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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdminBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuAdminBar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1044, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(131, 26)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(131, 26)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(131, 26)
        Me.ExitBar.Text = "Exit"
        '
        'MenuAdminBar
        '
        Me.MenuAdminBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Admin1ToolStripMenuItem, Me.Admin2ToolStripMenuItem})
        Me.MenuAdminBar.Name = "MenuAdminBar"
        Me.MenuAdminBar.Size = New System.Drawing.Size(106, 24)
        Me.MenuAdminBar.Text = "Menu Admin"
        '
        'Admin1ToolStripMenuItem
        '
        Me.Admin1ToolStripMenuItem.Name = "Admin1ToolStripMenuItem"
        Me.Admin1ToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.Admin1ToolStripMenuItem.Text = "Sparepart"
        '
        'Admin2ToolStripMenuItem
        '
        Me.Admin2ToolStripMenuItem.Name = "Admin2ToolStripMenuItem"
        Me.Admin2ToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.Admin2ToolStripMenuItem.Text = "Penjualan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "- Selamat Datang -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Multi Jaya Sparepart"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(694, 67)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Menyediakan Berbagai Sparepart Motor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1044, 663)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents MenuAdminBar As ToolStripMenuItem
    Friend WithEvents Admin1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Admin2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
