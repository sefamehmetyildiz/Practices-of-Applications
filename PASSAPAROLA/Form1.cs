using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSAPAROLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int questionNo = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "NEXT";
            questionNo++;
            this.Text = "QUESTION " + questionNo;

            if (questionNo==1)
            {
                richTextBox1.Text = "Ülkemizin başkenti neresidir?";
                button1.BackColor = Color.Yellow;

            }
            if (questionNo == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara şehrimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (questionNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (questionNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (questionNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir?";
                button5.BackColor = Color.Yellow;
            }
            if (questionNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (questionNo == 7)
            {
                richTextBox1.Text = "DÜNYANIN ISI KAYNAPĞI?";
                button7.BackColor = Color.Yellow;
            }
            if (questionNo == 8)
            {
                richTextBox1.Text = "ÖĞRENCİLERİN KÖTÜ KARNE GETİRİNCE BAKIŞTIĞI NESNE?";
                button8.BackColor = Color.Yellow;
            }
            if (questionNo == 9)
            {
                richTextBox1.Text = "GÜLÜ İLE ÜNLÜ ŞEHRİMİZ?";
                button9.BackColor = Color.Yellow;
            }
            if (questionNo == 10)
            {
                richTextBox1.Text = "MERSİNİN DİĞER HALİ?";
                button10.BackColor = Color.Yellow;
            }
            if (questionNo == 11)
            {
                richTextBox1.Text = "ASKERİ BİR TOPLULUK?";
                button11.BackColor = Color.Yellow;
            }
            if (questionNo == 12)
            {
                richTextBox1.Text = "MALATYANIN MEŞHUR MEYVESİ?";
                button12.BackColor = Color.Yellow;
            }
            if (questionNo == 13)
            {
                richTextBox1.Text = "HER YIL BAHAR AYLARINDA DÜZENLENEN MEŞHUR ÇİÇEK FESTİVALİ?";
                button13.BackColor = Color.Yellow;
            }
            if (questionNo == 14)
            {
                richTextBox1.Text = "ÜFLEMELİ MÜZİK ALETİ?";
                button14.BackColor = Color.Yellow;
            }
            if (questionNo == 15)
            {
                richTextBox1.Text = "HALK ŞAİRİ?";
                button15.BackColor = Color.Yellow;
            }
            if (questionNo == 16)
            {
                richTextBox1.Text = "ÇOCUKLARIN SALLANDIĞI YER?";
                button16.BackColor = Color.Yellow;
            }
            if (questionNo == 17)
            {
                richTextBox1.Text = "11 AYIN SULTANI?";
                button17.BackColor = Color.Yellow;
            }
            if (questionNo == 18)
            {
                richTextBox1.Text = "İNGİLİZCEDE YILAN?";
                button18.BackColor = Color.Yellow;
            }
            if (questionNo == 20)
            {
                richTextBox1.Text = "ÜMİT KELİMESİNİN EŞ ANLAMLISI?";
                button20.BackColor = Color.Yellow;
            }
            if (questionNo == 19)
            {
                richTextBox1.Text = "TÜRKİYENİN MEGA STARI?";
                button19.BackColor = Color.Yellow;
            }
            if (questionNo == 21)
            {
                richTextBox1.Text = "KAHVALTISI İLE ÜNLÜ İLİMİZ?";
                button21.BackColor = Color.Yellow;
            }
            if (questionNo == 22)
            {
                richTextBox1.Text = "EGE BÖLGESİNİN EN ÇOK AĞACI BULUNAN VE YAĞI OLAN SEBZE?";
                button22.BackColor = Color.Yellow;
            }
            
            



        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (questionNo)
                {
                    case 1:
                        if (textBox1.Text=="ankara")
                        {
                            button1.BackColor = Color.Green;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                        }
                        break;

                     case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "ısparta")
                        {
                            button10.BackColor = Color.Green;
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "ısparta")
                        {
                            button11.BackColor = Color.Green;
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "ısparta")
                        {
                            button12.BackColor = Color.Green;
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "ısparta")
                        {
                            button13.BackColor = Color.Green;
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "ısparta")
                        {
                            button14.BackColor = Color.Green;
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ısparta")
                        {
                            button15.BackColor = Color.Green;
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                        }
                        break;



                }
                
            }
        }
    }
}
