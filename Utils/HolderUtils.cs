using System;
using BusinessLogicLayer;
using MealSync_APP.Globals;

namespace MealSync_APP.Utils
{
    internal static class HolderValidator
    {
        public static ValidatorResult IsUserNotAssociatedToBk(User u, BankAccount bk)
        {
            try
            {
                var dt = Holder_BLL.Search_Holder(u.ID, bk.ID);
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
                    Source = nameof(IsUserNotAssociatedToBk),
                    ErrorMessage = $"Ocorreu um erro ao tentar verificar se o utilizador tem associação com esta conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult IsPasswordEqualToBKPassword(BankAccount bk)
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
                    Source = nameof(IsPasswordEqualToBKPassword),
                    ErrorMessage = $"Ocorreu um erro ao tentar entrar na conta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult IsUserNameEqualToActiveBkOwnerName(User u)
        {
            try
            {
                var dt = BankAccount_BLL.Search_AccountUserDataByName(u.Name);
                if (dt.Rows.Count != 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O utilizador não pode desativa contas que não estão em seu nome",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsUserNameEqualToActiveBkOwnerName),
                    ErrorMessage = $"Ocorreu erro ao tentar validar o dono da conta: {ex.Message}",
                };
            }
        }
    }
    public class HolderAuth
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
                        OwnerShipOrder = ownerShipOrder,// 1 cuz he is the owner of the bk account so he has the first association
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
        public static ValidatorResult DeactivateHolder(User u, BankAccount bk)
        {
            try
            {
                Holder h = new Holder
                {
                    UserId = u.ID,
                    BankAccountId = bk.ID,
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
        public static ValidatorResult ReactivateHolder(User u, BankAccount bk)
        {
            try
            {
                Holder h = new Holder
                {
                    UserId = u.ID,
                    BankAccountId = bk.ID,
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
             * 3º Create associate between bk and user
             */

            int bkHolderNumber = Holder_BLL.GetMaxOwnershipOrderValue(bk.ID);

            //try
            //{
            //    int ownerShipOrder = Holder_BLL.GetMaxOwnershipOrderValue(bk.ID);
            //    if (ownerShipOrder >= 8)
            //    {
            //        return new ValidatorResult
            //        {
            //            IsValid = false,
            //            ErrorMessage = "Não é possível associar mais de 7 utilizadores a mesma conta bancária",
            //        };
            //    }
            //    var validations = new[]
            //    {
            //    HolderValidator.IsUserNotAssociatedToBk(u, bk),
            //    HolderValidator.IsUserNameEqualToActiveBkOwnerName(u),
            //};
            //    foreach (var validation in validations)
            //    {
            //        if (!validation.IsValid)
            //        {
            //            return validation;
            //        }
            //    }
            //    CreateHolder(u, bk, ownerShipOrder);
            //    return new ValidatorResult { IsValid = true };
            //}
            //catch (Exception ex)
            //{
            //    return new ValidatorResult
            //    {
            //        IsValid = false,
            //        Source = nameof(AssociateBkToUser),
            //        ErrorMessage = $"Ocorreu um erro criando associação entre utilizador e conta bancária: {ex.Message}",
            //    };
            //}
        }
        public static ValidatorResult DisassociateBkToUser(User u, BankAccount bk)
        {
            try
            {
                var validations = new[]
                {
                    HolderValidator.IsPasswordEqualToBKPassword(bk),
                    HolderValidator.IsUserNameEqualToActiveBkOwnerName(u),
                };
                foreach(var validate in validations)
                {
                    if (!validate.IsValid)
                    {
                        return validate;
                    }
                }
                BankAuth.DeactivateBankAccount(bk);
                DeactivateHolder(u, bk);
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof (AssociateBkToUser),
                    ErrorMessage = $"Ocorreu um erro ao desativar conexão entre utilizador e conta bancária: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ReassociateBkToUser(User u, BankAccount bk)
        {
            try
            {
                var validations = new[]
                {
                    HolderValidator.IsPasswordEqualToBKPassword(bk),
                    HolderValidator.IsUserNameEqualToActiveBkOwnerName(u),
                };
                foreach (var validate in validations)
                {
                    if (!validate.IsValid)
                    {
                        return validate;
                    }
                }
                BankAuth.ReactivateBankAccount(bk);
                ReactivateHolder(u, bk);
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ReassociateBkToUser),
                    ErrorMessage = $"Ocorreu um erro ao tentar reativar conexão entre utilizador e conta bancária: {ex.Message}",
                };
            }
        }
    }
}