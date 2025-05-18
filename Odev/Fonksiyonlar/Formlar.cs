using System;
using System.Linq;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Odev.Fonksiyonlar
{
    internal class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool secim = false)
        {
            Modul_Stok.FrmStokListesi frm = new Modul_Stok.FrmStokListesi();
            if (secim)
            {
                frm.secim = secim;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
            return AnaForm.Aktarma;
        }


        public int StokGruplari(bool secim = false)
        {
            Modul_Stok.FrmStokGrupları frm = new Modul_Stok.FrmStokGrupları();
            if (secim) frm.secim = secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }
        public void StokKarti(bool AC = false)
        {
            Modul_Stok.FrmStokKartı frm = new Modul_Stok.FrmStokKartı();
            frm.ShowDialog();
        }
        #endregion


        #region cari formları
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.FrmCariGruplar frm = new Modul_Cari.FrmCariGruplar();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }


        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.FrmCariListesi frm = new Modul_Cari.FrmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }


        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.FrmCariAcilisKarti frm = new Modul_Cari.FrmCariAcilisKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }
        public void CariHareketleri(bool secim=false)
        {
            Modul_Cari.FrmCariHareketleri frm = new Modul_Cari.FrmCariHareketleri();
            frm.ShowDialog();
        }

        #endregion

        #region Kasa Formları



        public void KasaAcilisKarti()
        {
            Modul_Kasa.FrmKasaAcilisKarti frm = new Modul_Kasa.FrmKasaAcilisKarti();
            frm.ShowDialog();
        }
        public void KasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.FrmKasaDevirIslem frm = new Modul_Kasa.FrmKasaDevirIslem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }

        public  int KasaListesi(bool Secim=false)
        {
           Modul_Kasa.FrmKasaListesi frm = new Modul_Kasa.FrmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
                return 1;// Değer döndürnek için kullanılıyo.
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
                return 0;
            }
        }

        public void KasaTahsilatOdemeKarti(bool Ac=false,int ID=-1)
        { Modul_Kasa.FrmKasaTahsilatOdeme frm = new Modul_Kasa.FrmKasaTahsilatOdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
                    
                    }

        public void KasaHarektleri(bool Ac=false, int ID=-1)
        {
            Modul_Kasa.FrmKasaHareketleri frm = new Modul_Kasa.FrmKasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if(Ac) frm.Ac(ID);
            frm.Show();
        }


        #endregion

        #region Banka Formları

 public void BankaAclisKarti()
        {
            Modul_Banka.FrmBankaAcilisKarti frm = new Modul_Banka.FrmBankaAcilisKarti();
            frm.ShowDialog();
        }

        public void BankaIslem(bool Ac=false,int ID=-1)
        {
            Modul_Banka.FrmBankaIslem frm = new Modul_Banka.FrmBankaIslem();
            
            frm.ShowDialog();
        }
        public int BankaListesi(bool Secim=false)
        {
            Modul_Banka.FrmBankaListesi frm = new Modul_Banka.FrmBankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

    public void BankaParaTransfer(bool Ac=false ,int ID=-1)
        {
            Modul_Banka.FrmBankaTransferi Frm = new Modul_Banka.FrmBankaTransferi();
            if (Ac) Frm.Ac(ID);
            Frm.ShowDialog();
        }



        public void BankaHareketleri(bool Ac=false,int ID=-1)
        {
            Modul_Banka.FrmBankaHareketleri frm = new Modul_Banka.FrmBankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();
        }




        #endregion

        #region Çek Formları
        public void KendiCekimiz(int Id = 0, bool Ac = false)
        {
            Modul_Cek.FrmKendiCekimiz frm = new Modul_Cek.FrmKendiCekimiz();
            //if(Ac);
            frm.ShowDialog();
        }
        public void MusteriCeki(int id=0,bool Ac=false)
        {
            Modul_Cek.FrmMusteriCeki frm = new Modul_Cek.FrmMusteriCeki();
            //if(Ac);
            frm.ShowDialog();
        }
        public void CariyeCekCikisi()
        {
            Modul_Cek.FrmCariyeCekCikisi frm = new Modul_Cek.FrmCariyeCekCikisi();
            frm.ShowDialog();

        }
        public void BankayaCekCikisi()
        {
            Modul_Cek.FrmBankayaCekCikisi frm = new Modul_Cek.FrmBankayaCekCikisi();
            frm.ShowDialog();

        }
        public int CekListesi(bool Secim=false)
        {
            Modul_Cek.FrmCekListesi frm =new Modul_Cek.FrmCekListesi();
            if (Secim)
            {
                frm.Secim = true;
                frm.ShowDialog();

            }
            else
            {
                foreach(DevExpress.XtraEditors.XtraForm K in AnaForm.ActiveForm.MdiChildren)
                {
                    if (K.Text=="Çek Listesi")
                    {
                        K.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        #endregion

        #region Fatura Formları

        public void Fatura(bool Ac=false,int ID=-1,  bool Irsaliye=false)
        {
            Modul_Fatura.FrmSatisFaturasi frm = new Modul_Fatura.FrmSatisFaturasi(Ac,ID, Irsaliye);
            //if (Ac) frm = new Modul_Fatura.FrmSatisFaturasi(Ac, ID);
            //else frm = new Modul_Fatura.FrmSatisFaturasi();

            frm.MdiParent= AnaForm.ActiveForm;
            frm.Show();
        }

       public void FaturaListesi(bool Secim=false)
        {
            Modul_Fatura.FrmFaturaListesi frm = new Modul_Fatura.FrmFaturaListesi(Secim);
            if (Secim) frm.ShowDialog();
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }


        public void KullaniciYonetimi()
        {
            Modul_Kullanici.FrmKullaniciYonetimi frm = new Modul_Kullanici.FrmKullaniciYonetimi();
            frm.ShowDialog();
        }

        public void KullaniciPanel(bool ac=false,int ID=-1)
        {
            Modul_Kullanici.FrmKullaniciPanel frm = new Modul_Kullanici.FrmKullaniciPanel();
            frm.ShowDialog();
        }
        #endregion

    }
}
