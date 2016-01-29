<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestData
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
        Me.lb = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lb
        '
        Me.lb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb.FormattingEnabled = True
        Me.lb.Location = New System.Drawing.Point(0, 0)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(411, 427)
        Me.lb.TabIndex = 0
        '
        'frmTestData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 427)
        Me.Controls.Add(Me.lb)
        Me.Name = "frmTestData"
        Me.Text = "Test Data"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb As System.Windows.Forms.ListBox
End Class
