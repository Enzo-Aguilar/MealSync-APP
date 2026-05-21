using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class ImageValidator
    {
        static public ValidatorResult Validate_Image(Image img)
        {
            try
            {
                if (img == null || img == )
                {
                    return new ValidatorResult { IsValid = true };
                }
                return new ValidatorResult { IsValid = false };

            }
            catch (InvalidCastException ice)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "O tipo de dados ou tentativa de conversão invalida: "+ice };
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro: " + err.Message };
            }
        }
    }
    public class ImageUtils
    {
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
}
