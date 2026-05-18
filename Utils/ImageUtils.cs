using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class ImgConverter
    {
        //  Converter Imagem pra BitArray
        //          ||
        //          \/
        //  Salvar Imagem   

        static public byte[] ImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                if(img == null)
                {
                    return null;
                }
                img.Save(ms, img.RawFormat);//Manter formato original
                return ms.ToArray();
            }
        }
        static public Image BytesToImage(byte[] bytes)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                if(bytes == null)
                {
                    return null;
                }
                return Image.FromStream(new MemoryStream(bytes));
            }
        }
    }
    public class ImageData : ImgConverter
    {
        public ValidatorResult Save(Image img)
        {
            try
            {
                byte[] imageBytes = img != null ? ImageToBytes(img) : null;
                if (imageBytes != null)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Image está null" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar salvar a imagem: " + err.Message };
            }
        }
    }
}
