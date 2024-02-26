Public Class Form1
    Private Sub cmd_verifica_numero_Click(sender As Object, e As EventArgs) Handles cmd_verifica_numero.Click
        Dim n As Integer
        n = Val(txt_n1.Text)

        If n > 0 Then
            lbl_n1.Text = "Número Positivo!"
        ElseIf n < 0 Then
            lbl_n1.Text = "Número Negativo"
        Else
            lbl_n1.Text = "Número Nulo!"
        End If

    End Sub

    Private Sub Cmd2form2_Click(sender As Object, e As EventArgs) Handles cmd2form2.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
