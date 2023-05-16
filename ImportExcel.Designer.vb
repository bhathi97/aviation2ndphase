<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportExcel
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
        Me.btnExport = New FontAwesome.Sharp.IconButton()
        Me.btnpath = New FontAwesome.Sharp.IconButton()
        Me.tbpath = New System.Windows.Forms.TextBox()
        Me.dgvExcell = New System.Windows.Forms.DataGridView()
        Me.btnExcell = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvExcell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btnExport.IconColor = System.Drawing.Color.White
        Me.btnExport.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnExport.IconSize = 20
        Me.btnExport.Location = New System.Drawing.Point(620, 8)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(166, 35)
        Me.btnExport.TabIndex = 33
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnpath
        '
        Me.btnpath.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnpath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpath.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnpath.FlatAppearance.BorderSize = 0
        Me.btnpath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnpath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnpath.ForeColor = System.Drawing.Color.White
        Me.btnpath.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btnpath.IconColor = System.Drawing.Color.White
        Me.btnpath.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnpath.IconSize = 20
        Me.btnpath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpath.Location = New System.Drawing.Point(12, 20)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(194, 29)
        Me.btnpath.TabIndex = 32
        Me.btnpath.Text = "SELECT LOCATION"
        Me.btnpath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpath.UseVisualStyleBackColor = False
        '
        'tbpath
        '
        Me.tbpath.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbpath.Location = New System.Drawing.Point(212, 20)
        Me.tbpath.Name = "tbpath"
        Me.tbpath.Size = New System.Drawing.Size(498, 29)
        Me.tbpath.TabIndex = 31
        '
        'dgvExcell
        '
        Me.dgvExcell.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvExcell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExcell.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvExcell.Location = New System.Drawing.Point(10, 10)
        Me.dgvExcell.Name = "dgvExcell"
        Me.dgvExcell.RowTemplate.Height = 25
        Me.dgvExcell.Size = New System.Drawing.Size(780, 307)
        Me.dgvExcell.TabIndex = 30
        '
        'btnExcell
        '
        Me.btnExcell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnExcell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExcell.FlatAppearance.BorderSize = 0
        Me.btnExcell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExcell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnExcell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcell.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExcell.ForeColor = System.Drawing.Color.White
        Me.btnExcell.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExcell.IconColor = System.Drawing.Color.White
        Me.btnExcell.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnExcell.IconSize = 20
        Me.btnExcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcell.Location = New System.Drawing.Point(716, 20)
        Me.btnExcell.Name = "btnExcell"
        Me.btnExcell.Size = New System.Drawing.Size(70, 29)
        Me.btnExcell.TabIndex = 29
        Me.btnExcell.Text = "OK"
        Me.btnExcell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcell.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbpath)
        Me.Panel1.Controls.Add(Me.btnExcell)
        Me.Panel1.Controls.Add(Me.btnpath)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 68)
        Me.Panel1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExport)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvExcell)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(800, 327)
        Me.Panel3.TabIndex = 36
        '
        'ImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ImportExcel"
        Me.Text = "ImportExcel"
        CType(Me.dgvExcell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnpath As FontAwesome.Sharp.IconButton
    Friend WithEvents tbpath As TextBox
    Friend WithEvents dgvExcell As DataGridView
    Friend WithEvents btnExcell As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
