using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

namespace BusinessLogicLayer
{
    public class BLL
    {
        
        public class User
        {
            static protected readonly string _tableName = "[User]";
            static public int Create_User(DateTime createdAt, string email, string name, string password, int role)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@createdAt",createdAt),
                    new SqlParameter("@email",email),
                    new SqlParameter("@name",name),
                    new SqlParameter("@password",password),
                    new SqlParameter("@role",role)
                };
                return dal.ExecuteNonQuery("INSERT INTO [User] (createdAt,email,name,password,role) VALUES(@createdAt,@email,@name,@password,@role)", sqlParams);
            }
            
            //Buscar dados do User pelo Nome
            static public DataTable Get_UserByName(string name)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@name",name)
                };
                return dal.ExecuteReader("SELECT * FROM [User] WHERE name=@name", sqlParams);
            }

            //Métodos de Procura
            static public DataTable Search_UserEmail(string email)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter ("@email",email),
                };

                return dal.ExecuteReader("SELECT * FROM " + _tableName + " WHERE email=@email",sqlParams);
            }
            static public DataTable Search_UserName(string name)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@name",name),
                };
                return dal.ExecuteReader("SELECT * FROM [User] WHERE name=@name",sqlParams);
            }
        }
        public class Holder
        {
            static public bool isUserHolder(int userID)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@ID_User",userID)
                };
                DataTable table= dal.ExecuteReader("SELECT * FROM [Holder] WHERE userID=@ID_User", sqlParams);
                if(table.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
        }
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
}