using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int soruno = 0, dogru = 0, yanlıs = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = false;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = false;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        { 
            label5.Text = BtnA.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
           
            if(label4.Text==label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click_1(object sender, EventArgs e)
        {
            BtnSonraki.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin en büyük yüz ölçümlü ili nedir";
                BtnA.Text = "Ankara";
                BtnB.Text = "Bursa";
                BtnC.Text = "Konya";
                BtnD.Text = "Bilecik";
                label4.Text = "Konya";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir";
                BtnA.Text = "1921";
                BtnB.Text = "1920";
                BtnC.Text = "1923";
                BtnD.Text = "1922";
                label4.Text = "1923";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Bursanın plaka kodu kaçtır";
                BtnA.Text = "16";
                BtnB.Text = "24";
                BtnC.Text = "10";
                BtnD.Text = "56";
                label4.Text = "16";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                
                MessageBox.Show("Dogru :" + dogru + "\n" + "Yanlış :" + yanlıs + "\n" );
            }
        }

    }
}
