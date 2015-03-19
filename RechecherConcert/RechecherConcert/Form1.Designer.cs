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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheConcert));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.DGRecherche = new System.Windows.Forms.DataGridView();
            this.cbRechercheAvancee = new System.Windows.Forms.ComboBox();
            this.btnRechercheAvancee = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(48, 29);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(66, 13);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche :";
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(126, 26);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(130, 20);
            this.tbRecherche.TabIndex = 1;
            // 
            // DGRecherche
            // 
            this.DGRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRecherche.Location = new System.Drawing.Point(92, 76);
            this.DGRecherche.Name = "DGRecherche";
            this.DGRecherche.Size = new System.Drawing.Size(469, 256);
            this.DGRecherche.TabIndex = 2;
            // 
            // cbRechercheAvancee
            // 
            this.cbRechercheAvancee.CausesValidation = false;
            this.cbRechercheAvancee.FormattingEnabled = true;
            this.cbRechercheAvancee.Items.AddRange(new object[] {
            "artiste",
            "lieu",
            "date"});
            this.cbRechercheAvancee.Location = new System.Drawing.Point(519, 25);
            this.cbRechercheAvancee.Name = "cbRechercheAvancee";
            this.cbRechercheAvancee.Size = new System.Drawing.Size(121, 21);
            this.cbRechercheAvancee.TabIndex = 3;
            this.cbRechercheAvancee.Visible = false;
            // 
            // btnRechercheAvancee
            // 
            this.btnRechercheAvancee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercheAvancee.Location = new System.Drawing.Point(374, 24);
            this.btnRechercheAvancee.Name = "btnRechercheAvancee";
            this.btnRechercheAvancee.Size = new System.Drawing.Size(114, 23);
            this.btnRechercheAvancee.TabIndex = 4;
            this.btnRechercheAvancee.Text = "Recherche Avancée";
            this.btnRechercheAvancee.UseVisualStyleBackColor = true;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(418, 347);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(143, 23);
            this.btnMap.TabIndex = 5;
            this.btnMap.Text = "Afficher avec Google map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // FrmRechercheConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnRechercheAvancee);
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
        private System.Windows.Forms.Button btnRechercheAvancee;
        private System.Windows.Forms.Button btnMap;
    }
}

