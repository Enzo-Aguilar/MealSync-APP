using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class ValidatorResult
    {
        public bool IsValid { get; set; }
        public string errorMessage { get; set; }
    }
    public class Encryptor
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("your-32-char-secret-key-here!!!!");
        private static readonly Aes aes = Aes.Create();

        public static string Encrypt(string plainText)
        {
            aes.Key = Key;
            aes.GenerateIV(); // Random IV for each encryption

            var encryptor = aes.CreateEncryptor();
            using (var ms = new MemoryStream())
            {
                // Prepend IV to the ciphertext so we can use it during decryption
                ms.Write(aes.IV, 0, aes.IV.Length);

                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                    sw.Write(plainText);

                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static string Decrypt(string cipherText)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                aes.Key = Key;

                // Extract the IV from the first 16 bytes
                var iv = new byte[16];
                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                aes.IV = iv;

                var decryptor = aes.CreateDecryptor();
                using (var ms = new MemoryStream(fullCipher, 16, fullCipher.Length - 16))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }

    public class Validator
    {
        static public ValidatorResult Validate_Password(string password)
        {
            try
            {
                if (!String.IsNullOrEmpty(password))
                {
                    if (password.Length >= 7)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "password muito fraca" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "campo [palavra-passe] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [palavra-passe]: " + err.Message };
            }
        }
    }
}
