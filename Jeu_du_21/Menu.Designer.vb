<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemJouer = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRegles = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemProgramme})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItemProgramme
        '
        Me.MenuItemProgramme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemJouer})
        Me.MenuItemProgramme.Name = "MenuItemProgramme"
        Me.MenuItemProgramme.Size = New System.Drawing.Size(101, 24)
        Me.MenuItemProgramme.Text = "Programme"
        '
        'MenuItemJouer
        '
        Me.MenuItemJouer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem})
        Me.MenuItemJouer.Name = "MenuItemJouer"
        Me.MenuItemJouer.Size = New System.Drawing.Size(224, 26)
        Me.MenuItemJouer.Text = "Jouer au jeu du 21!"
        '
        'CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem
        '
        Me.CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem.Name = "CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem"
        Me.CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem.Size = New System.Drawing.Size(552, 26)
        Me.CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem.Text = "Commencer le jeu ne fermera pas cette fenêtre qui contient les règles"
        '
        'lblRegles
        '
        Me.lblRegles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegles.ForeColor = System.Drawing.Color.Black
        Me.lblRegles.Location = New System.Drawing.Point(135, 132)
        Me.lblRegles.Name = "lblRegles"
        Me.lblRegles.Size = New System.Drawing.Size(706, 257)
        Me.lblRegles.TabIndex = 1
        Me.lblRegles.Text = resources.GetString("lblRegles.Text")
        '
        'lblIntro
        '
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblIntro.Location = New System.Drawing.Point(50, 62)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(860, 61)
        Me.lblIntro.TabIndex = 2
        Me.lblIntro.Text = "Bienvenu au jeu du 21! Tu connais les règles? Clique sur l'icône en haut à gauche" &
    " pour démarrer la partie. Si tu ne les connaît pas, lis le parapraphe ci-dessous" &
    ". Bonne chance!"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 398)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.lblRegles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuItemProgramme As ToolStripMenuItem
    Friend WithEvents MenuItemJouer As ToolStripMenuItem
    Friend WithEvents CommencerLeJeuNeFermeraPasCetteFenêtreQuiContientLesRèglesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRegles As Label
    Friend WithEvents lblIntro As Label
End Class
