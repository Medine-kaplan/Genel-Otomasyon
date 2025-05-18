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

namespace Odev
{
    public partial class FrmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        public FrmLoginForm()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm frm = new AnaForm();
            frm.Show();
        }

        private void BtnAyar_Click(object sender, EventArgs e)
        {
            FrmAyar frm = new FrmAyar();
            frm.ShowDialog();
        }

        private void FrmLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}