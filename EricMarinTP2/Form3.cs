﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricMarinTP2
{
    public partial class Form3 : Form
    {

        List<Reservation> listReserv = new List<Reservation>();
        Reservation[] tabReserv;
        string cheminImage;
        string nomCamping;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Reservation> listReserv, string nomCamping, string cheminImage)
        {
            InitializeComponent();
            this.listReserv = listReserv;
            this.nomCamping = nomCamping;
            this.cheminImage = cheminImage;
            tabReserv = new Reservation[listReserv.Count];
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            labelCamping.Text = nomCamping;

            for (int i = 0; i < listReserv.Count; i++)
            {
                tabReserv[i] = listReserv[i];
            }

            listBoxReservations.Items.AddRange(tabReserv);

            pictureBoxCamping.ImageLocation = cheminImage;
        }

        private void listBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pointeur = listBoxReservations.SelectedIndex;
            Reservation reservSelectionne = tabReserv[pointeur];

            textBoxDetails.Text = "Terrain choisi: " + (reservSelectionne.TerrainChoisi + 1) + "\r\nNombre d'adultes: " + reservSelectionne.NbAdultes + "\r\nNombre d'enfants: " + reservSelectionne.NbEnfants + "\r\nNombre de nuits: " + (reservSelectionne.FinReservation.DayOfYear - reservSelectionne.DebutReservation.DayOfYear) + "\r\nType de paiement: " + reservSelectionne.TypePayement + "\r\nCout total: " + reservSelectionne.Cout;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
