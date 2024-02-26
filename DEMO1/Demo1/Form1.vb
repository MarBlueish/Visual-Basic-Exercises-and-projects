Public Class cmd_demo1
    Private Sub cmd_inicio_Click(sender As Object, e As EventArgs) Handles cmd_inicio.Click
        cmd_inicio.Enabled = False
        cmd_sair.Enabled = True
        cmd_mostrar.Enabled = True


    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End

    End Sub

    Private Sub cmd_esconder_Click(sender As Object, e As EventArgs) Handles cmd_esconder.Click
        cmd_mostrar.Enabled = True
        cmd_esconder.Enabled = False



    End Sub

    Private Sub cmd_mostrar_Click(sender As Object, e As EventArgs) Handles cmd_mostrar.Click
        cmd_image.Show()
        cmd_mostrar.Enabled = False
        cmd_esconder.Enabled = True





    End Sub
End Class
