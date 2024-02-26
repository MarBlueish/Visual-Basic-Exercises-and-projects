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
        But_sair = New Button()
        But_inicio = New Button()
        Img_Alegre = New PictureBox()
        Img_Iriste = New PictureBox()
        Lab_alegre = New Label()
        Lab_triste = New Label()
        Box_Alegre = New CheckBox()
        Box_Triste = New CheckBox()
        But_Alegre = New Button()
        But_Triste = New Button()
        lab_final = New Label()
        CType(Img_Alegre, ComponentModel.ISupportInitialize).BeginInit()
        CType(Img_Iriste, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' But_sair
        ' 
        But_sair.Location = New Point(645, 400)
        But_sair.Name = "But_sair"
        But_sair.Size = New Size(143, 38)
        But_sair.TabIndex = 0
        But_sair.Text = "Sair"
        But_sair.UseVisualStyleBackColor = True
        ' 
        ' But_inicio
        ' 
        But_inicio.Location = New Point(5, 7)
        But_inicio.Name = "But_inicio"
        But_inicio.Size = New Size(173, 40)
        But_inicio.TabIndex = 1
        But_inicio.Text = "Início"
        But_inicio.UseVisualStyleBackColor = True
        ' 
        ' Img_Alegre
        ' 
        Img_Alegre.Image = CType(resources.GetObject("Img_Alegre.Image"), Image)
        Img_Alegre.Location = New Point(25, 91)
        Img_Alegre.Name = "Img_Alegre"
        Img_Alegre.Size = New Size(214, 173)
        Img_Alegre.SizeMode = PictureBoxSizeMode.StretchImage
        Img_Alegre.TabIndex = 2
        Img_Alegre.TabStop = False
        Img_Alegre.Visible = False
        ' 
        ' Img_Iriste
        ' 
        Img_Iriste.Image = CType(resources.GetObject("Img_Iriste.Image"), Image)
        Img_Iriste.Location = New Point(471, 91)
        Img_Iriste.Name = "Img_Iriste"
        Img_Iriste.Size = New Size(227, 173)
        Img_Iriste.SizeMode = PictureBoxSizeMode.StretchImage
        Img_Iriste.TabIndex = 3
        Img_Iriste.TabStop = False
        Img_Iriste.Visible = False
        ' 
        ' Lab_alegre
        ' 
        Lab_alegre.AutoSize = True
        Lab_alegre.Location = New Point(25, 69)
        Lab_alegre.Name = "Lab_alegre"
        Lab_alegre.Size = New Size(41, 15)
        Lab_alegre.TabIndex = 4
        Lab_alegre.Text = "Alegre"
        Lab_alegre.Visible = False
        ' 
        ' Lab_triste
        ' 
        Lab_triste.AutoSize = True
        Lab_triste.Location = New Point(471, 69)
        Lab_triste.Name = "Lab_triste"
        Lab_triste.Size = New Size(34, 15)
        Lab_triste.TabIndex = 5
        Lab_triste.Text = "Triste"
        Lab_triste.Visible = False
        ' 
        ' Box_Alegre
        ' 
        Box_Alegre.AutoSize = True
        Box_Alegre.Location = New Point(25, 281)
        Box_Alegre.Name = "Box_Alegre"
        Box_Alegre.Size = New Size(60, 19)
        Box_Alegre.TabIndex = 6
        Box_Alegre.Text = "Alegre"
        Box_Alegre.UseVisualStyleBackColor = True
        Box_Alegre.Visible = False
        ' 
        ' Box_Triste
        ' 
        Box_Triste.AutoSize = True
        Box_Triste.Location = New Point(471, 281)
        Box_Triste.Name = "Box_Triste"
        Box_Triste.Size = New Size(53, 19)
        Box_Triste.TabIndex = 7
        Box_Triste.Text = "Triste"
        Box_Triste.UseVisualStyleBackColor = True
        Box_Triste.Visible = False
        ' 
        ' But_Alegre
        ' 
        But_Alegre.Location = New Point(25, 320)
        But_Alegre.Name = "But_Alegre"
        But_Alegre.Size = New Size(214, 41)
        But_Alegre.TabIndex = 8
        But_Alegre.Text = "Alegre"
        But_Alegre.UseVisualStyleBackColor = True
        But_Alegre.Visible = False
        ' 
        ' But_Triste
        ' 
        But_Triste.Location = New Point(471, 320)
        But_Triste.Name = "But_Triste"
        But_Triste.Size = New Size(227, 48)
        But_Triste.TabIndex = 9
        But_Triste.Text = "Triste"
        But_Triste.UseVisualStyleBackColor = True
        But_Triste.Visible = False
        ' 
        ' lab_final
        ' 
        lab_final.AutoSize = True
        lab_final.Location = New Point(22, 429)
        lab_final.Name = "lab_final"
        lab_final.Size = New Size(151, 15)
        lab_final.TabIndex = 10
        lab_final.Text = "Feito por: Marco Gonçalves"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lab_final)
        Controls.Add(But_Triste)
        Controls.Add(But_Alegre)
        Controls.Add(Box_Triste)
        Controls.Add(Box_Alegre)
        Controls.Add(Lab_triste)
        Controls.Add(Lab_alegre)
        Controls.Add(Img_Iriste)
        Controls.Add(Img_Alegre)
        Controls.Add(But_inicio)
        Controls.Add(But_sair)
        Name = "Form1"
        Text = "Form1"
        CType(Img_Alegre, ComponentModel.ISupportInitialize).EndInit()
        CType(Img_Iriste, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents But_sair As Button
    Friend WithEvents But_inicio As Button
    Friend WithEvents Img_Alegre As PictureBox
    Friend WithEvents Img_Iriste As PictureBox
    Friend WithEvents Lab_alegre As Label
    Friend WithEvents Lab_triste As Label
    Friend WithEvents Box_Alegre As CheckBox
    Friend WithEvents Box_Triste As CheckBox
    Friend WithEvents But_Alegre As Button
    Friend WithEvents But_Triste As Button
    Friend WithEvents lab_final As Label
End Class
