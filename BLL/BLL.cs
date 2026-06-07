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
        static public DataTable Load_BkAccountAssociatedWithUser(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@userID", user.ID)
            };
            return dal.ExecuteReader(
                "SELECT u.name AS Owner, h.ownerShipOrder AS OwnerNumber, ba.ID, ba.balance, ba.IBAN " +
                "FROM [BankAccount] ba " +
                "INNER JOIN [Holder] h ON ba.ID = h.ID_BankAccount " +
                "INNER JOIN [User] u ON h.ID_User = u.ID " +
                "WHERE h.ID_User = @userID",
                sqlParams);
        }
        static public int Create_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@accountType", bkAccount.AccountType),
                new SqlParameter("@balance", bkAccount.Balance),
                new SqlParameter("@createdAt", bkAccount.CreatedAt),
                new SqlParameter("@IBAN", bkAccount.Iban),
                new SqlParameter("@PIN", bkAccount.Password)
            };
            return dal.ExecuteNonQuery("INSERT INTO [BankAccount] (accountType,balance,createdAt,IBAN,PIN) VALUES(@accountType,@balance,@createdAt,@IBAN,@PIN)", sqlParams);
        }
        static public void Deactivate_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", bkAccount.ID)
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET isActive = 0 WHERE ID=@ID", sqlParams);
        }
        static public void Reactivate_BankAccount(BankAccount bkAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", bkAccount.ID)
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET isActive = 1 WHERE ID=@ID", sqlParams);
        }

        //Métodos de Procura
        static public DataTable Search_IBAN(string IBAN)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@IBAN", IBAN)
            };
            return dal.ExecuteReader("SELECT * FROM [BankAccount] WHERE IBAN=@IBAN", sqlParams);
        }
        static public DataTable Search_AccountUserDataByName(string name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@name", name) };
            return dal.ExecuteReader(
                "SELECT u.name, u.email, u.phoneNumber, ba.ID AS AccountID, ba.IBAN " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.ID_User " +
                "INNER JOIN [BankAccount] ba ON h.ID_BankAccount = ba.ID " +
                "WHERE ba.accountType = 'coletiva' AND h.ownerShipOrder = 1 AND u.name LIKE '%' + @name + '%' " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE ID_BankAccount = ba.ID) < 7 AND ba.isActive = 1" +
                "ORDER BY u.name",
                sqlParams);
        }
        static public DataTable Search_DeactivatedAccountUserByName(string name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@name", name) };
            return dal.ExecuteReader(
                "SELECT u.name, u.email, u.phoneNumber, ba.ID AS AccountID, ba.IBAN " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.ID_User " +
                "INNER JOIN [BankAccount] ba ON h.ID_BankAccount = ba.ID " +
                "WHERE ba.accountType = 'coletiva' AND h.ownerShipOrder = 1 AND u.name LIKE '%' + @name + '%' " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE ID_BankAccount = ba.ID) < 7 AND ba.isActive = 0" +
                "ORDER BY u.name",
                sqlParams);
        }
        static public DataTable Show_BankAccounts()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT ID, accountType,IBAN FROM [BankAccount]", null);
        }

        //Tabela que mostra o user e contas associadas (apenas contas coletivas com ownerShipOrder = 1 e que ainda permitem novos utilizadores - máx 7)
        static public DataTable Active_BkAccounts_WithOwnerData()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader(
                "SELECT u.name, u.email, u.phoneNumber, ba.ID AS AccountID, ba.IBAN " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.ID_User " +
                "INNER JOIN [BankAccount] ba ON h.ID_BankAccount = ba.ID " +
                "WHERE ba.accountType = 'coletiva' AND h.ownerShipOrder = 1 " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE ID_BankAccount = ba.ID) < 7 AND ba.isActive = 1" +
                "ORDER BY u.name",
                null);//This query returns active bkAccounts with their respective owner data
        }
        static public DataTable Deactivated_BkAccounts_WithOwnerData()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader(
                "SELECT u.name, u.email, u.phoneNumber, ba.ID AS AccountID, ba.IBAN " +
                "FROM [User] u " +
                "INNER JOIN [Holder] h ON u.ID = h.ID_User " +
                "INNER JOIN [BankAccount] ba ON h.ID_BankAccount = ba.ID " +
                "WHERE ba.accountType = 'coletiva' AND h.ownerShipOrder = 1 " +
                "AND (SELECT COUNT(*) FROM [Holder] WHERE ID_BankAccount = ba.ID) < 7 AND ba.isActive = 0" +
                "ORDER BY u.name",
                null);//This query returns deactivated bkAccounts with their respective owner data
        }

        //Detalhes da conta bancária
        static public DataTable Get_BankAccountDetails(int ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", ID)
            };
            return dal.ExecuteReader("SELECT * FROM [BankAccount] WHERE ID=@ID", sqlParams);
        }

        //Atualizar saldo da conta bancária
        static public void Update_BankAccountBalance(int ID, SqlMoney newBalance)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", ID),
                new SqlParameter("@balance", newBalance),
            };
            dal.ExecuteNonQuery("UPDATE [BankAccount] SET balance=@balance WHERE ID=@ID", sqlParams);
        }
    }
    public class FAQs_BLL
    {
        //Métodos para DataGridView
        static public DataTable Show_FAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT question,ID_User  FROM [FAQs] WHERE isActive = 1 and isAnswered = 1", null);
        }
        static public DataTable Show_UnansweredFAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT question,ID_User FROM [FAQs] WHERE isActive = 1 and isAnswered = 0", null);
        }
        static public DataTable Show_DeactivatedFAQs()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT question,ID_User FROM [FAQs] WHERE isActive = 0", null);
        }

        //Criar, Desativar, Reativar e Responder FAQs
        static public int Create_FAQ(FAQs faq)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User",faq.ID_User),
                new SqlParameter("@answer",faq.Answer),
                new SqlParameter("@isAnswered",faq.IsAnswered),
                new SqlParameter("@question",faq.Question)
            };
            return dal.ExecuteNonQuery("INSERT INTO [FAQs] (ID_User,answer,isAnswered,question) VALUES(@ID_User,@answer,@isAnswered,@question)", sqlParams);
        }
        static public void Deativate_FAQ(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question",question)
            };
            dal.ExecuteReader("UPDATE [FAQs] SET isActive = 0 WHERE question=@question", sqlParams);
        }
        static public void Reactivate_FAQ(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question",question)
            };
            dal.ExecuteReader("UPDATE [FAQs] SET isActive = 1 WHERE question=@question", sqlParams);
        }
        static public void AnswerQuestion(string answer, string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@answer",answer),
                new SqlParameter("@question",question)
            };
            dal.ExecuteNonQuery("UPDATE [FAQs] SET isAnswered=1,answer=@answer WHERE question=@question", sqlParams);
        }

        //Métodos de Procura
        //Procurar perguntas pra evitar repitidas
        static public DataTable GetQuestion(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question", question)
            };
            return dal.ExecuteReader("SELECT question FROM [FAQs] WHERE question=@question", sqlParams);
        }

        //Procurar FAQs desativadas
        static public DataTable GetDeactivatedFAQs(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question",question)
            };
            return dal.ExecuteReader("SELECT question FROM [FAQs] WHERE question LIKE '%'+  @question + '%' AND isActive = 0", sqlParams);
        }

        //Procurar perguntas
        static public DataTable GetAnsweredQuestions(string questionFilter)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question", questionFilter)
            };
            return dal.ExecuteReader("SELECT question FROM [FAQs] WHERE question LIKE '%' + @question + '%' AND isActive = 1 AND isAnswered = 1", sqlParams);
        }
        static public DataTable GetUnansweredQuestions(string questionFilter)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question", questionFilter)
            };
            return dal.ExecuteReader("SELECT question FROM [FAQs] WHERE question LIKE '%' + @question + '%' AND isActive = 1 AND isAnswered = 0", sqlParams);
        }

        //Procurar respostas
        static public DataTable GetAnswerByQuestion(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question", question)
            };
            return dal.ExecuteReader("SELECT answer FROM [FAQs] WHERE question = @question AND isAnswered = 1", sqlParams);
        }
        static public DataTable GetUnansweredAnswerByQuestion(string question)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@question", question)
            };
            return dal.ExecuteReader("SELECT answer FROM [FAQs] WHERE question = @question AND isAnswered = 0", sqlParams);
        }
    }
    public class Holder_BLL
    {
        static public int Create_Holder(Holder holder)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User", holder.ID_User),
                new SqlParameter("@ID_BankAccount", holder.ID_BankAccount),
                new SqlParameter("@ownerShipOrder", holder.OwnershipOrder)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Holder] (ID_User,ID_BankAccount,ownerShipOrder) VALUES(@ID_User,@ID_BankAccount,@ownerShipOrder)", sqlParams);
        }
        static public void Deactivate_Holder(Holder holder)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User", holder.ID_User),
                new SqlParameter("@ID_BankAccount", holder.ID_BankAccount)
            };
            dal.ExecuteNonQuery("UPDATE [Holder] SET isActive = 0 WHERE ID_User=@ID_User AND ID_BankAccount=@ID_BankAccount", sqlParams);
        }
        static public void Reactivate_Holder(Holder holder)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User",holder.ID_User),
                new SqlParameter("@ID_BankAccount",holder.ID_BankAccount)
            };
            dal.ExecuteNonQuery("UPDATE [Holder] SET isActive = 1 WHERE ID_User=@ID_User AND ID_BankAccount=@ID_BankAccount", sqlParams);
        }

        //Buscar ID
        static public int Get_UserHolderID(int ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User", ID)
            };
            return Convert.ToInt32(dal.ExecuteScalar("SELECT ID FROM [Holder] WHERE ID_User=@ID_User", sqlParams));
        }

        //Métodos de Procura
        static public DataTable Search_Holder(int ID_User, int ID_BankAccount)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User", ID_User),
                new SqlParameter("@ID_BankAccount", ID_BankAccount)
            };
            return dal.ExecuteReader("SELECT * FROM [Holder] WHERE ID_User=@ID_User AND ID_BankAccount=@ID_BankAccount", sqlParams);
        }

        //Verificar ordem de propriedade da conta
        static public DataTable GetMaxOwnershipOrderDataTable(int bankAccountID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_BankAccount", bankAccountID)
            };
            return dal.ExecuteReader(
                "SELECT TOP 1 * FROM [Holder] WHERE ID_BankAccount=@ID_BankAccount ORDER BY ownerShipOrder DESC",
                sqlParams);
        }

        //Retorna o maior numero de ordem na prioridade
        static public int GetMaxOwnershipOrderValue(int bankAccountID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_BankAccount", bankAccountID)
            };
            object result = dal.ExecuteScalar(
                "SELECT MAX(ownerShipOrder) FROM [Holder] WHERE ID_BankAccount=@ID_BankAccount",
                sqlParams);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
    }
    public class Meal_BLL
    {
        static public DataTable Show_Meals()
        {
            DAL dal = new DAL();
            return dal.ExecuteReader("SELECT * FROM [Meal]", null);
        }
        static public int Create_Meal(Meal meal)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@date",meal.Date),
                new SqlParameter("@description", meal.Description),
                new SqlParameter("@mealImage", meal.MealImage),
                new SqlParameter("@name", meal.Name),
                new SqlParameter("@price", meal.Price),
                new SqlParameter("@type", meal.Type)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Meal] (date,description,mealImage,name,price,type) VALUES(@date,@description,@mealImage,@name,@price,@type)", sqlParams);
        }
    }
    public class Order_BLL
    {
        static public DataTable Show_TodayMeal(DateTime date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@date", date),
            };
            return dal.ExecuteReader("SELECT * FROM [Meal] WHERE @date=date", sqlParams);
        }
        static public int Create_Order(Order order)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_User", order.ID_User),
                new SqlParameter("@ID_Meal", order.ID_Meal),
                new SqlParameter("@BookedAt", order.BookedAt),
                new SqlParameter("@ID_Transaction", order.ID_Transaction)
            };
            return dal.ExecuteNonQuery("INSERT INTO [Order] (ID_User, ID_Meal, BookedAt, ID_transaction) VALUES(@ID_User, @ID_Meal, @BookedAt, @ID_Transaction)",
                sqlParams);
        }
        static public DataTable Show_UserOrdersByDate(int userID, DateTime date)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@userID", userID),
                new SqlParameter("@date", date)
            };
            return dal.ExecuteReader(
                "SELECT m.* FROM [Meal] m " +
                "INNER JOIN [Order] o ON m.ID = o.ID_Meal " +
                "WHERE o.ID_User = @userID AND CAST(m.date AS DATE) = CAST(@date AS DATE) " +
                "ORDER BY o.BookedAt DESC",
                sqlParams);
        }
    }
    public class Transaction_BLL
    {
        static public int Create_Transaction(Transaction transaction)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_Holder", transaction.ID_Holder),
                new SqlParameter("@amount", transaction.Amount),
                new SqlParameter("@dateTime",transaction.DateTime),
                new SqlParameter("@description",transaction.Description),
                new SqlParameter("@type", transaction.Type),
            };
            return dal.ExecuteNonQuery("INSERT INTO [Transaction] (ID_Holder, amount, dateTime, description, type) VALUES(@ID_Holder, @amount, @dateTime, @description,  @type)", sqlParams);
        }
        static public int Get_TransactionID(Transaction transaction)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_Holder",transaction.ID_Holder),
                new SqlParameter("@amount", transaction.Amount),
                new SqlParameter("@dateTime", transaction.DateTime),
                new SqlParameter("@description", transaction.Description)
            };
            DataTable dt = dal.ExecuteReader("SELECT ID FROM [Transaction] WHERE ID_Holder=@ID_Holder AND amount=@amount AND dateTime=@dateTime AND description=@description", sqlParams);

            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt16(dt.Rows[0]["ID"]);
            }

            return 0;
        }
        static public DataTable Show_BankAccountTransactions(int bankAccountID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID_BankAccount", bankAccountID)
            };
            return dal.ExecuteReader("SELECT * FROM [Transaction] t INNER JOIN [Holder] h ON t.ID_Holder = h.ID WHERE h.ID_BankAccount = @ID_BankAccount ORDER BY dateTime DESC", sqlParams);
        }
    }
    public class User_BLL
    {
        static public DataTable Login(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@name", user.Name)
            };
            return dal.ExecuteReader("SELECT * FROM [User] WHERE name=@name", sqlParams);
        }
        static public int Register(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@createdAt",user.CreatedAt),
                    new SqlParameter("@email",user.Email),
                    new SqlParameter("@name",user.Name),
                    new SqlParameter("@password",user.Password),
                    new SqlParameter("@phoneNumber",user.PhoneNumber),
                    new SqlParameter("@postCode",user.PostCode),
                    new SqlParameter("@profileImage",user.ProfileImage),
                    new SqlParameter("@role",user.Role),
                    new SqlParameter("@school_member_ID",user.SchoolIDNumber)
            };
            return dal.ExecuteNonQuery("INSERT INTO [User] (createdAt,email,name,password,phoneNumber,postCode,profileImage,role,school_member_ID) VALUES(@createdAt,@email,@name,@password,@phoneNumber,@postCode,@profileImage,@role,@school_member_ID)", sqlParams);
        }
        static public void Deactivate_User(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@ID", user.ID)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET isActive = 0 WHERE ID=@ID", sqlParams);
        }
        static public void Reactivate_User(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID", user.ID)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET isActive = 1 WHERE ID=@ID", sqlParams);
        }

        //Para guardar dados do utilizador de sessão
        static public DataTable Save(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@name", user.Name)
            };
            return dal.ExecuteReader("SELECT * FROM [User] WHERE name=@name", sqlParams);
        }
        static public void UpdateUser(User user)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@ID",user.ID),
                new SqlParameter("@email",user.Email),
                new SqlParameter("@name",user.Name),
                new SqlParameter("@password",user.Password),
                new SqlParameter("@phoneNumber",user.PhoneNumber),
                new SqlParameter("@PostCode",user.PostCode),
                new SqlParameter("@school_member_ID",user.SchoolIDNumber)
            };
            dal.ExecuteNonQuery("UPDATE [User] SET email=@email,name=@name,password=@password,phoneNumber=@phoneNumber,PostCode=@PostCode,school_member_ID=@school_member_ID WHERE ID=@ID", sqlParams);
        }

        //Métodos de Procura
        static public object Search_Email(string email)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter ("@email",email),
            };

            return dal.ExecuteScalar("SELECT email FROM [User] WHERE email=@email", sqlParams);
        }
        static public object Search_Name(string name)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@name",name),
            };
            return dal.ExecuteScalar("SELECT name FROM [User] WHERE name=@name", sqlParams);
        }
        static public object Search_PhoneNumber(string phoneNumber)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@phoneNumber", phoneNumber)
            };
            return dal.ExecuteScalar("SELECT phoneNumber FROM [User] WHERE phoneNumber=@phoneNumber", sqlParams);
        }
        static public object Search_SchoolMemberID(string school_member_ID)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@school_member_ID", school_member_ID)
            };
            return dal.ExecuteScalar("SELECT school_member_ID  FROM [User] WHERE school_member_ID=@school_member_ID", sqlParams);
        }

        static public DataTable Has_BankAccount(int ID_User)
        {
            DAL dal = new DAL();
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                    new SqlParameter("@ID_User",ID_User)
            };
            return dal.ExecuteReader("SELECT * FROM [Holder] WHERE ID_User=@ID_User", sqlParams);
        }

        public class Admin
        {
            static public DataTable Show_Admins()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT * FROM [User] WHERE role=0", null);
            }
        }
        public class Employee
        {
            static public DataTable Show_Employees()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT * FROM [User] WHERE role=1", null);
            }
        }
        public class Student
        {
            static public DataTable Show_Students()
            {
                DAL dal = new DAL();
                return dal.ExecuteReader("SELECT * FROM [User] WHERE role=2", null);
            }
        }
    }
}