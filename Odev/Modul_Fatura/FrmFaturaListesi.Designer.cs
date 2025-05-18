namespace Odev.Modul_Fatura
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.TxtFaturaTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURATURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagTikYenile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNo.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(88, 154);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(78, 36);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Temizle";
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tarih:";
            // 
            // TxtFaturaNo
            // 
            this.TxtFaturaNo.Location = new System.Drawing.Point(5, 87);
            this.TxtFaturaNo.Name = "TxtFaturaNo";
            this.TxtFaturaNo.Size = new System.Drawing.Size(144, 20);
            this.TxtFaturaNo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fatura No:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnara);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TxtFaturaNo);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.TxtFaturaTuru);
            this.xtraTabPage1.Controls.Add(this.TxtTarih);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(186, 420);
            this.xtraTabPage1.Text = "Arama";
            // 
            // TxtFaturaTuru
            // 
            this.TxtFaturaTuru.Location = new System.Drawing.Point(4, 42);
            this.TxtFaturaTuru.Name = "TxtFaturaTuru";
            this.TxtFaturaTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFaturaTuru.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Aış Faturası",
            "Alış İade Faturası"});
            this.TxtFaturaTuru.Size = new System.Drawing.Size(144, 20);
            this.TxtFaturaTuru.TabIndex = 1;
            this.TxtFaturaTuru.SelectedIndexChanged += new System.EventHandler(this.TxtFaturaTuru_SelectedIndexChanged);
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(4, 128);
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
            this.TxtTarih.TabIndex = 5;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(810, 445);
            this.splitContainerControl1.SplitterPosition = 188;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(188, 445);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(612, 445);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FATURANO,
            this.FATURATURU,
            this.CARIKODU});
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
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURA NUMARASI";
            this.FATURANO.FieldName = "Fatura Numarası";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 0;
            // 
            // FATURATURU
            // 
            this.FATURATURU.Caption = "FATURA TÜRÜ";
            this.FATURATURU.FieldName = "FATURATURU";
            this.FATURATURU.Name = "FATURATURU";
            this.FATURATURU.OptionsColumn.AllowEdit = false;
            this.FATURATURU.OptionsColumn.AllowFocus = false;
            this.FATURATURU.OptionsColumn.FixedWidth = true;
            this.FATURATURU.Visible = true;
            this.FATURATURU.VisibleIndex = 1;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 2;
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagTikYenile});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(181, 48);
            // 
            // SagTikYenile
            // 
            this.SagTikYenile.Name = "SagTikYenile";
            this.SagTikYenile.Size = new System.Drawing.Size(180, 22);
            this.SagTikYenile.Text = "YENİLE";
            this.SagTikYenile.Click += new System.EventHandler(this.SagTikYenile_Click);
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 445);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.LargeImage = global::Odev.Properties.Resources.chartsshowlegend_32x32;
            this.Name = "FrmFaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaNo.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtFaturaNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn FATURATURU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraEditors.ComboBoxEdit TxtFaturaTuru;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem SagTikYenile;
    }
}