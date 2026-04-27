using System.Collections;
using System.DirectoryServices.ActiveDirectory;

namespace paw_ex_Verificare_produs_parte_2
{


    public partial class Form1 : Form
    {
        ArrayList TBlistacalificative = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            TBlistacalificative.Add(txtCalificative);
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //verificare Produs: 

            if (txtNume.Text == "")
            {

                errorProvider1.SetError(txtNume, "Introduceti denumire Produs obligatoriu:");
                txtNume.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNume, "");
            }

            //pret:
            double pret = 0;
            try
            {
                pret = Convert.ToDouble(txtPret.Text);
            }
            catch
            {
                txtPret.Focus();
                txtPret.SelectAll();
                MessageBox.Show("introduceti doar numere!");
                return;
            }

            if (pret < 1 || pret > 10000)
            {
                txtPret.ForeColor = Color.Red;
                txtPret.Focus();
                txtPret.SelectAll();
                errorProvider1.SetError(txtPret, "Introduceti un numar in intervalul 1-10000");
                return;
            }
            else
            {
                txtPret.ForeColor = Color.Green;
                errorProvider1.SetError(txtPret, "");
            }



        }

        private void txtScor_KeyPress(object sender, KeyPressEventArgs e) // introducere Doar Cifre
        {
            if ((e.KeyChar > '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtScor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int scor = 0;
            try
            {
                scor = Convert.ToInt32(txtScor.Text);

            }
            catch
            {
                txtScor.Focus();
                txtScor.SelectAll();
                errorProvider1.SetError(txtScor, "introduceti doar cifre");
                return;
            }
            errorProvider1.SetError(txtScor, "");

            if (scor < 1 || scor > 10)
            {
                txtScor.Focus();
                txtScor.SelectAll();
                txtScor.ForeColor = Color.Red;
                errorProvider1.SetError(txtScor, "Introduceti un nr in intervalul 1-10");
                return;
            }
            else
            {
                txtScor.ForeColor = Color.Green;
                errorProvider1.SetError(txtScor, "");
            }



        }

        private void txtCalificative_TextChanged(object sender, EventArgs e)
        {
            txtCalificative.TextAlign = HorizontalAlignment.Right;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            int x = txtCalificative.Location.X; // salvez in v ariabila x locatia pe axa orizontala a textboxului deja existent
            int y = ((TextBox)TBlistacalificative[TBlistacalificative.Count - 1]).Location.Y;
            //salvez in variabila y locatia pe verticala a ultimului textBox 
            //initial va fi textBoxul deja existent 
            int w = txtCalificative.Width; // salvez in variabila w latimea textboxului initial pt a le construi pe celelalte exact la fel 


            //incep construirea celorlalte textBoxuri 
            TextBox tb = new TextBox();
            tb.Location = new Point(x, y + 30);
            tb.Width = w;
            tb.TextAlign = HorizontalAlignment.Right;


            TBlistacalificative.Add(tb);// il adaug in lista 
            Controls.Add(tb); // il adaug pe form 
            tb.Focus();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (TBlistacalificative.Count > 1)
            {
                TextBox deSters = ((TextBox)TBlistacalificative[TBlistacalificative.Count - 1]);
                Controls.Remove(deSters);
                TBlistacalificative.Remove(deSters);
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in TBlistacalificative)
            {
                errorProvider1.Clear();
                int t = 0;

                try
                {
                    t = Convert.ToInt32(tb.Text);
                }
                catch
                {
                    tb.Focus();
                    tb.SelectAll();
                    errorProvider1.SetError(tb, "introduceti doar cifre");
                    return;
                }
                errorProvider1.SetError(tb, "");

                if (t < 1 || t > 5)
                {
                    tb.ForeColor = Color.Red;
                    tb.Focus();
                    tb.SelectAll();
                    errorProvider1.SetError(tb, "introduceti nr in intervalul 1-5");
                    return;
                }
                else
                {
                    tb.ForeColor = Color.Green;
                    errorProvider1.SetError(tb, "");
                }


               


            }
            string text = "Produs: " + txtNume.Text + ", Pret: " + txtPret.Text + " ,Scor:" + txtScor.Text + "calificative:";

            for (int i = 0; i < TBlistacalificative.Count; i++)
            {
                text += ((TextBox)TBlistacalificative[i]).Text + ",";
            }

            listBox.Items.Add(text);
        }

        private void btnErrOn_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtScor, "eroare");
            errorProvider1.SetError(txtPret, "eroare");
        }

        private void btnErrOf_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void completareAutomataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtPret.Text = rnd.Next(1, 10001).ToString();
            txtScor.Text = rnd.Next(1, 11).ToString();

        }

        private void stergereDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtPret.Clear();
            txtScor.Clear();

            foreach(TextBox tb in TBlistacalificative)
            {
                tb.Clear();
               
            }
           
        }
    }
}
