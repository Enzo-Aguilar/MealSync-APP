using BusinessLogicLayer;
using MealSync_APP;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Utils
{
    public class HolderUtils
    {
        static protected ValidatorResult IsUserAlredyAssociatedToBankAccount(User user, BankAccount bankAccount)
        {
            try
            {
                DataTable dt = Holder_BLL.Search_Holder(user.ID, bankAccount.ID);
                if (dt.Rows.Count == 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O utilizador já está associado a esta conta bancária." };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar se o utilizador já está associado a esta conta bancária: " + err.Message };
            }
        }
        static protected ValidatorResult IsPasswordEqualToBkAccountPassword(BankAccount bankAccount)
        {
            try
            {
                DataTable dt = BankAccount_BLL.GetBankAccountDetails(bankAccount);
                if (dt.Rows.Count != 0)
                {
                    string passwordDecrypted = Encryptor.Decrypt(dt.Rows[0][6].ToString());
                    if (bankAccount.Password == passwordDecrypted)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "A palavra-passe incorreta" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Não é possivel obter detalhes desta conta bancária" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar a palavra-passe da conta bancária: " + err.Message };
            }
        }
        static protected ValidatorResult IsNameEqualToBkOwner(User user)
        {
            try
            {
                DataTable dt = BankAccount_BLL.Search_AccountUserDataByName(user.Name);
                if (dt.Rows.Count != 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O utilizador só pode apagar contas que estão no seu nome" };
                }
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu erro ao tentar validar o nome do dono da conta bancaria: "+err.Message };
            }
        }
    }
    public class HolderAuth : HolderUtils
    {
        static public void Create_Holder(BankAccount bankAccount, User user, int ownershipOrder)
        {
            try
            {
                DataTable dt = BankAccount_BLL.Search_IBAN(bankAccount.IBAN);
                if(dt.Rows.Count != 0)
                {
                    bankAccount.ID = Convert.ToInt32(dt.Rows[0][0]);
                    Holder holder = new Holder
                    {
                        ID_User = user.ID,
                        ID_BankAccount = bankAccount.ID,
                        OwnershipOrder = ownershipOrder
                    };
                    Holder_BLL.Create_Holder(holder);
                }
                else
                {
                    MessageBox.Show("Não é possivel obter detalhes desta conta bancária");
                    return;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar criar Holder: "+err.Message);
            }
       }
        static public void Deactivate_Holder(BankAccount bkAccount, User user)
        {
            try
            {
                Holder holder = new Holder
                {
                    ID_User = user.ID,
                    ID_BankAccount = bkAccount.ID,
                };
                Holder_BLL.Deactivate_Holder(holder);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar desativar Holder: " + err.Message);
            }
        }
        static public ValidatorResult AssociateBankAccountToUser(User currentUser, BankAccount bankAccount)
        {
            int ownerShipOrder = Holder_BLL.GetMaxOwnershipOrderValue(bankAccount.ID)+1;

            if(ownerShipOrder >= 8)return new ValidatorResult { IsValid = false, errorMessage = "Número máximo de titulares atingido para esta conta bancária." };

            var checks = new[]
            {
                IsPasswordEqualToBkAccountPassword(bankAccount),
                IsUserAlredyAssociatedToBankAccount(currentUser, bankAccount)
            };
            foreach(var result in checks)
            {
                if (!result.IsValid) return result;
            }
            Create_Holder(bankAccount, currentUser, ownerShipOrder);
            return new ValidatorResult { IsValid = true };
        }
        static public ValidatorResult DeactivateBankAccountToUser(User currentUser, BankAccount bkAccount)
        {
            try
            {
                var checks = new[]
                {
                    IsPasswordEqualToBkAccountPassword(bkAccount),
                    IsNameEqualToBkOwner(currentUser)
                };
                foreach (var result in checks) if (!result.IsValid) return result;

                BankAuth.Deactivate_BankAccount(bkAccount);
                Deactivate_Holder(bkAccount, currentUser);
                return new ValidatorResult { IsValid = true };
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar desativar: "+err.Message};
            }
        }
    }
}