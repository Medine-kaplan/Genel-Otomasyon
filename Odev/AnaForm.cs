using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar=new Fonksiyonlar.Formlar();
        public static Fonksiyonlar.TBL_KULLANICILAR Kullanici;
        public static int UserID = -1;
        public static int Aktarma = -1;

        public AnaForm()
        {
            InitializeComponent();
        }
        public AnaForm(Fonksiyonlar.TBL_KULLANICILAR GelenKullanici)
        {

            InitializeComponent();
            Kullanici = GelenKullanici;
            UserID = Kullanici.ID;
            txtkulanici.Caption = Kullanici.KULLANICI;
            if (Kullanici.KODU=="Normal")
            {
                btnkullanici.Visibility = BarItemVisibility.Never;
            }
        
        
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnStokkartı_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void btnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void BtnStokGruplar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void BtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void BarBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void BarBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void BarBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void BarBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
        //    string currentDate = DateTime.Now.ToString("yyyy-mm-dd");
        //    Console.WriteLine(currentDate);
        }

        private void BtnAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void BtnKasaDevir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void BtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void BtnKasaTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void BtnKasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaHarektleri();
        }

        private void BarBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaAclisKarti();
        }

        private void BarBtnBankaİşlemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void BarBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void BarBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void BarBtnBankaHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaHareketleri();
        }
        public void Mesaj(string Baslik,string Mesaj)
        {
            alert.Show(this, Baslik, Mesaj);
        }
        #region stok menülerim
        private void NavBtnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void NavBtnStokGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokGruplari();

        }

        private void NavBtnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void NavBtnStokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokKarti();
        }


        #endregion

        #region Cari Menülerim
        private void navbtnAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void navBtnCariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void NavBtnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void navBtnCariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariHareketleri();
        }




        #endregion

        #region Kasa Menülerim
        private void navBtnkasaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void NavBtnKasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void navbtnkasadevir_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void navbtnKasatahsilatodeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void navbtnkasahareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaHarektleri();
        }
        #endregion

        #region banka menülerim
        private void navBtnBankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaAclisKarti();
        }

        private void navBtnParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void navbtnBnakalistesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaListesi();

        }

        private void navbtnbankaislemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void navBtnBankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaHareketleri();
        }
        #endregion

        #region çek menüleri
        private void barBtnMusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }
        private void barBtnCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }
        private void barBtnKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void barBtnBankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankayaCekCikisi();
        }

        private void barBtnCariyeCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariyeCekCikisi();
        }





        #endregion

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnStisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Fatura();
        }

        private void BtnSatisIadeFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FaturaListesi();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KullaniciYonetimi();
        }

        private void AnaForm_Load(object sender, EventArgs e)

        {
        }
         

        

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //YETKİ BUTONUNUN KODLARIIIII

            

        }

        private void barManager1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //this.Validate();
            //this.barManager1Source.EndEdit();
        }
    }
}