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
    public partial class Form3 : Form
    {
        public Form2 F2;
        public Form3()
        {
            InitializeComponent();
            
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = F2.yazi;

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            //DialogResult exit = MessageBox.Show("Ana Sayfaya Geri Dönmek İstediğine Emin Misin ?", "abalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (exit == DialogResult.Yes)
            //{
            //    Form2 f2 = new Form2();
            //    this.Hide();
            //    f2.Show();

            //}
        }
    }
}
