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
            cbNevek.SelectedIndexChanged += tbKereses_TextChanged;
            LvFill();
            CbFill();
        }

        private void CbFill()
        {
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

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {
            lvAdatok.Items.Clear();
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT * FROM ugyfelek " +
                $"WHERE nev LIKE '{tbKereses.Text}%' AND ceg LIKE '{cbNevek.SelectedItem}';",
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
    }
}
