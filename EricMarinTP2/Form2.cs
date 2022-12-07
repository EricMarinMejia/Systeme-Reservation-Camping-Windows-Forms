using System;
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
    public partial class Form2 : Form
    {
        Camping unCamping = null;
        private string chemin = Application.StartupPath + "\\";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Camping pCamping,DateTime pDateDebut,DateTime pDateFin)
        {
            InitializeComponent();
            unCamping = pCamping;
        }
    }
}
