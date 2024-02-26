Public Class Form1


    Private Sub But_if_Click(sender As Object, e As EventArgs) Handles But_if.Click
        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            If numero = 1 Then
                MessageBox.Show("O número " & numero & " corresponde a domingo.")
            ElseIf numero = 2 Then
                MessageBox.Show("O número " & numero & " corresponde a segunda-feira.")
            ElseIf numero = 3 Then
                MessageBox.Show("O número " & numero & " corresponde a terça-feira.")
            ElseIf numero = 4 Then
                MessageBox.Show("O número " & numero & " corresponde a quarta-feira.")
            ElseIf numero = 5 Then
                MessageBox.Show("O número " & numero & " corresponde a quinta-feira.")
            ElseIf numero = 6 Then
                MessageBox.Show("O número " & numero & " corresponde a sexta-feira.")
            ElseIf numero = 7 Then
                MessageBox.Show("O número " & numero & " corresponde a sábado.")
            Else
                MessageBox.Show("Número inválido. Insira um valor entre 1 e 7.")
            End If
        Else
            MessageBox.Show("Número inválido. Insira um valor numérico.")
        End If
    End Sub

    Private Sub But_ifcase_Click(sender As Object, e As EventArgs) Handles But_ifcase.Click
        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            Select Case numero
                Case 1
                    MessageBox.Show("O número " & numero & " corresponde a domingo.")
                Case 2
                    MessageBox.Show("O número " & numero & " corresponde a segunda-feira.")
                Case 3
                    MessageBox.Show("O número " & numero & " corresponde a terça-feira.")
                Case 4
                    MessageBox.Show("O número " & numero & " corresponde a quarta-feira.")
                Case 5
                    MessageBox.Show("O número " & numero & " corresponde a quinta-feira.")
                Case 6
                    MessageBox.Show("O número " & numero & " corresponde a sexta-feira.")
                Case 7
                    MessageBox.Show("O número " & numero & " corresponde a sábado.")
                Case Else
                    MessageBox.Show("Número inválido. Insira um valor entre 1 e 7.")
            End Select
        Else
            MessageBox.Show("Número inválido. Insira um valor numérico.")
        End If

    End Sub
End Class

