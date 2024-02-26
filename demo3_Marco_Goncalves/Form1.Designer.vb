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
        txt_n1 = New TextBox()
        cmd_verifica_numero = New Button()
        lbl_n1 = New Label()
        cmd2form2 = New Button()
        SuspendLayout()
        ' 
        ' txt_n1
        ' 
        txt_n1.Location = New Point(110, 164)
        txt_n1.Name = "txt_n1"
        txt_n1.Size = New Size(141, 23)
        txt_n1.TabIndex = 0
        ' 
        ' cmd_verifica_numero
        ' 
        cmd_verifica_numero.Location = New Point(110, 94)
        cmd_verifica_numero.Name = "cmd_verifica_numero"
        cmd_verifica_numero.Size = New Size(186, 32)
        cmd_verifica_numero.TabIndex = 1
        cmd_verifica_numero.Text = "Verifica Numero"
        cmd_verifica_numero.UseVisualStyleBackColor = True
        ' 
        ' lbl_n1
        ' 
        lbl_n1.AutoSize = True
        lbl_n1.Location = New Point(110, 212)
        lbl_n1.Name = "lbl_n1"
        lbl_n1.Size = New Size(41, 15)
        lbl_n1.TabIndex = 2
        lbl_n1.Text = "Label1"
        ' 
        ' cmd2form2
        ' 
        cmd2form2.Location = New Point(110, 271)
        cmd2form2.Name = "cmd2form2"
        cmd2form2.Size = New Size(157, 23)
        cmd2form2.TabIndex = 3
        cmd2form2.Text = "To Form 2"
        cmd2form2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 346)
        Controls.Add(cmd2form2)
        Controls.Add(lbl_n1)
        Controls.Add(cmd_verifica_numero)
        Controls.Add(txt_n1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_n1 As TextBox
    Friend WithEvents cmd_verifica_numero As Button
    Friend WithEvents lbl_n1 As Label
    Friend WithEvents cmd2form2 As Button
End Class
