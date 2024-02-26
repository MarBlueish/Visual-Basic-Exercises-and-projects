Public Class Form3

    Private Sub ButtonVerifica1_Click(sender As Object, e As EventArgs) Handles ButtonVerifica1.Click
        Dim N_Txt As String
        Dim N As String

        N_Txt = Me.Txt_Numero.Text
        If IsNumeric(N_Txt) Then
            MessageBox.Show("Digitou um número", "Valida Campo")
            N = Val(N_Txt)
        Else
            MessageBox.Show("Entrada inválida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txt_Numero.Clear()
            Txt_Numero.Focus()
        End If

    End Sub

    Private Sub cmd_Verifica2_Click(sender As Object, e As EventArgs) Handles cmd_Verifica2.Click
        Dim N_txt As String
        Dim N As Long

        N_txt = Txt_Numero.Text

        N = Val(N_txt)
        If N <> 0 Then
            MessageBox.Show("Digitou um número", "Valida Campo")
        Else
            MessageBox.Show("Digitou um texto ou caractere" & vbLf & "Digite um número PF", "ATENÇÃO")
            Txt_Numero.Clear()
            Txt_Numero.Focus()
        End If
    End Sub

    Private Sub form1butt_Click(sender As Object, e As EventArgs) Handles form1butt.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub form2butt_Click(sender As Object, e As EventArgs) Handles form2butt.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class