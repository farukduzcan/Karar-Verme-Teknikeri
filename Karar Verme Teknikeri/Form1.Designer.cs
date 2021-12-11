
namespace Karar_Verme_Teknikeri
{
    partial class anaform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.dogaldurumsatir = new System.Windows.Forms.ComboBox();
            this.yapitipi = new System.Windows.Forms.ComboBox();
            this.satirbilgi = new System.Windows.Forms.Label();
            this.satiradedi = new System.Windows.Forms.NumericUpDown();
            this.sutunadedi = new System.Windows.Forms.NumericUpDown();
            this.sutunbilgi = new System.Windows.Forms.Label();
            this.alfag = new System.Windows.Forms.TextBox();
            this.yapibilgi = new System.Windows.Forms.Label();
            this.doğalsutunbilgi = new System.Windows.Forms.Label();
            this.alfadegeribilgi = new System.Windows.Forms.Label();
            this.tablobuton = new System.Windows.Forms.Button();
            this.hesapbuton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infodogalsatir = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.tablosifirlaform = new System.Windows.Forms.Button();
            this.sayisifirlaform = new System.Windows.Forms.Button();
            this.alternatifbilgiform = new System.Windows.Forms.Label();
            this.alternatifler2 = new System.Windows.Forms.Label();
            this.dogaldurumbilgiform = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tusgrubu = new System.Windows.Forms.GroupBox();
            this.cikis = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.satiradedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutunadedi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tusgrubu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dogaldurumsatir
            // 
            this.dogaldurumsatir.AutoCompleteCustomSource.AddRange(new string[] {
            "Maliyet Yapılı"});
            this.dogaldurumsatir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dogaldurumsatir.FormattingEnabled = true;
            this.dogaldurumsatir.Items.AddRange(new object[] {
            "1",
            "2"});
            this.dogaldurumsatir.Location = new System.Drawing.Point(220, 106);
            this.dogaldurumsatir.Name = "dogaldurumsatir";
            this.dogaldurumsatir.Size = new System.Drawing.Size(121, 21);
            this.dogaldurumsatir.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dogaldurumsatir, resources.GetString("dogaldurumsatir.ToolTip"));
            this.dogaldurumsatir.SelectedIndexChanged += new System.EventHandler(this.dogaldurumsatir_SelectedIndexChanged);
            // 
            // yapitipi
            // 
            this.yapitipi.AutoCompleteCustomSource.AddRange(new string[] {
            "Getiri Yapılı"});
            this.yapitipi.BackColor = System.Drawing.SystemColors.Window;
            this.yapitipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yapitipi.FormattingEnabled = true;
            this.yapitipi.Items.AddRange(new object[] {
            "Getiri Yapılı",
            "Maliyet Yapılı"});
            this.yapitipi.Location = new System.Drawing.Point(369, 183);
            this.yapitipi.Name = "yapitipi";
            this.yapitipi.Size = new System.Drawing.Size(121, 21);
            this.yapitipi.TabIndex = 3;
            this.yapitipi.Tag = "";
            this.yapitipi.SelectedIndexChanged += new System.EventHandler(this.yapitipi_SelectedIndexChanged);
            // 
            // satirbilgi
            // 
            this.satirbilgi.AutoSize = true;
            this.satirbilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.satirbilgi.Location = new System.Drawing.Point(180, 131);
            this.satirbilgi.Name = "satirbilgi";
            this.satirbilgi.Size = new System.Drawing.Size(117, 13);
            this.satirbilgi.TabIndex = 10;
            this.satirbilgi.Text = "Alternatif Adedini Giriniz";
            // 
            // satiradedi
            // 
            this.satiradedi.Location = new System.Drawing.Point(370, 131);
            this.satiradedi.Name = "satiradedi";
            this.satiradedi.Size = new System.Drawing.Size(120, 20);
            this.satiradedi.TabIndex = 1;
            this.satiradedi.ValueChanged += new System.EventHandler(this.satiradedi_ValueChanged);
            // 
            // sutunadedi
            // 
            this.sutunadedi.Location = new System.Drawing.Point(370, 157);
            this.sutunadedi.Name = "sutunadedi";
            this.sutunadedi.Size = new System.Drawing.Size(120, 20);
            this.sutunadedi.TabIndex = 2;
            this.toolTip1.SetToolTip(this.sutunadedi, "Doğal durum adedi alternatifler sütunu haricinde ki sütunların sayısıdır.");
            this.sutunadedi.ValueChanged += new System.EventHandler(this.sutunadedi_ValueChanged);
            // 
            // sutunbilgi
            // 
            this.sutunbilgi.AutoSize = true;
            this.sutunbilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sutunbilgi.Location = new System.Drawing.Point(180, 164);
            this.sutunbilgi.Name = "sutunbilgi";
            this.sutunbilgi.Size = new System.Drawing.Size(178, 13);
            this.sutunbilgi.TabIndex = 11;
            this.sutunbilgi.Text = "Doğal Durum (Sütun)  Adedini Giriniz";
            // 
            // alfag
            // 
            this.alfag.BackColor = System.Drawing.SystemColors.Window;
            this.alfag.Location = new System.Drawing.Point(220, 137);
            this.alfag.Name = "alfag";
            this.alfag.Size = new System.Drawing.Size(100, 20);
            this.alfag.TabIndex = 5;
            this.alfag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alfadegeri_KeyPress);
            // 
            // yapibilgi
            // 
            this.yapibilgi.AutoSize = true;
            this.yapibilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yapibilgi.Location = new System.Drawing.Point(180, 191);
            this.yapibilgi.Name = "yapibilgi";
            this.yapibilgi.Size = new System.Drawing.Size(102, 13);
            this.yapibilgi.TabIndex = 12;
            this.yapibilgi.Text = "Yapı Türünü Seçiniz";
            // 
            // doğalsutunbilgi
            // 
            this.doğalsutunbilgi.AutoSize = true;
            this.doğalsutunbilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.doğalsutunbilgi.Location = new System.Drawing.Point(180, 218);
            this.doğalsutunbilgi.Name = "doğalsutunbilgi";
            this.doğalsutunbilgi.Size = new System.Drawing.Size(168, 13);
            this.doğalsutunbilgi.TabIndex = 13;
            this.doğalsutunbilgi.Text = "Doğal Durum Satır Adedini Seçiniz";
            // 
            // alfadegeribilgi
            // 
            this.alfadegeribilgi.AutoSize = true;
            this.alfadegeribilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.alfadegeribilgi.Location = new System.Drawing.Point(180, 245);
            this.alfadegeribilgi.Name = "alfadegeribilgi";
            this.alfadegeribilgi.Size = new System.Drawing.Size(98, 13);
            this.alfadegeribilgi.TabIndex = 14;
            this.alfadegeribilgi.Text = "Alfa Değerini Giriniz";
            // 
            // tablobuton
            // 
            this.tablobuton.Location = new System.Drawing.Point(506, 275);
            this.tablobuton.Name = "tablobuton";
            this.tablobuton.Size = new System.Drawing.Size(97, 40);
            this.tablobuton.TabIndex = 6;
            this.tablobuton.Text = "Tablo Oluştur";
            this.tablobuton.UseVisualStyleBackColor = true;
            this.tablobuton.Click += new System.EventHandler(this.tablobuton_Click);
            // 
            // hesapbuton
            // 
            this.hesapbuton.Location = new System.Drawing.Point(673, 12);
            this.hesapbuton.Name = "hesapbuton";
            this.hesapbuton.Size = new System.Drawing.Size(97, 40);
            this.hesapbuton.TabIndex = 7;
            this.hesapbuton.Text = "Hesapla";
            this.hesapbuton.UseVisualStyleBackColor = true;
            this.hesapbuton.Visible = false;
            this.hesapbuton.Click += new System.EventHandler(this.hesapbuton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.infodogalsatir);
            this.groupBox1.Controls.Add(this.info);
            this.groupBox1.Controls.Add(this.dogaldurumsatir);
            this.groupBox1.Controls.Add(this.alfag);
            this.groupBox1.Location = new System.Drawing.Point(150, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 225);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // infodogalsatir
            // 
            this.infodogalsatir.AutoSize = true;
            this.infodogalsatir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infodogalsatir.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infodogalsatir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.infodogalsatir.Location = new System.Drawing.Point(347, 103);
            this.infodogalsatir.Name = "infodogalsatir";
            this.infodogalsatir.Size = new System.Drawing.Size(24, 27);
            this.infodogalsatir.TabIndex = 6;
            this.infodogalsatir.Text = "İ";
            this.infodogalsatir.Click += new System.EventHandler(this.infodogalsatir_Click);
            this.infodogalsatir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.infodogalsatir_MouseClick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.info.Location = new System.Drawing.Point(346, 49);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(24, 27);
            this.info.TabIndex = 5;
            this.info.Text = "İ";
            this.info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.info_MouseClick);
            // 
            // tablosifirlaform
            // 
            this.tablosifirlaform.Location = new System.Drawing.Point(323, 12);
            this.tablosifirlaform.Name = "tablosifirlaform";
            this.tablosifirlaform.Size = new System.Drawing.Size(95, 40);
            this.tablosifirlaform.TabIndex = 8;
            this.tablosifirlaform.Text = "Tabloyu Sıfırla";
            this.tablosifirlaform.UseVisualStyleBackColor = true;
            this.tablosifirlaform.Visible = false;
            this.tablosifirlaform.Click += new System.EventHandler(this.tablosifirlaform_Click);
            // 
            // sayisifirlaform
            // 
            this.sayisifirlaform.Location = new System.Drawing.Point(437, 12);
            this.sayisifirlaform.Name = "sayisifirlaform";
            this.sayisifirlaform.Size = new System.Drawing.Size(95, 40);
            this.sayisifirlaform.TabIndex = 9;
            this.sayisifirlaform.Text = "Sayıları Sıfırla";
            this.sayisifirlaform.UseVisualStyleBackColor = true;
            this.sayisifirlaform.Visible = false;
            this.sayisifirlaform.Click += new System.EventHandler(this.sayisifirlaform_Click);
            // 
            // alternatifbilgiform
            // 
            this.alternatifbilgiform.AutoSize = true;
            this.alternatifbilgiform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternatifbilgiform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alternatifbilgiform.Location = new System.Drawing.Point(90, 144);
            this.alternatifbilgiform.Name = "alternatifbilgiform";
            this.alternatifbilgiform.Size = new System.Drawing.Size(93, 18);
            this.alternatifbilgiform.TabIndex = 16;
            this.alternatifbilgiform.Text = "Alternatifler";
            this.alternatifbilgiform.Visible = false;
            // 
            // alternatifler2
            // 
            this.alternatifler2.AutoSize = true;
            this.alternatifler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternatifler2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alternatifler2.Location = new System.Drawing.Point(101, 75);
            this.alternatifler2.Name = "alternatifler2";
            this.alternatifler2.Size = new System.Drawing.Size(98, 18);
            this.alternatifler2.TabIndex = 15;
            this.alternatifler2.Text = "Alternatifler ";
            this.alternatifler2.Visible = false;
            this.alternatifler2.Click += new System.EventHandler(this.alternatifler2_Click);
            // 
            // dogaldurumbilgiform
            // 
            this.dogaldurumbilgiform.AutoSize = true;
            this.dogaldurumbilgiform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogaldurumbilgiform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dogaldurumbilgiform.Location = new System.Drawing.Point(331, 21);
            this.dogaldurumbilgiform.Name = "dogaldurumbilgiform";
            this.dogaldurumbilgiform.Size = new System.Drawing.Size(139, 20);
            this.dogaldurumbilgiform.TabIndex = 18;
            this.dogaldurumbilgiform.Text = "Doğal Durumlar ";
            this.dogaldurumbilgiform.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "Bilgilendirme";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Dikkat!";
            // 
            // tusgrubu
            // 
            this.tusgrubu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tusgrubu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tusgrubu.Controls.Add(this.cikis);
            this.tusgrubu.Controls.Add(this.geri);
            this.tusgrubu.Controls.Add(this.sayisifirlaform);
            this.tusgrubu.Controls.Add(this.tablosifirlaform);
            this.tusgrubu.Controls.Add(this.hesapbuton);
            this.tusgrubu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tusgrubu.Location = new System.Drawing.Point(12, 380);
            this.tusgrubu.Name = "tusgrubu";
            this.tusgrubu.Size = new System.Drawing.Size(776, 58);
            this.tusgrubu.TabIndex = 19;
            this.tusgrubu.TabStop = false;
            this.tusgrubu.Visible = false;
            this.tusgrubu.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(107, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(95, 40);
            this.cikis.TabIndex = 11;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Visible = false;
            this.cikis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cikis_MouseClick);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(6, 12);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(95, 40);
            this.geri.TabIndex = 10;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Visible = false;
            this.geri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.geri_MouseClick);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dogaldurumbilgiform);
            this.Controls.Add(this.alternatifler2);
            this.Controls.Add(this.alternatifbilgiform);
            this.Controls.Add(this.tablobuton);
            this.Controls.Add(this.alfadegeribilgi);
            this.Controls.Add(this.doğalsutunbilgi);
            this.Controls.Add(this.yapibilgi);
            this.Controls.Add(this.sutunbilgi);
            this.Controls.Add(this.sutunadedi);
            this.Controls.Add(this.satiradedi);
            this.Controls.Add(this.satirbilgi);
            this.Controls.Add(this.yapitipi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tusgrubu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaform";
            this.Text = "Belirsizlik Altında Karar Verme Teknikleri Hesaplama [Ömer Faruk Duzcan -- Şeyma " +
    "Nur Karadağ -- Aydın Bayramov]";
            ((System.ComponentModel.ISupportInitialize)(this.satiradedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutunadedi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tusgrubu.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox alfag;
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
        private System.Windows.Forms.Label dogaldurumbilgiform;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox tusgrubu;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label infodogalsatir;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button cikis;
    }
}

