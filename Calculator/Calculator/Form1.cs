using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double sayi;
        int operatorSecimi;
        double islemSonucu;
        bool basildiMi = false;


        public Form1()
        {
            InitializeComponent();
        }

        void aritmetikİslem()
        {
            switch (operatorSecimi) {
                case 1:
                    islemSonucu = sayi / Convert.ToInt32(sonuc.Text);
                    islem.Text += " " + sonuc.Text + " =";
                    sonuc.Text = Convert.ToString(islemSonucu);
                    break;

                case 2:
                    islemSonucu = sayi * Convert.ToInt32(sonuc.Text);
                    islem.Text += " " + sonuc.Text + " =";
                    sonuc.Text = Convert.ToString(islemSonucu);
                    break;

                case 3:
                    islemSonucu = sayi + Convert.ToInt32(sonuc.Text);
                    islem.Text += " " + sonuc.Text + " =";
                    sonuc.Text = Convert.ToString(islemSonucu);
                    break;

                case 4:
                    islemSonucu = sayi - Convert.ToInt32(sonuc.Text);
                    islem.Text += " "+sonuc.Text+" =";
                    sonuc.Text = Convert.ToString(islemSonucu);
                    break;

            }
        }

        public string Geri(string s)
        {
            string m = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                m += s[i];
            }
            return m;
        }

        private void sayiYazdir(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            sonuc.Text += b.Text;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if(sonuc.Text != "")
            {
                sonuc.Text = Geri(sonuc.Text);
            }
            
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            sonuc.Text = "";
            islem.Text = "";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "0") {
                sonuc.Text = "";
            }  
            Button b = (Button)sender;
            islem.Text = sonuc.Text+" "+b.Text;
            sonuc.Text = "";
        }

        private void bolme_Click(object sender, EventArgs e)
        {

            islem.Text = sonuc.Text + " ÷";
            sayi = Convert.ToDouble(sonuc.Text);
            operatorSecimi = 1;
            sonuc.Text = "";
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            islem.Text = sonuc.Text + " x";
            sayi = Convert.ToDouble(sonuc.Text);
            operatorSecimi = 2;
            sonuc.Text = "";
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                sonuc.Text = "-";
            }
            else
            {
                islem.Text = sonuc.Text + " -";
                sayi = Convert.ToDouble(sonuc.Text);
                operatorSecimi = 4;
                sonuc.Text = "";
            }
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            islem.Text = sonuc.Text + " +";
            sayi = Convert.ToDouble(sonuc.Text);
            operatorSecimi = 3;
            sonuc.Text = "";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            aritmetikİslem();
        }

        private void virgul_Click(object sender, EventArgs e)
        {
            bool varmi = false;
            for(int i = 0;i< sonuc.Text.Length; i++)
            {
                if (sonuc.Text[i] == ',')
                {
                    varmi = true;
                }
            }
            if(!varmi)
            {
                sonuc.Text += ",";
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            islem.Text = sonuc.Text + "² =";
            sonuc.Text = Convert.ToString(Math.Pow(Convert.ToDouble(sonuc.Text), 2));    
        }

    }
}
