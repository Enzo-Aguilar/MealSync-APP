using System;
using System.Runtime.CompilerServices;
using BusinessLogicLayer;
using MealSync_APP.Globals;
using MealSync_APP.Pages.BankAccountFolder;

namespace MealSync_APP.Utils
{
    public class HolderValidator
    {
        public static ValidatorResult IsUserAssociatedToBk(int userID, int bkID)
        {
            try
            {
                var dt = Holder_BLL.Search_Holder(userID, bkID);
                if (dt.Rows.Count == 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O utilizador já está associado a esta conta",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsUserAssociatedToBk),
                    ErrorMessage = $"Ocorreu um erro ao tentar verificar se o utilizador está associado a conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult VerifyBkPassword(BankAccount bk)
        {
            try
            {
                var dt = BankAccount_BLL.Get_BankAccountDetails(bk.ID);
                if (dt.Rows.Count != 0)
                {
                    string storedHash = dt.Rows[0][6].ToString();
                    if (Password.VerifyPassword(bk.Password, storedHash))
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Palavra-passe Incorreta",
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Não é possivel obter detalhes da conta bancária",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(VerifyBkPassword),
                    ErrorMessage = $"Ocorreu um erro ao tentar entrar na conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult IsUserTheBkOwner(string name)
        {
            try
            {
                var dt = BankAccount_BLL.Search_AccountUserDataByName(name);
                if (dt.Rows.Count != 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O utilizador não pode desativar contas que não estão em seu nome",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsUserTheBkOwner),
                    ErrorMessage = $"Ocorreu erro ao tentar validar o dono da conta: {ex.Message}",
                };
            }
        }
    }
    public class HolderAuth : HolderValidator
    {
        public static ValidatorResult CreateHolder(User u, BankAccount bk, int ownerShipOrder = 1)
        {
            try
            {
                var dt = BankAccount_BLL.Search_IBAN(bk.Iban);
                if (dt.Rows.Count != 0)
                {
                    bk.ID = int.Parse(dt.Rows[0][0].ToString());
                    Holder h = new Holder
                    {
                        UserId = u.ID,
                        BankAccountId = bk.ID,
                        OwnerShipOrder = ownerShipOrder,
                    };
                    Holder_BLL.Create_Holder(h);
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Conta bancária não encontrada",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(CreateHolder),
                    ErrorMessage = $"Ocorreu um erro ao criar conexão entre utilizador e conta bancária: {ex.Message}",
                };
            }
        }
        public static ValidatorResult DeactivateHolder(int userID, int bkID)
        {
            try
            {
                Holder h = new Holder
                {
                    UserId = userID,
                    BankAccountId = bkID,
                };
                Holder_BLL.Deactivate_Holder(h);
                return new ValidatorResult { IsValid = true };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(DeactivateHolder),
                    ErrorMessage = $"Ocorreu um erro a desativar o titular: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ReactivateHolder(int userID, int bkID)
        {
            try
            {
                Holder h = new Holder
                {
                    UserId = userID,
                    BankAccountId = bkID,
                };
                Holder_BLL.Reactivate_Holder(h);
                return new ValidatorResult { IsValid = true };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ReactivateHolder),
                    ErrorMessage = $"Ocorreu um erro ao tentar reativar o titular: {ex.Message}",
                };
            }
        }
        public static ValidatorResult AssociateBkToUser(User u, BankAccount bk)
        {
            /* 1º Check if account is from same user
             * 2º Check if the account can still associate
             * 3º Create associate between bk and user*/

            // 1º
            var validations = new []
            {
                IsUserAssociatedToBk(u.ID,bk.ID),
                VerifyBkPassword(bk),
            };
            foreach(var validation in validations)
            {
                if (!validation.IsValid)
                {
                    return validation;
                }
            }

            // 2º
            int bkAssociatesNum = Holder_BLL.GetMaxOwnershipOrderValue(bk.ID);
            if(bkAssociatesNum >= 8)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "Não é possivel associar mais de 7 utilizadores a mesma conta bancária",
                };
            }

            // 3º
            CreateHolder(u, bk, bkAssociatesNum);
            return new ValidatorResult { IsValid = true };
        }
        public static ValidatorResult DeactivateBkToUser(User u, BankAccount bk)
        {
            /* 1º - Check if user and bk are associated
             * 2º - Deactivate Holder */

            // 1º
            var validations = new []
            {
                VerifyBkPassword(bk),
                IsUserTheBkOwner(u.Name),
            };
            foreach(var validation in validations)
            {
                if (!validation.IsValid)
                {
                    return validation;
                }
            }

            // 2º
            DeactivateHolder(u.ID, bk.ID);
            BankAuth.DeactivateBankAccount(bk);
            return new ValidatorResult { IsValid = true };
        }
        public static ValidatorResult ReassociateBkToUser(User u, BankAccount bk)
        {
            var validations = new[]
            {
                VerifyBkPassword(bk),
                IsUserTheBkOwner(u.Name)
            };
            foreach(var validation in validations)
            {
                if (!validation.IsValid)
                {
                    return validation;
                }
            }
            ReactivateHolder(u.ID, bk.ID);
            BankAuth.ReactivateBankAccount(bk);
            return new ValidatorResult { IsValid = true };
        }
    }
}