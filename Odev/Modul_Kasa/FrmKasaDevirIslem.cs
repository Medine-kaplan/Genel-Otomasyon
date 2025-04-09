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

namespace Odev.Modul_Kasa
{
    public partial class FrmKasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;

        public FrmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void FrmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            TxtAciklama.Text = "";
            TxtBelgeMakbuz.Text = "";
            TxtKasaAdi.Text = "";
            TxtKasaKodu.Text = "";
            TxtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                Hareket.ACIKLAMA = TxtAciklama.Text;
                Hareket.BELGENO = TxtBelgeMakbuz.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (RbCikis.Checked) Hareket.GCKODU = "C";
                if (RbGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(TxtTarih.Text);
                Hareket.TUTAR = decimal.Parse(TxtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEEDIT = AnaForm.UserID;
                db.TBL_KASAHAREKETLERIs.InsertOnSubmit(Hareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Devir kartı hareket kaydı işlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = TxtAciklama.Text;
                Hareket.BELGENO = TxtBelgeMakbuz.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (RbCikis.Checked) Hareket.GCKODU = "C";
                if (RbGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(TxtTarih.Text);
                Hareket.TUTAR = decimal.Parse(TxtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEEDIT = AnaForm.UserID;
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

                db.TBL_KASAHAREKETLERIs.DeleteOnSubmit(db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }


        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                TxtKasaAdi.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                TxtKasaKodu.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;

            }
            catch (Exception)
            {


            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                TxtAciklama.Text = Hareket.ACIKLAMA;
                TxtBelgeMakbuz.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                TxtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                TxtTutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G") RbGiris.Checked = true;
                if (Hareket.GCKODU == "C") RbCikis.Checked = true;

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

        private void TxtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                KasaAc(ID);
                AnaForm.Aktarma = -1;

            }
        }

        private void TxtBelgeMakbuz_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}