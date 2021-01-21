Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CustomApp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Clipboard.GetText(TextDataFormat.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://discord.com/developers")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim item As New Utils.Collections.ClientsCollection With {
            .ID = TextBox1.Text,
            .Name = InputBox("Veuillez entrer un nom pour ce client. Nous vous recommandons d'utiliser le nom que vous avez utilisé pour créer le client sur l'espace développeurs de Discord : ")
        }
        Dim list As List(Of Utils.Collections.ClientsCollection) = JsonConvert.DeserializeObject(Of List(Of Utils.Collections.ClientsCollection))(FileIO.FileSystem.ReadAllText(".\Clients.json"))

        list.Add(item)

        FileIO.FileSystem.WriteAllText(".\Clients.json", JsonConvert.SerializeObject(list, Formatting.Indented), False)

        CustomAppsList.Refresh()
        Close()
    End Sub

    Private Sub CustomApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fnt As New Font("Whitney Medium", 8.5, FontStyle.Regular)
        Dim fnt2 As New Font("Whitney Medium", 18, FontStyle.Bold)
        Label1.Font = fnt2
        Label2.Font = fnt
        Label3.Font = fnt2
        Label4.Font = fnt
        Label5.Font = fnt2
        Label6.Font = fnt
    End Sub
End Class