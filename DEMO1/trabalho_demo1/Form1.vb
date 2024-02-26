Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1


    Private Sub cmd_show_Click(sender As Object, e As EventArgs) Handles cmd_show.Click
        cmd_show.Enabled = False
        cmd_hide.Show()
        cmd_hide.Enabled = True
        cmd_imagem.Show()
        cmd_label.Show()
        cmd_checkbox.Checked = True
    End Sub

    Private Sub cmd_hide_Click(sender As Object, e As EventArgs) Handles cmd_hide.Click
        cmd_imagem.Hide()
        cmd_hide.Enabled = False
        cmd_show.Enabled = True
        cmd_label.Hide()
        cmd_checkbox.Checked = False
    End Sub

    Private Sub cmd_exit_Click_1(sender As Object, e As EventArgs) Handles cmd_exit.Click
        End

    End Sub

    Private Sub cmd_checkbox_CheckedChanged_1(sender As Object, e As EventArgs) Handles cmd_checkbox.CheckedChanged
        If cmd_checkbox.Checked Then
            cmd_imagem.Show()
            cmd_label.Show()
            cmd_show.Enabled = False
            cmd_hide.Enabled = True
        Else
            cmd_imagem.Hide()
            cmd_label.Hide()
            cmd_show.Enabled = True
            cmd_hide.Enabled = False
        End If
    End Sub

    Private Sub cmd_start_Click_1(sender As Object, e As EventArgs) Handles cmd_start.Click
        cmd_exit.Visible = True
        cmd_show.Visible = True
        cmd_start.Visible = False
    End Sub
End Class
