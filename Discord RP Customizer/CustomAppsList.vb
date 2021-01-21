Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CustomAppsList
    Private Sub CustomAppsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
    End Sub

    Public Function Refresh()
        ListView1.Items.Clear()
        Dim list As List(Of Utils.Collections.ClientsCollection) = JsonConvert.DeserializeObject(Of List(Of Utils.Collections.ClientsCollection))(FileIO.FileSystem.ReadAllText(".\Clients.json"))

        For Each item As Utils.Collections.ClientsCollection In list
            ListView1.Items.Add(item.Name).Tag = item.ID
        Next
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustomApp.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count <> 1 Then
            MessageBox.Show("Vous ne devez choisir qu'un client !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form1.SetClient(ListView1.SelectedItems(0).Tag)
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class