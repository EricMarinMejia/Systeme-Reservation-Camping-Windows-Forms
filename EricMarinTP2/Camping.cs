using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricMarinTP2
{
    public class Camping
    {
        private int nbCamping;
        private string nomCamping;
        private string nomFichierCamping;
        private int nbTerrains;
        private string cheminImage;

        public int NbCamping
        {
            get { return nbCamping; }
            set { nbCamping = value; }
        }

        public string NomCamping
        {
            get { return nomCamping; }
            set { nomCamping = value; }
        }

        public string NomFichierCamping
        {
            get { return nomFichierCamping; }
            set { nomFichierCamping = value; }
        }

        public int NbTerrains
        {
            get { return nbTerrains; }
            set { nbTerrains = value; }
        }

        public string CheminImage
        {
            get { return cheminImage; }
            set { cheminImage = value; }
        }

        public Camping()
        {
            nbCamping = 0;
            nomCamping = "";
            nomFichierCamping = "";
            nbTerrains = 0;
            cheminImage = "";
        }

        public Camping(int pNbCamping, string pNomCamping, string pNomFichierCamping, int pNbTerrains, string pCheminImage)
        {
            nbCamping = pNbCamping;
            nomCamping = pNomCamping;
            nomFichierCamping = pNomFichierCamping;
            nbTerrains = pNbTerrains;
            cheminImage = pCheminImage;
        }

    }
}
