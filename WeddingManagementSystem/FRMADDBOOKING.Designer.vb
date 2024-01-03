<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMADDBOOKING
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
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.plan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNCONFIRM = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.wed_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTNUPDATE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.date_in = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.time_in = New Guna.UI2.WinForms.Guna2TextBox()
        Me.contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.book_no = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bride = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNCAN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNSAVE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pac = New Guna.UI2.WinForms.Guna2TextBox()
        Me.groom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.plan)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNCONFIRM)
        Me.Guna2ShadowPanel1.Controls.Add(Me.wed_date)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNUPDATE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.contact)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.book_no)
        Me.Guna2ShadowPanel1.Controls.Add(Me.bride)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNCAN)
        Me.Guna2ShadowPanel1.Controls.Add(Me.email)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNSAVE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pac)
        Me.Guna2ShadowPanel1.Controls.Add(Me.groom)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(25, 65)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(546, 371)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'plan
        '
        Me.plan.AutoRoundedCorners = True
        Me.plan.BackColor = System.Drawing.Color.Transparent
        Me.plan.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.plan.BorderRadius = 17
        Me.plan.DisplayMember = "Client Name"
        Me.plan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.plan.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.plan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.plan.ForeColor = System.Drawing.Color.Black
        Me.plan.ItemHeight = 30
        Me.plan.Location = New System.Drawing.Point(30, 177)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(281, 36)
        Me.plan.TabIndex = 45
        Me.plan.Tag = "Client Name"
        Me.plan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.plan.ValueMember = "Client Name"
        '
        'BTNCONFIRM
        '
        Me.BTNCONFIRM.Animated = True
        Me.BTNCONFIRM.AutoRoundedCorners = True
        Me.BTNCONFIRM.BackColor = System.Drawing.Color.Transparent
        Me.BTNCONFIRM.BorderRadius = 21
        Me.BTNCONFIRM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCONFIRM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCONFIRM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCONFIRM.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCONFIRM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCONFIRM.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNCONFIRM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCONFIRM.ForeColor = System.Drawing.Color.White
        Me.BTNCONFIRM.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCONFIRM.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BTNCONFIRM.Location = New System.Drawing.Point(111, 273)
        Me.BTNCONFIRM.Name = "BTNCONFIRM"
        Me.BTNCONFIRM.Size = New System.Drawing.Size(149, 45)
        Me.BTNCONFIRM.TabIndex = 44
        Me.BTNCONFIRM.Text = "Confirm"
        '
        'wed_date
        '
        Me.wed_date.AutoRoundedCorners = True
        Me.wed_date.BorderRadius = 17
        Me.wed_date.Checked = True
        Me.wed_date.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.wed_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.wed_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.wed_date.Location = New System.Drawing.Point(148, 219)
        Me.wed_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.wed_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.wed_date.Name = "wed_date"
        Me.wed_date.Size = New System.Drawing.Size(362, 36)
        Me.wed_date.TabIndex = 43
        Me.wed_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.wed_date.Value = New Date(2023, 7, 4, 23, 48, 57, 3)
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
        Me.BTNUPDATE.Location = New System.Drawing.Point(111, 273)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(149, 45)
        Me.BTNUPDATE.TabIndex = 31
        Me.BTNUPDATE.Text = "Update"
        '
        'date_in
        '
        Me.date_in.AutoRoundedCorners = True
        Me.date_in.BorderRadius = 17
        Me.date_in.Checked = True
        Me.date_in.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.date_in.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_in.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.date_in.Location = New System.Drawing.Point(442, 23)
        Me.date_in.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.date_in.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.date_in.Name = "date_in"
        Me.date_in.Size = New System.Drawing.Size(40, 36)
        Me.date_in.TabIndex = 42
        Me.date_in.Value = New Date(2023, 7, 4, 23, 48, 57, 3)
        Me.date_in.Visible = False
        '
        'time_in
        '
        Me.time_in.AcceptsTab = True
        Me.time_in.Animated = True
        Me.time_in.AutoRoundedCorners = True
        Me.time_in.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.time_in.BorderRadius = 17
        Me.time_in.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.time_in.DefaultText = ""
        Me.time_in.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.time_in.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.time_in.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.time_in.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.time_in.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.time_in.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.time_in.ForeColor = System.Drawing.Color.Black
        Me.time_in.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.time_in.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.time_in.Location = New System.Drawing.Point(378, 23)
        Me.time_in.Name = "time_in"
        Me.time_in.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.time_in.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.time_in.PlaceholderText = "Time"
        Me.time_in.SelectedText = ""
        Me.time_in.Size = New System.Drawing.Size(40, 36)
        Me.time_in.TabIndex = 41
        Me.time_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.time_in.Visible = False
        '
        'contact
        '
        Me.contact.Animated = True
        Me.contact.AutoRoundedCorners = True
        Me.contact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.contact.BorderRadius = 17
        Me.contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contact.DefaultText = ""
        Me.contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contact.ForeColor = System.Drawing.Color.Black
        Me.contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contact.Location = New System.Drawing.Point(317, 135)
        Me.contact.Name = "contact"
        Me.contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contact.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.contact.PlaceholderText = "Contact Number"
        Me.contact.SelectedText = ""
        Me.contact.Size = New System.Drawing.Size(194, 36)
        Me.contact.TabIndex = 36
        Me.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Information"
        '
        'book_no
        '
        Me.book_no.Animated = True
        Me.book_no.AutoRoundedCorners = True
        Me.book_no.BackColor = System.Drawing.Color.Transparent
        Me.book_no.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.book_no.BorderRadius = 17
        Me.book_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.book_no.DefaultText = ""
        Me.book_no.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.book_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.book_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.book_no.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.book_no.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.book_no.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.book_no.ForeColor = System.Drawing.Color.Black
        Me.book_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.book_no.Location = New System.Drawing.Point(120, 9)
        Me.book_no.Name = "book_no"
        Me.book_no.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.book_no.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.book_no.PlaceholderText = "Book No."
        Me.book_no.SelectedText = ""
        Me.book_no.Size = New System.Drawing.Size(191, 36)
        Me.book_no.TabIndex = 23
        Me.book_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.book_no.Visible = False
        '
        'bride
        '
        Me.bride.Animated = True
        Me.bride.AutoRoundedCorners = True
        Me.bride.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bride.BorderRadius = 17
        Me.bride.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bride.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bride.DefaultText = ""
        Me.bride.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bride.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bride.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bride.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bride.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bride.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bride.ForeColor = System.Drawing.Color.Black
        Me.bride.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bride.Location = New System.Drawing.Point(31, 93)
        Me.bride.Name = "bride"
        Me.bride.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bride.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bride.PlaceholderText = "Bride's Name"
        Me.bride.SelectedText = ""
        Me.bride.Size = New System.Drawing.Size(480, 36)
        Me.bride.TabIndex = 33
        Me.bride.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTNCAN.Location = New System.Drawing.Point(266, 273)
        Me.BTNCAN.Name = "BTNCAN"
        Me.BTNCAN.Size = New System.Drawing.Size(149, 45)
        Me.BTNCAN.TabIndex = 32
        Me.BTNCAN.Text = "Cancel"
        '
        'email
        '
        Me.email.Animated = True
        Me.email.AutoRoundedCorners = True
        Me.email.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.email.BorderRadius = 17
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.DefaultText = ""
        Me.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(31, 135)
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.email.PlaceholderText = "Email"
        Me.email.SelectedText = ""
        Me.email.Size = New System.Drawing.Size(280, 36)
        Me.email.TabIndex = 28
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTNSAVE.Location = New System.Drawing.Point(111, 273)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(149, 45)
        Me.BTNSAVE.TabIndex = 24
        Me.BTNSAVE.Text = "Save"
        '
        'pac
        '
        Me.pac.Animated = True
        Me.pac.AutoRoundedCorners = True
        Me.pac.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pac.BorderRadius = 17
        Me.pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pac.DefaultText = ""
        Me.pac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pac.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pac.ForeColor = System.Drawing.Color.Black
        Me.pac.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pac.Location = New System.Drawing.Point(316, 177)
        Me.pac.Name = "pac"
        Me.pac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pac.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pac.PlaceholderText = "Package"
        Me.pac.SelectedText = ""
        Me.pac.Size = New System.Drawing.Size(194, 36)
        Me.pac.TabIndex = 26
        Me.pac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groom
        '
        Me.groom.Animated = True
        Me.groom.AutoRoundedCorners = True
        Me.groom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.groom.BorderRadius = 17
        Me.groom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.groom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.groom.DefaultText = ""
        Me.groom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.groom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.groom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.groom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.groom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.groom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.groom.ForeColor = System.Drawing.Color.Black
        Me.groom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.groom.Location = New System.Drawing.Point(30, 51)
        Me.groom.Name = "groom"
        Me.groom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.groom.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.groom.PlaceholderText = "Groom's Name"
        Me.groom.SelectedText = ""
        Me.groom.Size = New System.Drawing.Size(480, 36)
        Me.groom.TabIndex = 25
        Me.groom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bookings Information"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.AutoSize = True
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.date_in)
        Me.Guna2GradientPanel1.Controls.Add(Me.time_in)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(619, 463)
        Me.Guna2GradientPanel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Wedding Date:"
        '
        'FRMADDBOOKING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 463)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDBOOKING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMADDBOOKING"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bride As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNCAN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNUPDATE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSAVE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pac As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents groom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents book_no As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents wed_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents date_in As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents time_in As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNCONFIRM As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents plan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
End Class
