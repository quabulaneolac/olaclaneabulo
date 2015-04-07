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
using quabulaneolac.Musique;


namespace RechecherConcert
{
    public partial class FrmRechercheConcert : Form
    {
        #region champs

        int maX;
        int position;
        Button monbutton = new Button();

        #endregion


        public FrmRechercheConcert()
        {
            InitializeComponent();
        }

 #region bouton slider

#region timer
        private void TimerRetourBtnRecherceAvancee_Tick(object sender, EventArgs e)
        {
            if (btnRechercheAvancee.Location.X != 637)
            {
                btnRechercheAvancee.Location = new Point(btnRechercheAvancee.Location.X + 20, btnRechercheAvancee.Location.Y);
                panel1.Location = new Point(panel1.Location.X + 20, panel1.Location.Y);
            }
        }

        private void TimerAllerBtnRechercheAvancee_Tick(object sender, EventArgs e)
        {
            if (btnRechercheAvancee.Location.X != 497)
            {
                btnRechercheAvancee.Location = new Point(btnRechercheAvancee.Location.X - 20, btnRechercheAvancee.Location.Y);
                panel1.Location = new Point(panel1.Location.X - 20, panel1.Location.Y);
            }
        }

        private void TimerRetourBtnOnOff_Tick_1(object sender, EventArgs e)
        {
            position = maX + 37;

            while (monbutton.Location.X != position)
            {
                monbutton.Location = new Point(monbutton.Location.X + 1, monbutton.Location.Y);
            }

           
        }

        private void TimerAllerBtnOnOff_Tick(object sender, EventArgs e)
        {
            position = maX - 37;

            while (monbutton.Location.X != position)
            {
                monbutton.Location = new Point(monbutton.Location.X - 1, monbutton.Location.Y);
            }
           
        }

 #endregion
        
         private void btn_on_off_artiste_Click(object sender, EventArgs e)
        {
            maX = btn_on_off_artiste.Location.X;
            monbutton = (Button)sender;

            if (btn_on_off_artiste.Location == new Point(118, 133))
            {
                TimerRetourBtnOnOff.Enabled = false;
                TimerAllerBtnOnOff.Enabled = true;
                lblBtnArtiste.Text = "Off";
                lblBtnArtiste.ForeColor = Color.Gray;
                pictureBox1.BackColor = Color.Transparent;

            }
            else
            {
                TimerRetourBtnOnOff.Enabled = true;
                TimerAllerBtnOnOff.Enabled = false;
                lblBtnArtiste.Text = "On";
                lblBtnArtiste.ForeColor = Color.Lime;
                pictureBox1.BackColor = Color.LimeGreen;
            }
        }

       private void label2_Click(object sender, EventArgs e)
        {
            btn_on_off_artiste.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_on_off_artiste.PerformClick();
        }
        private void btnRechercheAvancee_Click(object sender, EventArgs e)
        {

            if (btnRechercheAvancee.Location == new Point(637, -1))
            {
                TimerRetourBtnRecherceAvancee.Enabled = false;
                TimerAllerBtnRechercheAvancee.Enabled = true;
                panel1.Visible = true;

            }
            else
            {
               
                TimerAllerBtnRechercheAvancee.Enabled = false;
                TimerRetourBtnRecherceAvancee.Enabled = true;
                panel1.Visible = false;

            }
        }
#endregion

        private void Form1_Load(object sender, EventArgs e)
        {
           //if (NetManager.isConnected() == false)
           //{
           //   System.Media.SystemSounds.Exclamation.Play();
           //   MessageBox.Show("Pas de connexion internet \n Impossible de démarrer l'appli sans connexion" , "Avertissement",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
           //   this.Close();
           //}
        }

      

        private void DGRecherche_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetails formulaire = new frmDetails();
            formulaire.Show();
        }

        private void btnOnOffLieu_Click(object sender, EventArgs e)
        {

            maX = btnOnOffLieu.Location.X;
            monbutton = (Button)sender;

            if (btnOnOffLieu.Location == new Point(118, 203))
            {
                

                TimerRetourBtnOnOff.Enabled = false;
                TimerAllerBtnOnOff.Enabled = true;
                lblBtnLieu.Text = "Off";
                lblBtnLieu.ForeColor = Color.Gray;
                pictureBox2.BackColor = Color.Transparent;

            }
            else
            {
                TimerRetourBtnOnOff.Enabled = true;
                TimerAllerBtnOnOff.Enabled = false;
                lblBtnLieu.Text = "On";
                lblBtnLieu.ForeColor = Color.Lime;
                pictureBox2.BackColor = Color.LimeGreen;
            }
        }

        private void btnOnOffVille_Click(object sender, EventArgs e)
        {
            maX = btnOnOffVille.Location.X;
            monbutton = (Button)sender;
             if (btnOnOffVille.Location == new Point(118, 273))
            {
                TimerRetourBtnOnOff.Enabled = false;
                TimerAllerBtnOnOff.Enabled = true;
                lblBtnVille.Text = "Off";
                lblBtnVille.ForeColor = Color.Gray;
               pictureBox3.BackColor = Color.Transparent;

            }
            else
            {
                TimerRetourBtnOnOff.Enabled = true;
                TimerAllerBtnOnOff.Enabled = false;
                lblBtnVille.Text = "On";
                lblBtnVille.ForeColor = Color.Lime;
                pictureBox3.BackColor = Color.LimeGreen;
            }
        }

        private void btnOnOffTitre_Click(object sender, EventArgs e)
        {
            maX = btnOnOffTitre.Location.X;
            monbutton = (Button)sender;
            if (btnOnOffTitre.Location == new Point(118, 343))
            {
                TimerRetourBtnOnOff.Enabled = false;
                TimerAllerBtnOnOff.Enabled = true;
                lblBtnTitre.Text = "Off";
                lblBtnTitre.ForeColor = Color.Gray;
                pictureBox4.BackColor = Color.Transparent;

            }
            else
            {
                TimerRetourBtnOnOff.Enabled = true;
                TimerAllerBtnOnOff.Enabled = false;
                lblBtnTitre.Text = "On";
                lblBtnTitre.ForeColor = Color.Lime;
                pictureBox4.BackColor = Color.LimeGreen;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnOnOffLieu.PerformClick();
        }

       

        private void lblBtnTitre_TextChanged(object sender, EventArgs e)
        {
            if (lblBtnTitre.Text == "Off")
            {
                lblBtnLieu.ForeColor = Color.Gray;
                lblBtnVille.ForeColor = Color.Gray;
                lblBtnArtiste.ForeColor = Color.Gray;
                lblBtnLieu.Text = "Off";
                lblBtnVille.Text = "Off";
                lblBtnArtiste.Text = "Off";
                btnOnOffVille.Location = new Point(81, 273);
                pictureBox3.BackColor = Color.Transparent;
                btnOnOffLieu.Location = new Point(81, 203);
                pictureBox2.BackColor = Color.Transparent;
                btn_on_off_artiste.Location = new Point(81, 133);
                pictureBox1.BackColor = Color.Transparent;
                


            }
            if (lblBtnTitre.Text == "On")
            {
                lblBtnLieu.ForeColor = Color.Lime;
                lblBtnVille.ForeColor = Color.Lime;
                lblBtnArtiste.ForeColor = Color.Lime;
                lblBtnLieu.Text = "On";
                lblBtnVille.Text = "On";
                lblBtnArtiste.Text = "On";
                btnOnOffVille.Location = new Point(118, 273);
                pictureBox3.BackColor = Color.LimeGreen;
                btnOnOffLieu.Location = new Point(118, 203);
                pictureBox2.BackColor = Color.LimeGreen;
                btn_on_off_artiste.Location = new Point(118, 133);
                pictureBox1.BackColor = Color.LimeGreen;
            }
        }

        private void lblBtnLieu_Click(object sender, EventArgs e)
        {
            btnOnOffLieu.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnOnOffVille.PerformClick();
        }

        private void lblBtnVille_Click(object sender, EventArgs e)
        {
            btnOnOffVille.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnOnOffTitre.PerformClick();
        }

        private void lblBtnTitre_Click(object sender, EventArgs e)
        {
            btnOnOffTitre.PerformClick();
        }

        private void tbRecherche_TextChanged(object sender, EventArgs e)
        {
        //    FlowLayoutPanel moncadre = new FlowLayoutPanel();
        //    if (lblBtnArtiste.Text == "On")
        //    {
        //        List<Event> lesEvents = new List<Event>();
        //        lesEvents = LastfmAPI.getEventbyArtist(tbRecherche.Text);
        //        foreach (Event in lesEvents)
        //        {
        //           moncadre
        //        }
              
            //}
        }

       
       
    }
}
