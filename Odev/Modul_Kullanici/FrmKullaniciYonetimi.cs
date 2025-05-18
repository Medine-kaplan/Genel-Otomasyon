using DevExpress.XtraEditors;
using Odev.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Kullanici
{
    public partial class FrmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int Id = 0;
        public FrmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += FrmKullaniciYonetimi_Shown;
        }
        
        private void FrmKullaniciYonetimi_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
         
        }

        private void FrmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel(true, Id);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

        }
    }
}