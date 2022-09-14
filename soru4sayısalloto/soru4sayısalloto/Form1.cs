using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru4sayısalloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[6];          //rasgele sayıları tutmak için dizi 
            Random rasgele = new Random();    //rasgele sayı olusturmak için gerekli fonksiyon
            int loto;
     
            int sayac=0;
            while (sayac < 6)               //altı sayı alamak için
            {
                loto = rasgele.Next(1, 50);       //next fonksiyonu ile rasgele sayı atıyoruz

                if (Array.IndexOf(dizi, loto)==-1){    //aynı sayıları almamak için ındexof fonksiyonu kullanıyoruz
                 dizi[sayac] = loto;                  //rasgele sayıları diziye ataması
                 sayac++;
                 }
            }
            Array.Sort(dizi);                           //tuttuğumuz sayıları sıralıyor
            label3.Text = dizi[0].ToString();           //rastgele sayıları ekrana yazdırıyoruz
            label4.Text = dizi[1].ToString();
            label5.Text = dizi[2].ToString();
            label6.Text = dizi[3].ToString();
            label7.Text = dizi[4].ToString();
            label8.Text = dizi[5].ToString();

           
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            int sayi5 = Convert.ToInt32(textBox5.Text);
            int sayi6 = Convert.ToInt32(textBox6.Text);

            int tahminkac = 0;

            int[] tahmin = new int[6] {sayi1,sayi2,sayi3,sayi4,sayi5,sayi6};   //rasgele sayılarla tuttuğum sayıları karşılaştırmak için bir dizi daha oluşturdum

            for(int j = 0; j < tahmin.Length; j++)
            {
                for(int k = 0; k < dizi.Length; k++)
                {
                    if (tahmin[j] == dizi[k])           //iki dizinin karşılaştırma işlemi
                    {
                        tahminkac++;
                    }
                }
            }

            if (tahminkac >= 3)
            {
                MessageBox.Show("Tebrikler kazandınız " + tahminkac + " tutturdunuz.");
            }


        }
    }
}
