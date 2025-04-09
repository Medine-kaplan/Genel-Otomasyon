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

namespace Odev.Modul_Banka
{
    public partial class FrmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        int BankaID = -1;
        int IslemID = -1;
        string EvrakTuru;
        public FrmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        void listele()
        {
            var lst = from s in DB.VW_BANKAHAREKETLERIs
                      where s.BANKAID==BankaID
                      select s;
            Liste.DataSource = lst;
        }
         public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI Banka = DB.VW_BANKALISTESIs.First(s => s.ID == BankaID);
                TxtHesapTuru.Text = Banka.HESAPADI;
                TxtHesapNo.Text = Banka.HESAPNO;
                TxtGiris.Text= Banka.GIRIS.Value.ToString();
                TxtCikis.Text = Banka.CIKIS.Value.ToString();
                TxtBakiye.Text = Banka.BAKIYE.Value.ToString();
                listele();


            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void TxtHesapTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                EvrakTuru=gridView1.GetFocusedRowCellValue("EvrakTuru").ToString();

            }
            catch (Exception )
            {

                IslemID = -1;
                EvrakTuru = "";
            }
        }
        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            sec();

            if (IslemID>0)
            {
                if (EvrakTuru == "Banka İşlem")
                {
                    bankaİşleminiDüzenleToolStripMenuItem.Enabled = true;
                    bankaParaTransferiniDüzenleToolStripMenuItem.Enabled = false;
                }
                else if (EvrakTuru == "Banka EFT" || EvrakTuru == "Banka Havale")
                {

                    bankaİşleminiDüzenleToolStripMenuItem.Enabled = false;
                    bankaParaTransferiniDüzenleToolStripMenuItem.Enabled = true;

                } 
            }

        }

        private void bankaİşleminiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true, IslemID);
            listele();
        }

        private void bankaParaTransferiniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            listele();
        }

        //private void SagTik(object sender, EventArgs e)
        //{

        //}

        //private void SagTik(object sender, EventArgs e)
        //{

        //}
    }
}