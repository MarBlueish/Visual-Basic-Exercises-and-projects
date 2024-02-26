<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cmd_demo1
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
        cmd_inicio = New Button()
        cmd_sair = New Button()
        cmd_mostrar = New Button()
        cmd_image = New PictureBox()
        cmd_esconder = New Button()
        CType(cmd_image, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_inicio
        ' 
        cmd_inicio.Location = New Point(12, 27)
        cmd_inicio.Name = "cmd_inicio"
        cmd_inicio.Size = New Size(129, 45)
        cmd_inicio.TabIndex = 0
        cmd_inicio.Text = "Inicio"
        cmd_inicio.UseVisualStyleBackColor = True
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Enabled = False
        cmd_sair.Location = New Point(159, 222)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(129, 45)
        cmd_sair.TabIndex = 1
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' cmd_mostrar
        ' 
        cmd_mostrar.Enabled = False
        cmd_mostrar.Location = New Point(159, 27)
        cmd_mostrar.Name = "cmd_mostrar"
        cmd_mostrar.Size = New Size(129, 45)
        cmd_mostrar.TabIndex = 2
        cmd_mostrar.Text = "Mostrar"
        cmd_mostrar.UseVisualStyleBackColor = True
        ' 
        ' cmd_image
        ' 
        cmd_image.Image = My.Resources.Resources.B5t_2MQCcAAefz4
        cmd_image.Location = New Point(3, 78)
        cmd_image.Name = "cmd_image"
        cmd_image.Size = New Size(285, 138)
        cmd_image.SizeMode = PictureBoxSizeMode.StretchImage
        cmd_image.TabIndex = 3
        cmd_image.TabStop = False
        cmd_image.Visible = False
        ' 
        ' cmd_esconder
        ' 
        cmd_esconder.Enabled = False
        cmd_esconder.Location = New Point(12, 222)
        cmd_esconder.Name = "cmd_esconder"
        cmd_esconder.Size = New Size(129, 45)
        cmd_esconder.TabIndex = 4
        cmd_esconder.Text = "Esconder"
        cmd_esconder.UseVisualStyleBackColor = True
        ' 
        ' cmd_demo1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(290, 283)
        Controls.Add(cmd_esconder)
        Controls.Add(cmd_image)
        Controls.Add(cmd_mostrar)
        Controls.Add(cmd_sair)
        Controls.Add(cmd_inicio)
        Name = "cmd_demo1"
        Text = "Demo1"
        CType(cmd_image, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_inicio As Button
    Friend WithEvents cmd_sair As Button
    Friend WithEvents cmd_mostrar As Button
    Friend WithEvents cmd_image As PictureBox
    Friend WithEvents cmd_esconder As Button
End Class
