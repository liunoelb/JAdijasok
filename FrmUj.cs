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
    public partial class FrmUj : Form
    {
        public FrmUj()
        {
            InitializeComponent();
            nud.Minimum = 2017;
            nud.Maximum = DateTime.Now.Year;
        }

        private void BtnUjSzemely_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(tbFoglalkozas.Text))
                    errorMsg = "A foglalkozás nem maradhat üresen!";
                if (string.IsNullOrWhiteSpace(tbSzemelyNev.Text))
                    errorMsg = "A személy neve nem maradhat üresen!";
                if (!string.IsNullOrEmpty(errorMsg))
                    throw new Exception(errorMsg);

                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    int szemelyId = 0;
                    new SqlCommand(
                        "INSERT INTO szemely VALUES " +
                       $"((SELECT MAX(id) + 1 FROM szemely), '{tbSzemelyNev.Text}');",
                        conn).ExecuteNonQuery();
                    var reader = new SqlCommand(
                        "SELECT id " +
                        "FROM szemely " +
                       $"WHERE nev LIKE '{tbSzemelyNev.Text}';",
                        conn).ExecuteReader();
                    reader.Read();
                    szemelyId = reader.GetInt32(0);
                    reader.Close();
                    new SqlCommand(
                        "INSERT INTO foglalkozas VALUES" +
                       $"({szemelyId}, '{tbFoglalkozas.Text}');",
                        conn).ExecuteNonQuery();
                }
                MessageBox.Show(
                    text: "Az adatok sikeresen rögzültek!",
                    caption: "Információ",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);
                tbSzemelyNev2.Text = tbSzemelyNev.Text;
                tbSzemelyNev.Text = string.Empty;
                tbFoglalkozas.Text = string.Empty;
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    text: "Ilyen nevezetű személy már szerepel az adatbázisban!",
                    caption: "Hiba!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    text: $"{errorMsg}",
                    caption: "Hiba!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }

        private void BtnUjDij_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(tbSzemelyNev2.Text))
                    errorMsg = "A foglalkozás nem maradhat üresen!";
                if (!string.IsNullOrEmpty(errorMsg))
                    throw new Exception(errorMsg);

                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    int szemelyId = 0;
                    var reader = new SqlCommand(
                        "SELECT id " +
                        "FROM szemely " +
                       $"WHERE nev LIKE '{tbSzemelyNev2.Text}';",
                        conn).ExecuteReader();
                    reader.Read();
                    szemelyId = reader.GetInt32(0);
                    reader.Close();
                    new SqlCommand(
                        "INSERT INTO kituntetes VALUES" +
                       $"((SELECT MAX(id) + 1 FROM kituntetes), {szemelyId}, {nud.Value});", conn).ExecuteNonQuery();
                }

                MessageBox.Show(
                    text: "Az adatok sikeresen rögzültek!",
                    caption: "Információ",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    text: $"{errorMsg}",
                    caption: "Hiba!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }
    }
}
