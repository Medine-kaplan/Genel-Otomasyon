using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Banka
{
    public partial class FrmBankaIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;
        public FrmBankaIslem()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBankaIslem_Load(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = IslemID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                TxtAciklama.Text = Hareket.ACIKLAMA;
                TxtBelgeNo.Text = Hareket.BELGENO;
                TxtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                TxtTutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") rbGirisIslemi.Checked = true;
                if (Hareket.GCKODU == "C") RbCikisIslemi.Checked = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                TxtHesapAdi.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                TxtHesapno.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void Temizle()
        {
            TxtAciklama.Text = "";
            TxtBelgeNo.Text = "";
            TxtHesapAdi.Text = "";
            TxtHesapno.Text = "";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            TxtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }
   
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = TxtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = TxtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbGirisIslemi.Checked) Hareket.GCKODU = "G";
                if (RbCikisIslemi.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(TxtTarih.Text);
                Hareket.TUTAR = decimal.Parse(TxtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Banka İşlemi Kaydı Yapılmıştır.");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = db.TBL_BANKAHAREKETLERIs.First(s=>s.ID==IslemID);
                Hareket.ACIKLAMA = TxtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = TxtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbGirisIslemi.Checked) Hareket.GCKODU = "G";
                if (RbCikisIslemi.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(TxtTarih.Text);
                Hareket.TUTAR = decimal.Parse(TxtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
    
    
    void Sil()
        {
            try
            {
                db.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                db.SubmitChanges();
                Temizle();
            
            
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }
    }
}