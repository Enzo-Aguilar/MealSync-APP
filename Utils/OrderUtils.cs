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
                    Description = dr[2].ToString(),
                    IsActive = Convert.ToBoolean(dr[3]),
                    MealImage = dr[4] != DBNull.Value ? (byte[])dr[4] : null,
                    Name = dr[5].ToString(),
                    Price = SqlMoney.Parse(dr[6].ToString()),
                    Type = dr[7].ToString(),
                };
                mealList.Add(meal);
            }
            return mealList.ToArray();
        }
        public static ValidatorResult CreateOrder(User user, Meal meal)
        {
            try
            {
                int ID_Holder = Holder_BLL.Get_UserHolderID(user.ID);
                Transaction transaction = new Transaction
                {
                    ID_Holder = ID_Holder,
                    Amount = meal.Price,
                    DateTime = DateTime.UtcNow,
                    Description = "Pagamento Refeição",
                    Type = "remover",
                };
                Transaction_BLL.Create_Transaction(transaction);
                int ID_Transaction = Transaction_BLL.Get_TransactionID(transaction);

                Order order = new Order
                {
                    ID_Meal = meal.ID,
                    ID_Transaction = ID_Transaction,
                    ID_User = user.ID,
                    BookedAt = DateTime.UtcNow,
                };
                Order_BLL.Create_Order(order);
                return new ValidatorResult { IsValid = true };
            }
            catch (Exception err) 
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar criar pedido: "+err.Message };
            }
        }
    }
}
