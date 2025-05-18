namespace Odev.Modul_Cek
{
    partial class FrmCekListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCekListesi));
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBankasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.TxtCekTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNumarasi.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(662, 507);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKA,
            this.CARINO,
            this.TIPI});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // BANKA
            // 
            this.BANKA.Caption = "Banka";
            this.BANKA.FieldName = "BANKA";
            this.BANKA.Name = "BANKA";
            this.BANKA.OptionsColumn.AllowEdit = false;
            this.BANKA.OptionsColumn.AllowFocus = false;
            this.BANKA.OptionsColumn.FixedWidth = true;
            this.BANKA.Visible = true;
            this.BANKA.VisibleIndex = 0;
            this.BANKA.Width = 191;
            // 
            // CARINO
            // 
            this.CARINO.Caption = "Cari  Numarası";
            this.CARINO.FieldName = "CARINO";
            this.CARINO.Name = "CARINO";
            this.CARINO.OptionsColumn.AllowEdit = false;
            this.CARINO.OptionsColumn.AllowFocus = false;
            this.CARINO.OptionsColumn.FixedWidth = true;
            this.CARINO.Visible = true;
            this.CARINO.VisibleIndex = 1;
            this.CARINO.Width = 353;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "Çek Türü";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 2;
            this.TIPI.Width = 93;
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(88, 154);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(78, 36);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Temizle";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnara.ImageOptions.SvgImage")));
            this.btnara.Location = new System.Drawing.Point(4, 154);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(78, 36);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "Ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // TxtBankasi
            // 
            this.TxtBankasi.Location = new System.Drawing.Point(4, 128);
            this.TxtBankasi.Name = "TxtBankasi";
            this.TxtBankasi.Size = new System.Drawing.Size(144, 20);
            this.TxtBankasi.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bankası";
            // 
            // txtCekNumarasi
            // 
            this.txtCekNumarasi.Location = new System.Drawing.Point(5, 87);
            this.txtCekNumarasi.Name = "txtCekNumarasi";
            this.txtCekNumarasi.Size = new System.Drawing.Size(144, 20);
            this.txtCekNumarasi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Çek Numarası:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Türü:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnara);
            this.xtraTabPage1.Controls.Add(this.TxtBankasi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtCekNumarasi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.TxtCekTuru);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(186, 482);
            this.xtraTabPage1.Text = "Arama";
            // 
            // TxtCekTuru
            // 
            this.TxtCekTuru.Location = new System.Drawing.Point(4, 42);
            this.TxtCekTuru.Name = "TxtCekTuru";
            this.TxtCekTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCekTuru.Properties.Items.AddRange(new object[] {
            "Kendi Çekimiz ",
            "Müşteri Çeki"});
            this.TxtCekTuru.Size = new System.Drawing.Size(144, 20);
            this.TxtCekTuru.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(860, 507);
            this.splitContainerControl1.SplitterPosition = 188;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(188, 507);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // FrmCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 507);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmCekListesi.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇEK LİSTESİ";
            this.Load += new System.EventHandler(this.FrmCekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNumarasi.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCekTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BANKA;
        private DevExpress.XtraGrid.Columns.GridColumn CARINO;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.TextEdit TxtBankasi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCekNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.ComboBoxEdit TxtCekTuru;
    }
}