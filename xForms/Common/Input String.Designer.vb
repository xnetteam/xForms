<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputString
    Inherits DevComponents.DotNetBar.Metro.MetroForm
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
        Me.lblNaslov = New DevComponents.DotNetBar.LabelX()
        Me.txt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnVnesi = New DevComponents.DotNetBar.ButtonX()
        Me.btnOtkazi = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'lblNaslov
        '
        Me.lblNaslov.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        '
        '
        Me.lblNaslov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNaslov.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNaslov.ForeColor = System.Drawing.Color.White
        Me.lblNaslov.Location = New System.Drawing.Point(12, 12)
        Me.lblNaslov.Name = "lblNaslov"
        Me.lblNaslov.Size = New System.Drawing.Size(345, 59)
        Me.lblNaslov.TabIndex = 1
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txt.Border.Class = "TextBoxBorder"
        Me.txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt.DisabledBackColor = System.Drawing.Color.Black
        Me.txt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt.ForeColor = System.Drawing.Color.White
        Me.txt.Location = New System.Drawing.Point(12, 77)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(345, 25)
        Me.txt.TabIndex = 2
        '
        'btnVnesi
        '
        Me.btnVnesi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVnesi.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnVnesi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnVnesi.Location = New System.Drawing.Point(127, 108)
        Me.btnVnesi.Name = "btnVnesi"
        Me.btnVnesi.Size = New System.Drawing.Size(112, 32)
        Me.btnVnesi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVnesi.TabIndex = 3
        Me.btnVnesi.Text = "Внеси"
        Me.btnVnesi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnOtkazi
        '
        Me.btnOtkazi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOtkazi.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOtkazi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOtkazi.Location = New System.Drawing.Point(245, 108)
        Me.btnOtkazi.Name = "btnOtkazi"
        Me.btnOtkazi.Size = New System.Drawing.Size(112, 32)
        Me.btnOtkazi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOtkazi.TabIndex = 4
        Me.btnOtkazi.Text = "Откажи"
        Me.btnOtkazi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'frmInputString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 145)
        Me.Controls.Add(Me.btnOtkazi)
        Me.Controls.Add(Me.btnVnesi)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lblNaslov)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputString"
        Me.Text = "Input String"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNaslov As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnVnesi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOtkazi As DevComponents.DotNetBar.ButtonX
End Class
