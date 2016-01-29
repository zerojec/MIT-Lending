<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pay_sched_uc
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblschedule_date = New System.Windows.Forms.Label()
        Me.lblday = New System.Windows.Forms.Label()
        Me.lblexcess = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.lbldaily = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblschedule_date, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblday, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblexcess, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblpayment, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbldue, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbldaily, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 32)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblschedule_date
        '
        Me.lblschedule_date.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblschedule_date.AutoSize = True
        Me.lblschedule_date.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblschedule_date.Location = New System.Drawing.Point(45, 9)
        Me.lblschedule_date.Name = "lblschedule_date"
        Me.lblschedule_date.Size = New System.Drawing.Size(41, 14)
        Me.lblschedule_date.TabIndex = 1
        Me.lblschedule_date.Text = "Date "
        Me.lblschedule_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblday
        '
        Me.lblday.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblday.AutoSize = True
        Me.lblday.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblday.Location = New System.Drawing.Point(4, 9)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(28, 14)
        Me.lblday.TabIndex = 0
        Me.lblday.Text = "No."
        Me.lblday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblexcess
        '
        Me.lblexcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblexcess.AutoSize = True
        Me.lblexcess.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexcess.Location = New System.Drawing.Point(446, 9)
        Me.lblexcess.Name = "lblexcess"
        Me.lblexcess.Size = New System.Drawing.Size(131, 14)
        Me.lblexcess.TabIndex = 4
        Me.lblexcess.Text = "Excess "
        Me.lblexcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpayment
        '
        Me.lblpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpayment.Location = New System.Drawing.Point(308, 9)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(131, 14)
        Me.lblpayment.TabIndex = 3
        Me.lblpayment.Text = "Payment "
        Me.lblpayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldue
        '
        Me.lbldue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldue.AutoSize = True
        Me.lbldue.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldue.Location = New System.Drawing.Point(146, 9)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(74, 14)
        Me.lbldue.TabIndex = 2
        Me.lbldue.Text = "Due "
        Me.lbldue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldaily
        '
        Me.lbldaily.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldaily.AutoSize = True
        Me.lbldaily.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldaily.Location = New System.Drawing.Point(227, 9)
        Me.lbldaily.Name = "lbldaily"
        Me.lbldaily.Size = New System.Drawing.Size(74, 14)
        Me.lbldaily.TabIndex = 7
        Me.lbldaily.Text = "Daily"
        Me.lbldaily.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pay_sched_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "pay_sched_uc"
        Me.Size = New System.Drawing.Size(602, 32)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblday As System.Windows.Forms.Label
    Friend WithEvents lblschedule_date As System.Windows.Forms.Label
    Friend WithEvents lbldue As System.Windows.Forms.Label
    Friend WithEvents lblpayment As System.Windows.Forms.Label
    Friend WithEvents lblexcess As System.Windows.Forms.Label
    Friend WithEvents lbldaily As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
