Public Class Bird
    Inherits Animal
    Public Property Beak As String = "三角"
    Public Overrides Function Sing() As Image
        Return My.Resources.BirdcookieSing
    End Function
    Public Overrides Function Reset() As Image
        Return My.Resources.Birdcookie
    End Function

End Class
