using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Cari
{
    public partial class FrmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numaralar Numaralar = new Fonksiyonlar.Numaralar();

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;



        public FrmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            TxtCariKodu.Text = Numaralar.CariKodNumarasi();
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";
            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
            txtcariadi.Text = Numaralar.CariKodNumarasi(); 
            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {

                Fonksiyonlar.TBL_CARILER Cari = new Fonksiyonlar.TBL_CARILER();
                Cari.ADRES = TxtAdres.Text;
                Cari.CARIADI = txtcariadi.Text;
                Cari.CARIKODU = TxtCariKodu.Text;
                Cari.FAX1 = TxtFax1.Text;
                Cari.FAX2 = TxtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = TxtIlce.Text;
                Cari.MAILINFO = TxtMailİnfo.Text;
                Cari.SEHIR = TxtSehir.Text;
                Cari.TELEFON1 = TxtTelefon1.Text;
                Cari.Telefon2 = TxtTelefon2.Text;
                Cari.ULKE = TxtUlke.Text;
                Cari.VERGIDAIRESI = Txtvergidairesi.Text;
                Cari.VERGINO = txtvergino.Text;
                Cari.WEBADRES=TxtWebAdres.Text;
                Cari.YETKILI1 = TxtYetkili1.Text;
                Cari.YETKILI2 = TxtYetkili2.Text;
                Cari.YERKILIEMAIL1 = TxtYetkiliEmail1.Text;
                Cari.YETKILIMAIL2 = TxtYetkiliEmail1.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                db.TBL_CARILERs.InsertOnSubmit(Cari);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturulmuştur. ");
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

                Fonksiyonlar.TBL_CARILER Cari = db.TBL_CARILERs.First(s=>s.ID==CariID);
                Cari.ADRES = TxtAdres.Text;
                Cari.CARIADI = txtcariadi.Text;
                Cari.CARIKODU = TxtCariKodu.Text;
                Cari.FAX1 = TxtFax1.Text;
                Cari.FAX2 = TxtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = TxtIlce.Text;
                Cari.MAILINFO = TxtMailİnfo.Text;
                Cari.SEHIR = TxtSehir.Text;
                Cari.TELEFON1 = TxtTelefon1.Text;
                Cari.Telefon2 = TxtTelefon2.Text;
                Cari.ULKE = TxtUlke.Text;
                Cari.VERGIDAIRESI = Txtvergidairesi.Text;
                Cari.VERGINO = txtvergino.Text;
                Cari.WEBADRES = TxtWebAdres.Text;
                Cari.YETKILI1 = TxtYetkili1.Text;
                Cari.YETKILI2 = TxtYetkili2.Text;
                Cari.YERKILIEMAIL1 = TxtYetkiliEmail1.Text;
                Cari.YETKILIMAIL2 = TxtYetkiliEmail1.Text;
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
                db.TBL_CARILERs.DeleteOnSubmit(db.TBL_CARILERs.First(s => s.ID == CariID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);

            }
        }
    
   public void Ac(int id)
        {
            try
            {
                Edit = true;
                CariID = id;
                Fonksiyonlar.TBL_CARILER Cari = db.TBL_CARILERs.First(s => s.ID == CariID);
                TxtAdres.Text = Cari.ADRES;
                txtcariadi.Text = Cari.CARIADI;
                TxtCariKodu.Text = Cari.CARIKODU;
                TxtFax1.Text = Cari.FAX1;
                TxtFax2.Text = Cari.FAX2;
                TxtIlce.Text = Cari.ILCE;
                TxtMailİnfo.Text = Cari.MAILINFO;
                TxtSehir.Text = Cari.SEHIR;
                TxtTelefon1.Text = Cari.TELEFON1;
                TxtTelefon2.Text = Cari.Telefon2;
                TxtUlke.Text = Cari.ULKE;
                Txtvergidairesi.Text = Cari.VERGIDAIRESI;
                txtvergino.Text = Cari.VERGINO;
                TxtWebAdres.Text = Cari.WEBADRES;
                TxtYetkili1.Text = Cari.YETKILI1;
                TxtYetkili2.Text = Cari.YETKILI2;
                TxtYetkiliEmail1.Text = Cari.YERKILIEMAIL1;
                TxtYetkiliMail2.Text = Cari.YETKILIMAIL2;
                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = db.TBL_CARIGRUPLARIs.First(s => s.ID == GrupID);
                TxtCariGrupKod.Text = Grup.GRUPADI;
                TxtCariGrupKodu.Text = Grup.GRUPKODU;
;
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void TxtCariGrupKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
           if (ID>0)
                {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;

        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID>0)
            {
                Ac(ID);

            }
            AnaForm.Aktarma = -1;
        }
    }

    
}