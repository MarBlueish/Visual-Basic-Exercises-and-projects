<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Txt_Numero = New TextBox()
        ButtonVerifica1 = New Button()
        cmd_Verifica2 = New Button()
        form1butt = New Button()
        form2butt = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 36)
        Label1.TabIndex = 0
        Label1.Text = "Validação de Campo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(143, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Número"
        ' 
        ' Txt_Numero
        ' 
        Txt_Numero.Location = New Point(118, 101)
        Txt_Numero.Name = "Txt_Numero"
        Txt_Numero.Size = New Size(100, 23)
        Txt_Numero.TabIndex = 2
        ' 
        ' ButtonVerifica1
        ' 
        ButtonVerifica1.Location = New Point(63, 159)
        ButtonVerifica1.Name = "ButtonVerifica1"
        ButtonVerifica1.Size = New Size(75, 36)
        ButtonVerifica1.TabIndex = 3
        ButtonVerifica1.Text = "Verifica 1"
        ButtonVerifica1.UseVisualStyleBackColor = True
        ' 
        ' cmd_Verifica2
        ' 
        cmd_Verifica2.Location = New Point(183, 159)
        cmd_Verifica2.Name = "cmd_Verifica2"
        cmd_Verifica2.Size = New Size(75, 36)
        cmd_Verifica2.TabIndex = 4
        cmd_Verifica2.Text = "Verifica 2"
        cmd_Verifica2.UseVisualStyleBackColor = True
        ' 
        ' form1butt
        ' 
        form1butt.Location = New Point(27, 221)
        form1butt.Name = "form1butt"
        form1butt.Size = New Size(111, 23)
        form1butt.TabIndex = 5
        form1butt.Text = "To Form 1"
        form1butt.UseVisualStyleBackColor = True
        ' 
        ' form2butt
        ' 
        form2butt.Location = New Point(198, 221)
        form2butt.Name = "form2butt"
        form2butt.Size = New Size(125, 23)
        form2butt.TabIndex = 6
        form2butt.Text = "To Form 2"
        form2butt.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(335, 259)
        Controls.Add(form2butt)
        Controls.Add(form1butt)
        Controls.Add(cmd_Verifica2)
        Controls.Add(ButtonVerifica1)
        Controls.Add(Txt_Numero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents ButtonVerifica1 As Button
    Friend WithEvents cmd_Verifica2 As Button
    Friend WithEvents form1butt As Button
    Friend WithEvents form2butt As Button
End Class
