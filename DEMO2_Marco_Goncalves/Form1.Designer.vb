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
        But_if = New Button()
        But_ifcase = New Button()
        txtNumero = New TextBox()
        SuspendLayout()
        ' 
        ' But_if
        ' 
        But_if.Location = New Point(128, 41)
        But_if.Name = "But_if"
        But_if.Size = New Size(301, 83)
        But_if.TabIndex = 0
        But_if.Text = "Botão If"
        But_if.UseVisualStyleBackColor = True
        ' 
        ' But_ifcase
        ' 
        But_ifcase.Location = New Point(123, 204)
        But_ifcase.Name = "But_ifcase"
        But_ifcase.Size = New Size(312, 74)
        But_ifcase.TabIndex = 1
        But_ifcase.Text = "Botão Case"
        But_ifcase.UseVisualStyleBackColor = True
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(237, 154)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(99, 23)
        txtNumero.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 349)
        Controls.Add(txtNumero)
        Controls.Add(But_ifcase)
        Controls.Add(But_if)
        Name = "Form1"
        Text = "Botoes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents But_if As Button
    Friend WithEvents But_ifcase As Button
    Friend WithEvents txtNumero As TextBox
End Class
