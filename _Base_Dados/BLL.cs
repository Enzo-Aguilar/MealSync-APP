using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public class Auxiliar
        {
            public class Procurar 
            {
                public class Utilizador
                {
                    static public DataTable Procurar_ID(int ID)
                    {
                        DAL dal = new DAL();
                        SqlParameter[] sqlParams = new SqlParameter[]
                        {
                    new SqlParameter("@ID",ID)
                        };
                        return dal.executarReader("SELECT ID FROM Utilizador WHERE ID=@ID", sqlParams);
                    }
                    static public DataTable Procurar_Email(string email)
                    {
                        DAL dal = new DAL();
                        SqlParameter[] sqlParams = new SqlParameter[]
                        {
                    new SqlParameter("@email",email)
                        };
                        return dal.executarReader("SELECT email FROM Utilizador WHERE email=@email", sqlParams);
                    }
                    static public DataTable Procurar_Nome(string nome)
                    {
                        DAL dal = new DAL();
                        SqlParameter[] sqlParams = new SqlParameter[]
                        {
                    new SqlParameter("@nome",nome)
                        };
                        return dal.executarReader("SELECT nome FROM Utilizador WHERE nome=@nome", sqlParams);
                    }
                }
            }
        }
        public class ContaBancaria
        {
            static public int Criar(string tipo,string password)
            {
                //Randomizar o IBAN
                Random random = new Random();
                int rnd = random.Next(0, 10000000);

                //Guardar valor da data de criação da conta
                DateTime dataCriacao = DateTime.Now;

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@data",dataCriacao),
                    new SqlParameter("@IBAN",rnd),
                    new SqlParameter("@saldo",1.36), //Bonus de presente
                    new SqlParameter("@password", password), //Password para associar/criar a conta bancária
                    new SqlParameter("@tipo",tipo)//Aprazo, Ordenado
                };
                return dal.executarNonQuery("INSERT INTO ContaBancaria (data,IBAN,saldo,password,tipo) VALUES(@data,@IBAN,@saldo,@password,@tipo)",sqlParams);
            }   
            static public DataTable Mostrar()
            {
                DAL dal = new DAL();
                return dal.executarReader("SELECT ID,data,IBAN FROM ContaBancaria", null);
            }
            static public DataTable Procurar_PorID(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@ID",id)
                };
                return dal.executarReader("SELECT * FROM ContaBancaria WHERE ID=@ID", sqlParams);
            }
        }
        public class Utilizador 
        {
            static public int Criar(DateTime dataCriacao, string email, string funcao, string nome, string password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@dataCriacao",dataCriacao),
                    new SqlParameter("@email",email),
                    new SqlParameter("@funcao",funcao),
                    new SqlParameter("@nome",nome),
                    new SqlParameter("@password",password)
                };

                return dal.executarNonQuery("INSERT INTO Utilizador (datacriacao, email, funcao, nome, password) VALUES(@dataCriacao, @email, @funcao, @nome, @password)",sqlParams);
            }
            static public DataTable Mostrar()
            {
                DAL dal = new DAL();
                return dal.executarReader("SELECT * FROM Utilizadores",null);
            }
            static public DataTable Procurar_porNome(string nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@nome",nome)
                };
                return dal.executarReader("SELECT * FROM [Utilizador] WHERE nome=@nome", sqlParams);
            }
            public class Titular
            {
                static public int Associar(int ID_Utilizador, int ID_ContaBancaria)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]
                    {
                        new SqlParameter("@ID_Titular",ID_Utilizador),
                        new SqlParameter("@ID_ContaBancaria",ID_ContaBancaria),
                        //Falta verificar se já existem titulares e adicionar depois
                    };

                    return dal.executarNonQuery("INSERT INTO Titular (ID_Titular,ID_ContaBancaria) VALUES(@ID_Titular,@ID_ContaBancaria)", sqlParams);
                }
            }
        }
        public class Exemplo
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Clientes", null);
            }
            static public int insertCliente(string nome, string morada, string telefone)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@telefone", telefone)
				};

                return dal.executarNonQuery("INSERT into Clientes (Nome,Morada,Telefone) VALUES(@nome,@morada,@telefone)", sqlParams);
            }
            static public DataTable queryClienteLike(String nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome + "%")
                };
                return dal.executarReader("select * from Clientes where Nome like @nome", sqlParams);
            }
            static public DataTable queryClientePorId(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from Clientes where ID=@id", sqlParams);
            }
            static public DataTable queryClientePorIdENome(int id, string nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                 new SqlParameter("@Nome", nome)
                };
                return dal.executarReader("select * from Clientes where ID=@id and Nome=@nome", sqlParams);
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
                return dal.executarNonQuery("update [Clientes] set [nome]=@nome, [morada]=@morada, [telefone]=@telefone where [id]=@id", sqlParams);
            }
            static public int deleteCliente(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),

            };
                return dal.executarNonQuery("Delete From Clientes WHERE[id]=@id", sqlParams);
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
                return dal.executarScalar("select Img from Imagem where id=@id", sqlParams);

            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Imagem", null);
            }

            static public int insertImagem(byte[] img)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@img", img),

           };

                return dal.executarNonQuery("INSERT into Imagem (Img) VALUES(@img)", sqlParams);
            }
        }
    }
}