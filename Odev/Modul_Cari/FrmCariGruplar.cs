using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Cari
{
    public partial class FrmCariGruplar : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;
        
        
        public FrmCariGruplar()
        {
            InitializeComponent();
            InitializeComponent();
            listele();
        }

        void Temizle()
        {
            TxtGrupAd.Text = "";
            TxtGrupKod.Text  = "";
            Edit = false;
            SecimID = -1;
            listele()
;
        }
        void listele()
        {
            var lst = from s in db.TBL_CARIGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TxtGrupAd.Text= gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                TxtGrupKod.Text= gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.GRUPADI = TxtGrupAd.Text;
                Grup.GRUPKODU = TxtGrupKod.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                db.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni cari grup kaydı oluşturuldu.");

                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = db.TBL_CARIGRUPLARIs.First(s=>s.ID==SecimID);
                Grup.GRUPADI = TxtGrupAd.Text;
                Grup.GRUPKODU = TxtGrupKod.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = AnaForm.UserID;
                db.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup);
                db.SubmitChanges();
                Mesajlar.Guncelle(true);

                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Sil()
        {
            try
            {
                db.TBL_CARIGRUPLARIs.DeleteOnSubmit(db.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);            }
        }
        

       

        private void FrmCariGruplar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Liste_Click(object sender, EventArgs e)
        {

        }


        private void Liste_Click_1(object sender, EventArgs e)
        {

        }


        private void Liste_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();

        }

        private void BtnKapat_Click_2(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupControl2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)

            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Liste_Click_2(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}