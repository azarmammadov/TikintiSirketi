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
    public partial class Hesaba_giriş : Form
    {
        public Hesaba_giriş()
        {
            InitializeComponent();
        }

        private void Hesaba_giriş_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dizayn_və_Layihələr dizayn_Və_Layihələr = new Dizayn_və_Layihələr();
            dizayn_Və_Layihələr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bizimlə_Əlaqə bizimlə = new Bizimlə_Əlaqə();
            bizimlə.Show();
            this.Hide();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sra.Text != "" && stfad.Text != "" && sifre.Text != "")
            {
                string TikintiSirketiDB = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=TikintiSirketiDataBase;Integrated Security=True";

                SqlConnection tikinti = new SqlConnection(TikintiSirketiDB);
                tikinti.Open();

                SqlCommand tikintisirketgiris = new SqlCommand("Select * from İnsanResusrları WHERE İşçi_sırası='" + sra.Text + "' and İstifadəçi_adı=N'" + stfad.Text + "' and Şifrə=N'" + sifre.Text + "' and Vəzifəsi=N'" + combo.Text + "'", tikinti);
               
                SqlDataReader oxu = tikintisirketgiris.ExecuteReader();
               

                if (oxu.Read() == true)
                {
                    if(combo.Text == "İnsan Resursları")
                    {
                        insan insan = new insan();
                        insan.Show();
                        this.Hide();
                    }
                    if (combo.Text == "Operator")
                    {
                        Operator op = new Operator();
                        op.Show();
                        this.Hide();
                    }
                    if (combo.Text == "Anbardar")
                    {
                        Anbardar op = new Anbardar();
                        op.Show();
                        this.Hide();
                    }
                    if (combo.Text == "Əməliyyatçı")
                    {
                        emeliyyat op = new emeliyyat();
                        op.Show();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Düzgün məlumatları daxil edin.", "Giriş mümkün deyil", MessageBoxButtons.OK);
                   
                }
            }
            else
            {
                MessageBox.Show("daxil etməni tam edin.");
            }
        }
    }
}
