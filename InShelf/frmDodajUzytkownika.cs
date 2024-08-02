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
    public partial class frmDodajUzytkownika : Form
    {
        public frmDodajUzytkownika()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Dodaje użytkownika
            string FilePath = @"dane/";
            string BazyPath = @"bazy/";
            string FileName = (string)txtNewUserLogin.Text;
            string FileBazyName;

            FileBazyName = Path.Combine(BazyPath, FileName + ".txt");
            FileName = Path.Combine(FilePath, FileName + ".txt");
            
            if (File.Exists(FileName))
            {
                MessageBox.Show("Podany login jest już zajęty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNewUserHaslo.TextLength < 8)
            {
                MessageBox.Show("Hasło jest zbyt krótkie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNewUserHaslo.Text != txtNewUserHaslo2nd.Text)
            {
                MessageBox.Show("Hasła się od siebie różnią", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.WriteAllText(FileName, txtNewUserLogin.Text + "\n" + txtNewUserHaslo.Text);
                File.WriteAllText(FileBazyName,"");
                txtNewUserLogin.Text = "";
                txtNewUserHaslo.Text = "";
                txtNewUserHaslo2nd.Text = "";
                MessageBox.Show("Dane zostały dodane poprawnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWrocDoZaloguj_Click(object sender, EventArgs e)
        {
            //Powrót do logowania
            this.Hide();
            frmZaloguj frmZaloguj_op = new frmZaloguj();
            frmZaloguj_op.Show();
        }
    }
}
