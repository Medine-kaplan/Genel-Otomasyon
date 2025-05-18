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
    public partial class FrmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    { Fonksiyonlar.DatabaseDataContext db=new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public FrmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void FrmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            TxtTarih.Text=DateTime.Now.ToShortDateString();
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }
        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari;
                //TxtCariAdi.Text = Cari.CARIADI;
                //ttxtcarikodu.Text = Cari.CARIKODU;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }
        void CariGetir(int ID)
        {
            try
            {
                CariID = ID;
                //Fonksiyonlar.TBL_CARILER Cek;
                //TxtBanka.Text=Cek.Banka;
                //TxtCekNo.Text=cek

            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }
    
    void Temizle()
        {
            TxtBanka.Text = "";
            TxtBelgeno.Text = "";
            TxtCariAdi.Text = "";
            TxtCekNo.Text = "";
            ttxtcarikodu.Text = "";
            TxtSube.Text = "";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            txtTtutar.Text = "";
            TxtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }
    
    
        void YeniKaydet()
        {
            //try
            //{
            //    Fonksiyonlar.TBL_CEKLER Cek;
            //    Cek.VERILENCARIID = CariID;
            //    Cek.VERILENCARI_TARIHI = DateTime.Parse(TxtTarih.Text);


            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
  
        void Guncelle()
        {
            //try
            //{
            //    Fonksiyonlar.TBL_CEKLER Cek;
            //    Cek.VERILENCARIID = CariID;
            //    Cek.VERILENCARI_TARIHI = DateTime.Parse(TxtTarih.Text);


            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                //Fonksiyonlar.TBL_CEKLER Cek;
                //TxtBanka.Text=Cek.Banka;
                //TxtCekNo.Text=cek.CEKNO;
                //txtTtutar.Text=cek.TUTAR.ToString();
                //TxtSube.Text=Cek.SUBE;
                //TxtVadeTarihi.Text=Cek.VADE_TARIHI.ToString();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }
            public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                CekGetir(CekID);
            }
            catch (Exception EX)
            {
                Mesajlar.Hata(EX);
                Temizle();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit&& Mesajlar.Guncelle()==DialogResult.Yes && CariID>0 && CekID > 0)
            {
                Guncelle();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            else if (!Edit && CariID > 0 && CekID > 0)
            {
                YeniKaydet();
                Mesajlar.YeniKayit("Yeni Kayıt Girişi");
                Temizle();
            }
            else
            {
                Mesajlar.Hata(new Exception("Lütfen gerekli alanları doldurunuz"));
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && Mesajlar.Sil() == DialogResult.Yes && CariID > 0 && CekID > 0)
            {
             
            }

            
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ttxtcarikodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0) CariAc(ID);
           // AnaForm.Aktarma();
        }
    }
}