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
        txtNomePasta = New TextBox()
        Label1 = New Label()
        btnCriarPasta = New Button()
        SuspendLayout()
        ' 
        ' txtNomePasta
        ' 
        txtNomePasta.Location = New Point(106, 158)
        txtNomePasta.Name = "txtNomePasta"
        txtNomePasta.Size = New Size(548, 23)
        txtNomePasta.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(291, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 25)
        Label1.TabIndex = 1
        Label1.Text = "Digite o nome da pasta"
        ' 
        ' btnCriarPasta
        ' 
        btnCriarPasta.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCriarPasta.Location = New Point(320, 202)
        btnCriarPasta.Name = "btnCriarPasta"
        btnCriarPasta.Size = New Size(157, 58)
        btnCriarPasta.TabIndex = 2
        btnCriarPasta.Text = "Criar pasta"
        btnCriarPasta.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCriarPasta)
        Controls.Add(Label1)
        Controls.Add(txtNomePasta)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNomePasta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCriarPasta As Button

End Class
