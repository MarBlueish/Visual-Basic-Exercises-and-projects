<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button2 = New Button()
        txt_password = New TextBox()
        cmd2form3 = New Button()
        cmd2form1 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(62, 56)
        Button2.Name = "Button2"
        Button2.Size = New Size(238, 59)
        Button2.TabIndex = 0
        Button2.Text = "Valida Password"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(75, 144)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(194, 23)
        txt_password.TabIndex = 1
        ' 
        ' cmd2form3
        ' 
        cmd2form3.Location = New Point(225, 289)
        cmd2form3.Name = "cmd2form3"
        cmd2form3.Size = New Size(128, 23)
        cmd2form3.TabIndex = 2
        cmd2form3.Text = "To Form 3"
        cmd2form3.UseVisualStyleBackColor = True
        ' 
        ' cmd2form1
        ' 
        cmd2form1.Location = New Point(12, 289)
        cmd2form1.Name = "cmd2form1"
        cmd2form1.Size = New Size(132, 23)
        cmd2form1.TabIndex = 3
        cmd2form1.Text = "To Form 1"
        cmd2form1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 333)
        Controls.Add(cmd2form1)
        Controls.Add(cmd2form3)
        Controls.Add(txt_password)
        Controls.Add(Button2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents cmd2form3 As Button
    Friend WithEvents cmd2form1 As Button
End Class
