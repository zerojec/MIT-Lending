<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_payment_uc
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtornumber = New System.Windows.Forms.TextBox()
        Me.dtpayment_date = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboclient = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtendofpayment = New System.Windows.Forms.TextBox()
        Me.txtstartofpayment = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbocollector = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtactive_loan = New System.Windows.Forms.TextBox()
        Me.txttotal_payment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdayslapse = New System.Windows.Forms.TextBox()
        Me.pnl_payment = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlstats = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Select :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 5)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 25)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(850, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(494, 18)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(101, 1)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Lapse"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(199, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Unprocessed"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.GreenYellow
        Me.Label16.Location = New System.Drawing.Point(3, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Paid"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(395, 1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Cut-Off"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(297, 1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Active Date"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW ENTRY"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(472, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Collector :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "OR Number :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtornumber
        '
        Me.txtornumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtornumber.Location = New System.Drawing.Point(556, 105)
        Me.txtornumber.Name = "txtornumber"
        Me.txtornumber.Size = New System.Drawing.Size(194, 23)
        Me.txtornumber.TabIndex = 15
        '
        'dtpayment_date
        '
        Me.dtpayment_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpayment_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpayment_date.Location = New System.Drawing.Point(556, 69)
        Me.dtpayment_date.Name = "dtpayment_date"
        Me.dtpayment_date.Size = New System.Drawing.Size(194, 23)
        Me.dtpayment_date.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact No :"
        '
        'txtcontactno
        '
        Me.txtcontactno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcontactno.Enabled = False
        Me.txtcontactno.Location = New System.Drawing.Point(205, 141)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(193, 23)
        Me.txtcontactno.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address :"
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(205, 105)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(193, 23)
        Me.txtaddress.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Name :"
        '
        'txtname
        '
        Me.txtname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(205, 69)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(193, 23)
        Me.txtname.TabIndex = 13
        '
        'txtamount
        '
        Me.txtamount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtamount.Location = New System.Drawing.Point(556, 33)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(194, 23)
        Me.txtamount.TabIndex = 9
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount :"
        '
        'cboclient
        '
        Me.cboclient.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboclient.FormattingEnabled = True
        Me.cboclient.Location = New System.Drawing.Point(205, 34)
        Me.cboclient.Name = "cboclient"
        Me.cboclient.Size = New System.Drawing.Size(193, 24)
        Me.cboclient.TabIndex = 21
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtendofpayment, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtstartofpayment, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtornumber, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpayment_date, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcontactno, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtaddress, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtname, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtamount, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboclient, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbocollector, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtactive_loan, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txttotal_payment, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbalance, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdayslapse, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.pnl_payment, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1349, 320)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'txtendofpayment
        '
        Me.txtendofpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtendofpayment.Enabled = False
        Me.txtendofpayment.Location = New System.Drawing.Point(556, 213)
        Me.txtendofpayment.Name = "txtendofpayment"
        Me.txtendofpayment.Size = New System.Drawing.Size(194, 23)
        Me.txtendofpayment.TabIndex = 27
        Me.txtendofpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtstartofpayment
        '
        Me.txtstartofpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtstartofpayment.Enabled = False
        Me.txtstartofpayment.Location = New System.Drawing.Point(556, 177)
        Me.txtstartofpayment.Name = "txtstartofpayment"
        Me.txtstartofpayment.Size = New System.Drawing.Size(194, 23)
        Me.txtstartofpayment.TabIndex = 27
        Me.txtstartofpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(450, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = " Days Lapse :"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(470, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "End Date :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(499, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Date :"
        '
        'cbocollector
        '
        Me.cbocollector.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbocollector.FormattingEnabled = True
        Me.cbocollector.Location = New System.Drawing.Point(556, 142)
        Me.cbocollector.Name = "cbocollector"
        Me.cbocollector.Size = New System.Drawing.Size(194, 24)
        Me.cbocollector.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(101, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Active Loan :"
        '
        'txtactive_loan
        '
        Me.txtactive_loan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtactive_loan.Enabled = False
        Me.txtactive_loan.Location = New System.Drawing.Point(205, 177)
        Me.txtactive_loan.Name = "txtactive_loan"
        Me.txtactive_loan.Size = New System.Drawing.Size(193, 23)
        Me.txtactive_loan.TabIndex = 25
        Me.txtactive_loan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal_payment
        '
        Me.txttotal_payment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal_payment.Enabled = False
        Me.txttotal_payment.Location = New System.Drawing.Point(205, 213)
        Me.txttotal_payment.Name = "txttotal_payment"
        Me.txttotal_payment.Size = New System.Drawing.Size(193, 23)
        Me.txttotal_payment.TabIndex = 26
        Me.txttotal_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(84, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total Payment :"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(128, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Balance :"
        '
        'txtbalance
        '
        Me.txtbalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbalance.Enabled = False
        Me.txtbalance.Location = New System.Drawing.Point(205, 249)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(193, 23)
        Me.txtbalance.TabIndex = 29
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(460, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Start Date :"
        '
        'txtdayslapse
        '
        Me.txtdayslapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdayslapse.Enabled = False
        Me.txtdayslapse.Location = New System.Drawing.Point(556, 249)
        Me.txtdayslapse.Name = "txtdayslapse"
        Me.txtdayslapse.Size = New System.Drawing.Size(194, 23)
        Me.txtdayslapse.TabIndex = 27
        Me.txtdayslapse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnl_payment
        '
        Me.pnl_payment.AutoScroll = True
        Me.pnl_payment.BackColor = System.Drawing.Color.White
        Me.pnl_payment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_payment.Location = New System.Drawing.Point(754, 27)
        Me.pnl_payment.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_payment.Name = "pnl_payment"
        Me.TableLayoutPanel1.SetRowSpan(Me.pnl_payment, 7)
        Me.pnl_payment.Size = New System.Drawing.Size(594, 251)
        Me.pnl_payment.TabIndex = 33
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1090, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1220, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 5)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlstats, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 279)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1347, 40)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'pnlstats
        '
        Me.pnlstats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlstats.Location = New System.Drawing.Point(3, 3)
        Me.pnlstats.Name = "pnlstats"
        Me.pnlstats.Size = New System.Drawing.Size(1081, 34)
        Me.pnlstats.TabIndex = 0
        '
        'new_payment_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "new_payment_uc"
        Me.Size = New System.Drawing.Size(1349, 320)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtornumber As System.Windows.Forms.TextBox
    Friend WithEvents dtpayment_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboclient As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbocollector As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtactive_loan As System.Windows.Forms.TextBox
    Friend WithEvents txttotal_payment As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtdayslapse As System.Windows.Forms.TextBox
    Friend WithEvents txtendofpayment As System.Windows.Forms.TextBox
    Friend WithEvents txtstartofpayment As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnl_payment As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlstats As System.Windows.Forms.Panel

End Class
