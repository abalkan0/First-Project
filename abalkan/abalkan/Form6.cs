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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
                Form9 f9 = new Form9();
                this.Hide();
                f9.ShowDialog();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            bunifuSeparator2.Visible = true;
            bunifuSeparator3.Visible = true;
            bunifuCards2.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;
            bunifuCards4.Visible = false;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label28.Visible = false;
            label5.Visible = false;
            label38.Visible = false;
            label18.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label15.Visible = false;
            label9.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;
            label10.Visible = false;
            bunifuSeparator2.Visible = false;
            bunifuSeparator3.Visible = false;
            ToolTip aciklama = new ToolTip();
            aciklama.IsBalloon = true;
            aciklama.ForeColor = Color.Orange;
            aciklama.IsBalloon = true;
            aciklama.BackColor = Color.WhiteSmoke;

            aciklama.SetToolTip(label2, "If-Else Deyimi\r\n \r\nIf deyimi bir programın akışını kontrol etmek için kullanılır.\r\nBelirli bir şarta göre yapılması istenilen işlemler , If-Else deyimi kullanılarak gerçekleştirilir. \r\n \r\nKullanımı : \r\n  \r\nif(koşul) \r\n{ \r\nKoşul doğruysa yapılacak işlemler;\r\n}\r\nelse \r\n{ \r\nKoşul yanlışsa yapılacak işlemler;\r\n}");

            aciklama.SetToolTip(label3, "İç-İçe If İfadesi\r\n \r\nBirden fazla koşula ihtiyaç duyulan durumlarda İç-İçe If ifadesi kullanılır. \r\nBir if koşuluna kaç tane else if ekleyebileceğiniz konusunda hiçbir sınır yoktur.\r\n \r\nKullanımı :\r\n  \r\nif(koşul1) \r\n{ \r\nkoşul1 doğruysa yapılacak işlemler;\r\n}\r\nelse if(koşul2)\r\n{\r\nkoşul1 yanlışsa ve koşul2 doğruysa yapılacak işlemler;\r\n}\r\nelse\r\n{\r\nher iki koşul da yanlışsa yapılacak işlemler;\r\n}");

            aciklama.SetToolTip(label4, "Switch-Case Deyimi\r\n \r\nSwitch-Case deyimi de If-Else deyimleri gibi karar kontrol mekanizmalarında kullanılmaktadır.\r\n Switch-Case deyimi genellikle karmaşık if-else bloklarının yerine \r\ndaha okunabilir oldukları için tercih edilmektedir.\r\nSwitch-Case ile yapabileceğimiz karşılaştırmaları if-else ile de yapabiliriz. \r\nSwitch-Case yapısı şu şekilde çalışır;\r\nbir deyimin değeri, sabitlerden oluşan bir listede peş peşe test edilir.\r\nDeyimin değeri sabitlerden birisiyle eşleşince, bu eşleşmeyle ilgili işlemler gerçekleştirilir.\r\n \r\nKullanımı :\r\n \r\nswitch(ifade)\r\n{\r\ncase 1:\r\n         Yapılacak işlemler;\r\n         break;\r\ncase 2:\r\n         Yapılacak işlemler;\r\n         break;\r\ncase 3:\r\n         Yapılacak işlemler;\r\n         break;\r\ndefault:\r\n        Yapılacak işlemler;\r\n         break;\r\n}");

            aciklama.SetToolTip(label5, "For Döngüsü\r\n \r\nBelirlenen başlangıç değerinden itibaren belirtilen koşul\r\nsağlanana kadar içine yazıldığı kod parçasını ardı ardına çalıştıran bir döngü çeşididir.\r\n \r\nKullanımı : \r\n  \r\nfor(başlangıç;koşul;artım)\r\n{\r\nyapılacak işler;\r\n}");

            aciklama.SetToolTip(label6, "While Döngüsü\r\n \r\nWhile döngüsü bir koşul sağlanıyorken dönmeye devam eder.\r\nKoşul yanlış (false) sonucunu verdiği zaman ise sonlandırılır.\r\n \r\nKullanımı : \r\n  \r\nwhile(koşul)\r\n{\r\nyapılacak işler;\r\n}");
            aciklama.SetToolTip(label7, "Do..While Döngüsü\r\n \r\nFor ve while döngülerinde döngü bloklarının koşul sağlanmadığı takdirde hiç çalıştırılmama ihtimali vardır.\r\nAncak döngünün en az bir kere çalıştırılması istenilen durumlarda do while döngüleri kullanılır.\r\nDo-While döngülerinde koşul döngü içerisindeki işlemler bir kez gerçekleştirildikten sonra kontrol edilir.\r\nKoşul doğru olduğu müddetçe de döngü içerisindeki işlemler tekrarlanmayı sürdürür.\r\n \r\nKullanımı : \r\n  \r\ndo\r\n{\r\nyapılacak işler;\r\n}\r\nwhile(koşul);");

            aciklama.SetToolTip(label9, "Geriye Değer Döndüren Metot\r\n \r\nMetotlar belirli işlemleri yerine getiren kod bloklarıdır.\r\nAynı kodların tekrar tekrar kullanılması gereken durumlarda büyük kolaylık sağlamaktadır.\r\nOluşturulan metot, ismiyle çağırılarak içerisinde bulunan kod bloklarının çalıştırılması sağlanır.\r\n \r\nKullanımı :\r\n \r\n[Erişim Belirleyici(public,private vs)][Türü(string,int vs)][Metot Adı][Parametre Listesi]\r\n{\r\n      Program satırları;\r\n      return;\r\n}");

            aciklama.SetToolTip(label10, "Geriye Değer Döndürmeyen Metot\r\n \r\nMetotlar belirli işlemleri yerine getiren kod bloklarıdır.\r\nAynı kodların tekrar tekrar kullanılması gereken durumlarda büyük kolaylık sağlamaktadır.\r\nOluşturulan metot, ismiyle çağırılarak içerisinde bulunan kod bloklarının çalıştırılması sağlanır.\r\n \r\nKullanımı :\r\n \r\n[Erişim Belirleyici(public,private vs)][void][Metot Adı][Parametre Listesi]\r\n{\r\n      Program satırları;\r\n}");

            aciklama.SetToolTip(label16, "int sayı1, sayı2, sayı3, ortalama; //Değişkenler Tanımlandı\r\nstring durum; //Değişken Tanımlandı\r\n\r\nsayı1 = int.Parse(Textbox1.Text); //Birinci Notun Girişi\r\n sayı2 = int.Parse(Textbox2.Text); //İkinci Notun Girişi\r\nsayı3 = int.Parse(Textbox3.Text); //Üçüncü Notun Girişi\r\n\r\nortalama = (sayı1+sayı2+sayı3) / 3; //Ortalama Hesaplanıyor\r\n\r\nif (ortalama >=50) //Kontrol Ediliyor\r\n{\r\ndurum = 'Geçtiniz'; //Ortalama 50 Den Büyükse = 'Geçti'\r\n}\r\nelse\r\n{\r\ndurum = 'Kaldınız'; Ortalama 50 Den Küçükse = 'Kaldı'\r\n}\r\n\r\nlabel1.Text = 'Ortalamanız': +ortalama.ToString()+' - '+durum; //Yazdırıyoruz");

            aciklama.SetToolTip(label17, "int sayı1, sayı2; //Değişkenler Tanımlandı\r\nint hesap; //Değişken Tanımlandı\r\nstring islem = Textbox1.Text; //Değişkene Değer Aktarıldı\r\n\r\nsayı1 = int.Parse(Textbox2.Text); //Birinci Sayının Girişi\r\n sayı2 = int.Parse(Textbox3.Text); //ikinci Sayının Girişi\r\n\r\nif (islem == ' / ') //Kontrol Ediliyor\r\n{\r\nhesap = sayı1 / sayı2; //Hesap Yapıldı\r\nlabel11.Text = ('Bölme İşleminin Sonucu = ' + hesap.ToString()); //Yazdırıyoruz\r\n}\r\nelse if (islem == '*') //Kontrol Ediliyor\r\n{\r\nhesap = sayı1 * sayı2; //Hesap Yapıldı\r\n label11.Text =('Çarpma İşleminin Sonucu = '+hesap.ToString()); //Yazdırıyoruz\r\n}\r\nelse if (islem == '-') //Kontrol Ediliyor\r\n{\r\nhesap =sayı1 - sayı2; //Hesap Yapıldı\r\nlabel11.Text = ('Çıkarma İşleminin Sonucu = '+hesap.ToString()); //Yazdırıyoruz\r\n}\r\nelse if (islem == '+') //Kontrol Ediliyor\r\n{\r\n hesap = sayı1 + sayı2; //Hesap Yapıldı\r\n label11.Text = ('Toplama İşleminin Sonucu = '+hesap.ToString()); //Yazdırıyoruz\r\n}");

            aciklama.SetToolTip(label27, "int sayı = int.Parse(Textbox1.Text);  //Değişkene Değer Aktarıldı\r\nstring sonuc = ''; //Değişken Tanımlandı\r\n\r\nswitch (sayı) //Sırası İle Şartlar Kontrol Ettiriliyor\r\n{\r\n case 1:\r\nsonuc = 'Pazartesi'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 2:\r\nsonuc = 'Salı'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 3:\r\nsonuc = 'Çarşamba'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 4:\r\nsonuc = 'Perşembe'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 5:\r\nsonuc = 'Cuma'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 6:\r\nsonuc = 'Cumartesi'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ncase 7:\r\nsonuc = 'Pazar'; //Değişkene Değer Aktarıldı\r\nlabel1.Text = sonuc; //Yazdırıyoruz\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\ndefault: //Eğer Şartlardan Her Hangi Birisi Uygun Değilse Bu satır Çalışıyor\r\nMessageBox.Show('HATA'+MessageBoxButtons.OK+MessageBoxIcon.Warning);\r\nbreak; //Break İfadesi Switch Case Yapısını Sonlandırıyor\r\n}");

            aciklama.SetToolTip(label36, "Geriye Değer Döndüren \r\n \r\npublic int alan(int kısakenar, int uzunkenar) //Gerekli Parametreler Veriliyor\r\n{\r\nreturn kısakenar * uzunkenar; //Hesaplama Yapılıp , Değer Döndürülüyor\r\n}");

            aciklama.SetToolTip(label37, "Geriye Değer Döndürmeyen \r\n \r\npublic void alan(int kısakenar, int uzunkenar) //Gerekli Parametreler Veriliyor\r\n{\r\nlabel1.Text = 'Dikdörtgenin Alanı: ' + kısakenar * uzunkenar; //Hesap Yapılıp Yazdırılıyor\r\n}");
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            bunifuSeparator2.Visible = true;
            bunifuSeparator3.Visible = true;
            bunifuCards2.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = true;
            bunifuSeparator2.Visible = true;
            bunifuSeparator3.Visible = true;
            label10.Visible = true;
            bunifuCards2.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards6.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bunifuCards2.Visible = true;
            bunifuCards3.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label6_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label7_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label8_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label4_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label9_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label10_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label0_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label11_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label12_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }
        private void label13_MouseHover(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label3_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label4_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label4_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label6_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label6_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label7_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label7_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label8_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label8_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label9_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label9_MouseLeave_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void label10_MouseHover_1(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Orange;
            bunifuSeparator3.LineColor = Color.Orange;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            bunifuSeparator2.LineColor = Color.Yellow;
            bunifuSeparator3.LineColor = Color.Yellow;
        }

        private void bunifuMetroTextbox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text!="")
            {
                if (bunifuMetroTextbox4.Text != "")
                {
                    if (bunifuMetroTextbox3.Text != "")
                    {
                        label15.Visible = true;
                        int sayı1, sayı2, sayı3, ortalama;
                        string durum;
                        sayı1 = int.Parse(bunifuMetroTextbox1.Text);
                        sayı2 = int.Parse(bunifuMetroTextbox4.Text);
                        sayı3 = int.Parse(bunifuMetroTextbox3.Text);
                        ortalama = (sayı1 + sayı2 + sayı3) / 3;
                        if (ortalama >= 50)
                        {
                            durum = "Geçtiniz";
                        }
                        else
                        {
                            durum = "Kaldınız";
                        }
                        label15.Text = "Ortalamanız : " + ortalama.ToString() + " - " + durum;
                    }
                    else
                    {
                        MessageBox.Show("✘ Not 3 : Boş Bırakma");
                    }
                }
                else
                {
                    MessageBox.Show("✘ Not 2 : Boş Bırakma");
                }
            }
            else
            {
                MessageBox.Show("✘ Not 1 : Boş Bırakma");
            }
            
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox6.Text=="/"|| bunifuMetroTextbox6.Text == "-" || bunifuMetroTextbox6.Text == "*" || bunifuMetroTextbox6.Text == "+")
            {
                if (bunifuMetroTextbox2.Text!="")
                {
                    if (bunifuMetroTextbox5.Text!="")
                    {
                        label18.Visible = true;
                        int sayı1, sayı2;
                        string islem = bunifuMetroTextbox6.Text;
                        int hesap;
                        sayı1 = int.Parse(bunifuMetroTextbox2.Text);
                        sayı2 = int.Parse(bunifuMetroTextbox5.Text);
                        if (islem == "/")
                        {
                            hesap = sayı1 / sayı2;
                            label18.Text = ("Bölme İşleminin Sonucu = " + hesap.ToString());
                        }
                        else if (islem == "*")
                        {
                            hesap = sayı1 * sayı2;
                            label18.Text =("Çarpma İşleminin Sonucu = "+hesap.ToString());
                        }
                        else if (islem == "-")
                        {
                            hesap =sayı1 - sayı2;
                            label18.Text = ("Çıkarma İşleminin Sonucu = "+hesap.ToString());
                        }
                        else if (islem == "+")
                        {
                            hesap = sayı1 + sayı2;
                            label18.Text = ("Toplama İşleminin Sonucu = "+hesap.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("✘ Sayı 2 : Boş Bırakma");
                    }
                }
                else
                {
                    MessageBox.Show("✘ Sayı 1 : Boş Bırakma");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Dört İşlem Giriniz");
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {
            bunifuCards4.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards3.Visible = true;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox7.Text!="")
            {
                if (bunifuMetroTextbox7.Text=="1"|| bunifuMetroTextbox7.Text == "2" || bunifuMetroTextbox7.Text == "3" || bunifuMetroTextbox7.Text == "4" || bunifuMetroTextbox7.Text == "5" || bunifuMetroTextbox7.Text == "6" || bunifuMetroTextbox7.Text == "7" )
                {
                    label28.Visible = true;
                    int sayı = int.Parse(bunifuMetroTextbox7.Text);
                    string sonuc = "";
                    switch (sayı)
                    {
                        case 1:
                            sonuc = "Pazartesi";
                            label28.Text = sonuc;
                            break;
                        case 2:
                            sonuc = "Salı";
                            label28.Text = sonuc;
                            break;
                        case 3:
                            sonuc = "Çarşamba";
                            label28.Text = sonuc;
                            break;
                        case 4:
                            sonuc = "Perşembe";
                            label28.Text = sonuc;
                            break;
                        case 5:
                            sonuc = "Cuma";
                            label28.Text = sonuc;
                            break;
                        case 6:
                            sonuc = "Cumartesi";
                            label28.Text = sonuc;
                            break;
                        case 7:
                            sonuc = "Pazar";
                            label28.Text = sonuc;
                            break;
                        default:
                            MessageBox.Show("HATA"+MessageBoxButtons.OK+MessageBoxIcon.Warning);
                            break;
                    } 
                }
                else
                {
                    MessageBox.Show("Lütfen 1-7 Arasında Bir Sayı Giriniz");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilmez");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            bunifuCards4.Visible = true;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards5.Visible = false;
            bunifuCards6.Visible = false;

        }
        int ilksayı, sonsayı, artısdegeri;

        private void label10_Click(object sender, EventArgs e)
        {
            bunifuCards5.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards6.Visible = true;
            radioButton6.Checked = false;
            radioButton5.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            bunifuCards4.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards6.Visible = false;
            bunifuCards5.Visible = true;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            bunifuCards4.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards6.Visible = false;
            radioButton1.Checked = false;
            bunifuCards5.Visible = true;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            bunifuCards4.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards6.Visible = false;
            bunifuCards5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
        }
        //ALİHAN BALKAN
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label36.Visible = false;
            label37.Visible = true;
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label36.Visible = true;
            label37.Visible = false;
        }
        public void alan(int kısakenar, int uzunkenar)
        {
            label38.Text = "Dikdörtgenin Alanı : " + (kısakenar * uzunkenar)+ "\r\nGeriye Değer Döndürmeyen Metot";
        }
        public int alan2(int kısakenar, int uzunkenar)
        {
            return kısakenar * uzunkenar;
        }
        int a, b;
        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            
            if (bunifuMetroTextbox13.Text!="")
            {
                if (bunifuMetroTextbox12.Text != "")
                {
                    a = int.Parse(bunifuMetroTextbox13.Text);
                    b = int.Parse(bunifuMetroTextbox12.Text);
                    if (a<b)
                    {
                        if (radioButton6.Checked)
                        {
                            int kısakenar, uzunkenar;
                            kısakenar = int.Parse(bunifuMetroTextbox13.Text);
                            uzunkenar = int.Parse(bunifuMetroTextbox12.Text);
                            label38.Text = "Dikdörtgenin Alanı : " + alan2(kısakenar, uzunkenar) +"\r\nGeriye Değer Döndüren Metot";
                            label38.Visible = true;

                        }
                        else if(radioButton5.Checked)
                        {
                            int kısakenar, uzunkenar;
                            kısakenar = int.Parse(bunifuMetroTextbox13.Text);
                            uzunkenar = int.Parse(bunifuMetroTextbox12.Text);
                            alan(kısakenar, uzunkenar);
                            label38.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Seçiniz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kısa Kenar , Uzun Kenardan Büyük Olamaz");
                    }
                }
                else
                {
                    MessageBox.Show("✘ Uzun Kenar : Boş Bırakma");
                }
            }
            else
            {
                MessageBox.Show("✘ Kısa Kenar : Boş Bırakma");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            bunifuCards5.Visible = false;
            bunifuCards4.Visible = false;
            bunifuCards3.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards6.Visible = true;
            radioButton6.Checked = true;
            radioButton5.Checked = false;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            try
            {
                ilksayı = int.Parse(bunifuMetroTextbox8.Text);
                sonsayı = int.Parse(bunifuMetroTextbox9.Text);
                artısdegeri = int.Parse(bunifuMetroTextbox10.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Değerleri Boş Bırakma");
            }
            if (ilksayı > sonsayı)
            {
                int gecici = ilksayı;
                ilksayı = sonsayı;
                sonsayı = gecici;
                string gec = bunifuMetroTextbox8.Text;
                bunifuMetroTextbox8.Text = bunifuMetroTextbox9.Text;
                bunifuMetroTextbox9.Text = gec;
            }
            if (radioButton1.Checked)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                for (int i = ilksayı; i <= sonsayı; i = i + artısdegeri)
                {
                    textBox1.Text += i + " ";
                }
                textBox2.Text = @"for (int i = ilksayı; i <=sonsayı; i=i+artısdegeri)
                {
                    textBox1.Text += i + ' ';
                }";
            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                int i = ilksayı;
                while (i < sonsayı)
                {
                    textBox1.Text += i + " ";
                    i += artısdegeri;
                }
                textBox2.Text = @"int i = ilksayı;
                while (i <= sonsayı)
                {
                    i += artısdegeri;
                    textBox1.Text += i + '';
                }";
            }
            else if (radioButton3.Checked)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                int i = ilksayı;
                do
                {
                    textBox1.Text += i + " ";
                    i += artısdegeri;
                } while (i < sonsayı);
                textBox2.Text = @"int i=ilksayı;
                do
                {
                    i += artısdegeri;
                    textBox1.Text += i + ' ';
                } while (i <= sonsayı);";
            }

        }
    }
}

