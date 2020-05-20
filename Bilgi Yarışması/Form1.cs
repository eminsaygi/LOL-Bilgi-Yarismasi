using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\1.png");
            button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            // soruno++;
            if (button1.BackColor == Color.Green || button1.BackColor == Color.Red || button1.Text=="")
            {
                soruno++;
            }
            if (soruno == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "'800K ..... Var.Kaldıran Bişeyler Al' Sözünde '.....' kısmına ne gelmelidir ?";
                button1.Text = "Draven";
                button2.Text = "Yasuo";
                button3.Text = "Elise";
                button4.Text = "Fiora";
                lbl2.Text = "Yasuo";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");
                



            }
            if (soruno == 2)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "Aşşağıdakilerden hangisi LOL'de ki kümelerden değildir ?";
                button1.Text = "Bronz Ligi";
                button2.Text = "Altın Ligi";
                button3.Text = "Tahta Ligi";
                button4.Text = "Gümüş Ligi";
                lbl2.Text = "Tahta Ligi";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");

            }
            if (soruno == 3)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "Genel Olarak Rakip takıma gelen,En sevilmeyen Şampiyon Hangisidir ?";
                button1.Text = "Teemo";
                button2.Text = "Fiora";
                button3.Text = "Vayne";
                button4.Text = "Lux";
                lbl2.Text = "Teemo";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");
            }
            if (soruno == 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "Bugüne Kadar En Çok Nerf(Düşürme) Yiyen Şampiyon Hangisidir ?";
                button1.Text = "Ezreal";
                button2.Text = "Gnar";
                button3.Text = "Illaoi";
                button4.Text = "Vladimir";
                lbl2.Text = "Vladimir";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");
            }
            if (soruno == 5)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "LOL Hangi Oyunun Çakmasıdır ?";
                button1.Text = "Warcraft";
                button2.Text = "CS:GO";
                button3.Text = "Minecraft";
                button4.Text = "Dota";
                lbl2.Text = "Dota";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");
            }
            if (soruno == 6)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button3.BackColor = Color.Orange;
                button4.BackColor = Color.Orange;
                label1.Text = soruno.ToString();
                label4.Text = "Aşşağıdakilerden Hangisi LOL'De En Son Çıkan Şampiyondur ?";
                button1.Text = "Taliyah";
                button2.Text = "Kled";
                button3.Text = "Aurelion Sol";
                button4.Text = "Jhin";
                lbl2.Text = "Kled";
                label5.Visible = true;
                label8.Visible = false;
                button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
                button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\b.png");
            }
            if (Bilgi.dogru==1)
            {
               
                label11.Text = "Çok Kötüsün";
            }
            if (Bilgi.dogru==2)
            {
                label11.Text = "Berbatsın";
            }
            if (Bilgi.dogru==3)
            {
                label11.Text = "Tekiniğin güzel ama geliştirmen lazım";
            }
            if (Bilgi.dogru==4)
            {
                label11.Text = "Bilgin yok diyemem ama varda demem";
            }
            if (Bilgi.dogru==5)
            {
                label11.Text = "Pişmissin sen";
            }
            if (Bilgi.dogru==6)
            {
                label11.Text = "Bunların hepsini bildiğine göre Bronzsun G.O";
            }
            if (soruno == 7)
            {
                Form2 f2 = new Form2();
                Bilgi.sonuc = label11.Text;
                f2.Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            button6.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\2.png");
            button5.Image = Image.FromFile(Application.StartupPath + "\\Resimler\\a.png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Yellow;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Yellow;
        }
        SoundPlayer clickSound = new SoundPlayer("Resimler\\Click.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Bilgi.sesSeçeneği == true)
            {
                clickSound.Play();
            }

            lbl1.Text = button1.Text;
            if (lbl1.Text == lbl2.Text)
            {

                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Doğru Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.dogru++;
                label8.Visible = true;
                label9.Text = Bilgi.dogru.ToString();
                if (button1.Text==lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }




            }
            else
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Yanlış Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.yanlis++;
                label10.Text = Bilgi.yanlis.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bilgi.sesSeçeneği == true)
            {
                clickSound.Play();
            }

            lbl1.Text = button2.Text;
            if (lbl1.Text == lbl2.Text)
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Doğru Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.dogru++;
                label9.Text = Bilgi.dogru.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }

            }
            else
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Yanlış Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.yanlis++;
                label10.Text = Bilgi.yanlis.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bilgi.sesSeçeneği == true)
            {
                clickSound.Play();
            }

            lbl1.Text = button3.Text;
            if (lbl1.Text == lbl2.Text)
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Doğru Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.dogru++;
                label9.Text = Bilgi.dogru.ToString();

                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }

            }
            else
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Yanlış Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.yanlis++;
                label10.Text = Bilgi.yanlis.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Bilgi.sesSeçeneği == true)
            {
                clickSound.Play();
            }

            lbl1.Text = button4.Text;
            if (lbl1.Text == lbl2.Text)
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Doğru Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.dogru++;
                label9.Text = Bilgi.dogru.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }


            }
            else
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Yanlış Cevap");
                label8.Text = lbl2.Text;
                label8.Visible = true;
                Bilgi.yanlis++;
                label10.Text = Bilgi.yanlis.ToString();
                label8.Visible = true;
                if (button1.Text == lbl2.Text)
                {
                    button1.BackColor = Color.Green;
                }
                if (button2.Text == lbl2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                if (button3.Text == lbl2.Text)
                {
                    button3.BackColor = Color.Green;
                }
                if (button4.Text == lbl2.Text)
                {
                    button4.BackColor = Color.Green;
                }

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            label9.Text = Bilgi.dogru.ToString();
            label10.Text = Bilgi.yanlis.ToString();
            label11.Text = Bilgi.sonuc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
            }
        }
    }
}
