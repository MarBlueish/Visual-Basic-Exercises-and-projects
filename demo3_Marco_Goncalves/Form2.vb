Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pwd As String
        pwd = txt_password.Text

        If pwd <> "iefp" Then
            MessageBox.Show("a passe está errada", "vb.net",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End

        Else
            MessageBox.Show("a passe está correta", "vb.net",
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Cmd2form1_Click(sender As Object, e As EventArgs) Handles cmd2form1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd2form3.Click
        Me.Hide()
        Form3.Show
    End Sub
End Class