using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tikinti_Sirketi
{
    public partial class Musterisorgu : Form
    {
        public Musterisorgu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

            SqlConnection TikintiSirketiDBb = new SqlConnection(TikintiSirketiDB);
            TikintiSirketiDBb.Open();
            SqlCommand Tikinti = new SqlCommand("Select * from Müraciətlər", TikintiSirketiDBb);

            SqlDataAdapter Tikintida = new SqlDataAdapter(Tikinti);
            DataTable tikintiMc = new DataTable();
            Tikintida.Fill(tikintiMc);
            dataGridView1.DataSource = tikintiMc;
        }

        private void Musterisorgu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operator op = new Operator();
            op.Show();
            this.Hide();
        }
    }
}
