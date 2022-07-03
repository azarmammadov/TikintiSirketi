using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tikinti_Sirketi
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musterisorgu musterisorgu = new Musterisorgu();
            musterisorgu.Show();
            this.Hide();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            Dizayn_və_Layihələr dizayn_Və_Layihələr = new Dizayn_və_Layihələr();
            dizayn_Və_Layihələr.Show();
            this.Hide();
        }

        private void Operator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anbaroperator anbar = new anbaroperator();
            anbar.Show();
            this.Hide();
        }
    }
}
