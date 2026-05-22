Public Class Animal
    Public Property color As String = "茶"
    Public Property smell As String = "コーヒー"
    Public Property Flavor As String = "チョコレート"


    Public Overridable Function Sing() As Image
        Return My.Resources.AnimalCookieSing
    End Function

    Public Overridable Function Reset() As Image
        Return My.Resources.AnimalCookie
    End Function

End Class
