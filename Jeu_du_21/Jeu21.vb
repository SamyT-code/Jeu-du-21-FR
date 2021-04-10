'**********************************
'*Travail : Jeu du 21
'*Programmeur : Samy Touabi
'*Date de conception : 3 mai 2020
'*********************************
Public Class FrmJeu21

    Public Compteur As Integer = 0 'Déclarer la valeur du compteur de cartes et la mettre à zéro
    Dim ScoreJoueur As Integer = 0 'Le score initial du joueur est de 0
    Dim ScoreOrdi As Integer = 0 'Le score initial de l'ordinateur est de 0

    Private Sub btnPigerCartes_Click(sender As Object, e As EventArgs) Handles btnPigerCartes.Click

        Randomize() ' Donne les nombres aléatoires
        Compteur = Compteur + 1 'Ajouter 1 au compteur de cartes

        btnRevelerCartes.Enabled = True 'Permet au joueur de révéler les cartes de l'ordinateur s'il pige au moins une carte

        'Déclarer les cartes du joueur en tant que integer
        Dim Carte1 As Integer
        Dim Carte2 As Integer
        Dim Carte3 As Integer
        Dim Carte4 As Integer
        Dim Carte5 As Integer
        Dim Carte6 As Integer
        Dim Carte7 As Integer

        'Somme des valeurs des cartes
        Dim SommeJoueur As Integer

        If Compteur = 1 Then 'Une seule carte est pigée
            Carte1 = (10 * Rnd() + 0.5)
            lblCarte1.Text = Carte1
            lblCarte1.Visible = True
        End If

        If Compteur = 2 Then '2 cartes sont pigées
            Carte2 = (10 * Rnd() + 0.5)
            lblCarte2.Text = Carte2
            lblCarte2.Visible = True
        End If

        If Compteur = 3 Then '3 cartes sont pigées
            Carte3 = (10 * Rnd() + 0.5)
            lblCarte3.Text = Carte3
            lblCarte3.Visible = True
        End If

        If Compteur = 4 Then '4 cartes sont pigées
            Carte4 = (10 * Rnd() + 0.5)
            lblCarte4.Text = Carte4
            lblCarte4.Visible = True
        End If

        If Compteur = 5 Then '5 cartes sont pigées
            Carte5 = (10 * Rnd() + 0.5)
            lblCarte5.Text = Carte5
            lblCarte5.Visible = True
        End If

        If Compteur = 6 Then '6 cartes sont pigées
            Carte6 = (10 * Rnd() + 0.5)
            lblCarte6.Text = Carte6
            lblCarte6.Visible = True
        End If

        If Compteur = 7 Then '7 cartes sont pigées
            Carte7 = (10 * Rnd() + 0.5)
            lblCarte7.Text = Carte7
            lblCarte7.Visible = True
        End If

        If Compteur >= 7 Then 'Message box pour dire que la limite a été atteinte
            MsgBox("Tu ne peux plus piger plus de cartes!")
            btnPigerCartes.Enabled = False 'Empêche le joueur de piger plus de cartes
        End If


        If Compteur = 1 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 2 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 3 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 4 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 5 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 6 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text) + Val(lblCarte6.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 7 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text) + Val(lblCarte6.Text) + Val(lblCarte7.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

    End Sub

    Private Sub btnReveler_Click(sender As Object, e As EventArgs) Handles btnRevelerCartes.Click

        Dim SommeJoueur As Integer
        Dim SommeOrdi As Integer

        'Rendre visible les cartes de l'ordinateur
        lblCarteOrdi1.Visible = True
        lblCarteOrdi2.Visible = True
        lblCarteOrdi3.Visible = True

        btnPigerCartes.Enabled = False 'Empêche le joueur de piger plus de cartes une foi qu'il vérifie le score
        btnRevelerCartes.Enabled = False 'Empêche le joueur de cliquer encore une fois sur le même bouton
        btnNouvellePartie.Enabled = True 'Permet au joueur de commencer une nouvelle partie

        Randomize() ' Donne les nombres aléatoires

        'Déclarer les cartes de l'ordinateur en tant que integer
        Dim CarteOrdi1 As Integer
        Dim CarteOrdi2 As Integer
        Dim CarteOrdi3 As Integer

        'Assigner des valeurs aléatoires aux cartes de l'ordinateur
        CarteOrdi1 = (10 * Rnd() + 0.5)
        CarteOrdi2 = (10 * Rnd() + 0.5)
        CarteOrdi3 = (10 * Rnd() + 0.5)

        'Note : avant de cliquer "Révéler les cartes", ces cartes seront invisibles
        lblCarteOrdi1.Text = CarteOrdi1
        lblCarteOrdi2.Text = CarteOrdi2
        lblCarteOrdi3.Text = CarteOrdi3

        'Calculer la somme des valeurs des cartes de l'ordi
        SommeOrdi = Val(lblCarteOrdi1.Text) + Val(lblCarteOrdi2.Text) + Val(lblCarteOrdi3.Text)

        lblSommeOrdi.Text = "Somme ordinateur : " & SommeOrdi 'Montrer le somme de l'ordi

        If Compteur = 1 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 2 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 3 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 4 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 5 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 6 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text) + Val(lblCarte6.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        If Compteur = 7 Then 'Trouver la somme des valeurs des cartes
            SommeJoueur = Val(lblCarte1.Text) + Val(lblCarte2.Text) + Val(lblCarte3.Text) + Val(lblCarte4.Text) + Val(lblCarte5.Text) + Val(lblCarte6.Text) + Val(lblCarte7.Text)
            lblSomme.Text = "Somme : " & SommeJoueur
        End If

        'Qui gagne ou ne gagne pas
        If SommeOrdi = SommeJoueur Or (SommeJoueur > 21 And SommeOrdi > 21) Then
            MsgBox("Personne n'a gagné ! ")
        ElseIf (SommeJoueur > SommeOrdi And SommeJoueur < 22) Or (SommeOrdi > 21 And SommeJoueur < 22) Then
            MsgBox("Tu as gagné ! ")
            ScoreJoueur = ScoreJoueur + 1 'Ajouter 1 point au joueur
            lblScoreJoueur.Text = "Score : " & ScoreJoueur
        Else MsgBox("Tu as perdu ! ")
            ScoreOrdi = ScoreOrdi + 1 'Ajouter 1 point à l'ordi
            lblScoreOrdi.Text = "Score : " & ScoreOrdi
        End If

    End Sub

    Private Sub btnNouvellePartie_Click(sender As Object, e As EventArgs) Handles btnNouvellePartie.Click


        'Donner une valeur inconnue aux cartes de l'ordinateur
        lblCarteOrdi1.Text = "?"
        lblCarteOrdi2.Text = "?"
        lblCarteOrdi3.Text = "?"

        'Donner une valeur nulle aux cartes du joueur
        lblCarte1.Text = ""
        lblCarte2.Text = ""
        lblCarte3.Text = ""
        lblCarte4.Text = ""
        lblCarte5.Text = ""
        lblCarte6.Text = ""
        lblCarte7.Text = ""

        Compteur = 0 'Reset le compeur des cartes

        'Déclarer les cartes de l'ordinateur en tant que integer
        Dim CarteOrdi1 As Integer
        Dim CarteOrdi2 As Integer
        Dim CarteOrdi3 As Integer

        'Assigner des valeurs aléatoires aux cartes de l'ordinateur
        CarteOrdi1 = (10 * Rnd() + 0.5)
        CarteOrdi2 = (10 * Rnd() + 0.5)
        CarteOrdi3 = (10 * Rnd() + 0.5)

        btnPigerCartes.Enabled = True 'Permet au joueur de piger plus de cartes
        btnRevelerCartes.Enabled = False 'Empêche le joueur de révéler les cartes de l'ordinateur s'il n'en a pigé aucune
        btnNouvellePartie.Enabled = False

        'Rend les cartes invisibles au début de la partie
        lblCarte1.Visible = False
        lblCarte2.Visible = False
        lblCarte3.Visible = False
        lblCarte4.Visible = False
        lblCarte5.Visible = False
        lblCarte6.Visible = False
        lblCarte7.Visible = False

        lblSomme.Text = "Somme : " 'Efface la somme qui était là avant
        lblSommeOrdi.Text = "Somme ordinateur : ?" 'Efface la somme qui était là avant

        btnPigerCartes.Enabled = True 'Permet au joueur de piger des cartes s'il clique sur Nouvelle partie

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        End ' Ferme l'application
    End Sub

    Private Sub FrmJeu21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNouvellePartie.Enabled = False 'Empêche le joueur de commencer une nouvelle partie s'il n'a pigé aucune carte
        btnRevelerCartes.Enabled = False 'Empêche le joueur de révéler les cartes de l'ordinateur s'il n'en a pigé aucune
    End Sub
End Class


