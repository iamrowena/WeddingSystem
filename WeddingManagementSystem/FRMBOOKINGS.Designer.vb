<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMBOOKINGS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMBOOKINGS))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BOOKINGS = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TABBOOKINGS = New System.Windows.Forms.TabPage()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDITB = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DELETEB = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CONFIRM = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VIEWB = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2CircleButton4 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TABCLIENTINFO = New System.Windows.Forms.TabPage()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.client_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bride = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.package = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wed_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDITC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DELETEC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VIEWC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TXTSEARCHCLIENT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNLOGOUT = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTNADDPACK = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CANCEL = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKINGS.SuspendLayout()
        Me.TABBOOKINGS.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TABCLIENTINFO.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BOOKINGS
        '
        Me.BOOKINGS.Controls.Add(Me.TABBOOKINGS)
        Me.BOOKINGS.Controls.Add(Me.TABCLIENTINFO)
        Me.BOOKINGS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BOOKINGS.ItemSize = New System.Drawing.Size(422, 40)
        Me.BOOKINGS.Location = New System.Drawing.Point(0, 64)
        Me.BOOKINGS.Name = "BOOKINGS"
        Me.BOOKINGS.SelectedIndex = 0
        Me.BOOKINGS.Size = New System.Drawing.Size(850, 579)
        Me.BOOKINGS.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BOOKINGS.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BOOKINGS.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.BOOKINGS.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BOOKINGS.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BOOKINGS.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BOOKINGS.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BOOKINGS.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.BOOKINGS.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.BOOKINGS.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BOOKINGS.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BOOKINGS.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BOOKINGS.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.BOOKINGS.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.BOOKINGS.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BOOKINGS.TabButtonSize = New System.Drawing.Size(422, 40)
        Me.BOOKINGS.TabIndex = 3
        Me.BOOKINGS.TabMenuBackColor = System.Drawing.Color.Transparent
        Me.BOOKINGS.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TABBOOKINGS
        '
        Me.TABBOOKINGS.Controls.Add(Me.Guna2Panel1)
        Me.TABBOOKINGS.Location = New System.Drawing.Point(4, 44)
        Me.TABBOOKINGS.Name = "TABBOOKINGS"
        Me.TABBOOKINGS.Padding = New System.Windows.Forms.Padding(3)
        Me.TABBOOKINGS.Size = New System.Drawing.Size(842, 531)
        Me.TABBOOKINGS.TabIndex = 0
        Me.TABBOOKINGS.Text = "BOOKING LIST"
        Me.TABBOOKINGS.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(836, 525)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(836, 478)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.ColumnHeadersHeight = 31
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.EDITB, Me.DELETEB, Me.CONFIRM, Me.VIEWB})
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(-3, 0)
        Me.DataGridView3.Name = "DataGridView3"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(842, 479)
        Me.DataGridView3.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Book no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Groom's Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bride's Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 57
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 69
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Planner"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Package"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 73
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 55
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 55
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Wedding Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 91
        '
        'EDITB
        '
        Me.EDITB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDITB.HeaderText = ""
        Me.EDITB.Image = Global.WeddingManagementSystem.My.Resources.Resources.edit1
        Me.EDITB.Name = "EDITB"
        Me.EDITB.Width = 5
        '
        'DELETEB
        '
        Me.DELETEB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DELETEB.HeaderText = ""
        Me.DELETEB.Image = CType(resources.GetObject("DELETEB.Image"), System.Drawing.Image)
        Me.DELETEB.Name = "DELETEB"
        Me.DELETEB.Width = 5
        '
        'CONFIRM
        '
        Me.CONFIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CONFIRM.HeaderText = ""
        Me.CONFIRM.Image = CType(resources.GetObject("CONFIRM.Image"), System.Drawing.Image)
        Me.CONFIRM.Name = "CONFIRM"
        Me.CONFIRM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CONFIRM.Width = 5
        '
        'VIEWB
        '
        Me.VIEWB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        Me.VIEWB.DefaultCellStyle = DataGridViewCellStyle3
        Me.VIEWB.HeaderText = ""
        Me.VIEWB.Image = CType(resources.GetObject("VIEWB.Image"), System.Drawing.Image)
        Me.VIEWB.Name = "VIEWB"
        Me.VIEWB.Width = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2CircleButton4)
        Me.Panel1.Controls.Add(Me.TXTSEARCH)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 47)
        Me.Panel1.TabIndex = 0
        '
        'Guna2CircleButton4
        '
        Me.Guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2CircleButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CircleButton4.Image = CType(resources.GetObject("Guna2CircleButton4.Image"), System.Drawing.Image)
        Me.Guna2CircleButton4.Location = New System.Drawing.Point(263, 5)
        Me.Guna2CircleButton4.Name = "Guna2CircleButton4"
        Me.Guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton4.Size = New System.Drawing.Size(43, 36)
        Me.Guna2CircleButton4.TabIndex = 8
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Animated = True
        Me.TXTSEARCH.AutoRoundedCorners = True
        Me.TXTSEARCH.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCH.BorderRadius = 17
        Me.TXTSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.DefaultText = ""
        Me.TXTSEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.Location = New System.Drawing.Point(20, 5)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCH.PlaceholderText = "Search No."
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.Size = New System.Drawing.Size(237, 36)
        Me.TXTSEARCH.TabIndex = 6
        Me.TXTSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TABCLIENTINFO
        '
        Me.TABCLIENTINFO.Controls.Add(Me.Guna2Panel2)
        Me.TABCLIENTINFO.Location = New System.Drawing.Point(4, 44)
        Me.TABCLIENTINFO.Name = "TABCLIENTINFO"
        Me.TABCLIENTINFO.Padding = New System.Windows.Forms.Padding(3)
        Me.TABCLIENTINFO.Size = New System.Drawing.Size(842, 531)
        Me.TABCLIENTINFO.TabIndex = 1
        Me.TABCLIENTINFO.Text = "CLIENT INFORMATION"
        Me.TABCLIENTINFO.UseVisualStyleBackColor = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel2.Controls.Add(Me.TXTSEARCHCLIENT)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(850, 528)
        Me.Guna2Panel2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 31
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.client_no, Me.bride, Me.emailc, Me.contact, Me.planner, Me.package, Me.datec, Me.timec, Me.wed_date, Me.EDITC, Me.DELETEC, Me.VIEWC})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 48)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(842, 475)
        Me.DataGridView1.TabIndex = 8
        '
        'client_no
        '
        Me.client_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.client_no.FillWeight = 50.0!
        Me.client_no.HeaderText = "Client No."
        Me.client_no.Name = "client_no"
        '
        'bride
        '
        Me.bride.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bride.FillWeight = 150.0!
        Me.bride.HeaderText = "Client's Name"
        Me.bride.Name = "bride"
        '
        'emailc
        '
        Me.emailc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.emailc.HeaderText = "Email"
        Me.emailc.Name = "emailc"
        Me.emailc.Visible = False
        Me.emailc.Width = 57
        '
        'contact
        '
        Me.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.contact.HeaderText = "Contact"
        Me.contact.Name = "contact"
        Me.contact.Visible = False
        Me.contact.Width = 69
        '
        'planner
        '
        Me.planner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.planner.FillWeight = 150.0!
        Me.planner.HeaderText = "Planner"
        Me.planner.Name = "planner"
        Me.planner.Width = 66
        '
        'package
        '
        Me.package.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.package.HeaderText = "Package"
        Me.package.Name = "package"
        Me.package.Width = 73
        '
        'datec
        '
        Me.datec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.datec.HeaderText = "Date"
        Me.datec.Name = "datec"
        Me.datec.Visible = False
        Me.datec.Width = 55
        '
        'timec
        '
        Me.timec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.timec.HeaderText = "Time"
        Me.timec.Name = "timec"
        Me.timec.Visible = False
        Me.timec.Width = 55
        '
        'wed_date
        '
        Me.wed_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wed_date.FillWeight = 150.0!
        Me.wed_date.HeaderText = "Wedding Date"
        Me.wed_date.Name = "wed_date"
        Me.wed_date.Width = 91
        '
        'EDITC
        '
        Me.EDITC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDITC.HeaderText = ""
        Me.EDITC.Image = Global.WeddingManagementSystem.My.Resources.Resources.edit1
        Me.EDITC.Name = "EDITC"
        Me.EDITC.Width = 5
        '
        'DELETEC
        '
        Me.DELETEC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DELETEC.HeaderText = ""
        Me.DELETEC.Image = CType(resources.GetObject("DELETEC.Image"), System.Drawing.Image)
        Me.DELETEC.Name = "DELETEC"
        Me.DELETEC.Width = 5
        '
        'VIEWC
        '
        Me.VIEWC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.NullValue = CType(resources.GetObject("DataGridViewCellStyle7.NullValue"), Object)
        Me.VIEWC.DefaultCellStyle = DataGridViewCellStyle7
        Me.VIEWC.HeaderText = ""
        Me.VIEWC.Image = CType(resources.GetObject("VIEWC.Image"), System.Drawing.Image)
        Me.VIEWC.Name = "VIEWC"
        Me.VIEWC.Width = 5
        '
        'TXTSEARCHCLIENT
        '
        Me.TXTSEARCHCLIENT.Animated = True
        Me.TXTSEARCHCLIENT.AutoRoundedCorners = True
        Me.TXTSEARCHCLIENT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCHCLIENT.BorderRadius = 17
        Me.TXTSEARCHCLIENT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCHCLIENT.DefaultText = ""
        Me.TXTSEARCHCLIENT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSEARCHCLIENT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSEARCHCLIENT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCHCLIENT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCHCLIENT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCHCLIENT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTSEARCHCLIENT.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCHCLIENT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCHCLIENT.Location = New System.Drawing.Point(24, 6)
        Me.TXTSEARCHCLIENT.Name = "TXTSEARCHCLIENT"
        Me.TXTSEARCHCLIENT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCHCLIENT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCHCLIENT.PlaceholderText = "Search"
        Me.TXTSEARCHCLIENT.SelectedText = ""
        Me.TXTSEARCHCLIENT.Size = New System.Drawing.Size(236, 36)
        Me.TXTSEARCHCLIENT.TabIndex = 0
        Me.TXTSEARCHCLIENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Booking List"
        '
        'BTNLOGOUT
        '
        Me.BTNLOGOUT.Animated = True
        Me.BTNLOGOUT.AutoRoundedCorners = True
        Me.BTNLOGOUT.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGOUT.BorderRadius = 21
        Me.BTNLOGOUT.CustomizableEdges.BottomRight = False
        Me.BTNLOGOUT.CustomizableEdges.TopRight = False
        Me.BTNLOGOUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGOUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNLOGOUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGOUT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLOGOUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLOGOUT.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNLOGOUT.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BTNLOGOUT.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGOUT.ForeColor = System.Drawing.Color.White
        Me.BTNLOGOUT.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOGOUT.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BTNLOGOUT.Image = CType(resources.GetObject("BTNLOGOUT.Image"), System.Drawing.Image)
        Me.BTNLOGOUT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNLOGOUT.ImageOffset = New System.Drawing.Point(5, 0)
        Me.BTNLOGOUT.Location = New System.Drawing.Point(732, 12)
        Me.BTNLOGOUT.Name = "BTNLOGOUT"
        Me.BTNLOGOUT.Size = New System.Drawing.Size(114, 45)
        Me.BTNLOGOUT.TabIndex = 16
        Me.BTNLOGOUT.Text = "Logout"
        Me.BTNLOGOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNLOGOUT.TextOffset = New System.Drawing.Point(15, 0)
        Me.BTNLOGOUT.UseTransparentBackground = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel1.Controls.Add(Me.BTNLOGOUT)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(850, 64)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 17
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(42, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2TextBox1.PlaceholderText = "Search"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(169, 36)
        Me.Guna2TextBox1.TabIndex = 0
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), System.Drawing.Image)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(217, 6)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(43, 36)
        Me.Guna2CircleButton1.TabIndex = 1
        '
        'BTNADDPACK
        '
        Me.BTNADDPACK.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDPACK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNADDPACK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNADDPACK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNADDPACK.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNADDPACK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNADDPACK.ForeColor = System.Drawing.Color.White
        Me.BTNADDPACK.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNADDPACK.Image = CType(resources.GetObject("BTNADDPACK.Image"), System.Drawing.Image)
        Me.BTNADDPACK.Location = New System.Drawing.Point(266, 6)
        Me.BTNADDPACK.Name = "BTNADDPACK"
        Me.BTNADDPACK.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNADDPACK.Size = New System.Drawing.Size(43, 36)
        Me.BTNADDPACK.TabIndex = 4
        '
        'CANCEL
        '
        Me.CANCEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANCEL.HeaderText = ""
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Text = "CANCEL"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Amount"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Package"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = "Booking No."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'FRMBOOKINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 643)
        Me.Controls.Add(Me.BOOKINGS)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMBOOKINGS"
        Me.Text = "FRMBOOKINGS"
        Me.BOOKINGS.ResumeLayout(False)
        Me.TABBOOKINGS.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TABCLIENTINFO.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BOOKINGS As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLOGOUT As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TABBOOKINGS As TabPage
    Friend WithEvents TABCLIENTINFO As TabPage
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTSEARCHCLIENT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTNADDPACK As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CANCEL As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2CircleButton4 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents EDITB As DataGridViewImageColumn
    Friend WithEvents DELETEB As DataGridViewImageColumn
    Friend WithEvents CONFIRM As DataGridViewImageColumn
    Friend WithEvents VIEWB As DataGridViewImageColumn
    Friend WithEvents client_no As DataGridViewTextBoxColumn
    Friend WithEvents bride As DataGridViewTextBoxColumn
    Friend WithEvents emailc As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents planner As DataGridViewTextBoxColumn
    Friend WithEvents package As DataGridViewTextBoxColumn
    Friend WithEvents datec As DataGridViewTextBoxColumn
    Friend WithEvents timec As DataGridViewTextBoxColumn
    Friend WithEvents wed_date As DataGridViewTextBoxColumn
    Friend WithEvents EDITC As DataGridViewImageColumn
    Friend WithEvents DELETEC As DataGridViewImageColumn
    Friend WithEvents VIEWC As DataGridViewImageColumn
End Class
