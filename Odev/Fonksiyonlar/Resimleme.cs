using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odev.Fonksiyonlar
{
    internal class Resimleme
    {
        public byte[] ResimYukleme(System.Drawing.Image Resim)
        {using(MemoryStream ms=new MemoryStream())
                    {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image ResimGetirme(byte[] GelenByteArray)
        {
            using(MemoryStream ms=new MemoryStream(GelenByteArray))
            {
                Image Resim = Image.FromStream(ms);
                return Resim;
            }
        }
    }
}
