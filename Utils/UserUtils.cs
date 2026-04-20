using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Utils
{
    public class UserUtils
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
        public static bool Auth_UserRegister(DateTime createdAt, string email, string name, string password, string passwordConfirm,int role)
        {
            return
                Search_User(email,name) &&
                Auth_UserDateTime(createdAt) &&
                Auth_UserEmail(email) &&
                Auth_UserName(name) &&
                Auth_UserPassword(password) &&
                Auth_PasswordRegister(password,passwordConfirm) &&
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
        static private bool ValidateUserName(string name)
        {
            return true;
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
            //Ainda falta as verificações
            return true;
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

        //Autenticação para Login
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

        //Autenticaçãp para Register
        static private bool Auth_PasswordRegister(string password, string passwordConfirm)
        {
           if(password == passwordConfirm)
            {
                if(password.Length > 7)
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

        //Métodos de Procura
        static private bool Search_UserName(string name)
        {
            DataTable dt = BLL.User.Search_UserName(name);
            if(dt.Rows.Count >= 1)
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
            if(dt.Rows.Count >= 1)
            {
                MessageBox.Show("Já existe um utilizador com este email");
                return false;
            }
            else
            {
                return true;
            }
        }

        static protected ValidatorResult IsUserNameTaken(string name)
        {
            try
            {
                DataTable dt = BLL.User.Search_UserName(name);
                if (dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este nome não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao procurar o nome do utilizador "+err.Message};
            }
        }
        static protected ValidatorResult IsUserEmailTaken(string email)
        {
            try
            {
                DataTable dt = BLL.User.Search_UserEmail(email);
                if(dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este email não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage= "Ocorreu um erro ao procurar o email do utilizador "+err.Message};
            }
        }

        static protected ValidatorResult Validate_UserEmail(string email)
        {
            try
            { 
                if (email.Contains("@"))
                {
                    if (email.EndsWith(".com") || email.EndsWith(".pt"))
                    {
                        if (email.Length >= 10)
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "Email muito curto" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "Email deve terminar com '.com' ou '.pt'" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Email tem que conter '@' " };
                }
            }
            catch (Exception err) 
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [email]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_UserName(string name)
        {
            try
            {
                if (!String.IsNullOrEmpty(name))
                {
                    if (name.Length >= 3)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O campo [nome] não pode estar vazio" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "nome muito curto" };
                }
            }
            catch(Exception err) 
            {
                return new ValidatorResult { IsValid = false, errorMessage= "Ocorreu um erro ao tentar validar o campo [nome]: "+err.Message };
            }
        }
        static protected ValidatorResult Validate_UserPassword(string password)
        {
            try
            {
                if (!String.IsNullOrEmpty(password))
                {
                    if (password.Length >= 7)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "password muito fraca" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "campo [password] não pode estar vazio" };
                }
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid=false, errorMessage = "Ocorreu um erro ao tentar validar o campo [password]: "+ err.Message };
            }
        }
        static protected ValidatorResult Validate_UserRole(int role)
        {
            try
            {
                if (role < 0 || role > 3)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Campo [função] invalido" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao Validar o campo [função]: " + err.Message };
            }
        }

        //Métodos de Verificação secundarios
        static protected ValidatorResult PasswordConfirm(string password, string passwordConfirm)
        {
            if (password != passwordConfirm)
                return new ValidatorResult { IsValid = false, errorMessage = "Password's não coincidem" };
            else
                return new ValidatorResult { IsValid = true };
        }

        static protected ValidatorResult Can_UserLogin(string name, string password)
        {
            try
            {
                DataTable dt = BLL.User.Get_UserByName(name);
                if (dt.Rows.Count != 0)
                {
                    if (password == dt.Rows[0][4].ToString())
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "Password Incorreta" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Utilizador não existe" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar fazer Login: " + err.Message };
            }
        }
    }
    public class Auth : UserUtils//Auth --> Authtorize
    {
        static public void Register(string email, string name, string password, string passwordConfirm, int role)
        {
            ValidatorResult validateEmail = Validate_UserEmail(email);
            ValidatorResult isEmailTaken = IsUserEmailTaken(email);

            ValidatorResult validateName = Validate_UserName(name);
            ValidatorResult isNameTaken = IsUserNameTaken(name);

            ValidatorResult validatePassword = Validate_UserPassword(password);
            ValidatorResult pswdConfirm = PasswordConfirm(password, passwordConfirm);

            ValidatorResult validateRole = Validate_UserRole(role);

            //Email
            if (!validateEmail.IsValid)
            {
                MessageBox.Show(validateEmail.errorMessage);
                return;
            }
            if (!isEmailTaken.IsValid)
            {
                MessageBox.Show(isEmailTaken.errorMessage);
                return;
            }
            //Name
            if (!validateName.IsValid)
            {
                MessageBox.Show(validateName.errorMessage);
                return;
            }
            if (!isNameTaken.IsValid)
            {
                MessageBox.Show(isNameTaken.errorMessage);
            }
            //Password
            if (!validatePassword.IsValid)
            {
                MessageBox.Show(validatePassword.errorMessage);
                return;
            }
            if(!pswdConfirm.IsValid)
            {
                MessageBox.Show(pswdConfirm.errorMessage);
            }
            //Role -> Função
            if (!validateRole.IsValid)
            {
                MessageBox.Show(validateRole.errorMessage);
                return;
            }
        }
        static public void Login(string name, string password)
        {
            ValidatorResult validateName = Validate_UserName(name);
            ValidatorResult validatePassword = Validate_UserEmail(password);
            ValidatorResult canUserLogin = Can_UserLogin(name, password);

            if (!validatePassword.IsValid)
            {
                MessageBox.Show(validatePassword.errorMessage);
                return;
            }
            if (!validateName.IsValid)
            {
                MessageBox.Show(validatePassword.errorMessage);
                return;
            } 
            if (!canUserLogin.IsValid)
            {
                MessageBox.Show(canUserLogin.errorMessage);
                return;
            }
        }
    }
    public class UserData
    {
        static public ValidatorResult Save(string name)
        {
            ValidatorResult result = new ValidatorResult();

            try
            {
                DataTable dt = BLL.User.Get_UserByName(name);
                if (dt.Rows.Count != 0)
                {
                    Globals.User.ID = Convert.ToInt16(dt.Rows[0][0]);
                    Globals.User.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    Globals.User.Email = dt.Rows[0][2].ToString();
                    Globals.User.Name = dt.Rows[0][3].ToString();
                    Globals.User.Role = Convert.ToInt16(dt.Rows[0][4]);

                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Utilizador não encontrado" };
                }
            }
            catch(Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar salvar o dados do utilizador: " + err.Message };
            }
            finally
            {
                if(result.IsValid == false)
                    MessageBox.Show(result.errorMessage);
            }

        }
        static public void Reset()
        {
            Globals.User.ID = 0;
            Globals.User.CreatedAt = DateTime.MinValue;
            Globals.User.Email = string.Empty;
            Globals.User.Name = string.Empty;
            Globals.User.Role = -1;
        }
    }
    public class ValidatorResult
    {
        public bool IsValid { get; set; }
        public string errorMessage { get; set; }
    }
}
    