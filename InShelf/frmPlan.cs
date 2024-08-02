using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InShelf
{
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            //Otwiera frmProfil
            this.Hide();
            frmProfil frmProfil_op = new frmProfil();
            frmProfil_op.Show();
        }

        private void numStrony1_ValueChanged(object sender, EventArgs e)
        {
            if (numStrony1.Value != 0 && numDni1.Value != 0)
            {
                var i = Math.Round(numStrony1.Value / numDni1.Value);
                lblWynik1.Text = i.ToString() + " str/dzień";
            }
            else
            {
                lblWynik2.Text = "- str/dzień";
            }

        }

        private void numDni1_ValueChanged(object sender, EventArgs e)
        {
            if (numStrony1.Value != 0 && numDni1.Value != 0)
            {
                var i = Math.Round(numStrony1.Value / numDni1.Value);
                lblWynik1.Text = i.ToString() + " str/dzień";
            }
            else
            {
                lblWynik2.Text = "- str/dzień";
            }
        }

        private void numStrony2_ValueChanged(object sender, EventArgs e)
        {
            if (numStrony2.Value != 0 && numDni2.Value != 0)
            {
                var i = Math.Round(numStrony2.Value / numDni2.Value);
                lblWynik2.Text = i.ToString() + " dni";
            }
            else
            {
                lblWynik2.Text = "- dni";
            }
        }

        private void numDni2_ValueChanged(object sender, EventArgs e)
        {
            if (numStrony2.Value != 0 && numDni2.Value != 0)
            {
                var i = Math.Round(numStrony2.Value / numDni2.Value);
                lblWynik2.Text = i.ToString() + " dni";
            }
            else
            {
                lblWynik2.Text = "- dni";
            }
        }
    }
}
