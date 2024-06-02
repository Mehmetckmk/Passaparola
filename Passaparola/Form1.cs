using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox2.Text=="Akdeniz" || textBox2.Text=="akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox2.Text == "Bursa" || textBox2.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox2.Text == "Cuma" || textBox2.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox2.Text == "Diyarbakır" || textBox2.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox2.Text == "Eski" || textBox2.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox2.Text == "Ferman" || textBox2.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox2.Text == "Gaziantep" || textBox2.Text == "gaziantep")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox2.Text == "Hasta" || textBox2.Text == "hasta")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox2.Text == "Irak" || textBox2.Text == "ırak")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox2.Text == "İnek" || textBox2.Text == "inek")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox2.Text == "Japonya" || textBox2.Text == "japonya")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox2.Text == "Kütüphane" || textBox2.Text == "kütüphane")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox2.Text == "Limon" || textBox2.Text == "limon")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox2.Text == "Maymun" || textBox2.Text == "maymun")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox2.Text == "Ne" || textBox2.Text == "ne")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox2.Text == "Okul" || textBox2.Text == "okul")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox2.Text == "Patates" || textBox2.Text == "patates")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox2.Text == "Robot" || textBox2.Text == "robot")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox2.Text == "Salı" || textBox2.Text == "salı")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox2.Text == "Tavuk" || textBox2.Text == "tavuk")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox2.Text == "Unutmak" || textBox2.Text == "unutmak")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox2.Text == "Van" || textBox2.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox2.Text == "Yaz" || textBox2.Text == "yaz")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox2.Text == "Zebra" || textBox2.Text == "zebra")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;              
                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text="Soru No "+soruno.ToString();
            textBox2.Text = "";

            if (soruno==1)
            {
                textBox1.Text = "Ülkemizin Güney Bölgesindeki Kıyı Bölgesi? ";
                button25.Text = button1.Text;
                button1.BackColor= Color.Yellow;
            }
            if (soruno == 2)
            {
                textBox1.Text = "Yeşilliğiyle Ünlü İlimiz? ";
                button25.Text = button2.Text;
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                textBox1.Text = "Müslümanların Kutsal Günü? ";
                button25.Text = button3.Text;
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                textBox1.Text = "Karpuzuyla Ünlü İlimiz? ";
                button25.Text = button4.Text;
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                textBox1.Text = "Yeni Kelimesiniz Zıt Anlamlısı? ";
                button25.Text = button5.Text;
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                textBox1.Text = "Padişahın Emirlerinin Yazılı Olduğu Kağıdın Hali? ";
                button25.Text = button6.Text;
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                textBox1.Text = "Atatürk'ün Nüfusa Kayıtlı Olduğu İl? ";
                button25.Text = button7.Text;
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                textBox1.Text = "Doktora Gidden İnsanlar? ";
                button25.Text = button8.Text;
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                textBox1.Text = "Türkiyenin Komşusu Bir Ülke? ";
                button25.Text = button9.Text;
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                textBox1.Text = "Süt Veren, Eti Yenilen Bir Hayvan? ";
                button25.Text = button10.Text;
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                textBox1.Text = "Uzak Doğu Asyada Bir Ülke? ";
                button25.Text = button11.Text;
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                textBox1.Text = "İnsanların Kitap Okuyup, Kitapları Ödünç Aldığı Yer? ";
                button25.Text = button12.Text;
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                textBox1.Text = "Sarı Renkli, Ekşi Bir Meyve? ";
                button25.Text = button13.Text;
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                textBox1.Text = "Muzu Çok Seven Bir Hayvan? ";
                button25.Text = button14.Text;
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                textBox1.Text = "En Çok Kullanılan Soru Kelimesi? ";
                button25.Text = button15.Text;
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                textBox1.Text = "Öğrencilerin ve öğretmenlerin haftada beş gün gittiği yer? ";
                button25.Text = button16.Text;
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                textBox1.Text = "İnsanları genelde sevdiği , kahverengi bir sebze. Kızarması yapılıyor? ";
                button25.Text = button17.Text;
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                textBox1.Text = "İnsana benziyor , makine? ";
                button25.Text = button18.Text;
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                textBox1.Text = "Haftanın bir günü? ";
                button25.Text = button19.Text;
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                textBox1.Text = "Yumurta yapan, eti güzel olan bir hayvan? ";
                button25.Text = button20.Text;
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                textBox1.Text = " Hatırlamamak Eylemi? ";
                button25.Text = button21.Text;
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                textBox1.Text = "Türkiyede kedisi çok meşhur bir şehir? ";
                button25.Text = button22.Text;
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                textBox1.Text = "Bir mevsim, hava genellikle çok sıcaktır? ";
                button25.Text = button23.Text;
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                textBox1.Text = "Siyah beyaz bir hayvan? ";
                button25.Text = button24.Text;
                button24.BackColor = Color.Yellow;
            }
            if (soruno > 24)
            {
                MessageBox.Show("Verilen Doğru Cevap Sayısı= " + dogru.ToString() + " Verilen Yanlış Cevap Sayısı= " + yanlis.ToString());
                this.Hide();
            }

        }
    }
}
