<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataform
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
        Me.president = New System.Windows.Forms.TextBox()
        Me.dpresident = New System.Windows.Forms.TextBox()
        Me.seceretary = New System.Windows.Forms.TextBox()
        Me.treasurer = New System.Windows.Forms.TextBox()
        Me.SOSE = New System.Windows.Forms.TextBox()
        Me.SOMB = New System.Windows.Forms.TextBox()
        Me.irep = New System.Windows.Forms.TextBox()
        Me.pres = New System.Windows.Forms.TextBox()
        Me.dpres = New System.Windows.Forms.TextBox()
        Me.sec = New System.Windows.Forms.TextBox()
        Me.tre = New System.Windows.Forms.TextBox()
        Me.sosen = New System.Windows.Forms.TextBox()
        Me.sombn = New System.Windows.Forms.TextBox()
        Me.irepn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'president
        '
        Me.president.Location = New System.Drawing.Point(13, 48)
        Me.president.Name = "president"
        Me.president.Size = New System.Drawing.Size(100, 20)
        Me.president.TabIndex = 0
        '
        'dpresident
        '
        Me.dpresident.Location = New System.Drawing.Point(13, 92)
        Me.dpresident.Name = "dpresident"
        Me.dpresident.Size = New System.Drawing.Size(100, 20)
        Me.dpresident.TabIndex = 1
        '
        'seceretary
        '
        Me.seceretary.Location = New System.Drawing.Point(13, 142)
        Me.seceretary.Name = "seceretary"
        Me.seceretary.Size = New System.Drawing.Size(100, 20)
        Me.seceretary.TabIndex = 2
        '
        'treasurer
        '
        Me.treasurer.Location = New System.Drawing.Point(13, 196)
        Me.treasurer.Name = "treasurer"
        Me.treasurer.Size = New System.Drawing.Size(100, 20)
        Me.treasurer.TabIndex = 3
        '
        'SOSE
        '
        Me.SOSE.Location = New System.Drawing.Point(323, 48)
        Me.SOSE.Name = "SOSE"
        Me.SOSE.Size = New System.Drawing.Size(100, 20)
        Me.SOSE.TabIndex = 4
        '
        'SOMB
        '
        Me.SOMB.Location = New System.Drawing.Point(323, 92)
        Me.SOMB.Name = "SOMB"
        Me.SOMB.Size = New System.Drawing.Size(100, 20)
        Me.SOMB.TabIndex = 5
        '
        'irep
        '
        Me.irep.Location = New System.Drawing.Point(323, 142)
        Me.irep.Name = "irep"
        Me.irep.Size = New System.Drawing.Size(100, 20)
        Me.irep.TabIndex = 6
        '
        'pres
        '
        Me.pres.Location = New System.Drawing.Point(120, 48)
        Me.pres.Name = "pres"
        Me.pres.Size = New System.Drawing.Size(100, 20)
        Me.pres.TabIndex = 7
        '
        'dpres
        '
        Me.dpres.Location = New System.Drawing.Point(120, 92)
        Me.dpres.Name = "dpres"
        Me.dpres.Size = New System.Drawing.Size(100, 20)
        Me.dpres.TabIndex = 8
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(120, 142)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(100, 20)
        Me.sec.TabIndex = 9
        '
        'tre
        '
        Me.tre.Location = New System.Drawing.Point(120, 196)
        Me.tre.Name = "tre"
        Me.tre.Size = New System.Drawing.Size(100, 20)
        Me.tre.TabIndex = 10
        '
        'sosen
        '
        Me.sosen.Location = New System.Drawing.Point(430, 47)
        Me.sosen.Name = "sosen"
        Me.sosen.Size = New System.Drawing.Size(100, 20)
        Me.sosen.TabIndex = 11
        '
        'sombn
        '
        Me.sombn.Location = New System.Drawing.Point(430, 92)
        Me.sombn.Name = "sombn"
        Me.sombn.Size = New System.Drawing.Size(100, 20)
        Me.sombn.TabIndex = 12
        '
        'irepn
        '
        Me.irepn.Location = New System.Drawing.Point(430, 142)
        Me.irepn.Name = "irepn"
        Me.irepn.Size = New System.Drawing.Size(100, 20)
        Me.irepn.TabIndex = 13
        '
        'dataform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 261)
        Me.Controls.Add(Me.irepn)
        Me.Controls.Add(Me.sombn)
        Me.Controls.Add(Me.sosen)
        Me.Controls.Add(Me.tre)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.dpres)
        Me.Controls.Add(Me.pres)
        Me.Controls.Add(Me.irep)
        Me.Controls.Add(Me.SOMB)
        Me.Controls.Add(Me.SOSE)
        Me.Controls.Add(Me.treasurer)
        Me.Controls.Add(Me.seceretary)
        Me.Controls.Add(Me.dpresident)
        Me.Controls.Add(Me.president)
        Me.Name = "dataform"
        Me.Text = "dataform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents president As TextBox
    Friend WithEvents dpresident As TextBox
    Friend WithEvents seceretary As TextBox
    Friend WithEvents treasurer As TextBox
    Friend WithEvents SOSE As TextBox
    Friend WithEvents SOMB As TextBox
    Friend WithEvents irep As TextBox
    Friend WithEvents pres As TextBox
    Friend WithEvents dpres As TextBox
    Friend WithEvents sec As TextBox
    Friend WithEvents tre As TextBox
    Friend WithEvents sosen As TextBox
    Friend WithEvents sombn As TextBox
    Friend WithEvents irepn As TextBox
End Class
