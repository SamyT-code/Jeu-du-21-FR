<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJeu21
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPigerCartes = New System.Windows.Forms.Button()
        Me.lblCarte1 = New System.Windows.Forms.Label()
        Me.lblCarte2 = New System.Windows.Forms.Label()
        Me.lblCarte3 = New System.Windows.Forms.Label()
        Me.lblCarte4 = New System.Windows.Forms.Label()
        Me.lblCarte5 = New System.Windows.Forms.Label()
        Me.lblCarteOrdi1 = New System.Windows.Forms.Label()
        Me.lblCarteOrdi2 = New System.Windows.Forms.Label()
        Me.lblCarteOrdi3 = New System.Windows.Forms.Label()
        Me.btnRevelerCartes = New System.Windows.Forms.Button()
        Me.btnNouvellePartie = New System.Windows.Forms.Button()
        Me.lblSomme = New System.Windows.Forms.Label()
        Me.lblSommeOrdi = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblCartesJoueur = New System.Windows.Forms.Label()
        Me.lblCartesOrdinateur = New System.Windows.Forms.Label()
        Me.lblCarte7 = New System.Windows.Forms.Label()
        Me.lblCarte6 = New System.Windows.Forms.Label()
        Me.lblScoreJoueur = New System.Windows.Forms.Label()
        Me.lblScoreOrdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPigerCartes
        '
        Me.btnPigerCartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPigerCartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPigerCartes.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnPigerCartes.Location = New System.Drawing.Point(12, 383)
        Me.btnPigerCartes.Name = "btnPigerCartes"
        Me.btnPigerCartes.Size = New System.Drawing.Size(167, 84)
        Me.btnPigerCartes.TabIndex = 0
        Me.btnPigerCartes.Text = "Piger une carte"
        Me.btnPigerCartes.UseVisualStyleBackColor = False
        '
        'lblCarte1
        '
        Me.lblCarte1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte1.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte1.Location = New System.Drawing.Point(12, 58)
        Me.lblCarte1.Name = "lblCarte1"
        Me.lblCarte1.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte1.TabIndex = 1
        Me.lblCarte1.Visible = False
        '
        'lblCarte2
        '
        Me.lblCarte2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte2.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte2.Location = New System.Drawing.Point(105, 58)
        Me.lblCarte2.Name = "lblCarte2"
        Me.lblCarte2.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte2.TabIndex = 2
        Me.lblCarte2.Visible = False
        '
        'lblCarte3
        '
        Me.lblCarte3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte3.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte3.Location = New System.Drawing.Point(198, 58)
        Me.lblCarte3.Name = "lblCarte3"
        Me.lblCarte3.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte3.TabIndex = 3
        Me.lblCarte3.Visible = False
        '
        'lblCarte4
        '
        Me.lblCarte4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte4.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte4.Location = New System.Drawing.Point(291, 58)
        Me.lblCarte4.Name = "lblCarte4"
        Me.lblCarte4.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte4.TabIndex = 4
        Me.lblCarte4.Visible = False
        '
        'lblCarte5
        '
        Me.lblCarte5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte5.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte5.Location = New System.Drawing.Point(384, 58)
        Me.lblCarte5.Name = "lblCarte5"
        Me.lblCarte5.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte5.TabIndex = 5
        Me.lblCarte5.Visible = False
        '
        'lblCarteOrdi1
        '
        Me.lblCarteOrdi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarteOrdi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteOrdi1.ForeColor = System.Drawing.Color.Navy
        Me.lblCarteOrdi1.Location = New System.Drawing.Point(747, 58)
        Me.lblCarteOrdi1.Name = "lblCarteOrdi1"
        Me.lblCarteOrdi1.Size = New System.Drawing.Size(87, 122)
        Me.lblCarteOrdi1.TabIndex = 6
        Me.lblCarteOrdi1.Text = "?"
        '
        'lblCarteOrdi2
        '
        Me.lblCarteOrdi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarteOrdi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteOrdi2.ForeColor = System.Drawing.Color.Navy
        Me.lblCarteOrdi2.Location = New System.Drawing.Point(840, 58)
        Me.lblCarteOrdi2.Name = "lblCarteOrdi2"
        Me.lblCarteOrdi2.Size = New System.Drawing.Size(87, 122)
        Me.lblCarteOrdi2.TabIndex = 7
        Me.lblCarteOrdi2.Text = "?"
        '
        'lblCarteOrdi3
        '
        Me.lblCarteOrdi3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarteOrdi3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteOrdi3.ForeColor = System.Drawing.Color.Navy
        Me.lblCarteOrdi3.Location = New System.Drawing.Point(933, 58)
        Me.lblCarteOrdi3.Name = "lblCarteOrdi3"
        Me.lblCarteOrdi3.Size = New System.Drawing.Size(87, 122)
        Me.lblCarteOrdi3.TabIndex = 8
        Me.lblCarteOrdi3.Text = "?"
        '
        'btnRevelerCartes
        '
        Me.btnRevelerCartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRevelerCartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevelerCartes.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnRevelerCartes.Location = New System.Drawing.Point(198, 383)
        Me.btnRevelerCartes.Name = "btnRevelerCartes"
        Me.btnRevelerCartes.Size = New System.Drawing.Size(167, 84)
        Me.btnRevelerCartes.TabIndex = 9
        Me.btnRevelerCartes.Text = "Révéler les cartes de l'ordi"
        Me.btnRevelerCartes.UseVisualStyleBackColor = False
        '
        'btnNouvellePartie
        '
        Me.btnNouvellePartie.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNouvellePartie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouvellePartie.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnNouvellePartie.Location = New System.Drawing.Point(384, 383)
        Me.btnNouvellePartie.Name = "btnNouvellePartie"
        Me.btnNouvellePartie.Size = New System.Drawing.Size(167, 84)
        Me.btnNouvellePartie.TabIndex = 10
        Me.btnNouvellePartie.Text = "Nouvelle partie"
        Me.btnNouvellePartie.UseVisualStyleBackColor = False
        '
        'lblSomme
        '
        Me.lblSomme.AutoSize = True
        Me.lblSomme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSomme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSomme.Location = New System.Drawing.Point(12, 249)
        Me.lblSomme.Name = "lblSomme"
        Me.lblSomme.Size = New System.Drawing.Size(123, 29)
        Me.lblSomme.TabIndex = 11
        Me.lblSomme.Text = "Somme : "
        '
        'lblSommeOrdi
        '
        Me.lblSommeOrdi.AutoSize = True
        Me.lblSommeOrdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSommeOrdi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSommeOrdi.Location = New System.Drawing.Point(755, 249)
        Me.lblSommeOrdi.Name = "lblSommeOrdi"
        Me.lblSommeOrdi.Size = New System.Drawing.Size(262, 29)
        Me.lblSommeOrdi.TabIndex = 12
        Me.lblSommeOrdi.Text = "Somme ordinateur : ?"
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Red
        Me.btnQuitter.Location = New System.Drawing.Point(923, 417)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(130, 50)
        Me.btnQuitter.TabIndex = 13
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblCartesJoueur
        '
        Me.lblCartesJoueur.AutoSize = True
        Me.lblCartesJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartesJoueur.ForeColor = System.Drawing.Color.Blue
        Me.lblCartesJoueur.Location = New System.Drawing.Point(6, 9)
        Me.lblCartesJoueur.Name = "lblCartesJoueur"
        Me.lblCartesJoueur.Size = New System.Drawing.Size(173, 32)
        Me.lblCartesJoueur.TabIndex = 14
        Me.lblCartesJoueur.Text = "Tes cartes :"
        '
        'lblCartesOrdinateur
        '
        Me.lblCartesOrdinateur.AutoSize = True
        Me.lblCartesOrdinateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartesOrdinateur.ForeColor = System.Drawing.Color.Blue
        Me.lblCartesOrdinateur.Location = New System.Drawing.Point(741, 9)
        Me.lblCartesOrdinateur.Name = "lblCartesOrdinateur"
        Me.lblCartesOrdinateur.Size = New System.Drawing.Size(324, 32)
        Me.lblCartesOrdinateur.TabIndex = 15
        Me.lblCartesOrdinateur.Text = "Cartes de l'ordinateur :"
        '
        'lblCarte7
        '
        Me.lblCarte7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte7.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte7.Location = New System.Drawing.Point(570, 58)
        Me.lblCarte7.Name = "lblCarte7"
        Me.lblCarte7.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte7.TabIndex = 17
        Me.lblCarte7.Visible = False
        '
        'lblCarte6
        '
        Me.lblCarte6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarte6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarte6.ForeColor = System.Drawing.Color.Navy
        Me.lblCarte6.Location = New System.Drawing.Point(477, 58)
        Me.lblCarte6.Name = "lblCarte6"
        Me.lblCarte6.Size = New System.Drawing.Size(87, 122)
        Me.lblCarte6.TabIndex = 18
        Me.lblCarte6.Visible = False
        '
        'lblScoreJoueur
        '
        Me.lblScoreJoueur.AutoSize = True
        Me.lblScoreJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreJoueur.ForeColor = System.Drawing.Color.Cyan
        Me.lblScoreJoueur.Location = New System.Drawing.Point(12, 293)
        Me.lblScoreJoueur.Name = "lblScoreJoueur"
        Me.lblScoreJoueur.Size = New System.Drawing.Size(117, 29)
        Me.lblScoreJoueur.TabIndex = 19
        Me.lblScoreJoueur.Text = "Score : 0"
        '
        'lblScoreOrdi
        '
        Me.lblScoreOrdi.AutoSize = True
        Me.lblScoreOrdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreOrdi.ForeColor = System.Drawing.Color.Cyan
        Me.lblScoreOrdi.Location = New System.Drawing.Point(755, 293)
        Me.lblScoreOrdi.Name = "lblScoreOrdi"
        Me.lblScoreOrdi.Size = New System.Drawing.Size(117, 29)
        Me.lblScoreOrdi.TabIndex = 20
        Me.lblScoreOrdi.Text = "Score : 0"
        '
        'FrmJeu21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1073, 481)
        Me.Controls.Add(Me.lblScoreOrdi)
        Me.Controls.Add(Me.lblScoreJoueur)
        Me.Controls.Add(Me.lblCarte6)
        Me.Controls.Add(Me.lblCarte7)
        Me.Controls.Add(Me.lblCartesOrdinateur)
        Me.Controls.Add(Me.lblCartesJoueur)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblSommeOrdi)
        Me.Controls.Add(Me.lblSomme)
        Me.Controls.Add(Me.btnNouvellePartie)
        Me.Controls.Add(Me.btnRevelerCartes)
        Me.Controls.Add(Me.lblCarteOrdi3)
        Me.Controls.Add(Me.lblCarteOrdi2)
        Me.Controls.Add(Me.lblCarteOrdi1)
        Me.Controls.Add(Me.lblCarte5)
        Me.Controls.Add(Me.lblCarte4)
        Me.Controls.Add(Me.lblCarte3)
        Me.Controls.Add(Me.lblCarte2)
        Me.Controls.Add(Me.lblCarte1)
        Me.Controls.Add(Me.btnPigerCartes)
        Me.Name = "FrmJeu21"
        Me.Text = "Jeu21"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPigerCartes As Button
    Friend WithEvents lblCarte1 As Label
    Friend WithEvents lblCarte2 As Label
    Friend WithEvents lblCarte3 As Label
    Friend WithEvents lblCarte4 As Label
    Friend WithEvents lblCarte5 As Label
    Friend WithEvents lblCarteOrdi1 As Label
    Friend WithEvents lblCarteOrdi2 As Label
    Friend WithEvents lblCarteOrdi3 As Label
    Friend WithEvents btnRevelerCartes As Button
    Friend WithEvents btnNouvellePartie As Button
    Friend WithEvents lblSomme As Label
    Friend WithEvents lblSommeOrdi As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblCartesJoueur As Label
    Friend WithEvents lblCartesOrdinateur As Label
    Friend WithEvents lblCarte7 As Label
    Friend WithEvents lblCarte6 As Label
    Friend WithEvents lblScoreJoueur As Label
    Friend WithEvents lblScoreOrdi As Label
End Class
