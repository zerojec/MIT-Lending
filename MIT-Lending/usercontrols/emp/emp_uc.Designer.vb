<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emp_uc
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
        Me.pnlSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlops = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CashAdvanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 360)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlSearch, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNew, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(590, 43)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'pnlSearch
        '
        Me.pnlSearch.ColumnCount = 2
        Me.TableLayoutPanel2.SetColumnSpan(Me.pnlSearch, 2)
        Me.pnlSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.pnlSearch.Controls.Add(Me.txtSearchBox, 0, 0)
        Me.pnlSearch.Controls.Add(Me.btnSearch, 1, 0)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSearch.Location = New System.Drawing.Point(200, 0)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.RowCount = 1
        Me.pnlSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlSearch.Size = New System.Drawing.Size(260, 43)
        Me.pnlSearch.TabIndex = 3
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchBox.BackColor = System.Drawing.Color.White
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearchBox.Location = New System.Drawing.Point(3, 8)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(209, 26)
        Me.txtSearchBox.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(463, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(124, 37)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employees"
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.ForeColor = System.Drawing.Color.DimGray
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(4, 60)
        Me.lv.Margin = New System.Windows.Forms.Padding(4)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(588, 296)
        Me.lv.TabIndex = 0
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
        Me.ColumnHeader2.Text = "Position"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Contact Number"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Area"
        Me.ColumnHeader4.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CashAdvanceToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 92)
        '
        'pnlops
        '
        Me.pnlops.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlops.Location = New System.Drawing.Point(3, 52)
        Me.pnlops.Name = "pnlops"
        Me.pnlops.Size = New System.Drawing.Size(590, 1)
        Me.pnlops.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CashAdvanceToolStripMenuItem
        '
        Me.CashAdvanceToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashAdvanceToolStripMenuItem.Image = Global.MIT_Lending.My.Resources.Resources.money
        Me.CashAdvanceToolStripMenuItem.Name = "CashAdvanceToolStripMenuItem"
        Me.CashAdvanceToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CashAdvanceToolStripMenuItem.Text = "Cash Advance"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.MIT_Lending.My.Resources.Resources.Search_24x24
        Me.btnSearch.Location = New System.Drawing.Point(218, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 37)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Image = Global.MIT_Lending.My.Resources.Resources.Edit_16x16
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.Image = Global.MIT_Lending.My.Resources.Resources.Delete_16x16
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'emp_uc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "emp_uc"
        Me.Size = New System.Drawing.Size(596, 360)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents pnlops As System.Windows.Forms.Panel
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlSearch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents CashAdvanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
