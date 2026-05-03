using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class BankAccountValidator
    {
        //Métodos de validação de dados relacionados a conta bancária
        static protected ValidatorResult Validate_IBAN(string IBAN)
        {
            try
            {
                if (!String.IsNullOrEmpty(IBAN))
                {
                    if (IBAN.Length == 25)
                    {
                        if (IBAN.StartsWith("PT50"))
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "O IBAN deve começar com 'PT50'" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O IBAN deve conter exatamente 25 caracteres" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O campo [IBAN] está invalido" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao validar o IBAN: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_PasswordConfirm(string password, string passwordConfirm)
        {
            try
            {
                if (password != passwordConfirm)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        errorMessage = "As palavras-passe não coincidem"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao validar a confirmação da palavra-passe: " + err.Message };
            }
        }
        //Métodos de procura
        static protected ValidatorResult IsIBANTaken(string iban)
        {
            try
            {
                DataTable dt = BankAccount_BLL.Search_IBAN(iban);
                if (dt.Rows.Count != 0)
                {
                    IsIBANTaken(IBAN.Create());
                    return new ValidatorResult { IsValid = false};
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao validar o IBAN: " + err.Message };
            }
        }
    }
    public class BankAuth : BankAccountValidator
    {
        public static ValidatorResult Create_BankAccount(BankAccount bankAccount, string passwordConfirm)
        {
            var checks = new[]
            {
                Validate_IBAN(bankAccount.IBAN),
                IsIBANTaken(bankAccount.IBAN),
                Validator.Validate_Password(bankAccount.Password),
                Validate_PasswordConfirm(bankAccount.Password, passwordConfirm)
            };
            foreach(var result in checks)
            {
                if (!result.IsValid) return result;
            }
            bankAccount.Password = Encryptor.Encrypt(bankAccount.Password);

            BankAccount_BLL.Create_BankAccount(bankAccount);
            return new ValidatorResult { IsValid = true };
        }
        public static ValidatorResult Deactivate_BankAccount(BankAccount bankAccount)
        {
            try
            {
                BankAccount_BLL.Deactivate_BankAccount(bankAccount);
                return new ValidatorResult { IsValid = true };
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao desativar a conta bancária: " + err.Message };
            }
        }
    }
    public class BankAccountData
    {
        public static void Save(BankAccount bankAccount)
        {
            DataTable dt = BankAccount_BLL.GetBankAccountDetails(bankAccount);
            if(dt.Rows.Count != 0)
            {
                bankAccount = new BankAccount
                {
                    ID = int.Parse(dt.Rows[0][0].ToString()),
                    Balance = SqlMoney.Parse(dt.Rows[0][2].ToString()),
                    CreatedAt = DateTime.Parse(dt.Rows[0][3].ToString()),
                    IBAN = dt.Rows[0][4].ToString(),
                    IsActive = true
                };

                Data.UserBankAccounts.Add(bankAccount);
            }
        }
    }
}
