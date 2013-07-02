Public Class ClickBotAction

    Public Event Update()

    Public Sub New(Location As System.Drawing.Point, DelayAfter As Integer, Repeat As Integer)
        oLocation = Location
        iDelayAfter = DelayAfter
        iRepeat = Repeat
    End Sub

    Private oLocation As System.Drawing.Point
    Public ReadOnly Property Location() As System.Drawing.Point
        Get
            Return oLocation
        End Get
    End Property

    Private iDelayAfter As Integer
    Public Property DelayAfter() As Integer
        Get
            Return iDelayAfter
        End Get
        Set(ByVal value As Integer)
            iDelayAfter = value
        End Set
    End Property

    Private iRepeat As Integer
    Public Property Repeat() As Integer
        Get
            Return iRepeat
        End Get
        Set(ByVal value As Integer)
            iRepeat = value
        End Set
    End Property

    Public Function Status() As String

        Return ""
    End Function

End Class
