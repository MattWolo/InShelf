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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();

        string Login = frmZaloguj.Login;
        DataTable table2 = new DataTable();

        private void frmLista_Load(object sender, EventArgs e)
        {

            table2.Columns.Add("Tytuł", typeof(string));
            table2.Columns.Add("Autor", typeof(string));
            table2.Columns.Add("Status", typeof(string));
            table2.Columns.Add("Obecna S.", typeof(int));
            table2.Columns.Add("Końcowa S.", typeof(int));

            dgvLista.DataSource = table2;

            btnRemove.HeaderText = "Usuń";
            btnRemove.Text = "delete";
            btnRemove.Name = "btn";
            btnRemove.FillWeight = 50;
            btnRemove.UseColumnTextForButtonValue = true;
            dgvLista.Columns.Add(btnRemove);

            string[] lines = File.ReadAllLines("bazy/" + Login + ".txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table2.Rows.Add(row);
            }

            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Otwiera frmDodajKsiazke
            this.Close();
            frmDodajKsiazke frmDodajKsiazke_op = new frmDodajKsiazke();
            frmDodajKsiazke_op.Show();
        }

        private void btnWrocDoProfilu_Click(object sender, EventArgs e)
        {
            //Otwiera frmProfil
            DialogResult result;
            result = MessageBox.Show("Czy zostały wprowadzone zmiany?", "Question",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                StreamWriter sw = null;

                sw = new StreamWriter("bazy/" + Login + ".txt");

                foreach (DataRow row in table2.Rows)
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
                this.Hide();
            }

            this.Hide();
            frmProfil frmProfil_op = new frmProfil();
            frmProfil_op.Show();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLista.Columns["btn"].Index && e.RowIndex >= 0)
            {
                int index = Convert.ToInt32(e.RowIndex);
                table2.Rows[index].Delete();
                dgvLista.DataSource = table2;
            }
        }

        private void dgvLista_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvLista.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvLista_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = 0;
            StreamWriter sw = null;

            sw = new StreamWriter("bazy/" + Login + ".txt");

            foreach (DataRow row in table2.Rows)
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

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table2.DefaultView;
            dv.RowFilter = "Tytuł LIKE '" + txtSzukaj.Text + "%'";
            DataView dv2 = table2.DefaultView;
            dv2.RowFilter = "Autor LIKE '" + txtSzukaj.Text + "%'";
            dgvLista.DataSource = dv;
        }
    }
}
