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
    public partial class frmZmiana : Form
    {
        public frmZmiana()
        {
            InitializeComponent();
        }

        private void btnWrocDoZaloguj_Click(object sender, EventArgs e)
        {
            //Powrót do logowania
            this.Hide();
            frmZaloguj frmZaloguj_op = new frmZaloguj();
            frmZaloguj_op.Show();
        }

        string Login = frmZaloguj.Login;

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string FilePath = "dane/";
            string OldFileName = (string)txtOldLogin.Text;
            
            string FileBaza = "bazy/";
            string OldFileBaza = OldFileName;
            
            OldFileName = Path.Combine(FilePath, OldFileName + ".txt");
            OldFileBaza = Path.Combine(FileBaza, OldFileBaza + ".txt");

            string[] dane = File.ReadAllLines(OldFileName);
            string[] dane2 = File.ReadAllLines(OldFileBaza);

            if (txtOldLogin.Text == dane[0] && txtOldHaslo.Text == dane[1] && txtNewHaslo.TextLength >= 8 && txtNewHaslo.Text == txtNewHaslo2nd.Text)
            {
                if (File.Exists(OldFileName) && File.Exists(OldFileBaza))
                {
                    File.Delete(OldFileName);
                    string NewFileName = (string)txtNewLogin.Text;
                    string NewFileBaza = NewFileName;
                    NewFileName = Path.Combine(FilePath, NewFileName + ".txt");
                    NewFileBaza = Path.Combine(FileBaza, NewFileBaza + ".txt");
                    File.WriteAllText(NewFileName, txtNewLogin.Text + "\n" + txtNewHaslo.Text);
                    File.Copy(OldFileBaza, NewFileBaza);
                    File.Delete(OldFileBaza);
                    MessageBox.Show("Dane zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNewHaslo.Text = "";
                    txtNewLogin.Text = "";
                    txtOldHaslo.Text = "";
                    txtOldLogin.Text = "";
                    txtNewHaslo2nd.Text = "";
                }
            }
            else if (txtOldLogin.Text != dane[0] && txtOldHaslo.Text != dane[1])
            {
                MessageBox.Show("Podano błędne stare dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNewHaslo.TextLength < 8)
            {
                MessageBox.Show("Nowe hasło jest za krótkie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNewHaslo.Text != txtNewHaslo2nd.Text)
            {
                MessageBox.Show("Nowe hasło zostało powtórzone błędnie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
