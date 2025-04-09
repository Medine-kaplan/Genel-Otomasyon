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

namespace Odev.Modul_Kasa
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        int HareketID = -1;
        int EvrakID = -1;
        int KasaID = -1;
        string evrakturu;
            public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Ac (int ID)
           {
            try
            {
                KasaID = ID;
                TxtKasaKodu.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
                TxtKasaAdi.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                DurumuGetir();
                Listele();
                    
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);            }
           } 
        void DurumuGetir()
        {
            Fonksiyonlar.VW_KASADURUM Kasa = db.VW_KASADURUMs.First(s => s.KASAID == KasaID);
            TxtGiris.Text = Kasa.GIRIS.Value.ToString();
            TxtCikis.Text = Kasa.CIKIS.Value.ToString();
            TxtBakiye.Text = Kasa.BAKIYE.Value.ToString();
        }
        void Listele()
        {
            var lst = from s in db.VW_KASAHAREKETLERIs
                      where s.KASAID == KasaID
                      select s;
            liste.DataSource = lst;
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }

        private void TxtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID>0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }


        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());            }
                catch (Exception)
                {

                    EvrakID = -1;
                }
                evrakturu=gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                evrakturu = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (evrakturu=="Kasa Devir Kartı")
            {
                devirKartıİşleminiDüzenleToolStripMenuItem.Enabled = true;
                tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = false;
            }
            else if(evrakturu=="Kasa Tahsilat"|| evrakturu=="Kasa Ödeme")
            {
                devirKartıİşleminiDüzenleToolStripMenuItem.Enabled = false;
                tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = true;
            }

        }

        private void devirKartıİşleminiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevirIslemKarti(true, HareketID);
            Listele();
        }

        private void tahsilatÖdemeİşleminiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti(true, HareketID);

            Listele();
        }

        private void Sagtik(object sender, EventArgs e)
        {

        }
    }
}