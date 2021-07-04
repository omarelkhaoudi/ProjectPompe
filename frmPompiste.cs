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
    public partial class frmPompiste : Form
    {
        public frmPompiste()
        {
            InitializeComponent();
        }


        public void RemplireDataGridView2()
        {

            dataGridView2.Rows.Clear();

            for (int i = 0; i < Pompiste.ListePompiste.Count; i++)
            {
                dataGridView2.Rows.Add();

                dataGridView2.Rows[i].Cells["Numéro"].Value = Pompiste.ListePompiste[i].Numpompiste;
                dataGridView2.Rows[i].Cells["NOM"].Value = Pompiste.ListePompiste[i].Nompompiste;
                dataGridView2.Rows[i].Cells["PRENOM"].Value = Pompiste.ListePompiste[i].Prenompompiste;
                dataGridView2.Rows[i].Cells["CNS"].Value = Pompiste.ListePompiste[i].Cnspompiste;
                dataGridView2.Rows[i].Cells["ADRESSE"].Value = Pompiste.ListePompiste[i].Addresse;
                dataGridView2.Rows[i].Cells["NUMEROTELE"].Value = Pompiste.ListePompiste[i].NumTele;
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                dataGridView2.Columns.Add(img);
                dataGridView2.Rows.Add();


            }
        }

        private void btnAjouterPompiste_Click(object sender, EventArgs e)
        {
            if (textBoxCNSPompiste.Text.Length == 0 || textBoxAdressePompiste.Text.Length == 0 || textBoxNomPompiste.Text.Length == 0 || textBoxNumPompiste.Text.Length == 0 || textBoxNumTelePompiste.Text.Length == 0 || textBoxPrenomPompiste.Text.Length == 0 )
            {
                MessageBox.Show(" Attention!!!  une information est vide ", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Pompiste p1 = new Pompiste(textBoxNumPompiste.Text, textBoxCNSPompiste.Text, textBoxNomPompiste.Text, textBoxPrenomPompiste.Text, textBoxAdressePompiste.Text, textBoxNumTelePompiste.Text);
                p1.AjouterPomPiste(p1);

                MessageBox.Show("Pompiste ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RemplireDataGridView2();
            }
        }

        private void btnSupprimerPompiste_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer Ce Pompiste?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int index = this.dataGridView2.CurrentRow.Index;
                this.dataGridView2.Rows.RemoveAt(index);
                MessageBox.Show("La supprition avec succes");
            }
            else
            {
                MessageBox.Show("La supprition est ignord");
            }
        }

        private void btnNouveauPompiste_Click(object sender, EventArgs e)
        {
            textBoxNumPompiste.Text = "";
            textBoxCNSPompiste.Text = "";
            textBoxNomPompiste.Text = "";
            textBoxPrenomPompiste.Text = "";
            textBoxAdressePompiste.Text = "";
            textBoxNumTelePompiste.Text = "";
            pictureBoxPompiste.Image = null;
        }

       
    }
}
