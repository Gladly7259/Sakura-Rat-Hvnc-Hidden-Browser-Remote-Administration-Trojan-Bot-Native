<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.NyX_Theme1 = New New_Sakura_Rat.NYX_Theme()
        Me.CrystalClearTabControl1 = New New_Sakura_Rat.CrystalClearTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LV1 = New System.Windows.Forms.ListView()
        Me._IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._OS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._VER = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._TASKS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClientMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DownloadAndExecuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunİnMemoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunFromDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNINSTALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUILDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me._NUM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._CMD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._EXE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TaskMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Ping = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_Status = New System.Windows.Forms.Timer(Me.components)
        Me.NyX_Theme1.SuspendLayout()
        Me.CrystalClearTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ClientMenu.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TaskMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New New_Sakura_Rat.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.CrystalClearTabControl1)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = True
        Me.NyX_Theme1.Size = New System.Drawing.Size(792, 460)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "NyX_Theme1"
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'CrystalClearTabControl1
        '
        Me.CrystalClearTabControl1.Controls.Add(Me.TabPage1)
        Me.CrystalClearTabControl1.Controls.Add(Me.TabPage2)
        Me.CrystalClearTabControl1.Location = New System.Drawing.Point(12, 27)
        Me.CrystalClearTabControl1.Name = "CrystalClearTabControl1"
        Me.CrystalClearTabControl1.SelectedIndex = 0
        Me.CrystalClearTabControl1.Size = New System.Drawing.Size(776, 411)
        Me.CrystalClearTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.LV1)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clients List"
        '
        'LV1
        '
        Me.LV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LV1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._IP, Me.Country, Me._Username, Me._OS, Me._VER, Me._ID, Me._TASKS})
        Me.LV1.ContextMenuStrip = Me.ClientMenu
        Me.LV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV1.FullRowSelect = True
        Me.LV1.GridLines = True
        Me.LV1.HideSelection = False
        Me.LV1.Location = New System.Drawing.Point(3, 3)
        Me.LV1.Margin = New System.Windows.Forms.Padding(2)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(762, 376)
        Me.LV1.TabIndex = 1
        Me.LV1.UseCompatibleStateImageBehavior = False
        Me.LV1.View = System.Windows.Forms.View.Details
        '
        '_IP
        '
        Me._IP.Text = "IP"
        Me._IP.Width = 106
        '
        'Country
        '
        Me.Country.Text = "Country"
        Me.Country.Width = 83
        '
        '_Username
        '
        Me._Username.Text = "Username"
        Me._Username.Width = 129
        '
        '_OS
        '
        Me._OS.Text = "Operating System"
        Me._OS.Width = 150
        '
        '_VER
        '
        Me._VER.Text = "Version"
        Me._VER.Width = 72
        '
        '_ID
        '
        Me._ID.Text = "ID"
        Me._ID.Width = 129
        '
        '_TASKS
        '
        Me._TASKS.Text = "Last Task"
        Me._TASKS.Width = 103
        '
        'ClientMenu
        '
        Me.ClientMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ClientMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadAndExecuteToolStripMenuItem, Me.RemoteDesktopToolStripMenuItem, Me.CLIENTToolStripMenuItem, Me.ToolStripSeparator1, Me.BUILDERToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.ClientMenu.Name = "ClientMenu"
        Me.ClientMenu.Size = New System.Drawing.Size(170, 126)
        '
        'DownloadAndExecuteToolStripMenuItem
        '
        Me.DownloadAndExecuteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunİnMemoryToolStripMenuItem, Me.RunFromDiskToolStripMenuItem, Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1})
        Me.DownloadAndExecuteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DownloadAndExecuteToolStripMenuItem.Name = "DownloadAndExecuteToolStripMenuItem"
        Me.DownloadAndExecuteToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DownloadAndExecuteToolStripMenuItem.Text = "UPLOAD FILE"
        '
        'RunİnMemoryToolStripMenuItem
        '
        Me.RunİnMemoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RunİnMemoryToolStripMenuItem.Name = "RunİnMemoryToolStripMenuItem"
        Me.RunİnMemoryToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.RunİnMemoryToolStripMenuItem.Text = "Run in Memory "
        '
        'RunFromDiskToolStripMenuItem
        '
        Me.RunFromDiskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RunFromDiskToolStripMenuItem.Name = "RunFromDiskToolStripMenuItem"
        Me.RunFromDiskToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.RunFromDiskToolStripMenuItem.Text = "Run From Disk"
        '
        'RunİnMemoryWithBypassAMSIToolStripMenuItem1
        '
        Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1.Name = "RunİnMemoryWithBypassAMSIToolStripMenuItem1"
        Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1.Size = New System.Drawing.Size(254, 22)
        Me.RunİnMemoryWithBypassAMSIToolStripMenuItem1.Text = "Run in memory With Bypass AMSI"
        '
        'RemoteDesktopToolStripMenuItem
        '
        Me.RemoteDesktopToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.RemoteDesktopToolStripMenuItem.Name = "RemoteDesktopToolStripMenuItem"
        Me.RemoteDesktopToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoteDesktopToolStripMenuItem.Text = "REMOTE DESKTOP"
        '
        'CLIENTToolStripMenuItem
        '
        Me.CLIENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CLIENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLOSEToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.UNINSTALLToolStripMenuItem})
        Me.CLIENTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CLIENTToolStripMenuItem.Name = "CLIENTToolStripMenuItem"
        Me.CLIENTToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CLIENTToolStripMenuItem.Text = "CLIENT"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'UNINSTALLToolStripMenuItem
        '
        Me.UNINSTALLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UNINSTALLToolStripMenuItem.Name = "UNINSTALLToolStripMenuItem"
        Me.UNINSTALLToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UNINSTALLToolStripMenuItem.Text = "UNINSTALL"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'BUILDERToolStripMenuItem
        '
        Me.BUILDERToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BUILDERToolStripMenuItem.Name = "BUILDERToolStripMenuItem"
        Me.BUILDERToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BUILDERToolStripMenuItem.Text = "BUILDER"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(166, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AboutToolStripMenuItem.Text = "ABOUT"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tasks List"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._NUM, Me._CMD, Me._EXE})
        Me.ListView1.ContextMenuStrip = Me.TaskMenu
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(762, 376)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        '_NUM
        '
        Me._NUM.Text = "Task"
        Me._NUM.Width = 109
        '
        '_CMD
        '
        Me._CMD.Text = "Command"
        Me._CMD.Width = 156
        '
        '_EXE
        '
        Me._EXE.Text = "Execution"
        Me._EXE.Width = 148
        '
        'TaskMenu
        '
        Me.TaskMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TaskMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTaskToolStripMenuItem, Me.RemoveTaskToolStripMenuItem})
        Me.TaskMenu.Name = "TaskMenu"
        Me.TaskMenu.Size = New System.Drawing.Size(150, 48)
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AddTaskToolStripMenuItem.Text = "ADD TASK"
        '
        'RemoveTaskToolStripMenuItem
        '
        Me.RemoveTaskToolStripMenuItem.Name = "RemoveTaskToolStripMenuItem"
        Me.RemoveTaskToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.RemoveTaskToolStripMenuItem.Text = "REMOVE TASK"
        '
        'Timer_Ping
        '
        Me.Timer_Ping.Enabled = True
        Me.Timer_Ping.Interval = 30000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel1.Text = ".."
        '
        'Timer_Status
        '
        Me.Timer_Status.Enabled = True
        Me.Timer_Status.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 460)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.CrystalClearTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ClientMenu.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TaskMenu.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NyX_Theme1 As NYX_Theme
    Friend WithEvents CrystalClearTabControl1 As CrystalClearTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LV1 As ListView
    Friend WithEvents _IP As ColumnHeader
    Friend WithEvents Country As ColumnHeader
    Friend WithEvents _Username As ColumnHeader
    Friend WithEvents _OS As ColumnHeader
    Friend WithEvents _VER As ColumnHeader
    Friend WithEvents _ID As ColumnHeader
    Friend WithEvents _TASKS As ColumnHeader
    Friend WithEvents ClientMenu As ContextMenuStrip
    Friend WithEvents DownloadAndExecuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunİnMemoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunFromDiskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunİnMemoryWithBypassAMSIToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RemoteDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNINSTALLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BUILDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents _NUM As ColumnHeader
    Friend WithEvents _CMD As ColumnHeader
    Friend WithEvents _EXE As ColumnHeader
    Friend WithEvents TaskMenu As ContextMenuStrip
    Friend WithEvents AddTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_Ping As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer_Status As Timer
End Class
