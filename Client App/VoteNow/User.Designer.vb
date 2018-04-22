<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.school = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.student = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(181, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Turquoise
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(42, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "UserID :"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.username.Location = New System.Drawing.Point(135, 100)
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Size = New System.Drawing.Size(277, 28)
        Me.username.TabIndex = 6
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userid
        '
        Me.userid.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userid.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.userid.Location = New System.Drawing.Point(134, 143)
        Me.userid.Name = "userid"
        Me.userid.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(277, 28)
        Me.userid.TabIndex = 7
        Me.userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(254, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 30)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "By Hariharan"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 54
        Me.PictureBox13.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(63, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 30)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Vote Now"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.Location = New System.Drawing.Point(42, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 30)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "School :"
        '
        'school
        '
        Me.school.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.school.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.school.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.school.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.school.Location = New System.Drawing.Point(134, 185)
        Me.school.Name = "school"
        Me.school.ReadOnly = True
        Me.school.Size = New System.Drawing.Size(277, 28)
        Me.school.TabIndex = 57
        Me.school.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Turquoise
        Me.Label5.Location = New System.Drawing.Point(31, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 30)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Country :"
        '
        'student
        '
        Me.student.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.student.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.student.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.student.Location = New System.Drawing.Point(134, 228)
        Me.student.Name = "student"
        Me.student.ReadOnly = True
        Me.student.Size = New System.Drawing.Size(277, 28)
        Me.student.TabIndex = 59
        Me.student.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(429, 276)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.school)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "User"
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents userid As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents school As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents student As TextBox
End Class
