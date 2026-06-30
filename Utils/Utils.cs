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
