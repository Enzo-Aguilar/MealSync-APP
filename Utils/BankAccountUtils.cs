using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class BankAccountValidator
    {

    }
    public class BankAuth
    {
        static public ValidatorResult Has_BankAccount(int ID)
        {
            try
            {
                DataTable dt = BLL.User.Has_BankAccount(ID);
                if (dt.Rows.Count > 0)
                {
                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Utilizador não tem conta criado/associada" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar verificar se o utilizador tem conta" };
            }
        }
    }
}
