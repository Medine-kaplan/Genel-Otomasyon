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

namespace Odev.Modul_Kasa
{
    public partial class FrmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimId = -1;

        public FrmKasaListesi()
        {
            InitializeComponent();
        }

        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst=from s in db.TBL_KASALARs
                    where s.KASAKODU.Contains(TxtKasaKodu.Text)&&s.KASAADI.Contains(TxtKasaAdi.Text)
                    select s;
            Liste.DataSource = lst;
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
            if (Secim && SecimId > 0)
            {
                AnaForm.Aktarma = SecimId;
                this.Close();

            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}