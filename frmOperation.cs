using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPompe
{
    public partial class frmOperation : Form
    {
        public frmOperation()
        {
            InitializeComponent();
        }

        private void frmPompe_Load(object sender, EventArgs e)
        {
            dataTPLheure.Value = DateTime.Now;
            dataTPRemplissage.Value = System.DateTime.Today;

        }

        public void RemplireDataGridView1()
        {

            dataGridView1.Rows.Clear();

            for (int i = 0; i < Operation.ListeOperation.Count; i++)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells["NuméroOpération"].Value = Operation.ListeOperation[i].NuméroOpération;
                dataGridView1.Rows[i].Cells["TypeCarburant"].Value = Operation.ListeOperation[i].TypeCarburant;
                dataGridView1.Rows[i].Cells["NombreLitre"].Value = Operation.ListeOperation[i].NombreLitre;
                dataGridView1.Rows[i].Cells["TypeRemplissage"].Value = Operation.ListeOperation[i].TypeRemplissage;
                dataGridView1.Rows[i].Cells["Lheure"].Value = Operation.ListeOperation[i].Lheure;
                dataGridView1.Rows[i].Cells["DateRemplissage"].Value = Operation.ListeOperation[i].DateRemplissage;
                dataGridView1.Rows[i].Cells["PrixLitre"].Value = Operation.ListeOperation[i].PrixLitre;
                dataGridView1.Rows[i].Cells["Montant"].Value = Operation.ListeOperation[i].Montant;
                dataGridView1.Columns["Lheure"].DefaultCellStyle.Format = "HH:mm:ss";
                dataGridView1.Columns["DateRemplissage"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            for (int i = 0; i < Client.ListeClient.Count; i++)
            {
                dataGridView1.Rows[i].Cells["NuméroClient"].Value = Client.ListeClient[i].Num;
                dataGridView1.Rows[i].Cells["NomClient"].Value = Client.ListeClient[i].Nom;
                dataGridView1.Rows[i].Cells["PrénomClient"].Value = Client.ListeClient[i].Prenom;
                dataGridView1.Rows[i].Cells["DateNaissance"].Value = Client.ListeClient[i].DateNaissance;
                dataGridView1.Rows[i].Cells["Adresse"].Value = Client.ListeClient[i].Adresse;
                dataGridView1.Rows[i].Cells["Ville"].Value = Client.ListeClient[i].Ville;
                dataGridView1.Rows[i].Cells["NuméroCarte"].Value = Client.ListeClient[i].NumCarte;
                dataGridView1.Rows[i].Cells["DateDébutCarte"].Value = Client.ListeClient[i].DateDébutCarte;
                dataGridView1.Columns["DateNaissance"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["DateDébutCarte"].DefaultCellStyle.Format = "dd/MM/yyyy";


            }

        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNumOperation.Text.Length == 0 || textBoxNumClient.Text.Length == 0 || textBoxPrenomClient.Text.Length == 0 || textBoxNomClient.Text.Length == 0 || textBoxAdresse.Text.Length == 0 || textBoxNumCarte.Text.Length == 0 || comboBoxCarburant.SelectedItem == null || comboBoxRemlissage.SelectedItem == null || comboBoxVille.SelectedItem == null || textMontant.Text.Length == 0 || dTPDateNaiss.Value.ToString() == string.Empty || NUDNombreLitre.Value == 0)
            {
                MessageBox.Show(" Attention!!!  une information est vide ", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (textMontant.Text.All(char.IsNumber))
                {

                    Operation OP1 = new Operation(textBoxNumOperation.Text, comboBoxCarburant.Text, float.Parse(NUDNombreLitre.Text), comboBoxRemlissage.Text, dataTPLheure.Value, dataTPRemplissage.Value, float.Parse(NUDPrixLitre.Text), float.Parse(textMontant.Text));
                    Client Cl1 = new Client(textBoxNumClient.Text, textBoxNomClient.Text, textBoxPrenomClient.Text, dTPDateNaiss.Value, textBoxAdresse.Text, comboBoxVille.Text, textBoxNumCarte.Text, dTPDateCarte.Value);
                    OP1.AjouterOP(OP1);
                    Cl1.AjouterClient(Cl1);



                    MessageBox.Show("Operation ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RemplireDataGridView1();

                }
                else
                {
                    MessageBox.Show("Invalide Value ");
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
          
                try
                {
                    DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer Cette Operation?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        int index = this.dataGridView1.CurrentRow.Index;
                        this.dataGridView1.Rows.RemoveAt(index);
                        MessageBox.Show("La supprition avec succes");
                    }
                    else
                    {
                        MessageBox.Show("La supprition est ignord");
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Datagridview est Vide");
                }
            
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            textBoxNumClient.Text = "";
            textBoxAdresse.Text = "";
            textBoxNomClient.Text = "";
            textBoxNumCarte.Text = "";
            textBoxNumOperation.Text = "";
            textBoxPrenomClient.Text = "";
            textMontant.Text = "";
            textBoxNumCarte.Text = "";
            comboBoxCarburant.Text = "";
            comboBoxRemlissage.Text = "";
            comboBoxVille.Text = "";
            NUDNombreLitre.Value = 0;
            dTPDateCarte.Value = DateTime.Now;
            dTPDateNaiss.Value = DateTime.Now;
            dataTPLheure.Value = DateTime.Now;
            dataTPRemplissage.Value = System.DateTime.Today;





        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
