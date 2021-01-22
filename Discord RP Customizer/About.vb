Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fnt As New Font("Whitney Medium", 12, FontStyle.Regular)
        Dim fnt2 As New Font("Whitney Medium", 8.5, FontStyle.Regular)
        Label1.Font = fnt
        Label2.Font = fnt2
    End Sub
End Class