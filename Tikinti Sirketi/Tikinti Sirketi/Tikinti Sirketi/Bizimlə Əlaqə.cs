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
    public partial class Bizimlə_Əlaqə : Form
    {
        public Bizimlə_Əlaqə()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.Text != "" && soyad.Text != "" && teklif.Text != "" && tel.Text != "" )
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand müraciətlər = new SqlCommand("INSERT into Müraciətlər (Ad, Soyad, Layihə_kodu, Təkliflər, Telefon ) values (N'" + ad.Text + "', N'" + soyad.Text + "', N'" + Layihecombo.Text + "', N'" + teklif.Text + "', @Telefon)", tikintiSDBd);
                müraciətlər.Parameters.AddWithValue("@Telefon", tel.Text);
                müraciətlər.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Müraciətiniz qeydə alındı. Qısa bir zamanda sizinlə əlaqə saxlanılacaqdır.\nBizi seçdiyiniz üçün təşəkkür edirik.", "Müraciət", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Müraciətiniz qeydə alınmadı. Zəhmət olmasa məlumatları tam şəkildə yazın.\nŞirkəmiz müştərilərimizin fikirlərinə önəm verir.", "Müraciət", MessageBoxButtons.OK);
            }
        }

        private void kecid_Click(object sender, EventArgs e)
        {
            Hesaba_giriş hesaba_Giriş = new Hesaba_giriş();
            hesaba_Giriş.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dizayn_və_Layihələr dizayn_Və_Layihələr = new Dizayn_və_Layihələr();
            dizayn_Və_Layihələr.Show();
            this.Hide();
        }

        private void Bizimlə_Əlaqə_Load(object sender, EventArgs e)
        {

        }
    }
}
