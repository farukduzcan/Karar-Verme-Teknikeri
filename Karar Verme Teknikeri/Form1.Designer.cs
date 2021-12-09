
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tablobuton = new System.Windows.Forms.Button();
            this.hesapbuton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablosifirlaform = new System.Windows.Forms.Button();
            this.sayisifirlaform = new System.Windows.Forms.Button();
            this.alternatifbilgiform = new System.Windows.Forms.Label();
            this.alternatifler2 = new System.Windows.Forms.Label();
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
            this.dogaldurumsatir.Location = new System.Drawing.Point(369, 210);
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
            this.yapitipi.Location = new System.Drawing.Point(369, 183);
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
            this.satirbilgi.Location = new System.Drawing.Point(180, 131);
            this.satirbilgi.Name = "satirbilgi";
            this.satirbilgi.Size = new System.Drawing.Size(97, 13);
            this.satirbilgi.TabIndex = 2;
            this.satirbilgi.Text = "Satır Adedini Giriniz";
            // 
            // satiradedi
            // 
            this.satiradedi.Location = new System.Drawing.Point(370, 131);
            this.satiradedi.Name = "satiradedi";
            this.satiradedi.Size = new System.Drawing.Size(120, 20);
            this.satiradedi.TabIndex = 3;
            this.satiradedi.ValueChanged += new System.EventHandler(this.satiradedi_ValueChanged);
            // 
            // sutunadedi
            // 
            this.sutunadedi.Location = new System.Drawing.Point(370, 157);
            this.sutunadedi.Name = "sutunadedi";
            this.sutunadedi.Size = new System.Drawing.Size(120, 20);
            this.sutunadedi.TabIndex = 4;
            this.sutunadedi.ValueChanged += new System.EventHandler(this.sutunadedi_ValueChanged);
            // 
            // sutunbilgi
            // 
            this.sutunbilgi.AutoSize = true;
            this.sutunbilgi.Location = new System.Drawing.Point(180, 164);
            this.sutunbilgi.Name = "sutunbilgi";
            this.sutunbilgi.Size = new System.Drawing.Size(104, 13);
            this.sutunbilgi.TabIndex = 5;
            this.sutunbilgi.Text = "Sütun Adedini Giriniz";
            // 
            // alfadegeri
            // 
            this.alfadegeri.Location = new System.Drawing.Point(370, 238);
            this.alfadegeri.Name = "alfadegeri";
            this.alfadegeri.Size = new System.Drawing.Size(100, 20);
            this.alfadegeri.TabIndex = 6;
            // 
            // yapibilgi
            // 
            this.yapibilgi.AutoSize = true;
            this.yapibilgi.Location = new System.Drawing.Point(180, 191);
            this.yapibilgi.Name = "yapibilgi";
            this.yapibilgi.Size = new System.Drawing.Size(102, 13);
            this.yapibilgi.TabIndex = 7;
            this.yapibilgi.Text = "Yapı Türünü Seçiniz";
            // 
            // doğalsutunbilgi
            // 
            this.doğalsutunbilgi.AutoSize = true;
            this.doğalsutunbilgi.Location = new System.Drawing.Point(180, 218);
            this.doğalsutunbilgi.Name = "doğalsutunbilgi";
            this.doğalsutunbilgi.Size = new System.Drawing.Size(168, 13);
            this.doğalsutunbilgi.TabIndex = 8;
            this.doğalsutunbilgi.Text = "Doğal Durum Satır Adedini Seçiniz";
            // 
            // alfadegeribilgi
            // 
            this.alfadegeribilgi.AutoSize = true;
            this.alfadegeribilgi.Location = new System.Drawing.Point(180, 245);
            this.alfadegeribilgi.Name = "alfadegeribilgi";
            this.alfadegeribilgi.Size = new System.Drawing.Size(98, 13);
            this.alfadegeribilgi.TabIndex = 9;
            this.alfadegeribilgi.Text = "Alfa Değerini Giriniz";
            // 
            // tablobuton
            // 
            this.tablobuton.Location = new System.Drawing.Point(506, 275);
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
            this.hesapbuton.Visible = false;
            this.hesapbuton.Click += new System.EventHandler(this.hesapbuton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(150, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 225);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başlangıç";
            // 
            // tablosifirlaform
            // 
            this.tablosifirlaform.Location = new System.Drawing.Point(72, 384);
            this.tablosifirlaform.Name = "tablosifirlaform";
            this.tablosifirlaform.Size = new System.Drawing.Size(95, 40);
            this.tablosifirlaform.TabIndex = 19;
            this.tablosifirlaform.Text = "Tabloyu Sıfırla";
            this.tablosifirlaform.UseVisualStyleBackColor = true;
            this.tablosifirlaform.Visible = false;
            this.tablosifirlaform.Click += new System.EventHandler(this.tablosifirlaform_Click);
            // 
            // sayisifirlaform
            // 
            this.sayisifirlaform.Location = new System.Drawing.Point(189, 384);
            this.sayisifirlaform.Name = "sayisifirlaform";
            this.sayisifirlaform.Size = new System.Drawing.Size(95, 40);
            this.sayisifirlaform.TabIndex = 20;
            this.sayisifirlaform.Text = "Sayıları Sıfırla";
            this.sayisifirlaform.UseVisualStyleBackColor = true;
            this.sayisifirlaform.Visible = false;
            this.sayisifirlaform.Click += new System.EventHandler(this.sayisifirlaform_Click);
            // 
            // alternatifbilgiform
            // 
            this.alternatifbilgiform.AutoSize = true;
            this.alternatifbilgiform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternatifbilgiform.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.alternatifbilgiform.Location = new System.Drawing.Point(101, 137);
            this.alternatifbilgiform.Name = "alternatifbilgiform";
            this.alternatifbilgiform.Size = new System.Drawing.Size(80, 18);
            this.alternatifbilgiform.TabIndex = 22;
            this.alternatifbilgiform.Text = "Alternatifler";
            this.alternatifbilgiform.Visible = false;
            // 
            // alternatifler2
            // 
            this.alternatifler2.AutoSize = true;
            this.alternatifler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternatifler2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.alternatifler2.Location = new System.Drawing.Point(101, 75);
            this.alternatifler2.Name = "alternatifler2";
            this.alternatifler2.Size = new System.Drawing.Size(84, 18);
            this.alternatifler2.TabIndex = 23;
            this.alternatifler2.Text = "Alternatifler ";
            this.alternatifler2.Visible = false;
            this.alternatifler2.Click += new System.EventHandler(this.alternatifler2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alternatifler2);
            this.Controls.Add(this.alternatifbilgiform);
            this.Controls.Add(this.sayisifirlaform);
            this.Controls.Add(this.tablosifirlaform);
            this.Controls.Add(this.hesapbuton);
            this.Controls.Add(this.tablobuton);
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
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Belirsizlik Altında Karar Verme Teknikleri Hesaplama [Ömer Faruk Duzcan -- Şeyma " +
    "Nur Karadağ -- Aydın Bayramov]";
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
        private System.Windows.Forms.Button tablobuton;
        private System.Windows.Forms.Button hesapbuton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tablosifirlaform;
        private System.Windows.Forms.Button sayisifirlaform;
        private System.Windows.Forms.Label alternatifbilgiform;
        private System.Windows.Forms.Label alternatifler2;
    }
}

