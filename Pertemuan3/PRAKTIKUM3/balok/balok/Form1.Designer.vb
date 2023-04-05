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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpanjang = New System.Windows.Forms.TextBox()
        Me.txtlebar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtluaspermukaan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Terstruktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'txtpanjang
        '
        Me.txtpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpanjang.Location = New System.Drawing.Point(225, 94)
        Me.txtpanjang.Name = "txtpanjang"
        Me.txtpanjang.Size = New System.Drawing.Size(142, 30)
        Me.txtpanjang.TabIndex = 2
        '
        'txtlebar
        '
        Me.txtlebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlebar.Location = New System.Drawing.Point(225, 130)
        Me.txtlebar.Name = "txtlebar"
        Me.txtlebar.Size = New System.Drawing.Size(142, 30)
        Me.txtlebar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lebar"
        '
        'txttinggi
        '
        Me.txttinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinggi.Location = New System.Drawing.Point(225, 166)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(142, 30)
        Me.txttinggi.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tinggi"
        '
        'txtluaspermukaan
        '
        Me.txtluaspermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtluaspermukaan.Location = New System.Drawing.Point(225, 310)
        Me.txtluaspermukaan.Name = "txtluaspermukaan"
        Me.txtluaspermukaan.Size = New System.Drawing.Size(142, 30)
        Me.txtluaspermukaan.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Luas Permukaan"
        '
        'txtvolume
        '
        Me.txtvolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvolume.Location = New System.Drawing.Point(225, 274)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(142, 30)
        Me.txtvolume.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Volume"
        '
        'btnhitung
        '
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(238, 209)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(113, 51)
        Me.btnhitung.TabIndex = 11
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(348, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(329, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ibnu Hasan - 200511148 - TI20D"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(348, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Created by"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 489)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtluaspermukaan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtvolume)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlebar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpanjang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Balok - Ibnu Hasan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtluaspermukaan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
