namespace EricMarinTP2
{
    public partial class Form1 : Form
    {
        private string chemin = Application.StartupPath + "\\";
        Camping unCamping = null;
        bool dateDebutCorrecte = true;
        bool dateFinCorrecte = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imageName = "";

            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        imageName = "campingBic.jpg";
                        unCamping = new Camping(0, "Parc du Bic", "Fichiers/RESERV_BIC.txt", 10, imageName);
                        break;
                    case 1:
                        imageName = "campingOrford.jpg";
                        unCamping = new Camping(1, "Parc du Mont-Orford", "Fichiers/RESERV_ORFORD.txt", 8, imageName);
                        break;
                    case 2:
                        imageName = "campingPerce.jpg";
                        unCamping = new Camping(2, "Camping du Rocher Percé", "Fichiers/RESERV_PERCE.txt", 5, imageName);
                        break;
                    case 3:
                        imageName = "campingStSimeon.jpg";
                        unCamping = new Camping(3, "Camping de la plage de St-Siméon", "Fichiers/RESERV_SIMEON.txt", 10, imageName);
                        break;
                    default:
                        imageName = "";
                        unCamping = null;
                        break;
                }

                if (imageName != "")
                {
                    pictureBoxCamping.ImageLocation = chemin + imageName;
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + "Image non trouvable (" + ex + ")", "Ouverture d'un fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDebut_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateDebut = dateTimePickerDebut.Value;
            DateTime dateFin = dateTimePickerFin.Value;

            if (dateDebut.Year != dateFin.Year || dateDebut > dateFin || dateDebut.Month < 5 || dateFin.Month > 10 || dateDebut == dateFin)
            {
                errorProviderDate.SetError(labelDebut, "La date d'arrivée doit être avant la date de départ et la réservation entre le 1er mai et 31 octobre de la même année et différente");
                dateDebutCorrecte = false;
            } else
            {
                errorProviderDate.Clear();
                dateDebutCorrecte = true;
            }

        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateDebut = dateTimePickerDebut.Value;
            DateTime dateFin = dateTimePickerFin.Value;

            if (dateDebut.Year != dateFin.Year || dateDebut > dateFin || dateDebut.Month < 5 || dateFin.Month > 10 || dateDebut == dateFin)
            {
                errorProviderDate.SetError(labelDebut, "La date d'arrivée doit être avant la date de départ et la réservation entre le 1er mai et 31 octobre de la même année et différente");
                dateFinCorrecte = false;
            }
            else
            {
                errorProviderDate.Clear();
                dateFinCorrecte = true;
            }
        }

        private void buttonRerservation_Click(object sender, EventArgs e)
        {
            if (unCamping != null && dateDebutCorrecte && dateFinCorrecte)
            {
                Form2 form2 = new Form2(unCamping, dateTimePickerDebut.Value, dateTimePickerFin.Value);
                form2.ShowDialog();
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}