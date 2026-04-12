using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Utils
{
    internal class UserUtils
    {
        static public void Get_UserData(string name)
        {
            try
            {
                DataTable dt = BLL.User.Get_UserByName(name);

                if (dt.Rows.Count != 0)
                {
                    Globals.User.ID = Convert.ToInt16(dt.Rows[0][0]);
                    Globals.User.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    Globals.User.Email = dt.Rows[0][2].ToString();
                    Globals.User.Name = dt.Rows[0][3].ToString();
                    Globals.User.Role = Convert.ToInt16(dt.Rows[0][5]);
                }
                else
                {
                    MessageBox.Show("Utilizador não encontrado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message, "Error");
            }
        }
        static public void Reset_UserData()
        {
            Globals.User.ID = 0;
            Globals.User.CreatedAt = DateTime.MinValue;
            Globals.User.Email = string.Empty;
            Globals.User.Name = string.Empty;
            Globals.User.Role = -1;
        }
        static public bool Auth_UserLogin(string name, string password)
        {
            return Auth_UserName(name) && Auth_PasswordLogin(name, password);
        }
        public static bool Auth_UserRegister(DateTime createdAt, string email, string name, string password, int role)
        {
            return
                Search_User(email,name) &&
                Auth_UserDateTime(createdAt) &&
                Auth_UserEmail(email) &&
                Auth_UserName(name) &&
                Auth_UserPassword(password) &&
                Auth_UserRole(role);

        } 
        public static bool Search_User(string email,string name)
        {
            return
                Search_UserEmail(email) &&
                Search_UserName(name);
        }
        


        //Métodos de Autenticação
        static private bool Auth_UserName(string name)
        {
            try
            {
                DataTable dt = BLL.User.Get_UserByName(name);

                if (dt.Rows.Count != 0)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        if (name.Length >= 3)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Utilizador não existe");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
                return false;
            }
        }
        static private bool Auth_UserPassword(string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(password))
                {
                    if (password.Length >= 8)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Password fraca");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Campo [Password] Vazio");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
                return false;
            }
        }
        static private bool Auth_UserDateTime(DateTime createdAt)
        {
            if(createdAt < DateTime.UtcNow || createdAt > DateTime.UtcNow)
            {
                MessageBox.Show("Data Invalida");
                return false;
            }
            else
            {
                return true;
            }
        }
        static private bool Auth_UserEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email invalido");
                return false;
            }
            else
            {
                return true;
            }
        }
        static private bool Auth_UserRole(int role)
        {
            if(role < 0  || role > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static private bool Auth_PasswordLogin(string name, string password)
        {
            DataTable dt = BLL.User.Get_UserByName(name);
            string dtPassword = dt.Rows[0][4].ToString();
            if (dtPassword != password)
            {
                MessageBox.Show("Password Incorreta");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Métodos de Procura
        static private bool Search_UserName(string name)
        {
            DataTable dt = BLL.User.Search_UserName(name);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Já existe um utilizador com este nome");
                return false;
            }
            else
            {
                return true;
            }
        }
        static private bool Search_UserEmail(string email)
        {
            DataTable dt = BLL.User.Search_UserEmail(email);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Já existe um utilizador com este email");
                return false;
            }
            else
            {
                return true;
            }
        }


        //IsAdmin verificação
        static public int IsAdmin()
        {
            switch (Globals.User.Role)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
            }

            return 0;
        }
        
    }
}
