using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq ;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Kasa
{
    public partial class FrmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar =new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar Numaralar=new Fonksiyonlar.Numaralar();

        bool Edit = false;
        int SecimID = -1;


        public FrmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            TxtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            Listele();
        }

        void Temizle()
        {
            TxtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            TxtKasaAdi.Text = "";
            TxtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();


        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new Fonksiyonlar.TBL_KASALAR();
                Kasa.ACIKLAMA = TxtAciklama.Text;
                Kasa.KASAADI = TxtKasaAdi.Text;
                Kasa.KASAKODU = TxtKasaKodu.Text;
                Kasa.SAVEDATE=DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                db.TBL_KASALARs.InsertOnSubmit(Kasa);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni kasa kaydı oluşturulmuştur.");
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
                Fonksiyonlar.TBL_KASALAR Kasa = db.TBL_KASALARs.First(s => s.ID == SecimID);
                Kasa.ACIKLAMA = TxtAciklama.Text;
                Kasa.KASAADI = TxtKasaAdi.Text;
                Kasa.KASAKODU = TxtKasaKodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
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
                db.TBL_KASALARs.DeleteOnSubmit(db.TBL_KASALARs.First(s => s.ID == SecimID));
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
                TxtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                TxtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                TxtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }
    
    void Listele()
        {
            var Lst = from s in db.TBL_KASALARs
                      select s;
            Liste.DataSource = Lst;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKasaAdi.Text != "" && TxtAciklama.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else YeniKaydet();
            }
            else MessageBox.Show("Kasa Adı Ve Açıklama Girilmesi Gerekmektedir.", "İŞLEM HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}