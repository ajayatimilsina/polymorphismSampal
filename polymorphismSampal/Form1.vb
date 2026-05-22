Public Class Form1
    ' animalCookies लाई यहाँ Declare गर्नुपर्छ
    Dim animalCookies As Animal

    Private Sub ButtonSing_Click(sender As Object, e As EventArgs) Handles ButtonSing.Click
        animalCookies = New Dog() ' () लाई अंग्रेजी बनाउने
        PictureBoxDog.Image = animalCookies.Sing()
        animalCookies = New Cat()
        PictureBoxCat.Image = animalCookies.Sing()
        animalCookies = New Bird()
        PictureBoxBird.Image = animalCookies.Sing()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        animalCookies = New Dog()
        PictureBoxDog.Image = animalCookies.Reset()
        animalCookies = New Cat()
        PictureBoxCat.Image = animalCookies.Reset()
        animalCookies = New Bird()
        PictureBoxBird.Image = animalCookies.Reset()
    End Sub
End Class