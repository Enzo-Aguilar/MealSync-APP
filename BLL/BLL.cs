using System.Data.SqlClient;
using MealSync_APP.Globals;
using DataAccessLayer;
using MealSync_APP;
using System.Data;
using System;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
	public class BLL
	{
		public class Exemplo
		{

			static public DataTable Load()
			{
				DAL dal = new DAL();
				return dal.ExecuteReader("select * from Clientes", null);
			}
			static public int insertCliente(string nome, string morada, string telefone)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@nome", nome),
				new SqlParameter("@morada", morada),
				new SqlParameter("@telefone", telefone)
				};

				return dal.ExecuteNonQuery("INSERT into Clientes (Nome,Morada,Telefone) VALUES(@nome,@morada,@telefone)", sqlParams);
			}
			static public DataTable queryClienteLike(String nome)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@nome", nome + "%")
				};
				return dal.ExecuteReader("select * from Clientes where Nome like @nome", sqlParams);
			}
			static public DataTable queryClientePorId(int id)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@id", id)
				};
				return dal.ExecuteReader("select * from Clientes where ID=@id", sqlParams);
			}
			static public DataTable queryClientePorIdENome(int id, string nome)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@id", id),
				 new SqlParameter("@Nome", nome)
				};
				return dal.ExecuteReader("select * from Clientes where ID=@id and Nome=@nome", sqlParams);
			}
			static public int updateCliente(string id, string nome, string morada, string telefone)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@id", id),
				new SqlParameter("@nome", nome),
				new SqlParameter("@morada", morada),
				new SqlParameter("@telefone", telefone)
			};
				return dal.ExecuteNonQuery("update [Clientes] set [nome]=@nome, [morada]=@morada, [telefone]=@telefone where [id]=@id", sqlParams);
			}
			static public int deleteCliente(string id)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@id", id),

			};
				return dal.ExecuteNonQuery("Delete From Clientes WHERE[id]=@id", sqlParams);
			}
		}
		public class Imagem
		{
			static public object loadpic()
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@id", 1),
			 };
				return dal.ExecuteScalar("select Img from Imagem where id=@id", sqlParams);

			}
			static public DataTable Load()
			{
				DAL dal = new DAL();
				return dal.ExecuteReader("select * from Imagem", null);
			}

			static public int insertImagem(byte[] img)
			{
				DAL dal = new DAL();
				SqlParameter[] sqlParams = new SqlParameter[]{
				new SqlParameter("@img", img),

		   };

				return dal.ExecuteNonQuery("INSERT into Imagem (Img) VALUES(@img)", sqlParams);
			}
		}
	}
	public class BankAccount_BLL
	{
		static public int Create_BankAccount(BankAccount bkAccount)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
				new SqlParameter("@accountType", bkAccount.AccountType),
				new SqlParameter("@balance", bkAccount.Balance),
				new SqlParameter("@createdAt", bkAccount.CreatedAt),
				new SqlParameter("@IBAN", bkAccount.IBAN),
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


		//Mostrar todas as contas bancárias
		static public DataTable Show_BankAccounts()
		{
			DAL dal = new DAL();
			return dal.ExecuteReader("SELECT ID, accountType,IBAN FROM [BankAccount]", null);
		}

		//Tabela que mostra o user e contas associadas (apenas contas coletivas com ownerShipOrder = 1 e que ainda permitem novos utilizadores - máx 7)
		static public DataTable DataTable_BkAccount_With_OwnerData()
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
				null);
		}
		static public DataTable DataTable_DeactivatedBkAccount_With_OwnerData()
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
				null);
		}

		//Detalhes da conta bancária
		static public DataTable GetBankAccountDetails(BankAccount bkAccount)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
				new SqlParameter("@ID", bkAccount.ID)
			};
			return dal.ExecuteReader("SELECT * FROM [BankAccount] WHERE ID=@ID", sqlParams);
		}
	}
	public class FAQs_BLL
	{
		static public DataTable Show_FAQs()
		{
			DAL dal = new DAL();
			return dal.ExecuteReader("SELECT question,ID_User  FROM [FAQs] WHERE isActive = 1 and isAnswered = 1", null);
		}
		static public DataTable Show_UnansweredFAQs()
		{
			DAL dal = new DAL();
			return dal.ExecuteReader("SELECT question FROM [FAQs] WHERE isActive = 1 and isAnswered = 0", null);
		}
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
		static public void Deativate_FAQ(FAQs faq)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
				new SqlParameter("@ID",faq.ID)
			};
			dal.ExecuteReader("UPDATE [FAQs] SET isActive = 0 WHERE ID=@ID", sqlParams);
		}

		//Métodos de Procura
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
					new SqlParameter("@role",user.Role),
					new SqlParameter("@postalCode",user.PostalCode),
					new SqlParameter("@school_member_ID",user.SchoolIDNumber)
			};
			return dal.ExecuteNonQuery("INSERT INTO [User] (createdAt,email,name,password,phoneNumber,role,postalCode,school_member_ID) VALUES(@createdAt,@email,@name,@password,@phoneNumber,@role,@postalCode,@school_member_ID)", sqlParams);
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

		//Métodos de Procura
		static public DataTable Search_Email(string email)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
					new SqlParameter ("@email",email),
			};

			return dal.ExecuteReader("SELECT * FROM [User] WHERE email=@email", sqlParams);
		}
		static public DataTable Search_Name(string name)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
					new SqlParameter("@name",name),
			};
			return dal.ExecuteReader("SELECT * FROM [User] WHERE name=@name", sqlParams);
		}
		static public DataTable Search_PhoneNumber(string phoneNumber)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
					new SqlParameter("@phoneNumber", phoneNumber)
			};
			return dal.ExecuteReader("SELECT * FROM [User] WHERE phoneNumber=@phoneNumber", sqlParams);
		}
		static public DataTable Search_SchoolMemberID(string school_member_ID)
		{
			DAL dal = new DAL();
			SqlParameter[] sqlParams = new SqlParameter[]
			{
					new SqlParameter("@school_member_ID", school_member_ID)
			};
			return dal.ExecuteReader("SELECT * FROM [User] WHERE school_member_ID=@school_member_ID", sqlParams);
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