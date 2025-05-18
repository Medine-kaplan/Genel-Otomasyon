using Odev.Fonksiyonlar;
using System;
using System.Windows.Forms;

namespace Odev.Modul_Fatura
{
    public partial class FrmSatisFaturasi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;
        int IrsalıyeID = -1;
        string OdemeYeri = "";
        bool Edit = false;
        bool IrsalieAc = false;

        void Temizle()
        {
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsalıyeID = -1;
            OdemeYeri = "";
            Edit = false;
            IrsalieAc = false;
            TxtAciklama.Text = "";
            TxtAraToplam.Text = "";
            TxtCariAdi.Text = "";
            TxtCariKodu.Text = "";
            TxtFaturaNo.Text = "";
            TxtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            TxtFaturaTuru.SelectedIndex = 0;
            TxtGenelToplam.Text = "0.00";
            TxtHesapAdi.Text = "";
            TxtHesapNO.Text = "";
            TxtIrsalıyeNo.Text = "";
            TxtIrsalıyeTarihi.Text = DateTime.Now.ToShortDateString();
            TxtKasaAdi.Text = "";
            TxtKasaKodu.Text = "";
            TxtKDV.Text = "0.00";
            TxtOdemeYeri.SelectedIndex = 0;
            AnaForm.Aktarma = -1;

        }
        public FrmSatisFaturasi()
        {
            InitializeComponent();
        }
        public FrmSatisFaturasi(bool Ac, int ID,bool Irsaliye)
        {
            InitializeComponent();
            Edit = Ac;
            if (Irsaliye) IrsalıyeID = ID;
            else FaturaID = ID;
            IrsalieAc = Irsaliye;
            this.Shown+= FrmSatisFaturasi_Shown;

        }
        void StokGetir()
        {
            //Fonksiyonlar.TBL_STOKLAR Stok = db.TBL_STOKLARs.First(s => s.ID == StokID);

            //     gridView1.AddNewRow();
            //     gridView1.SetFocusedRowCellValue("MIKTAR", Stok.STOKBARKOD);
            //     gridView1.SetFocusedRowCellValue("BARKOD", Stok.STOKKODU);
            //     gridView1.SetFocusedRowCellValue("STOKADI", Stok.STOKADI);
            //     gridView1.SetFocusedRowCellValue("BIRIM", Stok.STOKBIRIM);
            //     gridView1.SetFocusedRowCellValue("BIRIMFIYAT", Stok.STOKSATISFIYAT);
            //     gridView1.SetFocusedRowCellValue("KDV", Stok.STOKSATISKDV);


        }
       
        void FaturaGetir()
        {
            try
            {

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
            private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniFaturaKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void TxtCariAdi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtOdemeYeri_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSatisFaturasi_Load(object sender, EventArgs e)
        {
            TxtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            TxtIrsalıyeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnButonSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //// var stoklar = db.TBL_STOKLAR.ToList();
            // int StokID = Formlar.StokListesi(true);
            // if (StokID > 0)
            // {
            //     Fonksiyonlar.TBL_STOKLAR Stok = db.TBL_STOKLARs.First(s => s.ID == StokID);

            //     gridView1.AddNewRow();
            //     gridView1.SetFocusedRowCellValue("MIKTAR", Stok.STOKBARKOD);
            //     gridView1.SetFocusedRowCellValue("BARKOD", Stok.STOKKODU);
            //     gridView1.SetFocusedRowCellValue("STOKADI", Stok.STOKADI);
            //     gridView1.SetFocusedRowCellValue("BIRIM", Stok.STOKBIRIM);
            //     gridView1.SetFocusedRowCellValue("BIRIMFIYAT", Stok.STOKSATISFIYAT);
            //     gridView1.SetFocusedRowCellValue("KDV", Stok.STOKSATISKDV);





        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        void YeniFaturaKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = new Fonksiyonlar.TBL_FATURALAR();
                Fatura.ACIKLAMA = TxtAciklama.Text;
                Fatura.CARIKODU = TxtCariKodu.Text;
                Fatura.FATURANO = TxtFaturaNo.Text;
                Fatura.FATURATURU = "Satış Faturası";
                Fatura.GENELTOPLAM = decimal.Parse(TxtGenelToplam.Text);
                Fatura.IRSALIYEID = IrsalıyeID;
                Fatura.ODEMEYERI = OdemeYeri;
                Fatura.ODEMEYERIID = OdemeID;
                Fatura.TARIHI = DateTime.Parse(TxtFaturaTarihi.Text);
                Fatura.SAVEDATE = DateTime.Now;
                Fatura.SAVEUSER = AnaForm.UserID;
                // db.TBL_FATURALARs
                FaturaID = Fatura.ID;
                if (IrsalıyeID<0)
                {
                    Fonksiyonlar.TBL_IRSALIYELER IRSALIYE = new Fonksiyonlar.TBL_IRSALIYELER();
                    IRSALIYE.ACIKLAMA = TxtAciklama.Text;
                    IRSALIYE.CARIKODU = TxtCariKodu.Text;
                    IRSALIYE.FATURAID = Fatura.ID;
                    IRSALIYE.IRSALIYENO = TxtIrsalıyeNo.Text;
                    IRSALIYE.TARIHI = DateTime.Parse(TxtIrsalıyeTarihi.Text);
                    IRSALIYE.SAVEDATE = DateTime.Now;
                    IRSALIYE.SAVEUSER= AnaForm.UserID;
                    IrsalıyeID = IRSALIYE.ID;

                }
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void FrmSatisFaturasi_Shown(object sender, EventArgs e)
        {
            if (Edit) FaturaGetir();
        }
    }
}
