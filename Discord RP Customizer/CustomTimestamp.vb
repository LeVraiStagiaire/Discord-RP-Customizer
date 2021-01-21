Public Class CustomTimestamp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tstamp As DiscordRPC.Timestamps = Form1.Tstamp
        tstamp.Start = New Date(MonthCalendar1.SelectionRange.Start.Year, MonthCalendar1.SelectionRange.Start.Month, MonthCalendar1.SelectionRange.Start.Day, MaskedTextBox1.Text.Substring(0, 2), MaskedTextBox1.Text.Substring(3), 0)
        Form1.Label6.Text = "Depuis : " + tstamp.Start.Value.Hour.ToString + ":" + tstamp.Start.Value.Minute.ToString
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub CustomTimestamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fnt As New Font("Whitney Medium", 8.5, FontStyle.Regular)
        Form1.Font = fnt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MonthCalendar1.SelectionRange.Start = Date.Now
        MaskedTextBox1.Text = Date.Now.Hour.ToString + ":" + Date.Now.Minute.ToString
    End Sub
End Class