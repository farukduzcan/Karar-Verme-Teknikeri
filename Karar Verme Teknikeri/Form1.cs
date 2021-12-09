using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Verme_Teknikeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox[,] TextKutu;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        int satir;
        int sutun;
        int yapi;
        int dogaldurum;
        private void satiradedi_ValueChanged(object sender, EventArgs e)
        {
            satir = Convert.ToInt32(satiradedi.Value);
        }
        private void sutunadedi_ValueChanged(object sender, EventArgs e)
        {
            sutun = Convert.ToInt32(sutunadedi.Value);
        }
        private void yapitipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            yapi = yapitipi.SelectedIndex;
        }
        private void dogaldurumsatir_SelectedIndexChanged(object sender, EventArgs e)
        {
            dogaldurum = dogaldurumsatir.SelectedIndex;
        }

        private void KutuOlustur()
        {
            TextKutu = new TextBox[satir, sutun];
            int left = 100;
            int top = 50;
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    TextKutu[i, k] = new TextBox();
                    TextKutu[i, k].Left = left;
                    TextKutu[i, k].Top = top;
                    TextKutu[i, k].Width = 85;
                    this.Controls.Add(TextKutu[i, k]);
                    left += 100;
                }
                top = top + 60;
                left = 100;
            }
        }

        private void tablobuton_Click(object sender, EventArgs e)
        {
            KutuOlustur();
            satiradedi.Visible = false;
            sutunadedi.Visible = false;
            yapitipi.Visible = false;
            tablobuton.Visible = false;
            dogaldurumsatir.Visible = false;
            hesapbuton.Visible = true;
            alfadegeri.Visible = false;
            satirbilgi.Visible = false;
            sutunbilgi.Visible = false;
            yapibilgi.Visible = false;
            doğalsutunbilgi.Visible = false;
            alfadegeribilgi.Visible = false;
        }


        int iyimser;
        int iyimserdeger = 0;
        int kotumser;
        int kotumserdeger;
        int kotumsersatirbuyuk;
        int esolasılık;
        double esolasılıkdeger;
        int esolasılıksatir;
        double esolasılıkdegerbuyuk;
        double hurwics;
        double hurwicsdegeri;
        double hurwicsbuyuk;
        double hurwicskucuk;
        double hurwicssatirbuyuk;
        double hurwicssatirkucuk;
        double hurwicssonuc;
        double alfaeksi;
        double alfaartı;
        int pismanlik;
        int pismanliksutunfark;
        int pismanliksutunbuyuk;
        int pismanliksutunenbuyuk;
        int pismanliktablosubuyuk;
        int pismanliktablosudeğeri;
        int pismanliktablosusatirkucuk;
        string pismanlikalternatif;
        string kotumseralternatif;
        string iyimseralternatif;
        string esolasilikalternatif;
        string hurwicsalternatif;
        private void hesapbuton_Click(object sender, EventArgs e)
        {
            {
                if (yapi == 0)
                {
                    if (dogaldurum == 0)
                    {
                        /*Doğal Satır Adedi 1 tane */
                        /*iyimserlik hesaplama*/
                        for (int i = 1; i < satir; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                iyimser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (iyimser > iyimserdeger)
                                {
                                    iyimserdeger = iyimser;
                                    iyimseralternatif = TextKutu[i,0].Text ;

                                }

                            }
                        }

                        /*kötümserlik hesaplama*/
                        kotumsersatirbuyuk = Convert.ToInt32(TextKutu[1, 1].Text);
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (kotumser < kotumsersatirbuyuk)
                                {
                                    kotumsersatirbuyuk = kotumser;
                                    kotumseralternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 1; i < satir; i++)
                        {
                            kotumserdeger = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                 /*MessageBox.Show("kötümser  " + kotumser);
                                 MessageBox.Show("kötümser değer  " + kotumserdeger);*/

                                if (kotumser < kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                    /*MessageBox.Show("kotumser sayım kotumser değerden küçük olduğu için yeni kotumser sayım bu oldu" + kotumserdeger);*/
                                }
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Sütun Sonuna geldik şuan ki min(max) değerimiz "+kotumsersatirbuyuk);*/
                                    if (kotumserdeger > kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Sütunun sonuna geldik ve bu satırda ki en küçük değer diğer satırda ki en küçük değerden büyük olduğu için yeni sayımız " + kotumsersatirbuyuk);*/
                                    }
                                }
                            }
                        }

                        /* eş olasılık (laplaca)*/
                        for (int i = 1; i < satir; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger > esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
                                        //MessageBox.Show("Önceki Sütundan büyük olduğu için yeni eş değerimiz " + esolasılıkdegerbuyuk);
                                    }
                                }

                            }
                        }

                        /* Hurwics hesaplama */

                        for (int i = 1; i < satir; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirbuyuk) + (hurwicssatirkucuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    if (hurwicsdegeri > hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Hurwicsdegeri degerim yani şuan ki satır değerim önce ki hurwics değerimden büyük olduğu için sonuç değerim " + hurwicssonuc);*/
                                    }
                                }

                            }
                        }

                        /* Pişmanlık Değeri Hesaplama */
                        int[,] pismanliktablo = new int[satir, sutun];

                        for (int i = 1; i < sutun; i++)
                        {
                            pismanliksutunbuyuk = Convert.ToInt32(TextKutu[1, i].Text);
                            pismanliksutunenbuyuk = Convert.ToInt32(TextKutu[1, i].Text);
                            for (int j = 1; j < satir; j++)
                            {
                                pismanlik = Convert.ToInt32(TextKutu[j, i].Text);
                               // MessageBox.Show(" Şuan ki pişmanlık sayım " + pismanlik);
                                if (pismanlik > pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                    //MessageBox.Show(" pişmanlık sayım pişmanlık sütun büyük değerimden büyük oluğu için sütun büyük değişkenimin yeni sayısı" + pismanliksutunbuyuk);
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    //MessageBox.Show(" sütunumun sonuna geldim ve sütunda ki en büyük sayım " + pismanliksutunenbuyuk);
                                    int l;
                                    l = i;

                                    //MessageBox.Show(" L değerim  yani kaçıncı sütunda olduğum" + l);
                                    for (int m = 1; m < satir; m++)
                                    {
                                        pismanliksutunfark = pismanliksutunenbuyuk - Convert.ToInt32(TextKutu[m, l].Text);
                                        pismanliktablo[m, l] = pismanliksutunfark;
                                        //MessageBox.Show(m - 1+". satırın o sütunda ki en büyük değerle olan farkı "+pismanliksutunfark);
                                    }
                                }

                            }

                        }
                        pismanliktablosubuyuk = pismanliktablo[1, 1];
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                            }
                        }
                        pismanliktablosusatirkucuk = pismanliktablo[1, 1];
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosusatirkucuk)
                                {
                                    pismanliktablosusatirkucuk = pismanliktablosudeğeri;
                                    pismanlikalternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 1; i < satir; i++)
                        {
                            pismanliktablosubuyuk = pismanliktablo[i, 1];
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                               // MessageBox.Show("Pişmanlık tablosu değeri " + pismanliktablosudeğeri);

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                   // MessageBox.Show("Pişmanlık tablosu değeri pişmanlık tablosu buyuk değerinden büyük olduğu için yeni pişmanlık tablosu büyük değerimiz " + pismanliktablosubuyuk);

                                }
                                if (j == sutun - 1)
                                {
                                   // MessageBox.Show("satırın sonuna geldik ve pismanlık tablosu buyuk değerim "+pismanliktablosubuyuk);
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                       // MessageBox.Show("bu satırda ki en büyük değer bir önce ki satırda ki en büyük değerden daha küçük olduğu için yeni değerimiz "+pismanliktablosusatirkucuk);
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                    }
                                }
                            }
                        }
                        /*sonuç değeri (denemelik)*/
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");
                        /*iyimserform.Text = Convert.ToString(iyimseralternatif + "("+iyimserdeger+")");
                        kotumserform.Text = Convert.ToString(kotumseralternatif+" ("+kotumsersatirbuyuk+ " )");
                        esolasilikform.Text = Convert.ToString(esolasilikalternatif+"(" + esolasılıkdegerbuyuk+ ")");
                        hurwicsform.Text = Convert.ToString(hurwicsalternatif+ "("+hurwicssonuc+ ")");
                        pismanlikform.Text = Convert.ToString(pismanlikalternatif+"("+ pismanliktablosusatirkucuk+")");*/
                    }
                    /* doğal durum satır adedi 2 adet*/
                    else if (dogaldurum == 1)
                    {
                        /*iyimserlik hesaplama*/
                        for (int i = 2; i < satir; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                iyimser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (iyimser > iyimserdeger)
                                {
                                    iyimserdeger = iyimser;
                                    iyimseralternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }

                        /*kötümserlik hesaplama*/
                        kotumsersatirbuyuk = Convert.ToInt32(TextKutu[2, 1].Text);
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (kotumser < kotumsersatirbuyuk)
                                {
                                    kotumsersatirbuyuk = kotumser;
                                    kotumseralternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 2; i < satir; i++)
                        {
                            kotumserdeger = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                /* MessageBox.Show("kötümser  " + kotumser);
                                 MessageBox.Show("kötümser değer  " + kotumserdeger);*/

                                if (kotumser < kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                    /*MessageBox.Show("kotumser sayım kotumser değerden küçük olduğu için yeni kotumser sayım bu oldu" + kotumserdeger);*/
                                }
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Sütun Sonuna geldik şuan ki min(max) değerimiz "+kotumsersatirbuyuk);*/
                                    if (kotumserdeger > kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Sütunun sonuna geldik ve bu satırda ki en küçük değer diğer satırda ki en küçük değerden büyük olduğu için yeni sayımız " + kotumsersatirbuyuk);*/
                                    }
                                }
                            }
                        }

                        /* eş olasılık (laplaca)*/
                        for (int i = 2; i < satir; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);*/
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger > esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Önceki Sütundan büyük olduğu için yeni eş değerimiz " + esolasılıkdegerbuyuk);*/
                                    }
                                }

                            }
                        }

                        /* Hurwics hesaplama */

                        for (int i = 2; i < satir; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirbuyuk) + (hurwicssatirkucuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    if (hurwicsdegeri > hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Hurwicsdegeri degerim yani şuan ki satır değerim önce ki hurwics değerimden büyük olduğu için sonuç değerim " + hurwicssonuc);*/
                                    }
                                }

                            }
                        }

                        /* Pişmanlık Değeri Hesaplama */
                        int[,] pismanliktablo = new int[satir, sutun];

                        for (int i = 1; i < sutun; i++)
                        {
                            pismanliksutunbuyuk = Convert.ToInt32(TextKutu[2, i].Text);
                            pismanliksutunenbuyuk = Convert.ToInt32(TextKutu[2, i].Text);
                            for (int j = 2; j < satir; j++)
                            {
                                pismanlik = Convert.ToInt32(TextKutu[j, i].Text);
                                /*MessageBox.Show(" Şuan ki pişmanlık sayım " + pismanlik);*/
                                if (pismanlik > pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                    /*MessageBox.Show(" pişmanlık sayım pişmanlık sütun büyük değerimden büyük oluğu için sütun büyük değişkenimin yeni sayısı" + pismanliksutunbuyuk);*/
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    /*MessageBox.Show(" sütunumun sonuna geldim ve sütunda ki en büyük sayım " + pismanliksutunenbuyuk);*/
                                    int l;
                                    l = i;

                                    /*MessageBox.Show(" L değerim  yani kaçıncı sütunda olduğum" + l);*/
                                    for (int m = 2; m < satir; m++)
                                    {
                                        pismanliksutunfark = pismanliksutunenbuyuk - Convert.ToInt32(TextKutu[m, l].Text);
                                        pismanliktablo[m, l] = pismanliksutunfark;
                                        /*MessageBox.Show(m - 1+". satırın o sütunda ki en büyük değerle olan farkı "+pismanliksutunfark);*/
                                    }
                                }

                            }

                        }
                        pismanliktablosubuyuk = pismanliktablo[2, 1];
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                            }
                        }

                        pismanliktablosusatirkucuk = pismanliktablo[2, 1];
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosusatirkucuk)
                                {
                                    pismanliktablosusatirkucuk = pismanliktablosudeğeri;
                                    pismanlikalternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }

                        for (int i = 2; i < satir; i++)
                        {
                            pismanliktablosubuyuk = pismanliktablo[i, 1];
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                /*MessageBox.Show("Pişmanlık tablosu değeri " + pismanliktablosudeğeri);*/

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                    /*MessageBox.Show("Pişmanlık tablosu değeri pişmanlık tablosu buyuk değerinden büyük olduğu için yeni pişmanlık tablosu büyük değerimiz " + pismanliktablosubuyuk);*/

                                }
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("satırın sonuna geldik ve pismanlık tablosu buyuk değerim "+pismanliktablosubuyuk);*/
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("bu satırda ki en büyük değer bir önce ki satırda ki en büyük değerden daha küçük olduğu için yeni değerimiz "+pismanliktablosusatirkucuk);*/
                                    }
                                }
                            }
                        }



                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                                        "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                                        "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                                        "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                                        "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");

                        /*sonuç değeri (denemelik)
                        iyimserform.Text = Convert.ToString(iyimserdeger);
                        kotumserform.Text = Convert.ToString(kotumsersatirbuyuk);
                        esolasilikform.Text = Convert.ToString(esolasılıkdegerbuyuk);
                        hurwicsform.Text = Convert.ToString(hurwicssonuc);
                        pismanlikform.Text = Convert.ToString(pismanliktablosusatirkucuk);*/

                    }

                }
                // ----------------------MALİYET YAPILI---------------------------
                else if (yapi == 1)
                {
                    //------------------2 Adet Doğal Durum Satırı-----------------
                    if (dogaldurum == 0)
                    {
                        /*Doğal Satır Adedi 1 tane */
                        /*iyimserlik hesaplama*/
                        for (int i = 1; i < satir; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                iyimser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (iyimser < iyimserdeger)
                                {
                                    iyimserdeger = iyimser;
                                    iyimseralternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }

                        /*kötümserlik hesaplama*/
                        kotumsersatirbuyuk = Convert.ToInt32(TextKutu[1, 1].Text);
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (kotumser > kotumsersatirbuyuk)
                                {
                                    kotumsersatirbuyuk = kotumser;
                                    kotumseralternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 1; i < satir; i++)
                        {
                            kotumserdeger = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("kötümser  " + kotumser);
                                MessageBox.Show("kötümser değer  " + kotumserdeger);*/

                                if (kotumser > kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                    /*MessageBox.Show("kotumser sayım kotumser değerden küçük olduğu için yeni kotumser sayım bu oldu" + kotumserdeger);*/
                                }
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Sütun Sonuna geldik şuan ki min(max) değerimiz "+kotumsersatirbuyuk);*/
                                    if (kotumserdeger < kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Sütunun sonuna geldik ve bu satırda ki en küçük değer diğer satırda ki en küçük değerden büyük olduğu için yeni sayımız " + kotumsersatirbuyuk);*/
                                    }
                                }
                            }
                        }

                        /* eş olasılık (laplaca)*/

                        for (int i = 1; i < 2 ; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    esolasılıkdegerbuyuk = esolasılıkdeger;
                                }

                            }
                        }


                        for (int i = 1; i < satir; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    //MessageBox.Show("Sütun toplamlarının " + (sutun - 1) + " e bölümünün sonucu " + esolasılıkdeger);
                                    if (esolasılıkdeger < esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
                                        // MessageBox.Show("Önceki Sütundan büyük olduğu için yeni eş değerimiz " + esolasılıkdegerbuyuk);
                                    }
                                }

                            }
                        }

                        /* Hurwics hesaplama */

                        for (int i = 1; i < 2; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    hurwicssonuc = hurwicsdegeri;
                                    hurwicsalternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }

                        for (int i = 1; i < satir; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    if (hurwicsdegeri < hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Hurwicsdegeri degerim yani şuan ki satır değerim önce ki hurwics değerimden büyük olduğu için sonuç değerim " + hurwicssonuc);*/
                                    }
                                }

                            }
                        }

                        /* Pişmanlık Değeri Hesaplama */
                        int[,] pismanliktablo = new int[satir, sutun];

                        for (int i = 1; i < sutun; i++)
                        {
                            pismanliksutunbuyuk = Convert.ToInt32(TextKutu[1, i].Text);
                            pismanliksutunenbuyuk = Convert.ToInt32(TextKutu[1, i].Text);
                            for (int j = 1; j < satir; j++)
                            {
                                pismanlik = Convert.ToInt32(TextKutu[j, i].Text);
                                // MessageBox.Show(" Şuan ki pişmanlık sayım " + pismanlik);
                                if (pismanlik < pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                    //MessageBox.Show(" pişmanlık sayım pişmanlık sütun büyük değerimden büyük oluğu için sütun büyük değişkenimin yeni sayısı" + pismanliksutunbuyuk);
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    //MessageBox.Show(" sütunumun sonuna geldim ve sütunda ki en büyük sayım " + pismanliksutunenbuyuk);
                                    int l;
                                    l = i;

                                    //MessageBox.Show(" L değerim  yani kaçıncı sütunda olduğum" + l);
                                    for (int m = 1; m < satir; m++)
                                    {
                                        pismanliksutunfark = Convert.ToInt32(TextKutu[m, l].Text) - pismanliksutunenbuyuk;
                                        pismanliktablo[m, l] = pismanliksutunfark;
                                        //MessageBox.Show(m - 1+". satırın o sütunda ki en büyük değerle olan farkı "+pismanliksutunfark);
                                    }
                                }

                            }

                        }
                        pismanliktablosubuyuk = pismanliktablo[1, 1];
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                            }
                        }
                        pismanliktablosusatirkucuk = pismanliktablo[1, 1];
                        for (int i = 1; i < 2; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosusatirkucuk)
                                {
                                    pismanliktablosusatirkucuk = pismanliktablosudeğeri;
                                    pismanlikalternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 1; i < satir; i++)
                        {
                            pismanliktablosubuyuk = pismanliktablo[i, 1];
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                               // MessageBox.Show("Pişmanlık tablosu değeri " + pismanliktablosudeğeri);

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                    //MessageBox.Show("Pişmanlık tablosu değeri pişmanlık tablosu buyuk değerinden büyük olduğu için yeni pişmanlık tablosu büyük değerimiz " + pismanliktablosubuyuk);

                                }
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("satırın sonuna geldik ve pismanlık tablosu buyuk değerim " + pismanliktablosubuyuk);
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                        //MessageBox.Show("bu satırda ki en büyük değer bir önce ki satırda ki en büyük değerden daha küçük olduğu için yeni değerimiz " + pismanliktablosusatirkucuk);
                                    }
                                }
                            }
                        }
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");
                        /*sonuç değeri (denemelik)
                        iyimserform.Text = Convert.ToString(iyimserdeger);
                        kotumserform.Text = Convert.ToString(kotumsersatirbuyuk);
                        esolasilikform.Text = Convert.ToString(esolasılıkdegerbuyuk);
                        hurwicsform.Text = Convert.ToString(hurwicssonuc);
                        pismanlikform.Text = Convert.ToString(pismanliktablosusatirkucuk);*/
                    }
                    else if (dogaldurum == 1)
                        //------------------------ DOĞAL DURUM SATIR ADEDİ 2 -----------------------------------
                    {
                        /*iyimserlik hesaplama*/
                        for (int i = 2; i < satir; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                iyimser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (iyimser < iyimserdeger)
                                {
                                    iyimserdeger = iyimser;
                                    iyimseralternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }

                        /*kötümserlik hesaplama*/
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                if (kotumser > kotumsersatirbuyuk)
                                {
                                    kotumsersatirbuyuk = kotumser;
                                    kotumseralternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }


                        for (int i = 2; i < satir; i++)
                        {
                            kotumserdeger = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                kotumser = Convert.ToInt32(TextKutu[i, j].Text);
                                /* MessageBox.Show("kötümser  " + kotumser);
                                 MessageBox.Show("kötümser değer  " + kotumserdeger);*/

                                if (kotumser > kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                    /*MessageBox.Show("kotumser sayım kotumser değerden küçük olduğu için yeni kotumser sayım bu oldu" + kotumserdeger);*/
                                }
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Sütun Sonuna geldik şuan ki min(max) değerimiz "+kotumsersatirbuyuk);*/
                                    if (kotumserdeger < kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Sütunun sonuna geldik ve bu satırda ki en küçük değer diğer satırda ki en küçük değerden büyük olduğu için yeni sayımız " + kotumsersatirbuyuk);*/
                                    }
                                }
                            }
                        }

                        /* eş olasılık (laplaca)*/

                        for (int i = 2; i < 3; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    esolasılıkdegerbuyuk = esolasılıkdeger;
                                    esolasilikalternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }


                        for (int i = 2; i < satir; i++)
                        {
                            esolasılık = Convert.ToInt32(TextKutu[i, 1].Text);
                            esolasılıksatir = 0;
                            for (int j = 1; j < sutun; j++)
                            {
                                esolasılık = Convert.ToInt32(TextKutu[i, j].Text);
                                esolasılıksatir = esolasılıksatir + esolasılık;
                                if (j == sutun - 1)
                                {
                                    /*MessageBox.Show("Son sütuna geldik sütunların toplamı = " + esolasılıksatir);*/
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger < esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Önceki Sütundan büyük olduğu için yeni eş değerimiz " + esolasılıkdegerbuyuk);*/
                                    }
                                }

                            }
                        }

                        /* Hurwics hesaplama */

                        for (int i = 2; i < 3; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    hurwicssonuc = hurwicsdegeri;
                                    hurwicsalternatif = TextKutu[i, 0].Text;
                                }

                            }
                        }

                        for (int i = 2; i < satir; i++)
                        {
                            hurwicsbuyuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            hurwicskucuk = Convert.ToInt32(TextKutu[i, 1].Text);
                            for (int j = 1; j < sutun; j++)
                            {
                                hurwics = Convert.ToInt32(TextKutu[i, j].Text);
                                /*MessageBox.Show("Şuan ki hurwics değerim " + hurwics);*/
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics buyuk degerim " + hurwicsbuyuk);*/
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                    /*MessageBox.Show("Şuan ki hurwics küçük değerim " + hurwicskucuk);*/
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    /*MessageBox.Show("Sonuncu Sütuna geldim ve bu satırda ki en büyük sayı " + hurwicssatirbuyuk+" en küçük sayı ise "+hurwicssatirkucuk);*/
                                    alfaeksi = 1 - Convert.ToDouble(alfadegeri.Text);
                                    alfaartı = Convert.ToDouble(alfadegeri.Text);
                                    /*MessageBox.Show("Şuan ki alfa değerim " + alfaartı+" ve 1 alfa değerim "+alfaeksi);*/
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    /*MessageBox.Show("Şuan ki hurwicsdeğeri değerim " + hurwicsdegeri);*/
                                    if (hurwicsdegeri < hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
                                        /*MessageBox.Show("Hurwicsdegeri degerim yani şuan ki satır değerim önce ki hurwics değerimden büyük olduğu için sonuç değerim " + hurwicssonuc);*/
                                    }
                                }

                            }
                        }

                        /* Pişmanlık Değeri Hesaplama */
                        int[,] pismanliktablo = new int[satir, sutun];

                        for (int i = 1; i < sutun; i++)
                        {
                            pismanliksutunbuyuk = Convert.ToInt32(TextKutu[2, i].Text);
                            pismanliksutunenbuyuk = Convert.ToInt32(TextKutu[2, i].Text);
                            for (int j = 2; j < satir; j++)
                            {
                                pismanlik = Convert.ToInt32(TextKutu[j, i].Text);
                                //MessageBox.Show(" Şuan ki pişmanlık sayım " + pismanlik);
                                if (pismanlik < pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                    //MessageBox.Show(" pişmanlık sayım pişmanlık sütun büyük değerimden büyük oluğu için sütun büyük değişkenimin yeni sayısı" + pismanliksutunbuyuk);
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    //MessageBox.Show(" sütunumun sonuna geldim ve sütunda ki en büyük sayım " + pismanliksutunenbuyuk);
                                    int l;
                                    l = i;

                                    //MessageBox.Show(" L değerim  yani kaçıncı sütunda olduğum" + l);
                                    for (int m = 2; m < satir; m++)
                                    {
                                        pismanliksutunfark =  Convert.ToInt32(TextKutu[m, l].Text) - pismanliksutunenbuyuk;
                                        pismanliktablo[m, l] = pismanliksutunfark;
                                        //MessageBox.Show(m - 1+". satırın o sütunda ki en büyük değerle olan farkı "+pismanliksutunfark);
                                    }
                                }

                            }

                        }
                        pismanliktablosubuyuk = pismanliktablo[2, 1];
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                            }
                        }

                        pismanliktablosusatirkucuk = pismanliktablo[2, 1];
                        for (int i = 2; i < 3; i++)
                        {
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                if (pismanliktablosudeğeri > pismanliktablosusatirkucuk)
                                {
                                    pismanliktablosusatirkucuk = pismanliktablosudeğeri;
                                    pismanlikalternatif = TextKutu[i, 0].Text;
                                }
                            }
                        }

                        for (int i = 2; i < satir; i++)
                        {
                            pismanliktablosubuyuk = pismanliktablo[i, 1];
                            for (int j = 1; j < sutun; j++)
                            {
                                pismanliktablosudeğeri = pismanliktablo[i, j];
                                //MessageBox.Show("Pişmanlık tablosu değeri " + pismanliktablosudeğeri);

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                    //MessageBox.Show("Pişmanlık tablosu değeri pişmanlık tablosu buyuk değerinden büyük olduğu için yeni pişmanlık tablosu büyük değerimiz " + pismanliktablosubuyuk);

                                }
                                if (j == sutun - 1)
                                {
                                    //MessageBox.Show("satırın sonuna geldik ve pismanlık tablosu buyuk değerim "+pismanliktablosubuyuk);
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                        //MessageBox.Show("bu satırda ki en büyük değer bir önce ki satırda ki en büyük değerden daha küçük olduğu için yeni değerimiz "+pismanliktablosusatirkucuk);
                                    }
                                }
                            }
                        }


                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");

                        /*sonuç değeri (denemelik)
                        iyimserform.Text = Convert.ToString(iyimserdeger);
                        kotumserform.Text = Convert.ToString(kotumsersatirbuyuk);
                        esolasilikform.Text = Convert.ToString(esolasılıkdegerbuyuk);
                        hurwicsform.Text = Convert.ToString(hurwicssonuc);
                        pismanlikform.Text = Convert.ToString(pismanliktablosusatirkucuk);*/


                    }
                }
            }
        }


    }
}
