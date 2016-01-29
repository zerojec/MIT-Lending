<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cutoff_uc
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblweekno = New System.Windows.Forms.Label()
        Me.lblcollectibles = New System.Windows.Forms.Label()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.lblabsent = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblweekno, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblcollectibles, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbldue, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblabsent, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblpayment, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 48)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Collectibles :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week No :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Due :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Payment :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Absent :"
        '
        'lblweekno
        '
        Me.lblweekno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblweekno.AutoSize = True
        Me.lblweekno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweekno.Location = New System.Drawing.Point(105, 5)
        Me.lblweekno.Name = "lblweekno"
        Me.lblweekno.Size = New System.Drawing.Size(91, 14)
        Me.lblweekno.TabIndex = 5
        Me.lblweekno.Text = "..."
        Me.lblweekno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcollectibles
        '
        Me.lblcollectibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcollectibles.AutoSize = True
        Me.lblcollectibles.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollectibles.Location = New System.Drawing.Point(105, 28)
        Me.lblcollectibles.Name = "lblcollectibles"
        Me.lblcollectibles.Size = New System.Drawing.Size(91, 14)
        Me.lblcollectibles.TabIndex = 6
        Me.lblcollectibles.Text = "..."
        '
        'lbldue
        '
        Me.lbldue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldue.AutoSize = True
        Me.lbldue.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldue.Location = New System.Drawing.Point(304, 5)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(91, 14)
        Me.lbldue.TabIndex = 7
        Me.lbldue.Text = "..."
        '
        'lblabsent
        '
        Me.lblabsent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblabsent.AutoSize = True
        Me.lblabsent.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabsent.Location = New System.Drawing.Point(304, 28)
        Me.lblabsent.Name = "lblabsent"
        Me.lblabsent.Size = New System.Drawing.Size(91, 14)
        Me.lblabsent.TabIndex = 9
        Me.lblabsent.Text = "..."
        '
        'lblpayment
        '
        Me.lblpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpayment.Location = New System.Drawing.Point(503, 5)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(93, 14)
        Me.lblpayment.TabIndex = 8
        Me.lblpayment.Text = "..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cutoff_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cutoff_uc"
        Me.Size = New System.Drawing.Size(600, 48)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblweekno As System.Windows.Forms.Label
    Friend WithEvents lblcollectibles As System.Windows.Forms.Label
    Friend WithEvents lbldue As System.Windows.Forms.Label
    Friend WithEvents lblabsent As System.Windows.Forms.Label
    Friend WithEvents lblpayment As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
