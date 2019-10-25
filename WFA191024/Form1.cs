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

namespace WFA191024
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFilename=|DataDirectory|krea.mdf");
            InitializeComponent();

            tbKereses.TextChanged += Kereses;
            cbNevek.SelectedIndexChanged += Kereses;
            cbNevek.TextChanged += Kereses;

            LvFill();
            CbFill();
        }

        private void CbFill()
        {
            cbNevek.Items.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT ceg FROM ugyfelek GROUP BY ceg;", conn);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbNevek.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void LvFill()
        {
            lvAdatok.Items.Clear();
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM ugyfelek", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] lvis = { reader.GetInt32(0) + "", reader.GetString(1), reader.GetString(2) };
                var lvi = new ListViewItem(lvis);
                lvAdatok.Items.Add(lvi);
            }
            conn.Close();
        }

        private void Kereses(object sender, EventArgs e)
        {
            lvAdatok.Items.Clear();
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT * FROM ugyfelek " +
                $"WHERE nev LIKE '{tbKereses.Text}%' AND ceg LIKE '{cbNevek.Text}%';",
                conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] lvis = { reader.GetInt32(0) + "", reader.GetString(1), reader.GetString(2) };
                var lvi = new ListViewItem(lvis);
                lvAdatok.Items.Add(lvi);
            }
            conn.Close();
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            conn.Open();

            var adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO ugyfelek (nev, ceg) VALUES " +
                $"('{tbNev.Text}', '{tbCeg.Text}');", conn);

            adapter.InsertCommand.ExecuteNonQuery();

            conn.Close();

            LvFill();
            CbFill();
        }
    }
}
