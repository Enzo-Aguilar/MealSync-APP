using DataAccessLayer;
using MealSync_APP;
using MealSync_APP.Globals;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BusinessLogicLayer
{
    public class BankAccount_BLL
    {
        public static DataTable Load_BkAccountAssociatedWithUser(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", user.ID)
            };
            return dal.ExecuteReader(
                "SELECT u.Name AS Owner, h.OwnerShipOrder AS OwnerNumber, ba.ID, ba.Balance, ba.Iban " +
                "FROM [BankAccount] ba " +
                "INNER JOIN [Holder] h ON ba.ID = h.BankAccountId " +
                "INNER JOIN [User] u ON h.UserId = u.ID " +
                "WHERE h.UserId = @UserId",
                sqlParams);
        }
        public static int Create_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@AccountType", bkAccount.AccountType),
                new SqlParameter("@Balance", bkAccount.Balance),
                new SqlParameter("@CreatedAt", bkAccount.CreatedAt),
                new SqlParameter("@Iban", bkAccount.Iban),
                new SqlParameter("@Password", bkAccount.Password)
            };
            return dal.ExecuteNonQuery("INSERT INTO [BankAccount] (AccountType,Balance,CreatedAt,Iban,Password) VALUES(@AccountType,@Balance,@CreatedAt,@Iban,@Password)", sqlParams);
        }
        public static void Deactivate_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", bkAccount.ID)
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET IsActive = 0 WHERE ID=@ID", sqlParams);
        }
        public static void Reactivate_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", bkAccount.ID)
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET IsActive = 1 WHERE ID=@ID", sqlParams);
        }

        //Searching Methods
        public static DataTable Search_IBAN(string Iban)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Iban", Iban)
            };
            return dal.ExecuteReader("SELECT * FROM [BankAccount] WHERE Iban=@Iban", sqlParams);
        }
        public static DataTable Search_AccountUserDataByName(string Name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Name", Name) };
            return dal.ExecuteReader(
                "SELECT u.Name, u.Email, u.PhoneNumber, ba.ID AS AccountID, ba.Iban " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.UserId " +
                "INNER JOIN [BankAccount] ba ON h.BankAccountId = ba.ID " +
                "WHERE ba.AccountType = 'coletiva' AND h.OwnerShipOrder = 1 AND u.Name LIKE '%' + @Name + '%' " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE BankAccountId = ba.ID) < 7 AND ba.IsActive = 1" +
                "ORDER BY u.Name",
                sqlParams);
        }
        public static DataTable Search_DeactivatedAccountUserByName(string Name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Name", Name) };
            return dal.ExecuteReader(
                "SELECT u.Name, u.Email, u.PhoneNumber, ba.ID AS AccountID, ba.Iban " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.UserId " +
                "INNER JOIN [BankAccount] ba ON h.BankAccountId = ba.ID " +
                "WHERE ba.AccountType = 'coletiva' AND h.OwnerShipOrder = 1 AND u.Name LIKE '%' + @Name + '%' " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE BankAccountId = ba.ID) < 7 AND ba.IsActive = 0" +
                "ORDER BY u.Name",
                sqlParams);
        }
        public static DataTable Show_BankAccounts()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID, AccountType,Iban FROM [BankAccount]", null);
        }

        //Tables that show what accounts can user associate(account only appear if the account have less than 7 users associated)
        public static DataTable Active_BkAccounts_WithOwnerData()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader(
                "SELECT u.Name, u.Email, u.PhoneNumber, ba.ID AS AccountID, ba.Iban " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.UserId " +
                "INNER JOIN [BankAccount] ba ON h.BankAccountId = ba.ID " +
                "WHERE ba.AccountType = 'coletiva' AND h.OwnerShipOrder = 1 " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE BankAccountId = ba.ID) < 7 AND ba.IsActive = 1" +
                "ORDER BY u.Name",
                null);//This query returns active bkAccounts with their respective owner data
        }
        public static DataTable Deactivated_BkAccounts_WithOwnerData()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader(
                "SELECT u.Name, u.Email, u.PhoneNumber, ba.ID AS AccountID, ba.Iban " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.UserId " +
                "INNER JOIN [BankAccount] ba ON h.BankAccountId = ba.ID " +
                "WHERE ba.AccountType = 'coletiva' AND h.OwnerShipOrder = 1 " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE BankAccountId = ba.ID) < 7 AND ba.IsActive = 0" +
                "ORDER BY u.Name",
                null);//This query returns deactivated bkAccounts with their respective owner data
        }
        public static DataTable Get_BankAccountDetails(int ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", ID)
            };
            return dal.ExecuteReader("SELECT * FROM [BankAccount] WHERE ID=@ID", sqlParams);
        }
        public static Object Get_BkBalance(int id)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID",id),
            };
            return dal.ExecuteScalar("SELECT Balance FROM [BankAccount] WHERE ID=@ID",sqlParams);
        }

        //Update Bank Account balance after a payment
        public static void Update_BankAccountBalance(int ID, decimal newBalance)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", ID),
                new SqlParameter("@Balance", newBalance),
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET Balance=@Balance WHERE ID=@ID", sqlParams);
        }
    }
    public class Faq_BLL
    {
        public static DataTable Show_FAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT Question,UserId  FROM [Faq] WHERE IsActive = 1 and IsAnswered = 1", null);
        }
        public static DataTable Show_UnansweredFAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT Question,UserId FROM [Faq] WHERE IsActive = 1 and IsAnswered = 0", null);
        }
        public static DataTable Show_DeactivatedFAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT Question,UserId FROM [Faq] WHERE IsActive = 0", null);
        }

        public static int Create_Question(Faq faq)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId",faq.UserId),
                new SqlParameter("@Answer",null),
                new SqlParameter("@IsActive",1),
                new SqlParameter("@IsAnswered",0),
                new SqlParameter("@Question",faq.Question)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Faq] (UserId,Answer,IsAnswered,Question) VALUES(@UserId,@Answer,@IsActive,@IsAnswered,@Question)", sqlParams);
        }
        public static void Deactivate_Question(string Question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question",Question)
            };
            dal.ExecuteReader("UPDATE [Faq] SET IsActive = 0 WHERE Question=@Question", sqlParams);
        }
        public static void Reactivate_Question(string Question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question",Question)
            };
            dal.ExecuteReader("UPDATE [Faq] SET IsActive = 1 WHERE Question=@Question", sqlParams);
        }
        public static void Answer_Question(Faq faq)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Answer",faq.Answer),
                new SqlParameter("@Question",faq.Question)
            };
            dal.ExecuteNonQuery("UPDATE [Faq] SET IsAnswered=1,Answer=@Answer WHERE Question=@Question", sqlParams);
        }

        //Search Methods
        public static object Search_Question(string Question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question", Question)
            };
            return dal.ExecuteScalar("SELECT Question FROM [Faq] WHERE Question=@Question", sqlParams);
        }
        public static DataTable Search_DeactivatedFAQs(string Question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question",Question)
            };
            return dal.ExecuteReader("SELECT Question FROM [Faq] WHERE Question LIKE '%'+  @Question + '%' AND IsActive = 0", sqlParams);
        }
        public static DataTable DataTable_AnsweredQuestions(string questionFilter)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question", questionFilter)
            };
            return dal.ExecuteReader("SELECT Question FROM [Faq] WHERE Question LIKE '%' + @Question + '%' AND IsActive = 1 AND IsAnswered = 1", sqlParams);
        }
        public static DataTable Search_UnansweredQuestions(string questionFilter)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question", questionFilter)
            };
            return dal.ExecuteReader("SELECT Question FROM [Faq] WHERE Question LIKE '%' + @Question + '%' AND IsActive = 1 AND IsAnswered = 0", sqlParams);
        }

        //Search if Question is alredy answered
        public static bool IsQuestionAlredyAnswered(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[] 
            { 
                new SqlParameter("@Question", question) 
            };
            return Convert.ToBoolean(dal.ExecuteScalar("SELECT IsAnswered FROM [Faq] WHERE Question=@Question",sqlParams));
        }

        //Search by parameter [Question]
        public static DataTable Search_AnsweredQuestions(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question", question)
            };
            return dal.ExecuteReader("SELECT * FROM [Faq] WHERE Question = @Question AND IsAnswered = 1", sqlParams);
        }
        public static DataTable Search_UnansweredQuestion(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Question", question)
            };
            return dal.ExecuteReader("SELECT * FROM [Faq] WHERE Question = @Question AND IsAnswered = 0", sqlParams);
        }
    }
    public class Holder_BLL
    {
        public static int Create_Holder(Holder h)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", h.UserId),
                new SqlParameter("@BankAccountId", h.BankAccountId),
                new SqlParameter("@IsActive", 1),
                new SqlParameter("@OwnerShipOrder", h.OwnerShipOrder)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Holder] (UserId,BankAccountId,IsActive,OwnerShipOrder) VALUES(@UserId,@BankAccountId,@IsActive,@OwnerShipOrder)", sqlParams);
        }
        public static void Deactivate_Holder(Holder holder)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", holder.UserId),
                new SqlParameter("@BankAccountId", holder.BankAccountId)
            };
            dal.ExecuteNonQuery("UPDATE [Holder] SET IsActive = 0 WHERE UserId=@UserId AND BankAccountId=@BankAccountId", sqlParams);
        }
        public static void Reactivate_Holder(Holder holder)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId",holder.UserId),
                new SqlParameter("@BankAccountId",holder.BankAccountId)
            };
            dal.ExecuteNonQuery("UPDATE [Holder] SET IsActive = 1 WHERE UserId=@UserId AND BankAccountId=@BankAccountId", sqlParams);
        }

        //Buscar ID
        public static int Get_UserHolderID(int ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", ID)
            };
            return Convert.ToInt32(dal.ExecuteScalar("SELECT ID FROM [Holder] WHERE UserId=@UserId", sqlParams));
        }

        //M�todos de Procura
        public static DataTable Search_Holder(int UserId, int BankAccountId)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@BankAccountId", BankAccountId)
            };
            return dal.ExecuteReader("SELECT * FROM [Holder] WHERE UserId=@UserId AND BankAccountId=@BankAccountId", sqlParams);
        }

        //Verificar ordem de propriedade da conta
        public static DataTable GetMaxOwnershipOrderDataTable(int BankAccountId)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@BankAccountId", BankAccountId)
            };
            return dal.ExecuteReader(
                "SELECT TOP 1 * FROM [Holder] WHERE BankAccountId=@BankAccountId ORDER BY OwnerShipOrder DESC",
                sqlParams);
        }

        //Retorna o maior numero de ordem na prioridade
        public static int GetMaxOwnershipOrderValue(int BankAccountId)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@BankAccountId", BankAccountId)
            };
            object result = dal.ExecuteScalar(
                "SELECT MAX(OwnerShipOrder) FROM [Holder] WHERE BankAccountId=@BankAccountId",
                sqlParams);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
    }
    public class Meal_BLL
    {
        public static DataTable Show_Meals()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT * FROM [Meal]", null);
        }
        public static DataTable Show_MealsByDate(DateTime Date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Date", Date)
            };
            return dal.ExecuteReader("SELECT * FROM [Meal] WHERE CAST(Date AS Date) = CAST(@Date AS Date)", sqlParams);
        }
        public static int Create_Meal(Meal meal)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Date",meal.Date),
                new SqlParameter("@Description", meal.Description),
                new SqlParameter("@MealImage", meal.MealImage),
                new SqlParameter("@Name", meal.Name),
                new SqlParameter("@Price", meal.Price),
                new SqlParameter("@Type", meal.Type)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Meal] (Date,Description,MealImage,Name,Price,Type) VALUES(@Date,@Description,@MealImage,@Name,@Price,@Type)", sqlParams);
        }
        public static int Update_Meal(Meal meal)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", meal.ID),
                new SqlParameter("@Date", meal.Date),
                new SqlParameter("@Description", meal.Description),
                new SqlParameter("@MealImage", meal.MealImage),
                new SqlParameter("@Name", meal.Name),
                new SqlParameter("@Price", meal.Price),
                new SqlParameter("@Type", meal.Type)
            };
            return dal.ExecuteNonQuery("UPDATE [Meal] SET Date=@Date, Description=@Description, MealImage=@MealImage, Name=@Name, Price=@Price, Type=@Type WHERE ID=@ID", sqlParams);
        }
    }
    public class Order_BLL
    {
        public static DataTable Show_TodayMeal(DateTime Date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@Date", Date),
            };
            return dal.ExecuteReader("SELECT * FROM [Meal] WHERE @Date=Date", sqlParams);
        }
        public static int Create_Order(Order order)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", order.UserId),
                new SqlParameter("@MealId", order.MealId),
                new SqlParameter("@BookedAt", order.BookedAt),
                new SqlParameter("@TransactionId", order.TransactionId)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Order] (UserId, MealId, BookedAt, TransactionId) VALUES(@UserId, @MealId, @BookedAt, @TransactionId)",
                sqlParams);
        }
        public static DataTable Show_UserOrdersByDate(int UserId, DateTime Date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@Date", Date)
            };
            return dal.ExecuteReader(
                "SELECT m.* FROM [Meal] m " +
                "INNER JOIN [Order] o ON m.ID = o.MealId " +
                "WHERE o.UserId = @UserId AND CAST(m.Date AS Date) = CAST(@Date AS Date) " +
                "ORDER BY o.BookedAt DESC",
                sqlParams);
        }
        public static DataTable Show_CancellableUserOrdersByDate(int UserId, DateTime Date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@Date", Date)
            };
            return dal.ExecuteReader(
                "SELECT m.ID, m.Date, m.Description, m.IsActive, m.MealImage, m.Name, m.Price, m.Type, o.ID AS OrderID FROM [Meal] m " +
                "INNER JOIN [Order] o ON m.ID = o.MealId " +
                "WHERE o.UserId = @UserId AND CAST(m.Date AS Date) = CAST(@Date AS Date) " +
                "AND DATEDIFF(DAY, GETDATE(), m.Date) >= 7 " +
                "ORDER BY o.BookedAt DESC",
                sqlParams);
        }
        public static int Delete_Order(int orderID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", orderID)
            };
            return dal.ExecuteNonQuery("DELETE FROM [Order] WHERE ID = @ID", sqlParams);
        }
    }
    public class Transaction_BLL
    {
        public static int Create_Transaction(Transaction transaction)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@HolderId", transaction.HolderId),
                new SqlParameter("@Amount", transaction.Amount),
                new SqlParameter("@DateTime",transaction.DateTime),
                new SqlParameter("@Description",transaction.Description),
                new SqlParameter("@Type", transaction.Type),
            };
            return dal.ExecuteNonQuery("INSERT INTO [Transaction] (HolderId, Amount, DateTime, Description, Type) VALUES(@HolderId, @Amount, @DateTime, @Description,  @Type)", sqlParams);
        }
        public static object Get_TransactionID(Transaction transaction)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@HolderId",transaction.HolderId),
                new SqlParameter("@Amount", transaction.Amount),
                new SqlParameter("@DateTime", transaction.DateTime),
                new SqlParameter("@Description", transaction.Description)
            };
            return dal.ExecuteScalar("SELECT ID FROM [Transaction] WHERE HolderId=@HolderId AND Amount=@Amount AND DateTime=@DateTime AND Description=@Description", sqlParams);
        }
        public static DataTable Show_BankAccountTransactions(int BankAccountId)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@BankAccountId", BankAccountId)
            };
            return dal.ExecuteReader("SELECT * FROM [Transaction] t INNER JOIN [Holder] h ON t.HolderId = h.ID WHERE h.BankAccountId = @BankAccountId ORDER BY t.DateTime DESC;", sqlParams);
        }
    }
    public class User_BLL
    {
        public static DataTable Login(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@Name", user.Name)
            };
            return dal.ExecuteReader("SELECT * FROM [User] WHERE Name=@Name", sqlParams);
        }
        public static int Register(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@CreatedAt",user.CreatedAt),
                    new SqlParameter("@Email",user.Email),
                    new SqlParameter("@Name",user.Name),
                    new SqlParameter("@Password",user.Password),
                    new SqlParameter("@PhoneNumber",user.PhoneNumber),
                    new SqlParameter("@PostCode",user.PostCode),
                    new SqlParameter("@ProfileImage",user.ProfileImage),
                    new SqlParameter("@Role",user.Role),
                    new SqlParameter("@SchoolMemberId",user.SchoolIDNumber)
            };
            return dal.ExecuteNonQuery("INSERT INTO [User] (CreatedAt,Email,Name,Password,PhoneNumber,PostCode,ProfileImage,Role,SchoolMemberId) VALUES(@CreatedAt,@Email,@Name,@Password,@PhoneNumber,@PostCode,@ProfileImage,@Role,@SchoolMemberId)", sqlParams);
        }
        
        public static int Create_User(User u)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@CreatedAt",u.CreatedAt),
                    new SqlParameter("@Email",u.Email),
                    new SqlParameter("@Name",u.Name),
                    new SqlParameter("@Password",u.Password),
                    new SqlParameter("@PhoneNumber",u.PhoneNumber),
                    new SqlParameter("@PostCode",u.PostCode),
                    new SqlParameter("@ProfileImage",u.ProfileImage),
                    new SqlParameter("@Role",u.Role),
                    new SqlParameter("@SchoolMemberId",u.SchoolIDNumber)
            };
            return dal.ExecuteNonQuery("INSERT INTO [User] (CreatedAt,Email,Name,Password,PhoneNumber,PostCode,ProfileImage,Role,SchoolMemberId) VALUES(@CreatedAt,@Email,@Name,@Password,@PhoneNumber,@PostCode,@ProfileImage,@Role,@SchoolMemberId)", sqlParams);
        }
        public static void Deactivate_User(int ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@ID", ID)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET IsActive = 0 WHERE ID=@ID", sqlParams);
        }
        public static void Reactivate_User(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", user.ID)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET IsActive = 1 WHERE ID=@ID", sqlParams);
        }

        //Current Session User
        public static DataTable Save(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@Name", user.Name)
            };
            return dal.ExecuteReader("SELECT * FROM [User] WHERE Name=@Name", sqlParams);
        }
        public static void UpdateUser(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID",user.ID),
                new SqlParameter("@Email",user.Email),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Password",user.Password),
                new SqlParameter("@PhoneNumber",user.PhoneNumber),
                new SqlParameter("@PostCode",user.PostCode),
                new SqlParameter("@SchoolMemberId",user.SchoolIDNumber)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET Email=@Email,Name=@Name,Password=@Password,PhoneNumber=@PhoneNumber,PostCode=@PostCode,SchoolMemberId=@SchoolMemberId WHERE ID=@ID", sqlParams);
        }

        //Search Methods
        public static object Search_Email(string Email)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter ("@Email",Email),
            };

            return dal.ExecuteScalar("SELECT Email FROM [User] WHERE Email=@Email", sqlParams);
        }
        public static object Search_Name(string Name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@Name",Name),
            };
            return dal.ExecuteScalar("SELECT Name FROM [User] WHERE Name=@Name", sqlParams);
        }
        public static object Search_PhoneNumber(string PhoneNumber)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@PhoneNumber", PhoneNumber)
            };
            return dal.ExecuteScalar("SELECT PhoneNumber FROM [User] WHERE PhoneNumber=@PhoneNumber", sqlParams);
        }
        public static object Search_SchoolMemberID(string SchoolMemberId)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@SchoolMemberId", SchoolMemberId)
            };
            return dal.ExecuteScalar("SELECT SchoolMemberId  FROM [User] WHERE SchoolMemberId=@SchoolMemberId", sqlParams);
        }

        //Order All Users
        public static DataTable Search_UserByName(string name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@Name",name)
            };
            return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Name LIKE '%' + @Name + '%'", sqlParams);
        }
        public static DataTable Show_AllUsers()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User]",null);
        }
        public static DataTable Show_AllUsers_Alphabetical()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] ORDER BY Name ASC", null);
        }
        public static DataTable Show_AllUsers_OrderById()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] ORDER BY ID ASC", null);
        }
        public static DataTable Show_AllUsers_OrderByCreationDate()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] ORDER BY CreatedAt ASC", null);
        }
        public class Admin
        {
            public static DataTable Search_AdminByName(string name)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                };
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Name LIKE '%' + @Name + '%' AND Role=0", sqlParams);
            }
            public static DataTable Show_Admins()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=0", null);
            }
            public static DataTable Show_Admins_Alphabetical()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=0 ORDER BY Name ASC", null);
            }
            public static DataTable Show_Admins_OrderById()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=0 ORDER BY ID ASC", null);
            }
            public static DataTable Show_Admins_OrderByCreationDate()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=0 ORDER BY CreatedAt ASC", null);
            }
        }
        public class Employee
        {
            public static DataTable Search_EmmployeeByName(string name)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                };
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Name LIKE '%' + @Name + '%' AND Role=1", sqlParams);
            }
            public static DataTable Show_Employees()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=1", null);
            }
            public static DataTable Show_Employees_Alphabetical()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=1 ORDER BY Name ASC", null);
            }
            public static DataTable Show_Employees_OrderById()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=1 ORDER BY ID ASC", null);
            }
            public static DataTable Show_Employees_OrderByCreationDate()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=1 ORDER BY CreatedAt ASC", null);
            }
        }
        public class Student
        {
            public static DataTable Search_StudentByName(string name)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                };
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Name LIKE '%' + @Name + '%' AND Role=2", sqlParams);
            }
            public static DataTable Show_Students()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=2", null);
            }
            public static DataTable Show_Students_Alphabetical()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=2 ORDER BY Name ASC", null);
            }
            public static DataTable Show_Students_OrderById()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=2 ORDER BY ID ASC", null);
            }
            public static DataTable Show_Students_OrderByCreationDate()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT ID,CreatedAt,Email,Name,PhoneNumber,ProfileImage FROM [User] WHERE Role=2 ORDER BY CreatedAt ASC", null);
            }
        }
    }
}