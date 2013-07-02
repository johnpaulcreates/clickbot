Public Class ControlContainer
    'this assumes that all control are the same size.

    Public Sub AddControl(NewControl As ctlClickBotAction)

        Me.Controls.Add(NewControl)
        NewControl.Top = NewControl.Height * (Me.Controls.Count - 1)
        NewControl.Left = 0

        AddHandler NewControl.Remove, AddressOf ct_Remove

    End Sub

    Private Sub ControlContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ct_Remove(contrl As ctlClickBotAction)

        Me.Controls.Remove(contrl)
        'need to move the remaining controls up one
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim ctl As ctlClickBotAction = Me.Controls(i)
            ctl.Top = i * ctl.Height
        Next



    End Sub
End Class
