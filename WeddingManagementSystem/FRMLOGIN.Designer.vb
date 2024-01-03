<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMLOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLOGIN))
        Me.BTNLOGIN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXTUSERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SEEPASSWORD = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTNRFID = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.Animated = True
        Me.BTNLOGIN.AutoRoundedCorners = True
        Me.BTNLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGIN.BorderRadius = 21
        Me.BTNLOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGIN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLOGIN.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNLOGIN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGIN.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNLOGIN.Location = New System.Drawing.Point(405, 340)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(113, 45)
        Me.BTNLOGIN.TabIndex = 17
        Me.BTNLOGIN.Text = "LOG IN"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(428, 93)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(184, 158)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 19
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXTUSERNAME
        '
        Me.TXTUSERNAME.Animated = True
        Me.TXTUSERNAME.AutoRoundedCorners = True
        Me.TXTUSERNAME.BackColor = System.Drawing.Color.Transparent
        Me.TXTUSERNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTUSERNAME.BorderRadius = 19
        Me.TXTUSERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSERNAME.DefaultText = ""
        Me.TXTUSERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSERNAME.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TXTUSERNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTUSERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSERNAME.IconLeft = CType(resources.GetObject("TXTUSERNAME.IconLeft"), System.Drawing.Image)
        Me.TXTUSERNAME.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTUSERNAME.Location = New System.Drawing.Point(405, 246)
        Me.TXTUSERNAME.Name = "TXTUSERNAME"
        Me.TXTUSERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSERNAME.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTUSERNAME.PlaceholderText = "ID/Username"
        Me.TXTUSERNAME.SelectedText = ""
        Me.TXTUSERNAME.Size = New System.Drawing.Size(230, 41)
        Me.TXTUSERNAME.TabIndex = 20
        Me.TXTUSERNAME.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Animated = True
        Me.TXTPASSWORD.AutoRoundedCorners = True
        Me.TXTPASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.TXTPASSWORD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPASSWORD.BorderRadius = 19
        Me.TXTPASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASSWORD.DefaultText = ""
        Me.TXTPASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASSWORD.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TXTPASSWORD.ForeColor = System.Drawing.Color.Black
        Me.TXTPASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASSWORD.IconLeft = CType(resources.GetObject("TXTPASSWORD.IconLeft"), System.Drawing.Image)
        Me.TXTPASSWORD.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTPASSWORD.Location = New System.Drawing.Point(405, 293)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXTPASSWORD.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPASSWORD.PlaceholderText = "Password"
        Me.TXTPASSWORD.SelectedText = ""
        Me.TXTPASSWORD.Size = New System.Drawing.Size(230, 41)
        Me.TXTPASSWORD.TabIndex = 21
        Me.TXTPASSWORD.TextOffset = New System.Drawing.Point(5, 0)
        '
        'SEEPASSWORD
        '
        Me.SEEPASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.SEEPASSWORD.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SEEPASSWORD.Image = CType(resources.GetObject("SEEPASSWORD.Image"), System.Drawing.Image)
        Me.SEEPASSWORD.ImageOffset = New System.Drawing.Point(0, 0)
        Me.SEEPASSWORD.ImageRotate = 0!
        Me.SEEPASSWORD.Location = New System.Drawing.Point(605, 293)
        Me.SEEPASSWORD.Name = "SEEPASSWORD"
        Me.SEEPASSWORD.Size = New System.Drawing.Size(30, 41)
        Me.SEEPASSWORD.TabIndex = 23
        Me.SEEPASSWORD.UseTransparentBackground = True
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(0, 0)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Guna2ImageButton1.IndicateFocus = True
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(605, 293)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(30, 41)
        Me.Guna2ImageButton1.TabIndex = 22
        Me.Guna2ImageButton1.UseTransparentBackground = True
        Me.Guna2ImageButton1.Visible = False
        '
        'BTNRFID
        '
        Me.BTNRFID.Animated = True
        Me.BTNRFID.AutoRoundedCorners = True
        Me.BTNRFID.BackColor = System.Drawing.Color.Transparent
        Me.BTNRFID.BorderRadius = 21
        Me.BTNRFID.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRFID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRFID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRFID.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRFID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRFID.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNRFID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRFID.ForeColor = System.Drawing.Color.White
        Me.BTNRFID.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNRFID.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNRFID.Location = New System.Drawing.Point(522, 340)
        Me.BTNRFID.Name = "BTNRFID"
        Me.BTNRFID.Size = New System.Drawing.Size(113, 45)
        Me.BTNRFID.TabIndex = 24
        Me.BTNRFID.Text = "RFID"
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 645)
        Me.Controls.Add(Me.BTNRFID)
        Me.Controls.Add(Me.SEEPASSWORD)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.TXTUSERNAME)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMLOGIN"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNLOGIN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXTPASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SEEPASSWORD As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTNRFID As Guna.UI2.WinForms.Guna2GradientButton
    Public WithEvents TXTUSERNAME As Guna.UI2.WinForms.Guna2TextBox
End Class
