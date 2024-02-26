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
        cmd_start = New Button()
        cmd_exit = New Button()
        cmd_show = New Button()
        cmd_hide = New Button()
        cmd_imagem = New PictureBox()
        cmd_label = New Label()
        cmd_checkbox = New CheckBox()
        CType(cmd_imagem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_start
        ' 
        cmd_start.Location = New Point(138, 12)
        cmd_start.Name = "cmd_start"
        cmd_start.Size = New Size(223, 56)
        cmd_start.TabIndex = 0
        cmd_start.Text = "Start"
        cmd_start.UseVisualStyleBackColor = True
        ' 
        ' cmd_exit
        ' 
        cmd_exit.Location = New Point(138, 256)
        cmd_exit.Name = "cmd_exit"
        cmd_exit.Size = New Size(223, 65)
        cmd_exit.TabIndex = 1
        cmd_exit.Text = "Exit"
        cmd_exit.UseVisualStyleBackColor = True
        ' 
        ' cmd_show
        ' 
        cmd_show.Location = New Point(4, 88)
        cmd_show.Name = "cmd_show"
        cmd_show.Size = New Size(137, 48)
        cmd_show.TabIndex = 2
        cmd_show.Text = "Show"
        cmd_show.UseVisualStyleBackColor = True
        ' 
        ' cmd_hide
        ' 
        cmd_hide.Location = New Point(0, 164)
        cmd_hide.Name = "cmd_hide"
        cmd_hide.Size = New Size(143, 45)
        cmd_hide.TabIndex = 3
        cmd_hide.Text = "Hide"
        cmd_hide.UseVisualStyleBackColor = True
        ' 
        ' cmd_imagem
        ' 
        cmd_imagem.Image = My.Resources.Resources._123
        cmd_imagem.Location = New Point(149, 88)
        cmd_imagem.Name = "cmd_imagem"
        cmd_imagem.Size = New Size(225, 121)
        cmd_imagem.SizeMode = PictureBoxSizeMode.StretchImage
        cmd_imagem.TabIndex = 4
        cmd_imagem.TabStop = False
        cmd_imagem.Visible = False
        ' 
        ' cmd_label
        ' 
        cmd_label.AutoSize = True
        cmd_label.Location = New Point(15, 37)
        cmd_label.Name = "cmd_label"
        cmd_label.Size = New Size(88, 15)
        cmd_label.TabIndex = 5
        cmd_label.Text = "VBA NET LOGO"
        cmd_label.Visible = False
        ' 
        ' cmd_checkbox
        ' 
        cmd_checkbox.AutoSize = True
        cmd_checkbox.Location = New Point(169, 231)
        cmd_checkbox.Name = "cmd_checkbox"
        cmd_checkbox.Size = New Size(148, 19)
        cmd_checkbox.TabIndex = 6
        cmd_checkbox.Text = "Premir para ronaldinho"
        cmd_checkbox.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 450)
        Controls.Add(cmd_checkbox)
        Controls.Add(cmd_label)
        Controls.Add(cmd_imagem)
        Controls.Add(cmd_hide)
        Controls.Add(cmd_show)
        Controls.Add(cmd_exit)
        Controls.Add(cmd_start)
        Name = "Form1"
        Text = "Form1"
        CType(cmd_imagem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_start As Button
    Friend WithEvents cmd_exit As Button
    Friend WithEvents cmd_show As Button
    Friend WithEvents cmd_hide As Button
    Friend WithEvents cmd_imagem As PictureBox
    Friend WithEvents cmd_label As Label
    Friend WithEvents cmd_checkbox As CheckBox
End Class
