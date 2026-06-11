using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MealSync_APP.Utils
{
    internal class ImageValidator
    {
        public static ValidatorResult ValidateImage(Image img)
        {
            try
            {
                if (img != null)
                {
                    return new ValidatorResult { IsValid = true };
                }
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "Imagem Invalida",
                };
            }
            catch (InvalidCastException ice)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateImage),
                    ErrorMessage = $"Imagem em formato Inválido: {ice.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateImage),
                    ErrorMessage = $"Ocorreu um erro a tentar validar imagem: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidateBytes(byte[] bytes)
        {
            try
            {
                if (bytes != null)
                {
                    return new ValidatorResult { IsValid = true };
                }
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "Bytes Invalidos",
                };
            }
            catch (InvalidCastException ice)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateBytes),
                    ErrorMessage = $"Bytes da imagem em formato Inválido: {ice.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateBytes),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar bytes da image: {ex.Message}"
                };
            }
        }
    }
    public class ImageUtils
    {
        public static byte[] ImageToBytes(Image img)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                var validate = ImageValidator.ValidateImage(img);
                if (validate.IsValid)
                {
                    using (ms)
                    {
                        if (img == null)
                        {
                            return null;
                        }
                        img.Save(ms, img.RawFormat);//Manter formato original
                        return ms.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show(validate.ErrorMessage, validate.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro convertendo a imagem para bytes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                ms.Close();
            }
        }
        public static Image BytesToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                var validate = ImageValidator.ValidateBytes(bytes);
                if (validate.IsValid)
                {
                    using (ms)
                    {
                        if (bytes == null)
                        {
                            return null;
                        }
                        return Image.FromStream(new MemoryStream(bytes));
                    }
                }
                else
                {
                    MessageBox.Show(validate.ErrorMessage, validate.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro convertendo os bytes para image: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                ms.Close();
            }
        }
    }
}
