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
    public partial class emeliyyat : Form
    {
        public emeliyyat()
        {
            InitializeComponent();
        }

        private void emeliyyat_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) )
            {
                e.Handled = true;
            }
        }

        private void d1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && d1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void d2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && d2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void miq_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.Text != "" && soyad.Text != "" && atad.Text != "" && unvan.Text != "" && SexsiyyetinFinKodu.Text != ""  || d1.Text != "" || d2.Text != "" || matrN.Text != "" || miq.Text != "" && sira.Text == "" )
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand anbar = new SqlCommand("INSERT into Əməliyyat (Ad, Soyad, Ata_adı, Doğum_tarixi, Yaşadığı_ünvan , Şəxsiyyətin_FinKodu, LayihəKodu, Dəyəri , Tarix, MaterialınNövü, MaterialınMiqdarı, Dəyər_Material) values (N'" + ad.Text + "', N'" + soyad.Text + "', N'" + atad.Text + "', @Doğum_tarixi, N'" + unvan.Text + "' , @Şəxsiyyətin_FinKodu, N'" + layihecombo.Text + "' , @Dəyəri , @Tarix, N'" + matrN.Text + "' , @MaterialınMiqdarı, @Dəyər_Material)", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Doğum_tarixi", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Şəxsiyyətin_FinKodu", SexsiyyetinFinKodu.Text);
                anbar.Parameters.AddWithValue("@Tarix", DateTime.Parse(daxilolma.Text));
                anbar.Parameters.AddWithValue("@Dəyəri", d1.Text);
                anbar.Parameters.AddWithValue("@MaterialınMiqdarı", miq.Text);
                anbar.Parameters.AddWithValue("@Dəyər_Material", d2.Text);
                anbar.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Məlumatlar yerləşdirildi", "Əməliyyat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Məlumatlar yerləşdirilmədi. Zəhmət olmasa Sıradan başqa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "Əməliyyat", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dizayn_və_Layihələr dizayn_Və_Layihələr = new Dizayn_və_Layihələr();
            dizayn_Və_Layihələr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ad.Text != "" && soyad.Text != "" && atad.Text != "" && unvan.Text != "" && SexsiyyetinFinKodu.Text != "" || d1.Text != "" || d2.Text != "" || matrN.Text != "" || miq.Text != "" && sira.Text != "")
            {
                
                    string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                    SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                    tikintiSDBd.Open();
                    SqlCommand anbar = new SqlCommand("UPDATE Əməliyyat set  Ad=N'" + ad.Text + "',Soyad= N'" + soyad.Text + "', Ata_adı= N'" + atad.Text + "', Doğum_tarixi=@Doğum_tarixi, Yaşadığı_ünvan=N'" + unvan.Text + "' , Şəxsiyyətin_FinKodu = @Şəxsiyyətin_FinKodu, LayihəKodu=N'" + layihecombo.Text + "', Dəyəri=@Dəyəri , Tarix=@Tarix, MaterialınNövü=N'" + matrN.Text + "', MaterialınMiqdarı=@MaterialınMiqdarı, Dəyər_Material= @Dəyər_Material ", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Doğum_tarixi", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Şəxsiyyətin_FinKodu", SexsiyyetinFinKodu.Text);
                anbar.Parameters.AddWithValue("@Tarix", DateTime.Parse(daxilolma.Text));
                anbar.Parameters.AddWithValue("@Dəyəri", d1.Text);
                anbar.Parameters.AddWithValue("@MaterialınMiqdarı", miq.Text);
                anbar.Parameters.AddWithValue("@Dəyər_Material", d2.Text);
                anbar.ExecuteNonQuery();
                    tikintiSDBd.Close();
                    MessageBox.Show("Məlumatlar yerləşdirildi", "Əməliyyat", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Məlumatlar yerləşdirilmədi. Zəhmət olmasa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "Əməliyyat", MessageBoxButtons.OK);
                }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" && soyad.Text == "" && atad.Text == "" && unvan.Text == "" && SexsiyyetinFinKodu.Text == "" || d1.Text == "" || d2.Text == "" || matrN.Text == "" || miq.Text == "" && sira.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

                SqlConnection Anbardansil = new SqlConnection(TikintiSirketiDB);
                Anbardansil.Open();
                SqlCommand anbar = new SqlCommand("DELETE Əməliyyat where Sıra=@Sıra ", Anbardansil);
                anbar.Parameters.AddWithValue("@Sıra", sira.Text);
                anbar.ExecuteNonQuery();
                Anbardansil.Close();
                MessageBox.Show("Məlumat istədiyiniz sıraya görə və ya istədiyiniz məlumata görə silinmə işini uğurla apardı .", "Əməliyyat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Təkcə Sıranı yazaraq əməliyyatı silə bilərsiniz.", "Əməliyyat", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anbaremeliyyat anbar = new anbaremeliyyat();
            anbar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emmelbaxs anbar = new emmelbaxs();
            anbar.Show();
            this.Hide();
        }
    }
}
