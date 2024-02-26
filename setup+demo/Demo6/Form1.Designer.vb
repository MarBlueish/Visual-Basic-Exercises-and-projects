<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Lab1 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtnome = New TextBox()
        txtmorada = New TextBox()
        txtcod = New TextBox()
        txtloc = New TextBox()
        txtnmr = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        MenuStrip1 = New MenuStrip()
        FicheiroToolStripMenuItem = New ToolStripMenuItem()
        abreF = New ToolStripMenuItem()
        guardaF = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarTudoToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        AdicionarToolStripMenuItem = New ToolStripMenuItem()
        LimparToolStripMenuItem = New ToolStripMenuItem()
        FormatarToolStripMenuItem = New ToolStripMenuItem()
        SobreToolStripMenuItem = New ToolStripMenuItem()
        SobreNósToolStripMenuItem = New ToolStripMenuItem()
        FontDialog1 = New FontDialog()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txt_resumo = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lab1
        ' 
        Lab1.AutoSize = True
        Lab1.Location = New Point(99, 28)
        Lab1.Name = "Lab1"
        Lab1.Size = New Size(155, 15)
        Lab1.TabIndex = 0
        Lab1.Text = "Registo de Dados do Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 2
        Label2.Text = "Morada"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 3
        Label3.Text = "Código-Postal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 4
        Label4.Text = "Localidade"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 5
        Label5.Text = "Nº Telemovel"
        ' 
        ' txtnome
        ' 
        txtnome.Location = New Point(116, 84)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(240, 23)
        txtnome.TabIndex = 6
        ' 
        ' txtmorada
        ' 
        txtmorada.Location = New Point(116, 121)
        txtmorada.Name = "txtmorada"
        txtmorada.Size = New Size(240, 23)
        txtmorada.TabIndex = 7
        ' 
        ' txtcod
        ' 
        txtcod.Location = New Point(116, 150)
        txtcod.Name = "txtcod"
        txtcod.Size = New Size(100, 23)
        txtcod.TabIndex = 8
        ' 
        ' txtloc
        ' 
        txtloc.Location = New Point(116, 179)
        txtloc.Name = "txtloc"
        txtloc.Size = New Size(100, 23)
        txtloc.TabIndex = 9
        ' 
        ' txtnmr
        ' 
        txtnmr.Location = New Point(116, 208)
        txtnmr.Name = "txtnmr"
        txtnmr.Size = New Size(100, 23)
        txtnmr.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(13, 257)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 36)
        Button1.TabIndex = 11
        Button1.Text = "Adicionar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(150, 257)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 36)
        Button2.TabIndex = 12
        Button2.Text = "Limpar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(274, 257)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 36)
        Button3.TabIndex = 13
        Button3.Text = "Formatar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(21, 483)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 14
        Button4.Text = "Guardar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(281, 483)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 15
        Button5.Text = "Sair"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FicheiroToolStripMenuItem, EditarToolStripMenuItem, VerToolStripMenuItem, SobreToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(368, 24)
        MenuStrip1.TabIndex = 16
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FicheiroToolStripMenuItem
        ' 
        FicheiroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {abreF, guardaF, ImprimirToolStripMenuItem, SairToolStripMenuItem})
        FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        FicheiroToolStripMenuItem.Size = New Size(61, 20)
        FicheiroToolStripMenuItem.Text = "Ficheiro"
        ' 
        ' abreF
        ' 
        abreF.Name = "abreF"
        abreF.Size = New Size(120, 22)
        abreF.Text = "Abrir"
        ' 
        ' guardaF
        ' 
        guardaF.Name = "guardaF"
        guardaF.Size = New Size(120, 22)
        guardaF.Text = "Guardar"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(120, 22)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(120, 22)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelecionarTudoToolStripMenuItem, CopiarToolStripMenuItem, ToolStripMenuItem2, ToolStripMenuItem3})
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' SelecionarTudoToolStripMenuItem
        ' 
        SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        SelecionarTudoToolStripMenuItem.Size = New Size(158, 22)
        SelecionarTudoToolStripMenuItem.Text = "Selecionar Tudo"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(158, 22)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(158, 22)
        ToolStripMenuItem2.Text = "Colar"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(158, 22)
        ToolStripMenuItem3.Text = "Cortar"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdicionarToolStripMenuItem, LimparToolStripMenuItem, FormatarToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(35, 20)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' AdicionarToolStripMenuItem
        ' 
        AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        AdicionarToolStripMenuItem.Size = New Size(125, 22)
        AdicionarToolStripMenuItem.Text = "Adicionar"
        ' 
        ' LimparToolStripMenuItem
        ' 
        LimparToolStripMenuItem.Name = "LimparToolStripMenuItem"
        LimparToolStripMenuItem.Size = New Size(125, 22)
        LimparToolStripMenuItem.Text = "Limpar"
        ' 
        ' FormatarToolStripMenuItem
        ' 
        FormatarToolStripMenuItem.Name = "FormatarToolStripMenuItem"
        FormatarToolStripMenuItem.Size = New Size(125, 22)
        FormatarToolStripMenuItem.Text = "Formatar"
        ' 
        ' SobreToolStripMenuItem
        ' 
        SobreToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SobreNósToolStripMenuItem})
        SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        SobreToolStripMenuItem.Size = New Size(49, 20)
        SobreToolStripMenuItem.Text = "Sobre"
        ' 
        ' SobreNósToolStripMenuItem
        ' 
        SobreNósToolStripMenuItem.Name = "SobreNósToolStripMenuItem"
        SobreNósToolStripMenuItem.Size = New Size(126, 22)
        SobreNósToolStripMenuItem.Text = "Sobre nós"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txt_resumo
        ' 
        txt_resumo.BackColor = SystemColors.Info
        txt_resumo.ForeColor = SystemColors.InfoText
        txt_resumo.FormattingEnabled = True
        txt_resumo.ItemHeight = 15
        txt_resumo.Location = New Point(12, 321)
        txt_resumo.Name = "txt_resumo"
        txt_resumo.Size = New Size(344, 139)
        txt_resumo.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 518)
        Controls.Add(txt_resumo)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtnmr)
        Controls.Add(txtloc)
        Controls.Add(txtcod)
        Controls.Add(txtmorada)
        Controls.Add(txtnome)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Lab1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Adicionar Cliente"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lab1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtmorada As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtloc As TextBox
    Friend WithEvents txtnmr As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents abreF As ToolStripMenuItem
    Friend WithEvents guardaF As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents eselect As ToolStripMenuItem
    Friend WithEvents ecopy As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreNósToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_resumo As ListBox
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
