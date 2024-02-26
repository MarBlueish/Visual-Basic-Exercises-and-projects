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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        but_pdia = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        checksim = New CheckBox()
        labfome = New Label()
        Checknao = New CheckBox()
        butseg = New Button()
        butter = New Button()
        butquar = New Button()
        butqui = New Button()
        butsex = New Button()
        butsab = New Button()
        butdom = New Button()
        butvoltar = New Button()
        butsair = New Button()
        lab_sob = New Label()
        lab_bebidas = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        lab_men = New Label()
        ComboBox3 = New ComboBox()
        butcart = New Button()
        butped = New Button()
        labpag = New Label()
        ComboBox4 = New ComboBox()
        butpag = New Button()
        SuspendLayout()
        ' 
        ' but_pdia
        ' 
        but_pdia.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        but_pdia.Location = New Point(379, 12)
        but_pdia.Name = "but_pdia"
        but_pdia.Size = New Size(143, 35)
        but_pdia.TabIndex = 4
        but_pdia.Text = "Prato do Dia"
        but_pdia.UseVisualStyleBackColor = True
        but_pdia.Visible = False
        ' 
        ' checksim
        ' 
        checksim.AutoSize = True
        checksim.BackColor = Color.Transparent
        checksim.Font = New Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point)
        checksim.ForeColor = Color.Gold
        checksim.Location = New Point(413, 153)
        checksim.Name = "checksim"
        checksim.Size = New Size(108, 49)
        checksim.TabIndex = 8
        checksim.Text = "Sim"
        checksim.UseVisualStyleBackColor = False
        ' 
        ' labfome
        ' 
        labfome.AutoSize = True
        labfome.BackColor = SystemColors.Menu
        labfome.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point)
        labfome.ForeColor = Color.Gold
        labfome.Image = CType(resources.GetObject("labfome.Image"), Image)
        labfome.Location = New Point(255, 173)
        labfome.Name = "labfome"
        labfome.Size = New Size(152, 29)
        labfome.TabIndex = 9
        labfome.Text = "Com Fome?"
        ' 
        ' Checknao
        ' 
        Checknao.AutoSize = True
        Checknao.BackColor = Color.Transparent
        Checknao.Font = New Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Checknao.ForeColor = Color.Gold
        Checknao.Location = New Point(409, 208)
        Checknao.Name = "Checknao"
        Checknao.Size = New Size(112, 49)
        Checknao.TabIndex = 10
        Checknao.Text = "Não"
        Checknao.UseVisualStyleBackColor = False
        ' 
        ' butseg
        ' 
        butseg.Location = New Point(12, 12)
        butseg.Name = "butseg"
        butseg.Size = New Size(164, 23)
        butseg.TabIndex = 11
        butseg.Text = "Segunda-Feira"
        butseg.UseVisualStyleBackColor = True
        butseg.Visible = False
        ' 
        ' butter
        ' 
        butter.Location = New Point(12, 41)
        butter.Name = "butter"
        butter.Size = New Size(164, 23)
        butter.TabIndex = 12
        butter.Text = "Terça Feira"
        butter.UseVisualStyleBackColor = True
        butter.Visible = False
        ' 
        ' butquar
        ' 
        butquar.Location = New Point(12, 70)
        butquar.Name = "butquar"
        butquar.Size = New Size(164, 23)
        butquar.TabIndex = 13
        butquar.Text = "Quarta-Feira"
        butquar.UseVisualStyleBackColor = True
        butquar.Visible = False
        ' 
        ' butqui
        ' 
        butqui.Location = New Point(12, 99)
        butqui.Name = "butqui"
        butqui.Size = New Size(164, 23)
        butqui.TabIndex = 14
        butqui.Text = "Quinta-Feira"
        butqui.UseVisualStyleBackColor = True
        butqui.Visible = False
        ' 
        ' butsex
        ' 
        butsex.Location = New Point(12, 128)
        butsex.Name = "butsex"
        butsex.Size = New Size(164, 23)
        butsex.TabIndex = 15
        butsex.Text = "Sexta-Feira"
        butsex.UseVisualStyleBackColor = True
        butsex.Visible = False
        ' 
        ' butsab
        ' 
        butsab.Location = New Point(12, 157)
        butsab.Name = "butsab"
        butsab.Size = New Size(164, 23)
        butsab.TabIndex = 16
        butsab.Text = "Sábado"
        butsab.UseVisualStyleBackColor = True
        butsab.Visible = False
        ' 
        ' butdom
        ' 
        butdom.Location = New Point(12, 186)
        butdom.Name = "butdom"
        butdom.Size = New Size(164, 23)
        butdom.TabIndex = 17
        butdom.Text = "Domingo"
        butdom.UseVisualStyleBackColor = True
        butdom.Visible = False
        ' 
        ' butvoltar
        ' 
        butvoltar.Location = New Point(12, 306)
        butvoltar.Name = "butvoltar"
        butvoltar.Size = New Size(124, 34)
        butvoltar.TabIndex = 18
        butvoltar.Text = "Voltar"
        butvoltar.UseVisualStyleBackColor = True
        butvoltar.Visible = False
        ' 
        ' butsair
        ' 
        butsair.Location = New Point(409, 306)
        butsair.Name = "butsair"
        butsair.Size = New Size(113, 34)
        butsair.TabIndex = 19
        butsair.Text = "Sair"
        butsair.UseVisualStyleBackColor = True
        ' 
        ' lab_sob
        ' 
        lab_sob.AutoSize = True
        lab_sob.Location = New Point(204, 164)
        lab_sob.Name = "lab_sob"
        lab_sob.Size = New Size(73, 16)
        lab_sob.TabIndex = 20
        lab_sob.Text = "Sobremesa"
        lab_sob.Visible = False
        ' 
        ' lab_bebidas
        ' 
        lab_bebidas.AutoSize = True
        lab_bebidas.Location = New Point(200, 102)
        lab_bebidas.Name = "lab_bebidas"
        lab_bebidas.Size = New Size(123, 16)
        lab_bebidas.TabIndex = 21
        lab_bebidas.Text = "Bebidas Disponiveis"
        lab_bebidas.Visible = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Tan
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Vinho tinto", "Vinho Branco", "Coca-Cola", "Pepsi", "Sumol Laranja", "Sumol Ananás", "Coca-Cola Zero", "Ice Tea Manga", "Ice Tea Limão"})
        ComboBox1.Location = New Point(202, 128)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(188, 24)
        ComboBox1.TabIndex = 22
        ComboBox1.Visible = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Tan
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Francesinha", "Salmão Grelhado", "Bacalhau à Lagareiro", "Hamburguer Com Bacon e Batatas Fritas", "Pescada Cozida com batatas", "Prego em Pão", "Prego em Prato", "Pica-Pau"})
        ComboBox2.Location = New Point(202, 69)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(188, 24)
        ComboBox2.TabIndex = 23
        ComboBox2.Visible = False
        ' 
        ' lab_men
        ' 
        lab_men.AutoSize = True
        lab_men.Location = New Point(202, 44)
        lab_men.Name = "lab_men"
        lab_men.Size = New Size(85, 16)
        lab_men.TabIndex = 24
        lab_men.Text = "Menu A Carta"
        lab_men.Visible = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.Tan
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Pudim Flan", "Pudim de Leite Condensado", "Bolo de Bolacha", "Tiramisu", "Gelado de Caramelo", "Gelado de Chocolate", "Fruta da Época"})
        ComboBox3.Location = New Point(200, 185)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(190, 24)
        ComboBox3.TabIndex = 25
        ComboBox3.Visible = False
        ' 
        ' butcart
        ' 
        butcart.Location = New Point(12, 237)
        butcart.Name = "butcart"
        butcart.Size = New Size(168, 25)
        butcart.TabIndex = 26
        butcart.Text = "Pedir Carta"
        butcart.UseVisualStyleBackColor = True
        butcart.Visible = False
        ' 
        ' butped
        ' 
        butped.Location = New Point(186, 237)
        butped.Name = "butped"
        butped.Size = New Size(166, 25)
        butped.TabIndex = 27
        butped.Text = "Efetuar Pedido"
        butped.UseVisualStyleBackColor = True
        butped.Visible = False
        ' 
        ' labpag
        ' 
        labpag.AutoSize = True
        labpag.BackColor = Color.Transparent
        labpag.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        labpag.ForeColor = Color.Red
        labpag.Location = New Point(-1, 26)
        labpag.Name = "labpag"
        labpag.Size = New Size(536, 56)
        labpag.TabIndex = 28
        labpag.Text = "Método de Pagamento"
        labpag.Visible = False
        ' 
        ' ComboBox4
        ' 
        ComboBox4.AutoCompleteCustomSource.AddRange(New String() {"Mastercard", "Multibanco", "Visa", "Dinheiro", "American Express"})
        ComboBox4.BackColor = Color.Bisque
        ComboBox4.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Dinheiro", "Mastercard", "Visa", "American Express"})
        ComboBox4.Location = New Point(119, 167)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(288, 40)
        ComboBox4.TabIndex = 29
        ComboBox4.Visible = False
        ' 
        ' butpag
        ' 
        butpag.BackColor = Color.Bisque
        butpag.Location = New Point(80, 254)
        butpag.Name = "butpag"
        butpag.Size = New Size(347, 46)
        butpag.TabIndex = 30
        butpag.Text = "Efetuar Pagamento"
        butpag.UseVisualStyleBackColor = False
        butpag.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.restimg
        ClientSize = New Size(533, 352)
        Controls.Add(butpag)
        Controls.Add(ComboBox4)
        Controls.Add(labpag)
        Controls.Add(butped)
        Controls.Add(butcart)
        Controls.Add(ComboBox3)
        Controls.Add(lab_men)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(lab_bebidas)
        Controls.Add(lab_sob)
        Controls.Add(butsair)
        Controls.Add(butvoltar)
        Controls.Add(butdom)
        Controls.Add(butsab)
        Controls.Add(butsex)
        Controls.Add(butqui)
        Controls.Add(butquar)
        Controls.Add(butter)
        Controls.Add(butseg)
        Controls.Add(Checknao)
        Controls.Add(labfome)
        Controls.Add(checksim)
        Controls.Add(but_pdia)
        Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Restaurante Belo Petisco"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents but_pdia As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents checksim As CheckBox
    Friend WithEvents labfome As Label
    Friend WithEvents Checknao As CheckBox
    Friend WithEvents butseg As Button
    Friend WithEvents butter As Button
    Friend WithEvents butquar As Button
    Friend WithEvents butqui As Button
    Friend WithEvents butsex As Button
    Friend WithEvents butsab As Button
    Friend WithEvents butdom As Button
    Friend WithEvents butvoltar As Button
    Friend WithEvents butsair As Button
    Friend WithEvents lab_sob As Label
    Friend WithEvents lab_bebidas As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lab_men As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents butcart As Button
    Friend WithEvents butped As Button
    Friend WithEvents labpag As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents butpag As Button
End Class
