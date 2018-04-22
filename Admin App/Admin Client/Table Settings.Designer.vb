<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Table_Settings))
        Me.CreateDB = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CreateDB
        '
        Me.CreateDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateDB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateDB.ForeColor = System.Drawing.Color.DarkCyan
        Me.CreateDB.Image = CType(resources.GetObject("CreateDB.Image"), System.Drawing.Image)
        Me.CreateDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateDB.Location = New System.Drawing.Point(37, 63)
        Me.CreateDB.Name = "CreateDB"
        Me.CreateDB.Size = New System.Drawing.Size(160, 37)
        Me.CreateDB.TabIndex = 45
        Me.CreateDB.Text = "Create"
        Me.CreateDB.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 44)
        Me.Panel1.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Table Settings"
        '
        'Table_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(229, 121)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CreateDB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(245, 160)
        Me.MinimumSize = New System.Drawing.Size(245, 160)
        Me.Name = "Table_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table_Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateDB As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
