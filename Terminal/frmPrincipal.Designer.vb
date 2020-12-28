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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtStringEnvio = New System.Windows.Forms.TextBox
        Me.lblStringEnviar = New System.Windows.Forms.Label
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
        Me.btnLimparEnviados = New System.Windows.Forms.Button
        Me.grpSinaisSerial = New System.Windows.Forms.GroupBox
        Me.chkRTS = New System.Windows.Forms.CheckBox
        Me.chkDTR = New System.Windows.Forms.CheckBox
        Me.chkDSR = New System.Windows.Forms.CheckBox
        Me.chkCTS = New System.Windows.Forms.CheckBox
        Me.chkCD = New System.Windows.Forms.CheckBox
        Me.ComunicaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrePortaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FechaPortaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DadosRecebidosEnviadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComandosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExibirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComandosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgramarComandosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbtnAbrirPorta = New System.Windows.Forms.ToolStripButton
        Me.tsbtnFecharPorta = New System.Windows.Forms.ToolStripButton
        Me.btnComando1 = New System.Windows.Forms.Button
        Me.btnComando2 = New System.Windows.Forms.Button
        Me.btnComando3 = New System.Windows.Forms.Button
        Me.btnComando4 = New System.Windows.Forms.Button
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.tmrDadReceb = New System.Windows.Forms.Timer(Me.components)
        Me.rchtxtDadosEnvRec = New System.Windows.Forms.RichTextBox
        Me.chkAdicionaCrLfEnv = New System.Windows.Forms.CheckBox
        Me.dlgSaveFileCmd = New System.Windows.Forms.SaveFileDialog
        Me.dlgSaveFileHist = New System.Windows.Forms.SaveFileDialog
        Me.chkLimparTxtEnvio = New System.Windows.Forms.CheckBox
        Me.stsComunicacao = New System.Windows.Forms.StatusStrip
        Me.stslblTipoComun = New System.Windows.Forms.ToolStripStatusLabel
        Me.stslblConfigComun = New System.Windows.Forms.ToolStripStatusLabel
        Me.stslblStatusComun = New System.Windows.Forms.ToolStripStatusLabel
        Me.stslblTX = New System.Windows.Forms.ToolStripStatusLabel
        Me.stslblRX = New System.Windows.Forms.ToolStripStatusLabel
        Me.tmrIndicTX = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIndicRX = New System.Windows.Forms.Timer(Me.components)
        Me.grpSinaisSerial.SuspendLayout()
        Me.mnuPrincipal.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.stsComunicacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        '
        'txtStringEnvio
        '
        Me.txtStringEnvio.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStringEnvio.Location = New System.Drawing.Point(23, 223)
        Me.txtStringEnvio.Name = "txtStringEnvio"
        Me.txtStringEnvio.Size = New System.Drawing.Size(764, 26)
        Me.txtStringEnvio.TabIndex = 3
        '
        'lblStringEnviar
        '
        Me.lblStringEnviar.AutoSize = True
        Me.lblStringEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStringEnviar.Location = New System.Drawing.Point(29, 207)
        Me.lblStringEnviar.Name = "lblStringEnviar"
        Me.lblStringEnviar.Size = New System.Drawing.Size(94, 13)
        Me.lblStringEnviar.TabIndex = 4
        Me.lblStringEnviar.Text = "String a enviar:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(793, 222)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(72, 27)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnSOH
        '
        Me.btnSOH.AccessibleDescription = ""
        Me.btnSOH.Location = New System.Drawing.Point(23, 114)
        Me.btnSOH.Name = "btnSOH"
        Me.btnSOH.Size = New System.Drawing.Size(47, 34)
        Me.btnSOH.TabIndex = 8
        Me.btnSOH.Text = "SOH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(01h)"
        Me.btnSOH.UseVisualStyleBackColor = True
        '
        'btnSTX
        '
        Me.btnSTX.Location = New System.Drawing.Point(76, 114)
        Me.btnSTX.Name = "btnSTX"
        Me.btnSTX.Size = New System.Drawing.Size(47, 34)
        Me.btnSTX.TabIndex = 9
        Me.btnSTX.Text = "STX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(02h)"
        Me.btnSTX.UseVisualStyleBackColor = True
        '
        'btnETX
        '
        Me.btnETX.Location = New System.Drawing.Point(129, 114)
        Me.btnETX.Name = "btnETX"
        Me.btnETX.Size = New System.Drawing.Size(47, 34)
        Me.btnETX.TabIndex = 10
        Me.btnETX.Text = "ETX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(03h)"
        Me.btnETX.UseVisualStyleBackColor = True
        '
        'btnEOT
        '
        Me.btnEOT.Location = New System.Drawing.Point(182, 114)
        Me.btnEOT.Name = "btnEOT"
        Me.btnEOT.Size = New System.Drawing.Size(47, 34)
        Me.btnEOT.TabIndex = 11
        Me.btnEOT.Text = "EOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(04h)"
        Me.btnEOT.UseVisualStyleBackColor = True
        '
        'btnBS
        '
        Me.btnBS.Location = New System.Drawing.Point(394, 114)
        Me.btnBS.Name = "btnBS"
        Me.btnBS.Size = New System.Drawing.Size(47, 34)
        Me.btnBS.TabIndex = 15
        Me.btnBS.Text = "BS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(08h)"
        Me.btnBS.UseVisualStyleBackColor = True
        '
        'btnBEL
        '
        Me.btnBEL.Location = New System.Drawing.Point(341, 114)
        Me.btnBEL.Name = "btnBEL"
        Me.btnBEL.Size = New System.Drawing.Size(47, 34)
        Me.btnBEL.TabIndex = 14
        Me.btnBEL.Text = "BEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(07h)"
        Me.btnBEL.UseVisualStyleBackColor = True
        '
        'btnACK
        '
        Me.btnACK.Location = New System.Drawing.Point(288, 114)
        Me.btnACK.Name = "btnACK"
        Me.btnACK.Size = New System.Drawing.Size(47, 34)
        Me.btnACK.TabIndex = 13
        Me.btnACK.Text = "ACK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(06h)"
        Me.btnACK.UseVisualStyleBackColor = True
        '
        'btnENQ
        '
        Me.btnENQ.Location = New System.Drawing.Point(235, 114)
        Me.btnENQ.Name = "btnENQ"
        Me.btnENQ.Size = New System.Drawing.Size(47, 34)
        Me.btnENQ.TabIndex = 12
        Me.btnENQ.Text = "ENQ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(05h)"
        Me.btnENQ.UseVisualStyleBackColor = True
        '
        'btnFS
        '
        Me.btnFS.Location = New System.Drawing.Point(606, 154)
        Me.btnFS.Name = "btnFS"
        Me.btnFS.Size = New System.Drawing.Size(47, 34)
        Me.btnFS.TabIndex = 19
        Me.btnFS.Text = "FS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Ch)"
        Me.btnFS.UseVisualStyleBackColor = True
        '
        'btnESC
        '
        Me.btnESC.Location = New System.Drawing.Point(553, 154)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(47, 34)
        Me.btnESC.TabIndex = 18
        Me.btnESC.Text = "ESC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Bh)"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'btnSUB
        '
        Me.btnSUB.Location = New System.Drawing.Point(500, 154)
        Me.btnSUB.Name = "btnSUB"
        Me.btnSUB.Size = New System.Drawing.Size(47, 34)
        Me.btnSUB.TabIndex = 17
        Me.btnSUB.Text = "SUB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Ah)"
        Me.btnSUB.UseVisualStyleBackColor = True
        '
        'btnEN
        '
        Me.btnEN.Location = New System.Drawing.Point(447, 154)
        Me.btnEN.Name = "btnEN"
        Me.btnEN.Size = New System.Drawing.Size(47, 34)
        Me.btnEN.TabIndex = 16
        Me.btnEN.Text = "EN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(19h)"
        Me.btnEN.UseVisualStyleBackColor = True
        '
        'btnFF
        '
        Me.btnFF.Location = New System.Drawing.Point(606, 114)
        Me.btnFF.Name = "btnFF"
        Me.btnFF.Size = New System.Drawing.Size(47, 34)
        Me.btnFF.TabIndex = 23
        Me.btnFF.Text = "FF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Ch)"
        Me.btnFF.UseVisualStyleBackColor = True
        '
        'btnVT
        '
        Me.btnVT.Location = New System.Drawing.Point(553, 114)
        Me.btnVT.Name = "btnVT"
        Me.btnVT.Size = New System.Drawing.Size(47, 34)
        Me.btnVT.TabIndex = 22
        Me.btnVT.Text = "VT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Bh)"
        Me.btnVT.UseVisualStyleBackColor = True
        '
        'btnLF
        '
        Me.btnLF.Location = New System.Drawing.Point(500, 114)
        Me.btnLF.Name = "btnLF"
        Me.btnLF.Size = New System.Drawing.Size(47, 34)
        Me.btnLF.TabIndex = 21
        Me.btnLF.Text = "LF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Ah)"
        Me.btnLF.UseVisualStyleBackColor = True
        '
        'btnHT
        '
        Me.btnHT.Location = New System.Drawing.Point(447, 114)
        Me.btnHT.Name = "btnHT"
        Me.btnHT.Size = New System.Drawing.Size(47, 34)
        Me.btnHT.TabIndex = 20
        Me.btnHT.Text = "HT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(09h)"
        Me.btnHT.UseVisualStyleBackColor = True
        '
        'btnDLE
        '
        Me.btnDLE.Location = New System.Drawing.Point(818, 114)
        Me.btnDLE.Name = "btnDLE"
        Me.btnDLE.Size = New System.Drawing.Size(47, 34)
        Me.btnDLE.TabIndex = 27
        Me.btnDLE.Text = "DLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(10h)"
        Me.btnDLE.UseVisualStyleBackColor = True
        '
        'btnSI
        '
        Me.btnSI.Location = New System.Drawing.Point(765, 114)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(47, 34)
        Me.btnSI.TabIndex = 26
        Me.btnSI.Text = "SI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Fh)"
        Me.btnSI.UseVisualStyleBackColor = True
        '
        'btnSO
        '
        Me.btnSO.Location = New System.Drawing.Point(712, 114)
        Me.btnSO.Name = "btnSO"
        Me.btnSO.Size = New System.Drawing.Size(47, 34)
        Me.btnSO.TabIndex = 25
        Me.btnSO.Text = "SO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Eh)"
        Me.btnSO.UseVisualStyleBackColor = True
        '
        'btnCR
        '
        Me.btnCR.Location = New System.Drawing.Point(659, 114)
        Me.btnCR.Name = "btnCR"
        Me.btnCR.Size = New System.Drawing.Size(47, 34)
        Me.btnCR.TabIndex = 24
        Me.btnCR.Text = "CR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0Dh)"
        Me.btnCR.UseVisualStyleBackColor = True
        '
        'btnSPC
        '
        Me.btnSPC.Location = New System.Drawing.Point(818, 154)
        Me.btnSPC.Name = "btnSPC"
        Me.btnSPC.Size = New System.Drawing.Size(47, 34)
        Me.btnSPC.TabIndex = 31
        Me.btnSPC.Text = "SPC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(20h)"
        Me.btnSPC.UseVisualStyleBackColor = True
        '
        'btnUS
        '
        Me.btnUS.Location = New System.Drawing.Point(765, 154)
        Me.btnUS.Name = "btnUS"
        Me.btnUS.Size = New System.Drawing.Size(47, 34)
        Me.btnUS.TabIndex = 30
        Me.btnUS.Text = "US" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Fh)"
        Me.btnUS.UseVisualStyleBackColor = True
        '
        'btnRS
        '
        Me.btnRS.Location = New System.Drawing.Point(712, 154)
        Me.btnRS.Name = "btnRS"
        Me.btnRS.Size = New System.Drawing.Size(47, 34)
        Me.btnRS.TabIndex = 29
        Me.btnRS.Text = "RS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Eh)"
        Me.btnRS.UseVisualStyleBackColor = True
        '
        'btnGS
        '
        Me.btnGS.Location = New System.Drawing.Point(659, 154)
        Me.btnGS.Name = "btnGS"
        Me.btnGS.Size = New System.Drawing.Size(47, 34)
        Me.btnGS.TabIndex = 28
        Me.btnGS.Text = "GS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1Dh)"
        Me.btnGS.UseVisualStyleBackColor = True
        '
        'btnDC4
        '
        Me.btnDC4.Location = New System.Drawing.Point(182, 154)
        Me.btnDC4.Name = "btnDC4"
        Me.btnDC4.Size = New System.Drawing.Size(47, 34)
        Me.btnDC4.TabIndex = 35
        Me.btnDC4.Text = "DC4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(14h)"
        Me.btnDC4.UseVisualStyleBackColor = True
        '
        'btnDC3
        '
        Me.btnDC3.Location = New System.Drawing.Point(129, 154)
        Me.btnDC3.Name = "btnDC3"
        Me.btnDC3.Size = New System.Drawing.Size(47, 34)
        Me.btnDC3.TabIndex = 34
        Me.btnDC3.Text = "DC3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(13h)"
        Me.btnDC3.UseVisualStyleBackColor = True
        '
        'btnDC2
        '
        Me.btnDC2.Location = New System.Drawing.Point(76, 154)
        Me.btnDC2.Name = "btnDC2"
        Me.btnDC2.Size = New System.Drawing.Size(47, 34)
        Me.btnDC2.TabIndex = 33
        Me.btnDC2.Text = "DC2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(12h)"
        Me.btnDC2.UseVisualStyleBackColor = True
        '
        'btnDC1
        '
        Me.btnDC1.Location = New System.Drawing.Point(23, 154)
        Me.btnDC1.Name = "btnDC1"
        Me.btnDC1.Size = New System.Drawing.Size(47, 34)
        Me.btnDC1.TabIndex = 32
        Me.btnDC1.Text = "DC1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(11h)"
        Me.btnDC1.UseVisualStyleBackColor = True
        '
        'btnCAN
        '
        Me.btnCAN.Location = New System.Drawing.Point(394, 154)
        Me.btnCAN.Name = "btnCAN"
        Me.btnCAN.Size = New System.Drawing.Size(47, 34)
        Me.btnCAN.TabIndex = 39
        Me.btnCAN.Text = "CAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(18h)"
        Me.btnCAN.UseVisualStyleBackColor = True
        '
        'btnETB
        '
        Me.btnETB.Location = New System.Drawing.Point(341, 154)
        Me.btnETB.Name = "btnETB"
        Me.btnETB.Size = New System.Drawing.Size(47, 34)
        Me.btnETB.TabIndex = 38
        Me.btnETB.Text = "ETB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(17h)"
        Me.btnETB.UseVisualStyleBackColor = True
        '
        'btnSYN
        '
        Me.btnSYN.Location = New System.Drawing.Point(288, 154)
        Me.btnSYN.Name = "btnSYN"
        Me.btnSYN.Size = New System.Drawing.Size(47, 34)
        Me.btnSYN.TabIndex = 37
        Me.btnSYN.Text = "SYN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(16h)"
        Me.btnSYN.UseVisualStyleBackColor = True
        '
        'btnNAK
        '
        Me.btnNAK.Location = New System.Drawing.Point(235, 154)
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
        Me.lblDadosEnviados.Location = New System.Drawing.Point(29, 282)
        Me.lblDadosEnviados.Name = "lblDadosEnviados"
        Me.lblDadosEnviados.Size = New System.Drawing.Size(238, 13)
        Me.lblDadosEnviados.TabIndex = 41
        Me.lblDadosEnviados.Text = "Histórico de dados enviados e recebidos"
        '
        'btnLimparEnviados
        '
        Me.btnLimparEnviados.Location = New System.Drawing.Point(793, 409)
        Me.btnLimparEnviados.Name = "btnLimparEnviados"
        Me.btnLimparEnviados.Size = New System.Drawing.Size(72, 39)
        Me.btnLimparEnviados.TabIndex = 49
        Me.btnLimparEnviados.Text = "Limpar Histórico"
        Me.btnLimparEnviados.UseVisualStyleBackColor = True
        '
        'grpSinaisSerial
        '
        Me.grpSinaisSerial.Controls.Add(Me.chkRTS)
        Me.grpSinaisSerial.Controls.Add(Me.chkDTR)
        Me.grpSinaisSerial.Controls.Add(Me.chkDSR)
        Me.grpSinaisSerial.Controls.Add(Me.chkCTS)
        Me.grpSinaisSerial.Controls.Add(Me.chkCD)
        Me.grpSinaisSerial.Enabled = False
        Me.grpSinaisSerial.Location = New System.Drawing.Point(529, 55)
        Me.grpSinaisSerial.Name = "grpSinaisSerial"
        Me.grpSinaisSerial.Size = New System.Drawing.Size(336, 48)
        Me.grpSinaisSerial.TabIndex = 52
        Me.grpSinaisSerial.TabStop = False
        Me.grpSinaisSerial.Text = "Status sinais RS-232"
        '
        'chkRTS
        '
        Me.chkRTS.AutoCheck = False
        Me.chkRTS.AutoSize = True
        Me.chkRTS.Location = New System.Drawing.Point(142, 21)
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
        Me.chkDTR.Location = New System.Drawing.Point(271, 21)
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
        Me.chkDSR.Location = New System.Drawing.Point(206, 21)
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
        Me.chkCTS.Location = New System.Drawing.Point(79, 21)
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
        Me.chkCD.Location = New System.Drawing.Point(22, 21)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Size = New System.Drawing.Size(41, 17)
        Me.chkCD.TabIndex = 52
        Me.chkCD.Text = "CD"
        Me.chkCD.UseVisualStyleBackColor = True
        '
        'ComunicaçõesToolStripMenuItem
        '
        Me.ComunicaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçãoToolStripMenuItem, Me.AbrePortaToolStripMenuItem, Me.FechaPortaToolStripMenuItem})
        Me.ComunicaçõesToolStripMenuItem.Name = "ComunicaçõesToolStripMenuItem"
        Me.ComunicaçõesToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ComunicaçõesToolStripMenuItem.Text = "&Comunicações"
        '
        'ConfiguraçãoToolStripMenuItem
        '
        Me.ConfiguraçãoToolStripMenuItem.Name = "ConfiguraçãoToolStripMenuItem"
        Me.ConfiguraçãoToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ConfiguraçãoToolStripMenuItem.Text = "&Configuração"
        '
        'AbrePortaToolStripMenuItem
        '
        Me.AbrePortaToolStripMenuItem.Name = "AbrePortaToolStripMenuItem"
        Me.AbrePortaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AbrePortaToolStripMenuItem.Text = "&Abre Porta"
        '
        'FechaPortaToolStripMenuItem
        '
        Me.FechaPortaToolStripMenuItem.Enabled = False
        Me.FechaPortaToolStripMenuItem.Name = "FechaPortaToolStripMenuItem"
        Me.FechaPortaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FechaPortaToolStripMenuItem.Text = "&Fecha Porta"
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.ExibirToolStripMenuItem, Me.ComunicaçõesToolStripMenuItem, Me.ComandosToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(884, 24)
        Me.mnuPrincipal.TabIndex = 53
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosRecebidosEnviadosToolStripMenuItem, Me.ComandosToolStripMenuItem1})
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SalvarToolStripMenuItem.Text = "&Salvar"
        '
        'DadosRecebidosEnviadosToolStripMenuItem
        '
        Me.DadosRecebidosEnviadosToolStripMenuItem.Name = "DadosRecebidosEnviadosToolStripMenuItem"
        Me.DadosRecebidosEnviadosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DadosRecebidosEnviadosToolStripMenuItem.Text = "&Dados Recebidos/Enviados"
        '
        'ComandosToolStripMenuItem1
        '
        Me.ComandosToolStripMenuItem1.Name = "ComandosToolStripMenuItem1"
        Me.ComandosToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.ComandosToolStripMenuItem1.Text = "&Comandos"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'ExibirToolStripMenuItem
        '
        Me.ExibirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.LanguageToolStripMenuItem})
        Me.ExibirToolStripMenuItem.Name = "ExibirToolStripMenuItem"
        Me.ExibirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ExibirToolStripMenuItem.Text = "E&xibir"
        '
        'ConfiToolStripMenuItem
        '
        Me.ConfiToolStripMenuItem.Name = "ConfiToolStripMenuItem"
        Me.ConfiToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ConfiToolStripMenuItem.Text = "&Opções"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.CheckOnClick = True
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'ComandosToolStripMenuItem
        '
        Me.ComandosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramarComandosToolStripMenuItem})
        Me.ComandosToolStripMenuItem.Name = "ComandosToolStripMenuItem"
        Me.ComandosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ComandosToolStripMenuItem.Text = "Co&mandos"
        '
        'ProgramarComandosToolStripMenuItem
        '
        Me.ProgramarComandosToolStripMenuItem.Name = "ProgramarComandosToolStripMenuItem"
        Me.ProgramarComandosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ProgramarComandosToolStripMenuItem.Text = "&Programar Comandos"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "&Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAbrirPorta, Me.tsbtnFecharPorta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(884, 25)
        Me.ToolStrip1.TabIndex = 54
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnAbrirPorta
        '
        Me.tsbtnAbrirPorta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAbrirPorta.Image = CType(resources.GetObject("tsbtnAbrirPorta.Image"), System.Drawing.Image)
        Me.tsbtnAbrirPorta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAbrirPorta.Name = "tsbtnAbrirPorta"
        Me.tsbtnAbrirPorta.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAbrirPorta.Text = "ToolStripButton1"
        Me.tsbtnAbrirPorta.ToolTipText = "Abrir Porta"
        '
        'tsbtnFecharPorta
        '
        Me.tsbtnFecharPorta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFecharPorta.Enabled = False
        Me.tsbtnFecharPorta.Image = CType(resources.GetObject("tsbtnFecharPorta.Image"), System.Drawing.Image)
        Me.tsbtnFecharPorta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFecharPorta.Name = "tsbtnFecharPorta"
        Me.tsbtnFecharPorta.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnFecharPorta.Text = "ToolStripButton2"
        Me.tsbtnFecharPorta.ToolTipText = "Fechar Porta"
        '
        'btnComando1
        '
        Me.btnComando1.Enabled = False
        Me.btnComando1.Location = New System.Drawing.Point(23, 60)
        Me.btnComando1.Name = "btnComando1"
        Me.btnComando1.Size = New System.Drawing.Size(100, 42)
        Me.btnComando1.TabIndex = 56
        Me.btnComando1.Text = "Comando 1"
        Me.btnComando1.UseVisualStyleBackColor = True
        '
        'btnComando2
        '
        Me.btnComando2.Enabled = False
        Me.btnComando2.Location = New System.Drawing.Point(129, 60)
        Me.btnComando2.Name = "btnComando2"
        Me.btnComando2.Size = New System.Drawing.Size(100, 42)
        Me.btnComando2.TabIndex = 57
        Me.btnComando2.Text = "Comando 2"
        Me.btnComando2.UseVisualStyleBackColor = True
        '
        'btnComando3
        '
        Me.btnComando3.Enabled = False
        Me.btnComando3.Location = New System.Drawing.Point(235, 60)
        Me.btnComando3.Name = "btnComando3"
        Me.btnComando3.Size = New System.Drawing.Size(100, 42)
        Me.btnComando3.TabIndex = 58
        Me.btnComando3.Text = "Comando 3"
        Me.btnComando3.UseVisualStyleBackColor = True
        '
        'btnComando4
        '
        Me.btnComando4.Enabled = False
        Me.btnComando4.Location = New System.Drawing.Point(341, 60)
        Me.btnComando4.Name = "btnComando4"
        Me.btnComando4.Size = New System.Drawing.Size(100, 42)
        Me.btnComando4.TabIndex = 59
        Me.btnComando4.Text = "Comando 4"
        Me.btnComando4.UseVisualStyleBackColor = True
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "*.txt"
        Me.dlgOpenFile.Filter = "Arquivos Texto (com comandos) (*.txt)|*.txt"
        '
        'tmrDadReceb
        '
        Me.tmrDadReceb.Interval = 50
        '
        'rchtxtDadosEnvRec
        '
        Me.rchtxtDadosEnvRec.AcceptsTab = True
        Me.rchtxtDadosEnvRec.DetectUrls = False
        Me.rchtxtDadosEnvRec.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchtxtDadosEnvRec.Location = New System.Drawing.Point(23, 302)
        Me.rchtxtDadosEnvRec.Name = "rchtxtDadosEnvRec"
        Me.rchtxtDadosEnvRec.Size = New System.Drawing.Size(764, 255)
        Me.rchtxtDadosEnvRec.TabIndex = 60
        Me.rchtxtDadosEnvRec.Text = ""
        '
        'chkAdicionaCrLfEnv
        '
        Me.chkAdicionaCrLfEnv.AutoSize = True
        Me.chkAdicionaCrLfEnv.Location = New System.Drawing.Point(23, 255)
        Me.chkAdicionaCrLfEnv.Name = "chkAdicionaCrLfEnv"
        Me.chkAdicionaCrLfEnv.Size = New System.Drawing.Size(355, 17)
        Me.chkAdicionaCrLfEnv.TabIndex = 62
        Me.chkAdicionaCrLfEnv.Text = "Adicionar automaticamente <CR><LF> no final da string a ser enviada"
        Me.chkAdicionaCrLfEnv.UseVisualStyleBackColor = True
        '
        'dlgSaveFileCmd
        '
        Me.dlgSaveFileCmd.FileName = "*.txt"
        Me.dlgSaveFileCmd.Filter = "Arquivos Texto (com comandos) (*.txt)|*.txt"
        '
        'dlgSaveFileHist
        '
        Me.dlgSaveFileHist.FileName = "*.rtf"
        Me.dlgSaveFileHist.Filter = "Arquivos Rich Text Format (*.rtf)|*.rtf"
        '
        'chkLimparTxtEnvio
        '
        Me.chkLimparTxtEnvio.AutoSize = True
        Me.chkLimparTxtEnvio.Location = New System.Drawing.Point(396, 255)
        Me.chkLimparTxtEnvio.Name = "chkLimparTxtEnvio"
        Me.chkLimparTxtEnvio.Size = New System.Drawing.Size(181, 17)
        Me.chkLimparTxtEnvio.TabIndex = 63
        Me.chkLimparTxtEnvio.Text = "Limpar caixa de texto após envio"
        Me.chkLimparTxtEnvio.UseVisualStyleBackColor = True
        '
        'stsComunicacao
        '
        Me.stsComunicacao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stslblTipoComun, Me.stslblConfigComun, Me.stslblStatusComun, Me.stslblTX, Me.stslblRX})
        Me.stsComunicacao.Location = New System.Drawing.Point(0, 571)
        Me.stsComunicacao.Name = "stsComunicacao"
        Me.stsComunicacao.Size = New System.Drawing.Size(884, 24)
        Me.stsComunicacao.TabIndex = 64
        Me.stsComunicacao.Text = "StatusStrip1"
        '
        'stslblTipoComun
        '
        Me.stslblTipoComun.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stslblTipoComun.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stslblTipoComun.Name = "stslblTipoComun"
        Me.stslblTipoComun.Size = New System.Drawing.Size(26, 19)
        Me.stslblTipoComun.Text = "     "
        '
        'stslblConfigComun
        '
        Me.stslblConfigComun.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stslblConfigComun.Name = "stslblConfigComun"
        Me.stslblConfigComun.Size = New System.Drawing.Size(29, 19)
        Me.stslblConfigComun.Text = "      "
        '
        'stslblStatusComun
        '
        Me.stslblStatusComun.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stslblStatusComun.Name = "stslblStatusComun"
        Me.stslblStatusComun.Size = New System.Drawing.Size(29, 19)
        Me.stslblStatusComun.Text = "      "
        '
        'stslblTX
        '
        Me.stslblTX.BackColor = System.Drawing.Color.Silver
        Me.stslblTX.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stslblTX.Name = "stslblTX"
        Me.stslblTX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.stslblTX.Size = New System.Drawing.Size(25, 19)
        Me.stslblTX.Text = "TX"
        '
        'stslblRX
        '
        Me.stslblRX.BackColor = System.Drawing.Color.Silver
        Me.stslblRX.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stslblRX.Name = "stslblRX"
        Me.stslblRX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.stslblRX.Size = New System.Drawing.Size(25, 19)
        Me.stslblRX.Text = "RX"
        '
        'tmrIndicTX
        '
        Me.tmrIndicTX.Interval = 50
        '
        'tmrIndicRX
        '
        Me.tmrIndicRX.Interval = 50
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 595)
        Me.Controls.Add(Me.stsComunicacao)
        Me.Controls.Add(Me.chkLimparTxtEnvio)
        Me.Controls.Add(Me.chkAdicionaCrLfEnv)
        Me.Controls.Add(Me.rchtxtDadosEnvRec)
        Me.Controls.Add(Me.btnComando4)
        Me.Controls.Add(Me.btnComando3)
        Me.Controls.Add(Me.btnComando2)
        Me.Controls.Add(Me.btnComando1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpSinaisSerial)
        Me.Controls.Add(Me.btnLimparEnviados)
        Me.Controls.Add(Me.lblDadosEnviados)
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
        Me.Controls.Add(Me.lblStringEnviar)
        Me.Controls.Add(Me.txtStringEnvio)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Versa Terminal 4.0"
        Me.grpSinaisSerial.ResumeLayout(False)
        Me.grpSinaisSerial.PerformLayout()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.stsComunicacao.ResumeLayout(False)
        Me.stsComunicacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtStringEnvio As System.Windows.Forms.TextBox
    Friend WithEvents lblStringEnviar As System.Windows.Forms.Label
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
    Friend WithEvents btnLimparEnviados As System.Windows.Forms.Button
    Friend WithEvents grpSinaisSerial As System.Windows.Forms.GroupBox
    Friend WithEvents chkCD As System.Windows.Forms.CheckBox
    Friend WithEvents chkDSR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkRTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkDTR As System.Windows.Forms.CheckBox
    Friend WithEvents ComunicaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrePortaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaPortaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAbrirPorta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFecharPorta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnComando1 As System.Windows.Forms.Button
    Friend WithEvents btnComando2 As System.Windows.Forms.Button
    Friend WithEvents btnComando3 As System.Windows.Forms.Button
    Friend WithEvents btnComando4 As System.Windows.Forms.Button
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComandosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramarComandosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComandosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DadosRecebidosEnviadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDadReceb As System.Windows.Forms.Timer
    Friend WithEvents rchtxtDadosEnvRec As System.Windows.Forms.RichTextBox
    Friend WithEvents chkAdicionaCrLfEnv As System.Windows.Forms.CheckBox
    Friend WithEvents ExibirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgSaveFileCmd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveFileHist As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkLimparTxtEnvio As System.Windows.Forms.CheckBox
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsComunicacao As System.Windows.Forms.StatusStrip
    Friend WithEvents stslblTipoComun As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stslblConfigComun As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stslblRX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stslblStatusComun As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stslblTX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrIndicTX As System.Windows.Forms.Timer
    Friend WithEvents tmrIndicRX As System.Windows.Forms.Timer
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
