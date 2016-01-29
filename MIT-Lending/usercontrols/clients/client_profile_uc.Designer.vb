<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client_profile_uc
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlstats = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtloan_cycle = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnl_payment = New System.Windows.Forms.Panel()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstLoanCycles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AssessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReviewPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvclient_has_been_comaker_to = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.pnl_payment.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmname, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtid, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtfname, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloan_cycle, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtaddress, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcontactno, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtlname, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(910, 356)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Middle Name :"
        '
        'txtmname
        '
        Me.txtmname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmname.Enabled = False
        Me.txtmname.Location = New System.Drawing.Point(205, 105)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(194, 23)
        Me.txtmname.TabIndex = 9
        '
        'txtid
        '
        Me.txtid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(205, 33)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(194, 23)
        Me.txtid.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Client No :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 25)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROFILE"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name :"
        '
        'txtfname
        '
        Me.txtfname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfname.Enabled = False
        Me.txtfname.Location = New System.Drawing.Point(205, 69)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(194, 23)
        Me.txtfname.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlstats, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 315)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(908, 40)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'pnlstats
        '
        Me.pnlstats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlstats.Location = New System.Drawing.Point(0, 0)
        Me.pnlstats.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlstats.Name = "pnlstats"
        Me.pnlstats.Size = New System.Drawing.Size(518, 40)
        Me.pnlstats.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(781, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(651, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Loan Cycles :"
        '
        'txtloan_cycle
        '
        Me.txtloan_cycle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtloan_cycle.Enabled = False
        Me.txtloan_cycle.Location = New System.Drawing.Point(205, 285)
        Me.txtloan_cycle.Name = "txtloan_cycle"
        Me.txtloan_cycle.Size = New System.Drawing.Size(194, 23)
        Me.txtloan_cycle.TabIndex = 17
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(205, 210)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtaddress, 2)
        Me.txtaddress.Size = New System.Drawing.Size(194, 65)
        Me.txtaddress.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'txtcontactno
        '
        Me.txtcontactno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcontactno.Enabled = False
        Me.txtcontactno.Location = New System.Drawing.Point(205, 177)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(194, 23)
        Me.txtcontactno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No. :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name :"
        '
        'txtlname
        '
        Me.txtlname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlname.Enabled = False
        Me.txtlname.Location = New System.Drawing.Point(205, 141)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(194, 23)
        Me.txtlname.TabIndex = 8
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.pnl_payment, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(403, 27)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel3, 8)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(506, 287)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'pnl_payment
        '
        Me.pnl_payment.AutoScroll = True
        Me.pnl_payment.Controls.Add(Me.lv)
        Me.pnl_payment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_payment.Location = New System.Drawing.Point(400, 0)
        Me.pnl_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_payment.Name = "pnl_payment"
        Me.pnl_payment.Size = New System.Drawing.Size(106, 287)
        Me.pnl_payment.TabIndex = 1
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(0, 0)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(106, 287)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No."
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Payment"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 180
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lstLoanCycles, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lvclient_has_been_comaker_to, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(394, 281)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'lstLoanCycles
        '
        Me.lstLoanCycles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstLoanCycles.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstLoanCycles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLoanCycles.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLoanCycles.FullRowSelect = True
        Me.lstLoanCycles.GridLines = True
        Me.lstLoanCycles.Location = New System.Drawing.Point(3, 3)
        Me.lstLoanCycles.MultiSelect = False
        Me.lstLoanCycles.Name = "lstLoanCycles"
        Me.lstLoanCycles.Size = New System.Drawing.Size(388, 124)
        Me.lstLoanCycles.TabIndex = 0
        Me.lstLoanCycles.UseCompatibleStateImageBehavior = False
        Me.lstLoanCycles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cycle"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Payment"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssessToolStripMenuItem, Me.ReviewPaymentsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 48)
        '
        'AssessToolStripMenuItem
        '
        Me.AssessToolStripMenuItem.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssessToolStripMenuItem.Name = "AssessToolStripMenuItem"
        Me.AssessToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AssessToolStripMenuItem.Text = "Assess"
        '
        'ReviewPaymentsToolStripMenuItem
        '
        Me.ReviewPaymentsToolStripMenuItem.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewPaymentsToolStripMenuItem.Name = "ReviewPaymentsToolStripMenuItem"
        Me.ReviewPaymentsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ReviewPaymentsToolStripMenuItem.Text = "Review Payments"
        '
        'lvclient_has_been_comaker_to
        '
        Me.lvclient_has_been_comaker_to.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvclient_has_been_comaker_to.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclient_has_been_comaker_to.FullRowSelect = True
        Me.lvclient_has_been_comaker_to.GridLines = True
        Me.lvclient_has_been_comaker_to.Location = New System.Drawing.Point(3, 153)
        Me.lvclient_has_been_comaker_to.MultiSelect = False
        Me.lvclient_has_been_comaker_to.Name = "lvclient_has_been_comaker_to"
        Me.lvclient_has_been_comaker_to.Size = New System.Drawing.Size(388, 125)
        Me.lvclient_has_been_comaker_to.TabIndex = 1
        Me.lvclient_has_been_comaker_to.UseCompatibleStateImageBehavior = False
        Me.lvclient_has_been_comaker_to.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Amount"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Balance"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 90
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(238, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "This client has been co-maker to :"
        '
        'client_profile_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "client_profile_uc"
        Me.Size = New System.Drawing.Size(910, 356)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.pnl_payment.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtloan_cycle As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstLoanCycles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnl_payment As System.Windows.Forms.Panel
    Friend WithEvents pnlstats As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvclient_has_been_comaker_to As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AssessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReviewPaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
