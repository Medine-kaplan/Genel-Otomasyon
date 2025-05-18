using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Windows.Forms;
using Odev.Fonksiyonlar;

namespace Odev.Modul_Cek
{
    public partial class FrmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        
        int CariId = -1;
        int CekId = -1;
        bool Edit = false;

        internal DatabaseDataContext Db { get => db; set => db = value; }

        public FrmMusteriCeki()
        {
            InitializeComponent();
        }

        private void textEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }
        void Temizle()
        {
            TxtAciklama.Text = "";
            TxtAsilBorclu.Text = "";
            TxtBanka.Text = "";
            TxtBelgeNo.Text = "";
            TxtCariAdi.Text = "";
            TxtCariKodu.Text = "";
            TxtCekNo.Text = "";
            TxtCekTuru.SelectedIndex = 0;
            TxtHesapNo.Text = "";
            TxtSube.Text = "";
            TxtTutar.Text = "";
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariId = -1;
            CekId = -1;
          //  AnaForm.Aktarma = -1;


        }
        
        private void FrmMusteriCeki_Load(object sender, EventArgs e)
        {
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();

        }

        void YeniCekKaydet()
        {
            try
            {

                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();
                Cek.ACIKLAMA = TxtAciklama.Text;
                if (TxtCekTuru.SelectedIndex == 0) Cek.ACKODU = "A";
                if (TxtCekTuru.SelectedIndex == 1) Cek.ACKODU = "C";
                Cek.ALINANCARIID = CariId;
                Cek.BANKA = TxtBanka.Text;
                Cek.BELGENO = TxtBelgeNo.Text;
                Cek.CEKNO = TxtCekNo.Text;
                Cek.DURUMU = "Potföy";
                Cek.HESAPNO = TxtHesapNo.Text;
                Cek.SUBE = TxtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.VADETARIHI = DateTime.Parse(TxtVadeTarihi.Text);
                Cek.TUTAR = decimal.Parse(TxtTutar.Text);
                Cek.TIPI = "Müşteri Çeki";
                Cek.SAVEDATE = DateTime.Now;
               // Cek.SAVEUSER = AnaForm.UserID;
                //var tablo = db.TBL_CEKLERs;
                //  System.Data.Linq.Table<TBL_CEKLER> tablo = db.TBL_CEKLERs;
                //tablo.InsertOnSubmit(Cek);
                //db.TBL_CEKLERs.InsertOnSubmit(Cek);
                Mesajlar.YeniKayit(TxtCekNo.Text + " Nolu Çek Kaydı Oluşturuldu.");
                //db.TBL_CEKLERs.InsertOnSubmit(Cek);
                //db.SubmitChanges();
                //Temizle();  
                Fonksiyonlar.TBL_CARIHAREKETLERI CarHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CarHareket.ACIKLAMA = TxtBelgeNo.Text + "belge numaralı ve" + TxtCekNo.Text + "cek Numaralı müşteri çeki";
                CarHareket.CARIID = CariId;
                CarHareket.EVRAKID = Cek.ID;
                //CarHareket.EVRAKID=Cek.ID;
                CarHareket.EVRAKTURU = " Müşteri Çeki";
                CarHareket.TARIH = DateTime.Now;
                CarHareket.TIPI = "MC";
                CarHareket.SAVEDATE = DateTime.Now;
             //   CarHareket.SAVEUSER = AnaForm.UserID;
                Mesajlar.YeniKayit(TxtCekNo.Text + "No'lu çeki cari kaydı gerçekleşmiştir.");

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void guncelle()
        { }
        void CariAc(int ID)
        {
        //    CariId = ID;
        //    Fonksiyonlar.TBL_CARILER Cari=db.TBL_CARILERs.First(s => s.ID == CariId);
        //    TxtCariAdi.Text = Cari.CARIADI;
        //    TxtCariKodu.Text = Cari.CARIKODU;   
        }
        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int id= //Formlar.CariListesi(true);
            //if (id>0)
            //{
            //    CariAc(id);
            //    AnaForm.Aktarma = -1;
                    
            //}
            //Form FrmCariListesi = new FrmCariListesi();
            //.Show();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit) guncelle();
            else YeniCekKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit&CekId>0&Mesajlar.Sil()==DialogResult.Yes)
            {
                
            }
            Temizle();
        }
    
    }



}