Public Class ctlClickBotAction

    Public Event Remove(contrl As ctlClickBotAction)

    Private WithEvents oAction As ClickBotAction

    Private Sub ClickBotAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Property Action() As ClickBotAction
        Get
            Return oAction
        End Get
        Set(ByVal value As ClickBotAction)
            oAction = value
            RefreshView()
        End Set
    End Property

    Private Sub RefreshView()
        If Action Is Nothing Then
            txtMouseLocation.Text = ""
            nudDelayAfter.Value = 0
            nudRepeat.Value = 0
            lblStatus.Text = ""
        Else
            txtMouseLocation.Text = oAction.Location.ToString
            nudDelayAfter.Value = oAction.DelayAfter
            nudRepeat.Value = oAction.Repeat
            lblStatus.Text = oAction.Status
        End If

    End Sub

    Private Sub oAction_Update() Handles oAction.Update
        RefreshView()
    End Sub

    Private Sub llblRemove_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRemove.LinkClicked
        RaiseEvent Remove(Me)
    End Sub
End Class
