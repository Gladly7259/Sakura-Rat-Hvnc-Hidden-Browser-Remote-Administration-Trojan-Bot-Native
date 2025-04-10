<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteDesktop
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
        Me.NyX_Theme1 = New New_Sakura_Rat.NYX_Theme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NyX_Button1 = New New_Sakura_Rat.NYX_Button()
        Me.NyX_Theme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New New_Sakura_Rat.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
        Me.NyX_Theme1.Controls.Add(Me.PictureBox1)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = True
        Me.NyX_Theme1.Size = New System.Drawing.Size(340, 246)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = " RemoteDesktop"
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NyX_Button1
        '
        Me.NyX_Button1.Colors = New New_Sakura_Rat.Bloom(-1) {}
        Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button1.Customization = ""
        Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button1.Image = Nothing
        Me.NyX_Button1.Location = New System.Drawing.Point(12, 210)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(316, 25)
        Me.NyX_Button1.TabIndex = 1
        Me.NyX_Button1.Text = "OFF"
        Me.NyX_Button1.Transparent = False
        '
        'RemoteDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 246)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RemoteDesktop"
        Me.Text = "RemoteDesktop"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NyX_Theme1 As NYX_Theme
    Friend WithEvents NyX_Button1 As NYX_Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
