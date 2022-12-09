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
           // unCamping = new Camping();
           // ecrire_json(unCamping);
            labelCamping.Text = unCamping.NomCamping;
            pictureBoxCamping.ImageLocation = chemin + unCamping.CheminImage;
            nbTerrains = unCamping.NbTerrains;
            campingDispo = new Boolean[nbTerrains, nbJours];
            System.Diagnostics.Debug.WriteLine(campingDispo.Length);

            for (int i = 0; i < unCamping.NbTerrains; i++)
            {
                comboBoxTerrain.Items.Add(nomTerrains[i]);
            }

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



                } catch (Exception ex)
                {

                }
            }


        }


      /*  private Camping[] lireJson()
        {
            Camping[] campings;
            string chemin_locale =  this.chemin + "Fichiers\\";
            string[] noms_fichiers = Directory.GetFiles(chemin_locale, "*.json");
            campings = new Camping[noms_fichiers.Length];
            try {
                for (int i = 0; i < noms_fichiers.Length; i++)
                {
                    string json = File.ReadAllText(noms_fichiers[i]);
                    campings[i] = JsonSerializer.Deserialize<Camping>(json);
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return campings;
        }

        private void ecrire_json(Camping camping)
        {
            string chemin_locale = this.chemin + "Fichiers\\";
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(chemin + "Fichiers\\fichier_test.json", JsonSerializer.Serialize(camping, options));
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }*/

    }
}
