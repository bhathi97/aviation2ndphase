<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlAF
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImportExcell = New FontAwesome.Sharp.IconButton()
        Me.btnRefreshDataGrid = New FontAwesome.Sharp.IconButton()
        Me.lblAddNewAC = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDeleteFlight = New FontAwesome.Sharp.IconButton()
        Me.btnUpdateFlight = New FontAwesome.Sharp.IconButton()
        Me.btnSaveFlight = New FontAwesome.Sharp.IconButton()
        Me.dpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbDT = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbStd1 = New System.Windows.Forms.ComboBox()
        Me.cbStd = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAName = New System.Windows.Forms.Label()
        Me.cbairlinecategory = New System.Windows.Forms.ComboBox()
        Me.tbflightNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvFlight = New System.Windows.Forms.DataGridView()
        Me.fid1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dipart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.fid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fno1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dipart1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eta1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvFlight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btnImportExcell)
        Me.Panel1.Controls.Add(Me.btnRefreshDataGrid)
        Me.Panel1.Controls.Add(Me.lblAddNewAC)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnDeleteFlight)
        Me.Panel1.Controls.Add(Me.btnUpdateFlight)
        Me.Panel1.Controls.Add(Me.btnSaveFlight)
        Me.Panel1.Controls.Add(Me.dpDate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbDT)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbStd1)
        Me.Panel1.Controls.Add(Me.cbStd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblAName)
        Me.Panel1.Controls.Add(Me.cbairlinecategory)
        Me.Panel1.Controls.Add(Me.tbflightNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 531)
        Me.Panel1.TabIndex = 0
        '
        'btnImportExcell
        '
        Me.btnImportExcell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnImportExcell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportExcell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImportExcell.FlatAppearance.BorderSize = 0
        Me.btnImportExcell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnImportExcell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnImportExcell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportExcell.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnImportExcell.ForeColor = System.Drawing.Color.White
        Me.btnImportExcell.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btnImportExcell.IconColor = System.Drawing.Color.White
        Me.btnImportExcell.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnImportExcell.IconSize = 18
        Me.btnImportExcell.Location = New System.Drawing.Point(99, 377)
        Me.btnImportExcell.Name = "btnImportExcell"
        Me.btnImportExcell.Size = New System.Drawing.Size(150, 35)
        Me.btnImportExcell.TabIndex = 24
        Me.btnImportExcell.Text = "EXCEL"
        Me.btnImportExcell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportExcell.UseVisualStyleBackColor = False
        '
        'btnRefreshDataGrid
        '
        Me.btnRefreshDataGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRefreshDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshDataGrid.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRefreshDataGrid.FlatAppearance.BorderSize = 0
        Me.btnRefreshDataGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRefreshDataGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefreshDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshDataGrid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefreshDataGrid.ForeColor = System.Drawing.Color.White
        Me.btnRefreshDataGrid.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate
        Me.btnRefreshDataGrid.IconColor = System.Drawing.Color.White
        Me.btnRefreshDataGrid.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRefreshDataGrid.IconSize = 20
        Me.btnRefreshDataGrid.Location = New System.Drawing.Point(98, 421)
        Me.btnRefreshDataGrid.Name = "btnRefreshDataGrid"
        Me.btnRefreshDataGrid.Size = New System.Drawing.Size(150, 35)
        Me.btnRefreshDataGrid.TabIndex = 22
        Me.btnRefreshDataGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefreshDataGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefreshDataGrid.UseVisualStyleBackColor = False
        '
        'lblAddNewAC
        '
        Me.lblAddNewAC.AutoSize = True
        Me.lblAddNewAC.Location = New System.Drawing.Point(233, 191)
        Me.lblAddNewAC.Name = "lblAddNewAC"
        Me.lblAddNewAC.Size = New System.Drawing.Size(209, 15)
        Me.lblAddNewAC.TabIndex = 20
        Me.lblAddNewAC.Text = "Airline Category Not Found? Add New"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Image = Global.CPCAviationDutyAssignManagement.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(387, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnDeleteFlight
        '
        Me.btnDeleteFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDeleteFlight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFlight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteFlight.FlatAppearance.BorderSize = 0
        Me.btnDeleteFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDeleteFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFlight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteFlight.ForeColor = System.Drawing.Color.White
        Me.btnDeleteFlight.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDeleteFlight.IconColor = System.Drawing.Color.White
        Me.btnDeleteFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDeleteFlight.IconSize = 20
        Me.btnDeleteFlight.Location = New System.Drawing.Point(289, 465)
        Me.btnDeleteFlight.Name = "btnDeleteFlight"
        Me.btnDeleteFlight.Size = New System.Drawing.Size(150, 35)
        Me.btnDeleteFlight.TabIndex = 19
        Me.btnDeleteFlight.Text = "DELETE"
        Me.btnDeleteFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteFlight.UseVisualStyleBackColor = False
        '
        'btnUpdateFlight
        '
        Me.btnUpdateFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdateFlight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateFlight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdateFlight.FlatAppearance.BorderSize = 0
        Me.btnUpdateFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdateFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnUpdateFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateFlight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateFlight.ForeColor = System.Drawing.Color.White
        Me.btnUpdateFlight.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnUpdateFlight.IconColor = System.Drawing.Color.White
        Me.btnUpdateFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUpdateFlight.IconSize = 20
        Me.btnUpdateFlight.Location = New System.Drawing.Point(289, 421)
        Me.btnUpdateFlight.Name = "btnUpdateFlight"
        Me.btnUpdateFlight.Size = New System.Drawing.Size(150, 35)
        Me.btnUpdateFlight.TabIndex = 18
        Me.btnUpdateFlight.Text = "UPDATE"
        Me.btnUpdateFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateFlight.UseVisualStyleBackColor = False
        '
        'btnSaveFlight
        '
        Me.btnSaveFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSaveFlight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFlight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSaveFlight.FlatAppearance.BorderSize = 0
        Me.btnSaveFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSaveFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSaveFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFlight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveFlight.ForeColor = System.Drawing.Color.White
        Me.btnSaveFlight.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnSaveFlight.IconColor = System.Drawing.Color.White
        Me.btnSaveFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSaveFlight.IconSize = 20
        Me.btnSaveFlight.Location = New System.Drawing.Point(289, 377)
        Me.btnSaveFlight.Name = "btnSaveFlight"
        Me.btnSaveFlight.Size = New System.Drawing.Size(150, 35)
        Me.btnSaveFlight.TabIndex = 17
        Me.btnSaveFlight.Text = "SAVE"
        Me.btnSaveFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveFlight.UseVisualStyleBackColor = False
        '
        'dpDate
        '
        Me.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDate.Location = New System.Drawing.Point(235, 305)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.Size = New System.Drawing.Size(204, 23)
        Me.dpDate.TabIndex = 16
        Me.dpDate.Value = New Date(2023, 3, 17, 11, 38, 27, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(99, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "DATE"
        '
        'cbDT
        '
        Me.cbDT.FormattingEnabled = True
        Me.cbDT.Location = New System.Drawing.Point(235, 261)
        Me.cbDT.Name = "cbDT"
        Me.cbDT.Size = New System.Drawing.Size(204, 23)
        Me.cbDT.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "DEPARTURE TIME"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(389, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(369, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(291, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbStd1
        '
        Me.cbStd1.FormattingEnabled = True
        Me.cbStd1.Location = New System.Drawing.Point(311, 220)
        Me.cbStd1.Name = "cbStd1"
        Me.cbStd1.Size = New System.Drawing.Size(50, 23)
        Me.cbStd1.TabIndex = 8
        '
        'cbStd
        '
        Me.cbStd.FormattingEnabled = True
        Me.cbStd.Location = New System.Drawing.Point(235, 220)
        Me.cbStd.Name = "cbStd"
        Me.cbStd.Size = New System.Drawing.Size(50, 23)
        Me.cbStd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "S.T.D (hh:mm:ss)"
        '
        'lblAName
        '
        Me.lblAName.BackColor = System.Drawing.SystemColors.Window
        Me.lblAName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAName.Location = New System.Drawing.Point(235, 159)
        Me.lblAName.Name = "lblAName"
        Me.lblAName.Size = New System.Drawing.Size(204, 23)
        Me.lblAName.TabIndex = 5
        Me.lblAName.Text = "Label4"
        '
        'cbairlinecategory
        '
        Me.cbairlinecategory.FormattingEnabled = True
        Me.cbairlinecategory.Location = New System.Drawing.Point(235, 127)
        Me.cbairlinecategory.Name = "cbairlinecategory"
        Me.cbairlinecategory.Size = New System.Drawing.Size(204, 23)
        Me.cbairlinecategory.TabIndex = 4
        '
        'tbflightNo
        '
        Me.tbflightNo.Location = New System.Drawing.Point(235, 83)
        Me.tbflightNo.Name = "tbflightNo"
        Me.tbflightNo.Size = New System.Drawing.Size(204, 23)
        Me.tbflightNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AIRLINE CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(99, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FLIGHT NO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FLIGHT DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.dgvFlight)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(478, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(683, 531)
        Me.Panel2.TabIndex = 1
        '
        'dgvFlight
        '
        Me.dgvFlight.AllowUserToAddRows = False
        Me.dgvFlight.AllowUserToDeleteRows = False
        Me.dgvFlight.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvFlight.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFlight.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlight.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fid1, Me.fno, Me.alc, Me.std1, Me.dipart, Me.eta, Me.dt})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFlight.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFlight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFlight.Location = New System.Drawing.Point(10, 48)
        Me.dgvFlight.Name = "dgvFlight"
        Me.dgvFlight.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFlight.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFlight.RowHeadersWidth = 4
        Me.dgvFlight.RowTemplate.Height = 25
        Me.dgvFlight.RowTemplate.ReadOnly = True
        Me.dgvFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlight.Size = New System.Drawing.Size(663, 296)
        Me.dgvFlight.TabIndex = 3
        '
        'fid1
        '
        Me.fid1.HeaderText = "FID"
        Me.fid1.Name = "fid1"
        Me.fid1.ReadOnly = True
        Me.fid1.Width = 50
        '
        'fno
        '
        Me.fno.HeaderText = "FLIGHT NO"
        Me.fno.Name = "fno"
        Me.fno.ReadOnly = True
        '
        'alc
        '
        Me.alc.HeaderText = "AIRLINE CATEGORY"
        Me.alc.Name = "alc"
        Me.alc.ReadOnly = True
        Me.alc.Width = 150
        '
        'std1
        '
        Me.std1.HeaderText = "STD"
        Me.std1.Name = "std1"
        Me.std1.ReadOnly = True
        Me.std1.Width = 75
        '
        'dipart
        '
        Me.dipart.HeaderText = "DEPARTURE TIME"
        Me.dipart.Name = "dipart"
        Me.dipart.ReadOnly = True
        Me.dipart.Width = 150
        '
        'eta
        '
        Me.eta.HeaderText = "ETA"
        Me.eta.Name = "eta"
        Me.eta.ReadOnly = True
        Me.eta.Width = 125
        '
        'dt
        '
        Me.dt.HeaderText = "DATE"
        Me.dt.Name = "dt"
        Me.dt.ReadOnly = True
        Me.dt.Width = 150
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.dgvSearch)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 344)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel4.Size = New System.Drawing.Size(663, 177)
        Me.Panel4.TabIndex = 3
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fid, Me.fno1, Me.alc1, Me.std, Me.dipart1, Me.eta1, Me.dt1})
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.Location = New System.Drawing.Point(6, 32)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowHeadersWidth = 4
        Me.dgvSearch.RowTemplate.Height = 25
        Me.dgvSearch.Size = New System.Drawing.Size(651, 139)
        Me.dgvSearch.TabIndex = 3
        '
        'fid
        '
        Me.fid.HeaderText = "FID"
        Me.fid.Name = "fid"
        Me.fid.ReadOnly = True
        Me.fid.Width = 80
        '
        'fno1
        '
        Me.fno1.HeaderText = "FLIGHT NO"
        Me.fno1.Name = "fno1"
        Me.fno1.ReadOnly = True
        '
        'alc1
        '
        Me.alc1.FillWeight = 150.0!
        Me.alc1.HeaderText = "AIRLINE CATEGORY"
        Me.alc1.Name = "alc1"
        Me.alc1.ReadOnly = True
        Me.alc1.Width = 150
        '
        'std
        '
        Me.std.HeaderText = "S.T.D"
        Me.std.Name = "std"
        Me.std.ReadOnly = True
        '
        'dipart1
        '
        Me.dipart1.FillWeight = 120.0!
        Me.dipart1.HeaderText = "DEPARTURE TIME"
        Me.dipart1.Name = "dipart1"
        Me.dipart1.ReadOnly = True
        Me.dipart1.Width = 150
        '
        'eta1
        '
        Me.eta1.HeaderText = "E.T.A"
        Me.eta1.Name = "eta1"
        Me.eta1.ReadOnly = True
        '
        'dt1
        '
        Me.dt1.HeaderText = "DATE"
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(6, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(651, 26)
        Me.Panel6.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 26)
        Me.Panel7.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(0, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Search Results"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(663, 38)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Controls.Add(Me.tbSearch)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(413, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 38)
        Me.Panel5.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnSearch.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 20
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(219, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(19, 7)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(197, 23)
        Me.tbSearch.TabIndex = 2
        '
        'UserControlAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlAF"
        Me.Size = New System.Drawing.Size(1161, 531)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvFlight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAName As Label
    Friend WithEvents cbairlinecategory As ComboBox
    Friend WithEvents tbflightNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbStd1 As ComboBox
    Friend WithEvents cbStd As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbDT As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dpDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSaveFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAddNewAC As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvFlight As DataGridView
    Friend WithEvents fid1 As DataGridViewTextBoxColumn
    Friend WithEvents fno As DataGridViewTextBoxColumn
    Friend WithEvents alc As DataGridViewTextBoxColumn
    Friend WithEvents std1 As DataGridViewTextBoxColumn
    Friend WithEvents dipart As DataGridViewTextBoxColumn
    Friend WithEvents eta As DataGridViewTextBoxColumn
    Friend WithEvents dt As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents fid As DataGridViewTextBoxColumn
    Friend WithEvents fno1 As DataGridViewTextBoxColumn
    Friend WithEvents alc1 As DataGridViewTextBoxColumn
    Friend WithEvents std As DataGridViewTextBoxColumn
    Friend WithEvents dipart1 As DataGridViewTextBoxColumn
    Friend WithEvents eta1 As DataGridViewTextBoxColumn
    Friend WithEvents dt1 As DataGridViewTextBoxColumn
    Friend WithEvents btnImportExcell As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRefreshDataGrid As FontAwesome.Sharp.IconButton
End Class
