<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConfComunicacao
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.grpSerial = New System.Windows.Forms.GroupBox
        Me.cmbHandshake = New System.Windows.Forms.ComboBox
        Me.lblHandshake = New System.Windows.Forms.Label
        Me.cmbParidade = New System.Windows.Forms.ComboBox
        Me.cmbStopBits = New System.Windows.Forms.ComboBox
        Me.cmbDataBits = New System.Windows.Forms.ComboBox
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.cmbPortaSerial = New System.Windows.Forms.ComboBox
        Me.chkHabilitaRTS = New System.Windows.Forms.CheckBox
        Me.chkHabilitaDTR = New System.Windows.Forms.CheckBox
        Me.lblParidade = New System.Windows.Forms.Label
        Me.lblStopBits = New System.Windows.Forms.Label
        Me.lblDataBits = New System.Windows.Forms.Label
        Me.lblBaudRate = New System.Windows.Forms.Label
        Me.lblPortaSerial = New System.Windows.Forms.Label
        Me.grpEthernet = New System.Windows.Forms.GroupBox
        Me.rdbUDP = New System.Windows.Forms.RadioButton
        Me.rdbTCP = New System.Windows.Forms.RadioButton
        Me.txtPortaEthernet = New System.Windows.Forms.TextBox
        Me.txtEndEthernet = New System.Windows.Forms.TextBox
        Me.lblPortaEth = New System.Windows.Forms.Label
        Me.lblIPAddress = New System.Windows.Forms.Label
        Me.rdbSerial = New System.Windows.Forms.RadioButton
        Me.rdbEthernet = New System.Windows.Forms.RadioButton
        Me.lblAtrasoDadosRecebidos = New System.Windows.Forms.Label
        Me.txtTempoAtrasoDadosReceb = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpSerial.SuspendLayout()
        Me.grpEthernet.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(307, 385)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'grpSerial
        '
        Me.grpSerial.Controls.Add(Me.cmbHandshake)
        Me.grpSerial.Controls.Add(Me.lblHandshake)
        Me.grpSerial.Controls.Add(Me.cmbParidade)
        Me.grpSerial.Controls.Add(Me.cmbStopBits)
        Me.grpSerial.Controls.Add(Me.cmbDataBits)
        Me.grpSerial.Controls.Add(Me.cmbBaudRate)
        Me.grpSerial.Controls.Add(Me.cmbPortaSerial)
        Me.grpSerial.Controls.Add(Me.chkHabilitaRTS)
        Me.grpSerial.Controls.Add(Me.chkHabilitaDTR)
        Me.grpSerial.Controls.Add(Me.lblParidade)
        Me.grpSerial.Controls.Add(Me.lblStopBits)
        Me.grpSerial.Controls.Add(Me.lblDataBits)
        Me.grpSerial.Controls.Add(Me.lblBaudRate)
        Me.grpSerial.Controls.Add(Me.lblPortaSerial)
        Me.grpSerial.Location = New System.Drawing.Point(12, 25)
        Me.grpSerial.Name = "grpSerial"
        Me.grpSerial.Size = New System.Drawing.Size(441, 151)
        Me.grpSerial.TabIndex = 15
        Me.grpSerial.TabStop = False
        '
        'cmbHandshake
        '
        Me.cmbHandshake.FormattingEnabled = True
        Me.cmbHandshake.Items.AddRange(New Object() {"Xon/Xoff", "Hardware"})
        Me.cmbHandshake.Location = New System.Drawing.Point(355, 64)
        Me.cmbHandshake.Name = "cmbHandshake"
        Me.cmbHandshake.Size = New System.Drawing.Size(70, 21)
        Me.cmbHandshake.TabIndex = 28
        Me.cmbHandshake.Text = "None"
        '
        'lblHandshake
        '
        Me.lblHandshake.AutoSize = True
        Me.lblHandshake.Location = New System.Drawing.Point(284, 67)
        Me.lblHandshake.Name = "lblHandshake"
        Me.lblHandshake.Size = New System.Drawing.Size(65, 13)
        Me.lblHandshake.TabIndex = 27
        Me.lblHandshake.Text = "Handshake:"
        '
        'cmbParidade
        '
        Me.cmbParidade.FormattingEnabled = True
        Me.cmbParidade.Items.AddRange(New Object() {"None", "Ímpar (Odd)", "Par (Even)", "Marca", "Espaço"})
        Me.cmbParidade.Location = New System.Drawing.Point(355, 27)
        Me.cmbParidade.Name = "cmbParidade"
        Me.cmbParidade.Size = New System.Drawing.Size(70, 21)
        Me.cmbParidade.TabIndex = 26
        Me.cmbParidade.Text = "Nenhum"
        '
        'cmbStopBits
        '
        Me.cmbStopBits.FormattingEnabled = True
        Me.cmbStopBits.Items.AddRange(New Object() {"1", "1,5", "2"})
        Me.cmbStopBits.Location = New System.Drawing.Point(223, 64)
        Me.cmbStopBits.Name = "cmbStopBits"
        Me.cmbStopBits.Size = New System.Drawing.Size(48, 21)
        Me.cmbStopBits.TabIndex = 25
        Me.cmbStopBits.Tag = ""
        Me.cmbStopBits.Text = "1"
        '
        'cmbDataBits
        '
        Me.cmbDataBits.FormattingEnabled = True
        Me.cmbDataBits.Items.AddRange(New Object() {"7", "8"})
        Me.cmbDataBits.Location = New System.Drawing.Point(223, 29)
        Me.cmbDataBits.Name = "cmbDataBits"
        Me.cmbDataBits.Size = New System.Drawing.Size(48, 21)
        Me.cmbDataBits.TabIndex = 24
        Me.cmbDataBits.Text = "8"
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(74, 64)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(74, 21)
        Me.cmbBaudRate.TabIndex = 23
        Me.cmbBaudRate.Text = "9600"
        '
        'cmbPortaSerial
        '
        Me.cmbPortaSerial.FormattingEnabled = True
        Me.cmbPortaSerial.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20", "COM21", "COM22", "COM23", "COM24", "COM25", "COM26", "COM27", "COM28", "COM29", "COM30", "COM31", "COM32", "COM33", "COM34", "COM35", "COM36", "COM37", "COM38", "COM39", "COM40", "COM41", "COM42", "COM43", "COM44", "COM45", "COM46", "COM47", "COM48", "COM49", "COM50", "COM51", "COM52", "COM53", "COM54", "COM55", "COM56", "COM57", "COM58", "COM59", "COM60", "COM61", "COM62", "COM63", "COM64", "COM65", "COM66", "COM67", "COM68", "COM69", "COM70", "COM71", "COM72", "COM73", "COM74", "COM75", "COM76", "COM77", "COM78", "COM79", "COM80", "COM81", "COM82", "COM83", "COM84", "COM85", "COM86", "COM87", "COM88", "COM89", "COM90", "COM91", "COM92", "COM93", "COM94", "COM95", "COM96", "COM97", "COM98", "COM99", "COM100", "COM101", "COM102", "COM103", "COM104", "COM105", "COM106", "COM107", "COM108", "COM109", "COM110", "COM111", "COM112", "COM113", "COM114", "COM115", "COM116", "COM117", "COM118", "COM119", "COM120", "COM121", "COM122", "COM123", "COM124", "COM125", "COM126", "COM127", "COM128", "COM129", "COM130", "COM131", "COM132", "COM133", "COM134", "COM135", "COM136", "COM137", "COM138", "COM139", "COM140", "COM141", "COM142", "COM143", "COM144", "COM145", "COM146", "COM147", "COM148", "COM149", "COM150", "COM151", "COM152", "COM153", "COM154", "COM155", "COM156", "COM157", "COM158", "COM159", "COM160", "COM161", "COM162", "COM163", "COM164", "COM165", "COM166", "COM167", "COM168", "COM169", "COM170", "COM171", "COM172", "COM173", "COM174", "COM175", "COM176", "COM177", "COM178", "COM179", "COM180", "COM181", "COM182", "COM183", "COM184", "COM185", "COM186", "COM187", "COM188", "COM189", "COM190", "COM191", "COM192", "COM193", "COM194", "COM195", "COM196", "COM197", "COM198", "COM199", "COM200", "COM201", "COM202", "COM203", "COM204", "COM205", "COM206", "COM207", "COM208", "COM209", "COM210", "COM211", "COM212", "COM213", "COM214", "COM215", "COM216", "COM217", "COM218", "COM219", "COM220", "COM221", "COM222", "COM223", "COM224", "COM225", "COM226", "COM227", "COM228", "COM229", "COM230", "COM231", "COM232", "COM233", "COM234", "COM235", "COM236", "COM237", "COM238", "COM239", "COM240", "COM241", "COM242", "COM243", "COM244", "COM245", "COM246", "COM247", "COM248", "COM249", "COM250", "COM251", "COM252", "COM253", "COM254", "COM255"})
        Me.cmbPortaSerial.Location = New System.Drawing.Point(74, 29)
        Me.cmbPortaSerial.Name = "cmbPortaSerial"
        Me.cmbPortaSerial.Size = New System.Drawing.Size(74, 21)
        Me.cmbPortaSerial.TabIndex = 22
        Me.cmbPortaSerial.Text = "COM1"
        '
        'chkHabilitaRTS
        '
        Me.chkHabilitaRTS.AutoSize = True
        Me.chkHabilitaRTS.Location = New System.Drawing.Point(306, 108)
        Me.chkHabilitaRTS.Name = "chkHabilitaRTS"
        Me.chkHabilitaRTS.Size = New System.Drawing.Size(119, 17)
        Me.chkHabilitaRTS.TabIndex = 21
        Me.chkHabilitaRTS.Text = "Manter RTS Ligado"
        Me.chkHabilitaRTS.UseVisualStyleBackColor = True
        '
        'chkHabilitaDTR
        '
        Me.chkHabilitaDTR.AutoSize = True
        Me.chkHabilitaDTR.Checked = True
        Me.chkHabilitaDTR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHabilitaDTR.Location = New System.Drawing.Point(170, 108)
        Me.chkHabilitaDTR.Name = "chkHabilitaDTR"
        Me.chkHabilitaDTR.Size = New System.Drawing.Size(120, 17)
        Me.chkHabilitaDTR.TabIndex = 20
        Me.chkHabilitaDTR.Text = "Manter DTR Ligado"
        Me.chkHabilitaDTR.UseVisualStyleBackColor = True
        '
        'lblParidade
        '
        Me.lblParidade.AutoSize = True
        Me.lblParidade.Location = New System.Drawing.Point(297, 30)
        Me.lblParidade.Name = "lblParidade"
        Me.lblParidade.Size = New System.Drawing.Size(52, 13)
        Me.lblParidade.TabIndex = 19
        Me.lblParidade.Text = "Paridade:"
        '
        'lblStopBits
        '
        Me.lblStopBits.AutoSize = True
        Me.lblStopBits.Location = New System.Drawing.Point(165, 67)
        Me.lblStopBits.Name = "lblStopBits"
        Me.lblStopBits.Size = New System.Drawing.Size(52, 13)
        Me.lblStopBits.TabIndex = 18
        Me.lblStopBits.Text = "Stop Bits:"
        '
        'lblDataBits
        '
        Me.lblDataBits.AutoSize = True
        Me.lblDataBits.Location = New System.Drawing.Point(165, 30)
        Me.lblDataBits.Name = "lblDataBits"
        Me.lblDataBits.Size = New System.Drawing.Size(53, 13)
        Me.lblDataBits.TabIndex = 17
        Me.lblDataBits.Text = "Data Bits:"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Location = New System.Drawing.Point(7, 67)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(61, 13)
        Me.lblBaudRate.TabIndex = 16
        Me.lblBaudRate.Text = "Baud Rate:"
        '
        'lblPortaSerial
        '
        Me.lblPortaSerial.AutoSize = True
        Me.lblPortaSerial.Location = New System.Drawing.Point(33, 30)
        Me.lblPortaSerial.Name = "lblPortaSerial"
        Me.lblPortaSerial.Size = New System.Drawing.Size(35, 13)
        Me.lblPortaSerial.TabIndex = 15
        Me.lblPortaSerial.Text = "Porta:"
        '
        'grpEthernet
        '
        Me.grpEthernet.Controls.Add(Me.rdbUDP)
        Me.grpEthernet.Controls.Add(Me.rdbTCP)
        Me.grpEthernet.Controls.Add(Me.txtPortaEthernet)
        Me.grpEthernet.Controls.Add(Me.txtEndEthernet)
        Me.grpEthernet.Controls.Add(Me.lblPortaEth)
        Me.grpEthernet.Controls.Add(Me.lblIPAddress)
        Me.grpEthernet.Enabled = False
        Me.grpEthernet.Location = New System.Drawing.Point(12, 201)
        Me.grpEthernet.Name = "grpEthernet"
        Me.grpEthernet.Size = New System.Drawing.Size(441, 113)
        Me.grpEthernet.TabIndex = 16
        Me.grpEthernet.TabStop = False
        '
        'rdbUDP
        '
        Me.rdbUDP.AutoSize = True
        Me.rdbUDP.Location = New System.Drawing.Point(249, 15)
        Me.rdbUDP.Name = "rdbUDP"
        Me.rdbUDP.Size = New System.Drawing.Size(63, 17)
        Me.rdbUDP.TabIndex = 22
        Me.rdbUDP.Text = "UDP/IP"
        Me.rdbUDP.UseVisualStyleBackColor = True
        '
        'rdbTCP
        '
        Me.rdbTCP.AutoSize = True
        Me.rdbTCP.Checked = True
        Me.rdbTCP.Location = New System.Drawing.Point(124, 15)
        Me.rdbTCP.Name = "rdbTCP"
        Me.rdbTCP.Size = New System.Drawing.Size(61, 17)
        Me.rdbTCP.TabIndex = 21
        Me.rdbTCP.TabStop = True
        Me.rdbTCP.Text = "TCP/IP"
        Me.rdbTCP.UseVisualStyleBackColor = True
        '
        'txtPortaEthernet
        '
        Me.txtPortaEthernet.Location = New System.Drawing.Point(114, 75)
        Me.txtPortaEthernet.Name = "txtPortaEthernet"
        Me.txtPortaEthernet.Size = New System.Drawing.Size(95, 20)
        Me.txtPortaEthernet.TabIndex = 20
        Me.txtPortaEthernet.Text = "5001"
        '
        'txtEndEthernet
        '
        Me.txtEndEthernet.Location = New System.Drawing.Point(114, 41)
        Me.txtEndEthernet.Name = "txtEndEthernet"
        Me.txtEndEthernet.Size = New System.Drawing.Size(209, 20)
        Me.txtEndEthernet.TabIndex = 18
        Me.txtEndEthernet.Text = "192.168.0.35"
        '
        'lblPortaEth
        '
        Me.lblPortaEth.AutoSize = True
        Me.lblPortaEth.Location = New System.Drawing.Point(71, 78)
        Me.lblPortaEth.Name = "lblPortaEth"
        Me.lblPortaEth.Size = New System.Drawing.Size(35, 13)
        Me.lblPortaEth.TabIndex = 17
        Me.lblPortaEth.Text = "Porta:"
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(7, 44)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(101, 13)
        Me.lblIPAddress.TabIndex = 15
        Me.lblIPAddress.Text = "Endereço (IP, host):"
        '
        'rdbSerial
        '
        Me.rdbSerial.AutoSize = True
        Me.rdbSerial.Checked = True
        Me.rdbSerial.Location = New System.Drawing.Point(22, 12)
        Me.rdbSerial.Name = "rdbSerial"
        Me.rdbSerial.Size = New System.Drawing.Size(51, 17)
        Me.rdbSerial.TabIndex = 17
        Me.rdbSerial.TabStop = True
        Me.rdbSerial.Text = "Serial"
        Me.rdbSerial.UseVisualStyleBackColor = True
        '
        'rdbEthernet
        '
        Me.rdbEthernet.AutoSize = True
        Me.rdbEthernet.Location = New System.Drawing.Point(18, 188)
        Me.rdbEthernet.Name = "rdbEthernet"
        Me.rdbEthernet.Size = New System.Drawing.Size(65, 17)
        Me.rdbEthernet.TabIndex = 19
        Me.rdbEthernet.Text = "Ethernet"
        Me.rdbEthernet.UseVisualStyleBackColor = True
        '
        'lblAtrasoDadosRecebidos
        '
        Me.lblAtrasoDadosRecebidos.AutoSize = True
        Me.lblAtrasoDadosRecebidos.Location = New System.Drawing.Point(19, 334)
        Me.lblAtrasoDadosRecebidos.Name = "lblAtrasoDadosRecebidos"
        Me.lblAtrasoDadosRecebidos.Size = New System.Drawing.Size(224, 13)
        Me.lblAtrasoDadosRecebidos.TabIndex = 26
        Me.lblAtrasoDadosRecebidos.Text = "Atraso para exibição de dados recebidos (ms):"
        '
        'txtTempoAtrasoDadosReceb
        '
        Me.txtTempoAtrasoDadosReceb.Location = New System.Drawing.Point(249, 331)
        Me.txtTempoAtrasoDadosReceb.Name = "txtTempoAtrasoDadosReceb"
        Me.txtTempoAtrasoDadosReceb.Size = New System.Drawing.Size(74, 20)
        Me.txtTempoAtrasoDadosReceb.TabIndex = 28
        Me.txtTempoAtrasoDadosReceb.Text = "20"
        '
        'dlgConfComunicacao
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(465, 426)
        Me.Controls.Add(Me.txtTempoAtrasoDadosReceb)
        Me.Controls.Add(Me.lblAtrasoDadosRecebidos)
        Me.Controls.Add(Me.rdbEthernet)
        Me.Controls.Add(Me.rdbSerial)
        Me.Controls.Add(Me.grpEthernet)
        Me.Controls.Add(Me.grpSerial)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConfComunicacao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Porta de Comunicação"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpSerial.ResumeLayout(False)
        Me.grpSerial.PerformLayout()
        Me.grpEthernet.ResumeLayout(False)
        Me.grpEthernet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents grpSerial As System.Windows.Forms.GroupBox
    Friend WithEvents cmbHandshake As System.Windows.Forms.ComboBox
    Friend WithEvents lblHandshake As System.Windows.Forms.Label
    Friend WithEvents cmbParidade As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDataBits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPortaSerial As System.Windows.Forms.ComboBox
    Friend WithEvents chkHabilitaRTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkHabilitaDTR As System.Windows.Forms.CheckBox
    Friend WithEvents lblParidade As System.Windows.Forms.Label
    Friend WithEvents lblStopBits As System.Windows.Forms.Label
    Friend WithEvents lblDataBits As System.Windows.Forms.Label
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
    Friend WithEvents lblPortaSerial As System.Windows.Forms.Label
    Friend WithEvents rdbSerial As System.Windows.Forms.RadioButton
    Friend WithEvents grpEthernet As System.Windows.Forms.GroupBox
    Friend WithEvents lblPortaEth As System.Windows.Forms.Label
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents rdbEthernet As System.Windows.Forms.RadioButton
    Friend WithEvents txtPortaEthernet As System.Windows.Forms.TextBox
    Friend WithEvents txtEndEthernet As System.Windows.Forms.TextBox
    Friend WithEvents rdbUDP As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTCP As System.Windows.Forms.RadioButton
    Friend WithEvents lblAtrasoDadosRecebidos As System.Windows.Forms.Label
    Friend WithEvents txtTempoAtrasoDadosReceb As System.Windows.Forms.TextBox
    Friend WithEvents cmbStopBits As System.Windows.Forms.ComboBox

End Class
