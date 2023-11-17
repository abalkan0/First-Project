using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace abalkan
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            f3.F2 = this;
        }
        public Form3 f3 = new Form3();
        public Form1 F1;
        public string yazi="";
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader oku;
        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip site = new ToolTip();
            site.IsBalloon = true;
            site.ForeColor = Color.Orange;
            site.IsBalloon = true;
            site.BackColor = Color.WhiteSmoke;

            site.SetToolTip(bunifuImageButton1, "İnternet Sayfama Gitmek İçin Tıklayınız");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text!="")
            {
                if (bunifuMaterialTextbox2.Text!="")
                {
                    if (bunifuMaterialTextbox1.Text=="abalkan" && bunifuMaterialTextbox2.Text=="1406")
                    {
                        this.Hide();
                        Form9 f9 = new Form9();
                        f9.ShowDialog();
                    }
                    else
                    {
                        string kadi= bunifuMaterialTextbox1.Text;
                        string sifre = bunifuMaterialTextbox2.Text;
                        baglanti= new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                        komut = new OleDbCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT * FROM kayıt where kadi='" + bunifuMaterialTextbox1.Text + "' AND sifre='" + bunifuMaterialTextbox2.Text + "'";
                        oku = komut.ExecuteReader();
                        if (oku.Read())
                        {
                            yazi = bunifuMaterialTextbox1.Text;
                            this.Close();
                            f3.ShowDialog();
                        }
                        else
                        {
                            Form20 f20 = new Form20();
                            this.Hide();
                            f20.ShowDialog();
                            //bunifuMaterialTextbox1.Text = "";
                            //bunifuMaterialTextbox2.Text = "";
                            //bunifu.MetaliralTextBot3.Text="";
                        }
                        baglanti.Close();
                        
                    }
                }
                else
                {
                    Form19 f19 = new Form19();
                    this.Hide();
                    f19.ShowDialog();
                }
            }
            else
            {
                Form18 f18 = new Form18();
                this.Hide();
                f18.ShowDialog();
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            //bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            //if (bunifuSwitch1.Value = false)
            //{
            //    this.BackColor = Color.WhiteSmoke;
            //}
            //else if (bunifuSwitch1.Value = true)
            //{
            //    this.BackColor = Color.Silver;
            }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
            //DialogResult exit = MessageBox.Show("Kapatmak İstediğine Emin Misin ?", "abalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (exit == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "")
            {
                if (bunifuMaterialTextbox2.Text != "")
                {
                    if (bunifuMaterialTextbox1.Text == "abalkan" && bunifuMaterialTextbox2.Text == "1406")
                    {
                        this.Hide();
                        Form9 f9 = new Form9();
                        f9.ShowDialog();
                    }
                    else
                    {
                        string kadi = bunifuMaterialTextbox1.Text;
                        string sifre = bunifuMaterialTextbox2.Text;
                        baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                        komut = new OleDbCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "SELECT * FROM kayıt where kadi='" + bunifuMaterialTextbox1.Text + "' AND sifre='" + bunifuMaterialTextbox2.Text + "'";
                        oku = komut.ExecuteReader();
                        if (oku.Read())
                        {
                            yazi = bunifuMaterialTextbox1.Text;
                            this.Close();
                            f3.ShowDialog();
                        }
                        else
                        {
                            Form20 f20 = new Form20();
                            this.Hide();
                            f20.ShowDialog();
                            //bunifuMaterialTextbox1.Text = "";
                            //bunifuMaterialTextbox2.Text = "";
                        }
                        baglanti.Close();

                    }
                }
                else
                {
                    Form19 f19 = new Form19();
                    this.Hide();
                    f19.ShowDialog();
                }
            }
            else
            {
                Form18 f18 = new Form18();
                this.Hide();
                f18.ShowDialog();
            }
        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.abalkan.com");
        }
        
    }
    }
    

