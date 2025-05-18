namespace Odev
{
    partial class FrmAyar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.TxtUserID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ChkYeniGiris = new DevExpress.XtraEditors.CheckEdit();
            this.TxtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.TxtSunucu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkYeniGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSunucu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(499, 215);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mevcut Bağlantı Bilgisi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CS:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtPassword);
            this.groupControl2.Controls.Add(this.TxtUserID);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.BtnKaydet);
            this.groupControl2.Controls.Add(this.ChkYeniGiris);
            this.groupControl2.Controls.Add(this.TxtDatabase);
            this.groupControl2.Controls.Add(this.TxtSunucu);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 68);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(499, 147);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Yeni Bağlantı Bilgisi";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(304, 68);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(177, 20);
            this.TxtPassword.TabIndex = 11;
            // 
            // TxtUserID
            // 
            this.TxtUserID.Enabled = false;
            this.TxtUserID.Location = new System.Drawing.Point(304, 34);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(177, 20);
            this.TxtUserID.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(237, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Password:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(237, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "User ID:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.Location = new System.Drawing.Point(304, 105);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(177, 23);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Yeni Ayarları Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChkYeniGiris
            // 
            this.ChkYeniGiris.Location = new System.Drawing.Point(156, 107);
            this.ChkYeniGiris.Name = "ChkYeniGiris";
            this.ChkYeniGiris.Properties.Caption = "Yeni Giriş";
            this.ChkYeniGiris.Size = new System.Drawing.Size(75, 20);
            this.ChkYeniGiris.TabIndex = 6;
            this.ChkYeniGiris.CheckedChanged += new System.EventHandler(this.ChkYeniGiris_CheckedChanged);
            // 
            // TxtDatabase
            // 
            this.TxtDatabase.Enabled = false;
            this.TxtDatabase.Location = new System.Drawing.Point(68, 68);
            this.TxtDatabase.Name = "TxtDatabase";
            this.TxtDatabase.Size = new System.Drawing.Size(163, 20);
            this.TxtDatabase.TabIndex = 5;
            // 
            // TxtSunucu
            // 
            this.TxtSunucu.Enabled = false;
            this.TxtSunucu.Location = new System.Drawing.Point(68, 34);
            this.TxtSunucu.Name = "TxtSunucu";
            this.TxtSunucu.Size = new System.Drawing.Size(163, 20);
            this.TxtSunucu.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Database:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Sunucu:";
            // 
            // FrmAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 215);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyar";
            this.Text = "BAĞLANTI AYARLARI";
            this.Load += new System.EventHandler(this.FrmAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkYeniGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSunucu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.CheckEdit ChkYeniGiris;
        private DevExpress.XtraEditors.TextEdit TxtDatabase;
        private DevExpress.XtraEditors.TextEdit TxtSunucu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.TextEdit TxtUserID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}