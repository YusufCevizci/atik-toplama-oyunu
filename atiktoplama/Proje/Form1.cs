//                                                  ADI SOYADI: YUSUF EMRE CEVİZCİ
//                                                  NUMARASI: B191210076
//                                                  DERS GRUBU: 1/B


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Proje
{
   
    public partial class ATIKTOPLAMA : Form
    {
        public void fotoSec()  //Fotoğraflar arasından rastgele 1 adet seçip bunu picturebox a koyan fonksiyon.
        {
            Random rnd = new Random();
            string[] atikResim = Directory.GetFiles("atıklar");
            int sayi = rnd.Next(atikResim.Length);
            pictureBox1.ImageLocation = atikResim[sayi];
            textBox5.Text = Convert.ToString(sayi);
        }
        public ATIKTOPLAMA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            Text = "ATIK TOPLAMA";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sure = Convert.ToInt32(textBox4.Text);//Süreyi kontrol eden kodlar.
            sure = sure - 1;                            
            textBox4.Text = Convert.ToString(sure);

            if (sure == 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;//Süre 0'a eşit olduğunda oyunun durması için
                button7.Enabled = false;//butonları devre dışı bırakan kodlar.
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button1.Enabled = true;
                timer1.Stop();//süre 0'a eşitlendiğinde timerı durduran kod.
                progressBar1.Value = 0; 
                progressBar2.Value = 0;//Süre 0' eşit olduğunda progressbarları
                progressBar3.Value = 0;//sıfırlayan kodlar.
                progressBar4.Value = 0;

                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;//"YENİ OYUN" tuşuna basıldığında
            button6.Enabled = true;//bütün butonları aktik eden kodlar.
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            listBox1.Items.Clear();
            listBox2.Items.Clear();//"YENİ OYUN" tuşuna basıldığında listboxları 
            listBox3.Items.Clear();//temizleyen kodlar.
            listBox3.Items.Clear();

            textBox4.Text = Convert.ToString(60);
            timer1.Interval = 1000;//Timer kodları.
            timer1.Start();

            int d = Convert.ToInt32(textBox6.Text);
            d = 0;  //"YENİ OYUN" tuşuna basıldığında puanı sıfırlayan kodlar.
            textBox6.Text = Convert.ToString(d);

            fotoSec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //"ÇIKIŞ" tuşuna basıldığında oyunu kapatan kod.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text); //Fotoğrafın neye ait fotoğraf olduğunu kontrol etmeme yarayan kod.

            if (sayi == 3) //Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
               
                if(progressBar1.Value + 150 < 700)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {                                 
                    progressBar1.Value += 150;
                    listBox1.Items.Add("DOMATES (150P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 150;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
                
            }
            else if (sayi == 6)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
              
                if (progressBar1.Value + 120 < 700) //Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar1.Value += 120;
                    listBox1.Items.Add("SALATALIK (120P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 120;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }

            else
            {

            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);//Fotoğrafın neye ait fotoğraf olduğunu kontrol etmeme yarayan kod.

            if (sayi == 2)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
                
                if (progressBar2.Value + 200 < 1200)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar2.Value += 200;
                    listBox2.Items.Add("DERGİ (200P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 200;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else if (sayi == 4)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
            
                if(progressBar2.Value +250 <1200)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar2.Value += 250;
                    listBox2.Items.Add("GAZETE (250P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 250;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else
            {

            }

           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);//Fotoğrafın neye ait fotoğraf olduğunu kontrol etmeme yarayan kod.

            if (sayi == 0)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
              
                if (progressBar3.Value + 250 < 2200)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar3.Value += 250;
                    listBox3.Items.Add("CAM BARDAK (250P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 250;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else if (sayi == 1)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
               
                if (progressBar3.Value + 600 < 2200)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar3.Value += 600;
                    listBox3.Items.Add("CAM ŞİŞE (600P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 600;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else
            {

            }

            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);//Fotoğrafın neye ait fotoğraf olduğunu kontrol etmeme yarayan kod.
            if (sayi == 5)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
                
                if(progressBar4.Value + 350 <2300)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar4.Value += 350;
                    listBox4.Items.Add("KUTU KOLA (350P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 350;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else if (sayi == 7)//Fotoğrafın atık kutusuyla uyuşup uyuşmadığını anlamak için kullandığım kontrol kodu.
            {
                
                if(progressBar4.Value + 550 < 2300)//Progressbar %75'ten daha az dolu ise yapılması gereken işlemleri yapan kontrol kısmı.
                {
                    progressBar4.Value += 550;
                    listBox4.Items.Add("SALÇA KUTUSU (550P)");

                    int b = Convert.ToInt32(textBox6.Text);
                    b = b + 550;
                    textBox6.Text = Convert.ToString(b);

                    fotoSec();
                }
                else
                {

                }
            }
            else
            {

            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             if (progressBar1.Value >= 525)//Progressbarın doluluk oranı %75 veya daha fazla ise gerekli işlemleri yapan kontrol kısmı.
            {
                listBox1.Items.Clear();
                progressBar1.Value = progressBar1.Value - progressBar1.Value;

                int a = Convert.ToInt32(textBox4.Text);//Atık kutusu boşaltıldığında süreye 3 saniye ekleyen üç satırlık kod.
                a = a + 3;
                textBox4.Text = Convert.ToString(a);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value >= 900)//Progressbarın doluluk oranı %75 veya daha fazla ise gerekli işlemleri yapan kontrol kısmı.
            {
                int c = Convert.ToInt32(textBox6.Text);//Atık kutusu boşaltığında puan ekleyen üç satırlık kod.
                c = c + 1000;
                textBox6.Text = Convert.ToString(c);

                listBox2.Items.Clear();
                progressBar2.Value = progressBar2.Value - progressBar2.Value;

                int a = Convert.ToInt32(textBox4.Text);//Atık kutusu boşaltıldığında süreye 3 saniye ekleyen üç satırlık kod.
                a = a + 3;
                textBox4.Text = Convert.ToString(a);
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value >= 1650)//Progressbarın doluluk oranı %75 veya daha fazla ise gerekli işlemleri yapan kontrol kısmı.
            {
                int c = Convert.ToInt32(textBox6.Text);//Atık kutusu boşaltığında puan ekleyen üç satırlık kod.
                c = c + 600;
                textBox6.Text = Convert.ToString(c);

                listBox3.Items.Clear();
                progressBar3.Value = progressBar3.Value - progressBar3.Value;

                int a = Convert.ToInt32(textBox4.Text);//Atık kutusu boşaltıldığında süreye 3 saniye ekleyen üç satırlık kod.
                a = a + 3;
                textBox4.Text = Convert.ToString(a);
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value >= 1725)//Progressbarın doluluk oranı %75 veya daha fazla ise gerekli işlemleri yapan kontrol kısmı.
            {
                int c = Convert.ToInt32(textBox6.Text);//Atık kutusu boşaltığında puan ekleyen üç satırlık kod.
                c = c + 800;
                textBox6.Text = Convert.ToString(c);

                listBox4.Items.Clear();

                progressBar4.Value = progressBar4.Value - progressBar4.Value;

                int a = Convert.ToInt32(textBox4.Text);//Atık kutusu boşaltıldığında süreye 3 saniye ekleyen üç satırlık kod.
                a = a + 3;
                textBox4.Text =Convert.ToString(a);
                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
