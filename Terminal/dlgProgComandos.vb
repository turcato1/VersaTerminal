Imports System.Windows.Forms

Public Class dlgProgComandos

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Subrotina executada quando o botão OK é pressionado: Atualiza Status e fecha o diálogo de comandos

        Dim iLinhas As Integer 'Index do número da linha de comando pré-programado

        'Atualiza string com comandos a serem enviados ( sComando(<No.Comando>,<Linha>) ) para "Comando 1"
        For iLinhas = 0 To (rtxtComando1.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(1, (iLinhas + 1)) = rtxtComando1.Lines(iLinhas)
        Next
        'Atualiza o nome do "Comando 1" no botão do frmPrincipal
        frmPrincipal.btnComando1.Text = "Comando 1" & vbCrLf & "[" & txtNomeComando1.Text & "]"

        'Atualiza string com comandos a serem enviados ( sComando(<No.Comando>,<Linha>) ) para "Comando 2"
        For iLinhas = 0 To (rtxtComando2.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(2, (iLinhas + 1)) = rtxtComando2.Lines(iLinhas)
        Next
        'Atualiza o nome do "Comando 2" no botão do frmPrincipal
        frmPrincipal.btnComando2.Text = "Comando 2" & vbCrLf & "[" & txtNomeComando2.Text & "]"

        'Atualiza string com comandos a serem enviados ( sComando(<No.Comando>,<Linha>) ) para "Comando 3"
        For iLinhas = 0 To (rtxtComando3.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(3, (iLinhas + 1)) = rtxtComando3.Lines(iLinhas)
        Next
        'Atualiza o nome do "Comando 3" no botão do frmPrincipal
        frmPrincipal.btnComando3.Text = "Comando 3" & vbCrLf & "[" & txtNomeComando3.Text & "]"

        'Atualiza string com comandos a serem enviados ( sComando(<No.Comando>,<Linha>) ) para "Comando 4"
        For iLinhas = 0 To (rtxtComando4.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(4, (iLinhas + 1)) = rtxtComando4.Lines(iLinhas)
        Next
        'Atualiza o nome do "Comando 4" no botão do frmPrincipal
        frmPrincipal.btnComando4.Text = "Comando 4" & vbCrLf & "[" & txtNomeComando4.Text & "]"

        'Devolve resultado "OK" da caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Fecha a caixa de diálogo
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Devolve resultado "Cancel" da caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'Fecha a caixa de diálogo
        Me.Close()
    End Sub

    Private Sub chkHabilitaComando1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHabilitaComando1.CheckedChanged
        'Quando "Comando 1" é habilitado, muda o status do botão de disparo e grupo de edição do "Comando 1"
        With chkHabilitaComando1
            grpComando1.Enabled = .Checked
            frmPrincipal.btnComando1.Enabled = .Checked
        End With
    End Sub

    Private Sub chkHabilitaComando2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHabilitaComando2.CheckedChanged
        'Quando "Comando 2" é habilitado, muda o status do botão de disparo e grupo de edição do "Comando 2"
        With chkHabilitaComando2
            grpComando2.Enabled = .Checked
            frmPrincipal.btnComando2.Enabled = .Checked
        End With
    End Sub

    Private Sub chkHabilitaComando3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHabilitaComando3.CheckedChanged
        'Quando "Comando 3" é habilitado, muda o status do botão de disparo e grupo de edição do "Comando 3"
        With chkHabilitaComando3
            grpComando3.Enabled = .Checked
            frmPrincipal.btnComando3.Enabled = .Checked
        End With
    End Sub

    Private Sub chkHabilitaComando4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHabilitaComando4.CheckedChanged
        'Quando "Comando 4" é habilitado, muda o status do botão de disparo e grupo de edição do "Comando 4"
        With chkHabilitaComando4
            grpComando4.Enabled = .Checked
            frmPrincipal.btnComando4.Enabled = .Checked
        End With
    End Sub

    Private Sub dlgProgComandos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Subrotina que atualiza os comandos programados nas caixas de texto de edição
        Dim iLinhas, iComando As Integer 'Indexes de número de linha e número do comando
        Dim sTeste As String 'String temporária

        'Inicialização de variáveis
        iComando = 1
        rtxtComando1.Text = ""
        rtxtComando2.Text = ""
        rtxtComando3.Text = ""
        rtxtComando4.Text = ""

        'Atualiza as caixas de texto de edição
        Do Until (iComando >= 5)
            sTeste = frmPrincipal.sComando(iComando, iLinhas)
            iLinhas = 1
            Do Until ((frmPrincipal.sComando(iComando, iLinhas) = Nothing) Or (iLinhas >= 40))
                Select Case iComando
                    Case 1
                        rtxtComando1.AppendText(frmPrincipal.sComando(iComando, iLinhas) & vbCrLf)
                    Case 2
                        rtxtComando2.AppendText(frmPrincipal.sComando(iComando, iLinhas) & vbCrLf)
                    Case 3
                        rtxtComando3.AppendText(frmPrincipal.sComando(iComando, iLinhas) & vbCrLf)
                    Case 4
                        rtxtComando4.AppendText(frmPrincipal.sComando(iComando, iLinhas) & vbCrLf)
                End Select
                iLinhas = iLinhas + 1
            Loop
            iComando = iComando + 1
        Loop

    End Sub

    Private Sub btnSalvarComando1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarComando1.Click
        'Se o botão Salvar for apertado, grava modificações na string dos comandos, para Comando 1
        Dim iLinhas As Integer 'Variável do número da linha de comando

        'Varre todas as linhas da caixa de edição do comando e armazena na matriz de comandos sComando
        For iLinhas = 0 To (rtxtComando1.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(1, (iLinhas + 1)) = rtxtComando1.Lines(iLinhas)
        Next
        'Muda texto do botão de disparo do comando
        frmPrincipal.btnComando1.Text = "Comando 1" & vbCrLf & "[" & txtNomeComando1.Text & "]"
    End Sub

    Private Sub btnSalvarComando2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarComando2.Click
        'Se o botão Salvar for apertado, grava modificações na string dos comandos, para Comando 2
        Dim iLinhas As Integer

        'Varre todas as linhas da caixa de edição do comando e armazena na matriz de comandos sComando
        For iLinhas = 0 To (rtxtComando2.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(2, (iLinhas + 1)) = rtxtComando2.Lines(iLinhas)
        Next
        'Muda texto do botão de disparo do comando
        frmPrincipal.btnComando2.Text = "Comando 2" & vbCrLf & "[" & txtNomeComando2.Text & "]"
    End Sub

    Private Sub btnSalvarComando3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarComando3.Click
        'Se o botão Salvar for apertado, grava modificações na string dos comandos, para Comando 3
        Dim iLinhas As Integer

        'Varre todas as linhas da caixa de edição do comando e armazena na matriz de comandos sComando
        For iLinhas = 0 To (rtxtComando3.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(3, (iLinhas + 1)) = rtxtComando3.Lines(iLinhas)
        Next
        'Muda texto do botão de disparo do comando
        frmPrincipal.btnComando3.Text = "Comando 3" & vbCrLf & "[" & txtNomeComando3.Text & "]"
    End Sub

    Private Sub btnSalvarComando4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarComando4.Click
        'Se o botão Salvar for apertado, grava modificações na string dos comandos, para Comando 4
        Dim iLinhas As Integer

        'Varre todas as linhas da caixa de edição do comando e armazena na matriz de comandos sComando
        For iLinhas = 0 To (rtxtComando4.Lines.GetLength(0) - 1)
            frmPrincipal.sComando(4, (iLinhas + 1)) = rtxtComando4.Lines(iLinhas)
        Next
        'Muda texto do botão de disparo do comando
        frmPrincipal.btnComando4.Text = "Comando 4" & vbCrLf & "[" & txtNomeComando4.Text & "]"
    End Sub
End Class
