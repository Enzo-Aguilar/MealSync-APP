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
        public static Meal[] GetUserUpcomingOrderedMeals(User user)
        {
            DataTable dt = Order_BLL.Show_UserUpcomingOrders(user.ID);
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
            /* Pagamento, transação e pedido são executados como uma única operação atómica
             * em Order_BLL.PlaceOrder: ou tudo é gravado, ou nada é (sem saldo retirado sem pedido).
             */
            try
            {
                int holderId = Holder_BLL.Get_UserHolderID(u.ID);
                if (holderId <= 0)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Numero de Titular Invalido",
                    };
                }

                bool paid = Order_BLL.PlaceOrder(
                    bankAccountId: BkId,
                    holderId: holderId,
                    amount: m.Price,
                    description: "Pagamento Refeição",
                    type: "Saldo Retirado",
                    when: DateTime.Now,
                    userId: u.ID,
                    mealId: m.ID);

                if (!paid)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Conta Bancaria com saldo insuficiente"
                    };
                }

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
