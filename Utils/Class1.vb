Imports System.Resources
Imports Newtonsoft.Json
Imports Utils.Collections
Imports DiscordRPC

Public Class Collections

    Class ClientsCollection
        Public Property Name As String
        Public Property ID As String
    End Class

    Class RPCollection
        Public Property Name As String
        Public Property ClientID As String
        Public Property Line1 As String
        Public Property Line2 As String
        Public Property StartTimestamp As Date?
        Public Property ImageKey As String
    End Class

End Class

Public Class Saving

    Public Shared Function Save(filename As String, rp As RPCollection)
        Dim txt As String = JsonConvert.SerializeObject(rp, Formatting.Indented)
        If Not FileIO.FileSystem.FileExists(filename) Then
            System.IO.File.CreateText(filename).Close()
        End If
        FileIO.FileSystem.WriteAllText(filename, txt, False)
        Return True
    End Function

    Public Shared Function Open(filename As String) As RPCollection
        Dim json As RPCollection = JsonConvert.DeserializeObject(Of RPCollection)(FileIO.FileSystem.ReadAllText(filename))
        Return json
    End Function

End Class

Public Class Language

    Public Shared res As New ResXResourceSet("Lang\" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".resx")

End Class