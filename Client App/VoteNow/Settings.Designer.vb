<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.close = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.connectstat1 = New System.Windows.Forms.PictureBox()
        Me.connectalert1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dbname = New System.Windows.Forms.TextBox()
        Me.dbpass = New System.Windows.Forms.TextBox()
        Me.dbuser = New System.Windows.Forms.TextBox()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.connectstat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.connectalert1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 50)
        Me.Panel1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Settings"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.close)
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dbname)
        Me.Panel2.Controls.Add(Me.dbpass)
        Me.Panel2.Controls.Add(Me.dbuser)
        Me.Panel2.Controls.Add(Me.ip)
        Me.Panel2.Location = New System.Drawing.Point(10, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 388)
        Me.Panel2.TabIndex = 47
        '
        'close
        '
        Me.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.ForeColor = System.Drawing.Color.DarkCyan
        Me.close.Image = CType(resources.GetObject("close.Image"), System.Drawing.Image)
        Me.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.close.Location = New System.Drawing.Point(112, 320)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(99, 36)
        Me.close.TabIndex = 45
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.DarkCyan
        Me.reset.Image = CType(resources.GetObject("reset.Image"), System.Drawing.Image)
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reset.Location = New System.Drawing.Point(5, 320)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(101, 36)
        Me.reset.TabIndex = 44
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 36)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.connectstat1)
        Me.FlowLayoutPanel1.Controls.Add(Me.connectalert1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(142, 362)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(77, 24)
        Me.FlowLayoutPanel1.TabIndex = 42
        '
        'connectstat1
        '
        Me.connectstat1.BackColor = System.Drawing.Color.Transparent
        Me.connectstat1.Image = CType(resources.GetObject("connectstat1.Image"), System.Drawing.Image)
        Me.connectstat1.Location = New System.Drawing.Point(53, 3)
        Me.connectstat1.Name = "connectstat1"
        Me.connectstat1.Size = New System.Drawing.Size(21, 21)
        Me.connectstat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connectstat1.TabIndex = 26
        Me.connectstat1.TabStop = False
        '
        'connectalert1
        '
        Me.connectalert1.BackColor = System.Drawing.Color.Transparent
        Me.connectalert1.Image = CType(resources.GetObject("connectalert1.Image"), System.Drawing.Image)
        Me.connectalert1.Location = New System.Drawing.Point(26, 3)
        Me.connectalert1.Name = "connectalert1"
        Me.connectalert1.Size = New System.Drawing.Size(21, 21)
        Me.connectalert1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connectalert1.TabIndex = 27
        Me.connectalert1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 204)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(36, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Database"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(5, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(36, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(36, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(36, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "IP Address"
        '
        'dbname
        '
        Me.dbname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbname.Location = New System.Drawing.Point(5, 236)
        Me.dbname.Name = "dbname"
        Me.dbname.Size = New System.Drawing.Size(206, 29)
        Me.dbname.TabIndex = 33
        '
        'dbpass
        '
        Me.dbpass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbpass.Location = New System.Drawing.Point(5, 169)
        Me.dbpass.Name = "dbpass"
        Me.dbpass.Size = New System.Drawing.Size(206, 29)
        Me.dbpass.TabIndex = 32
        Me.dbpass.UseSystemPasswordChar = True
        '
        'dbuser
        '
        Me.dbuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbuser.Location = New System.Drawing.Point(5, 102)
        Me.dbuser.Name = "dbuser"
        Me.dbuser.Size = New System.Drawing.Size(206, 29)
        Me.dbuser.TabIndex = 31
        '
        'ip
        '
        Me.ip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip.Location = New System.Drawing.Point(5, 35)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(206, 29)
        Me.ip.TabIndex = 30
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(240, 455)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.connectstat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.connectalert1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents close As Button
    Friend WithEvents reset As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents connectstat1 As PictureBox
    Friend WithEvents connectalert1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dbname As TextBox
    Friend WithEvents dbpass As TextBox
    Friend WithEvents dbuser As TextBox
    Friend WithEvents ip As TextBox
End Class
