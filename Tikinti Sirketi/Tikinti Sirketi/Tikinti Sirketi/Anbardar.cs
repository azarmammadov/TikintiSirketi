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
    public partial class Anbardar : Form
    {
        public Anbardar()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && mebleg.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && miq.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void mebleg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Anbardar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (miq.Text != "" && mebleg.Text != "" && materialNovu.Text != "" && MaterialKodu.Text != "" && sira.Text == "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand anbar = new SqlCommand("INSERT into Anbar (Tarix, Məbləğ, Materialın_növü, Materialın_kodu, Materialın_miqdarı ) values (@Tarix, @Məbləğ, N'" + materialNovu.Text + "', @Materialın_kodu, @Materialın_miqdarı)", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Tarix", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Məbləğ", mebleg.Text);
                anbar.Parameters.AddWithValue("@Materialın_kodu", MaterialKodu.Text);
                anbar.Parameters.AddWithValue("@Materialın_miqdarı", miq.Text);
                anbar.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Anbara məlumatlar yerləşdirildi", "Anbar", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Anbara məlumatlar yerləşdirilmədi. Zəhmət olmasa Sıradan başqa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "Anbar", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hesaba_giriş hesaba_Giriş = new Hesaba_giriş();
            hesaba_Giriş.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Anbar anbar = new Anbar();
            anbar.Show();
            this.Hide();
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            if (miq.Text != "" && mebleg.Text != "" && materialNovu.Text != "" && MaterialKodu.Text != "" && sira.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand anbar = new SqlCommand("UPDATE Anbar set  Tarix=@Tarix, Məbləğ=@Məbləğ, Materialın_növü = N'" + materialNovu.Text + "', Materialın_kodu=@Materialın_kodu, Materialın_miqdarı=@Materialın_miqdarı where Sıra=@Sıra ", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Sıra", sira.Text);
                anbar.Parameters.AddWithValue("@Tarix", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Məbləğ", mebleg.Text);
                anbar.Parameters.AddWithValue("@Materialın_kodu", MaterialKodu.Text);
                anbar.Parameters.AddWithValue("@Materialın_miqdarı", miq.Text);
                anbar.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Anbara məlumatlar yerləşdirildi", "Anbar", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Anbara məlumatlar yerləşdirilmədi. Zəhmət olmasa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "Anbar", MessageBoxButtons.OK);
            }
        }

        private void sira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (miq.Text == "" && mebleg.Text == "" && materialNovu.Text == "" && MaterialKodu.Text == "" && sira.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

                SqlConnection Anbardansil = new SqlConnection(TikintiSirketiDB);
                Anbardansil.Open();
                SqlCommand anbar = new SqlCommand("DELETE Anbar where Sıra=@Sıra ", Anbardansil);
                anbar.Parameters.AddWithValue("@Sıra", sira.Text);
                anbar.ExecuteNonQuery();
                Anbardansil.Close();
                MessageBox.Show("Anbardan istədiyiniz sıraya görə və ya istədiyiniz məlumat silinmə işi uğurla aparıldı .", "Anbar", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Təkcə Sıranı yazaraq anbardan məlumatı silə bilərsiniz.", "Anbar", MessageBoxButtons.OK);
            }
        }
    }
}
