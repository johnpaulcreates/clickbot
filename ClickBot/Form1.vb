Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim temp As New ctlClickBotAction
        ControlContainer1.AddControl(temp)
    End Sub

    Private Sub btnCaptureLocation_Click(sender As Object, e As EventArgs) Handles btnCaptureLocation.Click
        Dim oPos As Point = Cursor.Position
        Dim Action As New ClickBotAction(oPos, 0, 0)

        Dim ctl As New ctlClickBotAction
        ctl.Action = Action
        ControlContainer1.AddControl(ctl)

    End Sub
End Class

