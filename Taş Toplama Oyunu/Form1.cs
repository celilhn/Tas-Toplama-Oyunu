using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Toplama_Oyunu
{
    public partial class Form1 : Form
    {
        // Değişkenler
        private int birinciOyuncu_tasStok = 3;
        private int ikinciOyuncu_tasStok = 3;
        private int ana_tas_stok = 1;
        private string[,] label_matris = new string[10, 10];
        private Label temp_ana_lbl;
        private Label[] lbl_duvarlar = new Label[15];
        private Label[] lDizi = new Label[100];
        private int counter_duvar = 0;
        private bool oyuncu1 = true;
        private bool oyuncu2 = false;
        private bool anatas = false;
        private int counterLevel = 0;

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            doldur(); // Label matrisi oluşturur
            lbl_Oyuncu_Siralama.Text = "Lütfen anataşı yerleştiriniz.";
            lbl_level.Text = "LEVEL 1";
        }

        // 10*10 Label matrisi oluşturur ve konumlandırır. Ulaşabilmek için sıralı şekilde dizi içerisine atandı.
        private void doldur()
        {
            bool IsColor = true;
            int counter = 0;

            lblStok.Text = birinciOyuncu_tasStok.ToString();
            lbl_stok_2.Text = ikinciOyuncu_tasStok.ToString();

            for (int i = 0; i < 10; i++) // Matris oluşturuluyor
            {

                for (int j = 0; j < 10; j++) 
                {
                    // Label oluşturma
                    lDizi[counter] = new Label();

                    lDizi[counter].Name = "lbl" + counter;

                    label_matris[i, j] = lDizi[counter].Name;

                    this.Controls.Add(lDizi[counter]);

                    lDizi[counter].Top = 80 + (i * 40);

                    lDizi[counter].Left = 20 + (40 * j);

                    if (IsColor) // Beyaz renklendirme
                    {
                        lDizi[counter].BackColor = Color.White;
                        IsColor = false;
                    }
                    else // Siyah renklendirme
                    {
                        lDizi[counter].BackColor = Color.Black;
                        IsColor = true;
                    }
                    lDizi[counter].Visible = true; // Görünürlük
                    lDizi[counter].AutoSize = false; 
                    lDizi[counter].AllowDrop = true; // Üstüne sürüklenen nesneyi almasını sağlar
                    lDizi[counter].Width = 40;
                    lDizi[counter].Height = 40;

                    // Label sürükle bırak metodları tanımlandı. Fonksiyonlar atandı.
                    lDizi[counter].DragDrop += new System.Windows.Forms.DragEventHandler(label_DragDrop);
                    lDizi[counter].DragEnter += new System.Windows.Forms.DragEventHandler(label_DragEnter);

                    counter++;
                }

                //  Renklendirme ayarları
                if (IsColor)
                    IsColor = false;
                else
                    IsColor = true;
            }
        }

        private void label_DragDrop(object sender, DragEventArgs e) // Sürükle bırak metodu
        {
            try
            {
                Label L = (Label)sender;

                if (L.Image == null) // İmage yok ise
                {
                    if (e.Data.GetData(DataFormats.Bitmap) == lbl_oyuncu1_yantas.Image && birinciOyuncu_tasStok > 0) // 1. oyuncu taşı sürüklendiyse ve yan taş stoğu var ise
                    {
                        if (oyuncu1 && anatas) // Sıra 1. oyuncuda ise ve anataş matrise eklendi ise 
                        {
                            // Matrise eklenen taşlar lbl_duvarlar dizisine atanıyor
                            lbl_duvarlar[counter_duvar] = L;
                            counter_duvar++;

                            // Label ayarları
                            L.Image = lbl_oyuncu1_yantas.Image;
                            L.Text = UzaklikHesapla(L).ToString(); // Uzaklık hesaplanıp text'e yazdırılıyor
                            L.TextAlign = ContentAlignment.MiddleCenter;
                            L.ForeColor = Color.Red;
                            L.Font = new Font("Arial", 20, FontStyle.Bold);

                            // Yan taş stoğu bir azaltılıyor ve lblStok'e yazdırılıyor
                            if (birinciOyuncu_tasStok > 0)
                                birinciOyuncu_tasStok--;
                            lblStok.Text = birinciOyuncu_tasStok.ToString();

                            // Sırası gelen oyuncu lbl_Oyuncu_Siralama'a yazdırılıyor ve oyuncu sıra değişikliği yapılıyor
                            lbl_Oyuncu_Siralama.Text = "Sıra 2. oyuncuda";
                            oyuncu1 = false;
                            oyuncu2 = true;
                        }
                        else if (anatas && !oyuncu1) // Anataş matrise eklendiyse ve sıra oyuncuda değilse, sıranın kimde olduğunu yazdırıyor
                        {
                            lbl_Oyuncu_Siralama.Text = "Sıra 2. oyuncuda";
                        }
                        else
                            lbl_Oyuncu_Siralama.Text = "Lüfen anataşı yerleştiriniz.";
                            
                    }
                    else if (e.Data.GetData(DataFormats.Bitmap) == lbl_ana_tas.Image && ana_tas_stok > 0) // Ana taş sürüklendiyse ve ana taş stoğu var ise
                    {
                        anatas = true; // Anataş matrise eklendi
                        temp_ana_lbl = L; // Ana taş label'inin yedeği alınıyor

                        // Label ayarları
                        L.Image = lbl_ana_tas.Image;
                        L.TextAlign = ContentAlignment.MiddleCenter;
                        L.ForeColor = Color.Red;
                        L.Font = new Font("Arial", 20, FontStyle.Bold);
                        lbl_Oyuncu_Siralama.Text = "Sıra 1. Oyuncuda";

                        // Ana taş stoğu bir azaltılıyor
                        if (ana_tas_stok > 0)
                            ana_tas_stok--;
                    }
                    else if (e.Data.GetData(DataFormats.Bitmap) == lbl_duvaroyuncu1.Image) // 1. duvar sürüklendiyse ve duvar stoğu var ise
                    {
                        // Matrise eklenen taşlar lbl_duvarlar dizisine atanıyor
                        lbl_duvarlar[counter_duvar] = L; 
                        counter_duvar++;

                        // Label ayarları
                        L.Image = lbl_duvaroyuncu1.Image;
                        L.TextAlign = ContentAlignment.MiddleCenter;
                        L.ForeColor = Color.Red;
                        L.Font = new Font("Arial", 20, FontStyle.Bold);
                    }
                    if (e.Data.GetData(DataFormats.Bitmap) == lbl_oyuncu2_yantas.Image && ikinciOyuncu_tasStok > 0) // 2. oyuncu yan taşı sürüklendiyse ve yan taş stoğu var ise
                    {
                        if(oyuncu2 && anatas) // Sıra 2. oyuncuda ise ve anataş matrise eklendi ise 
                        {
                            // Matrise eklenen taşlar lbl_duvarlar dizisine atanıyor
                            lbl_duvarlar[counter_duvar] = L;
                            counter_duvar++;

                            // Label ayarları
                            L.Image = lbl_oyuncu1_yantas.Image;
                            L.Text = UzaklikHesapla(L).ToString(); // Uzaklık hesaplanıp text'e yazdırılıyor
                            L.TextAlign = ContentAlignment.MiddleCenter;
                            L.ForeColor = Color.Red;
                            L.Font = new Font("Arial", 20, FontStyle.Bold);

                            // Yan taş stoğu bir azaltılıyor ve lbl_stok_2'e yazdırılıyor
                            if (ikinciOyuncu_tasStok > 0)
                                ikinciOyuncu_tasStok--;
                            lbl_stok_2.Text = ikinciOyuncu_tasStok.ToString();

                            // Sırası gelen oyuncu lbl_Oyuncu_Siralama'a yazdırılıyor ve oyuncu sıra değişikliği yapılıyor
                            lbl_Oyuncu_Siralama.Text = "Sıra 1. oyuncuda";
                            oyuncu2 = false;
                            oyuncu1 = true;
                        }
                        else if(anatas && oyuncu2) // Anataş matrise eklendiyse ve sıra oyuncuda değilse, sıranın kimde olduğunu yazdırıyor
                        {
                            lbl_Oyuncu_Siralama.Text = "Sıra 1. oyuncuda";
                        }
                        else
                            lbl_Oyuncu_Siralama.Text = "Lüfen anataşı yerleştiriniz.";
                    }
                    else if (e.Data.GetData(DataFormats.Bitmap) == lbl_duvar_oyuncu2.Image) // 2. oyuncu duvar sürüklendiyse ve duvar stoğu var ise
                    {
                        // Matrise eklenen taşlar lbl_duvarlar dizisine atanıyor
                        lbl_duvarlar[counter_duvar] = L; 
                        counter_duvar++;

                        // Label ayarları
                        L.Image = lbl_duvaroyuncu1.Image;
                        L.TextAlign = ContentAlignment.MiddleCenter;
                        L.ForeColor = Color.Red;
                        L.Font = new Font("Arial", 20, FontStyle.Bold);
                    }

                    // Eğer bütün yantaşlar matrise eklendi ise matrise temizleniyor ve diğer bölüme geçiliyor
                    if(birinciOyuncu_tasStok == 0 && ikinciOyuncu_tasStok == 0)
                    {
                        temizle();
                        lbl_Oyuncu_Siralama.Text = "Lüfen anataşı yerleştiriniz.";
                    }
                }
            }
            catch(InvalidCastException a)
            {
                MessageBox.Show("Exception " + a);
            }
                
        }

        // Matris ve değişkenler temizleniyor ve diğer level ayarları yapılıyor
        private void temizle()
        {
            counterLevel++; // Level sayısı

            if (counterLevel == 1) // 2 levelli olacak
            {
                // Label resimleri ve textleri temizleniyor
                for (int i = 0; i < 100; i++)
                {
                    lDizi[i].Image = null;
                    lDizi[i].Text = "";
                }

                // Yeni bölüm taş stokları
                ana_tas_stok = 1;
                birinciOyuncu_tasStok = 4;
                ikinciOyuncu_tasStok = 4;

                // Label textlerş
                lblStok.Text = birinciOyuncu_tasStok.ToString();
                lbl_stok_2.Text = ikinciOyuncu_tasStok.ToString();

                // Oyuncu ayarları
                oyuncu1 = false;
                oyuncu2 = true;
                anatas = false;

                // Değişkenler temizlendi
                lbl_duvarlar = new Label[10];
                temp_ana_lbl = new Label();

                lbl_level.Text = "LEVEL 2";
            }
            else
                this.Close();
        }

        private void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lbl_tas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && birinciOyuncu_tasStok > 0) // Mausenin sol butonuna basıldı ise ve yantaş stoğu 0 dan büyükse 
            {
                lbl_oyuncu1_yantas.DoDragDrop(lbl_oyuncu1_yantas.Image, DragDropEffects.All);
            }
            
        }

        private void lbl_ana_tas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ana_tas_stok > 0) // Mausenin sol butonuna basıldı ise ve yantaş stoğu 0 dan büyükse 
            {
                lbl_ana_tas.DoDragDrop(lbl_ana_tas.Image, DragDropEffects.All);
            }
        }

        private void lbl_duvar_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Mausenin sol butonuna basıldı ise
            {
                lbl_duvaroyuncu1.DoDragDrop(lbl_duvaroyuncu1.Image, DragDropEffects.All);
            }
        }

        // Ana taş ile yan taş arasındaki uzaklığı hesaplama
        private int UzaklikHesapla(Label L)
        {
            // Yan taşın kordinat bilgileri
            int tas_satir = L.Name[3] - 48;
            int tas_sutun;
            if (L.Name.Length == 4)
                tas_sutun = 0;
            else
                tas_sutun = L.Name[4] - 48;

            // Ana taşın kordinat bilgileri
            int ana_tas_satir = temp_ana_lbl.Name[3] - 48;
            int ana_tas_sutun;
            if (temp_ana_lbl.Name.Length == 4)
                ana_tas_sutun = 0;
            else
                ana_tas_sutun = temp_ana_lbl.Name[4] - 48;

            // Matris uzaklık metoduna göre uzaklık hesaplandı.
            int adımSayisi = Math.Abs(tas_satir - ana_tas_satir) + Math.Abs(tas_sutun - ana_tas_sutun);

            return adımSayisi;
        }

        // LEVEL 2
        private void btn_level_2_Click(object sender, EventArgs e)
        {
            //// Matris ve değişkenler temizleniyor ve diğer level ayarları yapılıyor
            temizle();
        }

        private void lbl_tas_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // Mausenin sol butonuna basıldı ise
            {
                lbl_oyuncu1_yantas.DoDragDrop(lbl_oyuncu2_yantas.Image, DragDropEffects.All);
            }
        }

        private void lbl_duvar_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // Mausenin sol butonuna basıldı ise
            {
                lbl_duvaroyuncu1.DoDragDrop(lbl_duvar_oyuncu2.Image, DragDropEffects.All);
            }
        }

    }
}