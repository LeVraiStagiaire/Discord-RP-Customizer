Imports Utils.Language

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrersousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichPresenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnleverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApplicationPersonnaliséeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiteWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisesÀJoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PremiumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnleverLeRPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.RichPresenceToolStripMenuItem, Me.ToolStripMenuItem5})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(444, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.ToolStripMenuItem1, Me.EnregistrerToolStripMenuItem, Me.EnregistrersousToolStripMenuItem, Me.ToolStripMenuItem2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = res.GetString("MNU_File")
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NouveauToolStripMenuItem.Text = res.GetString("MNU_New")
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OuvrirToolStripMenuItem.Text = res.GetString("MNU_Open")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnregistrerToolStripMenuItem.Text = res.GetString("MNU_Save")
        '
        'EnregistrersousToolStripMenuItem
        '
        Me.EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        Me.EnregistrersousToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnregistrersousToolStripMenuItem.Text = res.GetString("MNU_SaveAs")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = res.GetString("MNU_Exit")
        '
        'RichPresenceToolStripMenuItem
        '
        Me.RichPresenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnleverToolStripMenuItem, Me.ToolStripMenuItem3, Me.ApplicationPersonnaliséeToolStripMenuItem})
        Me.RichPresenceToolStripMenuItem.Name = "RichPresenceToolStripMenuItem"
        Me.RichPresenceToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.RichPresenceToolStripMenuItem.Text = res.GetString("MNU_RP")
        '
        'EnleverToolStripMenuItem
        '
        Me.EnleverToolStripMenuItem.Name = "EnleverToolStripMenuItem"
        Me.EnleverToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EnleverToolStripMenuItem.Text = res.GetString("MNU_Remove")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(207, 6)
        '
        'ApplicationPersonnaliséeToolStripMenuItem
        '
        Me.ApplicationPersonnaliséeToolStripMenuItem.Name = "ApplicationPersonnaliséeToolStripMenuItem"
        Me.ApplicationPersonnaliséeToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ApplicationPersonnaliséeToolStripMenuItem.Text = res.GetString("MNU_CustomApps")
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiteWebToolStripMenuItem, Me.MisesÀJoursToolStripMenuItem, Me.ToolStripMenuItem6, Me.PremiumToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem5.Text = "&?"
        '
        'SiteWebToolStripMenuItem
        '
        Me.SiteWebToolStripMenuItem.Name = "SiteWebToolStripMenuItem"
        Me.SiteWebToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SiteWebToolStripMenuItem.Text = res.GetString("MNU_Website")
        '
        'MisesÀJoursToolStripMenuItem
        '
        Me.MisesÀJoursToolStripMenuItem.Name = "MisesÀJoursToolStripMenuItem"
        Me.MisesÀJoursToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MisesÀJoursToolStripMenuItem.Text = res.GetString("MNU_Updates")
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(139, 6)
        '
        'PremiumToolStripMenuItem
        '
        Me.PremiumToolStripMenuItem.Name = "PremiumToolStripMenuItem"
        Me.PremiumToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PremiumToolStripMenuItem.Text = res.GetString("MNU_Donate")
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AProposToolStripMenuItem.Text = res.GetString("MNU_About")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status personnalisés pas encore supportés !"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(180, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discord RP Customizer"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(180, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = res.GetString("Line1")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(180, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = res.GetString("Line2")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(180, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = res.GetString("Since") & " 00:00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(97, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = res.GetString("Apply")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Discord RP Customizer"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnleverLeRPToolStripMenuItem, Me.ToolStripMenuItem4, Me.QuitterToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 54)
        '
        'EnleverLeRPToolStripMenuItem
        '
        Me.EnleverLeRPToolStripMenuItem.Name = "EnleverLeRPToolStripMenuItem"
        Me.EnleverLeRPToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EnleverLeRPToolStripMenuItem.Text = "&Enlever le RP"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(138, 6)
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.QuitterToolStripMenuItem1.Text = res.GetString("MNU_Exit")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(97, 266)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(183, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Discord_RP_Customizer.My.Resources.Resources.Discord_RP_Template
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 394)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discord RP Customizer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichPresenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnleverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ApplicationPersonnaliséeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EnleverLeRPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents SiteWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisesÀJoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents PremiumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
End Class