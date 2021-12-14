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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        TextBox[,] TextKutu;
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
            satir = satir + (Convert.ToInt32(dogaldurumsatir.SelectedItem));
            sutun = sutun + 1;
        }
        private void KutuOlustur()
        {
            TextKutu = new TextBox[satir , sutun];
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
            if (satiradedi.Value >0)
            {
                if (sutunadedi.Value>0)
                {
                    if (yapitipi.SelectedIndex != -1)
                    {
                        if (dogaldurumsatir.SelectedIndex != -1)
                        {
                            if (alfag.TextLength != 0)
                            {
                                if (Convert.ToDouble(alfag.Text) > 0)
                                {
                                    if (Convert.ToDouble(alfag.Text) < 1)
                                    {
                                        KutuOlustur();
                                        satiradedi.Visible = false;
                                        sutunadedi.Visible = false;
                                        yapitipi.Visible = false;
                                        tablobuton.Visible = false;
                                        dogaldurumsatir.Visible = false;
                                        hesapbuton.Visible = true;
                                        alfag.Visible = false;
                                        satirbilgi.Visible = false;
                                        sutunbilgi.Visible = false;
                                        yapibilgi.Visible = false;
                                        doğalsutunbilgi.Visible = false;
                                        alfadegeribilgi.Visible = false;
                                        hesapbuton.Visible = true;
                                        groupBox1.Visible = false;
                                        tablosifirlaform.Visible = true;
                                        sayisifirlaform.Visible = true;
                                        dogaldurumbilgiform.Visible = true;
                                        tusgrubu.Visible = true;
                                        geri.Visible = true;
                                        cikis.Visible = true;
                                        if (dogaldurumsatir.SelectedIndex == 0)
                                        {
                                            TextKutu[0, 0].Visible = false;
                                            alternatifler2.Visible = true;
                                            for (int j = 1; j < sutun; j++)
                                            {
                                                TextKutu[0, j].BackColor = Color.WhiteSmoke;
                                            }
                                            for (int j = 1; j < satir; j++)
                                            {
                                                TextKutu[j, 0].BackColor = Color.WhiteSmoke;
                                            }
                                        }
                                        else if (dogaldurumsatir.SelectedIndex == 1)
                                        {
                                            TextKutu[0, 0].Visible = false;
                                            TextKutu[1, 0].Visible = false;
                                            alternatifbilgiform.Visible = true;
                                            for (int i = 0; i < 2; i++)
                                            {
                                                for (int j = 1; j < sutun; j++)
                                                {
                                                    TextKutu[i, j].BackColor = Color.Lavender;
                                                }
                                                for (int j = 2; j < satir; j++)
                                                {
                                                    TextKutu[j, 0].BackColor = Color.Lavender;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("1'den küçük bir Alfa değeri giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("0'dan Büyük bir Alfa değeri giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show(" Lütfen Alfa değeri girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                          
                        }
                        else
                        {
                            MessageBox.Show("Doğal Durum Satır Adedini Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yapı Tipini Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Sütun Adedine 0'dan büyük bir sayı girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Satır Adedine 0'dan büyük bir sayı girin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
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
                                if (kotumser < kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                }
                                if (j == sutun - 1)
                                {
                                    if (kotumserdeger > kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
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
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger > esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;   
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                    
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirbuyuk) + (hurwicssatirkucuk * alfaeksi);
                                    if (hurwicsdegeri > hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
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
                                if (pismanlik > pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    int l;
                                    l = i;

                                    for (int m = 1; m < satir; m++)
                                    {
                                        pismanliksutunfark = pismanliksutunenbuyuk - Convert.ToInt32(TextKutu[m, l].Text);
                                        pismanliktablo[m, l] = pismanliksutunfark;
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

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                                if (j == sutun - 1)
                                {
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                    }
                                }
                            }
                        }
                        
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");
                        
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
                                if (kotumser < kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                }
                                if (j == sutun - 1)
                                {
                                    if (kotumserdeger > kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
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
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger > esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirbuyuk) + (hurwicssatirkucuk * alfaeksi);
                                    if (hurwicsdegeri > hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
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
                                if (pismanlik > pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    int l;
                                    l = i;
                                    for (int m = 2; m < satir; m++)
                                    {
                                        pismanliksutunfark = pismanliksutunenbuyuk - Convert.ToInt32(TextKutu[m, l].Text);
                                        pismanliktablo[m, l] = pismanliksutunfark;
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

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                                if (j == sutun - 1)
                                {
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                    }
                                }
                            }
                        }
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                                        "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                                        "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                                        "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                                        "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");                        
                    }
                }
                // ----------------------MALİYET YAPILI---------------------------
                else if (yapi == 1)
                {
                    //------------------1 Adet Doğal Durum Satırı-----------------
                    if (dogaldurum == 0)
                    {
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
                                if (kotumser > kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                }
                                if (j == sutun - 1)
                                {
                                    if (kotumserdeger < kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
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
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger < esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    if (hurwicsdegeri < hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
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
                                if (pismanlik < pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    int l;
                                    l = i;
                                    for (int m = 1; m < satir; m++)
                                    {
                                        pismanliksutunfark = Convert.ToInt32(TextKutu[m, l].Text) - pismanliksutunenbuyuk;
                                        pismanliktablo[m, l] = pismanliksutunfark;
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

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                                if (j == sutun - 1)
                                {
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                    }
                                }
                            }
                        }
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");
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

                                if (kotumser > kotumserdeger)
                                {
                                    kotumserdeger = kotumser;
                                }
                                if (j == sutun - 1)
                                {
                                    if (kotumserdeger < kotumsersatirbuyuk)
                                    {
                                        kotumsersatirbuyuk = kotumserdeger;
                                        kotumseralternatif = TextKutu[i, 0].Text;
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
                                    esolasılıkdeger = Convert.ToDouble((esolasılıksatir) / (sutun - 1));
                                    if (esolasılıkdeger < esolasılıkdegerbuyuk)
                                    {
                                        esolasılıkdegerbuyuk = esolasılıkdeger;
                                        esolasilikalternatif = TextKutu[i, 0].Text;
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
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
                                if (hurwics > hurwicsbuyuk)
                                {
                                    hurwicsbuyuk = hurwics;
                                }
                                if (hurwics < hurwicskucuk)
                                {
                                    hurwicskucuk = hurwics;
                                }
                                if (j == sutun - 1)
                                {
                                    hurwicssatirbuyuk = hurwicsbuyuk;
                                    hurwicssatirkucuk = hurwicskucuk;
                                    alfaeksi = 1 - Convert.ToDouble(alfag.Text);
                                    alfaartı = Convert.ToDouble(alfag.Text);
                                    hurwicsdegeri = (alfaartı * hurwicssatirkucuk) + (hurwicssatirbuyuk * alfaeksi);
                                    if (hurwicsdegeri < hurwicssonuc)
                                    {
                                        hurwicssonuc = hurwicsdegeri;
                                        hurwicsalternatif = TextKutu[i, 0].Text;
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
                                if (pismanlik < pismanliksutunbuyuk)
                                {
                                    pismanliksutunbuyuk = pismanlik;
                                }
                                if (j == satir - 1)
                                {
                                    pismanliksutunenbuyuk = pismanliksutunbuyuk;
                                    int l;
                                    l = i;

                                    for (int m = 2; m < satir; m++)
                                    {
                                        pismanliksutunfark =  Convert.ToInt32(TextKutu[m, l].Text) - pismanliksutunenbuyuk;
                                        pismanliktablo[m, l] = pismanliksutunfark;
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

                                if (pismanliktablosudeğeri > pismanliktablosubuyuk)
                                {
                                    pismanliktablosubuyuk = pismanliktablosudeğeri;
                                }
                                if (j == sutun - 1)
                                {
                                    if (pismanliktablosubuyuk < pismanliktablosusatirkucuk)
                                    {
                                        pismanliktablosusatirkucuk = pismanliktablosubuyuk;
                                        pismanlikalternatif = TextKutu[i, 0].Text;
                                    }
                                }
                            }
                        }
                        MessageBox.Show("--> İyimserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + iyimseralternatif + " (" + iyimserdeger + ") " + "\n\n" +
                                                                "--> Kötümserlik Ölçütüne Göre Verilen Karar: \n     ➥ " + kotumseralternatif + " (" + kotumsersatirbuyuk + ") \n\n" +
                                                                "--> Eş Olasılık Ölçütüne Göre Verilen Karar: \n     ➥ " + esolasilikalternatif + " (" + esolasılıkdegerbuyuk + ") \n\n" +
                                                                "--> Hurwics Ölçütüne Göre Verilen Karar: \n     ➥ " + hurwicsalternatif + " (" + hurwicssonuc + ")\n\n" +
                                                                "--> Pişmanlık Ölçütüne Göre Verilen Karar: \n     ➥ " + pismanlikalternatif + " (" + pismanliktablosusatirkucuk + ")", "Sonuçlar");
                    }
                }
            }
        }
        private void tablosifirlaform_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    TextKutu[i, j].Text = "";
                }
            }
        }
        private void sayisifirlaform_Click(object sender, EventArgs e)
        {
            if (dogaldurumsatir.SelectedIndex == 0)
            {
                for (int i = 1; i < satir ; i++)
                {
                    for (int j = 1; j < sutun ; j++)
                    {
                        TextKutu[i, j].Text = "";
                    }
                }
            }
            else if (dogaldurumsatir.SelectedIndex == 1)
            {
                for (int i = 2; i < satir; i++)
                {
                    for (int j = 1; j < sutun; j++)
                    {
                        TextKutu[i, j].Text = "";
                    }
                }
            }
        }
        private void info_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Doğal durum adedi sayısal değerleri gireceğimiz sütunların adedini belirtir \n\n ","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void infodogalsatir_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
                            "Doğal durum satır adedimiz, \n\nProblemimizde ülke koşulları (iyi,aynı,kötü) ve güçlü/zayıf pazar payı gibi iki farklı doğal durum olursa 2 seçilir. \n\n" +
                            "Sadece kişisel / kurumsal yazılım gibi tek doğal durum varsa 1 seçilir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void geri_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }

        private void cikis_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
