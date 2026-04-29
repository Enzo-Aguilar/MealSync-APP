using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data;
using System;
using System.Linq;

namespace MealSync_APP.Utils
{
    public class UserValidator
    {
        //Métodos de Procura
        static protected ValidatorResult IsNameTaken(string name)
        {
            try
            {
                DataTable dt = BLL.User.Search_Name(name);
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
        static protected ValidatorResult IsEmailTaken(string email)
        {
            try
            {
                DataTable dt = BLL.User.Search_Email(email);
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
        static protected ValidatorResult IsPhoneNumberTaken(string phoneNumber)
        {
            try
            {
                DataTable dt = BLL.User.Search_PhoneNumber(phoneNumber);
                if (dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este número de telefone já está associado a outro utilizador" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao procurar o número de telefone do utilizador " + err.Message };
            }
        }

        //Métodos de Autenticação
        static protected ValidatorResult Validate_Email(string email)
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
        static protected ValidatorResult Validate_Name(string name)
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
        static protected ValidatorResult Validate_Password(string password)
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
        static protected ValidatorResult Validate_Role(int role)
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
        static protected ValidatorResult Validate_PhoneNumber(string phoneNumber)
        {
            try
            {
                if (!String.IsNullOrEmpty(phoneNumber))
                {
                    if (phoneNumber.Length == 9)
                    {
                        if (!phoneNumber.Contains("a"))//Verificar qualquer letra
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de telefone] deve conter apenas números" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de telefone] deve conter 9 dígitos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de telefone] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [número de telefone]: " + err.Message };
            } 
        }
        static protected ValidatorResult Validate_IDNumber(string IDNumber)
        {
            try
            {
                if (!String.IsNullOrEmpty(IDNumber))
                {
                    if (IDNumber.Length == 9)
                    {
                        if (!IDNumber.Equals("000000000") || !IDNumber.Equals("111111111"))
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação] com sequencia de dígitos inválida" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação] deve conter 9 dígitos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [número de identificação]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_Postcode(string postcode)
        {
            try
            {
                if (!String.IsNullOrEmpty(postcode))
                {
                    if (postcode.Length == 8)
                    {
                        if (postcode[4] == '-')
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "O campo [código postal] deve conter um hífen no meio" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O campo [código postal] deve conter 8 caracteres" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O campo [código postal] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [código postal]: " + err.Message };
            }
        }

        //Métodos de Verificação secundarios
        static protected ValidatorResult PasswordConfirm(string password, string passwordConfirm)
        {
            if (password != passwordConfirm)
                return new ValidatorResult { IsValid = false, errorMessage = "Palavras-Passe não coincidem" };

            return new ValidatorResult { IsValid = true };
        }
    }
    public class UserAuth : UserValidator //Auth --> Authtorize
    {
        static public void Register(string email, string name, string password, string passwordConfirm, int role, string phoneNumber, string idNumber, string postcode)
        {
            var validateEmail = Validate_Email(email);
            var isEmailTaken = IsEmailTaken(email);

            var validateName = Validate_Name(name);
            var isNameTaken = IsNameTaken(name);

            var validatePassword = Validate_Password(password);
            var pswdConfirm = PasswordConfirm(password, passwordConfirm);

            var validateRole = Validate_Role(role);

            var validatePhoneNumber = Validate_PhoneNumber(phoneNumber);
            var isPhoneNumberTaken = IsPhoneNumberTaken(phoneNumber);

            var validateIDNumber = Validate_IDNumber(idNumber);

            var validatePostcode = Validate_Postcode(postcode);
            
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
            ValidatorResult result = new ValidatorResult();
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
    