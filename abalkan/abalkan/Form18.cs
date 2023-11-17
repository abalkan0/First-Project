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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void Form18_Enter(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
           
        }
    }
}
