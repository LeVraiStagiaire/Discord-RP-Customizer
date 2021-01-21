Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Net
Imports DiscordRPC
Imports DiscordRPC.Message
Imports Microsoft.WindowsAPICodePack
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class Form1

    Dim WithEvents RP As New DiscordRpcClient("797585769027862548")
    Public Shared Tstamp As New Timestamps
    Public Shared imagekey As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetClient("797585769027862548")
    End Sub

    Private Sub RP_OnReady(sender As Object, args As ReadyMessage) Handles RP.OnReady
        Dim image As Bitmap
        Using mem As New System.IO.MemoryStream(New WebClient().DownloadData(RP.CurrentUser.GetAvatarURL(DiscordRPC.User.AvatarFormat.PNG)))
            image = Drawing.Image.FromStream(mem)
        End Using
        Dim image2 As New Bitmap(image.Width, image.Height)

        Using g = Graphics.FromImage(image2)
            Dim path As New GraphicsPath

            path.AddEllipse(0, 0, image2.Width, image2.Height)

            Dim reg As New Region(path)

            g.Clip = reg
            g.DrawImage(image, Point.Empty)
        End Using

        PictureBox2.Image = image2
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = InputBox("Veuillez entrer un texte pour la première ligne : ", "Changer de texte", Label4.Text)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = InputBox("Veuillez entrer un texte pour la deuxième ligne : ", "Changer de texte", Label5.Text)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        CustomTimestamp.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpcontent As New RichPresence
        rpcontent.Details = Label4.Text
        rpcontent.State = Label5.Text
        rpcontent.Timestamps = Tstamp
        rpcontent.Assets = New Assets With {
            .LargeImageKey = imagekey
        }

        RP.SetPresence(rpcontent)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ImageChooser.ShowDialog()
    End Sub

    Private Sub ApplicationPersonnaliséeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationPersonnaliséeToolStripMenuItem.Click
        CustomAppsList.ShowDialog()
    End Sub

    Public Function SetClient(id As String)
        RP = New DiscordRpcClient(id)
        RP.Initialize()
        Timer1.Start()
    End Function

    Private Sub EnleverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnleverToolStripMenuItem.Click
        RP.ClearPresence()
    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        e.Cancel = True
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.Focus()
    End Sub

    Private Sub EnleverLeRPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnleverLeRPToolStripMenuItem.Click
        RP.ClearPresence()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RP.IsInitialized Then
            Threading.Thread.Sleep(1000)
            Label1.Text = RP.CurrentUser.Username.ToString() + "#" + RP.CurrentUser.Discriminator.ToString()
            Dim fnt As New Font("Whitney Medium", 10, FontStyle.Regular)
            Dim fnt2 As New Font("Whitney Medium", 10, FontStyle.Bold)
            Label1.Font = fnt2
            Label2.Font = fnt
            Label3.Font = fnt2
            Label4.Font = fnt
            Label5.Font = fnt
            Label6.Font = fnt
            Button1.Font = fnt2
            Timer1.Stop()
        End If
    End Sub
End Class
