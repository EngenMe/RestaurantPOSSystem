using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class clsImageByte
    {
        public static Byte[] ImageToByte(Image img)
        {
            string tempFileName = Path.GetTempFileName();
            try
            {
                img.Save(tempFileName, ImageFormat.Png);
                Byte[] bResult = File.ReadAllBytes(tempFileName);
                return bResult; 
            }
            finally
            {
                if (File.Exists(tempFileName))
                {
                    File.Delete(tempFileName);
                }
            }
        }
        public static Image ByteToImage(object bObj)
        {
            Byte[] myImg = bObj as Byte[];
            Image image = null;
            using (MemoryStream ms = new MemoryStream(myImg, 0, myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }
            
            return image;
        }
    }
}
