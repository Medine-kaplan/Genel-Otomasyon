namespace Odev.Modul_Kullanici
{
    partial class FrmKullaniciYonetimi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOYISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BtnYeniKullanici);
            this.panelControl1.Controls.Add(this.BtnGuncelle);
            this.panelControl1.Controls.Add(this.BtnSil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(618, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // BtnYeniKullanici
            // 
            this.BtnYeniKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniKullanici.Appearance.Options.UseFont = true;
            this.BtnYeniKullanici.Location = new System.Drawing.Point(5, 12);
            this.BtnYeniKullanici.Name = "BtnYeniKullanici";
            this.BtnYeniKullanici.Size = new System.Drawing.Size(176, 26);
            this.BtnYeniKullanici.TabIndex = 1;
            this.BtnYeniKullanici.Text = "Yeni Kullanıcı Girişi";
            this.BtnYeniKullanici.Click += new System.EventHandler(this.BtnYeniKullanici_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Location = new System.Drawing.Point(208, 11);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 26);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Seçili Kullanıcıyı Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Location = new System.Drawing.Point(416, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(176, 26);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Seçili Kullanıcıyı Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 402);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KULLANICI,
            this.ISIM,
            this.SOYISIM,
            this.AKTIF,
            this.KODU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            // 
            // KULLANICI
            // 
            this.KULLANICI.Caption = "Kullanıcı";
            this.KULLANICI.FieldName = "KULLANICI";
            this.KULLANICI.Name = "KULLANICI";
            this.KULLANICI.OptionsColumn.AllowEdit = false;
            this.KULLANICI.OptionsColumn.AllowFocus = false;
            this.KULLANICI.OptionsColumn.FixedWidth = true;
            this.KULLANICI.Visible = true;
            this.KULLANICI.VisibleIndex = 0;
            this.KULLANICI.Width = 123;
            // 
            // ISIM
            // 
            this.ISIM.Caption = "İsim";
            this.ISIM.FieldName = "ISIM";
            this.ISIM.Name = "ISIM";
            this.ISIM.OptionsColumn.AllowEdit = false;
            this.ISIM.OptionsColumn.AllowFocus = false;
            this.ISIM.OptionsColumn.FixedWidth = true;
            this.ISIM.Visible = true;
            this.ISIM.VisibleIndex = 1;
            this.ISIM.Width = 159;
            // 
            // SOYISIM
            // 
            this.SOYISIM.Caption = "Soyİsim";
            this.SOYISIM.FieldName = "SOYISIM";
            this.SOYISIM.Name = "SOYISIM";
            this.SOYISIM.OptionsColumn.AllowEdit = false;
            this.SOYISIM.OptionsColumn.AllowFocus = false;
            this.SOYISIM.OptionsColumn.FixedWidth = true;
            this.SOYISIM.Visible = true;
            this.SOYISIM.VisibleIndex = 2;
            this.SOYISIM.Width = 144;
            // 
            // AKTIF
            // 
            this.AKTIF.Caption = "Durum";
            this.AKTIF.FieldName = "AKTIF";
            this.AKTIF.Name = "AKTIF";
            this.AKTIF.OptionsColumn.AllowEdit = false;
            this.AKTIF.OptionsColumn.AllowFocus = false;
            this.AKTIF.OptionsColumn.FixedWidth = true;
            this.AKTIF.Visible = true;
            this.AKTIF.VisibleIndex = 3;
            // 
            // KODU
            // 
            this.KODU.Caption = "Kullanıcı Kodu";
            this.KODU.FieldName = "KODU";
            this.KODU.Name = "KODU";
            this.KODU.OptionsColumn.AllowEdit = false;
            this.KODU.OptionsColumn.AllowFocus = false;
            this.KODU.OptionsColumn.FixedWidth = true;
            this.KODU.Visible = true;
            this.KODU.VisibleIndex = 4;
            // 
            // FrmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 453);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmKullaniciYonetimi";
            this.Text = "KULLANICI YÖNETİMİ";
            this.Load += new System.EventHandler(this.FrmKullaniciYonetimi_Load);
            this.Shown += new System.EventHandler(this.FrmKullaniciYonetimi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnYeniKullanici;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICI;
        private DevExpress.XtraGrid.Columns.GridColumn ISIM;
        private DevExpress.XtraGrid.Columns.GridColumn SOYISIM;
        private DevExpress.XtraGrid.Columns.GridColumn AKTIF;
        private DevExpress.XtraGrid.Columns.GridColumn KODU;
    }
}