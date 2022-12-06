namespace EricMarinTP2
{
    public partial class Form1 : Form
    {
        private string chemin = Application.StartupPath + "\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
                        break;
                    case 1:
                        imageName = "campingOrford.jpg";
                        break;
                    case 2:
                        imageName = "campingPerce.jpg";
                        break;
                    case 3:
                        imageName = "campingStSimeon.jpg";
                        break;
                    default:
                        imageName = "";
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
    }
}