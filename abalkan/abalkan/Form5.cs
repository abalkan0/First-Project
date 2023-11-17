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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Kayıt Edip , Kapatmak İstiyor Musun ?", "abalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("Değişiklik Başarıyla Tamamlandı.");               
                Form9 f9 = new Form9();
                this.Hide();
                f9.ShowDialog();


            }
            else
            {
                MessageBox.Show("Değişiklik Yapılmadı.");;
                Form9 f9 = new Form9();
                this.Hide();
                f9.ShowDialog();;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
