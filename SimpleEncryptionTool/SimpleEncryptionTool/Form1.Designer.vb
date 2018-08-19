<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.encryptBtn = New System.Windows.Forms.Button()
        Me.decryptBtn = New System.Windows.Forms.Button()
        Me.encryptLabel = New System.Windows.Forms.Label()
        Me.decryptedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 0
        '
        'encryptBtn
        '
        Me.encryptBtn.Location = New System.Drawing.Point(358, 101)
        Me.encryptBtn.Name = "encryptBtn"
        Me.encryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.encryptBtn.TabIndex = 1
        Me.encryptBtn.Text = "Encrypt"
        Me.encryptBtn.UseVisualStyleBackColor = True
        '
        'decryptBtn
        '
        Me.decryptBtn.Location = New System.Drawing.Point(358, 198)
        Me.decryptBtn.Name = "decryptBtn"
        Me.decryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.decryptBtn.TabIndex = 2
        Me.decryptBtn.Text = "Decrypt"
        Me.decryptBtn.UseVisualStyleBackColor = True
        '
        'encryptLabel
        '
        Me.encryptLabel.AutoSize = True
        Me.encryptLabel.Location = New System.Drawing.Point(63, 101)
        Me.encryptLabel.Name = "encryptLabel"
        Me.encryptLabel.Size = New System.Drawing.Size(85, 13)
        Me.encryptLabel.TabIndex = 3
        Me.encryptLabel.Text = "Encrypted String"
        '
        'decryptedLabel
        '
        Me.decryptedLabel.AutoSize = True
        Me.decryptedLabel.Location = New System.Drawing.Point(66, 198)
        Me.decryptedLabel.Name = "decryptedLabel"
        Me.decryptedLabel.Size = New System.Drawing.Size(86, 13)
        Me.decryptedLabel.TabIndex = 4
        Me.decryptedLabel.Text = "Decrypted String"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 295)
        Me.Controls.Add(Me.decryptedLabel)
        Me.Controls.Add(Me.encryptLabel)
        Me.Controls.Add(Me.decryptBtn)
        Me.Controls.Add(Me.encryptBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents encryptBtn As Button
    Friend WithEvents decryptBtn As Button
    Friend WithEvents encryptLabel As Label
    Friend WithEvents decryptedLabel As Label
End Class
