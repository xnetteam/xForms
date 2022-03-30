<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectArticle
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.tblArticles = New System.Windows.Forms.DataGridView()
        Me.bsArticles = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tblArticles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(12, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 22)
        Me.txtFilter.TabIndex = 0
        '
        'tblArticles
        '
        Me.tblArticles.AllowUserToAddRows = False
        Me.tblArticles.AllowUserToDeleteRows = False
        Me.tblArticles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblArticles.AutoGenerateColumns = False
        Me.tblArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblArticles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.sku, Me.title, Me.price})
        Me.tblArticles.DataSource = Me.bsArticles
        Me.tblArticles.Location = New System.Drawing.Point(12, 40)
        Me.tblArticles.Name = "tblArticles"
        Me.tblArticles.ReadOnly = True
        Me.tblArticles.Size = New System.Drawing.Size(593, 217)
        Me.tblArticles.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.Location = New System.Drawing.Point(399, 263)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(505, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'sku
        '
        Me.sku.DataPropertyName = "_sku"
        Me.sku.HeaderText = "sku"
        Me.sku.Name = "sku"
        Me.sku.ReadOnly = True
        Me.sku.Width = 80
        '
        'title
        '
        Me.title.DataPropertyName = "post_title"
        Me.title.HeaderText = "title"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 300
        '
        'price
        '
        Me.price.DataPropertyName = "_price"
        Me.price.HeaderText = "price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'frmSelectArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 305)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.tblArticles)
        Me.Controls.Add(Me.txtFilter)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectArticle"
        Me.Text = "Select article"
        CType(Me.tblArticles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilter As TextBox
    Friend WithEvents tblArticles As DataGridView
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents bsArticles As BindingSource
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents sku As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
