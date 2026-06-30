using MealSync_APP.Globals;
using System.Data.SqlTypes;
using BusinessLogicLayer;
using System.Data;
using System;

namespace MealSync_APP.Utils
{
    internal static class BankAccountValidator
    {
        public static ValidatorResult ValidateIban(string iban)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(iban))
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O campo [IBAN] está inválido.",
                    };
                }
                if(iban.Length != 25)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O IBAN deve conter exatamente 25 caracteres",
                    };
                }
                if (!iban.StartsWith("PT50"))
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O IBAN deve começar por 'PT50'",
                    };
                }
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateIban),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o IBAN: {ex.Message}",
                };
            }
        }
        public static ValidatorResult IsIbanTaken(string iban)
        {
            try
            {
                var dt = BankAccount_BLL.Search_IBAN(iban);
                if(dt.Rows.Count > 0)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O IBAN já se encontra registado"
                    };
                }
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsIbanTaken),
                    ErrorMessage = $"Ocorreu um erro ao verificar o IBAN: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ValidateMoney(SqlMoney money)
        {
            if(money.IsNull || money < 0)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "Quantia Monetária Invalida",
                };
            }
            else
            {
                return new ValidatorResult { IsValid = true, };
            }
        }
    }
    public static class BankAuth
    {
        public static ValidatorResult CreateBankAccount(BankAccount bk, string passwordConfirm)
        {
            var validations = new[]
            {
                BankAccountValidator.ValidateIban(bk.Iban),
                BankAccountValidator.IsIbanTaken(bk.Iban),
                Password.Validate(bk.Password),
                Password.ValidatePasswordConfirmation(bk.Password, passwordConfirm),
            };
            foreach (var validation in validations) 
            {
                if (!validation.IsValid)
                {
                    return validation;
                }
            }
            bk.Password = Password.HashPassword(bk.Password);
            try
            {
                BankAccount_BLL.Create_BankAccount(bk);
                return new ValidatorResult
                {
                    IsValid = true,
                };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(CreateBankAccount),
                    ErrorMessage = $"Ocorreu um erro ao tentar criar conta bancária: {ex.Message}",
                };
            }
        }
        public static ValidatorResult DeactivateBankAccount(BankAccount bk)
        {
            try
            {
                BankAccount_BLL.Deactivate_BankAccount(bk);
                return new ValidatorResult
                {
                    IsValid = true,
                };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(DeactivateBankAccount),
                    ErrorMessage = $"Ocorreu um erro ao tentar desativar conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ReactivateBankAccount(BankAccount bk)
        {
            try
            {
                BankAccount_BLL.Reactivate_BankAccount(bk);
                return new ValidatorResult
                {
                    IsValid = true,
                };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ReactivateBankAccount),
                    ErrorMessage = $"Ocorreu um erro ao tentar reativar conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult AddAmountToBkAccount(BankAccount bk, SqlMoney money)
        {
            var validations = new[]
            {
                BankAccountValidator.ValidateIban(bk.Iban),
                BankAccountValidator.ValidateMoney(money),
            };
            foreach(var validation in validations)
            {
                if (!validation.IsValid)
                {
                    return validation;
                }
            }
            decimal currentBalance = Convert.ToDecimal(BankAccount_BLL.Get_BkBalance(bk.ID));
            BankAccount_BLL.Update_BankAccountBalance(bk.ID, currentBalance + (decimal)money);
            return new ValidatorResult { IsValid = true, };
        }
    }
    public static class BankAccountData
    {
        private static readonly int _ownerNumber = 1;
        private static void EnsureBkTableExists()
        {

            var bkTable = CurrentSession.UserBkAccountsDataTable ?? (CurrentSession.UserBkAccountsDataTable = new DataTable());
            if (bkTable.Columns.Count > 0)
            {
                return;
            }
            bkTable.Columns.Add("Owner", typeof(string));
            bkTable.Columns.Add("OwnerNumber", typeof(int));
            bkTable.Columns.Add("ID", typeof(int));
            bkTable.Columns.Add("Balance", typeof(decimal));
            bkTable.Columns.Add("IBAN", typeof(string));
        }
        public static void Save(BankAccount bk)
        {
            var bkDetails = BankAccount_BLL.Get_BankAccountDetails(bk.ID);
            if(bkDetails.Rows.Count == 0)
            {
                return;
            }
            AppendBkToUserBkTable(bk);
        }
        public static void LoadBkAssociatedToUser()
        {
            CurrentSession.UserBkAccountsDataTable = BankAccount_BLL.Load_BkAccountAssociatedWithUser(CurrentSession.User);
        }
        public static void AppendBkToUserBkTable(BankAccount bk)
        {
            EnsureBkTableExists();
            CurrentSession.UserBkAccountsDataTable.Rows.Add(
              CurrentSession.User.Name,
              _ownerNumber,
              bk.ID,
              bk.Balance,
              bk.Iban
              );
        }
    }
}