using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Stok
{
    public partial class FrmStokKartı : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar=new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar Numaralar = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();


        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupId = -1;
        int StokId = -1;

        public FrmStokKartı()
        {
            InitializeComponent();
        }

    private void FrmStokKartı_Load(object sender, EventArgs e)
        {
            txtstokkodu.Text = Numaralar.StokKodNumarasi();
            Mesajlar.ForAcilis(this.Text);
        }
   
    void temizle()
        {
            txtstokkodu.Text = Numaralar.StokKodNumarasi();
            TxtStokAdi.Text = "";
            TxtSatisKDV.Text = "0";
            TxtSatişFiyati.Text = "0";
            TxtGrupKodu.Text = "";
            TxtGrupAdı.Text = "";
            TxtBirim.SelectedIndex = 0;
            TxtBarkod.Text = "";
            TxtAlisKDV.Text = "0";
            TxtAlisFiyati.Text = "0";
            pictureBox1.Image = null;
            Edit = false;
            Resim= false;
            GrupId = -1;
            StokId = -1;
            AnaForm.Aktarma = -1;

        }

    void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.Jpeg)|*.Jpeg";
            if (Dosya.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

    private void BtnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        public void Ac(int ID)
            {
            Edit = true;
            StokId = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = db.TBL_STOKLARs.First(s => s.ID == StokId);
            GrupAc(Stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.STOKRESIM.ToArray());
            TxtAlisFiyati.Text = Stok.STOKALISFIYAT.ToString();
            TxtAlisKDV.Text = Stok.STOKALISKDV.ToString();
            TxtBarkod.Text = Stok.STOKBARKOD;
            TxtBirim.Text = Stok.STOKBIRIM;
            TxtSatişFiyati.Text = Stok.STOKSATISFIYAT.ToString();
            TxtSatisKDV.Text = Stok.STOKSATISKDV.ToString();
            TxtStokAdi.Text = Stok.STOKADI;
            txtstokkodu.Text = Stok.STOKKODU;
        }

    void GrupAc(int ID)
        {
            GrupId = ID;
            TxtGrupAdı.Text = db.TBL_STOKGRUPLARIs.First(s => s.ID == GrupId).GRUPADI;
            TxtGrupKodu.Text = db.TBL_STOKGRUPLARIs.First(s => s.ID == GrupId).GRUPKODU;
        }
    void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new Fonksiyonlar.TBL_STOKLAR();
                Stok.STOKADI = TxtStokAdi.Text;
                Stok.STOKALISFIYAT = decimal.Parse(TxtAlisFiyati.Text);
                Stok.STOKALISKDV = decimal.Parse(TxtAlisKDV.Text);
                Stok.STOKBARKOD = TxtBarkod.Text;
                Stok.STOKBIRIM = TxtBirim.Text;
                Stok.STOKGRUPID = GrupId;
                Stok.STOKKODU = txtstokkodu.Text;
                Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(TxtSatişFiyati.Text);
                Stok.STOKSATISKDV = decimal.Parse(TxtSatisKDV.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                db.TBL_STOKLARs.InsertOnSubmit(Stok);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Stok Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_STOKLAR Stok = db.TBL_STOKLARs.First(s => s.ID == StokId);
                Stok.STOKADI = TxtStokAdi.Text;
                Stok.STOKALISFIYAT = decimal.Parse(TxtAlisFiyati.Text);
                Stok.STOKALISKDV = decimal.Parse(TxtAlisKDV.Text);
                Stok.STOKBARKOD = TxtBarkod.Text;
                Stok.STOKBIRIM = TxtBirim.Text;
                Stok.STOKGRUPID = GrupId;
                Stok.STOKKODU = txtstokkodu.Text;
              if(Resim)  Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(TxtSatişFiyati.Text);
                Stok.STOKSATISKDV = decimal.Parse(TxtSatisKDV.Text);
                Stok.STOKEDITDATE = DateTime.Now;
                Stok.STOKEDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                temizle();
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
                db.TBL_STOKLARs.DeleteOnSubmit(db.TBL_STOKLARs.First(s => s.ID == StokId));

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

        }

        private void txtstokkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID>0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void TxtGrupKodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokId > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit&&StokId>0&& Mesajlar.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void FrmStokKartı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.ForKapanis(this.Text);
        }
    }
}