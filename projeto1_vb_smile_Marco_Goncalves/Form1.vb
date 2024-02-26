Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles But_sair.Click
        End
    End Sub

    Private Sub But_Alegre_Click(sender As Object, e As EventArgs) Handles But_Alegre.Click
        Img_Alegre.Visible = True
        Lab_alegre.Visible = True
        Box_Alegre.Visible = True
        Img_Iriste.Visible = False
        Box_Triste.Visible = False
        But_Alegre.Visible = False
        But_Triste.Visible = True
        Box_Alegre.Checked = True
        Box_Triste.Checked = False



    End Sub

    Private Sub But_Triste_Click(sender As Object, e As EventArgs) Handles But_Triste.Click
        Img_Iriste.Visible = True
        Lab_triste.Visible = True
        Box_Triste.Visible = True
        Img_Alegre.Visible = False
        Box_Alegre.Visible = False
        But_Triste.Visible = False
        But_Alegre.Visible = True
        Box_Alegre.Checked = False
        Box_Triste.Checked = True
    End Sub

    Private Sub But_inicio_Click(sender As Object, e As EventArgs) Handles But_inicio.Click
        But_Alegre.Visible = True
        But_Triste.Visible = True

    End Sub


End Class
