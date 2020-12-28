<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnConfiguraPorta = New System.Windows.Forms.Button
        Me.btnAbrePorta = New System.Windows.Forms.Button
        Me.btnFechaPorta = New System.Windows.Forms.Button
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtStringEnvio = New System.Windows.Forms.TextBox
        Me.lblStringEnviar = New System.Windows.Forms.Label
        Me.lblDadoRecebido = New System.Windows.Forms.Label
        Me.txtDadosRecebidos = New System.Windows.Forms.TextBox
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.btnSOH = New System.Windows.Forms.Button
        Me.btnSTX = New System.Windows.Forms.Button
        Me.btnETX = New System.Windows.Forms.Button
        Me.btnEOT = New System.Windows.Forms.Button
        Me.btnBS = New System.Windows.Forms.Button
        Me.btnBEL = New System.Windows.Forms.Button
        Me.btnACK = New System.Windows.Forms.Button
        Me.btnENQ = New System.Windows.Forms.Button
        Me.btnFS = New System.Windows.Forms.Button
        Me.btnESC = New System.Windows.Forms.Button
        Me.btnSUB = New System.Windows.Forms.Button
        Me.btnEN = New System.Windows.Forms.Button
        Me.btnFF = New System.Windows.Forms.Button
        Me.btnVT = New System.Windows.Forms.Button
        Me.btnLF = New System.Windows.Forms.Button
        Me.btnHT = New System.Windows.Forms.Button
        Me.btnDLE = New System.Windows.Forms.Button
        Me.btnSI = New System.Windows.Forms.Button
        Me.btnSO = New System.Windows.Forms.Button
        Me.btnCR = New System.Windows.Forms.Button
        Me.btnSPC = New System.Windows.Forms.Button
        Me.btnUS = New System.Windows.Forms.Button
        Me.btnRS = New System.Windows.Forms.Button
        Me.btnGS = New System.Windows.Forms.Button
        Me.btnDC4 = New System.Windows.Forms.Button
        Me.btnDC3 = New System.Windows.Forms.Button
        Me.btnDC2 = New System.Windows.Forms.Button
        Me.btnDC1 = New System.Windows.Forms.Button
        Me.btnCAN = New System.Windows.Forms.Button
        Me.btnETB = New System.Windows.Forms.Button
        Me.btnSYN = New System.Windows.Forms.Button
        Me.btnNAK = New System.Windows.Forms.Button
        Me.lblDadosEnviados = New System.Windows.Forms.Label
        Me.txtDadosEnviados = New System.Windows.Forms.TextBox
        Me.txtStrEntrCalc = New System.Windows.Forms.TextBox
        Me.btnCalcSumCheck = New System.Windows.Forms.Button
        Me.btnCalcCRC16 = New System.Windows.Forms.Button
        Me.btnCalcCRC32 = New System.Windows.Forms.Button
        Me.lblSeta1 = New System.Windows.Forms.Label
        Me.lblSeta2 = New System.Windows.Forms.Label
        Me.txtStrSaidaCalc = New System.Windows.Forms.TextBox
        Me.btnLimparEnviados = New System.Windows.Forms.Button
        Me.btnLimparRecebidos = New System.Windows.Forms.Button
        Me.grpSinaisSerial = New System.Windows.Forms.GroupBox
        Me.chkRTS = New System.Windows.Forms.CheckBox
        Me.chkDTR = New System.Windows.Forms.CheckBox
        Me.chkDSR = New System.Windows.Forms.CheckBox
        Me.chkCTS = New System.Windows.Forms.CheckBox
        Me.chkCD = New System.Windows.Forms.CheckBox
        Me.grpSinaisSerial.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfiguraPorta
        '
        Me.btnConfiguraPorta.Location = New System.Drawing.Point(23, 33)
        Me.btnConfiguraPorta.Name = "btnConfiguraPorta"
        Me.btnConfiguraPorta.Size = New System.Drawing.Size(112, 27)
        Me.btnConfiguraPorta.TabIndex = 0
        Me.btnConfiguraPorta.Text = "Configurar Porta"
        Me.btnConfiguraPorta.UseVisualStyleBackColor = True
        '
        'btnAbrePorta
        '
        Me.btnAbrePorta.Location = New System.Drawing.Point(141, 33)
        Me.btnAbrePorta.Name = "btnAbrePorta"
        Me.btnAbrePorta.Size = New System.Drawing.Size(112, 27)
        Me.btnAbrePorta.TabIndex = 1
        Me.btnAbrePorta.Text = "Abre Porta"
        Me.btnAbrePorta.UseVisualStyleBackColor = True
        '
        'btnFechaPorta
        '
        Me.btnFechaPorta.Enabled = False
        Me.btnFechaPorta.Location = New System.Drawing.Point(259, 33)
        Me.btnFechaPorta.Name = "btnFechaPorta"
        Me.btnFechaPorta.Size = New System.Drawing.Size(112, 27)
        Me.btnFechaPorta.TabIndex = 2
        Me.btnFechaPorta.Text = "Fecha Porta"
        Me.btnFechaPorta.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        '
        'txtStringEnvio
        '
        Me.txtStringEnvio.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStringEnvio.Location = New System.Drawing.Point(21, 241)
        Me.txtStringEnvio.Name = "txtStringEnvio"
        Me.txtStringEnvio.Size = New System.Drawing.Size(764, 26)
        Me.txtStringEnvio.TabIndex = 3
        '
        'lblStringEnviar
        '
        Me.lblStringEnviar.AutoSize = True
        Me.lblStringEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStringEnviar.Location = New System.Drawing.Point(27, 225)
        Me.lblStringEnviar.Name = "lblStringEnviar"
        Me.lblStringEnviar.Size = New System.Drawing.Size(94, 13)
        Me.lblStringEnviar.TabIndex = 4
        Me.lblStringEnviar.Text = "String a enviar:"
        '
        'lblDadoRecebido
        '
        Me.lblDadoRecebido.AutoSize = True
        Me.lblDadoRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDadoRecebido.Location = New System.Drawing.Point(27, 429)
        Me.lblDadoRecebido.Name = "lblDadoRecebido"
        Me.lblDadoRecebido.Size = New System.Drawing.Size(94, 13)
        Me.lblDadoRecebido.TabIndex = 6
        Me.lblDadoRecebido.Text = "Dado recebido:"
        '
        'txtDadosRecebidos
        '
        Me.txtDadosRecebidos.BackColor = System.Drawing.SystemColors.Window
        Me.txtDadosRecebidos.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDadosRecebidos.Location = New System.Drawing.Point(21, 445)
        Me.txtDadosRecebidos.Multiline = True
        Me.txtDadosRecebidos.Name = "txtDadosRecebidos"
        Me.txtDadosRecebidos.ReadOnly = True
        Me.txtDadosRecebidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDadosRecebidos.Size = New System.Drawing.Size(764, 114)
        Me.txtDadosRecebidos.TabIndex = 5
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(791, 240)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(72, 27)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnSOH
        '
        Me.btnSOH.Location = New System.Drawing.Point(21, 87)
        Me.btnSOH.Name = "btnSOH"
        Me.btnSOH.Size = New System.Drawing.Size(47, 34)
        Me.btnSOH.TabIndex = 8
        Me.btnSOH.Text = "SOH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(01h)"
        Me.btnSOH.UseVisualStyleBackColor = True
        '
        'btnSTX
        '
        Me.btnSTX.Location = New System.Drawing.Point(74, 87)
        Me.btnSTX.Name = "btnSTX"
        Me.btnSTX.Size = New System.Drawing.Size(47, 34)
        Me.btnSTX.TabIndex = 9
        Me.btnSTX.Text = "STX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(02h)"
        Me.btnSTX.UseVisualStyleBackColor = True
        '
        'btnETX
        '
        Me.btnETX.Location = New System.Drawing.Point(127, 87)
        Me.btnETX.Name = "btnETX"
        Me.btnETX.Size = New System.Drawing.Size(47, 34)
        Me.btnETX.TabIndex = 10
        Me.btnETX.Text = "ETX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(03h)"
        Me.btnETX.UseVisualStyleBackColor = True
        '
        'btnEOT
        '
        Me.btnEOT.Location = New System.Drawing.Point(180, 87)
        Me.btnEOT.Name = "btnEOT"
        Me.btnEOT.Size = New System.Drawing.Size(47, 34)
        Me.btnEOT.TabIndex = 11
        Me.btnEOT.Text = "EOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(04h)"
        Me.btnEOT.UseVisualStyleBackColor = True
        '
        'btnBS
        '
        Me.btnBS.Location = New System.Drawing.Point(392, 87)
        Me.btnBS.Name = "btnBS"
        Me.btnBS.Size = New System.Drawing.Size(47, 34)
        Me.btnBS.TabIndex = 15
        Me.btnBS.Text = "BS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(08h)"
        Me.btnBS.UseVisualStyleBackColor = True
        '
        'btnBEL
        '
        Me.btnBEL.Location = New System.Drawing.Point(339, 87)
        Me.btnBEL.Name = "btnBEL"
        Me.btnBEL.Size = New System.Drawing.Size(47, 34)
        Me.btnBEL.TabIndex = 14
        Me.btnBEL.Text = "BEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(07h)"
        Me.btnBEL.UseVisualStyleBackColor = True
        '
        'btnACK
        '
        Me.btnACK.Location = New System.Drawing.Point(286, 87)
        Me.btnACK.Name = "btnACK"
        Me.btnACK.Size = New System.Drawing.Size(47, 34)
        Me.btnACK.TabIndex = 13
        Me.btnACK.Text = "ACK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(06h)"
        Me.btnACK.UseVisualStyleBackColor = True
        '
        'btnENQ
        '
        Me.btnENQ.Location = New System.Drawing.Point(233, 87)
        Me.btnENQ.Name = "btnENQ"
        Me.btnENQ.Size = New System.Drawing.Size(47, 34)
        Me.btnENQ.TabIndex = 12
        Me.btnENQ.Text = "ENQ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(05h)"
        Me.btnENQ.UseVisualStyleBackColor = True
        '
        'btnFS
        '
        Me.btnFS.Location = New System.Drawing.Point(604, 127)
        Me.btnFS.Name = "btnFS"
        Me.btnFS.Size = New System.Drawing.Size(47, 34)
        Me.btnFS.TabIndex = 19
        Me.btnFS.Text = "FS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Ch)"
        Me.btnFS.UseVisualStyleBackColor = True
        '
        'btnESC
        '
        Me.btnESC.Location = New System.Drawing.Point(551, 127)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(47, 34)
        Me.btnESC.TabIndex = 18
        Me.btnESC.Text = "ESC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Bh)"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'btnSUB
        '
        Me.btnSUB.Location = New System.Drawing.Point(498, 127)
        Me.btnSUB.Name = "btnSUB"
        Me.btnSUB.Size = New System.Drawing.Size(47, 34)
        Me.btnSUB.TabIndex = 17
        Me.btnSUB.Text = "SUB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Ah)"
        Me.btnSUB.UseVisualStyleBackColor = True
        '
        'btnEN
        '
        Me.btnEN.Location = New System.Drawing.Point(445, 127)
        Me.btnEN.Name = "btnEN"
        Me.btnEN.Size = New System.Drawing.Size(47, 34)
        Me.btnEN.TabIndex = 16
        Me.btnEN.Text = "EN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(19h)"
        Me.btnEN.UseVisualStyleBackColor = True
        '
        'btnFF
        '
        Me.btnFF.Location = New System.Drawing.Point(604, 87)
        Me.btnFF.Name = "btnFF"
        Me.btnFF.Size = New System.Drawing.Size(47, 34)
        Me.btnFF.TabIndex = 23
        Me.btnFF.Text = "FF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Ch)"
        Me.btnFF.UseVisualStyleBackColor = True
        '
        'btnVT
        '
        Me.btnVT.Location = New System.Drawing.Point(551, 87)
        Me.btnVT.Name = "btnVT"
        Me.btnVT.Size = New System.Drawing.Size(47, 34)
        Me.btnVT.TabIndex = 22
        Me.btnVT.Text = "VT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Bh)"
        Me.btnVT.UseVisualStyleBackColor = True
        '
        'btnLF
        '
        Me.btnLF.Location = New System.Drawing.Point(498, 87)
        Me.btnLF.Name = "btnLF"
        Me.btnLF.Size = New System.Drawing.Size(47, 34)
        Me.btnLF.TabIndex = 21
        Me.btnLF.Text = "LF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Ah)"
        Me.btnLF.UseVisualStyleBackColor = True
        '
        'btnHT
        '
        Me.btnHT.Location = New System.Drawing.Point(445, 87)
        Me.btnHT.Name = "btnHT"
        Me.btnHT.Size = New System.Drawing.Size(47, 34)
        Me.btnHT.TabIndex = 20
        Me.btnHT.Text = "HT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(09h)"
        Me.btnHT.UseVisualStyleBackColor = True
        '
        'btnDLE
        '
        Me.btnDLE.Location = New System.Drawing.Point(816, 87)
        Me.btnDLE.Name = "btnDLE"
        Me.btnDLE.Size = New System.Drawing.Size(47, 34)
        Me.btnDLE.TabIndex = 27
        Me.btnDLE.Text = "DLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(10h)"
        Me.btnDLE.UseVisualStyleBackColor = True
        '
        'btnSI
        '
        Me.btnSI.Location = New System.Drawing.Point(763, 87)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(47, 34)
        Me.btnSI.TabIndex = 26
        Me.btnSI.Text = "SI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Fh)"
        Me.btnSI.UseVisualStyleBackColor = True
        '
        'btnSO
        '
        Me.btnSO.Location = New System.Drawing.Point(710, 87)
        Me.btnSO.Name = "btnSO"
        Me.btnSO.Size = New System.Drawing.Size(47, 34)
        Me.btnSO.TabIndex = 25
        Me.btnSO.Text = "SO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Eh)"
        Me.btnSO.UseVisualStyleBackColor = True
        '
        'btnCR
        '
        Me.btnCR.Location = New System.Drawing.Point(657, 87)
        Me.btnCR.Name = "btnCR"
        Me.btnCR.Size = New System.Drawing.Size(47, 34)
        Me.btnCR.TabIndex = 24
        Me.btnCR.Text = "CR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Dh)"
        Me.btnCR.UseVisualStyleBackColor = True
        '
        'btnSPC
        '
        Me.btnSPC.Location = New System.Drawing.Point(816, 127)
        Me.btnSPC.Name = "btnSPC"
        Me.btnSPC.Size = New System.Drawing.Size(47, 34)
        Me.btnSPC.TabIndex = 31
        Me.btnSPC.Text = "SPC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(20h)"
        Me.btnSPC.UseVisualStyleBackColor = True
        '
        'btnUS
        '
        Me.btnUS.Location = New System.Drawing.Point(763, 127)
        Me.btnUS.Name = "btnUS"
        Me.btnUS.Size = New System.Drawing.Size(47, 34)
        Me.btnUS.TabIndex = 30
        Me.btnUS.Text = "US" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Fh)"
        Me.btnUS.UseVisualStyleBackColor = True
        '
        'btnRS
        '
        Me.btnRS.Location = New System.Drawing.Point(710, 127)
        Me.btnRS.Name = "btnRS"
        Me.btnRS.Size = New System.Drawing.Size(47, 34)
        Me.btnRS.TabIndex = 29
        Me.btnRS.Text = "RS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Eh)"
        Me.btnRS.UseVisualStyleBackColor = True
        '
        'btnGS
        '
        Me.btnGS.Location = New System.Drawing.Point(657, 127)
        Me.btnGS.Name = "btnGS"
        Me.btnGS.Size = New System.Drawing.Size(47, 34)
        Me.btnGS.TabIndex = 28
        Me.btnGS.Text = "GS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Dh)"
        Me.btnGS.UseVisualStyleBackColor = True
        '
        'btnDC4
        '
        Me.btnDC4.Location = New System.Drawing.Point(180, 127)
        Me.btnDC4.Name = "btnDC4"
        Me.btnDC4.Size = New System.Drawing.Size(47, 34)
        Me.btnDC4.TabIndex = 35
        Me.btnDC4.Text = "DC4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(14h)"
        Me.btnDC4.UseVisualStyleBackColor = True
        '
        'btnDC3
        '
        Me.btnDC3.Location = New System.Drawing.Point(127, 127)
        Me.btnDC3.Name = "btnDC3"
        Me.btnDC3.Size = New System.Drawing.Size(47, 34)
        Me.btnDC3.TabIndex = 34
        Me.btnDC3.Text = "DC3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(13h)"
        Me.btnDC3.UseVisualStyleBackColor = True
        '
        'btnDC2
        '
        Me.btnDC2.Location = New System.Drawing.Point(74, 127)
        Me.btnDC2.Name = "btnDC2"
        Me.btnDC2.Size = New System.Drawing.Size(47, 34)
        Me.btnDC2.TabIndex = 33
        Me.btnDC2.Text = "DC2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(12h)"
        Me.btnDC2.UseVisualStyleBackColor = True
        '
        'btnDC1
        '
        Me.btnDC1.Location = New System.Drawing.Point(21, 127)
        Me.btnDC1.Name = "btnDC1"
        Me.btnDC1.Size = New System.Drawing.Size(47, 34)
        Me.btnDC1.TabIndex = 32
        Me.btnDC1.Text = "DC1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(11h)"
        Me.btnDC1.UseVisualStyleBackColor = True
        '
        'btnCAN
        '
        Me.btnCAN.Location = New System.Drawing.Point(392, 127)
        Me.btnCAN.Name = "btnCAN"
        Me.btnCAN.Size = New System.Drawing.Size(47, 34)
        Me.btnCAN.TabIndex = 39
        Me.btnCAN.Text = "CAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(18h)"
        Me.btnCAN.UseVisualStyleBackColor = True
        '
        'btnETB
        '
        Me.btnETB.Location = New System.Drawing.Point(339, 127)
        Me.btnETB.Name = "btnETB"
        Me.btnETB.Size = New System.Drawing.Size(47, 34)
        Me.btnETB.TabIndex = 38
        Me.btnETB.Text = "ETB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(17h)"
        Me.btnETB.UseVisualStyleBackColor = True
        '
        'btnSYN
        '
        Me.btnSYN.Location = New System.Drawing.Point(286, 127)
        Me.btnSYN.Name = "btnSYN"
        Me.btnSYN.Size = New System.Drawing.Size(47, 34)
        Me.btnSYN.TabIndex = 37
        Me.btnSYN.Text = "SYN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(16h)"
        Me.btnSYN.UseVisualStyleBackColor = True
        '
        'btnNAK
        '
        Me.btnNAK.Location = New System.Drawing.Point(233, 127)
        Me.btnNAK.Name = "btnNAK"
        Me.btnNAK.Size = New System.Drawing.Size(47, 34)
        Me.btnNAK.TabIndex = 36
        Me.btnNAK.Text = "NAK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(15h)"
        Me.btnNAK.UseVisualStyleBackColor = True
        '
        'lblDadosEnviados
        '
        Me.lblDadosEnviados.AutoSize = True
        Me.lblDadosEnviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDadosEnviados.Location = New System.Drawing.Point(27, 279)
        Me.lblDadosEnviados.Name = "lblDadosEnviados"
        Me.lblDadosEnviados.Size = New System.Drawing.Size(102, 13)
        Me.lblDadosEnviados.TabIndex = 41
        Me.lblDadosEnviados.Text = "Dados enviados:"
        '
        'txtDadosEnviados
        '
        Me.txtDadosEnviados.BackColor = System.Drawing.SystemColors.Window
        Me.txtDadosEnviados.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDadosEnviados.Location = New System.Drawing.Point(21, 295)
        Me.txtDadosEnviados.Multiline = True
        Me.txtDadosEnviados.Name = "txtDadosEnviados"
        Me.txtDadosEnviados.ReadOnly = True
        Me.txtDadosEnviados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDadosEnviados.Size = New System.Drawing.Size(764, 114)
        Me.txtDadosEnviados.TabIndex = 5
        '
        'txtStrEntrCalc
        '
        Me.txtStrEntrCalc.Location = New System.Drawing.Point(54, 186)
        Me.txtStrEntrCalc.Name = "txtStrEntrCalc"
        Me.txtStrEntrCalc.Size = New System.Drawing.Size(221, 20)
        Me.txtStrEntrCalc.TabIndex = 42
        '
        'btnCalcSumCheck
        '
        Me.btnCalcSumCheck.Location = New System.Drawing.Point(303, 178)
        Me.btnCalcSumCheck.Name = "btnCalcSumCheck"
        Me.btnCalcSumCheck.Size = New System.Drawing.Size(85, 34)
        Me.btnCalcSumCheck.TabIndex = 43
        Me.btnCalcSumCheck.Text = "Sum Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VRC"
        Me.btnCalcSumCheck.UseVisualStyleBackColor = True
        '
        'btnCalcCRC16
        '
        Me.btnCalcCRC16.Location = New System.Drawing.Point(394, 178)
        Me.btnCalcCRC16.Name = "btnCalcCRC16"
        Me.btnCalcCRC16.Size = New System.Drawing.Size(85, 34)
        Me.btnCalcCRC16.TabIndex = 44
        Me.btnCalcCRC16.Text = "CRC-16"
        Me.btnCalcCRC16.UseVisualStyleBackColor = True
        '
        'btnCalcCRC32
        '
        Me.btnCalcCRC32.Location = New System.Drawing.Point(485, 178)
        Me.btnCalcCRC32.Name = "btnCalcCRC32"
        Me.btnCalcCRC32.Size = New System.Drawing.Size(85, 34)
        Me.btnCalcCRC32.TabIndex = 45
        Me.btnCalcCRC32.Text = "CRC-32"
        Me.btnCalcCRC32.UseVisualStyleBackColor = True
        '
        'lblSeta1
        '
        Me.lblSeta1.AutoSize = True
        Me.lblSeta1.Location = New System.Drawing.Point(281, 189)
        Me.lblSeta1.Name = "lblSeta1"
        Me.lblSeta1.Size = New System.Drawing.Size(16, 13)
        Me.lblSeta1.TabIndex = 46
        Me.lblSeta1.Text = "->"
        '
        'lblSeta2
        '
        Me.lblSeta2.AutoSize = True
        Me.lblSeta2.Location = New System.Drawing.Point(576, 189)
        Me.lblSeta2.Name = "lblSeta2"
        Me.lblSeta2.Size = New System.Drawing.Size(16, 13)
        Me.lblSeta2.TabIndex = 47
        Me.lblSeta2.Text = "->"
        '
        'txtStrSaidaCalc
        '
        Me.txtStrSaidaCalc.Location = New System.Drawing.Point(598, 186)
        Me.txtStrSaidaCalc.Name = "txtStrSaidaCalc"
        Me.txtStrSaidaCalc.Size = New System.Drawing.Size(106, 20)
        Me.txtStrSaidaCalc.TabIndex = 48
        '
        'btnLimparEnviados
        '
        Me.btnLimparEnviados.Location = New System.Drawing.Point(791, 341)
        Me.btnLimparEnviados.Name = "btnLimparEnviados"
        Me.btnLimparEnviados.Size = New System.Drawing.Size(72, 27)
        Me.btnLimparEnviados.TabIndex = 49
        Me.btnLimparEnviados.Text = "Limpar"
        Me.btnLimparEnviados.UseVisualStyleBackColor = True
        '
        'btnLimparRecebidos
        '
        Me.btnLimparRecebidos.Location = New System.Drawing.Point(791, 491)
        Me.btnLimparRecebidos.Name = "btnLimparRecebidos"
        Me.btnLimparRecebidos.Size = New System.Drawing.Size(72, 27)
        Me.btnLimparRecebidos.TabIndex = 50
        Me.btnLimparRecebidos.Text = "Limpar"
        Me.btnLimparRecebidos.UseVisualStyleBackColor = True
        '
        'grpSinaisSerial
        '
        Me.grpSinaisSerial.Controls.Add(Me.chkRTS)
        Me.grpSinaisSerial.Controls.Add(Me.chkDTR)
        Me.grpSinaisSerial.Controls.Add(Me.chkDSR)
        Me.grpSinaisSerial.Controls.Add(Me.chkCTS)
        Me.grpSinaisSerial.Controls.Add(Me.chkCD)
        Me.grpSinaisSerial.Location = New System.Drawing.Point(377, 11)
        Me.grpSinaisSerial.Name = "grpSinaisSerial"
        Me.grpSinaisSerial.Size = New System.Drawing.Size(183, 70)
        Me.grpSinaisSerial.TabIndex = 52
        Me.grpSinaisSerial.TabStop = False
        Me.grpSinaisSerial.Text = "Status sinais RS-232"
        '
        'chkRTS
        '
        Me.chkRTS.AutoCheck = False
        Me.chkRTS.AutoSize = True
        Me.chkRTS.Location = New System.Drawing.Point(59, 42)
        Me.chkRTS.Name = "chkRTS"
        Me.chkRTS.Size = New System.Drawing.Size(48, 17)
        Me.chkRTS.TabIndex = 56
        Me.chkRTS.Text = "RTS"
        Me.chkRTS.UseVisualStyleBackColor = True
        '
        'chkDTR
        '
        Me.chkDTR.AutoCheck = False
        Me.chkDTR.AutoSize = True
        Me.chkDTR.Location = New System.Drawing.Point(120, 42)
        Me.chkDTR.Name = "chkDTR"
        Me.chkDTR.Size = New System.Drawing.Size(49, 17)
        Me.chkDTR.TabIndex = 55
        Me.chkDTR.Text = "DTR"
        Me.chkDTR.UseVisualStyleBackColor = True
        '
        'chkDSR
        '
        Me.chkDSR.AutoCheck = False
        Me.chkDSR.AutoSize = True
        Me.chkDSR.Location = New System.Drawing.Point(120, 19)
        Me.chkDSR.Name = "chkDSR"
        Me.chkDSR.Size = New System.Drawing.Size(49, 17)
        Me.chkDSR.TabIndex = 54
        Me.chkDSR.Text = "DSR"
        Me.chkDSR.UseVisualStyleBackColor = True
        '
        'chkCTS
        '
        Me.chkCTS.AutoCheck = False
        Me.chkCTS.AutoSize = True
        Me.chkCTS.Location = New System.Drawing.Point(59, 19)
        Me.chkCTS.Name = "chkCTS"
        Me.chkCTS.Size = New System.Drawing.Size(47, 17)
        Me.chkCTS.TabIndex = 53
        Me.chkCTS.Text = "CTS"
        Me.chkCTS.UseVisualStyleBackColor = True
        '
        'chkCD
        '
        Me.chkCD.AutoCheck = False
        Me.chkCD.AutoSize = True
        Me.chkCD.Location = New System.Drawing.Point(11, 19)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Size = New System.Drawing.Size(41, 17)
        Me.chkCD.TabIndex = 52
        Me.chkCD.Text = "CD"
        Me.chkCD.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 579)
        Me.Controls.Add(Me.grpSinaisSerial)
        Me.Controls.Add(Me.btnLimparRecebidos)
        Me.Controls.Add(Me.btnLimparEnviados)
        Me.Controls.Add(Me.txtStrSaidaCalc)
        Me.Controls.Add(Me.lblSeta2)
        Me.Controls.Add(Me.lblSeta1)
        Me.Controls.Add(Me.btnCalcCRC32)
        Me.Controls.Add(Me.btnCalcCRC16)
        Me.Controls.Add(Me.btnCalcSumCheck)
        Me.Controls.Add(Me.txtStrEntrCalc)
        Me.Controls.Add(Me.lblDadosEnviados)
        Me.Controls.Add(Me.txtDadosEnviados)
        Me.Controls.Add(Me.btnCAN)
        Me.Controls.Add(Me.btnETB)
        Me.Controls.Add(Me.btnSYN)
        Me.Controls.Add(Me.btnNAK)
        Me.Controls.Add(Me.btnDC4)
        Me.Controls.Add(Me.btnDC3)
        Me.Controls.Add(Me.btnDC2)
        Me.Controls.Add(Me.btnDC1)
        Me.Controls.Add(Me.btnSPC)
        Me.Controls.Add(Me.btnUS)
        Me.Controls.Add(Me.btnRS)
        Me.Controls.Add(Me.btnGS)
        Me.Controls.Add(Me.btnDLE)
        Me.Controls.Add(Me.btnSI)
        Me.Controls.Add(Me.btnSO)
        Me.Controls.Add(Me.btnCR)
        Me.Controls.Add(Me.btnFF)
        Me.Controls.Add(Me.btnVT)
        Me.Controls.Add(Me.btnLF)
        Me.Controls.Add(Me.btnHT)
        Me.Controls.Add(Me.btnFS)
        Me.Controls.Add(Me.btnESC)
        Me.Controls.Add(Me.btnSUB)
        Me.Controls.Add(Me.btnEN)
        Me.Controls.Add(Me.btnBS)
        Me.Controls.Add(Me.btnBEL)
        Me.Controls.Add(Me.btnACK)
        Me.Controls.Add(Me.btnENQ)
        Me.Controls.Add(Me.btnEOT)
        Me.Controls.Add(Me.btnETX)
        Me.Controls.Add(Me.btnSTX)
        Me.Controls.Add(Me.btnSOH)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblDadoRecebido)
        Me.Controls.Add(Me.txtDadosRecebidos)
        Me.Controls.Add(Me.lblStringEnviar)
        Me.Controls.Add(Me.txtStringEnvio)
        Me.Controls.Add(Me.btnFechaPorta)
        Me.Controls.Add(Me.btnAbrePorta)
        Me.Controls.Add(Me.btnConfiguraPorta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terminal"
        Me.grpSinaisSerial.ResumeLayout(False)
        Me.grpSinaisSerial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfiguraPorta As System.Windows.Forms.Button
    Friend WithEvents btnAbrePorta As System.Windows.Forms.Button
    Friend WithEvents btnFechaPorta As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtStringEnvio As System.Windows.Forms.TextBox
    Friend WithEvents lblStringEnviar As System.Windows.Forms.Label
    Friend WithEvents lblDadoRecebido As System.Windows.Forms.Label
    Friend WithEvents txtDadosRecebidos As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnSOH As System.Windows.Forms.Button
    Friend WithEvents btnSTX As System.Windows.Forms.Button
    Friend WithEvents btnETX As System.Windows.Forms.Button
    Friend WithEvents btnEOT As System.Windows.Forms.Button
    Friend WithEvents btnBS As System.Windows.Forms.Button
    Friend WithEvents btnBEL As System.Windows.Forms.Button
    Friend WithEvents btnACK As System.Windows.Forms.Button
    Friend WithEvents btnENQ As System.Windows.Forms.Button
    Friend WithEvents btnFS As System.Windows.Forms.Button
    Friend WithEvents btnESC As System.Windows.Forms.Button
    Friend WithEvents btnSUB As System.Windows.Forms.Button
    Friend WithEvents btnEN As System.Windows.Forms.Button
    Friend WithEvents btnFF As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
    Friend WithEvents btnLF As System.Windows.Forms.Button
    Friend WithEvents btnHT As System.Windows.Forms.Button
    Friend WithEvents btnDLE As System.Windows.Forms.Button
    Friend WithEvents btnSI As System.Windows.Forms.Button
    Friend WithEvents btnSO As System.Windows.Forms.Button
    Friend WithEvents btnCR As System.Windows.Forms.Button
    Friend WithEvents btnSPC As System.Windows.Forms.Button
    Friend WithEvents btnUS As System.Windows.Forms.Button
    Friend WithEvents btnRS As System.Windows.Forms.Button
    Friend WithEvents btnGS As System.Windows.Forms.Button
    Friend WithEvents btnDC4 As System.Windows.Forms.Button
    Friend WithEvents btnDC3 As System.Windows.Forms.Button
    Friend WithEvents btnDC2 As System.Windows.Forms.Button
    Friend WithEvents btnDC1 As System.Windows.Forms.Button
    Friend WithEvents btnCAN As System.Windows.Forms.Button
    Friend WithEvents btnETB As System.Windows.Forms.Button
    Friend WithEvents btnSYN As System.Windows.Forms.Button
    Friend WithEvents btnNAK As System.Windows.Forms.Button
    Friend WithEvents lblDadosEnviados As System.Windows.Forms.Label
    Friend WithEvents txtDadosEnviados As System.Windows.Forms.TextBox
    Friend WithEvents txtStrEntrCalc As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcSumCheck As System.Windows.Forms.Button
    Friend WithEvents btnCalcCRC16 As System.Windows.Forms.Button
    Friend WithEvents btnCalcCRC32 As System.Windows.Forms.Button
    Friend WithEvents lblSeta1 As System.Windows.Forms.Label
    Friend WithEvents lblSeta2 As System.Windows.Forms.Label
    Friend WithEvents txtStrSaidaCalc As System.Windows.Forms.TextBox
    Friend WithEvents btnLimparEnviados As System.Windows.Forms.Button
    Friend WithEvents btnLimparRecebidos As System.Windows.Forms.Button
    Friend WithEvents grpSinaisSerial As System.Windows.Forms.GroupBox
    Friend WithEvents chkCD As System.Windows.Forms.CheckBox
    Friend WithEvents chkDSR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkRTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkDTR As System.Windows.Forms.CheckBox

End Class
