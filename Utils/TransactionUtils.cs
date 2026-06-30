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
        public static Transaction MakeTransaction(int UserId, decimal amount, string type)
        {
            try
            {
                int HolderId = Holder_BLL.Get_UserHolderID(UserId); 
                if (HolderId != 0)
                {
                    if (!string.IsNullOrEmpty(type))
                    {
                        Transaction transaction = new Transaction
                        {
                            HolderId = HolderId,
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
                    throw new ArgumentException("HolderId não pode ser zero.");
                }
            } 
            catch (Exception err)
            {
                throw new Exception("Ocorreu um erro ao criar a transação: " + err.Message);
            }
        }
    }
}
