<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMADDTASK
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PANEL = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TXTPACKAGE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTDETAILS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTSERVICES = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTCLIENTNO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTCNAME = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNCANCEL = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNUPDATE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNSAVE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.PANEL)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(618, 388)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.TXTID)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(618, 64)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'TXTID
        '
        Me.TXTID.BackColor = System.Drawing.Color.Transparent
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
        Me.TXTID.Location = New System.Drawing.Point(488, 18)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TXTID.PlaceholderText = ""
        Me.TXTID.SelectedText = ""
        Me.TXTID.Size = New System.Drawing.Size(27, 36)
        Me.TXTID.TabIndex = 4
        Me.TXTID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Task Management"
        '
        'PANEL
        '
        Me.PANEL.BackColor = System.Drawing.Color.Transparent
        Me.PANEL.Controls.Add(Me.TXTPACKAGE)
        Me.PANEL.Controls.Add(Me.TXTDETAILS)
        Me.PANEL.Controls.Add(Me.TXTSERVICES)
        Me.PANEL.Controls.Add(Me.TXTCLIENTNO)
        Me.PANEL.Controls.Add(Me.TXTCNAME)
        Me.PANEL.Controls.Add(Me.BTNCANCEL)
        Me.PANEL.Controls.Add(Me.BTNUPDATE)
        Me.PANEL.Controls.Add(Me.BTNSAVE)
        Me.PANEL.FillColor = System.Drawing.Color.White
        Me.PANEL.Location = New System.Drawing.Point(34, 70)
        Me.PANEL.Name = "PANEL"
        Me.PANEL.Radius = 10
        Me.PANEL.ShadowColor = System.Drawing.Color.White
        Me.PANEL.Size = New System.Drawing.Size(546, 282)
        Me.PANEL.TabIndex = 0
        '
        'TXTPACKAGE
        '
        Me.TXTPACKAGE.Animated = True
        Me.TXTPACKAGE.AutoRoundedCorners = True
        Me.TXTPACKAGE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPACKAGE.BorderRadius = 17
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
        Me.TXTPACKAGE.Location = New System.Drawing.Point(45, 108)
        Me.TXTPACKAGE.Name = "TXTPACKAGE"
        Me.TXTPACKAGE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPACKAGE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTPACKAGE.PlaceholderText = "Package"
        Me.TXTPACKAGE.SelectedText = ""
        Me.TXTPACKAGE.Size = New System.Drawing.Size(221, 36)
        Me.TXTPACKAGE.TabIndex = 43
        Me.TXTPACKAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTDETAILS
        '
        Me.TXTDETAILS.Animated = True
        Me.TXTDETAILS.AutoRoundedCorners = True
        Me.TXTDETAILS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDETAILS.BorderRadius = 17
        Me.TXTDETAILS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDETAILS.DefaultText = ""
        Me.TXTDETAILS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTDETAILS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTDETAILS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDETAILS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDETAILS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDETAILS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTDETAILS.ForeColor = System.Drawing.Color.Black
        Me.TXTDETAILS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDETAILS.Location = New System.Drawing.Point(45, 150)
        Me.TXTDETAILS.Name = "TXTDETAILS"
        Me.TXTDETAILS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDETAILS.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDETAILS.PlaceholderText = "Wedding Details"
        Me.TXTDETAILS.SelectedText = ""
        Me.TXTDETAILS.Size = New System.Drawing.Size(448, 36)
        Me.TXTDETAILS.TabIndex = 42
        Me.TXTDETAILS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTSERVICES
        '
        Me.TXTSERVICES.AutoRoundedCorners = True
        Me.TXTSERVICES.BackColor = System.Drawing.Color.Transparent
        Me.TXTSERVICES.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSERVICES.BorderRadius = 17
        Me.TXTSERVICES.DisplayMember = "Client Name"
        Me.TXTSERVICES.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TXTSERVICES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXTSERVICES.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSERVICES.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSERVICES.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSERVICES.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTSERVICES.ForeColor = System.Drawing.Color.Black
        Me.TXTSERVICES.ItemHeight = 30
        Me.TXTSERVICES.Location = New System.Drawing.Point(272, 108)
        Me.TXTSERVICES.Name = "TXTSERVICES"
        Me.TXTSERVICES.Size = New System.Drawing.Size(221, 36)
        Me.TXTSERVICES.TabIndex = 41
        Me.TXTSERVICES.Tag = "Client Name"
        Me.TXTSERVICES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTSERVICES.ValueMember = "Client Name"
        '
        'TXTCLIENTNO
        '
        Me.TXTCLIENTNO.Animated = True
        Me.TXTCLIENTNO.AutoRoundedCorners = True
        Me.TXTCLIENTNO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCLIENTNO.BorderRadius = 17
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
        Me.TXTCLIENTNO.Location = New System.Drawing.Point(45, 24)
        Me.TXTCLIENTNO.Name = "TXTCLIENTNO"
        Me.TXTCLIENTNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCLIENTNO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCLIENTNO.PlaceholderText = "Client No."
        Me.TXTCLIENTNO.SelectedText = ""
        Me.TXTCLIENTNO.Size = New System.Drawing.Size(221, 36)
        Me.TXTCLIENTNO.TabIndex = 21
        Me.TXTCLIENTNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TXTCNAME.Location = New System.Drawing.Point(45, 66)
        Me.TXTCNAME.Name = "TXTCNAME"
        Me.TXTCNAME.Size = New System.Drawing.Size(448, 36)
        Me.TXTCNAME.TabIndex = 20
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(281, 205)
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
        Me.BTNUPDATE.Location = New System.Drawing.Point(117, 205)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(149, 45)
        Me.BTNUPDATE.TabIndex = 15
        Me.BTNUPDATE.Text = "Update"
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
        Me.BTNSAVE.Location = New System.Drawing.Point(117, 205)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(149, 45)
        Me.BTNSAVE.TabIndex = 9
        Me.BTNSAVE.Text = "Save"
        '
        'FRMADDTASK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 388)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDTASK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMADDTASK"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.PANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PANEL As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTNCANCEL As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNUPDATE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNSAVE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTCLIENTNO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTCNAME As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTDETAILS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTSERVICES As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTPACKAGE As Guna.UI2.WinForms.Guna2TextBox
End Class
