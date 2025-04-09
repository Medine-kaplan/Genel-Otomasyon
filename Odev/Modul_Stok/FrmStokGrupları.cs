using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Odev.Modul_Stok
{
    public partial class FrmStokGrupları : DevExpress.XtraEditors.XtraForm
    {


        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();


        public bool secim = false;
        int secimID = -1;
        bool Edit = false;

        public FrmStokGrupları()
        {
            InitializeComponent();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokGrupları_Load(object sender, EventArgs e)
        {
            listele();
            
        }
        void listele()
        {
            var lst = from s in db.TBL_STOKGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }
        void temizle()
        {
            TxtGrupKod.Text = " ";
            TxtGrupAd.Text = " ";
            Edit = false;
            listele();


        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = new Fonksiyonlar.TBL_STOKGRUPLARI();
                Grup.GRUPADI = TxtGrupAd.Text;
                Grup.GRUPKODU = TxtGrupKod.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;
                db.TBL_STOKGRUPLARIs.InsertOnSubmit(Grup);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu");
                temizle();
                
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
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = db.TBL_STOKGRUPLARIs.First(s => s.ID == secimID);
                Grup.GRUPKODU = TxtGrupKod.Text;
                Grup.GRUPADI = TxtGrupAd.Text;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                Grup.GRUPEDITDATE = DateTime.Now;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

        }

        void sil()
        {
            try
            {
                db.TBL_STOKGRUPLARIs.DeleteOnSubmit(db.TBL_STOKGRUPLARIs.First(s => s.ID == secimID));
                db.SubmitChanges();
                temizle();
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
            if (Edit && secimID > 0 && Mesajlar.Sil() == DialogResult.Yes) sil();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }
   
    
       void Sec()
        {
            try
            {
                Edit = true;
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TxtGrupAd.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                TxtGrupKod.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                Edit= false;
                secimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {

            Sec();
            if (secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }
    }
    
}