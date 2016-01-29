<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnLoans = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.pnlops = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pnlstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCurrentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblposition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RestrictiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlops, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 704)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnEmployees, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClients, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLoans, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPayments, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnReports, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1008, 40)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(393, 3)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(124, 34)
        Me.btnEmployees.TabIndex = 2
        Me.btnEmployees.Text = "&Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnClients
        '
        Me.btnClients.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.Location = New System.Drawing.Point(263, 3)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(124, 34)
        Me.btnClients.TabIndex = 1
        Me.btnClients.Text = "&Clients"
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnLoans
        '
        Me.btnLoans.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoans.Location = New System.Drawing.Point(133, 3)
        Me.btnLoans.Name = "btnLoans"
        Me.btnLoans.Size = New System.Drawing.Size(124, 34)
        Me.btnLoans.TabIndex = 3
        Me.btnLoans.Text = "&Loans"
        Me.btnLoans.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPayments.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.Location = New System.Drawing.Point(3, 3)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(124, 34)
        Me.btnPayments.TabIndex = 0
        Me.btnPayments.Text = "&Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(523, 3)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(124, 34)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "&Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'pnlops
        '
        Me.pnlops.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlops.Location = New System.Drawing.Point(3, 43)
        Me.pnlops.Name = "pnlops"
        Me.pnlops.Size = New System.Drawing.Size(1002, 658)
        Me.pnlops.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pnlstatus, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblCurrentUser, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.lblposition, Me.ToolStripStatusLabel5, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 706)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 23)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pnlstatus
        '
        Me.pnlstatus.Name = "pnlstatus"
        Me.pnlstatus.Size = New System.Drawing.Size(145, 18)
        Me.pnlstatus.Text = "Connection Status"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(15, 18)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(115, 18)
        Me.ToolStripStatusLabel2.Text = "Current User :"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(23, 18)
        Me.lblCurrentUser.Text = "..."
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(15, 18)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(73, 18)
        Me.ToolStripStatusLabel4.Text = "Position:"
        '
        'lblposition
        '
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(23, 18)
        Me.lblposition.Text = "..."
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(15, 18)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestrictiosToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LockToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.MIT_Lending.My.Resources.Resources.Settings_24x24
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 21)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'RestrictiosToolStripMenuItem
        '
        Me.RestrictiosToolStripMenuItem.Name = "RestrictiosToolStripMenuItem"
        Me.RestrictiosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RestrictiosToolStripMenuItem.Text = "Restrictions"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.LockToolStripMenuItem.Text = "Lock (Ctrl+L)"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "frmMain"
        Me.Text = "..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnClients As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents pnlops As System.Windows.Forms.Panel
    Friend WithEvents btnLoans As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pnlstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCurrentUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestrictiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblposition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
