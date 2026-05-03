using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data;
using System;
using System.Linq;
using MealSync_APP.Globals;
using System.Security.Cryptography;
using System.Globalization;

namespace MealSync_APP.Utils
{
    public class UserValidator
    {
        //Métodos de Procura
        static protected ValidatorResult IsNameTaken(string name)
        {
            try
            {
                DataTable dt = User_BLL.Search_Name(name);
                if (dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este nome não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao procurar o nome do utilizador " + err.Message };
            }
        }
        static protected ValidatorResult IsEmailTaken(string email)
        {
            try
            {
                DataTable dt = User_BLL.Search_Email(email);
                if (dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este email não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao procurar o email do utilizador " + err.Message };
            }
        }
        static protected ValidatorResult IsPhoneNumberTaken(string phoneNumber)
        {
            try
            {
                DataTable dt = User_BLL.Search_PhoneNumber(phoneNumber);
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
        static protected ValidatorResult IsSchoolMemberIDTaken(string school_member_ID)
        {
            try
            {
                DataTable dt = User_BLL.Search_SchoolMemberID(school_member_ID);
                if (dt.Rows.Count >= 1)
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Este número de identificação escolar já está associado a outro utilizador" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }

            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao procurar o número de identificação escolar do utilizador " + err.Message };
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
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [nome]: " + err.Message };
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
        static protected ValidatorResult Validate_SchoolMemberID(string schoolMemberID)
        {
            try
            {
                if (!String.IsNullOrEmpty(schoolMemberID))
                {
                    if (schoolMemberID.Length == 6)
                    {
                        if (!schoolMemberID.Equals("000000") || !schoolMemberID.Equals("111111"))
                        {
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação escolar] com sequencia de dígitos inválida" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação escolar] deve conter 6 dígitos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "O campo [número de identificação escolar] não pode estar vazio" };
                }

            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro ao tentar validar o campo [número de identificação escolar]: " + err.Message };
            }
        }

        //Métodos de Verificação secundarias
        static protected ValidatorResult PasswordConfirm(string password, string passwordConfirm)
        {
            if (password != passwordConfirm)
                return new ValidatorResult { IsValid = false, errorMessage = "Palavras-Passe não coincidem" };

            return new ValidatorResult { IsValid = true };
        }
    }
    public class UserAuth : UserValidator
    {
        static public ValidatorResult Register(User user, string passwordConfirm)
        {
            var checks = new[]
            {
                Validate_Email(user.Email),
                IsEmailTaken(user.Email),
                Validate_Name(user.Name),
                IsNameTaken(user.Name),
                Validator.Validate_Password(user.Password),
                PasswordConfirm(user.Password, passwordConfirm),
                Validate_Role(user.Role),
                Validate_PhoneNumber(user.PhoneNumber),
                IsPhoneNumberTaken(user.PhoneNumber),
                Validate_Postcode(user.PostalCode),
                Validate_SchoolMemberID(user.SchoolIDNumber),
               IsSchoolMemberIDTaken(user.SchoolIDNumber),
            };

            foreach (var result in checks)
            {
                if (!result.IsValid) return result;
            }
            user.Password = Encryptor.Encrypt(user.Password);
            User_BLL.Register(user);
            return new ValidatorResult { IsValid = true };
        }
        static public ValidatorResult Login(User user)
        {
            try
            {
                DataTable dt = User_BLL.Login(user);
                if (dt.Rows.Count != 0)
                {
                    string hashedPassword = dt.Rows[0][5].ToString();
                    if (user.Password == Encryptor.Decrypt(hashedPassword))
                    {
                        UserData.Save(user);
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, errorMessage = "nome ou palavra-passe incorretos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, errorMessage = "Não existe utilizadores com estas credenciais" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, errorMessage = "Ocorreu um erro inesperado ao tentar fazer login: " + err.Message };
            }
        }
    }
    public class UserData
    {
        static public ValidatorResult Save(User user)
        {
            var result = new ValidatorResult();
            try
            {
                DataTable dt = User_BLL.Save(user);
                if (dt.Rows.Count != 0)
                {
                    Data.CurrentUser.ID = Convert.ToInt16(dt.Rows[0][0]);
                    Data.CurrentUser.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    Data.CurrentUser.Email = dt.Rows[0][2].ToString();
                    Data.CurrentUser.IsActive = true;
                    Data.CurrentUser.Name = dt.Rows[0][4].ToString();
                    //Data.currentUser.Password = dt.Rows[0][5].ToString();
                    Data.CurrentUser.PhoneNumber = dt.Rows[0][6].ToString();
                    Data.CurrentUser.Role = Convert.ToInt16(dt.Rows[0][7]);
                    Data.CurrentUser.PostalCode = dt.Rows[0][8].ToString();
                    Data.CurrentUser.SchoolIDNumber = dt.Rows[0][9].ToString();

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
            Data.CurrentUser.ID = -1;
            Data.CurrentUser.CreatedAt = DateTime.MinValue;
            Data.CurrentUser.Email = string.Empty;
            Data.CurrentUser.IsActive = false;
            Data.CurrentUser.Name = string.Empty;
            Data.CurrentUser.Password = string.Empty;
            Data.CurrentUser.PhoneNumber = string.Empty;
            Data.CurrentUser.Role = -1;
            Data.CurrentUser.PostalCode = string.Empty;
            Data.CurrentUser.SchoolIDNumber = string.Empty;
        }
    }
}
    