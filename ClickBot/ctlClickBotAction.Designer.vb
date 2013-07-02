<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlClickBotAction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtMouseLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudDelayAfter = New System.Windows.Forms.NumericUpDown()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudRepeat = New System.Windows.Forms.NumericUpDown()
        Me.llblRemove = New System.Windows.Forms.LinkLabel()
        CType(Me.nudDelayAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMouseLocation
        '
        Me.txtMouseLocation.Location = New System.Drawing.Point(100, 5)
        Me.txtMouseLocation.Name = "txtMouseLocation"
        Me.txtMouseLocation.Size = New System.Drawing.Size(100, 20)
        Me.txtMouseLocation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mouse Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delay After (sec):"
        '
        'nudDelayAfter
        '
        Me.nudDelayAfter.Location = New System.Drawing.Point(300, 6)
        Me.nudDelayAfter.Name = "nudDelayAfter"
        Me.nudDelayAfter.Size = New System.Drawing.Size(67, 20)
        Me.nudDelayAfter.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(497, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "lblStatus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Repeat:"
        '
        'nudRepeat
        '
        Me.nudRepeat.Location = New System.Drawing.Point(424, 6)
        Me.nudRepeat.Name = "nudRepeat"
        Me.nudRepeat.Size = New System.Drawing.Size(67, 20)
        Me.nudRepeat.TabIndex = 6
        '
        'llblRemove
        '
        Me.llblRemove.AutoSize = True
        Me.llblRemove.Location = New System.Drawing.Point(-3, 8)
        Me.llblRemove.Name = "llblRemove"
        Me.llblRemove.Size = New System.Drawing.Size(14, 13)
        Me.llblRemove.TabIndex = 7
        Me.llblRemove.TabStop = True
        Me.llblRemove.Text = "X"
        '
        'ctlClickBotAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.llblRemove)
        Me.Controls.Add(Me.nudRepeat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.nudDelayAfter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMouseLocation)
        Me.Name = "ctlClickBotAction"
        Me.Size = New System.Drawing.Size(692, 32)
        CType(Me.nudDelayAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMouseLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudDelayAfter As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudRepeat As System.Windows.Forms.NumericUpDown
    Friend WithEvents llblRemove As System.Windows.Forms.LinkLabel

End Class
