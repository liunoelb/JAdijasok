using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAdijasok
{
    public partial class FrmKereses : Form
    {
        public FrmKereses()
        {
            InitializeComponent();
        }

        private void FrmKereses_Load(object sender, EventArgs e)
            => FillDGV();
        private void TbSzures_TextChanged(object sender, EventArgs e)
            => FillDGV();

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT id, nev " +
                    "FROM szemely " +
                   $"WHERE nev LIKE '%{tbSzures.Text}%'" +
                   $"ORDER BY id;", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(reader[0], reader[1]);
                }
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv[0, e.RowIndex].Value);
            string nev = dgv[1, e.RowIndex].Value.ToString();

            new FrmReszletek(nev, id).ShowDialog();
        }
    }
}
