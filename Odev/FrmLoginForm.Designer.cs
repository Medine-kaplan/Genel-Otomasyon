namespace Odev
{
    partial class FrmLoginForm
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
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAyar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(91, 54);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnGiris.TabIndex = 0;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnAyar
            // 
            this.BtnAyar.Location = new System.Drawing.Point(91, 83);
            this.BtnAyar.Name = "BtnAyar";
            this.BtnAyar.Size = new System.Drawing.Size(100, 23);
            this.BtnAyar.TabIndex = 1;
            this.BtnAyar.Text = "Banğlantı Ayarları";
            this.BtnAyar.Click += new System.EventHandler(this.BtnAyar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "KULLANICI:";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(70, 2);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(151, 20);
            this.TxtKullanici.TabIndex = 3;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(70, 28);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(151, 20);
            this.TxtSifre.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ŞİFRE:";
            // 
            // FrmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 118);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnAyar);
            this.Controls.Add(this.BtnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLoginForm";
            this.Text = "LOGİN";
            this.Load += new System.EventHandler(this.FrmLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.SimpleButton BtnAyar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtKullanici;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}