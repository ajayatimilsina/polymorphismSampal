Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxDog.Click, PictureBoxCat.Click, PictureBoxBird.Click

    End Sub

    Private Sub ButtonSing_Click(sender As Object, e As EventArgs) Handles ButtonSing.Click
        animalCookis = New Dog（）
        PictureBoxDog.Image = animalCookis.Sing()
        animalCookis = New Cat（）
        PictureBoxCat.Image = animalCookis.Sing()
        animalCookis = New Bird（）
        PictureBoxBird.Image = animalCookis.Sing()

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        animalCookis = New Dog（）
        PictureBoxDog.Image = animalCookis.Reset()
        animalCookis = New Cat（）
        PictureBoxCat.Image = animalCookis.Reset()
        animalCookis = New Bird（）
        PictureBoxBird.Image = animalCookis.Reset()

    End Sub
End Class
