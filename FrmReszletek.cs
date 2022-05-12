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
    public partial class FrmReszletek : Form
    {
        public string Nev { get; set; }
        public int Id { get; set; }
        public FrmReszletek(string nev, int id)
        {
            InitializeComponent();
            Nev = nev;
            Id = id;
        }

        private void FrmReszletek_Load(object sender, EventArgs e)
        {
            FillFields();
        }

        private void FillFields()
        {
            tbNev.Text = Nev;
            tbDatumok.Text = string.Empty;

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT megnevezes " +
                    "FROM foglalkozas " +
                   $"WHERE szemelyId = {Id};",
                   conn).ExecuteReader();
                while (reader.Read())
                {
                    lbFoglalkozas.Items.Add($"[*] {reader[0]}");
                }
                reader.Close();

                reader = new SqlCommand(
                    "SELECT ev " +
                    "FROM kituntetes " +
                   $"WHERE szemelyId = {Id};",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    tbDatumok.Text += $"{reader[0]}, ";
                }
            }
        }
    }
}
