Public Class Cat
    Inherits Animal

    Public Property Ear As String = "丸"

    Public Overrides Function Sing() As Image
        Return My.Resources.CatCookieSing
    End Function

    Public Overrides Function Reset() As Image
        Return My.Resources.CatCookie
    End Function

End Class
