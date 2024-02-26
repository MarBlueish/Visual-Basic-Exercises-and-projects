Imports System.Reflection.Emit

Public Class MenuForm
    ' Method to display the menu items in the label control
    Public Sub DisplayMenu()
        Label1.Text = "Welcome to My Restaurant!" & vbCrLf &
                      "Here is our menu:" & vbCrLf &
                      "1. Burger" & vbCrLf &
                      "2. Pizza" & vbCrLf &
                      "3. Pasta" & vbCrLf &
                      "4. Salad"
        ' Add more items to the menu as needed
    End Sub
End Class






