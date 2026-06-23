using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace MealSync_APP.Utils
{
    public class ValidatorResult
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public string Source { get; set; }
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
    public class Password
    {
        public static ValidatorResult Validate(string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(password))
                {
                    if (password.Length >= 7)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult 
                        { 
                            IsValid = false, 
                            ErrorMessage = "palavra-passe muito fraca" 
                        };
                    }
                }
                else
                {
                    return new ValidatorResult 
                    { 
                        IsValid = false, 
                        ErrorMessage = "campo [palavra-passe] não pode estar vazio" 
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult 
                { 
                    IsValid = false, 
                    Source = nameof(Validate),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o campo [palavra-passe]: {ex.Message}" 
                };
            }
        }
        public static ValidatorResult ValidatePasswordConfirmation(string password, string passwordConfirm)
        {
            {
                if (password != passwordConfirm)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "As palavras-passe não coincidem."
                    };
                }

                return new ValidatorResult { IsValid = true };
            }
        }
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
    public class LogCheck
    {
        public static void UserIsLogged(Form f)
        {

            if (CurrentSession.User == null)
            {
                MessageBox.Show("Nenhum utilizador logado","Erro");
                LoginForm.Open(f);
            }

        }
    }
}
