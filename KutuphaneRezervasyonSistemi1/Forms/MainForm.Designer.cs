namespace KutuphaneRezervasyonSistemi1.Forms
{
    partial class MainForm
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
            this.IblOgrenci = new System.Windows.Forms.Label();
            this.IblKitap = new System.Windows.Forms.Label();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.btnOrnekVeri = new System.Windows.Forms.Button();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lstLoglar = new System.Windows.Forms.ListBox();
            this.btnLogGoster = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.lstAramaSonuc = new System.Windows.Forms.ListBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.lstListeleme = new System.Windows.Forms.ListBox();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.lstIstatistik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IblOgrenci
            // 
            this.IblOgrenci.AutoSize = true;
            this.IblOgrenci.Location = new System.Drawing.Point(177, 27);
            this.IblOgrenci.Name = "IblOgrenci";
            this.IblOgrenci.Size = new System.Drawing.Size(66, 13);
            this.IblOgrenci.TabIndex = 0;
            this.IblOgrenci.Text = "Öğrenci Seç";
            // 
            // IblKitap
            // 
            this.IblKitap.AutoSize = true;
            this.IblKitap.Location = new System.Drawing.Point(177, 94);
            this.IblKitap.Name = "IblKitap";
            this.IblKitap.Size = new System.Drawing.Size(53, 13);
            this.IblKitap.TabIndex = 1;
            this.IblKitap.Text = "Kitap Seç";
            this.IblKitap.Click += new System.EventHandler(this.IblKitap_Click);
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(180, 52);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(155, 21);
            this.cmbOgrenci.TabIndex = 2;
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(180, 119);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(155, 21);
            this.cmbKitap.TabIndex = 3;
            // 
            // btnOrnekVeri
            // 
            this.btnOrnekVeri.Location = new System.Drawing.Point(180, 238);
            this.btnOrnekVeri.Name = "btnOrnekVeri";
            this.btnOrnekVeri.Size = new System.Drawing.Size(155, 23);
            this.btnOrnekVeri.TabIndex = 4;
            this.btnOrnekVeri.Text = "Örnek Veri Yükle";
            this.btnOrnekVeri.UseVisualStyleBackColor = true;
            this.btnOrnekVeri.Click += new System.EventHandler(this.btnOrnekVeri_Click);
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(180, 267);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(155, 23);
            this.btnOduncAl.TabIndex = 5;
            this.btnOduncAl.Text = "Ödünç Al";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(180, 296);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(155, 23);
            this.btnIadeEt.TabIndex = 6;
            this.btnIadeEt.Text = "İade Et";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(781, 458);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(64, 13);
            this.lblLog.TabIndex = 7;
            this.lblLog.Text = "Log Kayıtları";
            // 
            // lstLoglar
            // 
            this.lstLoglar.FormattingEnabled = true;
            this.lstLoglar.Location = new System.Drawing.Point(592, 498);
            this.lstLoglar.Name = "lstLoglar";
            this.lstLoglar.Size = new System.Drawing.Size(442, 303);
            this.lstLoglar.TabIndex = 8;
            this.lstLoglar.SelectedIndexChanged += new System.EventHandler(this.lstLoglar_SelectedIndexChanged);
            // 
            // btnLogGoster
            // 
            this.btnLogGoster.Location = new System.Drawing.Point(757, 819);
            this.btnLogGoster.Name = "btnLogGoster";
            this.btnLogGoster.Size = new System.Drawing.Size(155, 22);
            this.btnLogGoster.TabIndex = 9;
            this.btnLogGoster.Text = "Logları Göster";
            this.btnLogGoster.UseVisualStyleBackColor = true;
            this.btnLogGoster.Click += new System.EventHandler(this.btnLogGoster_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(1294, 30);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAra.TabIndex = 10;
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Location = new System.Drawing.Point(1294, 453);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(155, 23);
            this.btnKitapAra.TabIndex = 11;
            this.btnKitapAra.Text = "Kitap Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // lstAramaSonuc
            // 
            this.lstAramaSonuc.FormattingEnabled = true;
            this.lstAramaSonuc.Location = new System.Drawing.Point(1130, 94);
            this.lstAramaSonuc.Name = "lstAramaSonuc";
            this.lstAramaSonuc.Size = new System.Drawing.Size(442, 303);
            this.lstAramaSonuc.TabIndex = 12;
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(180, 419);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(155, 23);
            this.btnKitapListele.TabIndex = 13;
            this.btnKitapListele.Text = "Kitapları Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(180, 448);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(155, 23);
            this.btnOgrenciListele.TabIndex = 14;
            this.btnOgrenciListele.Text = "Öğrencileri Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // lstListeleme
            // 
            this.lstListeleme.FormattingEnabled = true;
            this.lstListeleme.Location = new System.Drawing.Point(37, 498);
            this.lstListeleme.Name = "lstListeleme";
            this.lstListeleme.Size = new System.Drawing.Size(442, 303);
            this.lstListeleme.TabIndex = 15;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.Location = new System.Drawing.Point(738, 28);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(155, 23);
            this.btnIstatistik.TabIndex = 16;
            this.btnIstatistik.Text = "En Çok Ödünç Alınanlar";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // lstIstatistik
            // 
            this.lstIstatistik.FormattingEnabled = true;
            this.lstIstatistik.Location = new System.Drawing.Point(592, 94);
            this.lstIstatistik.Name = "lstIstatistik";
            this.lstIstatistik.Size = new System.Drawing.Size(442, 303);
            this.lstIstatistik.TabIndex = 17;
            this.lstIstatistik.SelectedIndexChanged += new System.EventHandler(this.lstIstatistik_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 987);
            this.Controls.Add(this.lstIstatistik);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.lstListeleme);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.lstAramaSonuc);
            this.Controls.Add(this.btnKitapAra);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.btnLogGoster);
            this.Controls.Add(this.lstLoglar);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnIadeEt);
            this.Controls.Add(this.btnOduncAl);
            this.Controls.Add(this.btnOrnekVeri);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.IblKitap);
            this.Controls.Add(this.IblOgrenci);
            this.Name = "MainForm";
            this.Text = "Kütüphane Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblOgrenci;
        private System.Windows.Forms.Label IblKitap;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Button btnOrnekVeri;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.Button btnIadeEt;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox lstLoglar;
        private System.Windows.Forms.Button btnLogGoster;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.ListBox lstAramaSonuc;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.ListBox lstListeleme;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.ListBox lstIstatistik;
    }
}

