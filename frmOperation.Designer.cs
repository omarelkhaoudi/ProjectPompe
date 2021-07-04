
namespace ProjectPompe
{
    partial class frmOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUDPrixLitre = new System.Windows.Forms.NumericUpDown();
            this.NUDNombreLitre = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumOperation = new System.Windows.Forms.TextBox();
            this.dataTPLheure = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.comboBoxCarburant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRemlissage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTPRemplissage = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NuméroOpération = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCarburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRemplissage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lheure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRemplissage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixLitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuméroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrénomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuméroCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDébutCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPrenomClient = new System.Windows.Forms.TextBox();
            this.textBoxNomClient = new System.Windows.Forms.TextBox();
            this.textBoxNumClient = new System.Windows.Forms.TextBox();
            this.dTPDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.dTPDateCarte = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumCarte = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrixLitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNombreLitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.NUDPrixLitre);
            this.groupBox1.Controls.Add(this.NUDNombreLitre);
            this.groupBox1.Controls.Add(this.textBoxNumOperation);
            this.groupBox1.Controls.Add(this.dataTPLheure);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textMontant);
            this.groupBox1.Controls.Add(this.comboBoxCarburant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxRemlissage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dataTPRemplissage);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(442, 421);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // NUDPrixLitre
            // 
            this.NUDPrixLitre.DecimalPlaces = 2;
            this.NUDPrixLitre.Location = new System.Drawing.Point(191, 327);
            this.NUDPrixLitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUDPrixLitre.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDPrixLitre.Name = "NUDPrixLitre";
            this.NUDPrixLitre.Size = new System.Drawing.Size(224, 21);
            this.NUDPrixLitre.TabIndex = 88;
            this.NUDPrixLitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPrixLitre.Value = new decimal(new int[] {
            965,
            0,
            0,
            131072});
            // 
            // NUDNombreLitre
            // 
            this.NUDNombreLitre.DecimalPlaces = 2;
            this.NUDNombreLitre.Location = new System.Drawing.Point(194, 121);
            this.NUDNombreLitre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUDNombreLitre.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDNombreLitre.Name = "NUDNombreLitre";
            this.NUDNombreLitre.Size = new System.Drawing.Size(224, 21);
            this.NUDNombreLitre.TabIndex = 87;
            this.NUDNombreLitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumOperation
            // 
            this.textBoxNumOperation.Location = new System.Drawing.Point(194, 20);
            this.textBoxNumOperation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumOperation.Name = "textBoxNumOperation";
            this.textBoxNumOperation.Size = new System.Drawing.Size(224, 21);
            this.textBoxNumOperation.TabIndex = 85;
            // 
            // dataTPLheure
            // 
            this.dataTPLheure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataTPLheure.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataTPLheure.Location = new System.Drawing.Point(194, 219);
            this.dataTPLheure.Name = "dataTPLheure";
            this.dataTPLheure.Size = new System.Drawing.Size(223, 21);
            this.dataTPLheure.TabIndex = 83;
            this.dataTPLheure.Value = new System.DateTime(2021, 6, 22, 14, 51, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "Numéro d\'operation :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Prix de Litre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Montant :";
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(194, 375);
            this.textMontant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(224, 21);
            this.textMontant.TabIndex = 78;
            // 
            // comboBoxCarburant
            // 
            this.comboBoxCarburant.FormattingEnabled = true;
            this.comboBoxCarburant.Items.AddRange(new object[] {
            "Essence",
            "Diésel"});
            this.comboBoxCarburant.Location = new System.Drawing.Point(195, 69);
            this.comboBoxCarburant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCarburant.Name = "comboBoxCarburant";
            this.comboBoxCarburant.Size = new System.Drawing.Size(223, 23);
            this.comboBoxCarburant.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Type  Remplissage :";
            // 
            // comboBoxRemlissage
            // 
            this.comboBoxRemlissage.FormattingEnabled = true;
            this.comboBoxRemlissage.Items.AddRange(new object[] {
            "Manuelle",
            "Automatique"});
            this.comboBoxRemlissage.Location = new System.Drawing.Point(194, 168);
            this.comboBoxRemlissage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRemlissage.Name = "comboBoxRemlissage";
            this.comboBoxRemlissage.Size = new System.Drawing.Size(222, 23);
            this.comboBoxRemlissage.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Date Remplissage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Heure de Remplire :";
            // 
            // dataTPRemplissage
            // 
            this.dataTPRemplissage.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataTPRemplissage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTPRemplissage.Location = new System.Drawing.Point(194, 273);
            this.dataTPRemplissage.Name = "dataTPRemplissage";
            this.dataTPRemplissage.Size = new System.Drawing.Size(223, 21);
            this.dataTPRemplissage.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Type de Carburant :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Nombre de Litre :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NuméroOpération,
            this.TypeCarburant,
            this.NombreLitre,
            this.TypeRemplissage,
            this.Lheure,
            this.DateRemplissage,
            this.PrixLitre,
            this.Montant,
            this.NuméroClient,
            this.NomClient,
            this.PrénomClient,
            this.DateNaissance,
            this.Adresse,
            this.Ville,
            this.NuméroCarte,
            this.DateDébutCarte});
            this.dataGridView1.Location = new System.Drawing.Point(37, 511);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 258);
            this.dataGridView1.TabIndex = 76;
            // 
            // NuméroOpération
            // 
            this.NuméroOpération.HeaderText = "Numéro Opération";
            this.NuméroOpération.MinimumWidth = 6;
            this.NuméroOpération.Name = "NuméroOpération";
            this.NuméroOpération.Width = 125;
            // 
            // TypeCarburant
            // 
            this.TypeCarburant.HeaderText = "Type de Carburant";
            this.TypeCarburant.MinimumWidth = 6;
            this.TypeCarburant.Name = "TypeCarburant";
            this.TypeCarburant.Width = 125;
            // 
            // NombreLitre
            // 
            this.NombreLitre.HeaderText = "Nombre de Litre";
            this.NombreLitre.MinimumWidth = 6;
            this.NombreLitre.Name = "NombreLitre";
            this.NombreLitre.Width = 125;
            // 
            // TypeRemplissage
            // 
            this.TypeRemplissage.HeaderText = "Type de remplissage";
            this.TypeRemplissage.MinimumWidth = 6;
            this.TypeRemplissage.Name = "TypeRemplissage";
            this.TypeRemplissage.Width = 125;
            // 
            // Lheure
            // 
            this.Lheure.HeaderText = "L\'heure";
            this.Lheure.MinimumWidth = 6;
            this.Lheure.Name = "Lheure";
            this.Lheure.Width = 125;
            // 
            // DateRemplissage
            // 
            this.DateRemplissage.HeaderText = "Date de remplissage";
            this.DateRemplissage.MinimumWidth = 6;
            this.DateRemplissage.Name = "DateRemplissage";
            this.DateRemplissage.Width = 125;
            // 
            // PrixLitre
            // 
            this.PrixLitre.HeaderText = "Prix de Litre";
            this.PrixLitre.MinimumWidth = 6;
            this.PrixLitre.Name = "PrixLitre";
            this.PrixLitre.Width = 125;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.MinimumWidth = 6;
            this.Montant.Name = "Montant";
            this.Montant.Width = 125;
            // 
            // NuméroClient
            // 
            this.NuméroClient.HeaderText = "Numéro Client";
            this.NuméroClient.MinimumWidth = 6;
            this.NuméroClient.Name = "NuméroClient";
            this.NuméroClient.Width = 125;
            // 
            // NomClient
            // 
            this.NomClient.HeaderText = "Nom Client";
            this.NomClient.MinimumWidth = 6;
            this.NomClient.Name = "NomClient";
            this.NomClient.Width = 125;
            // 
            // PrénomClient
            // 
            this.PrénomClient.HeaderText = "Prénom Client";
            this.PrénomClient.MinimumWidth = 6;
            this.PrénomClient.Name = "PrénomClient";
            this.PrénomClient.Width = 125;
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "DateNaissance";
            this.DateNaissance.MinimumWidth = 6;
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Width = 125;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            this.Adresse.Width = 125;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.Width = 125;
            // 
            // NuméroCarte
            // 
            this.NuméroCarte.HeaderText = "Numéro de Carte";
            this.NuméroCarte.MinimumWidth = 6;
            this.NuméroCarte.Name = "NuméroCarte";
            this.NuméroCarte.Width = 125;
            // 
            // DateDébutCarte
            // 
            this.DateDébutCarte.HeaderText = "Date Début Carte";
            this.DateDébutCarte.MinimumWidth = 6;
            this.DateDébutCarte.Name = "DateDébutCarte";
            this.DateDébutCarte.Width = 125;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(37, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 48);
            this.label5.TabIndex = 77;
            this.label5.Text = "                Service";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.MintCream;
            this.btnSupprimer.Location = new System.Drawing.Point(806, 694);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(224, 43);
            this.btnSupprimer.TabIndex = 83;
            this.btnSupprimer.Text = "Supprimer Operation";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.MintCream;
            this.btnNouveau.Location = new System.Drawing.Point(806, 618);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(224, 43);
            this.btnNouveau.TabIndex = 82;
            this.btnNouveau.Text = "Nouveau Operation";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.MintCream;
            this.btnAjouter.Location = new System.Drawing.Point(806, 541);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(224, 43);
            this.btnAjouter.TabIndex = 81;
            this.btnAjouter.Text = "Ajouter Operation";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(571, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(449, 48);
            this.label12.TabIndex = 86;
            this.label12.Text = "                InfoClient";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.textBoxPrenomClient);
            this.groupBox2.Controls.Add(this.textBoxNomClient);
            this.groupBox2.Controls.Add(this.textBoxNumClient);
            this.groupBox2.Controls.Add(this.dTPDateNaiss);
            this.groupBox2.Controls.Add(this.dTPDateCarte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxNumCarte);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.comboBoxVille);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxAdresse);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(568, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 421);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            // 
            // textBoxPrenomClient
            // 
            this.textBoxPrenomClient.Location = new System.Drawing.Point(201, 118);
            this.textBoxPrenomClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrenomClient.Name = "textBoxPrenomClient";
            this.textBoxPrenomClient.Size = new System.Drawing.Size(230, 21);
            this.textBoxPrenomClient.TabIndex = 95;
            // 
            // textBoxNomClient
            // 
            this.textBoxNomClient.Location = new System.Drawing.Point(201, 68);
            this.textBoxNomClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomClient.Name = "textBoxNomClient";
            this.textBoxNomClient.Size = new System.Drawing.Size(230, 21);
            this.textBoxNomClient.TabIndex = 94;
            // 
            // textBoxNumClient
            // 
            this.textBoxNumClient.Location = new System.Drawing.Point(201, 20);
            this.textBoxNumClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumClient.Name = "textBoxNumClient";
            this.textBoxNumClient.Size = new System.Drawing.Size(230, 21);
            this.textBoxNumClient.TabIndex = 93;
            // 
            // dTPDateNaiss
            // 
            this.dTPDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDateNaiss.Location = new System.Drawing.Point(201, 172);
            this.dTPDateNaiss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTPDateNaiss.Name = "dTPDateNaiss";
            this.dTPDateNaiss.Size = new System.Drawing.Size(228, 21);
            this.dTPDateNaiss.TabIndex = 92;
            // 
            // dTPDateCarte
            // 
            this.dTPDateCarte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDateCarte.Location = new System.Drawing.Point(201, 363);
            this.dTPDateCarte.Name = "dTPDateCarte";
            this.dTPDateCarte.Size = new System.Drawing.Size(230, 21);
            this.dTPDateCarte.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Numéro de Carte :";
            // 
            // textBoxNumCarte
            // 
            this.textBoxNumCarte.Location = new System.Drawing.Point(199, 317);
            this.textBoxNumCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumCarte.Name = "textBoxNumCarte";
            this.textBoxNumCarte.Size = new System.Drawing.Size(230, 21);
            this.textBoxNumCarte.TabIndex = 90;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.AliceBlue;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(22, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 85;
            this.label19.Text = "Ville :";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Items.AddRange(new object[] {
            "Casablanca",
            "Fes ",
            "Rabat",
            "Tanger",
            "Agadir",
            "Meknas",
            "Marrakech"});
            this.comboBoxVille.Location = new System.Drawing.Point(201, 269);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(228, 23);
            this.comboBoxVille.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "Numéro Client  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 366);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 17);
            this.label14.TabIndex = 79;
            this.label14.Text = "Date de Début Carte :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 223);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 77;
            this.label15.Text = "Adresse :";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(201, 223);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(228, 21);
            this.textBoxAdresse.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.AliceBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(20, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 17);
            this.label16.TabIndex = 72;
            this.label16.Text = "Date de Naissance :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 77);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 72);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Nom:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 69;
            this.label21.Text = "Prenom:";
            // 
            // frmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pompe";
            this.Load += new System.EventHandler(this.frmPompe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrixLitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNombreLitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dataTPLheure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMontant;
        private System.Windows.Forms.ComboBox comboBoxCarburant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRemlissage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataTPRemplissage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumCarte;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.DateTimePicker dTPDateNaiss;
        private System.Windows.Forms.DateTimePicker dTPDateCarte;
        private System.Windows.Forms.TextBox textBoxNumOperation;
        private System.Windows.Forms.TextBox textBoxPrenomClient;
        private System.Windows.Forms.TextBox textBoxNomClient;
        private System.Windows.Forms.TextBox textBoxNumClient;
        private System.Windows.Forms.NumericUpDown NUDPrixLitre;
        private System.Windows.Forms.NumericUpDown NUDNombreLitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuméroOpération;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCarburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRemplissage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lheure;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRemplissage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixLitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuméroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrénomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuméroCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDébutCarte;
    }
}