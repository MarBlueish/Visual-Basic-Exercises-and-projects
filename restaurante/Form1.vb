Public Class Form1
    Private Sub Checksim_CheckedChanged(sender As Object, e As EventArgs) Handles checksim.CheckedChanged
        If checksim.Checked Then
            but_pdia.Visible = True
            labfome.Visible = False
            checksim.Visible = False
            Checknao.Visible = False
            butvoltar.Visible = True
            butcart.Visible = True

        Else
            but_pdia.Visible = False
            butseg.Visible = False
            butter.Visible = False
            butquar.Visible = False
            butqui.Visible = False
            butsex.Visible = False
            butsab.Visible = False
            butdom.Visible = False
            butcart.Visible = False

        End If
    End Sub

    Private Sub Checknao_CheckedChanged(sender As Object, e As EventArgs) Handles Checknao.CheckedChanged
        End
    End Sub

    Private Sub But_pdia_Click(sender As Object, e As EventArgs) Handles but_pdia.Click
        butseg.Visible = True
        butter.Visible = True
        butquar.Visible = True
        butqui.Visible = True
        butsex.Visible = True
        butsab.Visible = True
        butdom.Visible = True
        but_pdia.Visible = False
        butcart.Visible = False
        ComboBox1.Visible = True
        ComboBox3.Visible = True
        lab_bebidas.Visible = True
        lab_sob.Visible = True
    End Sub

    Private Sub Butseg_Click(sender As Object, e As EventArgs) Handles butseg.Click
        butter.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        MessageBox.Show("Estamos Fechados Hoje!", "Estamos Encerrados")
    End Sub

    Private Sub Butter_Click(sender As Object, e As EventArgs) Handles butter.Click
        butseg.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Frango assado à Padeiro", "Prato do dia")
    End Sub

    Private Sub Butquar_Click(sender As Object, e As EventArgs) Handles butquar.Click
        butseg.Visible = False
        butter.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Filetes de Pescada com Salada Russa", "Prato do dia")
    End Sub

    Private Sub Butqui_Click(sender As Object, e As EventArgs) Handles butqui.Click
        butseg.Visible = False
        butter.Visible = False
        butquar.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Prego em Prato", "Prato do dia")
    End Sub

    Private Sub Butsex_Click(sender As Object, e As EventArgs) Handles butsex.Click
        butseg.Visible = False
        butter.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Coelho à Caçador", "Prato do dia")
    End Sub

    Private Sub Butsab_Click(sender As Object, e As EventArgs) Handles butsab.Click
        butseg.Visible = False
        butter.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Espetadas de Frango com Arroz de Feijão", "Prato do dia")
    End Sub

    Private Sub Butdom_Click(sender As Object, e As EventArgs) Handles butdom.Click
        butseg.Visible = False
        butter.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butcart.Visible = False
        butped.Visible = True
        MessageBox.Show("Bacalhau na Brasa", "Prato do dia")
    End Sub

    Private Sub Butvoltar_Click(sender As Object, e As EventArgs) Handles butvoltar.Click
        butseg.Visible = True
        butter.Visible = True
        butquar.Visible = True
        butqui.Visible = True
        butsex.Visible = True
        butsab.Visible = True
        butdom.Visible = True
        butcart.Visible = True
        butped.Visible = False
        lab_men.Visible = False
        ComboBox2.Visible = False
    End Sub

    Private Sub butsair_Click(sender As Object, e As EventArgs) Handles butsair.Click
        Checknao.Checked = True

    End Sub

    Private Sub butcart_Click(sender As Object, e As EventArgs) Handles butcart.Click
        lab_men.Visible = True
        ComboBox2.Visible = True
        lab_bebidas.Visible = True
        ComboBox1.Visible = True
        lab_sob.Visible = True
        ComboBox3.Visible = True
        butped.Visible = True
    End Sub

    Private Sub butped_Click(sender As Object, e As EventArgs) Handles butped.Click
        MessageBox.Show("Por favor, insira a sua forma de pagamento", "Pagamento")
        but_pdia.Visible = False
        butvoltar.Visible = False
        butseg.Visible = False
        butter.Visible = False
        butquar.Visible = False
        butqui.Visible = False
        butsex.Visible = False
        butsab.Visible = False
        butdom.Visible = False
        butcart.Visible = False
        lab_men.Visible = False
        ComboBox2.Visible = False
        lab_bebidas.Visible = False
        ComboBox1.Visible = False
        lab_sob.Visible = False
        ComboBox3.Visible = False
        butsair.Visible = False
        butped.Visible = False
        labpag.Visible = True
        ComboBox4.Visible = True
        butpag.Visible = True
    End Sub

    Private Sub butpag_Click(sender As Object, e As EventArgs) Handles butpag.Click
        MessageBox.Show("Pagamento Efetuado, obrigado e volte sempre!", "Pagamento Completo")
        Checknao.Checked = True
    End Sub


End Class
