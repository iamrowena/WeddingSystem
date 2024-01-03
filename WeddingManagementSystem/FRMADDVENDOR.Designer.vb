<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMADDVENDOR
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VADDRESS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VTYPE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNCAN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNUPDATE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.VRFID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VPASS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VMAILADD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNSAVE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.VCONTACT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VEMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.AutoSize = True
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(617, 511)
        Me.Guna2GradientPanel1.TabIndex = 3
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(617, 64)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADD VENDOR"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.VID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VADDRESS)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VTYPE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNCAN)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNUPDATE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VRFID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VPASS)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VMAILADD)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNSAVE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VCONTACT)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VEMAIL)
        Me.Guna2ShadowPanel1.Controls.Add(Me.VNAME)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(25, 65)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(546, 434)
        Me.Guna2ShadowPanel1.TabIndex = 0
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
        'VADDRESS
        '
        Me.VADDRESS.Animated = True
        Me.VADDRESS.AutoRoundedCorners = True
        Me.VADDRESS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VADDRESS.BorderRadius = 17
        Me.VADDRESS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VADDRESS.DefaultText = ""
        Me.VADDRESS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VADDRESS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VADDRESS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VADDRESS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VADDRESS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VADDRESS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VADDRESS.ForeColor = System.Drawing.Color.Black
        Me.VADDRESS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VADDRESS.Location = New System.Drawing.Point(33, 111)
        Me.VADDRESS.Name = "VADDRESS"
        Me.VADDRESS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VADDRESS.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VADDRESS.PlaceholderText = "Address"
        Me.VADDRESS.SelectedText = ""
        Me.VADDRESS.Size = New System.Drawing.Size(480, 36)
        Me.VADDRESS.TabIndex = 20
        Me.VADDRESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VTYPE
        '
        Me.VTYPE.Animated = True
        Me.VTYPE.AutoRoundedCorners = True
        Me.VTYPE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VTYPE.BorderRadius = 17
        Me.VTYPE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VTYPE.DefaultText = ""
        Me.VTYPE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VTYPE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VTYPE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VTYPE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VTYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VTYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VTYPE.ForeColor = System.Drawing.Color.Black
        Me.VTYPE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VTYPE.Location = New System.Drawing.Point(376, 69)
        Me.VTYPE.Name = "VTYPE"
        Me.VTYPE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VTYPE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VTYPE.PlaceholderText = "Service"
        Me.VTYPE.SelectedText = ""
        Me.VTYPE.Size = New System.Drawing.Size(137, 36)
        Me.VTYPE.TabIndex = 18
        Me.VTYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNCAN
        '
        Me.BTNCAN.Animated = True
        Me.BTNCAN.AutoRoundedCorners = True
        Me.BTNCAN.BackColor = System.Drawing.Color.Transparent
        Me.BTNCAN.BorderRadius = 21
        Me.BTNCAN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCAN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCAN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCAN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCAN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCAN.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNCAN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCAN.ForeColor = System.Drawing.Color.White
        Me.BTNCAN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCAN.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNCAN.Location = New System.Drawing.Point(268, 355)
        Me.BTNCAN.Name = "BTNCAN"
        Me.BTNCAN.Size = New System.Drawing.Size(149, 45)
        Me.BTNCAN.TabIndex = 17
        Me.BTNCAN.Text = "Cancel"
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
        Me.BTNUPDATE.Location = New System.Drawing.Point(113, 355)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(149, 45)
        Me.BTNUPDATE.TabIndex = 16
        Me.BTNUPDATE.Text = "Update"
        '
        'VRFID
        '
        Me.VRFID.Animated = True
        Me.VRFID.AutoRoundedCorners = True
        Me.VRFID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VRFID.BorderRadius = 17
        Me.VRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VRFID.DefaultText = ""
        Me.VRFID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VRFID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VRFID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VRFID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VRFID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VRFID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VRFID.ForeColor = System.Drawing.Color.Black
        Me.VRFID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VRFID.Location = New System.Drawing.Point(33, 241)
        Me.VRFID.Name = "VRFID"
        Me.VRFID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VRFID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VRFID.PlaceholderText = "RFID"
        Me.VRFID.SelectedText = ""
        Me.VRFID.Size = New System.Drawing.Size(229, 36)
        Me.VRFID.TabIndex = 15
        Me.VRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VPASS
        '
        Me.VPASS.Animated = True
        Me.VPASS.AutoRoundedCorners = True
        Me.VPASS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VPASS.BorderRadius = 17
        Me.VPASS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VPASS.DefaultText = ""
        Me.VPASS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VPASS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VPASS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VPASS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VPASS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VPASS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VPASS.ForeColor = System.Drawing.Color.Black
        Me.VPASS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VPASS.Location = New System.Drawing.Point(154, 283)
        Me.VPASS.Name = "VPASS"
        Me.VPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.VPASS.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VPASS.PlaceholderText = "Password"
        Me.VPASS.SelectedText = ""
        Me.VPASS.Size = New System.Drawing.Size(245, 36)
        Me.VPASS.TabIndex = 14
        Me.VPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VPASS.UseSystemPasswordChar = True
        '
        'VMAILADD
        '
        Me.VMAILADD.Animated = True
        Me.VMAILADD.AutoRoundedCorners = True
        Me.VMAILADD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VMAILADD.BorderRadius = 17
        Me.VMAILADD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VMAILADD.DefaultText = ""
        Me.VMAILADD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VMAILADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VMAILADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VMAILADD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VMAILADD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VMAILADD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VMAILADD.ForeColor = System.Drawing.Color.Black
        Me.VMAILADD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VMAILADD.Location = New System.Drawing.Point(268, 241)
        Me.VMAILADD.Name = "VMAILADD"
        Me.VMAILADD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VMAILADD.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VMAILADD.PlaceholderText = "Email"
        Me.VMAILADD.SelectedText = ""
        Me.VMAILADD.Size = New System.Drawing.Size(245, 36)
        Me.VMAILADD.TabIndex = 13
        Me.VMAILADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTNSAVE.Location = New System.Drawing.Point(113, 355)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(149, 45)
        Me.BTNSAVE.TabIndex = 9
        Me.BTNSAVE.Text = "Save"
        '
        'VCONTACT
        '
        Me.VCONTACT.Animated = True
        Me.VCONTACT.AutoRoundedCorners = True
        Me.VCONTACT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VCONTACT.BorderRadius = 17
        Me.VCONTACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VCONTACT.DefaultText = ""
        Me.VCONTACT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VCONTACT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VCONTACT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VCONTACT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VCONTACT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VCONTACT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VCONTACT.ForeColor = System.Drawing.Color.Black
        Me.VCONTACT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VCONTACT.Location = New System.Drawing.Point(268, 153)
        Me.VCONTACT.Name = "VCONTACT"
        Me.VCONTACT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VCONTACT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VCONTACT.PlaceholderText = "Contact Number"
        Me.VCONTACT.SelectedText = ""
        Me.VCONTACT.Size = New System.Drawing.Size(245, 36)
        Me.VCONTACT.TabIndex = 11
        Me.VCONTACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VEMAIL
        '
        Me.VEMAIL.Animated = True
        Me.VEMAIL.AutoRoundedCorners = True
        Me.VEMAIL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VEMAIL.BorderRadius = 17
        Me.VEMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VEMAIL.DefaultText = ""
        Me.VEMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VEMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VEMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VEMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VEMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VEMAIL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VEMAIL.ForeColor = System.Drawing.Color.Black
        Me.VEMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VEMAIL.Location = New System.Drawing.Point(33, 153)
        Me.VEMAIL.Name = "VEMAIL"
        Me.VEMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VEMAIL.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VEMAIL.PlaceholderText = "GMail"
        Me.VEMAIL.SelectedText = ""
        Me.VEMAIL.Size = New System.Drawing.Size(229, 36)
        Me.VEMAIL.TabIndex = 10
        Me.VEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VNAME
        '
        Me.VNAME.Animated = True
        Me.VNAME.AutoRoundedCorners = True
        Me.VNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VNAME.BorderRadius = 17
        Me.VNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VNAME.DefaultText = ""
        Me.VNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VNAME.ForeColor = System.Drawing.Color.Black
        Me.VNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VNAME.Location = New System.Drawing.Point(33, 69)
        Me.VNAME.Name = "VNAME"
        Me.VNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VNAME.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VNAME.PlaceholderText = "Business Name"
        Me.VNAME.SelectedText = ""
        Me.VNAME.Size = New System.Drawing.Size(337, 36)
        Me.VNAME.TabIndex = 9
        Me.VNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VID
        '
        Me.VID.Animated = True
        Me.VID.AutoRoundedCorners = True
        Me.VID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VID.BorderRadius = 17
        Me.VID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VID.DefaultText = ""
        Me.VID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VID.ForeColor = System.Drawing.Color.Black
        Me.VID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VID.Location = New System.Drawing.Point(33, 27)
        Me.VID.Name = "VID"
        Me.VID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VID.PlaceholderText = "ID"
        Me.VID.SelectedText = ""
        Me.VID.Size = New System.Drawing.Size(229, 36)
        Me.VID.TabIndex = 57
        Me.VID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FRMADDVENDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 511)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDVENDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMADDVENDOR"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTNCAN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNUPDATE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents VRFID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VPASS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VMAILADD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSAVE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents VCONTACT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VEMAIL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VTYPE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VADDRESS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VID As Guna.UI2.WinForms.Guna2TextBox
End Class
