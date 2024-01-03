<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMADDPAYMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMADDPAYMENT))
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PANEL = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TXTDOWNPAYMENT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTREF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPACKAGE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTCNAME = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNCANCEL = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNUPDATE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TXTCLIENTNO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNSAVE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TXTDATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TXTAMOUNT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNHIDE = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.BTNHIDE)
        Me.Guna2GradientPanel2.Controls.Add(Me.TXTID)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(546, 64)
        Me.Guna2GradientPanel2.TabIndex = 1
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
        Me.TXTID.Location = New System.Drawing.Point(326, 12)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TXTID.PlaceholderText = "ID"
        Me.TXTID.SelectedText = ""
        Me.TXTID.Size = New System.Drawing.Size(152, 36)
        Me.TXTID.TabIndex = 4
        Me.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Payment"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.PANEL)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(546, 362)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'PANEL
        '
        Me.PANEL.BackColor = System.Drawing.Color.Transparent
        Me.PANEL.Controls.Add(Me.TXTDOWNPAYMENT)
        Me.PANEL.Controls.Add(Me.TXTREF)
        Me.PANEL.Controls.Add(Me.TXTPACKAGE)
        Me.PANEL.Controls.Add(Me.TXTCNAME)
        Me.PANEL.Controls.Add(Me.BTNCANCEL)
        Me.PANEL.Controls.Add(Me.BTNUPDATE)
        Me.PANEL.Controls.Add(Me.TXTCLIENTNO)
        Me.PANEL.Controls.Add(Me.BTNSAVE)
        Me.PANEL.Controls.Add(Me.TXTDATE)
        Me.PANEL.Controls.Add(Me.TXTAMOUNT)
        Me.PANEL.FillColor = System.Drawing.Color.White
        Me.PANEL.Location = New System.Drawing.Point(34, 70)
        Me.PANEL.Name = "PANEL"
        Me.PANEL.Radius = 10
        Me.PANEL.ShadowColor = System.Drawing.Color.White
        Me.PANEL.Size = New System.Drawing.Size(481, 271)
        Me.PANEL.TabIndex = 0
        '
        'TXTDOWNPAYMENT
        '
        Me.TXTDOWNPAYMENT.Animated = True
        Me.TXTDOWNPAYMENT.AutoRoundedCorners = True
        Me.TXTDOWNPAYMENT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDOWNPAYMENT.BorderRadius = 17
        Me.TXTDOWNPAYMENT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDOWNPAYMENT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDOWNPAYMENT.DefaultText = ""
        Me.TXTDOWNPAYMENT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTDOWNPAYMENT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTDOWNPAYMENT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDOWNPAYMENT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDOWNPAYMENT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDOWNPAYMENT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTDOWNPAYMENT.ForeColor = System.Drawing.Color.Black
        Me.TXTDOWNPAYMENT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDOWNPAYMENT.Location = New System.Drawing.Point(243, 146)
        Me.TXTDOWNPAYMENT.Name = "TXTDOWNPAYMENT"
        Me.TXTDOWNPAYMENT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDOWNPAYMENT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDOWNPAYMENT.PlaceholderText = "Downpayment"
        Me.TXTDOWNPAYMENT.SelectedText = ""
        Me.TXTDOWNPAYMENT.Size = New System.Drawing.Size(205, 36)
        Me.TXTDOWNPAYMENT.TabIndex = 24
        Me.TXTDOWNPAYMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTREF
        '
        Me.TXTREF.Animated = True
        Me.TXTREF.AutoRoundedCorners = True
        Me.TXTREF.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTREF.BorderRadius = 17
        Me.TXTREF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTREF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTREF.DefaultText = ""
        Me.TXTREF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTREF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTREF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTREF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTREF.ForeColor = System.Drawing.Color.Black
        Me.TXTREF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREF.Location = New System.Drawing.Point(32, 146)
        Me.TXTREF.Name = "TXTREF"
        Me.TXTREF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTREF.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTREF.PlaceholderText = "Reference No."
        Me.TXTREF.SelectedText = ""
        Me.TXTREF.Size = New System.Drawing.Size(205, 36)
        Me.TXTREF.TabIndex = 23
        Me.TXTREF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTPACKAGE
        '
        Me.TXTPACKAGE.Animated = True
        Me.TXTPACKAGE.AutoRoundedCorners = True
        Me.TXTPACKAGE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPACKAGE.BorderRadius = 17
        Me.TXTPACKAGE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPACKAGE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPACKAGE.DefaultText = ""
        Me.TXTPACKAGE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPACKAGE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPACKAGE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPACKAGE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPACKAGE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPACKAGE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTPACKAGE.ForeColor = System.Drawing.Color.Black
        Me.TXTPACKAGE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPACKAGE.Location = New System.Drawing.Point(32, 104)
        Me.TXTPACKAGE.Name = "TXTPACKAGE"
        Me.TXTPACKAGE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPACKAGE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPACKAGE.PlaceholderText = "Package Name"
        Me.TXTPACKAGE.SelectedText = ""
        Me.TXTPACKAGE.Size = New System.Drawing.Size(204, 36)
        Me.TXTPACKAGE.TabIndex = 22
        Me.TXTPACKAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCNAME
        '
        Me.TXTCNAME.AutoRoundedCorners = True
        Me.TXTCNAME.BackColor = System.Drawing.Color.Transparent
        Me.TXTCNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCNAME.BorderRadius = 17
        Me.TXTCNAME.DisplayMember = "Client Name"
        Me.TXTCNAME.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTCNAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXTCNAME.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCNAME.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCNAME.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTCNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTCNAME.ItemHeight = 30
        Me.TXTCNAME.Location = New System.Drawing.Point(32, 62)
        Me.TXTCNAME.Name = "TXTCNAME"
        Me.TXTCNAME.Size = New System.Drawing.Size(414, 36)
        Me.TXTCNAME.TabIndex = 21
        Me.TXTCNAME.Tag = "Client Name"
        Me.TXTCNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTCNAME.ValueMember = "Client Name"
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(243, 198)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(149, 45)
        Me.BTNCANCEL.TabIndex = 16
        Me.BTNCANCEL.Text = "Cancel"
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
        Me.BTNUPDATE.Location = New System.Drawing.Point(77, 198)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(149, 45)
        Me.BTNUPDATE.TabIndex = 15
        Me.BTNUPDATE.Text = "Update"
        '
        'TXTCLIENTNO
        '
        Me.TXTCLIENTNO.Animated = True
        Me.TXTCLIENTNO.AutoRoundedCorners = True
        Me.TXTCLIENTNO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCLIENTNO.BorderRadius = 17
        Me.TXTCLIENTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCLIENTNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCLIENTNO.DefaultText = ""
        Me.TXTCLIENTNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCLIENTNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCLIENTNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCLIENTNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCLIENTNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCLIENTNO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTCLIENTNO.ForeColor = System.Drawing.Color.Black
        Me.TXTCLIENTNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCLIENTNO.Location = New System.Drawing.Point(32, 20)
        Me.TXTCLIENTNO.Name = "TXTCLIENTNO"
        Me.TXTCLIENTNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCLIENTNO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCLIENTNO.PlaceholderText = "Client No"
        Me.TXTCLIENTNO.SelectedText = ""
        Me.TXTCLIENTNO.Size = New System.Drawing.Size(202, 36)
        Me.TXTCLIENTNO.TabIndex = 14
        Me.TXTCLIENTNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTNSAVE.Location = New System.Drawing.Point(77, 198)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(149, 45)
        Me.BTNSAVE.TabIndex = 9
        Me.BTNSAVE.Text = "Save"
        '
        'TXTDATE
        '
        Me.TXTDATE.AutoRoundedCorners = True
        Me.TXTDATE.BorderRadius = 17
        Me.TXTDATE.Checked = True
        Me.TXTDATE.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTDATE.ForeColor = System.Drawing.Color.White
        Me.TXTDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.TXTDATE.Location = New System.Drawing.Point(240, 20)
        Me.TXTDATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TXTDATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(204, 36)
        Me.TXTDATE.TabIndex = 12
        Me.TXTDATE.Value = New Date(2023, 7, 4, 23, 48, 57, 3)
        '
        'TXTAMOUNT
        '
        Me.TXTAMOUNT.Animated = True
        Me.TXTAMOUNT.AutoRoundedCorners = True
        Me.TXTAMOUNT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTAMOUNT.BorderRadius = 17
        Me.TXTAMOUNT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTAMOUNT.DefaultText = ""
        Me.TXTAMOUNT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTAMOUNT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTAMOUNT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAMOUNT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAMOUNT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAMOUNT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTAMOUNT.ForeColor = System.Drawing.Color.Black
        Me.TXTAMOUNT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAMOUNT.Location = New System.Drawing.Point(242, 104)
        Me.TXTAMOUNT.Name = "TXTAMOUNT"
        Me.TXTAMOUNT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTAMOUNT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTAMOUNT.PlaceholderText = "Amount"
        Me.TXTAMOUNT.SelectedText = ""
        Me.TXTAMOUNT.Size = New System.Drawing.Size(204, 36)
        Me.TXTAMOUNT.TabIndex = 11
        Me.TXTAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNHIDE
        '
        Me.BTNHIDE.BackColor = System.Drawing.Color.Transparent
        Me.BTNHIDE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNHIDE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNHIDE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNHIDE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNHIDE.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTNHIDE.FillColor = System.Drawing.Color.Transparent
        Me.BTNHIDE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNHIDE.ForeColor = System.Drawing.Color.White
        Me.BTNHIDE.Image = CType(resources.GetObject("BTNHIDE.Image"), System.Drawing.Image)
        Me.BTNHIDE.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNHIDE.Location = New System.Drawing.Point(492, 0)
        Me.BTNHIDE.Name = "BTNHIDE"
        Me.BTNHIDE.Size = New System.Drawing.Size(54, 64)
        Me.BTNHIDE.TabIndex = 5
        '
        'FRMADDPAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 362)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDPAYMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMADDPAYMENT"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PANEL As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTNCANCEL As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNUPDATE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTCLIENTNO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSAVE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTDATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TXTAMOUNT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTCNAME As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTREF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTPACKAGE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTDOWNPAYMENT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNHIDE As Guna.UI2.WinForms.Guna2Button
End Class
