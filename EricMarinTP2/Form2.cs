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
        Reservation uneReservation = null;
        private string chemin = Application.StartupPath + "\\";
        int nombreReserv = -1;

        static int nbTerrains = 0;
        const int nbJours = 365;
        bool[,] campingDispo;

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
            labelCamping.Text = unCamping.NomCamping;
            pictureBoxCamping.ImageLocation = chemin + unCamping.CheminImage;
            nbTerrains = unCamping.NbTerrains;
            campingDispo = new Boolean[nbTerrains, nbJours];
            System.Diagnostics.Debug.WriteLine(campingDispo.Length);

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

            for (int i = 0; i < unCamping.NbTerrains; i++)
            {
                for (int j = 0; j < nbJours; j++)
                {
                    campingDispo[i, j] = false;
                }
            }

            System.Diagnostics.Debug.WriteLine(dateTimePickerDebut.Value);

            lectureFichier(cheminFichier);
            verifDispo();

            //LIRE LE FICHIER TEXTE POUR SAVOIR SI YA DEJA DESRESERVATION, les ajouter au tableau
            //Faire une méthode qui rajoute les dates déjà présentes dans les fichiers
            //Faire une méthode qui vérifie les dispo et colore les richTextBox

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

                        if (ligneCurrent != null)
                        {
                            string[] ligne = ligneCurrent.Split(";");
                            string debutString = ligne[2];
                            string finString = ligne[3];

                            DateTime debutDate = DateTime.Parse(debutString);
                            DateTime finDate = DateTime.Parse(finString);

                            int numJourDebut = debutDate.DayOfYear;
                            int numJourFin = finDate.DayOfYear;

                            for (int ctr = numJourDebut; ctr < numJourFin; ctr++)
                            {
                                campingDispo[int.Parse(ligne[4]), ctr] = true;
                                nombreReserv++;
                            }

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
                            // Terrani 1 : si réserver = change la couleur
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
                            // Terrani 1 : si réserver = change la couleur
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
                            // Terrani 1 : si réserver = change la couleur
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

    }
}
