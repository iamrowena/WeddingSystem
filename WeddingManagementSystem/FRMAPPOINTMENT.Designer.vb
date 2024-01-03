<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMAPPOINTMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMAPPOINTMENT))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BTNNEW = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTNLOGOUT = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTSEARCHDATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTNREFRESH = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDIT = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VIEW = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.BTNNEW)
        Me.Guna2GradientPanel1.Controls.Add(Me.BTNLOGOUT)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(854, 64)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'BTNNEW
        '
        Me.BTNNEW.BackColor = System.Drawing.Color.Transparent
        Me.BTNNEW.BorderColor = System.Drawing.Color.Transparent
        Me.BTNNEW.BorderThickness = 2
        Me.BTNNEW.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNNEW.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNNEW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNNEW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNNEW.FillColor = System.Drawing.Color.Empty
        Me.BTNNEW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNNEW.ForeColor = System.Drawing.Color.White
        Me.BTNNEW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNNEW.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNNEW.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BTNNEW.Image = CType(resources.GetObject("BTNNEW.Image"), System.Drawing.Image)
        Me.BTNNEW.Location = New System.Drawing.Point(680, 10)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNNEW.Size = New System.Drawing.Size(50, 45)
        Me.BTNNEW.TabIndex = 17
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
        Me.BTNLOGOUT.Location = New System.Drawing.Point(736, 10)
        Me.BTNLOGOUT.Name = "BTNLOGOUT"
        Me.BTNLOGOUT.Size = New System.Drawing.Size(114, 45)
        Me.BTNLOGOUT.TabIndex = 16
        Me.BTNLOGOUT.Text = "Logout"
        Me.BTNLOGOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNLOGOUT.TextOffset = New System.Drawing.Point(15, 0)
        Me.BTNLOGOUT.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Appointment List"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.TXTSEARCHDATE)
        Me.Guna2Panel1.Controls.Add(Me.BTNREFRESH)
        Me.Guna2Panel1.Controls.Add(Me.TXTSEARCH)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(854, 49)
        Me.Guna2Panel1.TabIndex = 1
        '
        'TXTSEARCHDATE
        '
        Me.TXTSEARCHDATE.AutoRoundedCorners = True
        Me.TXTSEARCHDATE.BorderRadius = 17
        Me.TXTSEARCHDATE.Checked = True
        Me.TXTSEARCHDATE.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCHDATE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCHDATE.ForeColor = System.Drawing.Color.White
        Me.TXTSEARCHDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.TXTSEARCHDATE.Location = New System.Drawing.Point(594, 7)
        Me.TXTSEARCHDATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TXTSEARCHDATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.TXTSEARCHDATE.Name = "TXTSEARCHDATE"
        Me.TXTSEARCHDATE.Size = New System.Drawing.Size(207, 36)
        Me.TXTSEARCHDATE.TabIndex = 13
        Me.TXTSEARCHDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTSEARCHDATE.Value = New Date(2023, 7, 4, 23, 48, 57, 3)
        '
        'BTNREFRESH
        '
        Me.BTNREFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNREFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNREFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNREFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNREFRESH.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BTNREFRESH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNREFRESH.ForeColor = System.Drawing.Color.White
        Me.BTNREFRESH.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNREFRESH.Image = CType(resources.GetObject("BTNREFRESH.Image"), System.Drawing.Image)
        Me.BTNREFRESH.Location = New System.Drawing.Point(807, 7)
        Me.BTNREFRESH.Name = "BTNREFRESH"
        Me.BTNREFRESH.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNREFRESH.Size = New System.Drawing.Size(43, 36)
        Me.BTNREFRESH.TabIndex = 5
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
        Me.TXTSEARCH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.Location = New System.Drawing.Point(12, 7)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TXTSEARCH.PlaceholderText = "Search Client No."
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.Size = New System.Drawing.Size(213, 36)
        Me.TXTSEARCH.TabIndex = 0
        Me.TXTSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 445)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 31
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.EDIT, Me.DELETE, Me.VIEW})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(854, 445)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Cllient No"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Contact"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Date"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 54
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Time"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 54
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Subject"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 68
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Description"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'EDIT
        '
        Me.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDIT.HeaderText = ""
        Me.EDIT.Image = Global.WeddingManagementSystem.My.Resources.Resources.edit1
        Me.EDIT.Name = "EDIT"
        Me.EDIT.Width = 5
        '
        'DELETE
        '
        Me.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DELETE.HeaderText = ""
        Me.DELETE.Image = Global.WeddingManagementSystem.My.Resources.Resources.trash
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Width = 5
        '
        'VIEW
        '
        Me.VIEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VIEW.HeaderText = ""
        Me.VIEW.Image = Global.WeddingManagementSystem.My.Resources.Resources.eye__1_
        Me.VIEW.Name = "VIEW"
        Me.VIEW.Width = 5
        '
        'FRMAPPOINTMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMAPPOINTMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLOGOUT As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Public WithEvents BTNNEW As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTNREFRESH As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TXTSEARCHDATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents EDIT As DataGridViewImageColumn
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents VIEW As DataGridViewImageColumn
End Class
