using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricMarinTP2
{
    internal class Reservation
    {
        private int numReservation;
        private int numCamping;
        private string nomClient;
        private string courriel;
        private string typePayement;
        private DateTime debutReservation;
        private DateTime finReservation;
        private int nbAdultes;
        private int nbEnfants;
        private double cout;

        public int NumReservation
        {
            get { return numReservation; }
            set { numReservation = value; }
        }

        public int NumCamping
        {
            get { return numCamping; }
            set { numCamping = value; }
        }

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }

        public DateTime DebutReservation
        {
            get { return debutReservation; }
            set { debutReservation = value; }
        }

        public DateTime FinReservation
        {
            get { return finReservation; }
            set { finReservation = value; }
        }

        public int NbAdultes
        {
            get { return nbAdultes; }
            set { nbAdultes = value; }
        }

        public double Cout
        {
            get { return cout; }
            set { cout = value; }
        }

        public int NbEnfants
        {
            get { return nbEnfants; }
            set { nbEnfants = value; }
        }

        public Reservation(int numReservation, int numCamping, string nomClient, string courriel, string typePayement, DateTime debutReservation, DateTime finReservation, int nbAdultes, int nbEnfants, double cout)
        {
            this.numReservation = numReservation;
            this.numCamping = numCamping;
            this.nomClient = nomClient;
            this.courriel = courriel;
            this.typePayement = typePayement;
            this.debutReservation = debutReservation;
            this.finReservation = finReservation;
            this.nbAdultes = nbAdultes;
            this.nbEnfants = nbEnfants;
            this.cout = cout;
        }

    }
}
