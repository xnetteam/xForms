<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionFile
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtServerAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMySQLUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMySQLPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(172, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 22)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "server"
        '
        'txtServerAddress
        '
        Me.txtServerAddress.Location = New System.Drawing.Point(172, 40)
        Me.txtServerAddress.Name = "txtServerAddress"
        Me.txtServerAddress.Size = New System.Drawing.Size(230, 22)
        Me.txtServerAddress.TabIndex = 3
        Me.txtServerAddress.Text = "localhost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server address"
        '
        'txtMySQLUsername
        '
        Me.txtMySQLUsername.Location = New System.Drawing.Point(172, 68)
        Me.txtMySQLUsername.Name = "txtMySQLUsername"
        Me.txtMySQLUsername.Size = New System.Drawing.Size(230, 22)
        Me.txtMySQLUsername.TabIndex = 5
        Me.txtMySQLUsername.Text = "magmat32remoter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MySQL Username"
        '
        'txtMySQLPassword
        '
        Me.txtMySQLPassword.Location = New System.Drawing.Point(172, 96)
        Me.txtMySQLPassword.Name = "txtMySQLPassword"
        Me.txtMySQLPassword.Size = New System.Drawing.Size(230, 22)
        Me.txtMySQLPassword.TabIndex = 7
        Me.txtMySQLPassword.Text = "pErMOOter4$6^5%"
        Me.txtMySQLPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MySQL Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(172, 124)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(230, 22)
        Me.txtConfirmPassword.TabIndex = 9
        Me.txtConfirmPassword.Text = "pErMOOter4$6^5%"
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirm Password"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(172, 152)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(230, 22)
        Me.txtDatabase.TabIndex = 11
        Me.txtDatabase.Text = "coffee2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Database name"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(302, 203)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Create file"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestConnection.Location = New System.Drawing.Point(186, 203)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(110, 30)
        Me.btnTestConnection.TabIndex = 13
        Me.btnTestConnection.Text = "Test connection"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(12, 220)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(28, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Info"
        Me.lblInfo.Visible = False
        '
        'frmConnectionFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 245)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMySQLPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMySQLUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServerAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnectionFile"
        Me.ShowIcon = False
        Me.Text = "Connection File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtServerAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMySQLUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMySQLPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents lblInfo As Label
End Class
