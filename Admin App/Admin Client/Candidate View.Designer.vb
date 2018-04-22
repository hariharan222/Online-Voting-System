<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Candidate_View
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Candidate_View))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.deleteid = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CNAME = New System.Windows.Forms.TextBox()
        Me.CID = New System.Windows.Forms.TextBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CMAIL = New System.Windows.Forms.TextBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(517, 465)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Candidates List"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(463, 525)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 26)
        Me.Button5.TabIndex = 34
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(494, 525)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 26)
        Me.Button6.TabIndex = 33
        Me.Button6.UseVisualStyleBackColor = True
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(12, 529)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(117, 20)
        Me.deleteid.TabIndex = 35
        Me.deleteid.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(535, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'CNAME
        '
        Me.CNAME.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNAME.Location = New System.Drawing.Point(535, 281)
        Me.CNAME.Name = "CNAME"
        Me.CNAME.ReadOnly = True
        Me.CNAME.Size = New System.Drawing.Size(162, 29)
        Me.CNAME.TabIndex = 37
        '
        'CID
        '
        Me.CID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CID.Location = New System.Drawing.Point(535, 348)
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Size = New System.Drawing.Size(162, 29)
        Me.CID.TabIndex = 38
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(534, 249)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox11.TabIndex = 39
        Me.PictureBox11.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label10.Location = New System.Drawing.Point(565, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 21)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Name/Surname"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label12.Location = New System.Drawing.Point(564, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 21)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Student ID"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(534, 316)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox14.TabIndex = 41
        Me.PictureBox14.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(615, 470)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 94)
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'CMAIL
        '
        Me.CMAIL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMAIL.Location = New System.Drawing.Point(535, 415)
        Me.CMAIL.Name = "CMAIL"
        Me.CMAIL.ReadOnly = True
        Me.CMAIL.Size = New System.Drawing.Size(162, 29)
        Me.CMAIL.TabIndex = 44
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(535, 383)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox17.TabIndex = 45
        Me.PictureBox17.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(565, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 21)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Email Address"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(536, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 45)
        Me.Button1.TabIndex = 47
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Candidate_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CMAIL)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CID)
        Me.Controls.Add(Me.CNAME)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.deleteid)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(720, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 600)
        Me.Name = "Candidate_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Candidate_View"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents deleteid As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CNAME As TextBox
    Friend WithEvents CID As TextBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CMAIL As TextBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
