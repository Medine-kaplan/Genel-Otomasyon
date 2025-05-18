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

namespace Odev.Modul_Cek
{
    public partial class FrmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
         int CekId = -1; // CekId değeri başlangıçta -1 olarak ayarlanır, böylece yeni bir çek oluşturulacağını anlarız.
        int BankaId = -1;
        bool Edit = false; // Formun düzenleme modunda olup olmadığını belirten bir bayrak

        public FrmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void FrmKendiCekimiz_Load(object sender, EventArgs e)
        {
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();

        }
        void Temizle()
        {
            TxtAciklama.Text = "";
            TxtBanka.Text = "";
            Txtbelgeno.Text = "";
            txtCekNo.Text = "";
            TxtHesapNo.Text = "";
            TxtSube.Text = "";
            TxtTutar.Text = "";
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekId = -1;
            BankaId = -1;
            Edit = false; // Temizleme işlemi sonrası düzenleme modunu kapatıyoruz
            
        }
        public void Ac(int CekinIDsi)
        {
            try
            {
                CekId = CekinIDsi;
                Fonksiyonlar.TBL_CEKLER Cek;
                //TxtAciklama.Text = Cek.ACIKLAMA;
                //Txtbelgeno.Text = Cek.BELGENO;
                //txtCekNo.Text = Cek.CEKNO;
                //TxtTutar.Text = Cek.TUTAR.ToString();
                //TxtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                Edit = true;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
                Temizle();
            }
        }
        void Sil()
        {
            try
            {
                //db.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(db.TBL_BANKAHAREKETLERIs.FirstOrDefault(x => x.EVRAKID == CekId));
                //Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();
                ////db.TBL_CEKLERs.DeleteOnSubmit(Cek);
                ////db.SubmitChanges();
                //Mesajlar.Sil();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void BankaAc(int BankaninIDSİ)
        {
            try
            {
                BankaId = BankaninIDSİ;
                ////Fonksiyonlar.TBL_BANKALAR Banka;
                ////TxtBanka.Text = Banka.BANKAADI;
                ////TxtHesapNo.Text=Banka.HESAPNO;
                ////TxtSube.Text = Banka.SUBE;
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

                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();

                Cek.ACIKLAMA = TxtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BANKA = TxtBanka.Text;
                Cek.BELGENO = Txtbelgeno.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = TxtHesapNo.Text;
                Cek.SUBE = TxtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = Decimal.Parse(TxtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(TxtVadeTarihi.Text);
                //db.TBL_CEKLERs.InsertOnSubmit(Cek);
                //db.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " Nolu Çek Kayıt Edilmiştir.");
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                BankaHareketi.ACIKLAMA = txtCekNo.Text + "nolu ve " + TxtVadeTarihi.Text + "Vadeli Kendi Çekimiz.";
                BankaHareketi.BANKAID = BankaId;
                BankaHareketi.BELGENO = Txtbelgeno.Text;
                BankaHareketi.EVRAKID = Cek.ID;
                BankaHareketi.EVRAKTURU = "Kendi çekimiz";
                BankaHareketi.GCKODU = "C";
                BankaHareketi.TARIH = DateTime.Now;
                BankaHareketi.TUTAR = 0;
                BankaHareketi.SAVEDATE = DateTime.Now;
                Mesajlar.YeniKayit(txtCekNo.Text + "nolu kendi çekimizin banka kaydı yapılmıştır.");

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

                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();

                Cek.ACIKLAMA = TxtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BANKA = TxtBanka.Text;
                Cek.BELGENO = Txtbelgeno.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = TxtHesapNo.Text;
                Cek.SUBE = TxtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = Decimal.Parse(TxtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(TxtVadeTarihi.Text);
                //db.TBL_CEKLERs.InsertOnSubmit(Cek);
                //db.SubmitChanges();
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                BankaHareketi.ACIKLAMA = txtCekNo.Text + "nolu ve " + TxtVadeTarihi.Text + "Vadeli Kendi Çekimiz.";
                BankaHareketi.BANKAID = BankaId;
                BankaHareketi.BELGENO = Txtbelgeno.Text;
                BankaHareketi.EVRAKID = Cek.ID;
                BankaHareketi.EVRAKTURU = "Kendi çekimiz";
                BankaHareketi.GCKODU = "C";
                BankaHareketi.TARIH = DateTime.Now;
                BankaHareketi.TUTAR = 0;
                BankaHareketi.SAVEDATE = DateTime.Now;
                Mesajlar.Guncelle(true);
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekId > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekId > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.BankaListesi(true);
            if (id>0)
            {
                BankaAc(id);
                //AnaForm.Aktarma = -1;
            }
        }
    }
}