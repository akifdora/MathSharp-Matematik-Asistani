
namespace MathSharp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basitMatematikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dörtİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asalSayıListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kombinasyonHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permütasyonHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üslüSayıHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karekökHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eBOBEKOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplayıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleEndeksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlGirilenSayiyaKadarCarpma1 = new MathSharp.UserControlGirilenSayiyaKadarCarpma();
            this.userControlUsluSayi1 = new MathSharp.UserControlUsluSayi();
            this.userControlPermutasyonHesaplama1 = new MathSharp.UserControlPermutasyonHesaplama();
            this.userControlModAlma1 = new MathSharp.UserControlDetayliOrtalamaHesaplama();
            this.userControlEbobEkokHesaplama1 = new MathSharp.UserControlEbobEkokHesaplama();
            this.userControlKarekokHesaplama1 = new MathSharp.UserControlKarekokHesaplama();
            this.userControlVucutKitleEndeksi1 = new MathSharp.UserControlVucutKitleEndeksi();
            this.userControlKombinasyonHesaplama1 = new MathSharp.UserControlKombinasyonHesaplama();
            this.userControlDortIslem1 = new MathSharp.UserControlDortIslem();
            this.userControlDikucgenCevreAlan1 = new MathSharp.UserControlDikucgenCevreAlan();
            this.userControlAsalSayiListeleme1 = new MathSharp.UserControlAsalSayiListeleme();
            this.userControlDikdortgenCevreAlan1 = new MathSharp.UserControlDikdortgenCevreAlan();
            this.userControlAnasayfa1 = new MathSharp.UserControlAnasayfa();
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.basitMatematikToolStripMenuItem,
            this.geometriToolStripMenuItem,
            this.hesaplayıcılarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anasayfaToolStripMenuItem.Image")));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // basitMatematikToolStripMenuItem
            // 
            this.basitMatematikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dörtİşlemToolStripMenuItem,
            this.asalSayıListelemeToolStripMenuItem,
            this.kombinasyonHesaplamaToolStripMenuItem,
            this.permütasyonHesaplamaToolStripMenuItem,
            this.üslüSayıHesaplamaToolStripMenuItem,
            this.karekökHesaplamaToolStripMenuItem,
            this.eBOBEKOKToolStripMenuItem,
            this.modAlmaToolStripMenuItem,
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem});
            this.basitMatematikToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("basitMatematikToolStripMenuItem.Image")));
            this.basitMatematikToolStripMenuItem.Name = "basitMatematikToolStripMenuItem";
            this.basitMatematikToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.basitMatematikToolStripMenuItem.Text = "Matematik";
            // 
            // dörtİşlemToolStripMenuItem
            // 
            this.dörtİşlemToolStripMenuItem.Name = "dörtİşlemToolStripMenuItem";
            this.dörtİşlemToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dörtİşlemToolStripMenuItem.Text = "Dört İşlem";
            this.dörtİşlemToolStripMenuItem.Click += new System.EventHandler(this.dörtİşlemToolStripMenuItem_Click);
            // 
            // asalSayıListelemeToolStripMenuItem
            // 
            this.asalSayıListelemeToolStripMenuItem.Name = "asalSayıListelemeToolStripMenuItem";
            this.asalSayıListelemeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.asalSayıListelemeToolStripMenuItem.Text = "Asal Sayı Listeleme";
            this.asalSayıListelemeToolStripMenuItem.Click += new System.EventHandler(this.asalSayıListelemeToolStripMenuItem_Click);
            // 
            // kombinasyonHesaplamaToolStripMenuItem
            // 
            this.kombinasyonHesaplamaToolStripMenuItem.Name = "kombinasyonHesaplamaToolStripMenuItem";
            this.kombinasyonHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.kombinasyonHesaplamaToolStripMenuItem.Text = "Kombinasyon Hesaplama";
            this.kombinasyonHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.kombinasyonHesaplamaToolStripMenuItem_Click);
            // 
            // permütasyonHesaplamaToolStripMenuItem
            // 
            this.permütasyonHesaplamaToolStripMenuItem.Name = "permütasyonHesaplamaToolStripMenuItem";
            this.permütasyonHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.permütasyonHesaplamaToolStripMenuItem.Text = "Permütasyon Hesaplama";
            this.permütasyonHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.permütasyonHesaplamaToolStripMenuItem_Click);
            // 
            // üslüSayıHesaplamaToolStripMenuItem
            // 
            this.üslüSayıHesaplamaToolStripMenuItem.Name = "üslüSayıHesaplamaToolStripMenuItem";
            this.üslüSayıHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.üslüSayıHesaplamaToolStripMenuItem.Text = "Üslü Sayı Hesaplama";
            this.üslüSayıHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.üslüSayıHesaplamaToolStripMenuItem_Click);
            // 
            // karekökHesaplamaToolStripMenuItem
            // 
            this.karekökHesaplamaToolStripMenuItem.Name = "karekökHesaplamaToolStripMenuItem";
            this.karekökHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.karekökHesaplamaToolStripMenuItem.Text = "Karekök Hesaplama";
            this.karekökHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.karekökHesaplamaToolStripMenuItem_Click);
            // 
            // eBOBEKOKToolStripMenuItem
            // 
            this.eBOBEKOKToolStripMenuItem.Name = "eBOBEKOKToolStripMenuItem";
            this.eBOBEKOKToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.eBOBEKOKToolStripMenuItem.Text = "EBOB - EKOK Hesaplama";
            this.eBOBEKOKToolStripMenuItem.Click += new System.EventHandler(this.eBOBEKOKToolStripMenuItem_Click);
            // 
            // modAlmaToolStripMenuItem
            // 
            this.modAlmaToolStripMenuItem.Name = "modAlmaToolStripMenuItem";
            this.modAlmaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.modAlmaToolStripMenuItem.Text = "Detaylı Ortalama Hesaplama";
            this.modAlmaToolStripMenuItem.Click += new System.EventHandler(this.modAlmaToolStripMenuItem_Click);
            // 
            // geometriToolStripMenuItem
            // 
            this.geometriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem,
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem});
            this.geometriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geometriToolStripMenuItem.Image")));
            this.geometriToolStripMenuItem.Name = "geometriToolStripMenuItem";
            this.geometriToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.geometriToolStripMenuItem.Text = "Geometri";
            // 
            // dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem
            // 
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem.Name = "dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem";
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem.Text = "Dikdörtgen Alan ve Çevre Hesaplama";
            this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem_Click);
            // 
            // diküçgenAlanVeÇevreHesaplamaToolStripMenuItem
            // 
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem.Name = "diküçgenAlanVeÇevreHesaplamaToolStripMenuItem";
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem.Text = "Diküçgen Alan ve Çevre Hesaplama";
            this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.diküçgenAlanVeÇevreHesaplamaToolStripMenuItem_Click);
            // 
            // hesaplayıcılarToolStripMenuItem
            // 
            this.hesaplayıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vücutKitleEndeksiToolStripMenuItem});
            this.hesaplayıcılarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hesaplayıcılarToolStripMenuItem.Image")));
            this.hesaplayıcılarToolStripMenuItem.Name = "hesaplayıcılarToolStripMenuItem";
            this.hesaplayıcılarToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.hesaplayıcılarToolStripMenuItem.Text = "Hesaplayıcılar";
            // 
            // vücutKitleEndeksiToolStripMenuItem
            // 
            this.vücutKitleEndeksiToolStripMenuItem.Name = "vücutKitleEndeksiToolStripMenuItem";
            this.vücutKitleEndeksiToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.vücutKitleEndeksiToolStripMenuItem.Text = "Vücut Kitle Endeksi";
            this.vücutKitleEndeksiToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleEndeksiToolStripMenuItem_Click);
            // 
            // userControlGirilenSayiyaKadarCarpma1
            // 
            this.userControlGirilenSayiyaKadarCarpma1.Location = new System.Drawing.Point(36, 33);
            this.userControlGirilenSayiyaKadarCarpma1.Name = "userControlGirilenSayiyaKadarCarpma1";
            this.userControlGirilenSayiyaKadarCarpma1.Size = new System.Drawing.Size(722, 417);
            this.userControlGirilenSayiyaKadarCarpma1.TabIndex = 13;
            // 
            // userControlUsluSayi1
            // 
            this.userControlUsluSayi1.Location = new System.Drawing.Point(36, 33);
            this.userControlUsluSayi1.Name = "userControlUsluSayi1";
            this.userControlUsluSayi1.Size = new System.Drawing.Size(722, 417);
            this.userControlUsluSayi1.TabIndex = 12;
            // 
            // userControlPermutasyonHesaplama1
            // 
            this.userControlPermutasyonHesaplama1.Location = new System.Drawing.Point(36, 33);
            this.userControlPermutasyonHesaplama1.Name = "userControlPermutasyonHesaplama1";
            this.userControlPermutasyonHesaplama1.Size = new System.Drawing.Size(722, 417);
            this.userControlPermutasyonHesaplama1.TabIndex = 11;
            // 
            // userControlModAlma1
            // 
            this.userControlModAlma1.Location = new System.Drawing.Point(36, 33);
            this.userControlModAlma1.Name = "userControlModAlma1";
            this.userControlModAlma1.Size = new System.Drawing.Size(722, 417);
            this.userControlModAlma1.TabIndex = 10;
            // 
            // userControlEbobEkokHesaplama1
            // 
            this.userControlEbobEkokHesaplama1.Location = new System.Drawing.Point(36, 33);
            this.userControlEbobEkokHesaplama1.Name = "userControlEbobEkokHesaplama1";
            this.userControlEbobEkokHesaplama1.Size = new System.Drawing.Size(722, 417);
            this.userControlEbobEkokHesaplama1.TabIndex = 9;
            // 
            // userControlKarekokHesaplama1
            // 
            this.userControlKarekokHesaplama1.Location = new System.Drawing.Point(36, 33);
            this.userControlKarekokHesaplama1.Name = "userControlKarekokHesaplama1";
            this.userControlKarekokHesaplama1.Size = new System.Drawing.Size(722, 417);
            this.userControlKarekokHesaplama1.TabIndex = 8;
            // 
            // userControlVucutKitleEndeksi1
            // 
            this.userControlVucutKitleEndeksi1.Location = new System.Drawing.Point(36, 33);
            this.userControlVucutKitleEndeksi1.Name = "userControlVucutKitleEndeksi1";
            this.userControlVucutKitleEndeksi1.Size = new System.Drawing.Size(722, 417);
            this.userControlVucutKitleEndeksi1.TabIndex = 7;
            // 
            // userControlKombinasyonHesaplama1
            // 
            this.userControlKombinasyonHesaplama1.Location = new System.Drawing.Point(36, 33);
            this.userControlKombinasyonHesaplama1.Name = "userControlKombinasyonHesaplama1";
            this.userControlKombinasyonHesaplama1.Size = new System.Drawing.Size(722, 417);
            this.userControlKombinasyonHesaplama1.TabIndex = 6;
            // 
            // userControlDortIslem1
            // 
            this.userControlDortIslem1.Location = new System.Drawing.Point(36, 33);
            this.userControlDortIslem1.Name = "userControlDortIslem1";
            this.userControlDortIslem1.Size = new System.Drawing.Size(722, 417);
            this.userControlDortIslem1.TabIndex = 5;
            // 
            // userControlDikucgenCevreAlan1
            // 
            this.userControlDikucgenCevreAlan1.Cursor = System.Windows.Forms.Cursors.Default;
            this.userControlDikucgenCevreAlan1.Location = new System.Drawing.Point(36, 33);
            this.userControlDikucgenCevreAlan1.Name = "userControlDikucgenCevreAlan1";
            this.userControlDikucgenCevreAlan1.Size = new System.Drawing.Size(722, 417);
            this.userControlDikucgenCevreAlan1.TabIndex = 4;
            // 
            // userControlAsalSayiListeleme1
            // 
            this.userControlAsalSayiListeleme1.Location = new System.Drawing.Point(36, 33);
            this.userControlAsalSayiListeleme1.Name = "userControlAsalSayiListeleme1";
            this.userControlAsalSayiListeleme1.Size = new System.Drawing.Size(722, 417);
            this.userControlAsalSayiListeleme1.TabIndex = 3;
            // 
            // userControlDikdortgenCevreAlan1
            // 
            this.userControlDikdortgenCevreAlan1.Location = new System.Drawing.Point(36, 33);
            this.userControlDikdortgenCevreAlan1.Name = "userControlDikdortgenCevreAlan1";
            this.userControlDikdortgenCevreAlan1.Size = new System.Drawing.Size(722, 417);
            this.userControlDikdortgenCevreAlan1.TabIndex = 2;
            // 
            // userControlAnasayfa1
            // 
            this.userControlAnasayfa1.Location = new System.Drawing.Point(36, 33);
            this.userControlAnasayfa1.Name = "userControlAnasayfa1";
            this.userControlAnasayfa1.Size = new System.Drawing.Size(722, 417);
            this.userControlAnasayfa1.TabIndex = 1;
            // 
            // girilenSayıyaKadarÇarpmaToolStripMenuItem
            // 
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem.Name = "girilenSayıyaKadarÇarpmaToolStripMenuItem";
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem.Text = "Girilen Sayıya Kadar Çarpma";
            this.girilenSayıyaKadarÇarpmaToolStripMenuItem.Click += new System.EventHandler(this.girilenSayıyaKadarÇarpmaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlGirilenSayiyaKadarCarpma1);
            this.Controls.Add(this.userControlUsluSayi1);
            this.Controls.Add(this.userControlPermutasyonHesaplama1);
            this.Controls.Add(this.userControlModAlma1);
            this.Controls.Add(this.userControlEbobEkokHesaplama1);
            this.Controls.Add(this.userControlKarekokHesaplama1);
            this.Controls.Add(this.userControlVucutKitleEndeksi1);
            this.Controls.Add(this.userControlKombinasyonHesaplama1);
            this.Controls.Add(this.userControlDortIslem1);
            this.Controls.Add(this.userControlDikucgenCevreAlan1);
            this.Controls.Add(this.userControlAsalSayiListeleme1);
            this.Controls.Add(this.userControlDikdortgenCevreAlan1);
            this.Controls.Add(this.userControlAnasayfa1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basitMatematikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem;
        private UserControlAnasayfa userControlAnasayfa1;
        private UserControlDikdortgenCevreAlan userControlDikdortgenCevreAlan1;
        private System.Windows.Forms.ToolStripMenuItem asalSayıListelemeToolStripMenuItem;
        private UserControlAsalSayiListeleme userControlAsalSayiListeleme1;
        private UserControlDikucgenCevreAlan userControlDikucgenCevreAlan1;
        private System.Windows.Forms.ToolStripMenuItem diküçgenAlanVeÇevreHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dörtİşlemToolStripMenuItem;
        private UserControlDortIslem userControlDortIslem1;
        private UserControlKombinasyonHesaplama userControlKombinasyonHesaplama1;
        private System.Windows.Forms.ToolStripMenuItem kombinasyonHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplayıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleEndeksiToolStripMenuItem;
        private UserControlVucutKitleEndeksi userControlVucutKitleEndeksi1;
        private System.Windows.Forms.ToolStripMenuItem karekökHesaplamaToolStripMenuItem;
        private UserControlKarekokHesaplama userControlKarekokHesaplama1;
        private System.Windows.Forms.ToolStripMenuItem eBOBEKOKToolStripMenuItem;
        private UserControlEbobEkokHesaplama userControlEbobEkokHesaplama1;
        private System.Windows.Forms.ToolStripMenuItem modAlmaToolStripMenuItem;
        private UserControlDetayliOrtalamaHesaplama userControlModAlma1;
        private UserControlPermutasyonHesaplama userControlPermutasyonHesaplama1;
        private System.Windows.Forms.ToolStripMenuItem permütasyonHesaplamaToolStripMenuItem;
        private UserControlUsluSayi userControlUsluSayi1;
        private System.Windows.Forms.ToolStripMenuItem üslüSayıHesaplamaToolStripMenuItem;
        private UserControlGirilenSayiyaKadarCarpma userControlGirilenSayiyaKadarCarpma1;
        private System.Windows.Forms.ToolStripMenuItem girilenSayıyaKadarÇarpmaToolStripMenuItem;
    }
}

