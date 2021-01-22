Public Class ImageChooser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ListView1.SelectedItems.Item(0).Index
            Case 0
                Form1.imagekey = ""
            Case 1
                Form1.imagekey = "minecraft"
        End Select
        Form1.PictureBox3.Image = ImageList1.Images.Item(ListView1.SelectedItems(0).ImageKey)
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.imagekey = InputBox("Entrez la clé (key) de l'image : ", "Image personnalisée")
        Close()
    End Sub

    Private Sub ImageChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class