using PowerFit.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Repository
{
    public class ImageRepository : IImageRepository
    {
        public Image ByteToImgConverter(byte[] imgByte)
        {
            using (MemoryStream ms = new MemoryStream(imgByte))
            {
                
                return Image.FromStream(ms);
                
            }
        }

        public byte[] ImageToByteConverter(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);

                return ms.ToArray();
            }
        }
    }
}
