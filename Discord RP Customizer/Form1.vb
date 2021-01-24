Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Net
Imports DiscordRPC
Imports DiscordRPC.Message
Imports Microsoft.WindowsAPICodePack.Dialogs.Controls
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Utils.Language

Public Class Form1

    Dim WithEvents RP As New DiscordRpcClient("797585769027862548")
    Public Shared Tstamp As New Timestamps With {
        .Start = Now
    }
    Public Shared imagekey As String
    Public Shared saved As Boolean = True
    Public Shared filename As String = Nothing
    Dim WithEvents td As New TaskDialog With {
        .Caption = res.GetString("NotSaved_Caption"),
        .Icon = TaskDialogStandardIcon.Warning,
        .InstructionText = res.GetString("NotSaved_InstructionText"),
        .Text = res.GetString("NotSaved_Text")
    }
    Dim WithEvents savenexit As New TaskDialogButton("savenexit", res.GetString("SaveAndExit"))
    Dim WithEvents dontsave As New TaskDialogButton("dontsave", res.GetString("DontSave"))
    Dim WithEvents cancel As New TaskDialogButton("cancel", res.GetString("Cancel"))
    Dim WithEvents save As New CommonSaveFileDialog() With {
        .Title = res.GetString("MNU_SaveAs"),
        .OverwritePrompt = True,
        .DefaultExtension = ".drp",
        .EnsurePathExists = True
    }
    Dim WithEvents nameLabel As New CommonFileDialogLabel(res.GetString("Name") + " : ")
    Dim WithEvents name1 As New CommonFileDialogTextBox("My RP")
    Dim WithEvents open As New CommonOpenFileDialog() With {
        .EnsureFileExists = True,
        .DefaultExtension = "drp",
        .EnsureValidNames = True,
        .Multiselect = False,
        .Title = res.GetString("MNU_Open")
    }
    Dim WithEvents notsaved As New TaskDialog With {
        .Caption = res.GetString("SaveAndContinue_Caption"),
        .Icon = TaskDialogStandardIcon.Warning,
        .InstructionText = res.GetString("SaveAndContinue_InstructionText"),
        .Text = res.GetString("SaveAndContinue_Text")
    }
    Dim WithEvents savencontinue As New TaskDialogButton("savencontinue", res.GetString("SaveAndContinue"))
    Dim WithEvents dontsave2 As New TaskDialogButton("dontsave1", res.GetString("DontSave"))
    Dim WithEvents cancel2 As New TaskDialogButton("cancel1", res.GetString("Cancel"))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        td.Controls.Add(savenexit)
        td.Controls.Add(dontsave)
        td.Controls.Add(cancel)
        save.Controls.Add(nameLabel)
        save.Controls.Add(name1)
        notsaved.Controls.Add(savencontinue)
        notsaved.Controls.Add(dontsave2)
        notsaved.Controls.Add(cancel2)
        save.Filters.Add(New CommonFileDialogFilter("Discord RP file", "*.drp"))
        open.Filters.Add(New CommonFileDialogFilter("Discord RP file", "*.drp"))
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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = InputBox(res.GetString("Line1Input"), res.GetString("ChangeText"), Label4.Text)
        saved = False
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = InputBox(res.GetString("Line2Input"), res.GetString("ChangeText"), Label5.Text)
        saved = False
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
            .LargeImageKey = imagekey,
            .LargeImageText = "Made with Discord RP Customizer - https://floyoutube54.github.io/Discord-RP-Customizer"
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
        If saved = False Then
            td.Show()
            Exit Sub
        End If
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        e.Cancel = True
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.Focus()
    End Sub

    Private Sub EnleverLeRPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnleverToolStripMenuItem.Click
        RP.ClearPresence()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If Not saved Then
            td.Show()
            Exit Sub
        End If
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RP.IsInitialized Then
            Threading.Thread.Sleep(1000)
            For i = 0 To 10
                If IsNothing(RP.CurrentUser) Then
                    Threading.Thread.Sleep(500)
                Else
                    Label1.Text = RP.CurrentUser.Username.ToString() + "#" + RP.CurrentUser.Discriminator.ToString()
                    Exit For
                End If
            Next
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

    Private Sub SiteWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiteWebToolStripMenuItem.Click
        Process.Start("http://aorracer.com/2Aa4")
    End Sub

    Private Sub MisesÀJoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisesÀJoursToolStripMenuItem.Click
        Process.Start("http://aorracer.com/2Ao6")
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub PremiumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PremiumToolStripMenuItem.Click
        Process.Start("https://www.paypal.com/donate?hosted_button_id=ZXWXJHQFH25NQ")
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        td.Close()
    End Sub

    Private Sub dontsave_Click(sender As Object, e As EventArgs) Handles dontsave.Click
        td.Close()
        End
    End Sub

    Private Sub savenexit_Click(sender As Object, e As EventArgs) Handles savenexit.Click
        Throw New NotImplementedException("Non-implémenté")
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        If filename = Nothing Then
            If save.ShowDialog() = CommonFileDialogResult.Ok Then
                filename = save.FileAsShellObject.ParsingName
                Utils.Saving.Save(save.FileAsShellObject.ParsingName, New Utils.Collections.RPCollection With {
                    .ClientID = RP.ApplicationID,
                    .ImageKey = imagekey,
                    .Line1 = Label4.Text,
                    .Line2 = Label5.Text,
                    .Name = name1.Text,
                    .StartTimestamp = Tstamp.Start
                })
                saved = True
            End If
        Else
            Utils.Saving.Save(filename, New Utils.Collections.RPCollection With {
                .ClientID = RP.ApplicationID,
                .ImageKey = imagekey,
                .Line1 = Label4.Text,
                .Line2 = Label5.Text,
                .Name = name1.Text,
                .StartTimestamp = Tstamp.Start
            })
            saved = True
        End If
    End Sub

    Private Sub save_FileOk(sender As Object, e As CancelEventArgs) Handles save.FileOk
        filename = save.FileName
        Utils.Saving.Save(save.FileAsShellObject.ParsingName, New Utils.Collections.RPCollection With {
            .ClientID = RP.ApplicationID,
            .ImageKey = imagekey,
            .Line1 = Label4.Text,
            .Line2 = Label5.Text,
            .Name = name1.Text,
            .StartTimestamp = Tstamp.Start
        })
        saved = True
    End Sub

    Private Sub EnregistrersousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrersousToolStripMenuItem.Click
        If save.ShowDialog() = CommonFileDialogResult.Ok Then
            filename = save.FileAsShellObject.ParsingName
            Utils.Saving.Save(save.FileAsShellObject.ParsingName, New Utils.Collections.RPCollection With {
                    .ClientID = RP.ApplicationID,
                    .ImageKey = imagekey,
                    .Line1 = Label4.Text,
                    .Line2 = Label5.Text,
                    .Name = name1.Text,
                    .StartTimestamp = Tstamp.Start
                })
            saved = True
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        If Not saved Then
            notsaved.Show()
        Else
            If open.ShowDialog() = CommonFileDialogResult.Ok Then
                filename = open.FileAsShellObject.ParsingName
                Dim rp As Utils.Collections.RPCollection = Utils.Saving.Open(open.FileAsShellObject.ParsingName)
                Tstamp.Start = rp.StartTimestamp
                Label4.Text = rp.Line1
                Label5.Text = rp.Line2
                imagekey = rp.ImageKey
                SetClient(rp.ClientID)
                Text = "Discord RP Customizer - " + rp.Name
            End If
        End If
    End Sub

    Private Sub cancel2_Click(sender As Object, e As EventArgs) Handles cancel2.Click
        notsaved.Close()
    End Sub

    Private Sub dontsave2_Click(sender As Object, e As EventArgs) Handles dontsave2.Click
        If open.ShowDialog() = CommonFileDialogResult.Ok Then
            filename = open.FileAsShellObject.ParsingName
            Dim rp As Utils.Collections.RPCollection = Utils.Saving.Open(open.FileAsShellObject.ParsingName)
            Tstamp.Start = rp.StartTimestamp
            Label4.Text = rp.Line1
            Label5.Text = rp.Line2
            imagekey = rp.ImageKey
            SetClient(rp.ClientID)
            Text = "Discord RP Customizer - " + rp.Name
        End If
    End Sub

    Private Sub savencontinue_Click(sender As Object, e As EventArgs) Handles savencontinue.Click
        If saved Then
            Utils.Saving.Save(filename, New Utils.Collections.RPCollection With {
                .ClientID = RP.ApplicationID,
                .ImageKey = imagekey,
                .Line1 = Label4.Text,
                .Line2 = Label5.Text,
                .Name = name1.Text,
                .StartTimestamp = Tstamp.Start
            })
            saved = True
        Else
            If save.ShowDialog() = CommonFileDialogResult.Ok Then
                filename = save.FileAsShellObject.ParsingName
                Utils.Saving.Save(save.FileAsShellObject.ParsingName, New Utils.Collections.RPCollection With {
                    .ClientID = RP.ApplicationID,
                    .ImageKey = imagekey,
                    .Line1 = Label4.Text,
                    .Line2 = Label5.Text,
                    .Name = name1.Text,
                    .StartTimestamp = Tstamp.Start
                })
                saved = True
            End If
        End If
        If open.ShowDialog() = CommonFileDialogResult.Ok Then
            filename = open.FileAsShellObject.ParsingName
            Dim rp As Utils.Collections.RPCollection = Utils.Saving.Open(open.FileAsShellObject.ParsingName)
            Tstamp.Start = rp.StartTimestamp
            Label4.Text = rp.Line1
            Label5.Text = rp.Line2
            imagekey = rp.ImageKey
            SetClient(rp.ClientID)
            Text = "Discord RP Customizer - " + rp.Name
        End If
    End Sub

    Private Sub open_FileOk(sender As Object, e As CancelEventArgs) Handles open.FileOk
        Dim rp As Utils.Collections.RPCollection = Utils.Saving.Open(open.FileName)
        Tstamp.Start = rp.StartTimestamp
        Label4.Text = rp.Line1
        Label5.Text = rp.Line2
        imagekey = rp.ImageKey
        SetClient(rp.ClientID)
        Text = "Discord RP Customizer - " + rp.Name
    End Sub
End Class
