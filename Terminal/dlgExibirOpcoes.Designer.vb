<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExibirOpcoes
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
        Me.dlgCor = New System.Windows.Forms.ColorDialog
        Me.dlgFonte = New System.Windows.Forms.FontDialog
        Me.btnFonteHistorico = New System.Windows.Forms.Button
        Me.btnCorStrEnviada = New System.Windows.Forms.Button
        Me.btnCorStrRecebida = New System.Windows.Forms.Button
        Me.chkExibeStringCod = New System.Windows.Forms.CheckBox
        Me.chkExibeStringPlena = New System.Windows.Forms.CheckBox
        Me.chkExibeNumLinha = New System.Windows.Forms.CheckBox
        Me.lblTextoEnvExib = New System.Windows.Forms.Label
        Me.lblTextoRecebExib = New System.Windows.Forms.Label
        Me.rchStringEnvExib = New System.Windows.Forms.RichTextBox
        Me.rchStringRecExib = New System.Windows.Forms.RichTextBox
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(290, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
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
        'btnFonteHistorico
        '
        Me.btnFonteHistorico.Location = New System.Drawing.Point(302, 248)
        Me.btnFonteHistorico.Name = "btnFonteHistorico"
        Me.btnFonteHistorico.Size = New System.Drawing.Size(134, 32)
        Me.btnFonteHistorico.TabIndex = 30
        Me.btnFonteHistorico.Text = "Fonte do histórico"
        Me.btnFonteHistorico.UseVisualStyleBackColor = True
        '
        'btnCorStrEnviada
        '
        Me.btnCorStrEnviada.Location = New System.Drawing.Point(162, 248)
        Me.btnCorStrEnviada.Name = "btnCorStrEnviada"
        Me.btnCorStrEnviada.Size = New System.Drawing.Size(134, 32)
        Me.btnCorStrEnviada.TabIndex = 29
        Me.btnCorStrEnviada.Text = "Cor da string enviada"
        Me.btnCorStrEnviada.UseVisualStyleBackColor = True
        '
        'btnCorStrRecebida
        '
        Me.btnCorStrRecebida.Location = New System.Drawing.Point(22, 248)
        Me.btnCorStrRecebida.Name = "btnCorStrRecebida"
        Me.btnCorStrRecebida.Size = New System.Drawing.Size(134, 32)
        Me.btnCorStrRecebida.TabIndex = 28
        Me.btnCorStrRecebida.Text = "Cor da string recebida"
        Me.btnCorStrRecebida.UseVisualStyleBackColor = True
        '
        'chkExibeStringCod
        '
        Me.chkExibeStringCod.AutoSize = True
        Me.chkExibeStringCod.Checked = True
        Me.chkExibeStringCod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExibeStringCod.Location = New System.Drawing.Point(14, 196)
        Me.chkExibeStringCod.Name = "chkExibeStringCod"
        Me.chkExibeStringCod.Size = New System.Drawing.Size(357, 17)
        Me.chkExibeStringCod.TabIndex = 27
        Me.chkExibeStringCod.Text = "Exibir string com caracteres especiais convertidos em código entre < >"
        Me.chkExibeStringCod.UseVisualStyleBackColor = True
        '
        'chkExibeStringPlena
        '
        Me.chkExibeStringPlena.AutoSize = True
        Me.chkExibeStringPlena.Location = New System.Drawing.Point(14, 173)
        Me.chkExibeStringPlena.Name = "chkExibeStringPlena"
        Me.chkExibeStringPlena.Size = New System.Drawing.Size(234, 17)
        Me.chkExibeStringPlena.TabIndex = 26
        Me.chkExibeStringPlena.Text = "Exibir string plena, com caracteres especiais"
        Me.chkExibeStringPlena.UseVisualStyleBackColor = True
        '
        'chkExibeNumLinha
        '
        Me.chkExibeNumLinha.AutoSize = True
        Me.chkExibeNumLinha.Checked = True
        Me.chkExibeNumLinha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExibeNumLinha.Location = New System.Drawing.Point(14, 219)
        Me.chkExibeNumLinha.Name = "chkExibeNumLinha"
        Me.chkExibeNumLinha.Size = New System.Drawing.Size(138, 17)
        Me.chkExibeNumLinha.TabIndex = 25
        Me.chkExibeNumLinha.Text = "Exibir o número da linha"
        Me.chkExibeNumLinha.UseVisualStyleBackColor = True
        '
        'lblTextoEnvExib
        '
        Me.lblTextoEnvExib.AutoSize = True
        Me.lblTextoEnvExib.Location = New System.Drawing.Point(51, 96)
        Me.lblTextoEnvExib.Name = "lblTextoEnvExib"
        Me.lblTextoEnvExib.Size = New System.Drawing.Size(166, 13)
        Me.lblTextoEnvExib.TabIndex = 24
        Me.lblTextoEnvExib.Text = "Como a string enviada aparecerá:"
        '
        'lblTextoRecebExib
        '
        Me.lblTextoRecebExib.AutoSize = True
        Me.lblTextoRecebExib.Location = New System.Drawing.Point(51, 24)
        Me.lblTextoRecebExib.Name = "lblTextoRecebExib"
        Me.lblTextoRecebExib.Size = New System.Drawing.Size(169, 13)
        Me.lblTextoRecebExib.TabIndex = 23
        Me.lblTextoRecebExib.Text = "Como a string recebida aparecerá:"
        '
        'rchStringEnvExib
        '
        Me.rchStringEnvExib.Location = New System.Drawing.Point(54, 112)
        Me.rchStringEnvExib.Name = "rchStringEnvExib"
        Me.rchStringEnvExib.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rchStringEnvExib.Size = New System.Drawing.Size(336, 46)
        Me.rchStringEnvExib.TabIndex = 22
        Me.rchStringEnvExib.Text = ""
        '
        'rchStringRecExib
        '
        Me.rchStringRecExib.Location = New System.Drawing.Point(54, 40)
        Me.rchStringRecExib.Name = "rchStringRecExib"
        Me.rchStringRecExib.Size = New System.Drawing.Size(336, 46)
        Me.rchStringRecExib.TabIndex = 21
        Me.rchStringRecExib.Text = ""
        '
        'dlgExibirOpcoes
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(448, 347)
        Me.Controls.Add(Me.btnFonteHistorico)
        Me.Controls.Add(Me.btnCorStrEnviada)
        Me.Controls.Add(Me.btnCorStrRecebida)
        Me.Controls.Add(Me.chkExibeStringCod)
        Me.Controls.Add(Me.chkExibeStringPlena)
        Me.Controls.Add(Me.chkExibeNumLinha)
        Me.Controls.Add(Me.lblTextoEnvExib)
        Me.Controls.Add(Me.lblTextoRecebExib)
        Me.Controls.Add(Me.rchStringEnvExib)
        Me.Controls.Add(Me.rchStringRecExib)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExibirOpcoes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opções de Exibição"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dlgCor As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgFonte As System.Windows.Forms.FontDialog
    Friend WithEvents btnFonteHistorico As System.Windows.Forms.Button
    Friend WithEvents btnCorStrEnviada As System.Windows.Forms.Button
    Friend WithEvents btnCorStrRecebida As System.Windows.Forms.Button
    Friend WithEvents chkExibeStringCod As System.Windows.Forms.CheckBox
    Friend WithEvents chkExibeStringPlena As System.Windows.Forms.CheckBox
    Friend WithEvents chkExibeNumLinha As System.Windows.Forms.CheckBox
    Friend WithEvents lblTextoEnvExib As System.Windows.Forms.Label
    Friend WithEvents lblTextoRecebExib As System.Windows.Forms.Label
    Friend WithEvents rchStringEnvExib As System.Windows.Forms.RichTextBox
    Friend WithEvents rchStringRecExib As System.Windows.Forms.RichTextBox

End Class
