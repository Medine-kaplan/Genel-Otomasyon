namespace Odev.Modul_Kasa
{
    partial class FrmKasaHareketleri
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
            this.components = new System.ComponentModel.Container();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devirKartıİşleminiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "Açıklama";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            this.ACIKLAMA.Width = 446;
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(563, 31);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBakiye.Properties.Appearance.Options.UseFont = true;
            this.TxtBakiye.Properties.ReadOnly = true;
            this.TxtBakiye.Size = new System.Drawing.Size(76, 24);
            this.TxtBakiye.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(510, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Bakiye:";
            // 
            // TxtCikis
            // 
            this.TxtCikis.Location = new System.Drawing.Point(428, 69);
            this.TxtCikis.Name = "TxtCikis";
            this.TxtCikis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCikis.Properties.Appearance.Options.UseFont = true;
            this.TxtCikis.Properties.ReadOnly = true;
            this.TxtCikis.Size = new System.Drawing.Size(65, 24);
            this.TxtCikis.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(390, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Çıkış:";
            // 
            // TxtGiris
            // 
            this.TxtGiris.Location = new System.Drawing.Point(428, 34);
            this.TxtGiris.Name = "TxtGiris";
            this.TxtGiris.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGiris.Properties.Appearance.Options.UseFont = true;
            this.TxtGiris.Properties.ReadOnly = true;
            this.TxtGiris.Size = new System.Drawing.Size(65, 24);
            this.TxtGiris.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(391, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Giriş:";
            // 
            // TxtKasaAdi
            // 
            this.TxtKasaAdi.Location = new System.Drawing.Point(115, 69);
            this.TxtKasaAdi.Name = "TxtKasaAdi";
            this.TxtKasaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKasaAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtKasaAdi.Properties.ReadOnly = true;
            this.TxtKasaAdi.Size = new System.Drawing.Size(270, 24);
            this.TxtKasaAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "Giriş";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.Caption = "Evrak Türü";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 1;
            this.EVRAKTURU.Width = 79;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "Belge No";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.OptionsFilter.AllowAutoFilter = false;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 85;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsFilter.AllowAutoFilter = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // liste
            // 
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(2, 23);
            this.liste.MainView = this.gridView1;
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(686, 274);
            this.liste.TabIndex = 0;
            this.liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.liste.ContextMenuStripChanged += new System.EventHandler(this.Sagtik);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTURU,
            this.GIRIS,
            this.CIKIS,
            this.TARIH,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "Çıkış";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 108);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(690, 299);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // TxtKasaKodu
            // 
            this.TxtKasaKodu.Location = new System.Drawing.Point(115, 37);
            this.TxtKasaKodu.Name = "TxtKasaKodu";
            this.TxtKasaKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKasaKodu.Properties.Appearance.Options.UseFont = true;
            this.TxtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtKasaKodu.Properties.ReadOnly = true;
            this.TxtKasaKodu.Size = new System.Drawing.Size(270, 24);
            this.TxtKasaKodu.TabIndex = 1;
            this.TxtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtKasaKodu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtBakiye);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtCikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtGiris);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(690, 108);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // SagTik
            // 
            this.SagTik.Enabled = false;
            this.SagTik.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devirKartıİşleminiDüzenleToolStripMenuItem,
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(304, 52);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // devirKartıİşleminiDüzenleToolStripMenuItem
            // 
            this.devirKartıİşleminiDüzenleToolStripMenuItem.Enabled = false;
            this.devirKartıİşleminiDüzenleToolStripMenuItem.Name = "devirKartıİşleminiDüzenleToolStripMenuItem";
            this.devirKartıİşleminiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.devirKartıİşleminiDüzenleToolStripMenuItem.Text = "Devir Kartı İşlemini Düzenle";
            this.devirKartıİşleminiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.devirKartıİşleminiDüzenleToolStripMenuItem_Click);
            // 
            // tahsilatÖdemeİşleminiDüzenleToolStripMenuItem
            // 
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = false;
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Name = "tahsilatÖdemeİşleminiDüzenleToolStripMenuItem";
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem_Click);
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 2;
            // 
            // FrmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 407);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmKasaHareketleri";
            this.Text = "KASA HAREKETLERİ";
            this.Load += new System.EventHandler(this.FrmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.TextEdit TxtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ButtonEdit TxtKasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem devirKartıİşleminiDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahsilatÖdemeİşleminiDüzenleToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
    }
}