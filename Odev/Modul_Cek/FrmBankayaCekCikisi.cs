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
    public partial class FrmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CekID = -1;
        int BankaID = -1;
        Fonksiyonlar.TBL_CEKLER Cek;
        public FrmBankayaCekCikisi()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            TxtBanka.Text = "";
            TxtBankaAdi.Text = "";
            TxtBelgeno.Text = "";
            TxtCekNo.Text = "";
            xtHesapNo.Text = "";
            TxtSube.Text = "";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            txtTtutar.Text = "";
            Cek = null;
            CekID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }
        private void FrmBankayaCekCikisi_Load(object sender, EventArgs e)
        {

        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                //Cek = db.TBL_CEKLERs.First(se=> s.ID == CekID);
                TxtBanka.Text = Cek.BANKA;
                TxtCekNo.Text = Cek.CEKNO;
                TxtSube.Text = Cek.SUBE;
                txtTtutar.Text = Cek.TUTAR.Value.ToString();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }
       
       void BankaGetir(int ID)
        {
            try
            {
                BankaID = ID;
                //xtHesapNo.Text=db.TBL_BANKALARs.first(s => s.ID == BankaID).HESAPNO;
                //TxtBankaAdi.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).BANKAADI;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket=new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = TxtBelgeno.Text + "Belge Numaralı ve" + TxtCekNo.Text + "Çekin Bnakaya Çıkışı";
               Hareket.BANKAID = BankaID;
                Hareket.BELGENO = TxtBelgeno.Text;
                Hareket.EVRAKID = CekID;
                Hareket.EVRAKTURU = "Bankaya Çek";
                Hareket.GCKODU = "G";
                Hareket.TARIH = DateTime.Parse(TxtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTtutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                Mesajlar.YeniKayit(TxtCekNo.Text + "nolu çekin banka hareket kaydı işlenmiştir.");
                Cek.VERILENBANKA_BELGENO = TxtBelgeno.Text;
                Cek.VERILENBANKA_TARIHI = DateTime.Parse(TxtTarih.Text);
                Cek.VERILENBANKAID = BankaID;
                Cek.DURUMU = "Bannkada";
                Mesajlar.YeniKayit(TxtCekNo.Text + "nolu çekin durum güncellenmesi yapılmıştır.");



            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.BankaListesi(true);
            if (ID>0)
            {
                BankaGetir(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void TxtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CekListesi(true);
            if (ID > 0)
            {
               CekGetir(ID);
            }
            AnaForm.Aktarma = -1;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Cek!=null && CekID>0&&BankaID>0)
            {
                YeniKaydet();
            }
        }
    }
}