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

namespace Odev.Modul_Kullanici
{
    public partial class FrmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullaniciID = -1;
        public FrmKullaniciPanel()
        {
            InitializeComponent();
        }

        public FrmKullaniciPanel(int ID,bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            // if(Ac) KullaniciGetir(ID);
        }
        void Temizle()
        {
            TxtIsim.Text = "";
            TxtKullaniciAdi.Text = "";
            ChkKullaniciTuru.SelectedIndex = 1;
            TxtSifre.Text = "";
            TxtSifreTekrar.Text = "";
            TxtSoyisim.Text = "";
            RbPasif.Checked = true;
            Ac = false;
            KullaniciID = -1;
        }
     void KullaniciGetir(int ID)
        {
            KullaniciID = ID;
            try
            {
             //   int kullanici;
               // Fonksiyonlar.TBL_KULLANICILAR Kullanici = db.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
              // TxtIsim.Text = Kullanici.ISIM;
               //Fonksiyonlar.TBL_KULLANICILAR kullanici=db.TBL_KULLANICILAR
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmKullaniciPanel_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Yenikaydet();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        void Yenikaydet()
        {
            if (TxtSifre.Text.Trim()==TxtSifreTekrar.Text.Trim())
            {
                if (TxtIsim.Text == "")
                {
                    MessageBox.Show("Bir isim girişi yapmak zorundasınız.");
                    return;
                }
                else if (TxtSoyisim.Text=="")
                {
                    MessageBox.Show("Bir Soy isim girişi yapmak zorundasınız.");
                    return;
                }
                else if (TxtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Bir Kullanıcı Adı girişi yapmak zorundasınız.");
                    return;
                }
                else if (TxtSifre.Text == "")
                {
                    MessageBox.Show("Bir Şifre  girişi yapmak zorundasınız.");
                    return;
                }
              
                else MessageBox.Show("Şifreler Aynı Değil!!!");
            }
        }
    
    
    }
}