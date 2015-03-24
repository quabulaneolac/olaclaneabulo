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
            this.DGRecherche = new System.Windows.Forms.DataGridView();
            this.cbRechercheAvancee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRechercheAvancee = new System.Windows.Forms.Button();
            this.monTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGRecherche)).BeginInit();
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
            // 
            // DGRecherche
            // 
            this.DGRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRecherche.Location = new System.Drawing.Point(19, 64);
            this.DGRecherche.Name = "DGRecherche";
            this.DGRecherche.Size = new System.Drawing.Size(469, 256);
            this.DGRecherche.TabIndex = 2;
            this.DGRecherche.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRecherche_CellDoubleClick);
            // 
            // cbRechercheAvancee
            // 
            this.cbRechercheAvancee.CausesValidation = false;
            this.cbRechercheAvancee.FormattingEnabled = true;
            this.cbRechercheAvancee.Items.AddRange(new object[] {
            "artiste",
            "lieu",
            "date"});
            this.cbRechercheAvancee.Location = new System.Drawing.Point(358, 358);
            this.cbRechercheAvancee.Name = "cbRechercheAvancee";
            this.cbRechercheAvancee.Size = new System.Drawing.Size(121, 21);
            this.cbRechercheAvancee.TabIndex = 3;
            this.cbRechercheAvancee.Visible = false;
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
            this.panel1.Location = new System.Drawing.Point(685, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 390);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
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
            // monTimer
            // 
            this.monTimer.Interval = 1;
            this.monTimer.Tick += new System.EventHandler(this.monTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmRechercheConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.btnRechercheAvancee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRechercheAvancee);
            this.Controls.Add(this.DGRecherche);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRechercheConcert";
            this.Text = "Recherche de Concerts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.DataGridView DGRecherche;
        private System.Windows.Forms.ComboBox cbRechercheAvancee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Button btnRechercheAvancee;
        private System.Windows.Forms.Timer monTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

