using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Fonksiyonlar
{
    internal class Mesajlar
    {



        AnaForm MesajForm = new AnaForm();


        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("Yeni Kayıt Girişi",Mesaj);
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kalıcı olara güncellenmektedir.\n Güncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili kalıcı olarak silinicektir\n Silme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir.");
        }

        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu", Hata.Message);
        }
        public void ForAcilis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + "formu açıldı.");
        }

        public void ForKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + "formu kapatıldı.");
        }








    }
}
