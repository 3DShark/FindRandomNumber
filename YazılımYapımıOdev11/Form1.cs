using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıOdev11
{
	public partial class Form1 : Form
	{

		// Değişken Tanımlamaları
		Random rastgele = new Random();
		int[] sayiArray = new int[6];
		string cozumText;
		int ciftHaneliSayi, hedefSayi = 0, yakinSayi = 0,j=0,sayi,loopSayi,kullanilanSayi,gecici,anlıkSonuc,operatör;

		private void Form1_Load(object sender, EventArgs e)
		{

		}
        public Form1()
        {
            InitializeComponent();
        }

		private void randomRadioButton_CheckedChanged(object sender, EventArgs e)
		{

			if (randomRadioButton.Checked)
			{
				groupBox1.Visible = false;
			}
			else
			{
				groupBox1.Visible = true;
			}

		}
		private void manuelRadioButton_CheckedChanged(object sender, EventArgs e)
		{

			if (manuelRadioButton.Checked)
			{
				Array.Clear(sayiArray, 0, 6);
				groupBox1.Visible = true;
			}
			else
			{
				groupBox1.Visible = false;
			}
		}
		private void TemizleBtn_Click(object sender, EventArgs e)
		{
			birinciText.Text = "";
			ikinciText.Text = "";
			ucText.Text = "";
			dortText.Text = "";
			besText.Text = "";
			ciftText.Text = "";
			hedefText.Text = "";
			sonucLabel.Text = "";

			listBox1.DataSource = null;
			ciftSayi.Text = "";
			hedefSayiLabel.Text = "";

		}


		// Random Sayıları Oluşturma Fonksiyonu
		private void randomSayi_Click(object sender, EventArgs e)
		{
			
			listBox1.DataSource = null;

			for (int i = 0; i < 5; i++)
			{
				sayi = rastgele.Next(1, 10);
				sayiArray[i] = sayi;
			}
			do
			{
				sayi = rastgele.Next(10, 100);
				ciftHaneliSayi = sayi;
			}
			while (ciftHaneliSayi % 10 != 0);

			sayiArray[5] = sayi;

			ciftSayi.Text = ciftHaneliSayi.ToString();
			sayi = rastgele.Next(100, 1000);
			hedefSayi = sayi;
			hedefSayiLabel.Text = hedefSayi.ToString();

			listBox1.DataSource = sayiArray;
	
		}

		private void hesapla_Click(object sender, EventArgs e)
		{
			j = 0;
			// Kullanıcının Opsiyonuna göre eğer manuel seçiliyse textboxtaki sayıları arraya atıyor
			if(manuelRadioButton.Checked == true)
			{
				TextBox[] tbs = { birinciText, ikinciText, ucText, dortText, besText, ciftText, hedefText };


				for (int i = 0; i < 7; i++)
				{
					if (tbs[i].Text == " ")
					{
						MessageBox.Show("Textboxlar Boş Olamaz");
						return;

					}
				}


				sayiArray[0] = Convert.ToInt32(birinciText.Text);
				sayiArray[1] = Convert.ToInt32(ikinciText.Text);
				sayiArray[2] = Convert.ToInt32(ucText.Text);
				sayiArray[3] = Convert.ToInt32(dortText.Text);
				sayiArray[4] = Convert.ToInt32(besText.Text);
				sayiArray[5] = Convert.ToInt32(ciftText.Text);
				hedefSayi = Convert.ToInt32(hedefText.Text);
				listBox1.DataSource = null;
				ciftSayi.Text = "";
				hedefSayiLabel.Text = "";

			}
			else if(randomRadioButton.Checked == true)
			{
				
				birinciText.Text = "";
				ikinciText.Text = "";
				ucText.Text = "";
				dortText.Text = "";
				besText.Text = "";
				ciftText.Text = "";
				hedefText.Text = "";
			}

			// Sayıya yaklaşma döngüsü
			while (true)
			{
				//
				//kullandığımız sayıyı birdaha kullanmamak için kurulan algoritma
				loopSayi = rastgele.Next(6);   
				gecici = sayiArray[loopSayi]; 
				sayiArray[loopSayi] = sayiArray[0]; 
				sayiArray[0] = gecici;

				anlıkSonuc = sayiArray[0];

				cozumText = sayiArray[0].ToString();

				kullanilanSayi = rastgele.Next(1, 7);

				//// 4 İşlemin yapıldığı döngü  üstte alınan sayıya 4 işlem uygulanıyor
				for (int i = 1; i < kullanilanSayi; i++)
				{
					
					 operatör = rastgele.Next(4);
					if (operatör == 0)
					{
						anlıkSonuc += sayiArray[i];
						cozumText +=   " + " + sayiArray[i].ToString(); 
					}
					if (operatör == 1)
					{
						anlıkSonuc -= sayiArray[i];
						cozumText += " - " + sayiArray[i].ToString();
					}
					if (operatör == 2)
					{
						anlıkSonuc *= sayiArray[i];
						cozumText += " x " + sayiArray[i].ToString(); 
					}
					if (operatör == 3)
					{
						if (anlıkSonuc % sayiArray[i] != 0) continue;
						anlıkSonuc /= sayiArray[i];
						cozumText += " / " + sayiArray[i].ToString();
					}
				}
				
				cozumText += " = " + anlıkSonuc.ToString();

				//
				// Ulaşabildiğimiz En Yakıns sayıyı burdan ayarlayıp tutuyoruz
				if (Math.Abs(hedefSayi - anlıkSonuc) < Math.Abs(hedefSayi - yakinSayi))
				{
					yakinSayi = anlıkSonuc;
					sonucLabel.Text = cozumText;
				}
				j++;  
				
				if (anlıkSonuc == hedefSayi)
				{
					sonucLabel.Text = cozumText;
					break;
				}
				// Döngü Bellli bir sefer döndükten sonra kendi kendini kapatıyor.++
				// ++ Ve Ulaşılan en yakın sayıyı ekrana yazdırıyor
				if (j == 1000000)
					break;

			}
			
		}

		
	}
}
