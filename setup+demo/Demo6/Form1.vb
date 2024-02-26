Imports System.Configuration

Public Class Form1


    Sub Abrir()
        Dim abreF As New OpenFileDialog
        abreF.Filter = "txt files (*.txt)|*.txt"
        abreF.FilterIndex = 2
        abreF.RestoreDirectory = False

        If abreF.ShowDialog() = DialogResult.OK Then
            txt_resumo.Text = IO.File.ReadAllText(abreF.FileName)
        End If
    End Sub

    Sub Guardar()
        Dim guardaF As New SaveFileDialog
        guardaF.Filter = "txt files (*.txt)|*.txt"
        guardaF.FilterIndex = 2
        guardaF.RestoreDirectory = False

        If guardaF.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(guardaF.FileName, txt_resumo.Text)
        End If
    End Sub

    Sub Imprimir()
        Dim printDialog As New PrintDialog()


        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printDocument As New Printing.PrintDocument()


            AddHandler printDocument.PrintPage, AddressOf PrintPageHandler


            printDocument.PrinterSettings = printDialog.PrinterSettings


            printDocument.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As Printing.PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim textToPrint As String = txt_resumo.Text

        Dim printRect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim sf As New StringFormat()


        sf.Alignment = StringAlignment.Near


        e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, printRect, sf)
    End Sub

    Sub Sair()
        End
    End Sub


    Private Sub abreF_Click(sender As Object, e As EventArgs) Handles abreF.Click
        Abrir()
    End Sub

    Private Sub guardaF_Click(sender As Object, e As EventArgs) Handles guardaF.Click
        Guardar()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Imprimir()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Sair()
    End Sub


    Private Sub SelecionarTudo()
        For i As Integer = 0 To txt_resumo.Items.Count - 1
            txt_resumo.SetSelected(i, True)
        Next
    End Sub


    Private Sub Copiar()
        Dim selectedItems As New List(Of String)

        For Each selectedItem As Object In txt_resumo.SelectedItems
            selectedItems.Add(selectedItem.ToString())
        Next

        Clipboard.SetText(String.Join(Environment.NewLine, selectedItems))
    End Sub


    Private Sub Colar()
        Dim textToPaste As String = Clipboard.GetText()


        Dim lines As String() = textToPaste.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        For Each line As String In lines
            txt_resumo.Items.Add(line)
        Next
    End Sub


    Private Sub Cortar()
        Copiar()

        For i As Integer = txt_resumo.SelectedIndices.Count - 1 To 0 Step -1
            txt_resumo.Items.RemoveAt(txt_resumo.SelectedIndices(i))
        Next
    End Sub

    Private Sub SelecionarTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarTudoToolStripMenuItem.Click
        SelecionarTudo()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Copiar()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Colar()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Cortar()
    End Sub

    Private Sub AdicionarItem()
        Dim newItem As String = InputBox("Digite o item a ser adicionado:", "Adicionar Item")

        If Not String.IsNullOrWhiteSpace(newItem) Then
            txt_resumo.Items.Add(newItem)
        End If
    End Sub

    Private Sub LimparItens()
        txt_resumo.Items.Clear()
    End Sub

    Private Sub FormatarItens()
        For Each selectedIndex As Integer In txt_resumo.SelectedIndices
            txt_resumo.SetSelected(selectedIndex, False)
            txt_resumo.Items(selectedIndex) = "<font color='red'>" & txt_resumo.Items(selectedIndex).ToString() & "</font>"
        Next
    End Sub


    Private Sub adicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        AdicionarItem()
    End Sub

    Private Sub limparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparToolStripMenuItem.Click
        LimparItens()
    End Sub

    Private Sub formatarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatarToolStripMenuItem.Click
        FormatarItens()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String = txtnome.Text & " - " & txtmorada.Text & " - " & txtcod.Text & " - " & txtloc.Text & " - " & txtnmr.Text
        txt_resumo.Items.Add(texto)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtnome.Clear()
        txtmorada.Clear()
        txtcod.Clear()
        txtloc.Clear()
        txtnmr.Clear()
        txt_resumo.Items.Clear()
        txtnome.Focus()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormatarItens()
    End Sub

    Private Sub SobreNósToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreNósToolStripMenuItem.Click
        Me.Hide()
        AboutBox1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class
