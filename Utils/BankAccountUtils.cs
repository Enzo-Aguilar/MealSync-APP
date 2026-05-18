using System.Data.SqlTypes;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System.Data;
using System;

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
                            return new ValidatorResult { IsValid = false, ErrorMessage = "O IBAN deve começar com 'PT50'" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "O IBAN deve conter exatamente 25 caracteres" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [IBAN] está invalido" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao validar o IBAN: " + err.Message };
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
                        ErrorMessage = "As palavras-passe não coincidem"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao validar a confirmação da palavra-passe: " + err.Message };
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
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao validar o IBAN: " + err.Message };
            }
        }
    }
    public class BankAuth : BankAccountValidator
    {
        static public ValidatorResult Create_BankAccount(BankAccount bankAccount, string passwordConfirm)
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
        static public ValidatorResult Deactivate_BankAccount(BankAccount bkAccount)
        {
            try
            {
                BankAccount_BLL.Deactivate_BankAccount(bkAccount);
                return new ValidatorResult { IsValid = true };
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao desativar a conta bancária: " + err.Message };
            }
        }
        static public ValidatorResult Reactivate_BankAccount(BankAccount bkAccount)
        {
            try
            {
                BankAccount_BLL.Reactivate_BankAccount(bkAccount);
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar ativar conta bancária: " + err.Message };
            }
        }
    }
    public class BankAccountData
    {
        public static void Save(BankAccount bankAccount)
        {
            DataTable dt = BankAccount_BLL.GetBankAccountDetails(bankAccount);
            if (dt.Rows.Count != 0)
            {
                bankAccount = new BankAccount
                {
                    ID = int.Parse(dt.Rows[0][0].ToString()),
                    Balance = SqlMoney.Parse(dt.Rows[0][2].ToString()),
                    CreatedAt = DateTime.Parse(dt.Rows[0][3].ToString()),
                    IBAN = dt.Rows[0][4].ToString(),
                    IsActive = true
                };

                // Ensure the session DataTable exists
                if (CurrentSession.UserBkAccountsDataTable == null)
                {
                    CurrentSession.UserBkAccountsDataTable = new DataTable();
                }

                // If the DataTable has no schema yet, add columns matching the data we'll store.
                // This avoids exceptions when calling Rows.Add with strongly-typed values.
                if (CurrentSession.UserBkAccountsDataTable.Columns.Count == 0)
                {
                    CurrentSession.UserBkAccountsDataTable.Columns.Add("ID", typeof(int));
                    CurrentSession.UserBkAccountsDataTable.Columns.Add("Balance", typeof(SqlMoney));
                    CurrentSession.UserBkAccountsDataTable.Columns.Add("CreatedAt", typeof(DateTime));
                    CurrentSession.UserBkAccountsDataTable.Columns.Add("IBAN", typeof(string));
                    CurrentSession.UserBkAccountsDataTable.Columns.Add("IsActive", typeof(bool));
                }

                // Add a new row with the bank account data.
                CurrentSession.UserBkAccountsDataTable.Rows.Add(
                    bankAccount.ID,
                    bankAccount.Balance,
                    bankAccount.CreatedAt,
                    bankAccount.IBAN,
                    bankAccount.IsActive
                );
            }
        }
        public static void Reset()
        {
            CurrentSession.UserBkAccountsList.Clear();
            CurrentSession.UserBkAccountsDataTable.Clear();
        }
        public static void AddUserRelatedAccountOnLoad()
        {
            //Com o login do user, adicionar todas as contas do user a lista userBkaccountList
        }
    }
}
 