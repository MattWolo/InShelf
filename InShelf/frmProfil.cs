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
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            //
            lblLogin.Text = frmZaloguj.Login;
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            //Powrót do logowania
            this.Hide();
            frmZaloguj frmZaloguj_op = new frmZaloguj();
            frmZaloguj_op.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            //Przejście do frmLista
            this.Hide();
            frmLista frmLista_op = new frmLista();
            frmLista_op.Show();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            //Otwiera frmPlan
            this.Hide();
            frmPlan frmPlan_op = new frmPlan();
            frmPlan_op.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Otwiera frmDodajKsiazke
            this.Hide();
            frmDodajKsiazke frmDodajKsiazke_op = new frmDodajKsiazke();
            frmDodajKsiazke_op.Show();
        }
    }
}
