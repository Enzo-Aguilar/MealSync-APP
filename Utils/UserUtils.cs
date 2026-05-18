using MealSync_APP.Globals;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data;
using System;
using System.Collections.Generic;


namespace MealSync_APP.Utils
{
    public class UserValidator : User_BLL
    {
        //Métodos de Procura
        static protected ValidatorResult IsNameTaken(string name)
        {
            try
            {
                if (Search_Name(name) != null)
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Este nome não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao procurar o nome do utilizador " + err.Message };
            }
        }
        static protected ValidatorResult IsEmailTaken(string email)
        {
            try
            {
                if (Search_Email(email) != null)
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Este email não está disponivel" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao procurar o email do utilizador " + err.Message };
            }
        }
        static protected ValidatorResult IsPhoneNumberTaken(string phoneNumber)
        {
            try
            {
                if (Search_PhoneNumber(phoneNumber) != null)
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Este número de telemovel já está associado a outro utilizador" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao procurar o número de telefone do utilizador " + err.Message };
            }
        }
        static protected ValidatorResult IsSchoolMemberIDTaken(string school_member_ID)
        {
            try
            {
                if (Search_SchoolMemberID(school_member_ID) != null)
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Este número de identificação escolar já está associado a outro utilizador" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao procurar o número de identificação escolar do utilizador " + err.Message };
            }
        }

        //Métodos de Autenticação
        static protected ValidatorResult Validate_Email(string email)
        {
            List<string> possibleDomains = new List<string>{ "gmail", "outlook", "icloud", "sapo", "epge"};
            try
            {
                if (email.Contains("@"))
                {
                    if (email.EndsWith(".com") || email.EndsWith(".pt"))
                    {
                        if (email.Length >= 10)
                        {
                            foreach(string d in possibleDomains)
                            {
                                if (email.Contains(d))
                                {
                                    return new ValidatorResult { IsValid = true };
                                }
                            }
                            return new ValidatorResult { IsValid = false, ErrorMessage = "O dominio do email é invalido" };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, ErrorMessage = "Email muito curto" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "Email deve terminar com '.com' ou '.pt'" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Email tem que conter '@' " };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar validar o campo [email]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_Name(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (name.Length >= 3)
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [nome] não pode estar vazio" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "nome muito curto" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar validar o campo [nome]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_Role(int role)
        {
            try
            {
                if (role < 0 || role > 3)
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Campo [função] invalido" };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao Validar o campo [função]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_PhoneNumber(string phoneNumber)
        {
            List<string> fakeNumbers = new List<string> {"123456789","000000000","111111111","222222222" };//Adicionar mais
            try
            {
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    if (phoneNumber.Length == 9)
                    {
                        foreach (char c in phoneNumber)
                        {
                            if (!char.IsDigit(c))
                            {
                                return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de telefone] deve conter apenas números" };
                            }
                        }
                        foreach(string n in fakeNumbers)
                        {
                            if(n == phoneNumber)
                            {
                                return new ValidatorResult { IsValid = false, ErrorMessage = "O numero de telemovel é invalido" };
                            }
                        }
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de telefone] deve conter 9 dígitos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de telefone] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar validar o campo [número de telefone]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_Postcode(string postCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(postCode))
                {
                    if (postCode.Length == 8)
                    {
                        if (postCode[4] == '-')
                        {
                            int cont=0;
                            foreach (char c in postCode)
                            {
                                if (!char.IsDigit(c))
                                {
                                    if(c == '-' && cont==4)
                                    {
                                        continue;
                                    }
                                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [código-potal] deve conter apenas números" };
                                }
                                cont++;
                            }
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [código-postal] deve conter um hífen no meio" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [código postal] deve conter 8 caracteres" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [código postal] não pode estar vazio" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar validar o campo [código postal]: " + err.Message };
            }
        }
        static protected ValidatorResult Validate_SchoolMemberID(string schoolMemberID)
        {
            try
            {
                if (!string.IsNullOrEmpty(schoolMemberID))
                {
                    if (schoolMemberID.Length == 6)
                    {
                        if (!schoolMemberID.Equals("000000"))
                        {
                            foreach (char c in schoolMemberID)
                            {
                                if (!char.IsDigit(c))
                                {
                                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [código-potal] deve conter apenas números" };
                                }
                            }
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de identificação escolar] com sequencia de dígitos inválida" };
                        }
                    }
                    else
                    {
                        return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de identificação escolar] deve conter 6 dígitos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "O campo [número de identificação escolar] não pode estar vazio" };
                }

            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro ao tentar validar o campo [número de identificação escolar]: " + err.Message };
            }
        }

        //Métodos de Verificação secundarias
        static protected ValidatorResult PasswordConfirm(string password, string passwordConfirm)
        {
            if (password != passwordConfirm)
                return new ValidatorResult { IsValid = false, ErrorMessage = "Palavras-Passe não coincidem" };

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
                Validate_Postcode(user.PostCode),
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
        static public new ValidatorResult Login(User user)
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
                        return new ValidatorResult { IsValid = false, ErrorMessage = "nome ou palavra-passe incorretos" };
                    }
                }
                else
                {
                    return new ValidatorResult { IsValid = false, ErrorMessage = "Não existe utilizadores com estas credenciais" };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult { IsValid = false, ErrorMessage = "Ocorreu um erro inesperado ao tentar fazer login: " + err.Message };
            }
        }
    }
    public class UserData : UserValidator
    {
        static public void Reset()
        {
            CurrentSession.User.ID = -1;
            CurrentSession.User.CreatedAt = DateTime.MinValue;
            CurrentSession.User.Email = string.Empty;
            CurrentSession.User.IsActive = false;
            CurrentSession.User.Name = string.Empty;
            CurrentSession.User.Password = string.Empty;
            CurrentSession.User.PhoneNumber = string.Empty;
            CurrentSession.User.ProfileImage = null;
            CurrentSession.User.Role = -1;
            CurrentSession.User.PostCode = string.Empty;
            CurrentSession.User.SchoolIDNumber = string.Empty;
        }
        static public new ValidatorResult Save(User user)
        {
            var result = new ValidatorResult();
            try
            {
                DataTable dt = User_BLL.Save(user);
                if (dt.Rows.Count != 0)
                {
                    CurrentSession.User.ID = Convert.ToInt16(dt.Rows[0][0]);
                    CurrentSession.User.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    CurrentSession.User.Email = dt.Rows[0][2].ToString();
                    CurrentSession.User.IsActive = true;
                    CurrentSession.User.Name = dt.Rows[0][4].ToString();
                    CurrentSession.User.Password = dt.Rows[0][5].ToString();
                    CurrentSession.User.PhoneNumber = dt.Rows[0][6].ToString();
                    CurrentSession.User.ProfileImage = dt.Rows[0][7] != DBNull.Value ? (byte[])dt.Rows[0][7] : null;
                    CurrentSession.User.Role = Convert.ToInt16(dt.Rows[0][8]);
                    CurrentSession.User.PostCode = dt.Rows[0][9].ToString();
                    CurrentSession.User.SchoolIDNumber = dt.Rows[0][10].ToString();

                    result.IsValid = true;
                    return result;
                }
                else
                {
                    result.IsValid = false; result.ErrorMessage = "Utlizador não encontrado";
                    return result;
                }
            }
            catch (Exception err)
            {
                result.IsValid = false; result.ErrorMessage = "Ocorreu um erro ao tentar salvar o dados do utilizador: " + err.Message;
                return result;
            }
            finally
            {
                if (!result.IsValid)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }

        }
        static public ValidatorResult Update(User user, string passwordConfirm)
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
                Validate_Postcode(user.PostCode),
                Validate_SchoolMemberID(user.SchoolIDNumber),
                IsSchoolMemberIDTaken(user.SchoolIDNumber),
            };
            foreach (var result in checks)
            {
                if (!result.IsValid) return result;
            }
            user.Password = Encryptor.Encrypt(user.Password);
            return new ValidatorResult { IsValid = true };
        }
    }
}
    