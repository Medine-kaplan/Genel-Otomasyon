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
    public partial class FrmBankaTransferi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;
        public FrmBankaTransferi()
        {
            InitializeComponent();
        }

      
        private void TxtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtTransferTuru.SelectedIndex==0)
            {
                rbGelenhavale.Text = "Gelen Havale";
                RbGidenHavlae.Text = "Giden Havale";
               
            }
            else if(TxtTransferTuru.SelectedIndex==0)
            {
                rbGelenhavale.Text = "Gelen Havale";
                RbGidenHavlae.Text = "Giden Havale";
                
            }
        }

        private void FrmBankaTransferi_Load(object sender, EventArgs e)
        {
            TxtTarih.Text=DateTime.Now.ToShortDateString();
        }
   
        void Temizle()
        {
            TxtAciklama.Text = "";
            TxtBelgeNo.Text = "";
            TxtCariAdi.Text = "";
            TxtCariKodu.Text = "";
            TxtHesapAdi.Text = "";
            TxtHesapno.Text = "";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            TxtTutar.Text = "";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }
    public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                TxtAciklama.Text = Banka.ACIKLAMA;
                TxtBelgeNo.Text = Banka.BELGENO;
                TxtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                TxtTransferTuru.Text = Banka.EVRAKTURU;
                TxtTutar.Text = Banka.TUTAR.ToString();
                if (Banka.GCKODU == "G") rbGelenhavale.Checked = true;
                if (Banka.GCKODU == "C") RbGidenHavlae.Checked = true;
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
    
        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                TxtCariKodu.Text = db.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
                TxtCariAdi.Text = db.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
    
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA = TxtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = TxtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = TxtTransferTuru.SelectedItem.ToString();
                if (rbGelenhavale.Checked) Banka.GCKODU = "G";
                if (RbGidenHavlae.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(TxtTarih.Text);
                Banka.TUTAR = Decimal.Parse(TxtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Banka);
                db.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = TxtAciklama.Text;
                if (rbGelenhavale.Checked) Cari.ALACAK = decimal.Parse(TxtTutar.Text);
                if (RbGidenHavlae.Checked) decimal.Parse(TxtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = TxtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(TxtTarih.Text);
                if (TxtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (TxtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                db.TBL_CARIHAREKETLERIs.InsertOnSubmit(Cari);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Para Transfer Kaydı İşlendi.");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                Banka.ACIKLAMA = TxtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = TxtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = TxtTransferTuru.SelectedItem.ToString();
                if (rbGelenhavale.Checked) Banka.GCKODU = "G";
                if (RbGidenHavlae.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(TxtTarih.Text);
                Banka.TUTAR = Decimal.Parse(TxtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == TxtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID);                Cari.ACIKLAMA = TxtAciklama.Text;
                if (rbGelenhavale.Checked) Cari.ALACAK = decimal.Parse(TxtTutar.Text);
                if (RbGidenHavlae.Checked) decimal.Parse(TxtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = TxtTransferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(TxtTarih.Text);
                if (TxtTransferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (TxtTransferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
                db.TBL_CARIHAREKETLERIs.DeleteOnSubmit(db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == TxtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID));
                db.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                db.SubmitChanges();
                Temizle();
            
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void TxtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }
    }
}