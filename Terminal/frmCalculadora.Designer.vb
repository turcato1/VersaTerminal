<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Me.txtStrEntrCalc = New System.Windows.Forms.TextBox
        Me.txtStrSaidaCalc = New System.Windows.Forms.TextBox
        Me.btnCalcCRC32 = New System.Windows.Forms.Button
        Me.btnCalcCRC16 = New System.Windows.Forms.Button
        Me.btnCalcSumCheck = New System.Windows.Forms.Button
        Me.btnHexToASCII = New System.Windows.Forms.Button
        Me.btnASCIIToHex = New System.Windows.Forms.Button
        Me.BtnBinToHex = New System.Windows.Forms.Button
        Me.btnHexToBin = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btnRealToIEEE754_32 = New System.Windows.Forms.Button
        Me.btnIEEE754_32ToReal = New System.Windows.Forms.Button
        Me.btnIEEE754_64ToReal = New System.Windows.Forms.Button
        Me.btnRealToIEEE754_64 = New System.Windows.Forms.Button
        Me.lblEntrada = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLimpa = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtStrEntrCalc
        '
        Me.txtStrEntrCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrEntrCalc.Location = New System.Drawing.Point(50, 21)
        Me.txtStrEntrCalc.Name = "txtStrEntrCalc"
        Me.txtStrEntrCalc.Size = New System.Drawing.Size(232, 21)
        Me.txtStrEntrCalc.TabIndex = 43
        '
        'txtStrSaidaCalc
        '
        Me.txtStrSaidaCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrSaidaCalc.Location = New System.Drawing.Point(50, 64)
        Me.txtStrSaidaCalc.Name = "txtStrSaidaCalc"
        Me.txtStrSaidaCalc.Size = New System.Drawing.Size(232, 21)
        Me.txtStrSaidaCalc.TabIndex = 49
        '
        'btnCalcCRC32
        '
        Me.btnCalcCRC32.Enabled = False
        Me.btnCalcCRC32.Location = New System.Drawing.Point(118, 107)
        Me.btnCalcCRC32.Name = "btnCalcCRC32"
        Me.btnCalcCRC32.Size = New System.Drawing.Size(100, 36)
        Me.btnCalcCRC32.TabIndex = 52
        Me.btnCalcCRC32.Text = "CRC-32"
        Me.btnCalcCRC32.UseVisualStyleBackColor = True
        '
        'btnCalcCRC16
        '
        Me.btnCalcCRC16.Enabled = False
        Me.btnCalcCRC16.Location = New System.Drawing.Point(231, 107)
        Me.btnCalcCRC16.Name = "btnCalcCRC16"
        Me.btnCalcCRC16.Size = New System.Drawing.Size(100, 36)
        Me.btnCalcCRC16.TabIndex = 51
        Me.btnCalcCRC16.Text = "CRC-16"
        Me.btnCalcCRC16.UseVisualStyleBackColor = True
        '
        'btnCalcSumCheck
        '
        Me.btnCalcSumCheck.Location = New System.Drawing.Point(5, 107)
        Me.btnCalcSumCheck.Name = "btnCalcSumCheck"
        Me.btnCalcSumCheck.Size = New System.Drawing.Size(100, 36)
        Me.btnCalcSumCheck.TabIndex = 50
        Me.btnCalcSumCheck.Text = "Sum Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LRC"
        Me.btnCalcSumCheck.UseVisualStyleBackColor = True
        '
        'btnHexToASCII
        '
        Me.btnHexToASCII.Location = New System.Drawing.Point(118, 191)
        Me.btnHexToASCII.Name = "btnHexToASCII"
        Me.btnHexToASCII.Size = New System.Drawing.Size(100, 36)
        Me.btnHexToASCII.TabIndex = 53
        Me.btnHexToASCII.Text = "Hex -> ASCII"
        Me.btnHexToASCII.UseVisualStyleBackColor = True
        '
        'btnASCIIToHex
        '
        Me.btnASCIIToHex.Location = New System.Drawing.Point(118, 149)
        Me.btnASCIIToHex.Name = "btnASCIIToHex"
        Me.btnASCIIToHex.Size = New System.Drawing.Size(100, 36)
        Me.btnASCIIToHex.TabIndex = 54
        Me.btnASCIIToHex.Text = "ASCII -> Hex"
        Me.btnASCIIToHex.UseVisualStyleBackColor = True
        '
        'BtnBinToHex
        '
        Me.BtnBinToHex.Location = New System.Drawing.Point(231, 149)
        Me.BtnBinToHex.Name = "BtnBinToHex"
        Me.BtnBinToHex.Size = New System.Drawing.Size(100, 36)
        Me.BtnBinToHex.TabIndex = 57
        Me.BtnBinToHex.Text = "Bin -> Hex"
        Me.BtnBinToHex.UseVisualStyleBackColor = True
        '
        'btnHexToBin
        '
        Me.btnHexToBin.Location = New System.Drawing.Point(231, 191)
        Me.btnHexToBin.Name = "btnHexToBin"
        Me.btnHexToBin.Size = New System.Drawing.Size(100, 36)
        Me.btnHexToBin.TabIndex = 58
        Me.btnHexToBin.Text = "Hex -> Bin"
        Me.btnHexToBin.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(288, 61)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(36, 26)
        Me.Button8.TabIndex = 60
        Me.Button8.Text = ">>"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(288, 18)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(36, 26)
        Me.Button9.TabIndex = 61
        Me.Button9.Text = "<<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btnRealToIEEE754_32
        '
        Me.btnRealToIEEE754_32.Enabled = False
        Me.btnRealToIEEE754_32.Location = New System.Drawing.Point(5, 149)
        Me.btnRealToIEEE754_32.Name = "btnRealToIEEE754_32"
        Me.btnRealToIEEE754_32.Size = New System.Drawing.Size(100, 36)
        Me.btnRealToIEEE754_32.TabIndex = 62
        Me.btnRealToIEEE754_32.Text = "Real -> IEEE-754 32 bits (Hex)"
        Me.btnRealToIEEE754_32.UseVisualStyleBackColor = True
        '
        'btnIEEE754_32ToReal
        '
        Me.btnIEEE754_32ToReal.Enabled = False
        Me.btnIEEE754_32ToReal.Location = New System.Drawing.Point(5, 191)
        Me.btnIEEE754_32ToReal.Name = "btnIEEE754_32ToReal"
        Me.btnIEEE754_32ToReal.Size = New System.Drawing.Size(100, 36)
        Me.btnIEEE754_32ToReal.TabIndex = 63
        Me.btnIEEE754_32ToReal.Text = "IEEE-754 -> Real 32 bits (Hex)"
        Me.btnIEEE754_32ToReal.UseVisualStyleBackColor = True
        '
        'btnIEEE754_64ToReal
        '
        Me.btnIEEE754_64ToReal.Enabled = False
        Me.btnIEEE754_64ToReal.Location = New System.Drawing.Point(5, 233)
        Me.btnIEEE754_64ToReal.Name = "btnIEEE754_64ToReal"
        Me.btnIEEE754_64ToReal.Size = New System.Drawing.Size(100, 36)
        Me.btnIEEE754_64ToReal.TabIndex = 65
        Me.btnIEEE754_64ToReal.Text = "IEEE-754 -> Real 64 bits (Hex)"
        Me.btnIEEE754_64ToReal.UseVisualStyleBackColor = True
        '
        'btnRealToIEEE754_64
        '
        Me.btnRealToIEEE754_64.Enabled = False
        Me.btnRealToIEEE754_64.Location = New System.Drawing.Point(118, 233)
        Me.btnRealToIEEE754_64.Name = "btnRealToIEEE754_64"
        Me.btnRealToIEEE754_64.Size = New System.Drawing.Size(100, 36)
        Me.btnRealToIEEE754_64.TabIndex = 64
        Me.btnRealToIEEE754_64.Text = "Real -> IEEE-754 64 bits (Hex)"
        Me.btnRealToIEEE754_64.UseVisualStyleBackColor = True
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(2, 24)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(47, 13)
        Me.lblEntrada.TabIndex = 66
        Me.lblEntrada.Text = "Entrada:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Saída:"
        '
        'btnLimpa
        '
        Me.btnLimpa.Location = New System.Drawing.Point(231, 233)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(100, 36)
        Me.btnLimpa.TabIndex = 68
        Me.btnLimpa.Text = "LIMPA"
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 283)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.btnIEEE754_64ToReal)
        Me.Controls.Add(Me.btnRealToIEEE754_64)
        Me.Controls.Add(Me.btnIEEE754_32ToReal)
        Me.Controls.Add(Me.btnRealToIEEE754_32)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnHexToBin)
        Me.Controls.Add(Me.BtnBinToHex)
        Me.Controls.Add(Me.btnASCIIToHex)
        Me.Controls.Add(Me.btnHexToASCII)
        Me.Controls.Add(Me.btnCalcCRC32)
        Me.Controls.Add(Me.btnCalcCRC16)
        Me.Controls.Add(Me.btnCalcSumCheck)
        Me.Controls.Add(Me.txtStrSaidaCalc)
        Me.Controls.Add(Me.txtStrEntrCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCalculadora"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora para protocolos"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStrEntrCalc As System.Windows.Forms.TextBox
    Friend WithEvents txtStrSaidaCalc As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcCRC32 As System.Windows.Forms.Button
    Friend WithEvents btnCalcCRC16 As System.Windows.Forms.Button
    Friend WithEvents btnCalcSumCheck As System.Windows.Forms.Button
    Friend WithEvents btnHexToASCII As System.Windows.Forms.Button
    Friend WithEvents btnASCIIToHex As System.Windows.Forms.Button
    Friend WithEvents BtnBinToHex As System.Windows.Forms.Button
    Friend WithEvents btnHexToBin As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btnRealToIEEE754_32 As System.Windows.Forms.Button
    Friend WithEvents btnIEEE754_32ToReal As System.Windows.Forms.Button
    Friend WithEvents btnIEEE754_64ToReal As System.Windows.Forms.Button
    Friend WithEvents btnRealToIEEE754_64 As System.Windows.Forms.Button
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
End Class
