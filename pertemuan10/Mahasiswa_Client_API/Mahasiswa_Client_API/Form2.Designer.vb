﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(479, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 30)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(479, 54)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(125, 30)
        Me.btnSubmit.TabIndex = 50
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(479, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 30)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtProdi
        '
        Me.txtProdi.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdi.Location = New System.Drawing.Point(212, 151)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(177, 25)
        Me.txtProdi.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Prodi"
        '
        'txtSKS
        '
        Me.txtSKS.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSKS.Location = New System.Drawing.Point(212, 113)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(177, 25)
        Me.txtSKS.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "SKS"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(212, 73)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(177, 25)
        Me.txtNama.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nama MK"
        '
        'txtKode
        '
        Me.txtKode.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(212, 35)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(177, 25)
        Me.txtKode.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Kode MK"
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(84, 249)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(520, 228)
        Me.dgvData.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("News706 BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Form Matakuliah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("News706 BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(238, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Ibnu Hasan_200511148_TI20D"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(684, 498)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSKS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvData)
        Me.Font = New System.Drawing.Font("News706 BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
