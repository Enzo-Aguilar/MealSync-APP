using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Utils
{
    public class OrderUtils
    {
        public static Meal[] IndexTodayMeals(DateTime today)
        {
            DataTable dt = Order_BLL.Show_TodayMeal(today);
            List<Meal> mealList = new List<Meal>();
            foreach(DataRow dr in dt.Rows)
            {
                Meal meal = new Meal
                {
                    ID = Convert.ToInt16(dr[0]),
                    Date = dr[1] != DBNull.Value ? Convert.ToDateTime(dr[1]) : DateTime.Now,
                    Description = dr[2].ToString(),
                    IsActive = Convert.ToBoolean(dr[3]),
                    MealImage = dr[4] != DBNull.Value ? (byte[])dr[4] : null,
                    Name = dr[5].ToString(),
                    Price = decimal.Parse(dr[6].ToString()),
                    Type = dr[7].ToString(),
                };
                mealList.Add(meal);
            }
            return mealList.ToArray();
        }
        public static Meal[] GetUserOrderedMeals(User user, DateTime date)
        {
            DataTable dt = Order_BLL.Show_UserOrdersByDate(user.ID, date);
            List<Meal> mealList = new List<Meal>();
            foreach (DataRow dr in dt.Rows)
            {
                Meal meal = new Meal
                {
                    ID = Convert.ToInt16(dr[0]),
                    Date = dr[1] != DBNull.Value ? Convert.ToDateTime(dr[1]) : DateTime.Now,
                    Description = dr[2].ToString(),
                    IsActive = Convert.ToBoolean(dr[3]),
                    MealImage = dr[4] != DBNull.Value ? (byte[])dr[4] : null,
                    Name = dr[5].ToString(),
                    Price = decimal.Parse(dr[6].ToString()),
                    Type = dr[7].ToString(),
                };
                mealList.Add(meal);
            }
            return mealList.ToArray();
        }
        public static Meal[] GetCancellableUserOrderedMeals(User user, DateTime date)
        {
            DataTable dt = Order_BLL.Show_CancellableUserOrdersByDate(user.ID, date);
            List<Meal> mealList = new List<Meal>();
            foreach (DataRow dr in dt.Rows)
            {
                Meal meal = new Meal
                {
                    ID = Convert.ToInt16(dr[0]),
                    Date = dr[1] != DBNull.Value ? Convert.ToDateTime(dr[1]) : DateTime.Now,
                    Description = dr[2].ToString(),
                    IsActive = Convert.ToBoolean(dr[3]),
                    MealImage = dr[4] != DBNull.Value ? (byte[])dr[4] : null,
                    Name = dr[5].ToString(),
                    Price = decimal.Parse(dr[6].ToString()),
                    Type = dr[7].ToString(),
                };
                // Store OrderID in a temporary property or use Tag
                mealList.Add(meal);
            }
            return mealList.ToArray();
        }
        public static Meal[] GetUserOrderedMealsWithOrderId(User user, DateTime date, out Dictionary<int, int> mealOrderMap)
        {
            mealOrderMap = new Dictionary<int, int>();
            DataTable dt = Order_BLL.Show_CancellableUserOrdersByDate(user.ID, date);
            List<Meal> mealList = new List<Meal>();
            foreach (DataRow dr in dt.Rows)
            {
                Meal meal = new Meal
                {
                    ID = Convert.ToInt16(dr[0]),
                    Date = dr[1] != DBNull.Value ? Convert.ToDateTime(dr[1]) : DateTime.Now,
                    Description = dr[2].ToString(),
                    IsActive = Convert.ToBoolean(dr[3]),
                    MealImage = dr[4] != DBNull.Value ? (byte[])dr[4] : null,
                    Name = dr[5].ToString(),
                    Price = Decimal.Parse(dr[6].ToString()),
                    Type = dr[7].ToString(),
                };
                int orderId = Convert.ToInt32(dr["OrderID"]);
                mealOrderMap[meal.ID] = orderId;
                mealList.Add(meal);
            }
            return mealList.ToArray();
        }
        public static ValidatorResult CreateOrder(User u, Meal m, int BkId)
        {
              /* 1º Tentar pagar
               * 2º Criar Transação
               * 3º Criar Pedido
               * 4º Returno 
               */
            try
            {
                int transactionID;

                // 1º
                decimal bkBalance = Convert.ToDecimal(BankAccount_BLL.Get_BkBalance(BkId));
                decimal newBalance = bkBalance - m.Price;

                if (newBalance < 0)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Conta Bancaria com saldo insuficiente"
                    };
                }
                BankAccount_BLL.Update_BankAccountBalance(BkId, newBalance);

                // 2º
                int holderId = Holder_BLL.Get_UserHolderID(u.ID);
                if (holderId > 0)
                {
                    Transaction t = new Transaction
                    {
                        HolderId = holderId,
                        Amount = m.Price,
                        DateTime = DateTime.Now,
                        Description = "Pagamente Refeição",
                        Type = "Saldo Retirado",
                    };
                    Transaction_BLL.Create_Transaction(t);
                    transactionID = Convert.ToInt16(Transaction_BLL.Get_TransactionID(t));
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Numero de Titular Invalido",
                    };
                }

                // 3º
                var o = new Order
                {
                    MealId = m.ID,
                    TransactionId = transactionID,
                    UserId = u.ID,
                    BookedAt = DateTime.Now,
                };
                Order_BLL.Create_Order(o);
                return new ValidatorResult { IsValid = true, };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(CreateOrder),
                    ErrorMessage = $"Ocorreu um erro: {ex.Message}",
                };
            }
        }
    }
}
