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
    public partial class FrmAyar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAyar()
        {
            InitializeComponent();
        }

        private void ChkYeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            TxtDatabase.Enabled = !TxtDatabase.Enabled;
            TxtPassword.Enabled=!TxtPassword.Enabled;
            TxtSunucu.Enabled = !TxtSunucu.Enabled;
            TxtUserID.Enabled = !TxtUserID.Enabled;
            BtnKaydet.Enabled = !BtnKaydet.Enabled;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Sunucu = TxtSunucu.Text.Trim() + ";";
            Properties.Settings.Default.cs_Database = TxtDatabase.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID=TxtUserID.Text.Trim()+";";
            Properties.Settings.Default.cs_Password = TxtPassword.Text.Trim() + ";";
            Properties.Settings.Default.Database = TxtDatabase.Text.Trim();
           Properties.Settings.Default.Save();
            //Application.Restart();
        }

        private void FrmAyar_Load(object sender, EventArgs e)
        {

            labelControl2.Text = Properties.Settings.Default.cs1 + Properties.Settings.Default.cs_Sunucu + Properties.Settings.Default.cs2 + Properties.Settings.Default.cs_Database + Properties.Settings.Default.cs3 + Properties.Settings.Default.cs_UserID + Properties.Settings.Default. cs4 + Properties.Settings.Default.cs_Password;
        }
    }
}