Public Class Dog
    Inherits Animal

    Public Property Nose As String = "丸"

    Public Overrides Function Sing() As Image
        Return My.Resources.DogCookieSing
    End Function

    Public Overrides Function Reset() As Image
        Return My.Resources.DogCookie
    End Function

End Class
