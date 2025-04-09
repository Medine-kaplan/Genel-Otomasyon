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
    public partial class FrmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    { Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;
        public FrmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();

        }

        void Temizle()
        {
            TxtAdres.Text = "";
            TxtBankaAdi.Text = "";
            TxtHesapTuru.Text = "";
            TxtHesapNO.Text = "";
            TxtIban.Text = "";
            TxtBankaSubesi.Text = "";
            TxtSubeTelefon.Text = "";
            TxtYetkiliTemsilci.Text = "";
            TxtYTMail.Text = "";
            Edit = false;
            SecimID = -1;
        }

        void Listele()
        {
            var lst = from s in db.TBL_BANKALARs
                      select s;
            Liste.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = new Fonksiyonlar.TBL_BANKALAR();
                Banka.ADRES = TxtAdres.Text;
                Banka.BANKAADI = TxtBankaAdi.Text;
                Banka.HESAPADI = TxtHesapTuru.Text;
                Banka.HESAPNO = TxtHesapNO.Text;
                Banka.IBAN = TxtIban.Text;
                Banka.SUBE = TxtBankaSubesi.Text;
                Banka.TEL = TxtSubeTelefon.Text;
                Banka.TEMSILCI = TxtYetkiliTemsilci.Text;
                Banka.TEMSILCI = TxtYTMail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKALARs.InsertOnSubmit(Banka);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Banka Kaydı Açılmıştır.");
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
                Fonksiyonlar.TBL_BANKALAR Banka = db.TBL_BANKALARs.First(s => s.ID == SecimID);
                Banka.ADRES = TxtAdres.Text;
                Banka.BANKAADI = TxtBankaAdi.Text;
                Banka.HESAPADI = TxtHesapTuru.Text;
                Banka.HESAPNO = TxtHesapNO.Text;
                Banka.IBAN = TxtIban.Text;
                Banka.SUBE = TxtBankaSubesi.Text;
                Banka.TEL = TxtSubeTelefon.Text;
                Banka.TEMSILCI = TxtYetkiliTemsilci.Text;
                Banka.TEMSILCI = TxtYTMail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
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
                db.TBL_BANKALARs.DeleteOnSubmit(db.TBL_BANKALARs.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                if (SecimID > 0) Ac();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = db.TBL_BANKALARs.First(s => s.ID == SecimID);
                TxtAdres.Text = Banka.ADRES;
                TxtBankaAdi.Text = Banka.BANKAADI;
                TxtHesapTuru.Text = Banka.HESAPADI;
                TxtHesapNO.Text = Banka.HESAPNO;
                TxtIban.Text = Banka.IBAN;
                TxtBankaSube.Text = Banka.SUBE;
                TxtSubeTelefon.Text = Banka.TEL;
                TxtYetkiliTemsilci.Text = Banka.TEMSILCI;
                TxtYTMail.Text = Banka.TEMSILCIMAIL;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID> 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void groupControl2_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}