Imports System.Resources

Public Class Collections

    Class ClientsCollection
        Public Property Name As String
        Public Property ID As String
    End Class

End Class

Public Class Language

    Public Shared res As New ResXResourceSet("Lang\" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".resx")

End Class