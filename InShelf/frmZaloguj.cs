namespace InShelf
{
    public partial class frmZaloguj : Form
    {
        public frmZaloguj()
        {
            InitializeComponent();
        }

        public static string Login = "";

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string FilePath = "dane/";
            string FileName = (string)txtLogin.Text;
            FileName = Path.Combine(FilePath, FileName + ".txt");

            if (File.Exists(FileName))
            {
                
                string[] dane = File.ReadAllLines(FileName);
                if (txtLogin.Text == dane[0] && txtHaslo.Text == dane[1])
                {
                    
                    Login = txtLogin.Text;
                    this.Hide();
                    frmProfil frmProfil_op = new frmProfil();
                    frmProfil_op.Show();
                }
                else if (txtHaslo.Text != dane[1] && txtLogin.Text != dane[0])
                {
                    MessageBox.Show("B��dne dane!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtHaslo.Text != dane[1])
                {
                    MessageBox.Show("B��dne has�o!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("B��dny login!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono takiego u�ytkownika.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            //Otwiera okno zmiany danych logowania
            this.Hide();
            frmZmiana frmZmiana_op = new frmZmiana();
            frmZmiana_op.Show();
            
        }

        private void btnDodajProfil_Click(object sender, EventArgs e)
        {
            //Przenosi do okienka w kt�rym mo�na doda� nowego u�ytkownika
            this.Hide();
            frmDodajUzytkownika frmDodajUzytkownika_op = new frmDodajUzytkownika();
            frmDodajUzytkownika_op.Show();
        }
    }
}