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
    public partial class FrmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        int SecilenID = -1;
         public bool Secim = false;

        public FrmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
        //    var Lst = from s in db.TBL_CEKLERs
        //              where s.TIPI.Contains(TxtCekTuru.Text) && s.BANKA.Contains(TxtBankasi.Text)
        //              select s;
        //    Liste.DataSource = Lst;
        }
        private void FrmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Sec()
        {

        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecilenID>0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}