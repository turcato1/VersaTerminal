
Public Class frmCalculadora

    Private Sub btnCalcSumCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcSumCheck.Click
        'Calcula o Sum Check, quando pressionado botão "Sum Check/LRC"
        Dim sString As String 'String plena, convertida da string com códigos < > da caixa de texto
        Dim i As Integer      'Indice para instrução FOR
        Dim lSum As Long      'Somatório (SumCheck) dos caracteres em formato long inteiro
        Dim sSum As String    'Sum Check convertido para string

        sString = StrCodToStrPl(txtStrEntrCalc.Text)

        'Calcula o check sum
        lSum = 0
        For i = 1 To Len(sString)
            'Soma os códigos ASCII de cada caractere da string
            lSum = lSum + Asc(Mid(sString, i, 1))
        Next
        sSum = Hex(lSum)
        'Exibe resultado do SumCheck na caixa de texto da calculadora
        txtStrSaidaCalc.Text = sSum
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Copia string da caixa de envio de frmPrincipal para a calculadora, se pressionado botão "<<"
        txtStrEntrCalc.Text = frmPrincipal.txtStringEnvio.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Copia o resultado da calculadora para a caixa de envio de frmPrincipal, se pressionado botão ">>"
        frmPrincipal.txtStringEnvio.Text = frmPrincipal.txtStringEnvio.Text & txtStrSaidaCalc.Text
    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        'Limpeza das caixas de texto, caso o botão "Limpa" for apertado
        txtStrEntrCalc.Clear()
        txtStrSaidaCalc.Clear()
    End Sub

    Private Sub btnASCIIToHex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnASCIIToHex.Click
        'Realiza conversão ASCII -> Hex
        Dim sStringIn As String  'String dos dados de entrada
        Dim sStringOut As String 'String do resultado da conversão
        Dim i As Integer         'Index para instrução FOR

        'Inicialização
        sStringOut = ""

        'Converte string codificada com < > em string plena (com caracteres de controle STX, ETX etc)
        sStringIn = StrCodToStrPl(txtStrEntrCalc.Text)
        'Extrai o código ASCII e converte para hexadecimal cada caractere
        For i = 1 To Len(sStringIn)
            sStringOut = sStringOut & Hex(Asc(Mid(sStringIn, i, 1)))
        Next
        'Exibe o resultado na caixa de texto
        txtStrSaidaCalc.Text = sStringOut
    End Sub

    Private Sub btnHexToASCII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHexToASCII.Click
        'Realiza conversão Hex -> ASCII
        Dim sStringIn As String  'String dos dados de entrada
        Dim sStringOut As String 'String do resultado da conversão
        Dim i As Integer         'Index para instrução FOR
        Dim bytCharCode As Byte  'Byte extraído da string de entrada
        'Dim iLSD As Integer     'Valor inteiro da conversão do dígito menos significativo de um par hexadecimal
        'Dim iMSD As Integer     'Valor inteiro da conversão do dígito mais significativo de um par hexadecimal

        'Inicialização
        sStringOut = ""

        'Cópia da string da caixa de texto para a string de uso da função
        sStringIn = txtStrEntrCalc.Text

        'O número de dígitos em hexa precisa ser par, ou seja, 230 (NOK) -> 0230 (OK)
        If (Len(sStringIn) Mod 2 = 0) Then
            'Conversão digito a dígito do hexa, se não houver erro (try)
            Try
                'Separa o digito mais significativo e menos significativo do byte de código de cada
                ' caracter a ser convertido
                For i = 1 To (Len(sStringIn) - 1) Step 2
                    bytCharCode = Convert.ToByte(Mid(sStringIn, i, 2), 16)
                    sStringOut = sStringOut & Chr(bytCharCode)
                    'Extrai os digitos de hexa e converte para decimal
                    'iLSD = DigitHexToInt(Mid(sStringIn, i + 1, 1))
                    'iMSD = DigitHexToInt(Mid(sStringIn, i, 1))
                    'Calcula o valor inteiro, com os dois dígitos convertidos
                    'sStringOut = sStringOut & Chr(iLSD + iMSD * 16)
                Next
                'Captura situação de erro na instrução de conversão do VB
            Catch ex As Exception
                MsgErro(3, ex.Message) 'Mensagem de erro se houver erro em alguma instrução VB
                sStringOut = ""
            End Try
            'Converte a string plena (com caracteres especiais) para string codificada com < > nos caracteres especiais
            txtStrSaidaCalc.Text = StrPlToStrCod(sStringOut)
        Else
            MsgErro(4, "") 'Mensagem de erro caso o número de digitos hexa não for par
        End If
    End Sub

    Private Sub frmCalculadora_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Atualiza status do item "Calculadora" marcado no menu suspenso de "Exibir" em frmPrincipal
        frmPrincipal.CalculadoraToolStripMenuItem.Checked = False
    End Sub

    Private Sub BtnBinToHex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBinToHex.Click
        'Calcula a conversão de binário para hexa
        Dim sStringIn As String  'String com os dados de entrada para conversão
        Dim i As Integer         'Index para instrução FOR
        Dim iSoma As Integer     'Soma do valor de cada bit para conversão Bin -> Int
        Dim iDigito As Integer   'Valor 0 ou 1 de cada dígito da string de bits
        Dim bBinario As Boolean  'Indica erro na conversão se for falso

        'Inicialização
        iSoma = 0
        bBinario = True

        'Cópia da string da caixa de texto para a string de uso da função
        sStringIn = txtStrEntrCalc.Text

        'Conversão digito a dígito do binário, se não houver erro (try)
        If (Len(sStringIn) Mod 4 = 0) Then
            Try
                For i = 1 To Len(sStringIn)
                    'Converte a string "0" e "1" para valor inteiro 0 e 1
                    iDigito = Val(Mid(sStringIn, i, 1))
                    'Calcula o somatório de cada casa binária para converter em valor inteiro
                    If (iDigito = 0 Or iDigito = 1) Then
                        iSoma = iSoma + iDigito * 2 ^ (Len(sStringIn) - i)
                    Else
                        'Se houver um dígito diferente de 0 ou 1, muda flag de erro de conversão
                        bBinario = False
                    End If
                Next
                'Se houver erro, captura a mensagem e exibe para o usuário
            Catch ex As Exception
                MsgErro(6, ex.Message) 'Mensagem de erro se houver erro em alguma instrução VB
            End Try

            'bBinario é verdadeiro se a conversão foi bem sucedida
            If bBinario Then
                txtStrSaidaCalc.Text = Hex(iSoma)
            Else
                MsgErro(7, "") 'Mensagem de erro se houver erro na conversão por dígitos diferentes de 0 ou 1
            End If
        Else
            MsgErro(5, "") 'Mensagem de erro se não houver dígitos em quantidade múltipla de 4 (ex: 0011 0010)
        End If
    End Sub

    Private Sub btnHexToBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHexToBin.Click
        'Calcula conversão de Hexa para Binário
        Dim sStringIn As String  'String de entrada de dados
        Dim sStringOut As String 'String com o resultado da conversão
        Dim i, j As Integer      'Index para instrução FOR
        Dim iDigito As Integer   'Digito extraído da string de entrada hexa, convertido para inteiro
        Dim iDivisao, iResto As Integer 'Resultado e Resto da divisão iterativa para encontrar bits da conversão binária
        Dim bHexa As Boolean     'Flag indicador de erro na conversão, se falso

        'Inicialização
        bHexa = True
        sStringOut = ""

        'Carrega string da caixa de texto na variável de entrada
        sStringIn = txtStrEntrCalc.Text

        'Conversão digito a dígito do hexa, se não houver erro (try)
        Try
            For i = 1 To Len(sStringIn)
                'Conversão de um dígito hexa em formato de caractere para valor inteiro
                iDigito = Convert.ToInt16(Mid(sStringIn, (Len(sStringIn) - i + 1), 1), 16)
                'Verifica se a conversão resultou em valor válido para um dígito (0 a 15)
                If (iDigito >= 0 And iDigito <= 15) Then
                    'Iguala os valores iDivisão a iDigito, devido à operação iterativa em cascata
                    iDivisao = iDigito
                    'Divide sucessivamente por 2 para encontrar cada bit da conversão para binário
                    For j = 0 To 2
                        iResto = iDivisao Mod 2
                        iDivisao = iDivisao \ 2
                        'Converte o valor obtido como resto para string e concatena à string existente (digitos já convertidos)
                        sStringOut = iResto.ToString & sStringOut
                        'Se é o último digito convertido, acrescenta o valor da divisão à string de restos
                        '(último digito de uma conversão binária por divisão sucessiva)
                        If j = 2 Then sStringOut = iDivisao.ToString & sStringOut
                    Next
                Else
                    'Muda flag de erro na conversão se ocorrer falha na instrução de conversão numérica do VB
                    bHexa = False
                End If
            Next
            'Captura mensagem de erro do VB
        Catch ex As Exception
            MsgErro(8, ex.Message) 'Mensagem de erro, caso haja erro em alguma instrução VB
        End Try

        'bHexa é verdadeiro se a conversão foi bem sucedida
        If bHexa Then
            'Exibe valor convertido na caixa de texto de saída
            txtStrSaidaCalc.Text = sStringOut
        Else
            MsgErro(9, "") 'Mensagem de erro de conversão não realizada
        End If
    End Sub

    Private Sub btnCalcCRC32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcCRC32.Click
        'Calcula CRC-32
        'TO BE DONE!!!!

        'Exemplo de código em C para calcular CRC-32:

        'unsigned int crc32(unsigned char *message) {
        'int i, j;
        'unsigned int byte, crc, mask;
        'i = 0;
        'crc = 0xFFFFFFFF;
        'while (message[i] != 0) {
        'byte = message[i]; // Get next byte.
        'crc = crc ^ byte;
        'for (j = 7; j >= 0; j--) { // Do eight times.
        'mask = -(crc & 1);
        'crc = (crc >> 1) ^ (0xEDB88320 & mask);
        '}
        'i = i + 1;
        '}
        'return ~crc;
        '}
    End Sub

    Private Sub btnCalcCRC16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcCRC16.Click
        'Calcula CRC-16
        'TO BE DONE!!!!
    End Sub
End Class