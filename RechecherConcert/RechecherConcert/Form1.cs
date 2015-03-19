using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechecherConcert
{
    public partial class FrmRechercheConcert : Form
    {
        public FrmRechercheConcert()
        {
            InitializeComponent();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Thomas est un bg");
            Console.WriteLine("Pfff c'est des conneries c'est joss le bg ! ");
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
           frmMap formulaire = new frmMap();
           formulaire.Show();
        }

       
    }
}
