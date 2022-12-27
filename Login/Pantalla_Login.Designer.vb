<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla_Login
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapedPanel2 = New Login.ShapedPanel()
        Me.ShapedPanel3 = New Login.ShapedPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ShapedPanel4 = New Login.ShapedPanel()
        Me.ShapedPanel7 = New Login.ShapedPanel()
        Me.ShapedPanel1 = New Login.ShapedPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShapedPanel2.SuspendLayout()
        Me.ShapedPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(8, 34)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(123, 19)
        Label1.TabIndex = 0
        Label1.Text = "INICIAR SESION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(216, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 22)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'btnRound
        '
        Me.btnRound.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRound.BackColor = System.Drawing.Color.Transparent
        Me.btnRound.FlatAppearance.BorderSize = 0
        Me.btnRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRound.Location = New System.Drawing.Point(184, 344)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(124, 32)
        Me.btnRound.TabIndex = 10
        Me.btnRound.Text = "ENTRAR"
        Me.btnRound.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.Location = New System.Drawing.Point(280, 296)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(137, 17)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Olvidé Mi Contraseña"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "USUARIO"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CONTRASEÑA"
        '
        'ShapedPanel2
        '
        Me.ShapedPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShapedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ShapedPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.ShapedPanel2.Controls.Add(Me.Label4)
        Me.ShapedPanel2.Edge = 40
        Me.ShapedPanel2.Location = New System.Drawing.Point(57, 235)
        Me.ShapedPanel2.Name = "ShapedPanel2"
        Me.ShapedPanel2.Size = New System.Drawing.Size(192, 46)
        Me.ShapedPanel2.TabIndex = 0
        '
        'ShapedPanel3
        '
        Me.ShapedPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShapedPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ShapedPanel3.BorderColor = System.Drawing.Color.Transparent
        Me.ShapedPanel3.Controls.Add(Me.Label3)
        Me.ShapedPanel3.Edge = 40
        Me.ShapedPanel3.Location = New System.Drawing.Point(56, 172)
        Me.ShapedPanel3.Name = "ShapedPanel3"
        Me.ShapedPanel3.Size = New System.Drawing.Size(192, 46)
        Me.ShapedPanel3.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(216, 184)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 22)
        Me.TextBox1.TabIndex = 1
        '
        'ShapedPanel4
        '
        Me.ShapedPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShapedPanel4.BackColor = System.Drawing.Color.White
        Me.ShapedPanel4.BorderColor = System.Drawing.Color.Transparent
        Me.ShapedPanel4.Edge = 40
        Me.ShapedPanel4.Location = New System.Drawing.Point(248, 172)
        Me.ShapedPanel4.Name = "ShapedPanel4"
        Me.ShapedPanel4.Size = New System.Drawing.Size(192, 46)
        Me.ShapedPanel4.TabIndex = 0
        '
        'ShapedPanel7
        '
        Me.ShapedPanel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShapedPanel7.BackColor = System.Drawing.Color.White
        Me.ShapedPanel7.BorderColor = System.Drawing.Color.Transparent
        Me.ShapedPanel7.Edge = 40
        Me.ShapedPanel7.Location = New System.Drawing.Point(248, 235)
        Me.ShapedPanel7.Name = "ShapedPanel7"
        Me.ShapedPanel7.Size = New System.Drawing.Size(192, 46)
        Me.ShapedPanel7.TabIndex = 0
        '
        'ShapedPanel1
        '
        Me.ShapedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShapedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ShapedPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.ShapedPanel1.Edge = 40
        Me.ShapedPanel1.Location = New System.Drawing.Point(0, 20)
        Me.ShapedPanel1.Name = "ShapedPanel1"
        Me.ShapedPanel1.Size = New System.Drawing.Size(136, 46)
        Me.ShapedPanel1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Location = New System.Drawing.Point(207, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 46)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(207, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 46)
        Me.Panel2.TabIndex = 11
        '
        'Pantalla_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapedPanel4)
        Me.Controls.Add(Me.ShapedPanel1)
        Me.Controls.Add(Me.ShapedPanel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapedPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapedPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "8"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShapedPanel2.ResumeLayout(False)
        Me.ShapedPanel2.PerformLayout()
        Me.ShapedPanel3.ResumeLayout(False)
        Me.ShapedPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnRound As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapedPanel2 As ShapedPanel
    Friend WithEvents ShapedPanel3 As ShapedPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ShapedPanel4 As ShapedPanel
    Friend WithEvents ShapedPanel7 As ShapedPanel
    Friend WithEvents ShapedPanel1 As ShapedPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
