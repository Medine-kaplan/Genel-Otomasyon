using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev.Modul_Cari
{
    public partial class FrmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }



        void Listele()
        {
            var LST = from s in db.TBL_CARILERs
                      where s.CARIADI.Contains(txtCariAdi.Text) && s.CARIKODU.Contains(txtCariKodu.Text)
                      select s;
            Liste.DataSource = LST;

        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception e)
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