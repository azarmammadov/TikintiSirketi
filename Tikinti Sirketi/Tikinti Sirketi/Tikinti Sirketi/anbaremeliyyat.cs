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
    public partial class anbaremeliyyat : Form
    {
        public anbaremeliyyat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
            SqlConnection sqlTikintiDB = new SqlConnection(TikintiSirketiDB);
            sqlTikintiDB.Open();
            SqlCommand TikintiSirketiDBbax = new SqlCommand("Select * from Anbar", sqlTikintiDB);

            SqlDataAdapter TikintiSirketiDBadapter = new SqlDataAdapter(TikintiSirketiDBbax);
            DataTable TikintiDBbax = new DataTable();
            TikintiSirketiDBadapter.Fill(TikintiDBbax);
            AnbarDB.DataSource = TikintiDBbax;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emeliyyat emeliyyat1 = new emeliyyat();
            emeliyyat1.Show();
            this.Hide();
        }
    }
}
