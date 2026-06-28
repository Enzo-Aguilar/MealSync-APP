using System.Collections.Generic;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System.Data;
using System;


namespace MealSync_APP.Utils
{
    internal class UserValidator : User_BLL
    {
        //Searching Methods
        public static ValidatorResult IsNameTaken(string name)
        {
            try
            {
                if (Search_Name(name) != null)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Este nome não está disponivel"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsNameTaken),
                    ErrorMessage = $"Ocorreu um erro ao procurar o nome do utilizador: {ex.Message}"
                };
            }
        }
        public static ValidatorResult IsEmailTaken(string email)
        {
            try
            {
                if (Search_Email(email) != null)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Este email não está disponivel"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsEmailTaken),
                    ErrorMessage = $"Ocorreu um erro ao procurar o email do utilizador: {ex.Message}"
                };
            }
        }
        public static ValidatorResult IsPhoneNumberTaken(string phoneNumber)
        {
            try
            {
                if (Search_PhoneNumber(phoneNumber) != null)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Este número de telemovel já está associado a outro utilizador"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsPhoneNumberTaken),
                    ErrorMessage = $"Ocorreu um erro ao procurar o número de telefone do utilizador {ex.Message}"
                };
            }
        }
        public static ValidatorResult IsSchoolMemberIDTaken(string school_member_ID)
        {
            try
            {
                if (Search_SchoolMemberID(school_member_ID) != null)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Este número de identificação escolar já está associado a outro utilizador"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsSchoolMemberIDTaken),
                    ErrorMessage = $"Ocorreu um erro ao procurar o número de identificação escolar do utilizador: {ex.Message}"
                };
            }
        }

        //Auth Methods
        public static ValidatorResult ValidateId(int ID)
        {
            if(ID <= 0)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "ID invalido",
                };
            }
            else
            {
                return new ValidatorResult
                {
                    IsValid = true,
                };
            }
        }
        public static ValidatorResult ValidateEmail(string email)
        {
            List<string> possibleDomains = new List<string> { "gmail", "outlook", "icloud", "sapo", "epge", "proton", "hotmail", "gustaveeiffel","edu" };
            try
            {
                if (email.Contains("@"))
                {
                    if (email.EndsWith(".com") || email.EndsWith(".pt"))
                    {
                        if (email.Length >= 10)
                        {
                            foreach (string d in possibleDomains)
                            {
                                if (email.Contains(d))
                                {
                                    return new ValidatorResult { IsValid = true };
                                }
                            }
                            return new ValidatorResult
                            {
                                IsValid = false,
                                ErrorMessage = "O dominio do email é invalido"
                            };
                        }
                        else
                        {
                            return new ValidatorResult
                            {
                                IsValid = false,
                                ErrorMessage = "Email muito curto"
                            };
                        }
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Email deve terminar com '.com' ou '.pt'"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Email tem que conter '@'"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateEmail),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o campo [email]: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidateName(string name)
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
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O campo [nome] não pode estar vazio"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "nome muito curto"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateName),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o campo [nome]: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidateRole(int role)
        {
            try
            {
                if (role < 0 || role > 3)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Campo [função] invalido"
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateRole),
                    ErrorMessage = $"Ocorreu um erro ao Validar o campo [função]: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidatePhoneNumber(string phoneNumber)
        {
            List<string> fakeNumbers = new List<string> { "123456789", "000000000", "111111111", "222222222", "999999999" };
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
                                return new ValidatorResult
                                {
                                    IsValid = false,
                                    ErrorMessage = "O campo [número de telefone] deve conter apenas números"
                                };
                            }
                        }
                        foreach (string n in fakeNumbers)
                        {
                            if (n == phoneNumber)
                            {
                                return new ValidatorResult
                                {
                                    IsValid = false,
                                    ErrorMessage = "O numero de telemovel é invalido"
                                };
                            }
                        }
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O campo [número de telefone] deve conter 9 dígitos"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O campo [número de telefone] não pode estar vazio"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o campo [número de telefone]: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidatePostcode(string postCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(postCode))
                {
                    if (postCode.Length == 8)
                    {
                        if (postCode[3] == '-')
                        {
                            int cont = 0;
                            foreach (char c in postCode)
                            {
                                if (!char.IsDigit(c))
                                {
                                    if (c == '-' && cont == 3)
                                    {
                                        continue;
                                    }
                                    return new ValidatorResult
                                    {
                                        IsValid = false,
                                        ErrorMessage = "O campo [código-postal] deve conter apenas números e um ´-´ exemplo: 1234-567"
                                    };
                                }
                                cont++;
                            }
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult
                            {
                                IsValid = false,
                                ErrorMessage = "O campo [código-postal] deve conter apenas números e um ´-´ exemplo: 1234-567"
                            };
                        }
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O campo [código-postal] deve conter apenas números e um ´-´ exemplo: 1234-567"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O campo [código postal] não pode estar vazio"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o campo [código postal]: {ex.Message}"
                };
            }
        }
        public static ValidatorResult ValidateProfileImage(byte[] bytes)
        {
            if (bytes != null)
            {
                return new ValidatorResult { IsValid = true };
            }
            else if (bytes == null)
            {
                return new ValidatorResult { IsValid = true };
            }
            else
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = "Ocorreu um a tentar processar a imagem"
                };
            }
        }
        public static ValidatorResult ValidateSchoolMemberID(string schoolMemberID)
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
                                    return new ValidatorResult
                                    {
                                        IsValid = false,
                                        ErrorMessage = "O campo número de identificação escolar deve conter apenas números"
                                    };
                                }
                            }
                            return new ValidatorResult { IsValid = true };
                        }
                        else
                        {
                            return new ValidatorResult
                            {
                                IsValid = false,
                                ErrorMessage = "O campo número de identificação escolar com sequencia de dígitos inválida"
                            };
                        }
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O campo número de identificação escolar deve conter 6 dígitos"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O campo número de identificação escolar não pode estar vazio"
                    };
                }

            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateSchoolMemberID),
                    ErrorMessage = $"Ocorreu um erro ao tentar validar o número de identificação escolar: {ex.Message}"
                };
            }
        }
    }
    public class UserAuth
    {
        public static ValidatorResult Register(User u, string passwordConfirm)
        {
            var validations = new[]
            {
                UserValidator.ValidateEmail(u.Email),
                UserValidator.IsEmailTaken(u.Email),
                UserValidator.ValidateName(u.Name),
                UserValidator.IsNameTaken(u.Name),
                Password.Validate(u.Password),
                Password.ValidatePasswordConfirmation(u.Password, passwordConfirm),
                UserValidator.ValidateRole(u.Role),
                UserValidator.ValidatePhoneNumber(u.PhoneNumber),
                UserValidator.IsPhoneNumberTaken(u.PhoneNumber),
                UserValidator.ValidatePostcode(u.PostCode),
                UserValidator.ValidateProfileImage(u.ProfileImage),
                UserValidator.ValidateSchoolMemberID(u.SchoolIDNumber),
                UserValidator.IsSchoolMemberIDTaken(u.SchoolIDNumber),
            };

            foreach (var validation in validations)
            {
                if (!validation.IsValid) return validation;
            }
            u.Password = Password.HashPassword(u.Password);
            User_BLL.Register(u);
            return new ValidatorResult { IsValid = true };
        }
        public static ValidatorResult Login(User u)
        {
            try
            {
                var dt = User_BLL.Login(u);
                if (dt.Rows.Count != 0)
                {
                    string hashedPassword = dt.Rows[0][5].ToString();
                    if (Password.VerifyPassword(u.Password, hashedPassword))
                    {
                        return new ValidatorResult { IsValid = true };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Nome ou palavra-passe incorretos"
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Não existe utilizadores com estas credenciais"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(Login),
                    ErrorMessage = $"Ocorreu um erro inesperado ao tentar fazer login: {ex.Message}"
                };
            }
        }
        public static ValidatorResult CreateUser(User u, string passwordConfirm)
        {
            var validations = new[]
            {
                UserValidator.ValidateEmail(u.Email),
                UserValidator.IsEmailTaken(u.Email),
                UserValidator.ValidateName(u.Name),
                UserValidator.IsNameTaken(u.Name),
                Password.Validate(u.Password),
                Password.ValidatePasswordConfirmation(u.Password, passwordConfirm),
                UserValidator.ValidateRole(u.Role),
                UserValidator.ValidatePhoneNumber(u.PhoneNumber),
                UserValidator.IsPhoneNumberTaken(u.PhoneNumber),
                UserValidator.ValidatePostcode(u.PostCode),
                UserValidator.ValidateProfileImage(u.ProfileImage),
                UserValidator.ValidateSchoolMemberID(u.SchoolIDNumber),
                UserValidator.IsSchoolMemberIDTaken(u.SchoolIDNumber),
            };

            foreach (var validation in validations)
            {
                if (!validation.IsValid) return validation;
            }
            u.Password = Password.HashPassword(u.Password);
            User_BLL.Create_User(u);
            return new ValidatorResult { IsValid = true };
        }
        public static ValidatorResult DeactivateUser(int ID)
        {
            try
            {
                User_BLL.Deactivate_User(ID);
                return new ValidatorResult
                {
                    IsValid = true
                };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro desativando utilizador {ex.Message}",
                };
            }
        }
    }
    public class UserData
    {
        public static ValidatorResult Save(User u)
        {
            try
            {
                DataTable dt = User_BLL.Save(u);
                if (dt.Rows.Count != 0)
                {
                    CurrentSession.User.ID = Convert.ToInt16(dt.Rows[0][0]);
                    CurrentSession.User.CreatedAt = Convert.ToDateTime(dt.Rows[0][1]);
                    CurrentSession.User.Email = dt.Rows[0][2].ToString();
                    CurrentSession.User.IsActive = true;
                    CurrentSession.User.Name = dt.Rows[0][4].ToString();
                    CurrentSession.User.Password = dt.Rows[0][5].ToString();
                    CurrentSession.User.PhoneNumber = dt.Rows[0][6].ToString();
                    CurrentSession.User.PostCode = dt.Rows[0][7].ToString();
                    CurrentSession.User.ProfileImage = dt.Rows[0][8] != DBNull.Value ? (byte[])dt.Rows[0][8] : null;
                    CurrentSession.User.Role = Convert.ToInt16(dt.Rows[0][9]);
                    CurrentSession.User.SchoolIDNumber = dt.Rows[0][10].ToString();

                    return new ValidatorResult { IsValid = true };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Utilizador não encontrado"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(Save),
                    ErrorMessage = $"Ocorreu um erro ao tentar salvar o dados do utilizador: {ex.Message}"
                };
            }
            finally
            {
                u.Clear();
            }
        }
        public static ValidatorResult Update(User u, string passwordConfirm)
        {
            var validations = new[]
            {
                UserValidator.ValidateEmail(u.Email),
                UserValidator.IsEmailTaken(u.Email),
                UserValidator.ValidateName(u.Name),
                UserValidator.IsNameTaken(u.Name),
                Password.Validate(u.Password),
                Password.ValidatePasswordConfirmation(u.Password, passwordConfirm),
                UserValidator.ValidateRole(u.Role),
                UserValidator.ValidatePhoneNumber(u.PhoneNumber),
                UserValidator.IsPhoneNumberTaken(u.PhoneNumber),
                UserValidator.ValidatePostcode(u.PostCode),
                UserValidator.ValidateSchoolMemberID(u.SchoolIDNumber),
                UserValidator.IsSchoolMemberIDTaken(u.SchoolIDNumber),
            };
            foreach (var validation in validations)
            {
                if (!validation.IsValid) return validation;
            }
            u.Password = Password.HashPassword(u.Password);
            return new ValidatorResult { IsValid = true };
        }
    }
}
    