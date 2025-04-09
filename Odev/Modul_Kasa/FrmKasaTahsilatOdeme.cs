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

namespace Odev.Modul_Kasa
{
    public partial class FrmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int IslemId = -1;
        int CariHareketID = -1;
        int KasaID = -1;    
        int CariID = -1;

        public FrmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            TxtAciklama.Text = "";
            TxtBelgeMakbuz.Text = "";
            TxtCariAdi.Text = "";
            TxtCariKodu.Text = "";
            TxtİslemTuru.SelectedIndex = 0;
            TxtKasaAdi.Text = "";
            TxtKasaKodu.Text = "";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            TxtTutar.Text = "0";
            Edit = false;
            IslemId = -1;
            KasaID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                TxtKasaAdi.Text = db.TBL_KASALARs.First(s=> s.ID == KasaID).KASAADI;
                TxtKasaKodu.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {

               
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                TxtCariAdi.Text = db.TBL_CARILERs.First(s => s.ID == KasaID).CARIADI;
                TxtCariKodu.Text = db.TBL_CARILERs.First(s => s.ID == KasaID).CARIKODU;

            }
            catch (Exception)
            {

                CariID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                KasaHareketi.ACIKLAMA = TxtAciklama.Text;
                KasaHareketi.BELGENO = TxtBelgeMakbuz.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = TxtİslemTuru.SelectedIndex.ToString();
                if (TxtİslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (TxtİslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.SAVEDATE = DateTime.Now;
                KasaHareketi.SAVEEDIT = AnaForm.UserID;
                KasaHareketi.TARIH = DateTime.Parse(TxtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(TxtTutar.Text);
                db.TBL_KASAHAREKETLERIs.InsertOnSubmit(KasaHareketi);
                db.SubmitChanges();
                Mesajlar.YeniKayit(TxtİslemTuru.SelectedItem.ToString() + "Yeni Kasa İşlemi Olarak İşlenmiştir.");
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = TxtBelgeMakbuz.Text + "Belge Numaralı" + TxtİslemTuru.SelectedItem.ToString() + "İşlemi";
                if (TxtİslemTuru.SelectedIndex == 0) CariHareket.ALACAK = Decimal.Parse(TxtTutar.Text);
                if (TxtİslemTuru.SelectedIndex == 1) CariHareket.BORC = Decimal.Parse(TxtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = TxtİslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(TxtTarih.Text);
                if (TxtİslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (TxtİslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
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
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemId);

                KasaHareketi.ACIKLAMA = TxtAciklama.Text;
                KasaHareketi.BELGENO = TxtBelgeMakbuz.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = TxtİslemTuru.SelectedIndex.ToString();
                if (TxtİslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (TxtİslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.SAVEDATE = DateTime.Now;
                KasaHareketi.SAVEEDIT = AnaForm.UserID;
                KasaHareketi.TARIH = DateTime.Parse(TxtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(TxtTutar.Text);
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = TxtBelgeMakbuz.Text + "Belge Numaralı" + TxtİslemTuru.SelectedItem.ToString() + "İşlemi";
                if (TxtİslemTuru.SelectedIndex == 0) CariHareket.ALACAK = Decimal.Parse(TxtTutar.Text);
                if (TxtİslemTuru.SelectedIndex == 1) CariHareket.BORC = Decimal.Parse(TxtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = TxtİslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(TxtTarih.Text);
                if (TxtİslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (TxtİslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
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
                db.TBL_KASAHAREKETLERIs.DeleteOnSubmit(db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemId));
                db.TBL_CARIHAREKETLERIs.DeleteOnSubmit(db.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        public void Ac( int HareketID)
        {
            try
            {
                Edit = true;
                IslemId = HareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemId);
                CariHareketID = db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == KasaHareketi.EVRAKTURU && s.EVRAKID == IslemId).ID;
                MessageBox.Show("Cari hareket id:" + CariHareketID.ToString());
                TxtAciklama.Text = KasaHareketi.ACIKLAMA;
                TxtBelgeMakbuz.Text = KasaHareketi.BELGENO;
                if (KasaHareketi.EVRAKTURU == "Kasa Tahsilat") TxtİslemTuru.SelectedIndex = 0;
                if (KasaHareketi.EVRAKTURU == "Kasa Ödeme") TxtİslemTuru.SelectedIndex = 1;
                TxtTarih.Text = KasaHareketi.TARIH.Value.ToString();
                TxtTutar.Text = KasaHareketi.TUTAR.Value.ToString();
                KasaAc(KasaHareketi.KASAID.Value);
                CariAc(KasaHareketi.CARIID.Value);
            }
            catch (Exception e)
            {

                Temizle();
                Mesajlar.Hata(e);
            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (Edit && IslemId > 0 && CariHareketID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemId > 0 && CariHareketID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void TxtİslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id>0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}