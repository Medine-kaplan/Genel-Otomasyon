using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Stok
{
    public partial class FrmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        public bool secim = false;
        int SecimId = -1;
        public FrmStokListesi()
        {
            InitializeComponent();
        }

        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            listele();


        }
        void listele()
        {
            var lst = from s in db.TBL_STOKLARs
                      where s.STOKADI.Contains(TxtStokAdı.Text)&&s.STOKBARKOD.Contains(TxtBarkod.Text)&& s.STOKKODU.Contains(TxtStokKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            TxtStokAdı.Text = " ";
            TxtStokKodu.Text = " ";
            TxtBarkod.Text = " ";
        }

        void Sec()
        {
            try
            {
                SecimId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {
                SecimId = -1;
            }
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim &&SecimId >0)
            {
                AnaForm.Aktarma = SecimId;
                this.Close();
            }
        }
    }
}