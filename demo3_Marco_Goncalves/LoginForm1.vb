Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String = "iefp"
        Dim password As String = "programador"

        Dim inputUsername As String = TxtUsername.Text
        Dim inputPassword As String = TxtPassword.Text

        If inputUsername = username AndAlso inputPassword = password Then
            MessageBox.Show("Login Bem-sucedido!")
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Usuário ou senha incorretos", "vb.net", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.Clear()
            TxtPassword.Clear()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
