using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abalkan
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public Form4 f4;
        private void Form8_Load(object sender, EventArgs e)
        {
            label1.Text = f4.adsoyad;
            label5.Text = f4.kadi;
            label6.Text = f4.sifre;
            label7.Text = f4.eposta;
            label4.Text = f4.tel;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
