<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapping
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblTables = New System.Windows.Forms.DataGridView()
        Me.cmbShema = New System.Windows.Forms.ComboBox()
        Me.btnAnalize = New System.Windows.Forms.Button()
        Me.ordinal_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.original_table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.origin_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custom_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgAnalize = New System.ComponentModel.BackgroundWorker()
        CType(Me.tblTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origin tables"
        '
        'tblTables
        '
        Me.tblTables.AllowUserToAddRows = False
        Me.tblTables.AllowUserToDeleteRows = False
        Me.tblTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tblTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblTables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ordinal_number, Me.original_table, Me.origin_status, Me.custom, Me.custom_status})
        Me.tblTables.Location = New System.Drawing.Point(12, 36)
        Me.tblTables.MultiSelect = False
        Me.tblTables.Name = "tblTables"
        Me.tblTables.RowHeadersVisible = False
        Me.tblTables.Size = New System.Drawing.Size(698, 578)
        Me.tblTables.TabIndex = 1
        '
        'cmbShema
        '
        Me.cmbShema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShema.FormattingEnabled = True
        Me.cmbShema.Items.AddRange(New Object() {"Common", "Coffeemath"})
        Me.cmbShema.Location = New System.Drawing.Point(179, 9)
        Me.cmbShema.Name = "cmbShema"
        Me.cmbShema.Size = New System.Drawing.Size(121, 21)
        Me.cmbShema.TabIndex = 2
        '
        'btnAnalize
        '
        Me.btnAnalize.Location = New System.Drawing.Point(306, 9)
        Me.btnAnalize.Name = "btnAnalize"
        Me.btnAnalize.Size = New System.Drawing.Size(75, 21)
        Me.btnAnalize.TabIndex = 3
        Me.btnAnalize.Text = "Analize"
        Me.btnAnalize.UseVisualStyleBackColor = True
        '
        'ordinal_number
        '
        Me.ordinal_number.DataPropertyName = "number"
        Me.ordinal_number.HeaderText = "no"
        Me.ordinal_number.Name = "ordinal_number"
        Me.ordinal_number.ReadOnly = True
        Me.ordinal_number.Width = 40
        '
        'original_table
        '
        Me.original_table.DataPropertyName = "origin"
        Me.original_table.HeaderText = "original table"
        Me.original_table.Name = "original_table"
        Me.original_table.Width = 200
        '
        'origin_status
        '
        Me.origin_status.DataPropertyName = "origin_status"
        Me.origin_status.HeaderText = "status"
        Me.origin_status.Name = "origin_status"
        Me.origin_status.Width = 130
        '
        'custom
        '
        Me.custom.DataPropertyName = "custom"
        Me.custom.HeaderText = "custom table"
        Me.custom.Name = "custom"
        Me.custom.Width = 200
        '
        'custom_status
        '
        Me.custom_status.DataPropertyName = "custom_status"
        Me.custom_status.HeaderText = "status"
        Me.custom_status.Name = "custom_status"
        '
        'bgAnalize
        '
        Me.bgAnalize.WorkerReportsProgress = True
        Me.bgAnalize.WorkerSupportsCancellation = True
        '
        'frmMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 626)
        Me.Controls.Add(Me.btnAnalize)
        Me.Controls.Add(Me.cmbShema)
        Me.Controls.Add(Me.tblTables)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMapping"
        Me.ShowIcon = False
        Me.Text = "Table and columns mapping"
        CType(Me.tblTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tblTables As DataGridView
    Friend WithEvents cmbShema As ComboBox
    Friend WithEvents btnAnalize As Button
    Friend WithEvents ordinal_number As DataGridViewTextBoxColumn
    Friend WithEvents original_table As DataGridViewTextBoxColumn
    Friend WithEvents origin_status As DataGridViewTextBoxColumn
    Friend WithEvents custom As DataGridViewTextBoxColumn
    Friend WithEvents custom_status As DataGridViewTextBoxColumn
    Friend WithEvents bgAnalize As System.ComponentModel.BackgroundWorker
End Class
