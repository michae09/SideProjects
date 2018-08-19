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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Player1Txt = New System.Windows.Forms.TextBox()
        Me.Player2Txt = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Winner1 = New System.Windows.Forms.Label()
        Me.Winner2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(245, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 214)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(584, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 214)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(426, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Play Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Player1Txt
        '
        Me.Player1Txt.Location = New System.Drawing.Point(262, 265)
        Me.Player1Txt.Name = "Player1Txt"
        Me.Player1Txt.Size = New System.Drawing.Size(100, 20)
        Me.Player1Txt.TabIndex = 3
        Me.Player1Txt.Text = "Player 1"
        '
        'Player2Txt
        '
        Me.Player2Txt.Location = New System.Drawing.Point(602, 265)
        Me.Player2Txt.Name = "Player2Txt"
        Me.Player2Txt.Size = New System.Drawing.Size(100, 20)
        Me.Player2Txt.TabIndex = 4
        Me.Player2Txt.Text = "Player 2"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(426, 105)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(111, 113)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Visible = False
        '
        'Winner1
        '
        Me.Winner1.AutoSize = True
        Me.Winner1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winner1.Location = New System.Drawing.Point(239, 312)
        Me.Winner1.Name = "Winner1"
        Me.Winner1.Size = New System.Drawing.Size(146, 36)
        Me.Winner1.TabIndex = 6
        Me.Winner1.Text = "WINNER!"
        Me.Winner1.Visible = False
        '
        'Winner2
        '
        Me.Winner2.AutoSize = True
        Me.Winner2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winner2.ForeColor = System.Drawing.Color.Firebrick
        Me.Winner2.Location = New System.Drawing.Point(578, 312)
        Me.Winner2.Name = "Winner2"
        Me.Winner2.Size = New System.Drawing.Size(146, 36)
        Me.Winner2.TabIndex = 7
        Me.Winner2.Text = "WINNER!"
        Me.Winner2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1015, 448)
        Me.Controls.Add(Me.Winner2)
        Me.Controls.Add(Me.Winner1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Player2Txt)
        Me.Controls.Add(Me.Player1Txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ForeColor = System.Drawing.Color.Firebrick
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Player1Txt As TextBox
    Friend WithEvents Player2Txt As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Winner1 As Label
    Friend WithEvents Winner2 As Label
End Class
