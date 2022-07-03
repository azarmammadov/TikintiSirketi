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
    public partial class anbaroperator : Form
    {
        public anbaroperator()
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
            Operator op1 = new Operator();
            op1.Show();
            this.Hide();
        }
        

        private void anbaroperator_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tikintimqiy tq = new tikintimqiy();
            tq.Show();
            this.Hide();
        }
    }
}
