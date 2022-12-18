using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EricMarinTP2
{
    public partial class Form2 : Form
    {

        string[] nomTerrains = {"Terrain 1", "Terrain 2", "Terrain 3", "Terrain 4", "Terrain 5", "Terrain 6", "Terrain 7", "Terrain 8", "Terrain 9", "Terrain 10"};
        string cheminFichier = "";
        Camping unCamping = null;
        private string chemin = Application.StartupPath + "\\";
        int nombreReserv = -1;

        static int nbTerrains = 0;
        const int nbJours = 365;
        bool[,] campingDispo;

        //Vérification des champs
        bool nomCorrect = true;
        bool prenomCorrect = true;
        bool courrielCorrect = true;
        bool nbPersonnesCorrect = true;
        bool terrainCorrect = true;

        List<Reservation> listReserv = new List<Reservation>();
        Reservation uneReservation;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Camping pCamping,DateTime pDateDebut,DateTime pDateFin)
        {
            InitializeComponent();
            unCamping = pCamping;
            dateTimePickerDebut.Value = pDateDebut;
            dateTimePickerFin.Value = pDateFin;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Mettre le nom dans le titre, l'image, initialiser le nombre de terrains, le tableau de bool
            labelCamping.Text = unCamping.NomCamping;
            pictureBoxCamping.ImageLocation = chemin + unCamping.CheminImage;
            nbTerrains = unCamping.NbTerrains;
            campingDispo = new Boolean[nbTerrains, nbJours];
            System.Diagnostics.Debug.WriteLine(campingDispo.Length);

            //Ajouter les terrains disponible au comboBox
            for (int i = 0; i < unCamping.NbTerrains; i++)
            {
                comboBoxTerrain.Items.Add(nomTerrains[i]);
            }

            //Choisir le fichier de réservation
            switch (unCamping.NomCamping)
            {
                case "Parc du Bic":
                    cheminFichier = chemin + "Fichiers\\RESERV_BIC.txt";
                    break;
                case "Parc du Mont-Orford":
                    cheminFichier = chemin + "Fichiers\\RESERV_ORFORD.txt";
                    break;
                case "Camping du Rocher Percé":
                    cheminFichier = chemin + "Fichiers\\RESERV_PERCE.txt";
                    break;
                case "Camping de la plage de St-Siméon":
                    cheminFichier = chemin + "Fichiers\\RESERV_SIMEON.txt";
                    break;
            }

            //Mettre à false toutes les cases du tableau
            for (int i = 0; i < unCamping.NbTerrains; i++)
            {
                for (int j = 0; j < nbJours; j++)
                {
                    campingDispo[i, j] = false;
                }
            }

            System.Diagnostics.Debug.WriteLine(dateTimePickerDebut.Value);

            //Lire le fichier texte et ajouter les réservations qui existent déjà
            lectureFichier(cheminFichier);
            //Vérififer les disponibilités et changer la couleur des richTextBox
            verifDispo();

        }

        private void lectureFichier(string cheminFichier)
        {

            if (File.Exists(cheminFichier))
            {
                try
                {

                    StreamReader lecteur = new StreamReader(cheminFichier);

                    do
                    {
                        string ligneCurrent = lecteur.ReadLine();

                        //Si la ligne n'est pas vide
                        if (ligneCurrent != null)
                        {
                            nombreReserv++;
                            string[] ligne = ligneCurrent.Split(";");
                            //Récuperer les dates de début et de fin
                            string debutString = ligne[2];
                            string finString = ligne[3];

                            DateTime debutDate = DateTime.Parse(debutString);
                            DateTime finDate = DateTime.Parse(finString);

                            int numJourDebut = debutDate.DayOfYear;
                            int numJourFin = finDate.DayOfYear;

                            //Mettre à true les cases correspondantes et faire +1 pour le numéro de réservations
                            for (int ctr = numJourDebut; ctr < numJourFin; ctr++)
                            {
                                campingDispo[int.Parse(ligne[4]), ctr] = true;;
                            }

                            uneReservation = new Reservation(int.Parse(ligne[0]), int.Parse(ligne[1]), DateTime.Parse(ligne[2]), DateTime.Parse(ligne[3]), int.Parse(ligne[4]), ligne[5], ligne[6], ligne[7], int.Parse(ligne[8]), int.Parse(ligne[9]), double.Parse(ligne[10]));
                            listReserv.Add(uneReservation);

                        }

                    } while (!lecteur.EndOfStream );


                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void verifDispo()
        {
            //Changer les cases à vert
            richTextBox1.BackColor = Color.Green;
            richTextBox2.BackColor = Color.Green;
            richTextBox3.BackColor = Color.Green;
            richTextBox4.BackColor = Color.Green;
            richTextBox5.BackColor = Color.Green;
            richTextBox6.BackColor = Color.Green;
            richTextBox7.BackColor = Color.Green;
            richTextBox8.BackColor = Color.Green;
            richTextBox9.BackColor = Color.Green;
            richTextBox10.BackColor = Color.Green;

            int debut = dateTimePickerDebut.Value.DayOfYear;
            int fin = dateTimePickerFin.Value.DayOfYear;

            //Chnager la couleur des cases selon le nombre de terrains du camping et leur disponibilité
            switch (unCamping.NbTerrains)
            {
                case 5:
                    richTextBox6.BackColor = Color.Black;
                    richTextBox7.BackColor = Color.Black;
                    richTextBox8.BackColor = Color.Black;
                    richTextBox9.BackColor = Color.Black;
                    richTextBox10.BackColor = Color.Black;

                    if (debut < fin)
                    {
                        for (int ctr = debut; ctr < fin; ctr++)
                        {
                            // Terrain : si réserver = change la couleur
                            if (campingDispo[0, ctr])
                            {
                                richTextBox1.BackColor = Color.Red;
                            }
                            if (campingDispo[1, ctr])
                            {
                                richTextBox2.BackColor = Color.Red;
                            }
                            if (campingDispo[2, ctr])
                            {
                                richTextBox3.BackColor = Color.Red;
                            }
                            if (campingDispo[3, ctr])
                            {
                                richTextBox4.BackColor = Color.Red;
                            }
                            if (campingDispo[4, ctr])
                            {
                                richTextBox5.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 8:

                    richTextBox9.BackColor = Color.Black;
                    richTextBox10.BackColor = Color.Black;

                    if (debut < fin)
                    {
                        for (int ctr = debut; ctr < fin; ctr++)
                        {
                            // Terrain : si réserver = change la couleur
                            if (campingDispo[0, ctr])
                            {
                                richTextBox1.BackColor = Color.Red;
                            }
                            if (campingDispo[1, ctr])
                            {
                                richTextBox2.BackColor = Color.Red;
                            }
                            if (campingDispo[2, ctr])
                            {
                                richTextBox3.BackColor = Color.Red;
                            }
                            if (campingDispo[3, ctr])
                            {
                                richTextBox4.BackColor = Color.Red;
                            }
                            if (campingDispo[4, ctr])
                            {
                                richTextBox5.BackColor = Color.Red;
                            }
                            if (campingDispo[5, ctr])
                            {
                                richTextBox6.BackColor = Color.Red;
                            }
                            if (campingDispo[6, ctr])
                            {
                                richTextBox7.BackColor = Color.Red;
                            }
                            if (campingDispo[7, ctr])
                            {
                                richTextBox8.BackColor = Color.Red;
                            }
                        }
                    }

                    break;
                case 10:

                    if (debut < fin)
                    {
                        for (int ctr = debut; ctr < fin; ctr++)
                        {
                            // Terrain  : si réserver = change la couleur
                            if (campingDispo[0, ctr])
                            {
                                richTextBox1.BackColor = Color.Red;
                            }
                            if (campingDispo[1, ctr])
                            {
                                richTextBox2.BackColor = Color.Red;
                            }
                            if (campingDispo[2, ctr])
                            {
                                richTextBox3.BackColor = Color.Red;
                            }
                            if (campingDispo[3, ctr])
                            {
                                richTextBox4.BackColor = Color.Red;
                            }
                            if (campingDispo[4, ctr])
                            {
                                richTextBox5.BackColor = Color.Red;
                            }
                            if (campingDispo[5, ctr])
                            {
                                richTextBox6.BackColor = Color.Red;
                            }
                            if (campingDispo[6, ctr])
                            {
                                richTextBox7.BackColor = Color.Red;
                            }
                            if (campingDispo[7, ctr])
                            {
                                richTextBox8.BackColor = Color.Red;
                            }
                            if (campingDispo[8, ctr])
                            {
                                richTextBox9.BackColor = Color.Red;
                            }
                            if (campingDispo[9, ctr])
                            {
                                richTextBox10.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retourAuMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

            string text = textBoxNom.Text;
            nomCorrect = true;

            if (string.IsNullOrEmpty(text))
            {
                errorProviderNom.SetError(textBoxNom, "Le nom ne peut pas être vide");
                nomCorrect = false;
            } else
            {
                foreach (char c in text)
                {
                    if (!Char.IsLetter(c) && !Char.IsControl(c) && !Char.IsWhiteSpace(c) && c != '\'' && c != '-')
                    {
                        errorProviderNom.SetError(textBoxNom, "Le nom ne peut contenir que de lettres, espaces, ' ou -");
                        nomCorrect = false;
                    }
                }
            }
            
            if (nomCorrect)
            {
                errorProviderNom.Clear();
            }
            
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxPrenom.Text;
            prenomCorrect = true;

            if (string.IsNullOrEmpty(text))
            {
                errorProviderPrenom.SetError(textBoxPrenom, "Le prenom ne peut pas être vide");
                prenomCorrect = false;
            }
            else
            {
                foreach (char c in text)
                {
                    if (!Char.IsLetter(c) && !Char.IsControl(c) && !Char.IsWhiteSpace(c) && c != '\'' && c != '-')
                    {
                        errorProviderPrenom.SetError(textBoxPrenom, "Le prenom ne peut contenir que de lettres, espaces, ' ou -");
                        prenomCorrect = false;
                    }
                }
            }

            if (prenomCorrect)
            {
                errorProviderPrenom.Clear();
            }
        }

        private void textBoxCourriel_TextChanged(object sender, EventArgs e)
        {
            bool contientAComercial = false;
            string text = textBoxCourriel.Text;

            foreach (char c in text)
            {
                if (c == '@')
                {
                    contientAComercial = true;
                }
            }

            if (contientAComercial)
            {
                errorProviderCourriel.Clear();
                courrielCorrect = true;
            } else
            {
                errorProviderCourriel.SetError(textBoxCourriel, "Le courriel doit contenir @ et ne peut pas être vide");
                courrielCorrect = false;
            }
        }

        private void numericUpDownAdulte_ValueChanged(object sender, EventArgs e)
        {
            int numberAdults = (int)(numericUpDownAdulte.Value);
            int numberChildren = (int)(numericUpDownEnfants.Value);

            if (numberAdults + numberChildren > 8)
            {
                errorProviderAdultes.SetError(numericUpDownAdulte, "Le maximum de personnes permises est de 8");
                errorProviderEnfants.SetError(numericUpDownEnfants, "Le maximum de personnes permises est de 8");
                nbPersonnesCorrect = false;

            } else if (numberAdults + numberChildren <= 0)
            {
                errorProviderAdultes.SetError(numericUpDownAdulte, "Le minimum de personnes demandés est de 1");
                errorProviderEnfants.SetError(numericUpDownEnfants, "Le minimum de personnes demandés est de 1");
                nbPersonnesCorrect = false;
            } else
            {
                nbPersonnesCorrect = true;
                errorProviderAdultes.Clear();
                errorProviderEnfants.Clear();
            }

        }

        private void numericUpDownEnfants_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAdulte_ValueChanged(sender, e);
        }

        private void comboBoxTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {

            string debutString = dateTimePickerDebut.Text;
            string finString = dateTimePickerFin.Text;

            DateTime debutDate = DateTime.Parse(debutString);
            DateTime finDate = DateTime.Parse(finString);

            int numJourDebut = debutDate.DayOfYear;
            int numJourFin = finDate.DayOfYear;
            bool terrainOccupe = false;

            //Mettre à true les cases correspondantes et faire +1 pour le numéro de réservations
            for (int ctr = numJourDebut; ctr < numJourFin; ctr++)
            {
                if (campingDispo[comboBoxTerrain.SelectedIndex, ctr] == true)
                {
                    terrainOccupe = true;
                }
            }

            if (!terrainOccupe) {
                errorProviderTerrains.Clear();
                terrainCorrect = true;
            } else
            {
                errorProviderTerrains.SetError(comboBoxTerrain, "Le terrain est déjà occupé");
                terrainCorrect = false;
            }

        }
    }
}
