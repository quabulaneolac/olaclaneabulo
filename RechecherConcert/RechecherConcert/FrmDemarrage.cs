using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Olaclaneabulo.Tools;

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
           if (NetManager.isConnected() == false)
           {
              System.Media.SystemSounds.Exclamation.Play();
              MessageBox.Show("Pas de connexion internet \n Impossible de démarrer l'appli sans connexion" , "Avertissement",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
              this.Close();
           }
        }

      

        private void DGRecherche_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetails formulaire = new frmDetails();
            formulaire.Show();
        }

        private void btnRechercheAvancee_Click(object sender, EventArgs e)
        {
            
            if (btnRechercheAvancee.Location == new Point (637,-1))
            {
                timer1.Enabled = false;
                monTimer.Enabled = true;
                panel1.Visible = true;
                
            }
            else
            {
                panel1.Visible = false;
                monTimer.Enabled = false;
                timer1.Enabled = true;
                
            }
            

        }

        private void monTimer_Tick(object sender, EventArgs e)
        {
            if (btnRechercheAvancee.Location.X != 497)
            {
                btnRechercheAvancee.Location = new Point(btnRechercheAvancee.Location.X - 20, btnRechercheAvancee.Location.Y);
                panel1.Location = new Point(panel1.Location.X - 20, panel1.Location.Y);
            }
        }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnRechercheAvancee.Location.X != 637)
            {
                btnRechercheAvancee.Location = new Point(btnRechercheAvancee.Location.X + 20, btnRechercheAvancee.Location.Y);
                panel1.Location = new Point(panel1.Location.X + 20, panel1.Location.Y);
            }
        }
        

      
       
    }
}
