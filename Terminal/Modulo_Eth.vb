Option Explicit On

Imports System.Net.Sockets

Module Modulo_Eth
    'Public ConexaoTCP As New TcpClient 'Cria nova conexão TCP
    'Dim iLinhaHist As Integer  'Índice de número de linha no histórico de envio/recebimento de textos
    'Dim sDadoRecebido As String 'Dado recebido concatenado (após timer, da stream Ethernet)
    'Dim sComando(4, 40) As String 'String para leitura de comando
    'Dim EthStream As NetworkStream 'Stream de Ethernet para verificação se dados foram recebidos

    'Public Sub test()
    '    'Subrotina que abre a porta Ethernet
    '    Dim iPortNum As Integer
    '    Dim sHostName As String
    '    Dim sMsgErro As String

    '    'Limpa mensagem de erro
    '    sMsgErro = ""
    '    'Lê da janela de configuração de comunicação, o número da porta e endereço para conexão TCP
    '    sHostName = dlgConfComunicacao.txtEndEthernet.Text
    '    iPortNum = Val(dlgConfComunicacao.txtPortaEthernet.Text)

    '    'Tenta abrir conexão TCP
    '    Try
    '        ConexaoTCP.Connect(sHostName, iPortNum)
    '        EthStream = ConexaoTCP.GetStream()
    '    Catch ex As Exception
    '        sMsgErro = ex.Message
    '    End Try

    'End Sub
    
End Module
