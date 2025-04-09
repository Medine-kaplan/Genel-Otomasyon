namespace Odev.Modul_Stok
{
    partial class FrmStokKartı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokKartı));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtstokkodu = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.TxtSatisKDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAlisKDV = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.TxtSatişFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.TxtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.TxtGrupAdı = new DevExpress.XtraEditors.TextEdit();
            this.TxtGrupKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatişFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnResimSec);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtstokkodu);
            this.groupControl1.Controls.Add(this.TxtStokAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(525, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ana Stok Bilgileri";
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnResimSec.Appearance.Options.UseFont = true;
            this.BtnResimSec.Location = new System.Drawing.Point(352, 32);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(75, 59);
            this.BtnResimSec.TabIndex = 2;
            this.BtnResimSec.Text = "Stok\r\nResmi\r\nSeçin";
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Stok Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu:";
            // 
            // txtstokkodu
            // 
            this.txtstokkodu.Location = new System.Drawing.Point(90, 31);
            this.txtstokkodu.Name = "txtstokkodu";
            this.txtstokkodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtstokkodu.Size = new System.Drawing.Size(164, 20);
            this.txtstokkodu.TabIndex = 0;
            this.txtstokkodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtstokkodu_ButtonClick);
            // 
            // TxtStokAdi
            // 
            this.TxtStokAdi.Location = new System.Drawing.Point(90, 57);
            this.TxtStokAdi.Name = "TxtStokAdi";
            this.TxtStokAdi.Size = new System.Drawing.Size(164, 20);
            this.TxtStokAdi.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnKaydet);
            this.groupControl2.Controls.Add(this.BtnSil);
            this.groupControl2.Controls.Add(this.BtnKapat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 362);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(525, 99);
            this.groupControl2.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(119, 39);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(81, 48);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(217, 39);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(81, 48);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(313, 39);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(81, 48);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl7);
            this.groupControl3.Controls.Add(this.groupControl6);
            this.groupControl3.Controls.Add(this.groupControl5);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 100);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(525, 262);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Genel Stok Bilgileri";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.TxtSatisKDV);
            this.groupControl7.Controls.Add(this.labelControl9);
            this.groupControl7.Controls.Add(this.labelControl10);
            this.groupControl7.Controls.Add(this.TxtAlisKDV);
            this.groupControl7.Location = new System.Drawing.Point(278, 144);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(244, 112);
            this.groupControl7.TabIndex = 3;
            this.groupControl7.Text = "KDV Bilgileri %";
            // 
            // TxtSatisKDV
            // 
            this.TxtSatisKDV.Location = new System.Drawing.Point(92, 59);
            this.TxtSatisKDV.Name = "TxtSatisKDV";
            this.TxtSatisKDV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtSatisKDV.Properties.MaskSettings.Set("mask", "p");
            this.TxtSatisKDV.Size = new System.Drawing.Size(133, 20);
            this.TxtSatisKDV.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 60);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 16);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Satış KDV:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(15, 35);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 16);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Alış KDV:";
            // 
            // TxtAlisKDV
            // 
            this.TxtAlisKDV.Location = new System.Drawing.Point(92, 34);
            this.TxtAlisKDV.Name = "TxtAlisKDV";
            this.TxtAlisKDV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtAlisKDV.Properties.MaskSettings.Set("mask", "p");
            this.TxtAlisKDV.Size = new System.Drawing.Size(133, 20);
            this.TxtAlisKDV.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.TxtSatişFiyati);
            this.groupControl6.Controls.Add(this.labelControl7);
            this.groupControl6.Controls.Add(this.labelControl8);
            this.groupControl6.Controls.Add(this.TxtAlisFiyati);
            this.groupControl6.Location = new System.Drawing.Point(278, 26);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(244, 112);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Fiyat Bilgileri";
            // 
            // TxtSatişFiyati
            // 
            this.TxtSatişFiyati.Location = new System.Drawing.Point(92, 59);
            this.TxtSatişFiyati.Name = "TxtSatişFiyati";
            this.TxtSatişFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtSatişFiyati.Properties.MaskSettings.Set("mask", "p");
            this.TxtSatişFiyati.Size = new System.Drawing.Size(133, 20);
            this.TxtSatişFiyati.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Satış Fiyatı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 16);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Alış Fiyatı:";
            // 
            // TxtAlisFiyati
            // 
            this.TxtAlisFiyati.Location = new System.Drawing.Point(92, 34);
            this.TxtAlisFiyati.Name = "TxtAlisFiyati";
            this.TxtAlisFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtAlisFiyati.Properties.MaskSettings.Set("mask", "p");
            this.TxtAlisFiyati.Size = new System.Drawing.Size(133, 20);
            this.TxtAlisFiyati.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.TxtBarkod);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.TxtBirim);
            this.groupControl5.Location = new System.Drawing.Point(0, 144);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(272, 112);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Barkod Ve Birim";
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.Location = new System.Drawing.Point(92, 59);
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.Size = new System.Drawing.Size(165, 20);
            this.TxtBarkod.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Barkod:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 16);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Birim:";
            // 
            // TxtBirim
            // 
            this.TxtBirim.EditValue = "ADET";
            this.TxtBirim.Location = new System.Drawing.Point(92, 34);
            this.TxtBirim.Name = "TxtBirim";
            this.TxtBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBirim.Properties.Items.AddRange(new object[] {
            "ADET",
            "TANE",
            "KİLO",
            "METRE"});
            this.TxtBirim.Size = new System.Drawing.Size(165, 20);
            this.TxtBirim.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.TxtGrupAdı);
            this.groupControl4.Controls.Add(this.TxtGrupKodu);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Location = new System.Drawing.Point(0, 26);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(272, 112);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Grup Bilgileri";
            // 
            // TxtGrupAdı
            // 
            this.TxtGrupAdı.Location = new System.Drawing.Point(92, 59);
            this.TxtGrupAdı.Name = "TxtGrupAdı";
            this.TxtGrupAdı.Size = new System.Drawing.Size(165, 20);
            this.TxtGrupAdı.TabIndex = 1;
            // 
            // TxtGrupKodu
            // 
            this.TxtGrupKodu.Location = new System.Drawing.Point(92, 34);
            this.TxtGrupKodu.Name = "TxtGrupKodu";
            this.TxtGrupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtGrupKodu.Size = new System.Drawing.Size(165, 20);
            this.TxtGrupKodu.TabIndex = 0;
            this.TxtGrupKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtGrupKodu_ButtonClick);
            this.TxtGrupKodu.EditValueChanged += new System.EventHandler(this.TxtGrupKodu_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Grup Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Grup Kodu:";
            // 
            // FrmStokKartı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 461);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmStokKartı.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "FrmStokKartı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK AÇILIŞ KARTI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStokKartı_FormClosed);
            this.Load += new System.EventHandler(this.FrmStokKartı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatişFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit txtstokkodu;
        private DevExpress.XtraEditors.TextEdit TxtStokAdi;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit TxtSatisKDV;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtSatişFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtGrupAdı;
        private DevExpress.XtraEditors.ButtonEdit TxtGrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAlisKDV;
        private DevExpress.XtraEditors.TextEdit TxtAlisFiyati;
        private DevExpress.XtraEditors.ComboBoxEdit TxtBirim;
    }
}