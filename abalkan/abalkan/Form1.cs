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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.bunifuProgressBar1.Value != 100)
            {
                this.bunifuProgressBar1.Value +=5;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                f2.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

