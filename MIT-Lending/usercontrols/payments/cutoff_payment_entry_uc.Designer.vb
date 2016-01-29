<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cutoff_payment_entry_uc
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
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtg.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg.Size = New System.Drawing.Size(1319, 336)
        Me.dtg.TabIndex = 0
        Me.dtg.Visible = False
        '
        'btnprint
        '
        Me.btnprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprint.Enabled = False
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(1161, 342)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(155, 35)
        Me.btnprint.TabIndex = 1
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'bgw
        '
        '
        'cutoff_payment_entry_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.dtg)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cutoff_payment_entry_uc"
        Me.Size = New System.Drawing.Size(1319, 380)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker

End Class
