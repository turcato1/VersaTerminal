Module Biblioteca_Terminal
    'Biblioteca de funções usadas em diversos forms do programa

    Public Function CharToCode(ByVal sChar As Char) As String
        'Função que codifica um código de caracter correspondente em comandos entre < > 
        Select Case sChar
            Case Chr(&H1)
                CharToCode = "<SOH>"
            Case Chr(&H2)
                CharToCode = "<STX>"
            Case Chr(&H3)
                CharToCode = "<ETX>"
            Case Chr(&H4)
                CharToCode = "<EOT>"
            Case Chr(&H5)
                CharToCode = "<ENQ>"
            Case Chr(&H6)
                CharToCode = "<ACK>"
            Case Chr(&H7)
                CharToCode = "<BEL>"
            Case Chr(&H8)
                CharToCode = "<BS>"
            Case Chr(&H9)
                CharToCode = "<HT>"
            Case Chr(&HA)
                CharToCode = "<LF>"
            Case Chr(&HB)
                CharToCode = "<VT>"
            Case Chr(&HC)
                CharToCode = "<FF>"
            Case Chr(&HD)
                CharToCode = "<CR>"
            Case Chr(&HE)
                CharToCode = "<SO>"
            Case Chr(&HF)
                CharToCode = "<SI>"
            Case Chr(&H10)
                CharToCode = "<DLE>"
            Case Chr(&H11)
                CharToCode = "<DC1>"
            Case Chr(&H12)
                CharToCode = "<DC2>"
            Case Chr(&H13)
                CharToCode = "<DC3>"
            Case Chr(&H14)
                CharToCode = "<DC4>"
            Case Chr(&H15)
                CharToCode = "<NAK>"
            Case Chr(&H16)
                CharToCode = "<SYN>"
            Case Chr(&H17)
                CharToCode = "<ETB>"
            Case Chr(&H18)
                CharToCode = "<CAN>"
            Case Chr(&H19)
                CharToCode = "<EN>"
            Case Chr(&H1A)
                CharToCode = "<SUB>"
            Case Chr(&H1B)
                CharToCode = "<ESC>"
            Case Chr(&H1C)
                CharToCode = "<FS>"
            Case Chr(&H1D)
                CharToCode = "<GS>"
            Case Chr(&H1E)
                CharToCode = "<RS>"
            Case Chr(&H1F)
                CharToCode = "<US>"
            Case Chr(&H20)
                CharToCode = "<SPC>"
            Case Else
                CharToCode = vbNullChar
        End Select
    End Function

    Public Function CodeToChar(ByVal sCode As String) As Char
        'Função que decodifica comandos entre < > para o código de caracter correspondente
        Select Case sCode
            Case "<SOH>" '01h
                CodeToChar = Chr(&H1)
            Case "<STX>" '02h
                CodeToChar = Chr(&H2)
            Case "<ETX>" '03h
                CodeToChar = Chr(&H3)
            Case "<EOT>" '04h
                CodeToChar = Chr(&H4)
            Case "<ENQ>" '05h
                CodeToChar = Chr(&H5)
            Case "<ACK>" '06h
                CodeToChar = Chr(&H6)
            Case "<BEL>" '07h
                CodeToChar = Chr(&H7)
            Case "<BS>" '08h
                CodeToChar = Chr(&H8)
            Case "<HT>" '09h
                CodeToChar = Chr(&H9)
            Case "<LF>" '0Ah
                CodeToChar = Chr(&HA)
            Case "<VT>" '0Bh
                CodeToChar = Chr(&HB)
            Case "<FF>" '0Ch
                CodeToChar = Chr(&HC)
            Case "<CR>" '0Dh
                CodeToChar = Chr(&HD)
            Case "<SO>" '0Eh
                CodeToChar = Chr(&HE)
            Case "<SI>" '0Fh
                CodeToChar = Chr(&HF)
            Case "<DLE>" '10h
                CodeToChar = Chr(&H10)
            Case "<DC1>" '11h
                CodeToChar = Chr(&H11)
            Case "<DC2>" '12h
                CodeToChar = Chr(&H12)
            Case "<DC3>" '13h
                CodeToChar = Chr(&H13)
            Case "<DC4>" '14h
                CodeToChar = Chr(&H14)
            Case "<NAK>" '15h
                CodeToChar = Chr(&H15)
            Case "<SYN>" '16h
                CodeToChar = Chr(&H16)
            Case "<ETB>" '17h
                CodeToChar = Chr(&H17)
            Case "<CAN>" '18h
                CodeToChar = Chr(&H18)
            Case "<EN>" '19h
                CodeToChar = Chr(&H19)
            Case "<SUB>" '1Ah
                CodeToChar = Chr(&H1A)
            Case "<ESC>" '1Bh
                CodeToChar = Chr(&H1B)
            Case "<FS>" '1Ch
                CodeToChar = Chr(&H1C)
            Case "<GS>" '1Dh
                CodeToChar = Chr(&H1D)
            Case "<RS>" '1Eh
                CodeToChar = Chr(&H1E)
            Case "<US>" '1Fh
                CodeToChar = Chr(&H1F)
            Case "<SPC>" '20h
                CodeToChar = Chr(&H20)
            Case Else
                CodeToChar = vbNullChar
        End Select
    End Function

    Public Function StrCodToStrPl(ByVal sStringCod As String) As String
        'Função que converte uma string inteira com códigos entre < > para string plena
        Dim sStringTemp, sStringTemp2 As String 'Strings temporárias
        Dim cExtractChar As Char                'Caracter extraído da string completa
        Dim iContChar, iContChar2 As Integer    'Indexes para a instrução FOR

        'Inicialização de variáveis
        sStringTemp = ""
        sStringTemp2 = ""
        cExtractChar = vbNullChar
        iContChar = 0
        iContChar2 = 0

        'Tratamento da String de Envio (extração de códigos e conversão em caracteres especiais)
        For iContChar = 1 To Len(sStringCod)
            'Extrai caracter a caracter da string que foi copiada da caixa de texto do dado a ser enviado
            cExtractChar = Mid(sStringCod, iContChar, 1)
            ' Procura pelo caractere de inicio de código "<"
            If (cExtractChar = "<") Then
                'Inicialização do index e string temporária
                iContChar2 = 0
                sStringTemp = ""
                'Se "<" foi encontrado, extrai o conteudo entre os caracteres "<" e ">".
                Do Until ((cExtractChar = ">") Or (iContChar2 > 5) Or ((iContChar + iContChar2) > Len(sStringCod)))
                    cExtractChar = Mid(sStringCod, (iContChar + iContChar2), 1)
                    sStringTemp = sStringTemp & cExtractChar
                    iContChar2 = iContChar2 + 1
                Loop
                'Se não encontrar o caracter ">" ou o conteúdo entre "<" e ">" não for um código
                ' válido (CodeToChar = ""), copia a string original para sStringEnvio
                ' Se encontrar ">", decodifica o código em caractere especial
                If ((cExtractChar = ">") And (CodeToChar(sStringTemp) <> vbNullChar)) Then
                    sStringTemp2 = sStringTemp2 & CodeToChar(sStringTemp)
                Else
                    sStringTemp2 = sStringTemp2 & sStringTemp2
                End If
                iContChar = iContChar + (iContChar2 - 1)
            Else
                'Se o caractere "<" não foi encontrado, adiciona o caractere para sStringEnvio
                sStringTemp2 = sStringTemp2 + cExtractChar
            End If
        Next
        'Retorna string convertida como resultado da função
        StrCodToStrPl = sStringTemp2
    End Function

    Public Function StrPlToStrCod(ByVal sStringPl As String) As String
        'Função que converte uma string inteira plena para uma string com códigos entre < > 
        Dim iContChar As Integer 'Index para instrução FOR
        Dim sStringIn, sStringTempOut As String 'Strings temporárias
        Dim cExtractChar As Char 'Caractere extraído da string completa

        'Inicialização de variáveis
        sStringIn = sStringPl
        sStringTempOut = ""

        'Tratamento da String de Envio (extração de códigos e conversão em caracteres especiais)
        For iContChar = 1 To Len(sStringIn)
            cExtractChar = Mid(sStringIn, iContChar, 1)
            ' Procura por caracteres especiais (entre 01h a 20h)
            Select Case cExtractChar
                'Se um caractere especial for encontrado, substitui pelo código correspondente (CharToCode)
                Case Chr(&H1) To Chr(&H20)
                    sStringTempOut = sStringTempOut & CharToCode(cExtractChar)
                Case Else
                    sStringTempOut = sStringTempOut & cExtractChar
            End Select
        Next
        'Retorna string convertida como resultado da função
        StrPlToStrCod = sStringTempOut
    End Function

    Public Sub MsgErro(ByVal iCodErro As Integer, ByVal sDetalheErro As String)
        'Subrotina que exibe mensagem de erro com código
        Dim sMsg As String
        sMsg = ""
        'Seleciona o código de erro a ser exibido em caixa de mensagens (MsgBox)
        Select Case iCodErro

            'Erros relacionados à porta serial
            Case 1
                sMsg = "Erro ao abrir a porta serial."
            Case 2
                sMsg = "Erro ao fechar a porta serial."
            Case 3
                sMsg = "A seqüência Hex está com dígitos inadequados"
            Case 4
                sMsg = "A seqüência Hex está com número ímpar de dígitos " & vbCrLf & _
                       "Se o código ASCII for menor que 10h, preceda-o com zero" & vbCrLf & _
                       "(Ex.: 2h -> use 02)"
            Case 5
                sMsg = "A seqüência Bin têm quantidade de dígitos" & vbCrLf & _
                       "que não é múltipla de 4. Use zeros à frente" & vbCrLf & _
                       "para adequá-la (Ex.: 010b -> use 0010)"
            Case 6
                sMsg = "Erro na conversão Bin -> Hex"
            Case 7
                sMsg = "O número a ser convertido têm digitos diferentes de 0 ou 1"
            Case 8
                sMsg = "O número a ser convertido têm digitos diferentes de 0 a F"
            Case 9
                sMsg = "O número a ser convertido têm digitos diferentes de 0 a F"

                'Erros relacionados à porta Ethernet
            Case 11
                sMsg = "Erro ao abrir a porta Ethernet"
            Case 12
                sMsg = "Erro ao fechar a porta Ethernet"

                'Erros gerais de transmissão/recepção de dados
            Case 21
                sMsg = "A porta Serial ou Ethernet não está aberta"

                'Erros relacionados à escrita/leitura de arquivos de comandos
            Case 31
                sMsg = "Falha 31 na Leitura do Arquivo:" 'Falta cabeçalho
            Case 32
                sMsg = "Falha 32 na Leitura do Arquivo:" 'Falta ident. [
            Case 33
                sMsg = "Falha 33 na Leitura do Arquivo" 'Falta identif. C1~C4, END
            Case 34
                sMsg = "Falha 34 na Leitura do Arquivo" 'Falta ':'
            Case 35
                sMsg = "Falha 35 na Leitura do Arquivo" 'Falta ASCII 13h no final da linha de comando
            Case 36
                sMsg = "Falha 36 na Leitura do Arquivo" 'Falta '%' p/ linha de comando ou '[' do prox. comando

        End Select
        'Exibição da caixa de mensagem com detalhes do erro ocorrido
        MsgBox(sMsg & vbCrLf & sDetalheErro, MsgBoxStyle.Critical, "Erro Código" & Str(iCodErro))
    End Sub
End Module
