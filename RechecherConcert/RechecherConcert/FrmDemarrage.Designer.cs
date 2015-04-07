namespace RechecherConcert
{
    partial class FrmRechercheConcert
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheConcert));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBtnTitre = new System.Windows.Forms.Label();
            this.btnOnOffTitre = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBtnVille = new System.Windows.Forms.Label();
            this.btnOnOffVille = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBtnLieu = new System.Windows.Forms.Label();
            this.btnOnOffLieu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBtnArtiste = new System.Windows.Forms.Label();
            this.btn_on_off_artiste = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRechercheAvancee = new System.Windows.Forms.Button();
            this.TimerAllerBtnRechercheAvancee = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerRetourBtnRecherceAvancee = new System.Windows.Forms.Timer(this.components);
            this.TimerRetourBtnOnOff = new System.Windows.Forms.Timer(this.components);
            this.TimerAllerBtnOnOff = new System.Windows.Forms.Timer(this.components);
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreRecherche = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(20, 28);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(66, 13);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche :";
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(98, 25);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(130, 20);
            this.tbRecherche.TabIndex = 1;
            this.tbRecherche.TextChanged += new System.EventHandler(this.tbRecherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double-clic pour plus d\'infos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.lblTitreRecherche);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblBtnTitre);
            this.panel1.Controls.Add(this.btnOnOffTitre);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblBtnVille);
            this.panel1.Controls.Add(this.btnOnOffVille);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblBtnLieu);
            this.panel1.Controls.Add(this.btnOnOffLieu);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblBtnArtiste);
            this.panel1.Controls.Add(this.btn_on_off_artiste);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(685, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 390);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label5.Location = new System.Drawing.Point(27, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "All";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label3.Location = new System.Drawing.Point(-1, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Salle de concert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Artiste";
            // 
            // lblBtnTitre
            // 
            this.lblBtnTitre.AutoSize = true;
            this.lblBtnTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnTitre.ForeColor = System.Drawing.Color.Lime;
            this.lblBtnTitre.Location = new System.Drawing.Point(39, 343);
            this.lblBtnTitre.Name = "lblBtnTitre";
            this.lblBtnTitre.Size = new System.Drawing.Size(27, 16);
            this.lblBtnTitre.TabIndex = 24;
            this.lblBtnTitre.Text = "On";
            this.lblBtnTitre.TextChanged += new System.EventHandler(this.lblBtnTitre_TextChanged);
            this.lblBtnTitre.Click += new System.EventHandler(this.lblBtnTitre_Click);
            // 
            // btnOnOffTitre
            // 
            this.btnOnOffTitre.BackColor = System.Drawing.Color.Gray;
            this.btnOnOffTitre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOnOffTitre.FlatAppearance.BorderSize = 2;
            this.btnOnOffTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOffTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOffTitre.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOffTitre.Image")));
            this.btnOnOffTitre.Location = new System.Drawing.Point(118, 343);
            this.btnOnOffTitre.Name = "btnOnOffTitre";
            this.btnOnOffTitre.Size = new System.Drawing.Size(13, 15);
            this.btnOnOffTitre.TabIndex = 23;
            this.btnOnOffTitre.UseVisualStyleBackColor = false;
            this.btnOnOffTitre.Click += new System.EventHandler(this.btnOnOffTitre_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(81, 343);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 15);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblBtnVille
            // 
            this.lblBtnVille.AutoSize = true;
            this.lblBtnVille.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnVille.ForeColor = System.Drawing.Color.Lime;
            this.lblBtnVille.Location = new System.Drawing.Point(39, 273);
            this.lblBtnVille.Name = "lblBtnVille";
            this.lblBtnVille.Size = new System.Drawing.Size(27, 16);
            this.lblBtnVille.TabIndex = 21;
            this.lblBtnVille.Text = "On";
            this.lblBtnVille.Click += new System.EventHandler(this.lblBtnVille_Click);
            // 
            // btnOnOffVille
            // 
            this.btnOnOffVille.BackColor = System.Drawing.Color.Gray;
            this.btnOnOffVille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOnOffVille.FlatAppearance.BorderSize = 2;
            this.btnOnOffVille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOffVille.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOffVille.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOffVille.Image")));
            this.btnOnOffVille.Location = new System.Drawing.Point(118, 273);
            this.btnOnOffVille.Name = "btnOnOffVille";
            this.btnOnOffVille.Size = new System.Drawing.Size(13, 15);
            this.btnOnOffVille.TabIndex = 20;
            this.btnOnOffVille.UseVisualStyleBackColor = false;
            this.btnOnOffVille.Click += new System.EventHandler(this.btnOnOffVille_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(81, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 15);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblBtnLieu
            // 
            this.lblBtnLieu.AutoSize = true;
            this.lblBtnLieu.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnLieu.ForeColor = System.Drawing.Color.Lime;
            this.lblBtnLieu.Location = new System.Drawing.Point(39, 203);
            this.lblBtnLieu.Name = "lblBtnLieu";
            this.lblBtnLieu.Size = new System.Drawing.Size(27, 16);
            this.lblBtnLieu.TabIndex = 18;
            this.lblBtnLieu.Text = "On";
            this.lblBtnLieu.Click += new System.EventHandler(this.lblBtnLieu_Click);
            // 
            // btnOnOffLieu
            // 
            this.btnOnOffLieu.BackColor = System.Drawing.Color.Gray;
            this.btnOnOffLieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOnOffLieu.FlatAppearance.BorderSize = 2;
            this.btnOnOffLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOffLieu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOffLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOffLieu.Image")));
            this.btnOnOffLieu.Location = new System.Drawing.Point(118, 203);
            this.btnOnOffLieu.Name = "btnOnOffLieu";
            this.btnOnOffLieu.Size = new System.Drawing.Size(13, 15);
            this.btnOnOffLieu.TabIndex = 17;
            this.btnOnOffLieu.UseVisualStyleBackColor = false;
            this.btnOnOffLieu.Click += new System.EventHandler(this.btnOnOffLieu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(81, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 15);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblBtnArtiste
            // 
            this.lblBtnArtiste.AutoSize = true;
            this.lblBtnArtiste.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnArtiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBtnArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnArtiste.ForeColor = System.Drawing.Color.Lime;
            this.lblBtnArtiste.Location = new System.Drawing.Point(39, 133);
            this.lblBtnArtiste.Name = "lblBtnArtiste";
            this.lblBtnArtiste.Size = new System.Drawing.Size(27, 16);
            this.lblBtnArtiste.TabIndex = 15;
            this.lblBtnArtiste.Text = "On";
            this.lblBtnArtiste.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_on_off_artiste
            // 
            this.btn_on_off_artiste.BackColor = System.Drawing.Color.Gray;
            this.btn_on_off_artiste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_on_off_artiste.FlatAppearance.BorderSize = 2;
            this.btn_on_off_artiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_on_off_artiste.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_on_off_artiste.Image = ((System.Drawing.Image)(resources.GetObject("btn_on_off_artiste.Image")));
            this.btn_on_off_artiste.Location = new System.Drawing.Point(118, 133);
            this.btn_on_off_artiste.Name = "btn_on_off_artiste";
            this.btn_on_off_artiste.Size = new System.Drawing.Size(13, 15);
            this.btn_on_off_artiste.TabIndex = 13;
            this.btn_on_off_artiste.UseVisualStyleBackColor = false;
            this.btn_on_off_artiste.Click += new System.EventHandler(this.btn_on_off_artiste_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(81, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 15);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRechercheAvancee
            // 
            this.btnRechercheAvancee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRechercheAvancee.BackgroundImage")));
            this.btnRechercheAvancee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRechercheAvancee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRechercheAvancee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnRechercheAvancee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnRechercheAvancee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercheAvancee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercheAvancee.ForeColor = System.Drawing.Color.Transparent;
            this.btnRechercheAvancee.Location = new System.Drawing.Point(637, -1);
            this.btnRechercheAvancee.Name = "btnRechercheAvancee";
            this.btnRechercheAvancee.Size = new System.Drawing.Size(49, 46);
            this.btnRechercheAvancee.TabIndex = 9;
            this.btnRechercheAvancee.UseVisualStyleBackColor = true;
            this.btnRechercheAvancee.Click += new System.EventHandler(this.btnRechercheAvancee_Click);
            // 
            // TimerAllerBtnRechercheAvancee
            // 
            this.TimerAllerBtnRechercheAvancee.Interval = 1;
            this.TimerAllerBtnRechercheAvancee.Tick += new System.EventHandler(this.TimerAllerBtnRechercheAvancee_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // TimerRetourBtnRecherceAvancee
            // 
            this.TimerRetourBtnRecherceAvancee.Interval = 30;
            this.TimerRetourBtnRecherceAvancee.Tick += new System.EventHandler(this.TimerRetourBtnRecherceAvancee_Tick);
            // 
            // TimerRetourBtnOnOff
            // 
            this.TimerRetourBtnOnOff.Interval = 30;
            this.TimerRetourBtnOnOff.Tick += new System.EventHandler(this.TimerRetourBtnOnOff_Tick_1);
            // 
            // TimerAllerBtnOnOff
            // 
            this.TimerAllerBtnOnOff.Interval = 30;
            this.TimerAllerBtnOnOff.Tick += new System.EventHandler(this.TimerAllerBtnOnOff_Tick);
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Location = new System.Drawing.Point(12, 61);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(666, 271);
            this.flp1.TabIndex = 2;
            // 
            // lblTitreRecherche
            // 
            this.lblTitreRecherche.AutoSize = true;
            this.lblTitreRecherche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreRecherche.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitreRecherche.Location = new System.Drawing.Point(3, 26);
            this.lblTitreRecherche.Name = "lblTitreRecherche";
            this.lblTitreRecherche.Size = new System.Drawing.Size(138, 34);
            this.lblTitreRecherche.TabIndex = 32;
            this.lblTitreRecherche.Text = "Recherche avancée\r\nRechercher par :\r\n";
            this.lblTitreRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRechercheConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRechercheAvancee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.flp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRechercheConcert";
            this.Text = "Recherche de Concerts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Button btnRechercheAvancee;
        private System.Windows.Forms.Timer TimerAllerBtnRechercheAvancee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TimerRetourBtnRecherceAvancee;
        private System.Windows.Forms.Label lblBtnArtiste;
        private System.Windows.Forms.Button btn_on_off_artiste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerRetourBtnOnOff;
        private System.Windows.Forms.Timer TimerAllerBtnOnOff;
        private System.Windows.Forms.Label lblBtnTitre;
        private System.Windows.Forms.Button btnOnOffTitre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBtnVille;
        private System.Windows.Forms.Button btnOnOffVille;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBtnLieu;
        private System.Windows.Forms.Button btnOnOffLieu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Label lblTitreRecherche;
    }
}

