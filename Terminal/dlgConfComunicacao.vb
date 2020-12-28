Imports System.Windows.Forms

Public Class dlgConfComunicacao

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Ao ser clicado o botão OK da caixa de diálogo, verifica o tipo de porta
        ' selecionado e atualiza as configurações do software

        'Se selecionada porta serial
        If (rdbSerial.Checked) Then
            'Atualiza as configurações para a porta serial de acordo com as escolhas na caixa de diálogo
            frmPrincipal.SerialPort1.PortName = cmbPortaSerial.Text 'Seleção da Porta Serial
            frmPrincipal.SerialPort1.BaudRate = cmbBaudRate.Text    'Seleção do Baud Rate
            frmPrincipal.SerialPort1.DataBits = cmbDataBits.Text    'Seleção de Bits de Dados
            Select Case (cmbStopBits.Text)                          'Seleção de Bits de Parada (Stop Bits)
                Case "1"
                    frmPrincipal.SerialPort1.StopBits = IO.Ports.StopBits.One
                Case "1,5"
                    frmPrincipal.SerialPort1.StopBits = IO.Ports.StopBits.OnePointFive
                Case "2"
                    frmPrincipal.SerialPort1.StopBits = IO.Ports.StopBits.Two
            End Select
            Select Case (cmbParidade.Text)                               'Seleção de Paridade
                Case "Nenhum"
                    frmPrincipal.SerialPort1.Parity = IO.Ports.Parity.None
                Case "Par (Even)"
                    frmPrincipal.SerialPort1.Parity = IO.Ports.Parity.Even
                Case "Ímpar (Odd)"
                    frmPrincipal.SerialPort1.Parity = IO.Ports.Parity.Odd
                Case "Marca"
                    frmPrincipal.SerialPort1.Parity = IO.Ports.Parity.Mark
                Case "Espaço"
                    frmPrincipal.SerialPort1.Parity = IO.Ports.Parity.Space
            End Select
            Select Case (cmbHandshake.Text)                               'Seleção de Paridade
                Case "Nenhum"
                    frmPrincipal.SerialPort1.Handshake = IO.Ports.Handshake.None
                Case "Xon/Xoff"
                    frmPrincipal.SerialPort1.Handshake = IO.Ports.Handshake.XOnXOff
                Case "Hardware"
                    frmPrincipal.SerialPort1.Handshake = IO.Ports.Handshake.RequestToSend
            End Select
            frmPrincipal.SerialPort1.RtsEnable = chkHabilitaRTS.Checked     'Habilita sinal RTS (Request to Send)
            frmPrincipal.SerialPort1.DtrEnable = chkHabilitaDTR.Checked     'Habilita sinal DTR (Data Transfer Ready)
        End If

        'Tempo de atraso para consolidação de todos os dados recebidos (evitar quebra de dados)
        frmPrincipal.tmrDadReceb.Interval = txtTempoAtrasoDadosReceb.Text
        'Atualiza barra de status do frmPrincipal com as configurações de porta selecionadas
        frmPrincipal.AtualizaStripStatus()
        'Retorna "OK" como resultado da caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Fecha caixa de diálogo
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Retorna "Cancel" como resultado da caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'Fecha caixa de diálogo
        Me.Close()
    End Sub

    Private Sub rdbSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSerial.CheckedChanged
        'Habilita grupo de configurações para serial, se for escolhida porta serial
        ' e desabilita grupo de configurações para Ethernet
        grpSerial.Enabled = True
        grpEthernet.Enabled = False
    End Sub

    Private Sub rdbEthernet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEthernet.CheckedChanged
        'Habilita grupo de configurações para Ethernet, se for escolhida porta Ethernet
        ' e desabilita grupo de configurações para serial
        grpSerial.Enabled = False
        grpEthernet.Enabled = True
    End Sub

    Private Sub dlgConfComunicacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtTempoAtrasoDadosReceb.Text = frmPrincipal.tmrDadReceb.Interval
    End Sub
End Class
