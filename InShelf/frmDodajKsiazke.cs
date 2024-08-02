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
    public partial class frmDodajKsiazke : Form
    {
        public frmDodajKsiazke()
        {
            InitializeComponent();
        }
        public static string Tytul = "";
        public static string Autor = "";
        public static int StronyS;
        public static int StronyE;
        public static string Status = "";

        DataTable table = new DataTable();
        DataTable tableStatus = new DataTable();
        string Login = frmZaloguj.Login;

        private void frmDodajKsiazke_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Tytuł", typeof(string));
            table.Columns.Add("Autor", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Obecna S.", typeof(int));
            table.Columns.Add("Końcowa S.", typeof(int));
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtTytul.Text == "" || txtAutor.Text == "" || cboxStatus.Text == "" || numEnd.Value == 0)
            {
                MessageBox.Show("Jedno z pól jest pustych, lub nieprawidłowych. Uzupełnij je!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if( numStart.Value > numEnd.Value)
            {
                MessageBox.Show("Strona przeczytana nie może być większa niż stron w książce!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string[] lines = File.ReadAllLines("bazy/"+Login+".txt");
                string[] values;

                for (int x = 0; x < lines.Length; x++)
                {
                    values = lines[x].ToString().Split(';');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }

                int Start = (int)numStart.Value;
                int End = (int)numEnd.Value;

                Tytul = txtTytul.Text;
                Autor = txtAutor.Text;
                StronyS = Start;
                StronyE = End;
                Status = cboxStatus.Text;

                table.Rows.Add(txtTytul.Text, txtAutor.Text, cboxStatus.Text, StronyS, StronyE);
                txtTytul.Text = "";
                txtAutor.Text = "";
                cboxStatus.Text = "Planowane";
                numEnd.Value = 0;
                numStart.Value = 0;



                int i = 0;
                StreamWriter sw = null;

                sw = new StreamWriter("bazy/" + Login + ".txt"); ;

                foreach (DataRow row in table.Rows)
                {
                    object[] array = row.ItemArray;

                    for (i = 0; i < array.Length - 1; i++)
                    {
                        sw.Write(array[i].ToString() + ";");
                    }
                    sw.Write(array[i].ToString());
                    sw.WriteLine();

                }

                sw.Close();

            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Czy napewno chcesz wrócić do listy książek?", "Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLista frmLista_op = new frmLista();
                frmLista_op.Show();
            }
        }
    }
}
