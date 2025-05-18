namespace Odev.Modul_Cek
{
    partial class FrmBankayaCekCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankayaCekCikisi));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtHesapNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBelgeno = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTtutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBanka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCekNo = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtVadeTarihi = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBelgeno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTtutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVadeTarihi.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnKaydet);
            this.groupControl3.Controls.Add(this.BtnSil);
            this.groupControl3.Controls.Add(this.BtnKapat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 296);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(372, 100);
            this.groupControl3.TabIndex = 9;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(58, 36);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(94, 45);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Enabled = false;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(158, 36);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(101, 45);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(265, 36);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(95, 45);
            this.BtnKapat.TabIndex = 9;
            this.BtnKapat.Text = "Kapat";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.xtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtBelgeno);
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.TxtBankaAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 136);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Cari Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Banka Adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap No:";
            // 
            // xtHesapNo
            // 
            this.xtHesapNo.Location = new System.Drawing.Point(58, 78);
            this.xtHesapNo.Name = "xtHesapNo";
            this.xtHesapNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.xtHesapNo.Properties.ReadOnly = true;
            this.xtHesapNo.Size = new System.Drawing.Size(144, 20);
            this.xtHesapNo.TabIndex = 5;
            this.xtHesapNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.xtHesapNo_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tarih:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Belge No:";
            // 
            // TxtBelgeno
            // 
            this.TxtBelgeno.Location = new System.Drawing.Point(58, 26);
            this.TxtBelgeno.Name = "TxtBelgeno";
            this.TxtBelgeno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtBelgeno.Size = new System.Drawing.Size(144, 20);
            this.TxtBelgeno.TabIndex = 1;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(58, 52);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.EditFormat.FormatString = "";
            this.TxtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtTarih.Size = new System.Drawing.Size(144, 20);
            this.TxtTarih.TabIndex = 3;
            // 
            // TxtBankaAdi
            // 
            this.TxtBankaAdi.Location = new System.Drawing.Point(58, 104);
            this.TxtBankaAdi.Name = "TxtBankaAdi";
            this.TxtBankaAdi.Properties.ReadOnly = true;
            this.TxtBankaAdi.Size = new System.Drawing.Size(144, 20);
            this.TxtBankaAdi.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txtTtutar);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.TxtSube);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.TxtBanka);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.TxtCekNo);
            this.groupControl2.Controls.Add(this.TxtVadeTarihi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 136);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(372, 160);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Çek Bilgileri";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 141);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Tutar:";
            // 
            // txtTtutar
            // 
            this.txtTtutar.Location = new System.Drawing.Point(64, 138);
            this.txtTtutar.Name = "txtTtutar";
            this.txtTtutar.Properties.ReadOnly = true;
            this.txtTtutar.Size = new System.Drawing.Size(144, 20);
            this.txtTtutar.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Şube:";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(64, 112);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Properties.ReadOnly = true;
            this.TxtSube.Size = new System.Drawing.Size(144, 20);
            this.TxtSube.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Banka:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Vade Tarihi:";
            // 
            // TxtBanka
            // 
            this.TxtBanka.Location = new System.Drawing.Point(64, 86);
            this.TxtBanka.Name = "TxtBanka";
            this.TxtBanka.Properties.ReadOnly = true;
            this.TxtBanka.Size = new System.Drawing.Size(144, 20);
            this.TxtBanka.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Çek No:";
            // 
            // TxtCekNo
            // 
            this.TxtCekNo.Location = new System.Drawing.Point(64, 34);
            this.TxtCekNo.Name = "TxtCekNo";
            this.TxtCekNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtCekNo.Properties.ReadOnly = true;
            this.TxtCekNo.Size = new System.Drawing.Size(144, 20);
            this.TxtCekNo.TabIndex = 5;
            this.TxtCekNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCekNo_ButtonClick);
            // 
            // TxtVadeTarihi
            // 
            this.TxtVadeTarihi.EditValue = null;
            this.TxtVadeTarihi.Location = new System.Drawing.Point(64, 60);
            this.TxtVadeTarihi.Name = "TxtVadeTarihi";
            this.TxtVadeTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtVadeTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtVadeTarihi.Properties.DisplayFormat.FormatString = "";
            this.TxtVadeTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtVadeTarihi.Properties.EditFormat.FormatString = "";
            this.TxtVadeTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtVadeTarihi.Properties.MaskSettings.Set("mask", "");
            this.TxtVadeTarihi.Properties.ReadOnly = true;
            this.TxtVadeTarihi.Size = new System.Drawing.Size(144, 20);
            this.TxtVadeTarihi.TabIndex = 7;
            // 
            // FrmBankayaCekCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 396);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmBankayaCekCikisi.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankayaCekCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKAYA ÇEK ÇIKIŞI";
            this.Load += new System.EventHandler(this.FrmBankayaCekCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBelgeno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTtutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVadeTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVadeTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit xtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit TxtBelgeno;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private DevExpress.XtraEditors.TextEdit TxtBankaAdi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTtutar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtSube;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtBanka;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ButtonEdit TxtCekNo;
        private DevExpress.XtraEditors.DateEdit TxtVadeTarihi;
    }
}