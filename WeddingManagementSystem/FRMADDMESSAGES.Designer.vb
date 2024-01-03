<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMADDMESSAGES
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMADDMESSAGES))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TXTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTDATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TXTNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNCONTACT = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTNCANCEL = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNSEND = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXTMESSAGES = New System.Windows.Forms.RichTextBox()
        Me.TXTSUBJECT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTCONTACT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(617, 470)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.TXTID)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.TXTDATE)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(617, 64)
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
        Me.TXTID.Location = New System.Drawing.Point(486, 23)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TXTID.PlaceholderText = "ID"
        Me.TXTID.SelectedText = ""
        Me.TXTID.Size = New System.Drawing.Size(111, 36)
        Me.TXTID.TabIndex = 5
        Me.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Messages"
        '
        'TXTDATE
        '
        Me.TXTDATE.Checked = True
        Me.TXTDATE.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTDATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTDATE.ForeColor = System.Drawing.Color.White
        Me.TXTDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.TXTDATE.Location = New System.Drawing.Point(448, 23)
        Me.TXTDATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TXTDATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(32, 36)
        Me.TXTDATE.TabIndex = 12
        Me.TXTDATE.Value = New Date(2023, 7, 4, 23, 48, 57, 3)
        Me.TXTDATE.Visible = False
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTNAME)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNCONTACT)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNCANCEL)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNSEND)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTSUBJECT)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TXTCONTACT)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(25, 65)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(572, 377)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'TXTNAME
        '
        Me.TXTNAME.Animated = True
        Me.TXTNAME.AutoRoundedCorners = True
        Me.TXTNAME.AutoSize = True
        Me.TXTNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTNAME.BorderRadius = 17
        Me.TXTNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNAME.DefaultText = ""
        Me.TXTNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNAME.Location = New System.Drawing.Point(60, 26)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNAME.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTNAME.PlaceholderText = "Name"
        Me.TXTNAME.SelectedText = ""
        Me.TXTNAME.Size = New System.Drawing.Size(404, 36)
        Me.TXTNAME.TabIndex = 16
        Me.TXTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNCONTACT
        '
        Me.BTNCONTACT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCONTACT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCONTACT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCONTACT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCONTACT.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNCONTACT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCONTACT.ForeColor = System.Drawing.Color.White
        Me.BTNCONTACT.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCONTACT.Image = CType(resources.GetObject("BTNCONTACT.Image"), System.Drawing.Image)
        Me.BTNCONTACT.Location = New System.Drawing.Point(470, 26)
        Me.BTNCONTACT.Name = "BTNCONTACT"
        Me.BTNCONTACT.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNCONTACT.Size = New System.Drawing.Size(43, 36)
        Me.BTNCONTACT.TabIndex = 15
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(283, 316)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(149, 45)
        Me.BTNCANCEL.TabIndex = 14
        Me.BTNCANCEL.Text = "Cancel"
        '
        'BTNSEND
        '
        Me.BTNSEND.Animated = True
        Me.BTNSEND.AutoRoundedCorners = True
        Me.BTNSEND.BackColor = System.Drawing.Color.Transparent
        Me.BTNSEND.BorderRadius = 21
        Me.BTNSEND.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNSEND.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNSEND.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSEND.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSEND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSEND.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNSEND.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSEND.ForeColor = System.Drawing.Color.White
        Me.BTNSEND.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSEND.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNSEND.Location = New System.Drawing.Point(128, 316)
        Me.BTNSEND.Name = "BTNSEND"
        Me.BTNSEND.Size = New System.Drawing.Size(149, 45)
        Me.BTNSEND.TabIndex = 9
        Me.BTNSEND.Text = "Send"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.TXTMESSAGES)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(14, 110)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(543, 200)
        Me.Guna2GroupBox1.TabIndex = 13
        Me.Guna2GroupBox1.Text = "Message"
        '
        'TXTMESSAGES
        '
        Me.TXTMESSAGES.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTMESSAGES.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMESSAGES.Location = New System.Drawing.Point(10, 43)
        Me.TXTMESSAGES.Name = "TXTMESSAGES"
        Me.TXTMESSAGES.Size = New System.Drawing.Size(530, 144)
        Me.TXTMESSAGES.TabIndex = 1
        Me.TXTMESSAGES.Text = ""
        '
        'TXTSUBJECT
        '
        Me.TXTSUBJECT.Animated = True
        Me.TXTSUBJECT.AutoRoundedCorners = True
        Me.TXTSUBJECT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSUBJECT.BorderRadius = 17
        Me.TXTSUBJECT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSUBJECT.DefaultText = ""
        Me.TXTSUBJECT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSUBJECT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSUBJECT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSUBJECT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSUBJECT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSUBJECT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTSUBJECT.ForeColor = System.Drawing.Color.Black
        Me.TXTSUBJECT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSUBJECT.Location = New System.Drawing.Point(274, 68)
        Me.TXTSUBJECT.Name = "TXTSUBJECT"
        Me.TXTSUBJECT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSUBJECT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSUBJECT.PlaceholderText = "Subject"
        Me.TXTSUBJECT.SelectedText = ""
        Me.TXTSUBJECT.Size = New System.Drawing.Size(239, 36)
        Me.TXTSUBJECT.TabIndex = 10
        Me.TXTSUBJECT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TXTCONTACT.Location = New System.Drawing.Point(60, 68)
        Me.TXTCONTACT.Name = "TXTCONTACT"
        Me.TXTCONTACT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCONTACT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTCONTACT.PlaceholderText = "Contact No."
        Me.TXTCONTACT.SelectedText = ""
        Me.TXTCONTACT.Size = New System.Drawing.Size(208, 36)
        Me.TXTCONTACT.TabIndex = 9
        Me.TXTCONTACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FRMADDMESSAGES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRMADDMESSAGES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TXTDATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TXTSUBJECT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTCONTACT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSEND As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTMESSAGES As RichTextBox
    Friend WithEvents BTNCANCEL As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNCONTACT As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TXTNAME As Guna.UI2.WinForms.Guna2TextBox
End Class
