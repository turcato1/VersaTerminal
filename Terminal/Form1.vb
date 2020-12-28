Option Explicit On

Public Class frmPrincipal
    Dim iLinhaEnv As Integer
    Dim iLinhaReceb As Integer

    Public Function CharToCode(ByVal sChar As Char) As String
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

    Public Sub TesteRecebe(ByVal sDadoRecebido As String)
        Dim sStringReceb As String
        Dim sStringTempR, sStringTempR2 As String
        Dim cExtractChar As Char
        Dim iContChar As Integer

        sStringTempR = sDadoRecebido
        sStringReceb = sDadoRecebido
        sStringTempR2 = ""

        'Tratamento da String de Envio (extração de códigos e conversão em caracteres especiais)
        For iContChar = 1 To Len(sStringTempR)
            cExtractChar = Mid(sStringTempR, iContChar, 1)
            ' Procura por caracteres especiais (entre 01h a 20h)
            Select Case cExtractChar
                'Se um caractere especial for encontrado, substitui pelo código correspondente (CharToCode)
                Case Chr(&H1) To Chr(&H20)
                    sStringTempR2 = sStringTempR2 & CharToCode(cExtractChar)
                Case Else
                    sStringTempR2 = sStringTempR2 & cExtractChar
            End Select
        Next

        'Acrescenta no histórico de envio (txtDadosEnviados) última string enviada.
        If (Len(txtDadosRecebidos.Text) = 0) Then
            iLinhaReceb = 1
        Else
            iLinhaReceb = iLinhaReceb + 1
        End If
        'Escreve na caixa de texto: "No Linha: String com código  (String com caracteres especiais)"
        ' Usado função "AppendText" para que a rolagem de texto seja automática
        txtDadosRecebidos.AppendText(Str(iLinhaReceb) & ": " & sStringTempR2 & "    (" & sStringReceb & ")" & vbCrLf)
    End Sub

    Private Sub btnConfiguraPorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraPorta.Click
        Dialog1.ShowDialog()
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
        txtDadosEnviados.Text = ""
    End Sub

    Private Sub btnLimparRecebidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparRecebidos.Click
        txtDadosRecebidos.Text = ""
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        TesteRecebe(SerialPort1.ReadExisting)
    End Sub

    Private Sub SerialPort1_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs) Handles SerialPort1.PinChanged
        'Modifica o estado dos LEDs (check box) no grupo "grpSinaisSerial" de acordo com o sinal da RS-232 que alterou
        With SerialPort1
            If (.CDHolding) Then chkCD.CheckState = CheckState.Indeterminate Else chkCD.CheckState = CheckState.Unchecked
            If (.CtsHolding) Then chkCTS.CheckState = CheckState.Indeterminate Else chkCTS.Checked = CheckState.Unchecked
            If (.DsrHolding) Then chkDSR.CheckState = CheckState.Indeterminate Else chkDSR.Checked = CheckState.Unchecked
            If (.DtrEnable) Then chkDTR.CheckState = CheckState.Indeterminate Else chkDTR.Checked = CheckState.Unchecked
            If (.RtsEnable) Then chkRTS.CheckState = CheckState.Indeterminate Else chkRTS.Checked = CheckState.Unchecked
        End With
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim sStringEnvio As String
        Dim sStringTemp, sStringTemp2 As String
        Dim cExtractChar As Char
        Dim iContChar, iContChar2 As Integer

        'Copia a string da caixa de texto e inicializa a string de envio (sStringEnvio)
        sStringTemp = txtStringEnvio.Text
        sStringEnvio = ""

        'Tratamento da String de Envio (extração de códigos e conversão em caracteres especiais)
        For iContChar = 1 To Len(sStringTemp)
            'Extrai caracter a caracter da string que foi copiada da caixa de texto do dado a ser enviado
            cExtractChar = Mid(sStringTemp, iContChar, 1)
            ' Procura pelo caractere de inicio de código "<"
            If (cExtractChar = "<") Then
                iContChar2 = 0
                sStringTemp2 = ""
                'Se "<" foi encontrado, extrai o conteudo entre os caracteres "<" e ">".
                Do Until ((cExtractChar = ">") Or (iContChar2 > 5) Or ((iContChar + iContChar2) > Len(sStringTemp)))
                    cExtractChar = Mid(sStringTemp, (iContChar + iContChar2), 1)
                    sStringTemp2 = sStringTemp2 & cExtractChar
                    iContChar2 = iContChar2 + 1
                Loop
                'Se não encontrar o caracter ">" ou o conteúdo entre "<" e ">" não for um código
                ' válido (CodeToChar = ""), copia a string original para sStringEnvio
                ' Se encontrar ">", decodifica o código em caractere especial
                If ((cExtractChar = ">") And (CodeToChar(sStringTemp2) <> vbNullChar)) Then
                    sStringEnvio = sStringEnvio & CodeToChar(sStringTemp2)
                Else
                    sStringEnvio = sStringEnvio & sStringTemp2
                End If
                iContChar = iContChar + (iContChar2 - 1)
            Else
                'Se o caractere "<" não foi encontrado, adiciona o caractere para sStringEnvio
                sStringEnvio = sStringEnvio + cExtractChar
            End If
        Next

        'SerialPort1.Write(sStringEnvio)

        TesteRecebe(sStringEnvio)

        'Acrescenta no histórico de envio (txtDadosEnviados) última string enviada.
        If (Len(txtDadosEnviados.Text) = 0) Then
            iLinhaEnv = 1
        Else
            iLinhaEnv = iLinhaEnv + 1
        End If
        'Escreve na caixa de texto: "No Linha: String com código  (String com caracteres especiais)"
        txtDadosEnviados.AppendText(Str(iLinhaEnv) & ": " + sStringTemp & "    (" & sStringEnvio & ")" & vbCrLf)
    End Sub

    Private Sub btnAbrePorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrePorta.Click
        'Tenta abrir a porta serial
        Try
            SerialPort1.Open()
        Catch ex As Exception
            If ((SerialPort1.IsOpen) And (ex.Message = "")) Then
                btnAbrePorta.Enabled = False
                btnFechaPorta.Enabled = True
                btnEnviar.Enabled = True
            Else
                btnAbrePorta.Enabled = True
                btnFechaPorta.Enabled = False
                btnEnviar.Enabled = False
                MsgBox("Erro ao abrir a porta serial." & vbCrLf & ex.Message, _
                   MsgBoxStyle.Critical, "Erro")
            End If
        End Try
    End Sub

    Private Sub btnFechaPorta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechaPorta.Click
        Try
            SerialPort1.Close()
        Catch ex As Exception
            If ((Not (SerialPort1.IsOpen)) And (ex.Message = "")) Then
                btnAbrePorta.Enabled = True
                btnFechaPorta.Enabled = False
                btnEnviar.Enabled = False
            Else
                btnAbrePorta.Enabled = False
                btnFechaPorta.Enabled = True
                btnEnviar.Enabled = False
                MsgBox("Erro ao fechar a porta serial." & vbCrLf & ex.Message, _
                   MsgBoxStyle.Critical, "Erro")
            End If
        End Try
    End Sub

    Private Sub btnCalcSumCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcSumCheck.Click
        Dim sString As String
        Dim i As Integer
        Dim lSum As Long
        Dim sSum As String

        sString = txtStrEntrCalc.Text

        'Calcula o check sum
        lSum = 0
        For i = 1 To Len(sString)
            lSum = lSum + Asc(Mid(sString, i, 1))
        Next

        sSum = Hex$(lSum)

        txtStrSaidaCalc.Text = sSum

    End Sub

    Private Sub btnCalcCRC16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcCRC16.Click

    End Sub
End Class
