namespace Odev.Modul_Cari
{
    partial class FrmCariGruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariGruplar));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtGrupAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGrupKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GRUPKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GRUPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(277, 335);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.DoubleClick += new System.EventHandler(this.groupControl2_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtGrupAd);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.TxtGrupKod);
            this.groupControl1.Controls.Add(this.labelControl22);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 114);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Grup Bilgisi";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // TxtGrupAd
            // 
            this.TxtGrupAd.Location = new System.Drawing.Point(86, 60);
            this.TxtGrupAd.Name = "TxtGrupAd";
            this.TxtGrupAd.Size = new System.Drawing.Size(166, 20);
            this.TxtGrupAd.TabIndex = 11;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(20, 63);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(45, 13);
            this.labelControl19.TabIndex = 10;
            this.labelControl19.Text = "Grup Adı:";
            // 
            // TxtGrupKod
            // 
            this.TxtGrupKod.Location = new System.Drawing.Point(86, 35);
            this.TxtGrupKod.Name = "TxtGrupKod";
            this.TxtGrupKod.Size = new System.Drawing.Size(166, 20);
            this.TxtGrupKod.TabIndex = 9;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(20, 39);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(54, 13);
            this.labelControl22.TabIndex = 8;
            this.labelControl22.Text = "Grup Kodu:";
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(0, 122);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(273, 128);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.GRUPKODU,
            this.GRUPADI});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "ID";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsColumn.AllowFocus = false;
            this.id.OptionsColumn.FixedWidth = true;
            // 
            // GRUPKODU
            // 
            this.GRUPKODU.Caption = "Grup Kodu";
            this.GRUPKODU.FieldName = "GRUPKODU";
            this.GRUPKODU.Name = "GRUPKODU";
            this.GRUPKODU.OptionsColumn.AllowEdit = false;
            this.GRUPKODU.OptionsColumn.AllowFocus = false;
            this.GRUPKODU.OptionsColumn.FixedWidth = true;
            this.GRUPKODU.Visible = true;
            this.GRUPKODU.VisibleIndex = 1;
            // 
            // GRUPADI
            // 
            this.GRUPADI.Caption = "Grup Adı";
            this.GRUPADI.FieldName = "GRUPADI";
            this.GRUPADI.Name = "GRUPADI";
            this.GRUPADI.OptionsColumn.AllowEdit = false;
            this.GRUPADI.OptionsColumn.AllowFocus = false;
            this.GRUPADI.OptionsColumn.FixedWidth = true;
            this.GRUPADI.Visible = true;
            this.GRUPADI.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnKaydet);
            this.groupControl3.Controls.Add(this.BtnSil);
            this.groupControl3.Controls.Add(this.BtnKapat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 256);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(273, 77);
            this.groupControl3.TabIndex = 3;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(8, 18);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(74, 43);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(95, 18);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(74, 43);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(186, 18);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(74, 43);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click_2);
            // 
            // FrmCariGruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 335);
            this.Controls.Add(this.groupControl2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmCariGruplar.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCariGruplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇAĞRI GRUPLARI";
            this.Load += new System.EventHandler(this.FrmCariGruplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrupKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn GRUPKODU;
        private DevExpress.XtraGrid.Columns.GridColumn GRUPADI;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtGrupAd;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit TxtGrupKod;
        private DevExpress.XtraEditors.LabelControl labelControl22;
    }
}