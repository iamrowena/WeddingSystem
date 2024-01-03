<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMADDBOOK
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
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTADDRESS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTAGE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNUPDATE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TXTRFID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTUSERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNSAVE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TXTCONTACT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTEMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTCNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTID
        '
        Me.TXTID.Animated = True
        Me.TXTID.AutoRoundedCorners = True
        Me.TXTID.BackColor = System.Drawing.Color.Transparent
        Me.TXTID.BorderRadius = 17
        Me.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTID.DefaultText = ""
        Me.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTID.ForeColor = System.Drawing.Color.Black
        Me.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.Location = New System.Drawing.Point(440, 12)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TXTID.PlaceholderText = "ID"
        Me.TXTID.SelectedText = ""
        Me.TXTID.Size = New System.Drawing.Size(133, 36)
        Me.TXTID.TabIndex = 5
        Me.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Security"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Client Information"
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.Animated = True
        Me.TXTADDRESS.AutoRoundedCorners = True
        Me.TXTADDRESS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTADDRESS.BorderRadius = 17
        Me.TXTADDRESS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTADDRESS.DefaultText = ""
        Me.TXTADDRESS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTADDRESS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTADDRESS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDRESS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDRESS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDRESS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTADDRESS.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDRESS.Location = New System.Drawing.Point(187, 111)
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTADDRESS.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTADDRESS.PlaceholderText = "Address"
        Me.TXTADDRESS.SelectedText = ""
        Me.TXTADDRESS.Size = New System.Drawing.Size(328, 36)
        Me.TXTADDRESS.TabIndex = 20
        Me.TXTADDRESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTAGE
        '
        Me.TXTAGE.Animated = True
        Me.TXTAGE.AutoRoundedCorners = True
        Me.TXTAGE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTAGE.BorderRadius = 17
        Me.TXTAGE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTAGE.DefaultText = ""
        Me.TXTAGE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTAGE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTAGE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAGE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAGE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAGE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTAGE.ForeColor = System.Drawing.Color.Black
        Me.TXTAGE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAGE.Location = New System.Drawing.Point(33, 111)
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTAGE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTAGE.PlaceholderText = "Birthday"
        Me.TXTAGE.SelectedText = ""
        Me.TXTAGE.Size = New System.Drawing.Size(150, 36)
        Me.TXTAGE.TabIndex = 19
        Me.TXTAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.Animated = True
        Me.Guna2GradientButton3.AutoRoundedCorners = True
        Me.Guna2GradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.BorderRadius = 21
        Me.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(360, 350)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(151, 45)
        Me.Guna2GradientButton3.TabIndex = 17
        Me.Guna2GradientButton3.Text = "Cancel"
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.Animated = True
        Me.BTNUPDATE.AutoRoundedCorners = True
        Me.BTNUPDATE.BackColor = System.Drawing.Color.Transparent
        Me.BTNUPDATE.BorderRadius = 21
        Me.BTNUPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNUPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNUPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNUPDATE.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNUPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNUPDATE.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNUPDATE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUPDATE.ForeColor = System.Drawing.Color.White
        Me.BTNUPDATE.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNUPDATE.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNUPDATE.Location = New System.Drawing.Point(195, 350)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(151, 45)
        Me.BTNUPDATE.TabIndex = 16
        Me.BTNUPDATE.Text = "Update"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.AutoSize = True
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.TXTID)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(608, 520)
        Me.Guna2GradientPanel1.TabIndex = 5
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTADDRESS)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTAGE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2GradientButton3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNUPDATE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTRFID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTPASSWORD)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTUSERNAME)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNSAVE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTCONTACT)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTEMAIL)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTCNAME)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(25, 65)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(548, 434)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'TXTRFID
        '
        Me.TXTRFID.Animated = True
        Me.TXTRFID.AutoRoundedCorners = True
        Me.TXTRFID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTRFID.BorderRadius = 17
        Me.TXTRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTRFID.DefaultText = ""
        Me.TXTRFID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTRFID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTRFID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRFID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRFID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTRFID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTRFID.ForeColor = System.Drawing.Color.Black
        Me.TXTRFID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTRFID.Location = New System.Drawing.Point(33, 241)
        Me.TXTRFID.Name = "TXTRFID"
        Me.TXTRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTRFID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTRFID.PlaceholderText = "RFID"
        Me.TXTRFID.SelectedText = ""
        Me.TXTRFID.Size = New System.Drawing.Size(231, 36)
        Me.TXTRFID.TabIndex = 15
        Me.TXTRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Animated = True
        Me.TXTPASSWORD.AutoRoundedCorners = True
        Me.TXTPASSWORD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPASSWORD.BorderRadius = 17
        Me.TXTPASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASSWORD.DefaultText = ""
        Me.TXTPASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASSWORD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTPASSWORD.ForeColor = System.Drawing.Color.Black
        Me.TXTPASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASSWORD.Location = New System.Drawing.Point(268, 283)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASSWORD.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPASSWORD.PlaceholderText = "Password"
        Me.TXTPASSWORD.SelectedText = ""
        Me.TXTPASSWORD.Size = New System.Drawing.Size(247, 36)
        Me.TXTPASSWORD.TabIndex = 14
        Me.TXTPASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTUSERNAME
        '
        Me.TXTUSERNAME.Animated = True
        Me.TXTUSERNAME.AutoRoundedCorners = True
        Me.TXTUSERNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTUSERNAME.BorderRadius = 17
        Me.TXTUSERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSERNAME.DefaultText = ""
        Me.TXTUSERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSERNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTUSERNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTUSERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSERNAME.Location = New System.Drawing.Point(33, 283)
        Me.TXTUSERNAME.Name = "TXTUSERNAME"
        Me.TXTUSERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSERNAME.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTUSERNAME.PlaceholderText = "Username"
        Me.TXTUSERNAME.SelectedText = ""
        Me.TXTUSERNAME.Size = New System.Drawing.Size(231, 36)
        Me.TXTUSERNAME.TabIndex = 13
        Me.TXTUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Animated = True
        Me.BTNSAVE.AutoRoundedCorners = True
        Me.BTNSAVE.BackColor = System.Drawing.Color.Transparent
        Me.BTNSAVE.BorderRadius = 21
        Me.BTNSAVE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNSAVE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNSAVE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSAVE.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSAVE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSAVE.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNSAVE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSAVE.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNSAVE.Location = New System.Drawing.Point(33, 350)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(151, 45)
        Me.BTNSAVE.TabIndex = 9
        Me.BTNSAVE.Text = "Save"
        '
        'TXTCONTACT
        '
        Me.TXTCONTACT.Animated = True
        Me.TXTCONTACT.AutoRoundedCorners = True
        Me.TXTCONTACT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCONTACT.BorderRadius = 17
        Me.TXTCONTACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCONTACT.DefaultText = ""
        Me.TXTCONTACT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCONTACT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCONTACT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCONTACT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCONTACT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCONTACT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTCONTACT.ForeColor = System.Drawing.Color.Black
        Me.TXTCONTACT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCONTACT.Location = New System.Drawing.Point(268, 153)
        Me.TXTCONTACT.Name = "TXTCONTACT"
        Me.TXTCONTACT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCONTACT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCONTACT.PlaceholderText = "Contact Number"
        Me.TXTCONTACT.SelectedText = ""
        Me.TXTCONTACT.Size = New System.Drawing.Size(247, 36)
        Me.TXTCONTACT.TabIndex = 11
        Me.TXTCONTACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Animated = True
        Me.TXTEMAIL.AutoRoundedCorners = True
        Me.TXTEMAIL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTEMAIL.BorderRadius = 17
        Me.TXTEMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTEMAIL.DefaultText = ""
        Me.TXTEMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTEMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTEMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTEMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTEMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTEMAIL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTEMAIL.ForeColor = System.Drawing.Color.Black
        Me.TXTEMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTEMAIL.Location = New System.Drawing.Point(33, 153)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTEMAIL.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTEMAIL.PlaceholderText = "Email"
        Me.TXTEMAIL.SelectedText = ""
        Me.TXTEMAIL.Size = New System.Drawing.Size(231, 36)
        Me.TXTEMAIL.TabIndex = 10
        Me.TXTEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCNAME
        '
        Me.TXTCNAME.Animated = True
        Me.TXTCNAME.AutoRoundedCorners = True
        Me.TXTCNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCNAME.BorderRadius = 17
        Me.TXTCNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCNAME.DefaultText = ""
        Me.TXTCNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTCNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTCNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCNAME.Location = New System.Drawing.Point(33, 69)
        Me.TXTCNAME.Name = "TXTCNAME"
        Me.TXTCNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCNAME.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCNAME.PlaceholderText = "Planner's Name"
        Me.TXTCNAME.SelectedText = ""
        Me.TXTCNAME.Size = New System.Drawing.Size(482, 36)
        Me.TXTCNAME.TabIndex = 9
        Me.TXTCNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FRMADDBOOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 520)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDBOOK"
        Me.Text = "FRMADDBOOK"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTADDRESS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTAGE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNUPDATE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TXTRFID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTPASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTUSERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSAVE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTCONTACT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTEMAIL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTCNAME As Guna.UI2.WinForms.Guna2TextBox
End Class
