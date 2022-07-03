using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tikinti_Sirketi
{
    public partial class emmelbaxs : Form
    {
        public emmelbaxs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emeliyyat emeliyyat = new emeliyyat();
            emeliyyat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

            SqlConnection TikintiSirketiDBb = new SqlConnection(TikintiSirketiDB);
            TikintiSirketiDBb.Open();
            SqlCommand Tikinti = new SqlCommand("Select * from Əməliyyat", TikintiSirketiDBb);

            SqlDataAdapter Tikintida = new SqlDataAdapter(Tikinti);
            DataTable tikintiMc = new DataTable();
            Tikintida.Fill(tikintiMc);
            dataGridView1.DataSource = tikintiMc;
        }

        private void emmelbaxs_Load(object sender, EventArgs e)
        {

        }
    }
}
