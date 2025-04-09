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
    public partial class FrmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;
        public FrmBankaListesi()
        {
            InitializeComponent();
        }

        private void FrmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in db.VW_BANKALISTESIs
                      where s.HESAPADI.Contains(TxtHesapAiTuru.Text) && s.HESAPNO.Contains(TxtHesapNo.Text) && s.IBAN.Contains(TxtIBAN.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception )
            {

                SecimID = -1;
            }
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim&& SecimID>0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}