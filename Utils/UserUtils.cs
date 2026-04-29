using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data;
using System;

namespace MealSync_APP.Utils
{
    public class UserValidator
    {
        //Métodos de Procura
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

        //Métodos de Autenticação
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
    }
    public class UserAuth : UserValidator //Auth --> Authtorize
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
        static public ValidatorResult Login(string name, string password)
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
    public class UserData
    {
        static public ValidatorResult Save(string name)
        {
            var result = new ValidatorResult();
            try
            {
                DataTable dt = BLL.User.Get_UserByName(name);
                if (dt.Rows.Count != 0)
                {
                    User.ID = Convert.ToInt16(dt.Rows[0][0]);
                    User.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    User.Email = dt.Rows[0][2].ToString();
                    User.Name = dt.Rows[0][3].ToString();
                    User.Role = Convert.ToInt16(dt.Rows[0][5]);
                    
                    result.IsValid = true;
                    return result;
                }
                else
                {
                    result.IsValid = false; result.errorMessage = "Utlizador não encontrado";
                    return result;
                }
            }
            catch (Exception err)
            {
                result.IsValid = false; result.errorMessage = "Ocorreu um erro ao tentar salvar o dados do utilizador: " + err.Message;
                return result;
            }
            finally
            {
                if (result.IsValid == false)
                {
                    MessageBox.Show(result.errorMessage);
                }
            }

        }
        static public void Reset()
        {
            User.ID = 0;
            User.CreatedAt = DateTime.MinValue;
            User.Email = string.Empty;
            User.Name = string.Empty;
            User.Role = -1;
        }
    }
}
    