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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT ev, nev, szemely.id " +
                    "FROM kituntetes " +
                    "INNER JOIN szemely ON kituntetes.szemelyId = szemely.Id " +
                    "ORDER BY ev DESC, nev ASC;", conn).ExecuteReader();
                
                while (reader.Read())
                {
                    dgv.Rows.Add(reader[0], reader[1], reader[2]);
                    
                }
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string nev = dgv[1, e.RowIndex].Value.ToString();
            int id = Convert.ToInt32(dgv[2, e.RowIndex].Value);

            new FrmReszletek(nev, id).ShowDialog();
        }

        private void TsmiUj_Click(object sender, EventArgs e)
            => new FrmUj().ShowDialog();

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmKereses().ShowDialog();

        private void TsmiInfo_Click(object sender, EventArgs e)
        => new FrmInfo().ShowDialog();
    }
}
