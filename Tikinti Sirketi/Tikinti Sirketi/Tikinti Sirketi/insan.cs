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
    public partial class insan : Form
    {
        public insan()
        {
            InitializeComponent();
        }

        private void insan_Load(object sender, EventArgs e)
        {

        }

        private void maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && maas.Text.IndexOf('.') != -1)
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
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) )
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
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.Text != "" && soyad.Text != "" && atad.Text != "" && unvan.Text != "" && SexsiyyetinFinKodu.Text != "" && Vezifecombo.Text != "" && tecrube.Text != "" && maas.Text != "" && istfadeciAd.Text != "" && sifre.Text != "" && sira.Text == "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand anbar = new SqlCommand("INSERT into İnsanResusrları (Ad, Soyad, Ata_adı, Doğum_tarixi, Yaşadığı_ünvan , Şəxsiyyətin_FinKodu, Vəzifəsi, Təcrübəsi , İşə_girmə_tarixi, Maaş, İstifadəçi_adı, Şifrə) values (N'" + ad.Text + "', N'" + soyad.Text + "', N'" + atad.Text + "', @Doğum_tarixi, N'" + unvan.Text + "' , @Şəxsiyyətin_FinKodu, N'" + Vezifecombo.Text + "' , N'" + tecrube.Text + "' , @İşə_girmə_tarixi, @Maaş, N'" + istfadeciAd.Text + "' , N'" + sifre.Text + "' )", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Doğum_tarixi", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Şəxsiyyətin_FinKodu", SexsiyyetinFinKodu.Text);
                anbar.Parameters.AddWithValue("@İşə_girmə_tarixi", DateTime.Parse(daxilolma.Text));
                anbar.Parameters.AddWithValue("@Maaş", maas.Text);
                anbar.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Məlumatlar yerləşdirildi", "Insan Resusrları", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Məlumatlar yerləşdirilmədi. Zəhmət olmasa Sıradan başqa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "İnsan Resusrları", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ad.Text != "" && soyad.Text != "" && atad.Text != "" && unvan.Text != "" && SexsiyyetinFinKodu.Text != "" && tecrube.Text != "" && maas.Text != "" && istfadeciAd.Text != "" && sifre.Text != "" && Vezifecombo.Text != "" && sira.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";
                SqlConnection tikintiSDBd = new SqlConnection(TikintiSirketiDB);
                tikintiSDBd.Open();
                SqlCommand anbar = new SqlCommand("UPDATE İnsanResusrları set  Ad=N'" + ad.Text + "',Soyad= N'" + soyad.Text + "', Ata_adı= N'" + atad.Text + "', Doğum_tarixi=@Doğum_tarixi, Yaşadığı_ünvan=N'" + unvan.Text + "' , Şəxsiyyətin_FinKodu = @Şəxsiyyətin_FinKodu, Vəzifəsi=N'" + Vezifecombo.Text + "', Təcrübəsi=N'" + tecrube.Text + "' , İşə_girmə_tarixi=@İşə_girmə_tarixi, Maaş=@Maaş, İstifadəçi_adı=N'" + istfadeciAd.Text + "', Şifrə= N'" + sifre.Text + "' where İşçi_sırası=@İşçi_sırası ", tikintiSDBd);
                anbar.Parameters.AddWithValue("@Doğum_tarixi", DateTime.Parse(tarix.Text));
                anbar.Parameters.AddWithValue("@Şəxsiyyətin_FinKodu", SexsiyyetinFinKodu.Text);
                anbar.Parameters.AddWithValue("@İşə_girmə_tarixi", DateTime.Parse(daxilolma.Text));
                anbar.Parameters.AddWithValue("@Maaş", maas.Text);
                anbar.Parameters.AddWithValue("@İşçi_sırası", sira.Text);
                anbar.ExecuteNonQuery();
                tikintiSDBd.Close();
                MessageBox.Show("Məlumatlar yerləşdirildi", "İnsan Resusrları", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Məlumatlar yerləşdirilmədi. Zəhmət olmasa məlumatları tam daxil edin. Əksi təqdirdə məlumatlarlar DataBase-ə yerləşdirilməyəcəkdir.", "İnsanResusrları", MessageBoxButtons.OK);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" && soyad.Text == "" && atad.Text == "" && unvan.Text == "" && SexsiyyetinFinKodu.Text == "" && tecrube.Text == "" && maas.Text == "" && istfadeciAd.Text == "" && sifre.Text == ""  && sira.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

                SqlConnection Anbardansil = new SqlConnection(TikintiSirketiDB);
                Anbardansil.Open();
                SqlCommand anbar = new SqlCommand("DELETE İnsanResusrları where İşçi_sırası=@İşçi_sırası ", Anbardansil);
                anbar.Parameters.AddWithValue("@İşçi_sırası", sira.Text);
                anbar.ExecuteNonQuery();
                Anbardansil.Close();
                MessageBox.Show("Məlumat istədiyiniz sıraya görə və ya istədiyiniz məlumata görə silinmə işini uğurla apardı .", "İnsan Resursları", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Təkcə Sıranı yazaraq işçini silə bilərsiniz.", "İnsan Resursları", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dizayn_və_Layihələr dizayn_Və_Layihələr = new Dizayn_və_Layihələr();
            dizayn_Və_Layihələr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iscimelumat iscimeluma = new iscimelumat();
            iscimeluma.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
