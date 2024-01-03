<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRFID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMRFID))
        Me.TXTRFID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PANEL = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BTNCANCEL = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNLOGINRFID = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTRFID
        '
        Me.TXTRFID.Animated = True
        Me.TXTRFID.AutoRoundedCorners = True
        Me.TXTRFID.BackColor = System.Drawing.Color.Transparent
        Me.TXTRFID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTRFID.BorderRadius = 34
        Me.TXTRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTRFID.DefaultText = ""
        Me.TXTRFID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTRFID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTRFID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRFID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRFID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTRFID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFID.ForeColor = System.Drawing.Color.Black
        Me.TXTRFID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTRFID.IconLeft = CType(resources.GetObject("TXTRFID.IconLeft"), System.Drawing.Image)
        Me.TXTRFID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTRFID.Location = New System.Drawing.Point(110, 77)
        Me.TXTRFID.Name = "TXTRFID"
        Me.TXTRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXTRFID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTRFID.PlaceholderText = "RFID Number"
        Me.TXTRFID.SelectedText = ""
        Me.TXTRFID.Size = New System.Drawing.Size(313, 71)
        Me.TXTRFID.TabIndex = 21
        Me.TXTRFID.TextOffset = New System.Drawing.Point(5, 0)
        Me.TXTRFID.UseSystemPasswordChar = True
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(586, 64)
        Me.Guna2GradientPanel2.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RFID"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.PANEL)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 64)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(586, 386)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'PANEL
        '
        Me.PANEL.BackColor = System.Drawing.Color.Transparent
        Me.PANEL.Controls.Add(Me.BTNCANCEL)
        Me.PANEL.Controls.Add(Me.TXTRFID)
        Me.PANEL.Controls.Add(Me.BTNLOGINRFID)
        Me.PANEL.FillColor = System.Drawing.Color.White
        Me.PANEL.Location = New System.Drawing.Point(28, 16)
        Me.PANEL.Name = "PANEL"
        Me.PANEL.Radius = 10
        Me.PANEL.ShadowColor = System.Drawing.Color.White
        Me.PANEL.Size = New System.Drawing.Size(546, 347)
        Me.PANEL.TabIndex = 23
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.Animated = True
        Me.BTNCANCEL.AutoRoundedCorners = True
        Me.BTNCANCEL.BackColor = System.Drawing.Color.Transparent
        Me.BTNCANCEL.BorderRadius = 21
        Me.BTNCANCEL.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCANCEL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCANCEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCANCEL.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCANCEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCANCEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNCANCEL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCANCEL.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNCANCEL.Location = New System.Drawing.Point(153, 214)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(230, 45)
        Me.BTNCANCEL.TabIndex = 42
        Me.BTNCANCEL.Text = "Cancel"
        '
        'BTNLOGINRFID
        '
        Me.BTNLOGINRFID.Animated = True
        Me.BTNLOGINRFID.AutoRoundedCorners = True
        Me.BTNLOGINRFID.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGINRFID.BorderRadius = 21
        Me.BTNLOGINRFID.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGINRFID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGINRFID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGINRFID.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGINRFID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLOGINRFID.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNLOGINRFID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGINRFID.ForeColor = System.Drawing.Color.White
        Me.BTNLOGINRFID.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGINRFID.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNLOGINRFID.Location = New System.Drawing.Point(153, 163)
        Me.BTNLOGINRFID.Name = "BTNLOGINRFID"
        Me.BTNLOGINRFID.Size = New System.Drawing.Size(230, 45)
        Me.BTNLOGINRFID.TabIndex = 22
        Me.BTNLOGINRFID.Text = "Login"
        '
        'FRMRFID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMRFID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMRFID"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TXTRFID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PANEL As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTNCANCEL As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNLOGINRFID As Guna.UI2.WinForms.Guna2GradientButton
End Class
