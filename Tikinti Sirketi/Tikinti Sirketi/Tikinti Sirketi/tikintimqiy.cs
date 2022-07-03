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
    public partial class tikintimqiy : Form
    {
        public tikintimqiy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

                SqlConnection TikintiSirketiDBb = new SqlConnection(TikintiSirketiDB);
                TikintiSirketiDBb.Open();
                string Anbar = "Select * from Anbar where Materialın_növü  LIKE '%' +  N'" + malnNovu.Text + "' +'%' ";

                SqlDataAdapter sqlda = new SqlDataAdapter(Anbar, TikintiSirketiDBb);
                DataTable material = new DataTable();
                sqlda.Fill(material);
                AnbarM.DataSource = material;
            
        }

        private void malnNovu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anbaroperator anbar = new anbaroperator();
            anbar.Show();
            this.Hide();

        }

        private void tikintimqiy_Load(object sender, EventArgs e)
        {

        }
    }
}
