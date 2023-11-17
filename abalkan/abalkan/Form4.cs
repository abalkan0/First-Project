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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            f8.f4 = this;
        }
        public string kadi = "";
        public string sifre = "";
        public string eposta = "";
        public string tel = "";
        public string adsoyad = "";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
        OleDbCommand komut;
        string ad = "";
        string soyad = "";
        public Form8 f8 = new Form8();
        public string abba = "";
        OleDbConnection con;
        OleDbConnection bag;
        OleDbConnection ek1;
        OleDbConnection ek2;
        OleDbCommand cmd;
        OleDbCommand ek11;
        OleDbCommand ek12;
        OleDbDataReader dr;
        OleDbDataReader ek21;
        OleDbDataReader ek22;

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var ctl in bunifuMaterialTextbox7.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))

                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = 11;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            
            }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
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
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked==true)
            {
                if (bunifuMaterialTextbox4.Text==bunifuMaterialTextbox5.Text)
                {
                    if (bunifuMaterialTextbox1.Text!="")
                    {
                        if (bunifuMaterialTextbox2.Text !="")
                        {
                            if (bunifuMaterialTextbox3.Text !="")
                            {
                                if (bunifuMaterialTextbox4.Text!="")
                                {
                                    if (bunifuMaterialTextbox5.Text !="")
                                    {
                                        if (bunifuMaterialTextbox6.Text !="")
                                        {
                                            if (bunifuMaterialTextbox7.Text !="")
                                            {
                                                string kkadı = bunifuMaterialTextbox3.Text;
                                                ek1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                                                ek11 = new OleDbCommand();
                                                ek1.Open();
                                                ek11.Connection = ek1;
                                                ek11.CommandText = "SELECT * FROM kayıt where kadi='" + bunifuMaterialTextbox3.Text + "'";
                                                ek21 = ek11.ExecuteReader();
                                                if (ek21.Read())
                                                {
                                                    //string eepst = bunifuMaterialTextbox6.Text;
                                                    //ek2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                                                    //ek12 = new OleDbCommand();
                                                    //ek2.Open();
                                                    //ek12.Connection = ek1;
                                                    //ek12.CommandText = "SELECT * FROM kayıt where eposta='" + bunifuMaterialTextbox6.Text + "'";
                                                    //ek22 = ek12.ExecuteReader();
                                                    Form24 f24 = new Form24();
                                                    this.Hide();
                                                    f24.ShowDialog();
                                                    
                                                    if (ek22.Read())
                                                    {
                                                        //ad = bunifuMaterialTextbox1.Text;
                                                        //soyad = bunifuMaterialTextbox2.Text;
                                                        //kadi = bunifuMaterialTextbox3.Text;
                                                        //sifre = bunifuMaterialTextbox4.Text;
                                                        //eposta = bunifuMaterialTextbox6.Text;
                                                        //tel = bunifuMaterialTextbox7.Text;
                                                        //adsoyad = bunifuMaterialTextbox1.Text + " " + bunifuMaterialTextbox2.Text;
                                                        //baglanti.Open();
                                                        //komut = new OleDbCommand("insert into kayıt(ad,soyad,kadi,sifre,eposta,telefon) values (@ad,@soyad,@kadi,@sifre,@eposta,@telefon)", baglanti);
                                                        //komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox1.Text);
                                                        //komut.Parameters.AddWithValue("@soyad", bunifuMaterialTextbox2.Text);
                                                        //komut.Parameters.AddWithValue("@kadi", bunifuMaterialTextbox3.Text);
                                                        //komut.Parameters.AddWithValue("@sifre", bunifuMaterialTextbox4.Text);
                                                        //komut.Parameters.AddWithValue("@eposta", bunifuMaterialTextbox6.Text);
                                                        //komut.Parameters.AddWithValue("@telefon", (bunifuMaterialTextbox7.Text));
                                                        //komut.ExecuteNonQuery();
                                                        //baglanti.Close();
                                                        //bunifuMaterialTextbox1.Text = "";
                                                        //bunifuMaterialTextbox2.Text = "";
                                                        //bunifuMaterialTextbox3.Text = "";
                                                        //bunifuMaterialTextbox4.Text = "";
                                                        //bunifuMaterialTextbox5.Text = "";
                                                        //bunifuMaterialTextbox6.Text = "";
                                                        //bunifuMaterialTextbox7.Text = "";
                                                        //bunifuCheckbox1.Enabled = false;
                                                        //textBox1.Focus();
                                                        //this.Hide();
                                                        //f8.ShowDialog();
                                                        //Form25 f25 = new Form25();
                                                        //this.Hide();
                                                        //f25.ShowDialog();

                                                    }
                                                    else
                                                    {
                                                        //eposta
                                                        //Form25 f25 = new Form25();
                                                        //this.Hide();
                                                        //f25.ShowDialog();
                                                        //ad = bunifuMaterialTextbox1.Text;
                                                        //soyad = bunifuMaterialTextbox2.Text;
                                                        //kadi = bunifuMaterialTextbox3.Text;
                                                        //sifre = bunifuMaterialTextbox4.Text;
                                                        //eposta = bunifuMaterialTextbox6.Text;
                                                        //tel = bunifuMaterialTextbox7.Text;
                                                        //adsoyad = bunifuMaterialTextbox1.Text + " " + bunifuMaterialTextbox2.Text;
                                                        //baglanti.Open();
                                                        //komut = new OleDbCommand("insert into kayıt(ad,soyad,kadi,sifre,eposta,telefon) values (@ad,@soyad,@kadi,@sifre,@eposta,@telefon)", baglanti);
                                                        //komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox1.Text);
                                                        //komut.Parameters.AddWithValue("@soyad", bunifuMaterialTextbox2.Text);
                                                        //komut.Parameters.AddWithValue("@kadi", bunifuMaterialTextbox3.Text);
                                                        //komut.Parameters.AddWithValue("@sifre", bunifuMaterialTextbox4.Text);
                                                        //komut.Parameters.AddWithValue("@eposta", bunifuMaterialTextbox6.Text);
                                                        //komut.Parameters.AddWithValue("@telefon", (bunifuMaterialTextbox7.Text));
                                                        //komut.ExecuteNonQuery();
                                                        //baglanti.Close();
                                                        //bunifuMaterialTextbox1.Text = "";
                                                        //bunifuMaterialTextbox2.Text = "";
                                                        //bunifuMaterialTextbox3.Text = "";
                                                        //bunifuMaterialTextbox4.Text = "";
                                                        //bunifuMaterialTextbox5.Text = "";
                                                        //bunifuMaterialTextbox6.Text = "";
                                                        //bunifuMaterialTextbox7.Text = "";
                                                        //bunifuCheckbox1.Enabled = false;
                                                        //textBox1.Focus();
                                                        //this.Hide();
                                                        //f8.ShowDialog();
                                                    }
                                                    //con.Close();
                                                }
                                                else
                                                {
                                                    string eepst = bunifuMaterialTextbox6.Text;
                                                    ek2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                                                    ek12 = new OleDbCommand();
                                                    ek2.Open();
                                                    ek12.Connection = ek1;
                                                    ek12.CommandText = "SELECT * FROM kayıt where eposta='" + bunifuMaterialTextbox6.Text + "'";
                                                    ek22 = ek12.ExecuteReader();
                                                    if (ek22.Read())
                                                    {
                                                        Form25 f25 = new Form25();
                                                        this.Hide();
                                                        f25.ShowDialog();
                                                    }
                                                    else
                                                    {
                                                        ad = bunifuMaterialTextbox1.Text;
                                                        soyad = bunifuMaterialTextbox2.Text;
                                                        kadi = bunifuMaterialTextbox3.Text;
                                                        sifre = bunifuMaterialTextbox4.Text;
                                                        eposta = bunifuMaterialTextbox6.Text;
                                                        tel = bunifuMaterialTextbox7.Text;
                                                        adsoyad = bunifuMaterialTextbox1.Text + " " + bunifuMaterialTextbox2.Text;
                                                        baglanti.Open();
                                                        komut = new OleDbCommand("insert into kayıt(ad,soyad,kadi,sifre,eposta,telefon) values (@ad,@soyad,@kadi,@sifre,@eposta,@telefon)", baglanti);
                                                        komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox1.Text);
                                                        komut.Parameters.AddWithValue("@soyad", bunifuMaterialTextbox2.Text);
                                                        komut.Parameters.AddWithValue("@kadi", bunifuMaterialTextbox3.Text);
                                                        komut.Parameters.AddWithValue("@sifre", bunifuMaterialTextbox4.Text);
                                                        komut.Parameters.AddWithValue("@eposta", bunifuMaterialTextbox6.Text);
                                                        komut.Parameters.AddWithValue("@telefon", (bunifuMaterialTextbox7.Text));
                                                        komut.ExecuteNonQuery();
                                                        baglanti.Close();
                                                        //int a1 = int.Parse(bunifuMaterialTextbox1.Text);
                                                        //int a2 = int.Parse(bunifuMaterialTextbox2.Text);
                                                        //int a3 = int.Parse(bunifuMaterialTextbox3.Text);
                                                        //int a4 = int.Parse(bunifuMaterialTextbox4.Text);
                                                        //int a5 = int.Parse(bunifuMaterialTextbox5.Text);
                                                        //int a6 = int.Parse(bunifuMaterialTextbox6.Text);
                                                        //int a7 = int.Parse(bunifuMaterialTextbox7.Text);
                                                        //bunifuCheckbox1.Enabled = false;
                                                        //bunifuMaterialTextbox1.Text = a1.ToString();
                                                        //bunifuMaterialTextbox2.Text = a2.ToString();
                                                        //bunifuMaterialTextbox3.Text = a3.ToString();
                                                        //bunifuMaterialTextbox4.Text = a4.ToString();
                                                        //bunifuMaterialTextbox5.Text = a5.ToString();
                                                        //bunifuMaterialTextbox6.Text = a6.ToString();
                                                        //bunifuMaterialTextbox7.Text = a7.ToString();
                                                        //bunifuCheckbox1.Enabled = false;
                                                        bunifuMaterialTextbox1.Text = "";
                                                        bunifuMaterialTextbox2.Text = "";
                                                        bunifuMaterialTextbox3.Text = "";
                                                        bunifuMaterialTextbox4.Text = "";
                                                        bunifuMaterialTextbox5.Text = "";
                                                        bunifuMaterialTextbox6.Text = "";
                                                        bunifuMaterialTextbox7.Text = "";
                                                        bunifuCheckbox1.Enabled = true;
                                                        textBox1.Focus();
                                                        this.Hide();
                                                        f8.ShowDialog();
                                                    }
                                                    //kullanıcıadı
                                                    //Form24 f24 = new Form24();
                                                    //this.Hide();
                                                    //f24.ShowDialog();
                                                }
                                                //con.Close();                                               
                                            }
                                            else
                                            {
                                                Form15 f15 = new Form15();
                                                this.Hide();
                                                f15.ShowDialog();
                                            }
                                        }
                                        else
                                        {
                                            Form14 f14 = new Form14();
                                            this.Hide();
                                            f14.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        Form13 f13 = new Form13();
                                        this.Hide();
                                        f13.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Form13 f13 = new Form13();
                                    this.Hide();
                                    f13.ShowDialog();
                                }
                            }
                            else
                            {
                                Form12 f12 = new Form12();
                                this.Hide();
                                f12.ShowDialog();
                            }
                        }
                        else
                        {
                            Form11 f11 = new Form11();
                            this.Hide();
                            f11.ShowDialog();
                        }
                    }
                    else
                    {
                        Form10 f10 = new Form10();
                        this.Hide();
                        f10.ShowDialog();
                    }
                }
                else
                {
                    Form17 f17 = new Form17();
                    this.Hide();
                    f17.ShowDialog();
                }
            }
            else
            {                
                Form16 f16 = new Form16();
                this.Hide();
                f16.ShowDialog();
            }

        }

        private void bunifuMaterialTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox8.Text!="")
            {
                if (bunifuMaterialTextbox10.Text!="")
                {
                    string kullanıcıadı = bunifuMaterialTextbox8.Text;
                    string sifresi = bunifuMaterialTextbox10.Text;
                    con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayitlar.mdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM kayıt where kadi='" + bunifuMaterialTextbox8.Text + "' AND eposta='" + bunifuMaterialTextbox10.Text + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        var psifre = dr.GetFieldValue<string>(3);
                        //var padi = dr.GetFieldValue<string>(1);
                        //var psoyadi = dr.GetFieldValue<string>(2);
                        bunifuMaterialTextbox8.Text = "";
                        bunifuMaterialTextbox10.Text = "";
                        textBox1.Focus();
                        MessageBox.Show("Şifren :"+psifre);
                        //MessageBox.Show(string.Format("Sayın, {0} {1} \n\r Şifreniz:'{2}'", padi, psoyadi, psifre));

                    }
                    else
                    {
                        Form21 f21 = new Form21();
                        this.Hide();
                        f21.ShowDialog();
                    }
                    con.Close();
                }
                else
                {
                    Form23 f23 = new Form23();
                    this.Hide();
                    f23.ShowDialog();
                }
            }
            else
            {
                Form22 f22 = new Form22();
                this.Hide();
                f22.ShowDialog();
            }
        }
    }
    }

