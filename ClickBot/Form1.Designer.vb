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
        Me.btnCaptureLocation = New System.Windows.Forms.Button()
        Me.ControlContainer1 = New ClickBot.ControlContainer()
        Me.btnPerformAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCaptureLocation
        '
        Me.btnCaptureLocation.Location = New System.Drawing.Point(12, 12)
        Me.btnCaptureLocation.Name = "btnCaptureLocation"
        Me.btnCaptureLocation.Size = New System.Drawing.Size(134, 86)
        Me.btnCaptureLocation.TabIndex = 0
        Me.btnCaptureLocation.Text = "Capture"
        Me.btnCaptureLocation.UseVisualStyleBackColor = True
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlContainer1.AutoScroll = True
        Me.ControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ControlContainer1.Location = New System.Drawing.Point(12, 104)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(701, 150)
        Me.ControlContainer1.TabIndex = 2
        '
        'btnPerformAll
        '
        Me.btnPerformAll.Location = New System.Drawing.Point(576, 12)
        Me.btnPerformAll.Name = "btnPerformAll"
        Me.btnPerformAll.Size = New System.Drawing.Size(134, 86)
        Me.btnPerformAll.TabIndex = 3
        Me.btnPerformAll.TabStop = False
        Me.btnPerformAll.Text = "Perform All"
        Me.btnPerformAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 265)
        Me.Controls.Add(Me.btnPerformAll)
        Me.Controls.Add(Me.ControlContainer1)
        Me.Controls.Add(Me.btnCaptureLocation)
        Me.Name = "Form1"
        Me.Text = "ClickBot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCaptureLocation As System.Windows.Forms.Button
    Friend WithEvents ControlContainer1 As ClickBot.ControlContainer
    Friend WithEvents btnPerformAll As System.Windows.Forms.Button

End Class
