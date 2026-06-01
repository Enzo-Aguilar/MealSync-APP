using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class TransactionUtils
    {
        static public Transaction MakeTransaction(int ID_User, SqlMoney amount, string type)
        {
            try
            {
                int ID_Holder = Holder_BLL.Get_UserHolderID(ID_User); 
                if (ID_Holder != 0)
                {
                    if (!string.IsNullOrEmpty(type))
                    {
                        Transaction transaction = new Transaction
                        {
                            ID_Holder = ID_Holder,
                            Amount = amount,
                            DateTime = DateTime.Now,
                            Type = type
                        };
                        return transaction;
                    }
                    else
                    {
                        throw new ArgumentException("Type cannot be null or empty.");
                    }
                }
                else
                {
                    throw new ArgumentException("ID_Holder não pode ser zero.");
                }
            } 
            catch (Exception err)
            {
                throw new Exception("Ocorreu um erro ao criar a transação: " + err.Message);
            }
        }
    }
}
