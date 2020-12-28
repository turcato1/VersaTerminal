Option Explicit On

Imports System.IO                 'Biblioteca de I/Os de Sistema
Imports System.Net.Sockets        'Biblioteca de Sockets Ethernet
Imports System.Threading          'Biblioteca de threads
Imports Terminal.dlgExibirOpcoes


Public Class frmPrincipal
    Dim iLinhaHist As Integer  'Índice de número de linha no histórico de envio/recebimento de textos
    Dim sDadoRecebido As String 'Dado recebido concatenado (após timer, da stream Ethernet)
    Public sComando(4, 40) As String 'Matriz com as strings dos comandos pre-programados
    Public EthStream As NetworkStream 'Stream de Ethernet para verificação se dados foram recebidos
    Public ConexaoTCP As New TcpClient 'Cria nova conexão TCP
    Public ConexaoUDP As New UdpClient 'Cria nova conexão UDP
    Public bUDPOpened As Boolean 'Indica que uma conexão UDP está disponível
    Dim iPortNum As Integer 'Número da porta UDP ou TCP
    Dim sHostName As String 'Nome do host (IP ou hostname)
    Dim ThreadRecebEth As New Thread(AddressOf SubTreadEth) 'Thread para leitura dos dados vindos de Ethernet
    Public Delegate Sub DelegarFrmPrinc(ByVal frmPrinc As Form) 'Delegate que faz com que treads externas modifiquem frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicialização de struct de opções do software com dados default
        OpcExibicao.FonteTextoHist = rchtxtDadosEnvRec.Font
        OpcExibicao.CorStringRec = Color.Blue
        OpcExibicao.CorStringEnv = Color.Black
        OpcExibicao.bExibirNumLinha = dlgExibirOpcoes.chkExibeNumLinha.Checked
        OpcExibicao.bExibirStringCod = dlgExibirOpcoes.chkExibeStringCod.Checked
        OpcExibicao.bExibirStringPlena = dlgExibirOpcoes.chkExibeStringPlena.Checked
        tmrDadReceb.Interval = dlgConfComunicacao.txtTempoAtrasoDadosReceb.Text
        'Atualiza barra de status inferior
        AtualizaStripStatus()
    End Sub

    Private Sub frmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Encerra aplicação, fechando todas as portas se alguma estiver aberta
        If ConexaoTCP.Connected Then FecharPortaEthernet()
        If SerialPort1.IsOpen Then FecharPorta()
    End Sub

    Public Sub SubTreadEth()
        'Subrotina cíclica executada como thread para verificação de dados recebidos via Ethernet
        Do
            'Se há dadados recebidos via Ethernet, atualiza informações recebidas na 
            'caixa de texto de histórico de dados
            If EthStream.DataAvailable Then
                'Executa procedure de outro thread (thread do frmPrincipal)
                Me.Invoke(New DelegarFrmPrinc(AddressOf AtualizaTxtHistorDados), New Object() {Me})
            End If
        Loop
    End Sub

    Public Sub AtualizaStripStatus()
        'Subrotina que atualiza dados na barra de status inferior (StripStatus)
        If dlgConfComunicacao.rdbSerial.Checked Then
            'Se selecionada porta serial, atualiza barra de status com configurações da porta serial
            With SerialPort1
                stslblTipoComun.Text = "Serial"
                stslblConfigComun.Text = .PortName.ToString & ": " & .BaudRate.ToString & ", " & _
                                         .DataBits.ToString & ", " & .Parity.ToString & ", " & _
                                         .StopBits.ToString
                If .IsOpen Then stslblStatusComun.Text = "Porta Aberta" Else stslblStatusComun.Text = "Porta Fechada"
            End With
        End If
        If dlgConfComunicacao.rdbEthernet.Checked Then
            'Se selecionada porta Ethernet, atualiza barra de status com configurações da Ethernet
            With dlgConfComunicacao
                stslblTipoComun.Text = "Ethernet"
                stslblConfigComun.Text = "Host: " & .txtEndEthernet.Text & _
                                         " Porta: " & .txtPortaEthernet.Text
                If ConexaoTCP.Connected Then stslblStatusComun.Text = "Conexão Aberta" Else stslblStatusComun.Text = "Conexão Fechada"
            End With
        End If
    End Sub

    Public Sub AtualizaIndicRX()
        'Pisca texto "RX" na barra de status
        stslblRX.BackColor = Color.Red
        tmrIndicRX.Enabled = True
    End Sub

    Public Sub AtualizaIndicTX()
        'Pisca texto "TX" na barra de status
        stslblTX.BackColor = Color.Red
        tmrIndicTX.Enabled = True
    End Sub

    Public Sub AbrirPorta()
        'Subrotina que abre a porta serial
        Dim sMsgErro As String 'String que contém detalhes de uma mensagem de erro

        'Limpa mensagem de erro
        sMsgErro = ""

        'Verifica se na janela de configuração de comunicação foi selecionada porta serial
        If (dlgConfComunicacao.rdbSerial.Checked) Then
            'Tenta abrir a porta serial
            Try
                SerialPort1.Open()
            Catch ex As Exception
                sMsgErro = ex.Message
            End Try

            'Se não houveram mensagens de erro ao abrir a porta serial, habilita operações do terminal
            If ((SerialPort1.IsOpen) And (sMsgErro = "")) Then
                AbrePortaToolStripMenuItem.Enabled = False    'Desabilita botão "Abre Porta" no menu
                FechaPortaToolStripMenuItem.Enabled = True    'Habilita botão "Fecha Porta" no menu
                ConfiguraçãoToolStripMenuItem.Enabled = False 'Habilita botão "Configuração" no menu
                tsbtnAbrirPorta.Enabled = False 'Desabilita botão "Abre Porta" na barra de ferramenta
                tsbtnFecharPorta.Enabled = True 'Habilita botão "Fecha Porta" na barra de ferramenta
                btnEnviar.Enabled = True        'Habilita botão "Enviar"
                grpSinaisSerial.Enabled = True  'Habilita leds de status dos sinais da porta serial
            Else
                'Se ocorreu um erro ao abrir a porta, desabilita operação do terminal 
                'e mostra mensagem de erro
                AbrePortaToolStripMenuItem.Enabled = True
                FechaPortaToolStripMenuItem.Enabled = False
                ConfiguraçãoToolStripMenuItem.Enabled = True
                tsbtnAbrirPorta.Enabled = True
                tsbtnFecharPorta.Enabled = False
                btnEnviar.Enabled = False
                grpSinaisSerial.Enabled = False
                MsgErro(1, sMsgErro) '"Erro ao abrir a porta serial"
            End If
        End If
        'Atualiza barra de status após a abertura da porta
        AtualizaStripStatus()
    End Sub

    Public Sub AbrirPortaEthernet()
        'Subrotina que abre a porta Ethernet
        Dim sMsgErro As String

        'Limpa mensagem de erro
        sMsgErro = ""
        'Lê da janela de configuração de comunicação, o número da porta e endereço para conexão TCP
        sHostName = dlgConfComunicacao.txtEndEthernet.Text
        iPortNum = Val(dlgConfComunicacao.txtPortaEthernet.Text)

        'Se selecionada conexão UDP, abre porta UDP
        If (dlgConfComunicacao.rdbUDP.Checked) Then
            bUDPOpened = False
            Try
                ConexaoUDP.Connect(sHostName, iPortNum)
            Catch exUDP As Exception
                sMsgErro = exUDP.Message
            End Try
            If (sMsgErro = "") Then
                bUDPOpened = True
                tmrDadReceb.Enabled = True
            End If
        End If

        'Se selecionada conexão TCP, abre porta TCP
        If (dlgConfComunicacao.rdbTCP.Checked) Then
            'Tenta abrir conexão TCP
            Try
                ConexaoTCP.Connect(sHostName, iPortNum)
                EthStream = ConexaoTCP.GetStream()
            Catch exTCP As Exception
                'Se houver erro, registra mensagem de erro na string "sMsgErro"
                sMsgErro = exTCP.Message
            End Try
        End If

        'Se não houveram mensagens de erro ao abrir a conexão TCP, habilita operações do terminal
        '( VIDE Sub "AbrirPorta" PARA DETALHES DOS ITENS ABAIXO NÃO COMENTADOS )
        If ((ConexaoTCP.Connected Or bUDPOpened) And (sMsgErro = "")) Then
            AbrePortaToolStripMenuItem.Enabled = False
            FechaPortaToolStripMenuItem.Enabled = True
            ConfiguraçãoToolStripMenuItem.Enabled = False
            tsbtnAbrirPorta.Enabled = False
            tsbtnFecharPorta.Enabled = True
            btnEnviar.Enabled = True
            If (ConexaoTCP.Connected) Then
                ThreadRecebEth.IsBackground = True  'Põe em background a thread de recebimento de dados via Ethernet
                ThreadRecebEth.Start()    'Inicia a thread de recebimento de dados via Ethernet
            End If
        Else
            'Se ocorreu um erro ao abrir a conexão, desabilita operação do terminal 
            'e mostra mensagem de erro
            AbrePortaToolStripMenuItem.Enabled = True
            FechaPortaToolStripMenuItem.Enabled = False
            ConfiguraçãoToolStripMenuItem.Enabled = True
            tsbtnAbrirPorta.Enabled = True
            tsbtnFecharPorta.Enabled = False
            btnEnviar.Enabled = False
            MsgErro(11, sMsgErro) '"Erro ao abrir a porta Ethernet"
        End If

        'Atualiza barra de status após a abertura da porta
        AtualizaStripStatus()
    End Sub

    Public Sub FecharPorta()
        'Subrotina que fecha a porta serial
        Dim sMsgErro As String

        sMsgErro = ""

        'Verifica se a porta serial foi selecionada e tenta fechar a porta serial
        If (dlgConfComunicacao.rdbSerial.Checked) Then
            Try
                'Fecha porta serial
                SerialPort1.Close()
                'Captura mensagens de erro ao fechar a porta
            Catch ex As Exception
                sMsgErro = ex.Message
            End Try
            'Atualiza habilitações da interface de frmPrincipal após o fechamento da porta
            '( VIDE Sub "AbrirPorta" PARA DETALHES DOS ITENS ABAIXO NÃO COMENTADOS )
            If ((Not (SerialPort1.IsOpen)) And (sMsgErro = "")) Then
                AbrePortaToolStripMenuItem.Enabled = True
                FechaPortaToolStripMenuItem.Enabled = False
                ConfiguraçãoToolStripMenuItem.Enabled = True
                tsbtnAbrirPorta.Enabled = True
                tsbtnFecharPorta.Enabled = False
                btnEnviar.Enabled = False
                grpSinaisSerial.Enabled = False
            Else
                btnEnviar.Enabled = False
                MsgErro(2, sMsgErro) '"Erro ao fechar a porta serial."
            End If
        End If
        'Atualiza barra de status
        AtualizaStripStatus()
    End Sub

    Public Sub FecharPortaEthernet()
        'Subrotina que abre a porta Ethernet
        Dim sMsgErro As String

        sMsgErro = ""
        'Verifica se a porta Ethernet foi selecionada e tenta fechar a porta Ethernet
        If (dlgConfComunicacao.rdbEthernet.Checked) Then

            'Fecha conexão UDP, se assim conectado
            If (bUDPOpened) Then
                Try
                    ConexaoUDP.Close()  'Fecha a porta Ethernet
                    'Captura mensagens de erro ocorridas no fechamento da porta
                Catch ex As Exception
                    sMsgErro = ex.Message
                End Try
                If sMsgErro = "" Then
                    bUDPOpened = False
                    tmrDadReceb.Enabled = False
                End If
            End If

            'Fecha conexão TCP, se assim conectado
            If (ConexaoTCP.Connected) Then
                Try
                    ThreadRecebEth.Abort() 'Encerra a thread de recebimento de dados
                    ConexaoTCP.Close()     'Fecha a porta Ethernet
                    'Captura mensagens de erro ocorridas no fechamento da porta
                Catch ex As Exception
                    sMsgErro = ex.Message
                End Try
            End If
            'Atualiza habilitações da interface de frmPrincipal após o fechamento da porta
            '( VIDE Sub "AbrirPorta" PARA DETALHES DOS ITENS ABAIXO NÃO COMENTADOS )
            If ((Not (SerialPort1.IsOpen)) And (sMsgErro = "")) Then
                AbrePortaToolStripMenuItem.Enabled = True
                FechaPortaToolStripMenuItem.Enabled = False
                ConfiguraçãoToolStripMenuItem.Enabled = True
                tsbtnAbrirPorta.Enabled = True
                tsbtnFecharPorta.Enabled = False
                btnEnviar.Enabled = False
                grpSinaisSerial.Enabled = False
            Else
                btnEnviar.Enabled = False
                MsgErro(12, sMsgErro) '"Erro ao fechar a porta Ethernet"
            End If
        End If
        'Atualiza barra de status
        AtualizaStripStatus()
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'Executa subrotina que dispara temporizador tmrDadReceb de acumulação/consolidação de dados recebidos via Serial
        Me.Invoke(New DelegarFrmPrinc(AddressOf DisparaTimerDadoRecebido), New Object() {Me})
    End Sub

    Private Sub SerialPort1_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs) Handles SerialPort1.PinChanged
        'Executa subrotina que dispara atualiza indicadores de sinais de handshake no formulário frmPrincipal
        Me.Invoke(New DelegarFrmPrinc(AddressOf AtualizaStatusSinais), New Object() {Me})
    End Sub

    Private Sub AtualizaStatusSinais()
        'Modifica o estado dos LEDs (check box) no grupo "grpSinaisSerial" de acordo com o sinal da RS-232 que alterou
        With SerialPort1
            If (.CDHolding) Then chkCD.CheckState = CheckState.Indeterminate Else chkCD.CheckState = CheckState.Unchecked
            If (.CtsHolding) Then chkCTS.CheckState = CheckState.Indeterminate Else chkCTS.Checked = CheckState.Unchecked
            If (.DsrHolding) Then chkDSR.CheckState = CheckState.Indeterminate Else chkDSR.Checked = CheckState.Unchecked
            If (.DtrEnable) Then chkDTR.CheckState = CheckState.Indeterminate Else chkDTR.Checked = CheckState.Unchecked
            If (.RtsEnable) Then chkRTS.CheckState = CheckState.Indeterminate Else chkRTS.Checked = CheckState.Unchecked
        End With
    End Sub

    Public Sub DisparaTimerDadoRecebido()
        'Subrotina que dispara o temporizador de acumulação/consolidação dos dados recebidos
        tmrDadReceb.Enabled = True
        'Pisca RX na barra de status
        AtualizaIndicRX()
    End Sub

    Private Sub AtualizaTxtHistorDados() 'AtualizaTxtDadosRecebidos()
        'Subrotina de atualização da caixa de texto de histórico de dados recebidos
        Dim sStringReceb As String 'String Recebida
        Dim sStringCod, sStringTempR2 As String 'Strings temporárias
        Dim byRecebEth(4096) As Byte 'Bytes recebidos via Ethernet
        Dim iLen, iLenInic, iTamEthStream As Integer 'Valores para tamanho de texto

        'Inicialização de variáveis
        sStringTempR2 = ""
        sStringCod = ""
        sStringReceb = ""
        iTamEthStream = 0

        'Se a conexão aberta é Ethernet, recebe dados da porta Ethernet, via stream da rede
        If dlgConfComunicacao.rdbEthernet.Checked Then
            'Pisca RX na barra de status, indicando que um dado chegou via Ethernet
            AtualizaIndicRX()
            If dlgConfComunicacao.rdbTCP.Checked Then
                'Captura dados recebidos via Ethernet para exibição no histórico
                ConexaoTCP.GetStream.Read(byRecebEth, 0, byRecebEth.Length)
                Do Until (byRecebEth(iTamEthStream) = 0 Or iTamEthStream >= 4096)
                    sStringReceb = sStringReceb & Chr(byRecebEth(iTamEthStream))
                    iTamEthStream = iTamEthStream + 1
                Loop
            End If
            If dlgConfComunicacao.rdbUDP.Checked Then
                sStringReceb = ConexaoUDP.Receive(New Net.IPEndPoint(Net.IPAddress.Any, 0)).ToString
            End If
        End If

        'Se a conexão aberta é serial, recebe dados da porta serial, via dados acumulados 
        'após tick do temporizador tmrDadReceb, disparado após detecção de dados recebidos via serial
        If dlgConfComunicacao.rdbSerial.Checked Then
            sStringReceb = sDadoRecebido
        End If

        'Converte String Plena para String Com Códigos entre < >
        sStringCod = StrPlToStrCod(sStringReceb)

        'Acrescenta no histórico de envio (rchtxtDadosEnvRec) última string enviada.
        If (Len(rchtxtDadosEnvRec.Text) = 0) Then
            iLinhaHist = 1
        Else
            iLinhaHist = iLinhaHist + 1
        End If

        'Escreve na caixa de texto: "'Num Linha': 'String com código < >'  'String com caracteres especiais'"
        'Usado função "AppendText" para que a rolagem de texto seja automática
        sStringTempR2 = ""
        'Monta string para histórico
        If OpcExibicao.bExibirNumLinha Then sStringTempR2 = sStringTempR2 & Str(iLinhaHist) & ": "
        If OpcExibicao.bExibirStringCod Then sStringTempR2 = sStringTempR2 & sStringCod & "   "
        If OpcExibicao.bExibirStringPlena Then sStringTempR2 = sStringTempR2 & sStringReceb
        'Pula para próxima linha
        sStringTempR2 = sStringTempR2 & vbCrLf
        iLenInic = rchtxtDadosEnvRec.TextLength 'Verifica o tamanho do texto existente
        rchtxtDadosEnvRec.AppendText(sStringTempR2) 'Acrescenta o texto novo ao histórico

        'Modificação da cor do texto de acordo com as opções escolhidas para exbição
        iLen = rchtxtDadosEnvRec.TextLength - iLenInic 'Calcula o tamanho do texto inserido
        rchtxtDadosEnvRec.SelectionStart = rchtxtDadosEnvRec.TextLength - iLen + 1 'Coloca o inicio da seleção no começo do texto inserido
        rchtxtDadosEnvRec.SelectionLength = iLen 'Define a seleção como sendo o tamanho do texto inserido
        rchtxtDadosEnvRec.SelectionColor = OpcExibicao.CorStringRec 'Modifica a cor do texto inserido
        rchtxtDadosEnvRec.ScrollToCaret() 'Rola o cursor para o fim do texto
    End Sub

    Public Sub EnviaString(ByVal sStringEnv As String)
        'Subrotina que executa o envio dos dados após disparo do envio e atualiza caixa de texto
        ' de histórico de dados recebidos e enviados
        Dim sStringEnvio As String
        Dim sMsgErro As String
        Dim sStringTemp, sStringTemp2 As String
        Dim iContChar, iLen, iLenInic As Integer
        Dim byStringEnvioByte(1024) As Byte

        'Copia a string da caixa de texto e inicializa a string de envio (sStringEnvio)
        sStringTemp = sStringEnv

        'Se selecionada a adição automática de retorno de carro ao fim de linha, adiciona CR e LF à string
        If chkAdicionaCrLfEnv.Checked Then sStringTemp = sStringTemp & "<CR>" & "<LF>"

        'Transforma string com códigos entre < > para string plena com caracteres ASCII
        sStringEnvio = StrCodToStrPl(sStringTemp)

        'Executa o envio se a porta serial ou Ethernet estiver aberta
        If ((SerialPort1.IsOpen) Or (ConexaoTCP.Connected) Or (bUDPOpened)) Then
            'Se a porta serial estiver aberta, transmite dados via porta serial
            AtualizaIndicTX()
            If (SerialPort1.IsOpen) Then SerialPort1.Write(sStringEnvio)
            'Se a porta Ethernet estiver aberta, transmite dados via porta Ethernet
            If (ConexaoTCP.Connected) Then
                'Converte string em vetor (array) de bytes para o envio para stream de rece
                For iContChar = 1 To Len(sStringEnvio)
                    byStringEnvioByte(iContChar - 1) = Asc(Mid(sStringEnvio, iContChar, 1))
                Next
                ConexaoTCP.GetStream.Write(byStringEnvioByte, 0, Len(sStringEnvio))
            End If

            If (bUDPOpened) Then
                sMsgErro = ""
                'Converte string em vetor (array) de bytes para o envio para stream de rece
                For iContChar = 1 To Len(sStringEnvio)
                    byStringEnvioByte(iContChar) = Asc(Mid(sStringEnvio, iContChar, 1))
                Next
                Try
                    ConexaoUDP.Send(byStringEnvioByte, Len(sStringEnvio), sHostName, iPortNum)
                Catch ex As Exception
                    sMsgErro = ex.Message
                End Try
                If sMsgErro <> "" Then MsgErro(25, sMsgErro)
            End If

            'Acrescenta no histórico de envio (rchtxtDadosEnvRec) última string enviada.
            If (Len(rchtxtDadosEnvRec.Text) = 0) Then
                iLinhaHist = 1
            Else
                iLinhaHist = iLinhaHist + 1
            End If

            'Escreve na caixa de texto: "Num Linha: String com código  String plena
            '(VIDE Sub AtualizaTxtHistorDados() PARA DETALHES SOBRE OS ITENS ABAIXO)
            sStringTemp2 = ""
            If OpcExibicao.bExibirNumLinha Then sStringTemp2 = sStringTemp2 & Str(iLinhaHist) & ": "
            If OpcExibicao.bExibirStringCod Then sStringTemp2 = sStringTemp2 & sStringTemp & "   "
            If OpcExibicao.bExibirStringPlena Then sStringTemp2 = sStringTemp2 & sStringEnvio
            sStringTemp2 = sStringTemp2 & vbCrLf
            iLenInic = rchtxtDadosEnvRec.TextLength
            rchtxtDadosEnvRec.AppendText(sStringTemp2)
            iLen = rchtxtDadosEnvRec.TextLength - iLenInic
            rchtxtDadosEnvRec.SelectionStart = rchtxtDadosEnvRec.TextLength - iLen + 1
            rchtxtDadosEnvRec.SelectionLength = iLen
            rchtxtDadosEnvRec.SelectionColor = OpcExibicao.CorStringEnv
            rchtxtDadosEnvRec.ScrollToCaret()
            If chkLimparTxtEnvio.Checked Then txtStringEnvio.Clear()
        Else
            MsgErro(21, "Dados não enviados!") 'Em caso de erro de envio, mostra caixa de mensagem com o erro
        End If
    End Sub

    Public Sub AtualizaComandosArquivo(ByVal sTexto As String)
        Dim cTemp1 As Char
        Dim iProcArquivo, iIndiceComando, iLinhaComando As Integer
        Dim bProssegue, bFim, bFimComandos As Boolean
        Dim sTemp1, sCabecalho As String

        'Inicialização de variáveis
        cTemp1 = ""
        sTemp1 = ""
        bFim = False
        bProssegue = True
        For iIndiceComando = 0 To 4
            For iLinhaComando = 0 To 39
                sComando(iIndiceComando, iLinhaComando) = ""
            Next
        Next
        iProcArquivo = iIndiceComando = 0

        dlgProgComandos.chkHabilitaComando1.Checked = False
        dlgProgComandos.chkHabilitaComando2.Checked = False
        dlgProgComandos.chkHabilitaComando3.Checked = False
        dlgProgComandos.chkHabilitaComando4.Checked = False

        btnComando1.Text = "Comando 1"
        btnComando2.Text = "Comando 2"
        btnComando3.Text = "Comando 3"
        btnComando4.Text = "Comando 4"

        dlgProgComandos.txtNomeComando1.Text = ""
        dlgProgComandos.txtNomeComando2.Text = ""
        dlgProgComandos.txtNomeComando3.Text = ""
        dlgProgComandos.txtNomeComando4.Text = ""

        dlgProgComandos.rtxtComando1.Text = ""
        dlgProgComandos.rtxtComando2.Text = ""
        dlgProgComandos.rtxtComando3.Text = ""
        dlgProgComandos.rtxtComando4.Text = ""

        'Verifica se o cabeçalho do arquivo corresponde a um arquivo de comandos
        sCabecalho = "[Comandos Terminal]"
        If (Mid(sTexto, 1, Len(sCabecalho)) = sCabecalho) Then
            bProssegue = True
        Else
            bProssegue = False
            MsgErro(31, "Arquivo Sem Cabeçalho!") 'Erro de arquivo sem cabeçalho
        End If

        iProcArquivo = Len(sCabecalho) + 1

        'Executa sequencia de leitura de todos os comandos
        Do Until ((bFim) Or (Not (bProssegue)) Or (iProcArquivo > Len(sTexto)))

            'Procura chave de identificação de comando "["
            If ((bProssegue) And (Not (bFim))) Then
                Do Until ((cTemp1 = "[") Or (iProcArquivo > Len(sTexto)))
                    cTemp1 = Mid(sTexto, iProcArquivo, 1)
                    iProcArquivo = iProcArquivo + 1
                Loop
                If iProcArquivo > Len(sTexto) Then
                    bProssegue = False
                    MsgErro(32, "Sem identificador de comando [") 'Sem identificador de comando [
                End If
            End If

            'Leitura do número do comando (1, 2, 3 ou 4) ou fim do arquivo [END]
            If ((bProssegue) And (Not (bFim))) Then
                sTemp1 = Mid(sTexto, iProcArquivo, 3)
                Select Case sTemp1
                    Case "C1:"
                        iIndiceComando = 1
                        btnComando1.Enabled = True
                        dlgProgComandos.chkHabilitaComando1.Checked = True
                    Case "C2:"
                        iIndiceComando = 2
                        btnComando2.Enabled = True
                        dlgProgComandos.chkHabilitaComando2.Checked = True
                    Case "C3:"
                        iIndiceComando = 3
                        btnComando3.Enabled = True
                        dlgProgComandos.chkHabilitaComando3.Checked = True
                    Case "C4:"
                        iIndiceComando = 4
                        btnComando4.Enabled = True
                        dlgProgComandos.chkHabilitaComando4.Checked = True
                    Case "END"
                        bFim = True
                    Case Else
                        bProssegue = False
                        MsgErro(33, "Falta identificador de comando C1:~C4: ou END")
                End Select
                iProcArquivo = iProcArquivo + 2
            End If

            ' Leitura do nome do comando
            If ((bProssegue) And (Not (bFim))) Then
                cTemp1 = Mid(sTexto, iProcArquivo, 1)
                sTemp1 = ""
                If (cTemp1 = ":") Then
                    iProcArquivo = iProcArquivo + 1
                    Do Until ((cTemp1 = "]") Or (iProcArquivo > Len(sTexto)))
                        cTemp1 = Mid(sTexto, iProcArquivo, 1)
                        If (cTemp1 <> "]") Then
                            sTemp1 = sTemp1 + cTemp1
                        End If
                        iProcArquivo = iProcArquivo + 1
                    Loop
                    If (iProcArquivo > Len(sTexto) + 1) Then
                        bProssegue = False
                        MsgErro(33, "Falta delimitador de identificação ] para comando")
                    Else
                        Select Case iIndiceComando
                            Case 1
                                dlgProgComandos.txtNomeComando1.Text = sTemp1
                                btnComando1.Text = "Comando 1" & vbCrLf & "[" & sTemp1 & "]"
                            Case 2
                                dlgProgComandos.txtNomeComando2.Text = sTemp1
                                btnComando2.Text = "Comando 2" & vbCrLf & "[" & sTemp1 & "]"
                            Case 3
                                dlgProgComandos.txtNomeComando3.Text = sTemp1
                                btnComando3.Text = "Comando 3" & vbCrLf & "[" & sTemp1 & "]"
                            Case 4
                                dlgProgComandos.txtNomeComando4.Text = sTemp1
                                btnComando4.Text = "Comando 4" & vbCrLf & "[" & sTemp1 & "]"
                        End Select
                    End If
                Else
                    bProssegue = False
                    MsgErro(34, "Falta ':' após número do comando")
                End If
            End If

            ' Leitura dos comandos
            If ((bProssegue) And (Not (bFim))) Then
                bFimComandos = False
                iLinhaComando = 1
                'Procura identificador de inicio de linha de comandos '%'
                Do Until (bFimComandos)
                    cTemp1 = ""
                    Do Until ((cTemp1 = "%") Or (cTemp1 = "[") Or (iProcArquivo > Len(sTexto)))
                        cTemp1 = Mid(sTexto, iProcArquivo, 1)
                        iProcArquivo = iProcArquivo + 1
                    Loop
                    'Verifica se há uma linha de comandos (%) ou próximo comando ([)
                    Select Case cTemp1
                        Case "%"
                            cTemp1 = ""
                            sTemp1 = ""
                            Do Until ((cTemp1 = vbCr) Or (iProcArquivo > Len(sTexto)))
                                cTemp1 = Mid(sTexto, iProcArquivo, 1)
                                If (cTemp1 <> vbCr) Then sTemp1 = sTemp1 & cTemp1
                                iProcArquivo = iProcArquivo + 1
                            Loop
                            If (cTemp1 = vbCr) Then
                                sComando(iIndiceComando, iLinhaComando) = sTemp1
                                iLinhaComando = iLinhaComando + 1
                                cTemp1 = ""
                            Else
                                bFimComandos = True
                                bProssegue = False
                                MsgErro(35, "Falta delimitador de linha de comando ASCII 13h" & vbCrLf & _
                                        "na linha " & Str(iLinhaComando) & ", comando " & _
                                        Str(iIndiceComando))
                            End If
                        Case "["
                            bFimComandos = True
                        Case Else
                            bFimComandos = True
                            bProssegue = False
                            MsgErro(36, "Falta identificador de linha de comando '%' " & vbCrLf & _
                                        "na linha " & Str(iLinhaComando) & ", comando " & _
                                        Str(iIndiceComando) & " ou identificador de próximo comando [")
                    End Select
                Loop
            End If
        Loop
    End Sub

    Private Sub btnSOH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSOH.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SOH>"
    End Sub

    Private Sub btnSTX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTX.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<STX>"
    End Sub

    Private Sub btnETX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETX.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<ETX>"
    End Sub

    Private Sub btnEOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEOT.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<EOT>"
    End Sub

    Private Sub btnENQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnENQ.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<ENQ>"
    End Sub

    Private Sub btnACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACK.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<ACK>"
    End Sub

    Private Sub btnBEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBEL.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<BEL>"
    End Sub

    Private Sub btnBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBS.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<BS>"
    End Sub

    Private Sub btnHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHT.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<HT>"
    End Sub

    Private Sub btnLF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLF.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<LF>"
    End Sub

    Private Sub btnVT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVT.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<VT>"
    End Sub

    Private Sub btnFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFF.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<FF>"
    End Sub

    Private Sub btnCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCR.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<CR>"
    End Sub

    Private Sub btnSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSO.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SO>"
    End Sub

    Private Sub btnSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSI.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SI>"
    End Sub

    Private Sub btnDLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDLE.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<DLE>"
    End Sub

    Private Sub btnDC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDC1.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<DC1>"
    End Sub

    Private Sub btnDC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDC2.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<DC2>"
    End Sub

    Private Sub btnDC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDC3.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<DC3>"
    End Sub

    Private Sub btnDC4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDC4.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<DC4>"
    End Sub

    Private Sub btnNAK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNAK.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<NAK>"
    End Sub

    Private Sub btnSYN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSYN.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SYN>"
    End Sub

    Private Sub btnETB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETB.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<ETB>"
    End Sub

    Private Sub btnCAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAN.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<CAN>"
    End Sub

    Private Sub btnEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEN.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<EN>"
    End Sub

    Private Sub btnSUB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSUB.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SUB>"
    End Sub

    Private Sub btnESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnESC.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<ESC>"
    End Sub

    Private Sub btnFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFS.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<FS>"
    End Sub

    Private Sub btnGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGS.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<GS>"
    End Sub

    Private Sub btnRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRS.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<RS>"
    End Sub

    Private Sub btnUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUS.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<US>"
    End Sub

    Private Sub btnSPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSPC.Click
        txtStringEnvio.Text = txtStringEnvio.Text & "<SPC>"
    End Sub

    Private Sub btnLimparEnviados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparEnviados.Click
        'Limpa histórico de dados
        rchtxtDadosEnvRec.Text = ""
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        'Envia texto pela porta selecionada, ao ser clicado o botão "Enviar"
        EnviaString(txtStringEnvio.Text)
    End Sub

    Private Sub btnComando1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComando1.Click
        'Dispara envio do comando 1 pré-programado
        Dim iLinha, iComando As Integer

        iLinha = 1
        iComando = 1
        Do Until ((sComando(iComando, iLinha) = "") Or (iLinha >= 40))
            EnviaString(sComando(iComando, iLinha))
            iLinha = iLinha + 1
        Loop

    End Sub

    Private Sub btnComando2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComando2.Click
        'Dispara envio do comando 2 pré-programado
        Dim iLinha, iComando As Integer

        iLinha = 1
        iComando = 2
        Do Until ((sComando(iComando, iLinha) = "") Or (iLinha >= 40))
            EnviaString(sComando(iComando, iLinha))
            iLinha = iLinha + 1
        Loop
    End Sub

    Private Sub btnComando3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComando3.Click
        'Dispara envio do comando 3 pré-programado
        Dim iLinha, iComando As Integer

        iLinha = 1
        iComando = 3
        Do Until ((sComando(iComando, iLinha) = "") Or (iLinha >= 40))
            EnviaString(sComando(iComando, iLinha))
            iLinha = iLinha + 1
        Loop
    End Sub

    Private Sub btnComando4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComando4.Click
        'Dispara envio do comando 4 pré-programado
        Dim iLinha, iComando As Integer

        iLinha = 1
        iComando = 4
        Do Until ((sComando(iComando, iLinha) = "") Or (iLinha >= 40))
            EnviaString(sComando(iComando, iLinha))
            iLinha = iLinha + 1
        Loop
    End Sub

    Private Sub AbrePortaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrePortaToolStripMenuItem.Click
        'Se foi selecionada comunicação via porta serial em dlgConfComunicacao, abre porta serial
        If (dlgConfComunicacao.rdbSerial.Checked) Then AbrirPorta()
        'Se foi selecionada comunicação via Ethernet em dlgConfComunicacao, abre porta Ethernet
        If (dlgConfComunicacao.rdbEthernet.Checked) Then AbrirPortaEthernet()
    End Sub

    Private Sub ConfiguraçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçãoToolStripMenuItem.Click
        'Chama janela de configuração de comunicação pelo menu suspenso
        dlgConfComunicacao.ShowDialog()
    End Sub

    Private Sub FechaPortaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaPortaToolStripMenuItem.Click
        'Chama subrotina que fecha porta serial/Ethernet, dependendo da seleção em dlgConfComunicacao
        If (dlgConfComunicacao.rdbSerial.Checked) Then FecharPorta()
        If (dlgConfComunicacao.rdbEthernet.Checked) Then FecharPortaEthernet()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        'Encerra aplicação, fechando todas as portas se alguma estiver aberta
        If ConexaoTCP.Connected Then FecharPortaEthernet()
        If SerialPort1.IsOpen Then FecharPorta()
        Application.Exit()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        'Ao clicar no menu suspenso, exibe a caixa "Sobre..."
        dlgAboutBox.ShowDialog()
    End Sub

    Private Sub ProgramarComandosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramarComandosToolStripMenuItem.Click
        'Ao clicar no menu suspenso, exibe janela de edição/criação de comandos
        dlgProgComandos.ShowDialog()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        'Ao clicar no menu suspenso, exibe janela de abertura de arquivos
        dlgOpenFile.ShowDialog()
    End Sub

    Private Sub ConfiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiToolStripMenuItem.Click
        'Ao clicar no menu suspenso, exibe janela de opções de exibição
        dlgExibirOpcoes.ShowDialog()
    End Sub

    Private Sub ComandosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComandosToolStripMenuItem1.Click
        'Ao clicar no menu suspenso, salva arquivo com comandos criados/modificados
        dlgSaveFileCmd.ShowDialog()
    End Sub

    Private Sub DadosRecebidosEnviadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DadosRecebidosEnviadosToolStripMenuItem.Click
        'Ao clicar no menu suspenso, salva arquivo com histótico de dados enviados/recebidos
        dlgSaveFileHist.ShowDialog()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        If CalculadoraToolStripMenuItem.Checked Then
            frmCalculadora.Show()
        Else
            frmCalculadora.Close()
        End If
    End Sub

    Private Sub dlgSaveFileHist_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgSaveFileHist.FileOk
        rchtxtDadosEnvRec.SaveFile(dlgSaveFileHist.FileName)
    End Sub

    Private Sub dlgSaveFileCmd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgSaveFileCmd.FileOk
        'Se pressionado 'OK' na janela de salvar arquivos, processar o salvamento do arquivo (comandos)
        Dim sCmdSalvarArquivo, sCaminhoArquivo As String
        Dim iLinhas As Integer

        sCaminhoArquivo = dlgSaveFileCmd.FileName
        sCmdSalvarArquivo = "[Comandos Terminal]" & vbCrLf & vbCrLf
        'Comandos para "Comando 1"
        If (dlgProgComandos.chkHabilitaComando1.Checked) Then
            With dlgProgComandos
                sCmdSalvarArquivo = sCmdSalvarArquivo & "[C1:" & .txtNomeComando1.Text & "]" & vbCrLf & vbCrLf
                iLinhas = 1
                Do Until (sComando(1, iLinhas) = "" Or iLinhas >= 40)
                    sCmdSalvarArquivo = sCmdSalvarArquivo & "%" & sComando(1, iLinhas) & vbCrLf
                    iLinhas = iLinhas + 1
                Loop
                sCmdSalvarArquivo = sCmdSalvarArquivo & vbCrLf
            End With
        End If
        'Comandos para "Comando 2"
        If (dlgProgComandos.chkHabilitaComando2.Checked) Then
            With dlgProgComandos
                sCmdSalvarArquivo = sCmdSalvarArquivo & "[C2:" & .txtNomeComando2.Text & "]" & vbCrLf & vbCrLf
                iLinhas = 1
                Do Until (sComando(2, iLinhas) = "" Or iLinhas >= 40)
                    sCmdSalvarArquivo = sCmdSalvarArquivo & "%" & sComando(2, iLinhas) & vbCrLf
                    iLinhas = iLinhas + 1
                Loop
                sCmdSalvarArquivo = sCmdSalvarArquivo & vbCrLf
            End With
        End If
        'Comandos para "Comando 3"
        If (dlgProgComandos.chkHabilitaComando3.Checked) Then
            With dlgProgComandos
                sCmdSalvarArquivo = sCmdSalvarArquivo & "[C3:" & .txtNomeComando3.Text & "]" & vbCrLf & vbCrLf
                iLinhas = 1
                Do Until (sComando(3, iLinhas) = "" Or iLinhas >= 40)
                    sCmdSalvarArquivo = sCmdSalvarArquivo & "%" & sComando(3, iLinhas) & vbCrLf
                    iLinhas = iLinhas + 1
                Loop
                sCmdSalvarArquivo = sCmdSalvarArquivo & vbCrLf
            End With
        End If
        'Comandos para "Comando 4"
        If (dlgProgComandos.chkHabilitaComando4.Checked) Then
            With dlgProgComandos
                sCmdSalvarArquivo = sCmdSalvarArquivo & "[C4:" & .txtNomeComando4.Text & "]" & vbCrLf & vbCrLf
                iLinhas = 1
                Do Until (sComando(4, iLinhas) = "" Or iLinhas >= 40)
                    sCmdSalvarArquivo = sCmdSalvarArquivo & "%" & sComando(4, iLinhas) & vbCrLf
                    iLinhas = iLinhas + 1
                Loop
                sCmdSalvarArquivo = sCmdSalvarArquivo & vbCrLf
            End With
        End If
        sCmdSalvarArquivo = sCmdSalvarArquivo & "[END]"
        My.Computer.FileSystem.WriteAllText(sCaminhoArquivo, sCmdSalvarArquivo, False)
    End Sub

    Private Sub dlgOpenFile_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgOpenFile.FileOk
        Dim sArquivoCmd As String
        'Se pressionado 'OK' na janela de abertura de arquivos, processar a abertura do arquivo (comandos)
        sArquivoCmd = My.Computer.FileSystem.ReadAllText(dlgOpenFile.FileName)
        AtualizaComandosArquivo(sArquivoCmd)
    End Sub

    Private Sub tsbtnAbrirPorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAbrirPorta.Click
        'Se foi selecionada comunicação via porta serial em dlgConfComunicacao, abre porta serial
        If (dlgConfComunicacao.rdbSerial.Checked) Then AbrirPorta()
        'Se foi selecionada comunicação via Ethernet em dlgConfComunicacao, abre porta Ethernet
        If (dlgConfComunicacao.rdbEthernet.Checked) Then AbrirPortaEthernet()
    End Sub

    Private Sub tsbtnFecharPorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnFecharPorta.Click
        'Se foi selecionada comunicação via porta serial em dlgConfComunicacao, abre porta serial
        If (dlgConfComunicacao.rdbSerial.Checked) Then FecharPorta()
        'Se foi selecionada comunicação via Ethernet em dlgConfComunicacao, abre porta Ethernet
        If (dlgConfComunicacao.rdbEthernet.Checked) Then FecharPortaEthernet()
    End Sub

    Private Sub tmrDadReceb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDadReceb.Tick

        'Se selecionada porta serial, ao atingir tick do temporizador, 
        'transfere para sDadoRecebido, 
        'todos os dados acumulados no buffer serial
        If dlgConfComunicacao.rdbSerial.Checked Then
            sDadoRecebido = SerialPort1.ReadExisting
            'Atualiza dados recebidos na caixa de texto de histórico
            AtualizaTxtHistorDados()
        End If

        'Ao atingir tick do temporizador, transfere para sDadoRecebido, 
        'todos os dados acumulados no buffer serial
        If ((dlgConfComunicacao.rdbEthernet.Checked) And (dlgConfComunicacao.rdbUDP.Checked)) Then
            If ConexaoUDP.Available > 0 Then
                AtualizaTxtHistorDados()
            End If
        End If
        'Cancela execução do temporizador (será ativado novamente quando próximo pacote de dados for recebido)
        tmrDadReceb.Enabled = False
    End Sub

    Private Sub tmrIndicTX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIndicTX.Tick
        'Recupera a mudança de cor de TX na barra de status após um período de tempo, 
        'de uma string enviada
        stslblTX.BackColor = Color.Silver
        tmrIndicTX.Enabled = False
    End Sub

    Private Sub tmrIndicRX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIndicRX.Tick
        'Recupera a mudança de cor de RX na barra de status após um período de tempo, 
        'de uma string recebida
        stslblRX.BackColor = Color.Silver
        tmrIndicRX.Enabled = False
    End Sub

    Private Sub LanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageToolStripMenuItem.Click

    End Sub
End Class
