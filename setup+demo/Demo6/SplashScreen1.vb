Public NotInheritable Class SplashScreen1

    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Timer1.Start()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class
