
namespace ProjectPompe
{
    partial class frmPompiste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPompiste));
            this.btnImage = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROTELE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNouveauPompiste = new System.Windows.Forms.Button();
            this.btnAjouterPompiste = new System.Windows.Forms.Button();
            this.btnSupprimerPompiste = new System.Windows.Forms.Button();
            this.pictureBoxPompiste = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdressePompiste = new System.Windows.Forms.TextBox();
            this.textBoxNomPompiste = new System.Windows.Forms.TextBox();
            this.textBoxPrenomPompiste = new System.Windows.Forms.TextBox();
            this.textBoxCNSPompiste = new System.Windows.Forms.TextBox();
            this.textBoxNumTelePompiste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumPompiste = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPompiste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage.ForeColor = System.Drawing.Color.MintCream;
            this.btnImage.Location = new System.Drawing.Point(709, 227);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(176, 27);
            this.btnImage.TabIndex = 37;
            this.btnImage.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.NOM,
            this.PRENOM,
            this.CNS,
            this.ADRESSE,
            this.NUMEROTELE,
            this.IMAGE});
            this.dataGridView2.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.Location = new System.Drawing.Point(76, 331);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(931, 273);
            this.dataGridView2.TabIndex = 36;
            // 
            // Numéro
            // 
            this.Numéro.HeaderText = "Numéro";
            this.Numéro.MinimumWidth = 6;
            this.Numéro.Name = "Numéro";
            this.Numéro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Numéro.Width = 125;
            // 
            // NOM
            // 
            this.NOM.HeaderText = "NOM";
            this.NOM.MinimumWidth = 6;
            this.NOM.Name = "NOM";
            this.NOM.Width = 125;
            // 
            // PRENOM
            // 
            this.PRENOM.HeaderText = "PRENOM";
            this.PRENOM.MinimumWidth = 6;
            this.PRENOM.Name = "PRENOM";
            this.PRENOM.Width = 125;
            // 
            // CNS
            // 
            this.CNS.HeaderText = "CNS";
            this.CNS.MinimumWidth = 6;
            this.CNS.Name = "CNS";
            this.CNS.Width = 125;
            // 
            // ADRESSE
            // 
            this.ADRESSE.HeaderText = "ADRESSE";
            this.ADRESSE.MinimumWidth = 6;
            this.ADRESSE.Name = "ADRESSE";
            this.ADRESSE.Width = 125;
            // 
            // NUMEROTELE
            // 
            this.NUMEROTELE.HeaderText = "NUMERO DE TELE";
            this.NUMEROTELE.MinimumWidth = 6;
            this.NUMEROTELE.Name = "NUMEROTELE";
            this.NUMEROTELE.Width = 125;
            // 
            // IMAGE
            // 
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.MinimumWidth = 6;
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMAGE.Width = 125;
            // 
            // btnNouveauPompiste
            // 
            this.btnNouveauPompiste.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNouveauPompiste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveauPompiste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouveauPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauPompiste.ForeColor = System.Drawing.Color.MintCream;
            this.btnNouveauPompiste.Location = new System.Drawing.Point(411, 278);
            this.btnNouveauPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveauPompiste.Name = "btnNouveauPompiste";
            this.btnNouveauPompiste.Size = new System.Drawing.Size(206, 38);
            this.btnNouveauPompiste.TabIndex = 35;
            this.btnNouveauPompiste.Text = "Nouveau Pompiste";
            this.btnNouveauPompiste.UseVisualStyleBackColor = false;
            this.btnNouveauPompiste.Click += new System.EventHandler(this.btnNouveauPompiste_Click);
            // 
            // btnAjouterPompiste
            // 
            this.btnAjouterPompiste.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAjouterPompiste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPompiste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPompiste.ForeColor = System.Drawing.Color.MintCream;
            this.btnAjouterPompiste.Location = new System.Drawing.Point(201, 278);
            this.btnAjouterPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterPompiste.Name = "btnAjouterPompiste";
            this.btnAjouterPompiste.Size = new System.Drawing.Size(206, 38);
            this.btnAjouterPompiste.TabIndex = 34;
            this.btnAjouterPompiste.Text = "Ajouter Pompiste";
            this.btnAjouterPompiste.UseVisualStyleBackColor = false;
            this.btnAjouterPompiste.Click += new System.EventHandler(this.btnAjouterPompiste_Click);
            // 
            // btnSupprimerPompiste
            // 
            this.btnSupprimerPompiste.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSupprimerPompiste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerPompiste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerPompiste.ForeColor = System.Drawing.Color.MintCream;
            this.btnSupprimerPompiste.Location = new System.Drawing.Point(621, 278);
            this.btnSupprimerPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimerPompiste.Name = "btnSupprimerPompiste";
            this.btnSupprimerPompiste.Size = new System.Drawing.Size(206, 38);
            this.btnSupprimerPompiste.TabIndex = 33;
            this.btnSupprimerPompiste.Text = "Supprimer Pompiste";
            this.btnSupprimerPompiste.UseVisualStyleBackColor = false;
            this.btnSupprimerPompiste.Click += new System.EventHandler(this.btnSupprimerPompiste_Click);
            // 
            // pictureBoxPompiste
            // 
            this.pictureBoxPompiste.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPompiste.Image")));
            this.pictureBoxPompiste.Location = new System.Drawing.Point(728, 34);
            this.pictureBoxPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPompiste.Name = "pictureBoxPompiste";
            this.pictureBoxPompiste.Size = new System.Drawing.Size(132, 169);
            this.pictureBoxPompiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPompiste.TabIndex = 31;
            this.pictureBoxPompiste.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(172, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "CNS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(172, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(172, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "PRENOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(172, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "ADRESSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(172, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "NUMERO DE TELE";
            // 
            // textBoxAdressePompiste
            // 
            this.textBoxAdressePompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdressePompiste.Location = new System.Drawing.Point(360, 193);
            this.textBoxAdressePompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdressePompiste.Name = "textBoxAdressePompiste";
            this.textBoxAdressePompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxAdressePompiste.TabIndex = 25;
            // 
            // textBoxNomPompiste
            // 
            this.textBoxNomPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomPompiste.Location = new System.Drawing.Point(360, 72);
            this.textBoxNomPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomPompiste.Name = "textBoxNomPompiste";
            this.textBoxNomPompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxNomPompiste.TabIndex = 24;
            // 
            // textBoxPrenomPompiste
            // 
            this.textBoxPrenomPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenomPompiste.Location = new System.Drawing.Point(360, 113);
            this.textBoxPrenomPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrenomPompiste.Name = "textBoxPrenomPompiste";
            this.textBoxPrenomPompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxPrenomPompiste.TabIndex = 23;
            // 
            // textBoxCNSPompiste
            // 
            this.textBoxCNSPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNSPompiste.Location = new System.Drawing.Point(360, 156);
            this.textBoxCNSPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCNSPompiste.Name = "textBoxCNSPompiste";
            this.textBoxCNSPompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxCNSPompiste.TabIndex = 22;
            // 
            // textBoxNumTelePompiste
            // 
            this.textBoxNumTelePompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumTelePompiste.Location = new System.Drawing.Point(360, 231);
            this.textBoxNumTelePompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumTelePompiste.Name = "textBoxNumTelePompiste";
            this.textBoxNumTelePompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxNumTelePompiste.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(172, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = " Numéro Pompiste";
            // 
            // textBoxNumPompiste
            // 
            this.textBoxNumPompiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumPompiste.Location = new System.Drawing.Point(360, 34);
            this.textBoxNumPompiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumPompiste.Name = "textBoxNumPompiste";
            this.textBoxNumPompiste.Size = new System.Drawing.Size(320, 24);
            this.textBoxNumPompiste.TabIndex = 38;
            // 
            // frmPompiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.textBoxNumPompiste);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNouveauPompiste);
            this.Controls.Add(this.btnAjouterPompiste);
            this.Controls.Add(this.btnSupprimerPompiste);
            this.Controls.Add(this.pictureBoxPompiste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdressePompiste);
            this.Controls.Add(this.textBoxNomPompiste);
            this.Controls.Add(this.textBoxPrenomPompiste);
            this.Controls.Add(this.textBoxCNSPompiste);
            this.Controls.Add(this.textBoxNumTelePompiste);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPompiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pompiste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPompiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNouveauPompiste;
        private System.Windows.Forms.Button btnAjouterPompiste;
        private System.Windows.Forms.Button btnSupprimerPompiste;
        private System.Windows.Forms.PictureBox pictureBoxPompiste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdressePompiste;
        private System.Windows.Forms.TextBox textBoxNomPompiste;
        private System.Windows.Forms.TextBox textBoxPrenomPompiste;
        private System.Windows.Forms.TextBox textBoxCNSPompiste;
        private System.Windows.Forms.TextBox textBoxNumTelePompiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumPompiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROTELE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGE;
    }
}