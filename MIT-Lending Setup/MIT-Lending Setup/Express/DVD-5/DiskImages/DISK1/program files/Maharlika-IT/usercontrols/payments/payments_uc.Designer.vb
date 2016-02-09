<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payments_uc
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlview = New System.Windows.Forms.TableLayoutPanel()
        Me.cboarea = New System.Windows.Forms.ComboBox()
        Me.cbocutoff = New System.Windows.Forms.ComboBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.cbomonths = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlsearch = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlops = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlview.SuspendLayout()
        Me.pnlsearch.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lv, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlops, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(913, 338)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Lime
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlview, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlsearch, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNew, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(907, 43)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'pnlview
        '
        Me.pnlview.ColumnCount = 4
        Me.pnlview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.pnlview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.pnlview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.pnlview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.pnlview.Controls.Add(Me.cboarea, 3, 0)
        Me.pnlview.Controls.Add(Me.cbocutoff, 2, 0)
        Me.pnlview.Controls.Add(Me.lblSelect, 0, 0)
        Me.pnlview.Controls.Add(Me.cbomonths, 1, 0)
        Me.pnlview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlview.Location = New System.Drawing.Point(327, 0)
        Me.pnlview.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlview.Name = "pnlview"
        Me.pnlview.RowCount = 1
        Me.pnlview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlview.Size = New System.Drawing.Size(450, 43)
        Me.pnlview.TabIndex = 4
        '
        'cboarea
        '
        Me.cboarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboarea.FormattingEnabled = True
        Me.cboarea.Location = New System.Drawing.Point(323, 9)
        Me.cboarea.Name = "cboarea"
        Me.cboarea.Size = New System.Drawing.Size(124, 24)
        Me.cboarea.TabIndex = 3
        '
        'cbocutoff
        '
        Me.cbocutoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbocutoff.FormattingEnabled = True
        Me.cbocutoff.Location = New System.Drawing.Point(223, 11)
        Me.cbocutoff.Name = "cbocutoff"
        Me.cbocutoff.Size = New System.Drawing.Size(94, 24)
        Me.cbocutoff.TabIndex = 2
        '
        'lblSelect
        '
        Me.lblSelect.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(21, 13)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(96, 16)
        Me.lblSelect.TabIndex = 5
        Me.lblSelect.Text = "Select Cutoff"
        '
        'cbomonths
        '
        Me.cbomonths.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbomonths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbomonths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomonths.FormattingEnabled = True
        Me.cbomonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbomonths.Location = New System.Drawing.Point(123, 11)
        Me.cbomonths.Name = "cbomonths"
        Me.cbomonths.Size = New System.Drawing.Size(94, 24)
        Me.cbomonths.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payments"
        '
        'pnlsearch
        '
        Me.pnlsearch.ColumnCount = 2
        Me.pnlsearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlsearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.pnlsearch.Controls.Add(Me.txtSearchBox, 0, 0)
        Me.pnlsearch.Controls.Add(Me.Button2, 1, 0)
        Me.pnlsearch.Location = New System.Drawing.Point(97, 0)
        Me.pnlsearch.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlsearch.Name = "pnlsearch"
        Me.pnlsearch.RowCount = 1
        Me.pnlsearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlsearch.Size = New System.Drawing.Size(230, 43)
        Me.pnlsearch.TabIndex = 4
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchBox.BackColor = System.Drawing.Color.White
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearchBox.Location = New System.Drawing.Point(3, 8)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(179, 26)
        Me.txtSearchBox.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.MIT_Lending.My.Resources.Resources.Search_24x24
        Me.Button2.Location = New System.Drawing.Point(188, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(780, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(124, 37)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&Generate"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.ForeColor = System.Drawing.Color.DimGray
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(4, 60)
        Me.lv.Margin = New System.Windows.Forms.Padding(4)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(905, 274)
        Me.lv.TabIndex = 5
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'No
        '
        Me.No.Text = "No."
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 230
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date of Payment"
        Me.ColumnHeader3.Width = 130
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.Image = Global.MIT_Lending.My.Resources.Resources.Delete_16x16
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlops
        '
        Me.pnlops.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlops.Location = New System.Drawing.Point(3, 52)
        Me.pnlops.Name = "pnlops"
        Me.pnlops.Size = New System.Drawing.Size(907, 1)
        Me.pnlops.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'payments_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "payments_uc"
        Me.Size = New System.Drawing.Size(913, 338)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlview.ResumeLayout(False)
        Me.pnlview.PerformLayout()
        Me.pnlsearch.ResumeLayout(False)
        Me.pnlsearch.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlops As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlview As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbocutoff As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents cboarea As System.Windows.Forms.ComboBox
    Friend WithEvents cbomonths As System.Windows.Forms.ComboBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlsearch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
