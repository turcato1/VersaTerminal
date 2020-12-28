Imports System.Windows.Forms
Imports Terminal.frmPrincipal

Public Class dlgExibirOpcoes

    'Struct com opções de exibição do histórico
    Public Structure Exibicao
        Public CorStringRec As System.Drawing.Color   'Cor do texto recebido
        Public CorStringEnv As System.Drawing.Color   'Cor do texto enviado
        Public FonteTextoHist As System.Drawing.Font  'Fonte de letra do histórico
        Public bExibirStringCod As Boolean            'Opção exibe/não exibe string com códigos especiais entre < >
        Public bExibirStringPlena As Boolean          'Opção exibe/não exibe string plena
        Public bExibirNumLinha As Boolean             'Opção exibe/não exibe número da linha no histórico
    End Structure

    Public Shared OpcExibicao As Exibicao  'Variável das opções de exibição selecionadas
    Public clStringRec, clStringEnv As System.Drawing.Color 'Variáveis temporárias para seleção de cor do texto de envio e recebimento
    Public fntHist As System.Drawing.Font 'Variável temporária do tipo de fonte de letra

    Private Sub AtualizaTextoExib()
        'Subrotina de atualização do texto exibido como exemplo na caixa de diálogo de opções

        Dim sTextoExibe As String 'String do texto de exemplo

        'Montagem do texto de exemplo
        sTextoExibe = vbCrLf
        If chkExibeNumLinha.Checked Then sTextoExibe = sTextoExibe & "1: "
        If chkExibeStringCod.Checked Then sTextoExibe = sTextoExibe & "<STX>ABC123@%&<ETX>   "
        If chkExibeStringPlena.Checked Then sTextoExibe = sTextoExibe & Chr(&H2) & "ABC123@%&" & Chr(&H3)

        'Modificação da fonte e cor do texto de exemplo para strings enviadas
        rchStringEnvExib.Font = OpcExibicao.FonteTextoHist
        fntHist = OpcExibicao.FonteTextoHist
        rchStringEnvExib.Text = sTextoExibe
        rchStringEnvExib.ForeColor = clStringEnv

        'Modificação da fonte e cor do texto de exemplo para strings recebidas
        rchStringRecExib.Font = OpcExibicao.FonteTextoHist
        rchStringRecExib.Text = sTextoExibe
        rchStringRecExib.ForeColor = clStringRec
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Atualização das definições de opção armazenadas no struct OpcExibição ao clicar OK na caixa de diálogo
        OpcExibicao.bExibirStringPlena = chkExibeStringPlena.Checked 'Exbição de string plena
        OpcExibicao.bExibirStringCod = chkExibeStringCod.Checked     'Exbição de string com < >
        OpcExibicao.bExibirNumLinha = chkExibeNumLinha.Checked       'Exibição de número de linha
        OpcExibicao.CorStringRec = clStringRec                       'Cor do texto para strings recebidas
        OpcExibicao.CorStringEnv = clStringEnv                       'Cor do texto para strings enviadas
        OpcExibicao.FonteTextoHist = fntHist                         'Fonte de letra do histórico
        frmPrincipal.rchtxtDadosEnvRec.Font = OpcExibicao.FonteTextoHist
        'Devolve resultado "OK" e fecha caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Devolve resultado "Cancel" e fecha caixa de diálogo
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgExibirOpções_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carrega opções previamente armazenadas no struct OpcExibição ao abrir a caixa de diálogo de opções
        chkExibeStringPlena.Checked = OpcExibicao.bExibirStringPlena
        chkExibeStringCod.Checked = OpcExibicao.bExibirStringCod
        chkExibeNumLinha.Checked = OpcExibicao.bExibirNumLinha
        rchStringEnvExib.ForeColor = OpcExibicao.CorStringEnv
        rchStringEnvExib.ForeColor = OpcExibicao.CorStringRec
        rchStringRecExib.Font = OpcExibicao.FonteTextoHist
        rchStringEnvExib.Font = OpcExibicao.FonteTextoHist
        dlgFonte.Font = OpcExibicao.FonteTextoHist
        btnCorStrEnviada.ForeColor = OpcExibicao.CorStringEnv
        clStringEnv = OpcExibicao.CorStringEnv
        btnCorStrRecebida.ForeColor = OpcExibicao.CorStringRec
        clStringRec = OpcExibicao.CorStringRec
        'Atualiza textos de exemplo da caixa de diálogo de opções
        AtualizaTextoExib()
    End Sub

    Private Sub chkExibeStringPlena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExibeStringPlena.CheckedChanged
        'Atualiza textos de exemplo da caixa de diálogo de opções, quando a opção de exibição de string plena é alterada
        AtualizaTextoExib()
    End Sub

    Private Sub chkExibeStringCod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExibeStringCod.CheckedChanged
        'Atualiza textos de exemplo da caixa de diálogo de opções, quando a opção de exibição de string com < > é alterada
        AtualizaTextoExib()
    End Sub

    Private Sub chkExibeNumLinha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExibeNumLinha.CheckedChanged
        'Atualiza textos de exemplo da caixa de diálogo de opções, quando a opção de exibição número de linha é alterada
        AtualizaTextoExib()
    End Sub

    Private Sub btnCorStrRecebida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorStrRecebida.Click
        'Ao ser clicado o botão de alteração de cor, trata as informações de cor escolhida pela cx de diálogo de cor dlgCor para strings recebidas
        dlgCor.Color = OpcExibicao.CorStringRec 'Carrega cor atualmente escolhida para dlgCor
        dlgCor.ShowDialog() 'Exibe dlgCor
        clStringRec = dlgCor.Color 'Atualiza nova cor escolhida em dlgCor
        btnCorStrRecebida.ForeColor = dlgCor.Color 'Muda cor do texto do botão de escolha da cor na cx de diálogo de opções
        'Atualiza textos de exemplo com a cor escolhida
        AtualizaTextoExib()
    End Sub

    Private Sub btnCorStrEnviada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorStrEnviada.Click
        'Ao ser clicado o botão de alteração de cor, trata as informações de cor escolhida pela cx de diálogo de cor dlgCor para strings enviadas
        dlgCor.Color = OpcExibicao.CorStringEnv 'Carrega cor atualmente escolhida para dlgCor
        dlgCor.ShowDialog() 'Exibe dlgCor
        clStringEnv = dlgCor.Color 'Atualiza nova cor escolhida em dlgCor
        btnCorStrEnviada.ForeColor = dlgCor.Color 'Muda cor do texto do botão de escolha da cor na cx de diálogo de opções
        'Atualiza textos de exemplo com a cor escolhida
        AtualizaTextoExib()
    End Sub

    Private Sub btnFonteHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFonteHistorico.Click
        'Ao ser clicado o botão de alteração de fonte, trata as informações de fonte escolhida pela cx de diálogo de cor dlgFonte para o histórico
        dlgFonte.Font = OpcExibicao.FonteTextoHist 'Carrega fonte atualmente escolhida para dlgFonte
        dlgFonte.ShowDialog() 'Exibe dlgFonte
        fntHist = dlgFonte.Font 'Atualiza nova fonte escolhida em dlgFonte
        'Atualiza textos de exemplo com a fonte escolhida
        AtualizaTextoExib()
    End Sub
End Class
