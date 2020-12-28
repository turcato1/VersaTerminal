<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProgComandos
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
        Me.tabComandos = New System.Windows.Forms.TabControl
        Me.tabComando1 = New System.Windows.Forms.TabPage
        Me.grpComando1 = New System.Windows.Forms.GroupBox
        Me.lblNomeCmd1 = New System.Windows.Forms.Label
        Me.txtNomeComando1 = New System.Windows.Forms.TextBox
        Me.btnSalvarComando1 = New System.Windows.Forms.Button
        Me.rtxtComando1 = New System.Windows.Forms.RichTextBox
        Me.chkHabilitaComando1 = New System.Windows.Forms.CheckBox
        Me.tabComando2 = New System.Windows.Forms.TabPage
        Me.grpComando2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNomeComando2 = New System.Windows.Forms.TextBox
        Me.btnSalvarComando2 = New System.Windows.Forms.Button
        Me.rtxtComando2 = New System.Windows.Forms.RichTextBox
        Me.chkHabilitaComando2 = New System.Windows.Forms.CheckBox
        Me.tabComando3 = New System.Windows.Forms.TabPage
        Me.grpComando3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNomeComando3 = New System.Windows.Forms.TextBox
        Me.btnSalvarComando3 = New System.Windows.Forms.Button
        Me.rtxtComando3 = New System.Windows.Forms.RichTextBox
        Me.chkHabilitaComando3 = New System.Windows.Forms.CheckBox
        Me.tabComando4 = New System.Windows.Forms.TabPage
        Me.grpComando4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNomeComando4 = New System.Windows.Forms.TextBox
        Me.btnSalvarComando4 = New System.Windows.Forms.Button
        Me.rtxtComando4 = New System.Windows.Forms.RichTextBox
        Me.chkHabilitaComando4 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabComandos.SuspendLayout()
        Me.tabComando1.SuspendLayout()
        Me.grpComando1.SuspendLayout()
        Me.tabComando2.SuspendLayout()
        Me.grpComando2.SuspendLayout()
        Me.tabComando3.SuspendLayout()
        Me.grpComando3.SuspendLayout()
        Me.tabComando4.SuspendLayout()
        Me.grpComando4.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(479, 415)
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
        'tabComandos
        '
        Me.tabComandos.Controls.Add(Me.tabComando1)
        Me.tabComandos.Controls.Add(Me.tabComando2)
        Me.tabComandos.Controls.Add(Me.tabComando3)
        Me.tabComandos.Controls.Add(Me.tabComando4)
        Me.tabComandos.Location = New System.Drawing.Point(7, 6)
        Me.tabComandos.Name = "tabComandos"
        Me.tabComandos.SelectedIndex = 0
        Me.tabComandos.Size = New System.Drawing.Size(625, 394)
        Me.tabComandos.TabIndex = 1
        '
        'tabComando1
        '
        Me.tabComando1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tabComando1.Controls.Add(Me.grpComando1)
        Me.tabComando1.Controls.Add(Me.chkHabilitaComando1)
        Me.tabComando1.Location = New System.Drawing.Point(4, 22)
        Me.tabComando1.Name = "tabComando1"
        Me.tabComando1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComando1.Size = New System.Drawing.Size(617, 368)
        Me.tabComando1.TabIndex = 0
        Me.tabComando1.Text = "Comando 1"
        Me.tabComando1.UseVisualStyleBackColor = True
        '
        'grpComando1
        '
        Me.grpComando1.Controls.Add(Me.lblNomeCmd1)
        Me.grpComando1.Controls.Add(Me.txtNomeComando1)
        Me.grpComando1.Controls.Add(Me.btnSalvarComando1)
        Me.grpComando1.Controls.Add(Me.rtxtComando1)
        Me.grpComando1.Enabled = False
        Me.grpComando1.Location = New System.Drawing.Point(11, 31)
        Me.grpComando1.Name = "grpComando1"
        Me.grpComando1.Size = New System.Drawing.Size(599, 330)
        Me.grpComando1.TabIndex = 1
        Me.grpComando1.TabStop = False
        '
        'lblNomeCmd1
        '
        Me.lblNomeCmd1.AutoSize = True
        Me.lblNomeCmd1.Location = New System.Drawing.Point(3, 14)
        Me.lblNomeCmd1.Name = "lblNomeCmd1"
        Me.lblNomeCmd1.Size = New System.Drawing.Size(110, 13)
        Me.lblNomeCmd1.TabIndex = 16
        Me.lblNomeCmd1.Text = "Nome do Comando 1:"
        '
        'txtNomeComando1
        '
        Me.txtNomeComando1.Location = New System.Drawing.Point(119, 11)
        Me.txtNomeComando1.MaxLength = 20
        Me.txtNomeComando1.Name = "txtNomeComando1"
        Me.txtNomeComando1.Size = New System.Drawing.Size(122, 20)
        Me.txtNomeComando1.TabIndex = 15
        '
        'btnSalvarComando1
        '
        Me.btnSalvarComando1.Location = New System.Drawing.Point(510, 293)
        Me.btnSalvarComando1.Name = "btnSalvarComando1"
        Me.btnSalvarComando1.Size = New System.Drawing.Size(83, 29)
        Me.btnSalvarComando1.TabIndex = 14
        Me.btnSalvarComando1.Text = "Aplicar"
        Me.btnSalvarComando1.UseVisualStyleBackColor = True
        '
        'rtxtComando1
        '
        Me.rtxtComando1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtComando1.Location = New System.Drawing.Point(6, 37)
        Me.rtxtComando1.Name = "rtxtComando1"
        Me.rtxtComando1.ShowSelectionMargin = True
        Me.rtxtComando1.Size = New System.Drawing.Size(587, 250)
        Me.rtxtComando1.TabIndex = 13
        Me.rtxtComando1.Text = ""
        Me.rtxtComando1.WordWrap = False
        '
        'chkHabilitaComando1
        '
        Me.chkHabilitaComando1.AutoSize = True
        Me.chkHabilitaComando1.Location = New System.Drawing.Point(16, 12)
        Me.chkHabilitaComando1.Name = "chkHabilitaComando1"
        Me.chkHabilitaComando1.Size = New System.Drawing.Size(118, 17)
        Me.chkHabilitaComando1.TabIndex = 0
        Me.chkHabilitaComando1.Text = "Habilita Comando 1"
        Me.chkHabilitaComando1.UseVisualStyleBackColor = True
        '
        'tabComando2
        '
        Me.tabComando2.Controls.Add(Me.grpComando2)
        Me.tabComando2.Controls.Add(Me.chkHabilitaComando2)
        Me.tabComando2.Location = New System.Drawing.Point(4, 22)
        Me.tabComando2.Name = "tabComando2"
        Me.tabComando2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComando2.Size = New System.Drawing.Size(617, 368)
        Me.tabComando2.TabIndex = 1
        Me.tabComando2.Text = "Comando 2"
        Me.tabComando2.UseVisualStyleBackColor = True
        '
        'grpComando2
        '
        Me.grpComando2.Controls.Add(Me.Label2)
        Me.grpComando2.Controls.Add(Me.txtNomeComando2)
        Me.grpComando2.Controls.Add(Me.btnSalvarComando2)
        Me.grpComando2.Controls.Add(Me.rtxtComando2)
        Me.grpComando2.Enabled = False
        Me.grpComando2.Location = New System.Drawing.Point(11, 31)
        Me.grpComando2.Name = "grpComando2"
        Me.grpComando2.Size = New System.Drawing.Size(599, 330)
        Me.grpComando2.TabIndex = 6
        Me.grpComando2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nome do Comando 2:"
        '
        'txtNomeComando2
        '
        Me.txtNomeComando2.Location = New System.Drawing.Point(119, 11)
        Me.txtNomeComando2.MaxLength = 20
        Me.txtNomeComando2.Name = "txtNomeComando2"
        Me.txtNomeComando2.Size = New System.Drawing.Size(122, 20)
        Me.txtNomeComando2.TabIndex = 15
        '
        'btnSalvarComando2
        '
        Me.btnSalvarComando2.Location = New System.Drawing.Point(510, 293)
        Me.btnSalvarComando2.Name = "btnSalvarComando2"
        Me.btnSalvarComando2.Size = New System.Drawing.Size(83, 29)
        Me.btnSalvarComando2.TabIndex = 14
        Me.btnSalvarComando2.Text = "Aplicar"
        Me.btnSalvarComando2.UseVisualStyleBackColor = True
        '
        'rtxtComando2
        '
        Me.rtxtComando2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtComando2.Location = New System.Drawing.Point(6, 37)
        Me.rtxtComando2.Name = "rtxtComando2"
        Me.rtxtComando2.Size = New System.Drawing.Size(587, 250)
        Me.rtxtComando2.TabIndex = 13
        Me.rtxtComando2.Text = ""
        '
        'chkHabilitaComando2
        '
        Me.chkHabilitaComando2.AutoSize = True
        Me.chkHabilitaComando2.Location = New System.Drawing.Point(16, 12)
        Me.chkHabilitaComando2.Name = "chkHabilitaComando2"
        Me.chkHabilitaComando2.Size = New System.Drawing.Size(118, 17)
        Me.chkHabilitaComando2.TabIndex = 3
        Me.chkHabilitaComando2.Text = "Habilita Comando 2"
        Me.chkHabilitaComando2.UseVisualStyleBackColor = True
        '
        'tabComando3
        '
        Me.tabComando3.Controls.Add(Me.grpComando3)
        Me.tabComando3.Controls.Add(Me.chkHabilitaComando3)
        Me.tabComando3.Location = New System.Drawing.Point(4, 22)
        Me.tabComando3.Name = "tabComando3"
        Me.tabComando3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComando3.Size = New System.Drawing.Size(617, 368)
        Me.tabComando3.TabIndex = 2
        Me.tabComando3.Text = "Comando 3"
        Me.tabComando3.UseVisualStyleBackColor = True
        '
        'grpComando3
        '
        Me.grpComando3.Controls.Add(Me.Label4)
        Me.grpComando3.Controls.Add(Me.txtNomeComando3)
        Me.grpComando3.Controls.Add(Me.btnSalvarComando3)
        Me.grpComando3.Controls.Add(Me.rtxtComando3)
        Me.grpComando3.Enabled = False
        Me.grpComando3.Location = New System.Drawing.Point(11, 31)
        Me.grpComando3.Name = "grpComando3"
        Me.grpComando3.Size = New System.Drawing.Size(599, 330)
        Me.grpComando3.TabIndex = 9
        Me.grpComando3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nome do Comando 3:"
        '
        'txtNomeComando3
        '
        Me.txtNomeComando3.Location = New System.Drawing.Point(119, 11)
        Me.txtNomeComando3.MaxLength = 20
        Me.txtNomeComando3.Name = "txtNomeComando3"
        Me.txtNomeComando3.Size = New System.Drawing.Size(122, 20)
        Me.txtNomeComando3.TabIndex = 15
        '
        'btnSalvarComando3
        '
        Me.btnSalvarComando3.Location = New System.Drawing.Point(510, 293)
        Me.btnSalvarComando3.Name = "btnSalvarComando3"
        Me.btnSalvarComando3.Size = New System.Drawing.Size(83, 29)
        Me.btnSalvarComando3.TabIndex = 14
        Me.btnSalvarComando3.Text = "Aplicar"
        Me.btnSalvarComando3.UseVisualStyleBackColor = True
        '
        'rtxtComando3
        '
        Me.rtxtComando3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtComando3.Location = New System.Drawing.Point(6, 37)
        Me.rtxtComando3.Name = "rtxtComando3"
        Me.rtxtComando3.Size = New System.Drawing.Size(587, 250)
        Me.rtxtComando3.TabIndex = 13
        Me.rtxtComando3.Text = ""
        '
        'chkHabilitaComando3
        '
        Me.chkHabilitaComando3.AutoSize = True
        Me.chkHabilitaComando3.Location = New System.Drawing.Point(16, 12)
        Me.chkHabilitaComando3.Name = "chkHabilitaComando3"
        Me.chkHabilitaComando3.Size = New System.Drawing.Size(118, 17)
        Me.chkHabilitaComando3.TabIndex = 6
        Me.chkHabilitaComando3.Text = "Habilita Comando 3"
        Me.chkHabilitaComando3.UseVisualStyleBackColor = True
        '
        'tabComando4
        '
        Me.tabComando4.Controls.Add(Me.grpComando4)
        Me.tabComando4.Controls.Add(Me.chkHabilitaComando4)
        Me.tabComando4.Location = New System.Drawing.Point(4, 22)
        Me.tabComando4.Name = "tabComando4"
        Me.tabComando4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComando4.Size = New System.Drawing.Size(617, 368)
        Me.tabComando4.TabIndex = 3
        Me.tabComando4.Text = "Comando 4"
        Me.tabComando4.UseVisualStyleBackColor = True
        '
        'grpComando4
        '
        Me.grpComando4.Controls.Add(Me.Label5)
        Me.grpComando4.Controls.Add(Me.txtNomeComando4)
        Me.grpComando4.Controls.Add(Me.btnSalvarComando4)
        Me.grpComando4.Controls.Add(Me.rtxtComando4)
        Me.grpComando4.Enabled = False
        Me.grpComando4.Location = New System.Drawing.Point(11, 31)
        Me.grpComando4.Name = "grpComando4"
        Me.grpComando4.Size = New System.Drawing.Size(599, 330)
        Me.grpComando4.TabIndex = 9
        Me.grpComando4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nome do Comando 4:"
        '
        'txtNomeComando4
        '
        Me.txtNomeComando4.Location = New System.Drawing.Point(119, 11)
        Me.txtNomeComando4.MaxLength = 20
        Me.txtNomeComando4.Name = "txtNomeComando4"
        Me.txtNomeComando4.Size = New System.Drawing.Size(122, 20)
        Me.txtNomeComando4.TabIndex = 15
        '
        'btnSalvarComando4
        '
        Me.btnSalvarComando4.Location = New System.Drawing.Point(510, 293)
        Me.btnSalvarComando4.Name = "btnSalvarComando4"
        Me.btnSalvarComando4.Size = New System.Drawing.Size(83, 29)
        Me.btnSalvarComando4.TabIndex = 14
        Me.btnSalvarComando4.Text = "Aplicar"
        Me.btnSalvarComando4.UseVisualStyleBackColor = True
        '
        'rtxtComando4
        '
        Me.rtxtComando4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtComando4.Location = New System.Drawing.Point(6, 37)
        Me.rtxtComando4.Name = "rtxtComando4"
        Me.rtxtComando4.Size = New System.Drawing.Size(587, 250)
        Me.rtxtComando4.TabIndex = 13
        Me.rtxtComando4.Text = ""
        '
        'chkHabilitaComando4
        '
        Me.chkHabilitaComando4.AutoSize = True
        Me.chkHabilitaComando4.Location = New System.Drawing.Point(16, 12)
        Me.chkHabilitaComando4.Name = "chkHabilitaComando4"
        Me.chkHabilitaComando4.Size = New System.Drawing.Size(118, 17)
        Me.chkHabilitaComando4.TabIndex = 6
        Me.chkHabilitaComando4.Text = "Habilita Comando 4"
        Me.chkHabilitaComando4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nome do Comando 1:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 11)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(510, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(587, 250)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nome do Comando 2:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 11)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(122, 20)
        Me.TextBox3.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(510, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 29)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Salvar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(6, 37)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(587, 250)
        Me.RichTextBox3.TabIndex = 13
        Me.RichTextBox3.Text = ""
        '
        'dlgProgComandos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(637, 456)
        Me.Controls.Add(Me.tabComandos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgProgComandos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Programar Comandos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabComandos.ResumeLayout(False)
        Me.tabComando1.ResumeLayout(False)
        Me.tabComando1.PerformLayout()
        Me.grpComando1.ResumeLayout(False)
        Me.grpComando1.PerformLayout()
        Me.tabComando2.ResumeLayout(False)
        Me.tabComando2.PerformLayout()
        Me.grpComando2.ResumeLayout(False)
        Me.grpComando2.PerformLayout()
        Me.tabComando3.ResumeLayout(False)
        Me.tabComando3.PerformLayout()
        Me.grpComando3.ResumeLayout(False)
        Me.grpComando3.PerformLayout()
        Me.tabComando4.ResumeLayout(False)
        Me.tabComando4.PerformLayout()
        Me.grpComando4.ResumeLayout(False)
        Me.grpComando4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents tabComandos As System.Windows.Forms.TabControl
    Friend WithEvents tabComando1 As System.Windows.Forms.TabPage
    Friend WithEvents tabComando2 As System.Windows.Forms.TabPage
    Friend WithEvents tabComando3 As System.Windows.Forms.TabPage
    Friend WithEvents chkHabilitaComando1 As System.Windows.Forms.CheckBox
    Friend WithEvents tabComando4 As System.Windows.Forms.TabPage
    Friend WithEvents chkHabilitaComando2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHabilitaComando3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHabilitaComando4 As System.Windows.Forms.CheckBox
    Friend WithEvents grpComando1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNomeCmd1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeComando1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarComando1 As System.Windows.Forms.Button
    Friend WithEvents rtxtComando1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents grpComando2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomeComando2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarComando2 As System.Windows.Forms.Button
    Friend WithEvents rtxtComando2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents grpComando3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomeComando3 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarComando3 As System.Windows.Forms.Button
    Friend WithEvents rtxtComando3 As System.Windows.Forms.RichTextBox
    Friend WithEvents grpComando4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomeComando4 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarComando4 As System.Windows.Forms.Button
    Friend WithEvents rtxtComando4 As System.Windows.Forms.RichTextBox

End Class
