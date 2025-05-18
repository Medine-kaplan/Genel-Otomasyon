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

namespace Odev.Modul_Fatura
{
    public partial class FrmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        bool Secim = false;
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        public FrmFaturaListesi(bool Secim)
        {
            InitializeComponent();
            Secim = Secim;
        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {

        }

        private void Liste_Click(object sender, EventArgs e)
        {

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void TxtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void SagTikYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }

}