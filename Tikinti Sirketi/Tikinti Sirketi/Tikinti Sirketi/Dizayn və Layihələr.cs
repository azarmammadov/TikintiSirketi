using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tikinti_Sirketi
{
    public partial class Dizayn_və_Layihələr : Form
    {
        public Dizayn_və_Layihələr()
        {
            InitializeComponent();
        }

        private void Dizayn_və_Layihələr_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bizimlə_Əlaqə be = new Bizimlə_Əlaqə();
            be.Show();
            this.Hide();
            
        }

        private void kecid_Click(object sender, EventArgs e)
        {
            Hesaba_giriş hg = new Hesaba_giriş();
            hg.Show();
            this.Hide();
        }
    }
}
