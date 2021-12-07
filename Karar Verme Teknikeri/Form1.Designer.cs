
namespace Karar_Verme_Teknikeri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dogaldurumsatir = new System.Windows.Forms.ComboBox();
            this.yapitipi = new System.Windows.Forms.ComboBox();
            this.satirbilgi = new System.Windows.Forms.Label();
            this.satiradedi = new System.Windows.Forms.NumericUpDown();
            this.sutunadedi = new System.Windows.Forms.NumericUpDown();
            this.sutunbilgi = new System.Windows.Forms.Label();
            this.alfadegeri = new System.Windows.Forms.TextBox();
            this.yapibilgi = new System.Windows.Forms.Label();
            this.doğalsutunbilgi = new System.Windows.Forms.Label();
            this.alfadegeribilgi = new System.Windows.Forms.Label();
            this.İyimserbilgi = new System.Windows.Forms.Label();
            this.kotumserbilgi = new System.Windows.Forms.Label();
            this.esolasilikbilgi = new System.Windows.Forms.Label();
            this.hurwicsbilgi = new System.Windows.Forms.Label();
            this.pismanlikbilgi = new System.Windows.Forms.Label();
            this.tablobuton = new System.Windows.Forms.Button();
            this.hesapbuton = new System.Windows.Forms.Button();
            this.iyimserform = new System.Windows.Forms.Label();
            this.kotumserform = new System.Windows.Forms.Label();
            this.esolasilikform = new System.Windows.Forms.Label();
            this.hurwicsform = new System.Windows.Forms.Label();
            this.pismanlikform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.satiradedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutunadedi)).BeginInit();
            this.SuspendLayout();
            // 
            // dogaldurumsatir
            // 
            this.dogaldurumsatir.AutoCompleteCustomSource.AddRange(new string[] {
            "Maliyet Yapılı"});
            this.dogaldurumsatir.FormattingEnabled = true;
            this.dogaldurumsatir.Items.AddRange(new object[] {
            "1",
            "2"});
            this.dogaldurumsatir.Location = new System.Drawing.Point(232, 139);
            this.dogaldurumsatir.Name = "dogaldurumsatir";
            this.dogaldurumsatir.Size = new System.Drawing.Size(121, 21);
            this.dogaldurumsatir.TabIndex = 0;
            this.dogaldurumsatir.Text = "Seçiniz";
            this.dogaldurumsatir.SelectedIndexChanged += new System.EventHandler(this.dogaldurumsatir_SelectedIndexChanged);
            // 
            // yapitipi
            // 
            this.yapitipi.AutoCompleteCustomSource.AddRange(new string[] {
            "Getiri Yapılı"});
            this.yapitipi.FormattingEnabled = true;
            this.yapitipi.Items.AddRange(new object[] {
            "Getiri Yapılı",
            "Maliyet Yapılı"});
            this.yapitipi.Location = new System.Drawing.Point(232, 112);
            this.yapitipi.Name = "yapitipi";
            this.yapitipi.Size = new System.Drawing.Size(121, 21);
            this.yapitipi.TabIndex = 1;
            this.yapitipi.Tag = "";
            this.yapitipi.Text = "Seçiniz";
            this.yapitipi.SelectedIndexChanged += new System.EventHandler(this.yapitipi_SelectedIndexChanged);
            // 
            // satirbilgi
            // 
            this.satirbilgi.AutoSize = true;
            this.satirbilgi.Location = new System.Drawing.Point(43, 60);
            this.satirbilgi.Name = "satirbilgi";
            this.satirbilgi.Size = new System.Drawing.Size(97, 13);
            this.satirbilgi.TabIndex = 2;
            this.satirbilgi.Text = "Satır Adedini Giriniz";
            // 
            // satiradedi
            // 
            this.satiradedi.Location = new System.Drawing.Point(233, 60);
            this.satiradedi.Name = "satiradedi";
            this.satiradedi.Size = new System.Drawing.Size(120, 20);
            this.satiradedi.TabIndex = 3;
            this.satiradedi.ValueChanged += new System.EventHandler(this.satiradedi_ValueChanged);
            // 
            // sutunadedi
            // 
            this.sutunadedi.Location = new System.Drawing.Point(233, 86);
            this.sutunadedi.Name = "sutunadedi";
            this.sutunadedi.Size = new System.Drawing.Size(120, 20);
            this.sutunadedi.TabIndex = 4;
            this.sutunadedi.ValueChanged += new System.EventHandler(this.sutunadedi_ValueChanged);
            // 
            // sutunbilgi
            // 
            this.sutunbilgi.AutoSize = true;
            this.sutunbilgi.Location = new System.Drawing.Point(43, 93);
            this.sutunbilgi.Name = "sutunbilgi";
            this.sutunbilgi.Size = new System.Drawing.Size(104, 13);
            this.sutunbilgi.TabIndex = 5;
            this.sutunbilgi.Text = "Sütun Adedini Giriniz";
            // 
            // alfadegeri
            // 
            this.alfadegeri.Location = new System.Drawing.Point(233, 167);
            this.alfadegeri.Name = "alfadegeri";
            this.alfadegeri.Size = new System.Drawing.Size(100, 20);
            this.alfadegeri.TabIndex = 6;
            // 
            // yapibilgi
            // 
            this.yapibilgi.AutoSize = true;
            this.yapibilgi.Location = new System.Drawing.Point(43, 120);
            this.yapibilgi.Name = "yapibilgi";
            this.yapibilgi.Size = new System.Drawing.Size(102, 13);
            this.yapibilgi.TabIndex = 7;
            this.yapibilgi.Text = "Yapı Türünü Seçiniz";
            // 
            // doğalsutunbilgi
            // 
            this.doğalsutunbilgi.AutoSize = true;
            this.doğalsutunbilgi.Location = new System.Drawing.Point(43, 147);
            this.doğalsutunbilgi.Name = "doğalsutunbilgi";
            this.doğalsutunbilgi.Size = new System.Drawing.Size(168, 13);
            this.doğalsutunbilgi.TabIndex = 8;
            this.doğalsutunbilgi.Text = "Doğal Durum Satır Adedini Seçiniz";
            // 
            // alfadegeribilgi
            // 
            this.alfadegeribilgi.AutoSize = true;
            this.alfadegeribilgi.Location = new System.Drawing.Point(43, 174);
            this.alfadegeribilgi.Name = "alfadegeribilgi";
            this.alfadegeribilgi.Size = new System.Drawing.Size(98, 13);
            this.alfadegeribilgi.TabIndex = 9;
            this.alfadegeribilgi.Text = "Alfa Değerini Giriniz";
            // 
            // İyimserbilgi
            // 
            this.İyimserbilgi.AutoSize = true;
            this.İyimserbilgi.Location = new System.Drawing.Point(43, 338);
            this.İyimserbilgi.Name = "İyimserbilgi";
            this.İyimserbilgi.Size = new System.Drawing.Size(71, 13);
            this.İyimserbilgi.TabIndex = 10;
            this.İyimserbilgi.Text = "İyimser Değer";
            // 
            // kotumserbilgi
            // 
            this.kotumserbilgi.AutoSize = true;
            this.kotumserbilgi.Location = new System.Drawing.Point(140, 338);
            this.kotumserbilgi.Name = "kotumserbilgi";
            this.kotumserbilgi.Size = new System.Drawing.Size(83, 13);
            this.kotumserbilgi.TabIndex = 11;
            this.kotumserbilgi.Text = "Kötümser Değer";
            // 
            // esolasilikbilgi
            // 
            this.esolasilikbilgi.AutoSize = true;
            this.esolasilikbilgi.Location = new System.Drawing.Point(250, 338);
            this.esolasilikbilgi.Name = "esolasilikbilgi";
            this.esolasilikbilgi.Size = new System.Drawing.Size(55, 13);
            this.esolasilikbilgi.TabIndex = 12;
            this.esolasilikbilgi.Text = "Eş Olasılık";
            // 
            // hurwicsbilgi
            // 
            this.hurwicsbilgi.AutoSize = true;
            this.hurwicsbilgi.Location = new System.Drawing.Point(328, 338);
            this.hurwicsbilgi.Name = "hurwicsbilgi";
            this.hurwicsbilgi.Size = new System.Drawing.Size(45, 13);
            this.hurwicsbilgi.TabIndex = 13;
            this.hurwicsbilgi.Text = "Hurwics";
            // 
            // pismanlikbilgi
            // 
            this.pismanlikbilgi.AutoSize = true;
            this.pismanlikbilgi.Location = new System.Drawing.Point(399, 338);
            this.pismanlikbilgi.Name = "pismanlikbilgi";
            this.pismanlikbilgi.Size = new System.Drawing.Size(85, 13);
            this.pismanlikbilgi.TabIndex = 14;
            this.pismanlikbilgi.Text = "Pişmanlık Ölçütü";
            // 
            // tablobuton
            // 
            this.tablobuton.Location = new System.Drawing.Point(369, 204);
            this.tablobuton.Name = "tablobuton";
            this.tablobuton.Size = new System.Drawing.Size(97, 40);
            this.tablobuton.TabIndex = 15;
            this.tablobuton.Text = "Tablo Oluştur";
            this.tablobuton.UseVisualStyleBackColor = true;
            this.tablobuton.Click += new System.EventHandler(this.tablobuton_Click);
            // 
            // hesapbuton
            // 
            this.hesapbuton.Location = new System.Drawing.Point(674, 384);
            this.hesapbuton.Name = "hesapbuton";
            this.hesapbuton.Size = new System.Drawing.Size(97, 40);
            this.hesapbuton.TabIndex = 16;
            this.hesapbuton.Text = "Hesapla";
            this.hesapbuton.UseVisualStyleBackColor = true;
            this.hesapbuton.Click += new System.EventHandler(this.hesapbuton_Click);
            // 
            // iyimserform
            // 
            this.iyimserform.AutoSize = true;
            this.iyimserform.Location = new System.Drawing.Point(46, 384);
            this.iyimserform.Name = "iyimserform";
            this.iyimserform.Size = new System.Drawing.Size(0, 13);
            this.iyimserform.TabIndex = 17;
            // 
            // kotumserform
            // 
            this.kotumserform.AutoSize = true;
            this.kotumserform.Location = new System.Drawing.Point(143, 384);
            this.kotumserform.Name = "kotumserform";
            this.kotumserform.Size = new System.Drawing.Size(0, 13);
            this.kotumserform.TabIndex = 18;
            // 
            // esolasilikform
            // 
            this.esolasilikform.AutoSize = true;
            this.esolasilikform.Location = new System.Drawing.Point(253, 384);
            this.esolasilikform.Name = "esolasilikform";
            this.esolasilikform.Size = new System.Drawing.Size(0, 13);
            this.esolasilikform.TabIndex = 19;
            // 
            // hurwicsform
            // 
            this.hurwicsform.AutoSize = true;
            this.hurwicsform.Location = new System.Drawing.Point(331, 384);
            this.hurwicsform.Name = "hurwicsform";
            this.hurwicsform.Size = new System.Drawing.Size(0, 13);
            this.hurwicsform.TabIndex = 20;
            // 
            // pismanlikform
            // 
            this.pismanlikform.AutoSize = true;
            this.pismanlikform.Location = new System.Drawing.Point(402, 384);
            this.pismanlikform.Name = "pismanlikform";
            this.pismanlikform.Size = new System.Drawing.Size(0, 13);
            this.pismanlikform.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pismanlikform);
            this.Controls.Add(this.hurwicsform);
            this.Controls.Add(this.esolasilikform);
            this.Controls.Add(this.kotumserform);
            this.Controls.Add(this.iyimserform);
            this.Controls.Add(this.hesapbuton);
            this.Controls.Add(this.tablobuton);
            this.Controls.Add(this.pismanlikbilgi);
            this.Controls.Add(this.hurwicsbilgi);
            this.Controls.Add(this.esolasilikbilgi);
            this.Controls.Add(this.kotumserbilgi);
            this.Controls.Add(this.İyimserbilgi);
            this.Controls.Add(this.alfadegeribilgi);
            this.Controls.Add(this.doğalsutunbilgi);
            this.Controls.Add(this.yapibilgi);
            this.Controls.Add(this.alfadegeri);
            this.Controls.Add(this.sutunbilgi);
            this.Controls.Add(this.sutunadedi);
            this.Controls.Add(this.satiradedi);
            this.Controls.Add(this.satirbilgi);
            this.Controls.Add(this.yapitipi);
            this.Controls.Add(this.dogaldurumsatir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.satiradedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutunadedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dogaldurumsatir;
        private System.Windows.Forms.ComboBox yapitipi;
        private System.Windows.Forms.Label satirbilgi;
        private System.Windows.Forms.NumericUpDown satiradedi;
        private System.Windows.Forms.NumericUpDown sutunadedi;
        private System.Windows.Forms.Label sutunbilgi;
        private System.Windows.Forms.TextBox alfadegeri;
        private System.Windows.Forms.Label yapibilgi;
        private System.Windows.Forms.Label doğalsutunbilgi;
        private System.Windows.Forms.Label alfadegeribilgi;
        private System.Windows.Forms.Label İyimserbilgi;
        private System.Windows.Forms.Label kotumserbilgi;
        private System.Windows.Forms.Label esolasilikbilgi;
        private System.Windows.Forms.Label hurwicsbilgi;
        private System.Windows.Forms.Label pismanlikbilgi;
        private System.Windows.Forms.Button tablobuton;
        private System.Windows.Forms.Button hesapbuton;
        private System.Windows.Forms.Label iyimserform;
        private System.Windows.Forms.Label kotumserform;
        private System.Windows.Forms.Label esolasilikform;
        private System.Windows.Forms.Label hurwicsform;
        private System.Windows.Forms.Label pismanlikform;
    }
}

