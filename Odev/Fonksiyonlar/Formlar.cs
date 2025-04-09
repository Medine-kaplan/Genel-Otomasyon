using System;
using System.Linq;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
