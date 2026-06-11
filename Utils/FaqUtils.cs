using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Xml.Schema;

namespace MealSync_APP.Utils
{
    internal class FaqValidator
    {
        public static ValidatorResult ValidateAnswer(string answer)
        {
            try
            {
                if (!string.IsNullOrEmpty(answer))
                {
                    if (answer.Length <= 254)
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Resposta excedeu o limite de 255 caracteres",
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Resposta Inválida",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateAnswer),
                    ErrorMessage = $"Ocorreu um erro a validar pergunta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ValidateQuestion(string question)
        {
            try
            {
                if (!string.IsNullOrEmpty(question))
                {
                    if (question.Length <= 254)
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Pergunta excedeu o limite de 255 caracteres",
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Pergunta Inválida",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ValidateQuestion),
                    ErrorMessage = $"Ocorreu um erro a validar resposta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult IsQuestionAlredyAnswered(string question)
        {
            try
            {
                bool isAnswered = Faq_BLL.IsQuestionAlredyAnswered(question);
                if (isAnswered)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Está pergunta já foi respondida",
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
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(IsQuestionAlredyAnswered),
                    ErrorMessage = $"Ocorreu um erro a validar se a pergunta já foi respondida: {ex.Message}",
                };
            }

        }
        public static ValidatorResult SearchQuestion(string question)
        {
            try
            {
                object searchedQuestion = Faq_BLL.Search_Question(question);
                if(searchedQuestion != null)
                {
                    return new ValidatorResult 
                    { 
                        IsValid = false, 
                        ErrorMessage = "Está pergunta já foi feita",
                    };
                }
                else
                {
                    return new ValidatorResult { IsValid = true };
                }
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(SearchQuestion),
                    ErrorMessage = $"Ocorreu um erro a responder a pergunta: {ex.Message}",
                };
            }
        }
    }
    public class FaqAuth
    {
        public static ValidatorResult AnswerQuestion(Faq faq)
        {
            try
            {
                var validations = new[]
                {
                    FaqValidator.ValidateAnswer(faq.Answer),
                    FaqValidator.ValidateQuestion(faq.Question),
                    FaqValidator.IsQuestionAlredyAnswered(faq.Question),
                };
                foreach (var validation in validations)
                {
                    if (!validation.IsValid)
                        return validation;
                }
                Faq_BLL.Answer_Question(faq);
                return new ValidatorResult { IsValid = true, };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(AnswerQuestion),
                    ErrorMessage = $"Ocorreu um erro a responder a pergunta: {ex.Message}",
                };
            }

        }
        public static ValidatorResult DeactivateQuestion(Faq faq)
        {
            try
            {
                var validations = new[]
                {
                    FaqValidator.ValidateQuestion(faq.Question),
                };
                foreach(var validation in validations)
                {
                    if (!validation.IsValid)
                    {
                        return validation;
                    }
                }
                Faq_BLL.Deactivate_Question(faq.Question);
                return new ValidatorResult { IsValid = true, };
            }
            catch(Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(DeactivateQuestion),
                    ErrorMessage = $"Ocorreu um erro a desativar pergunta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult CreateQuestion(Faq faq)
        {
            try
            {
                var validations = new[]
                {
                    FaqValidator.ValidateQuestion(faq.Question),
                    FaqValidator.SearchQuestion(faq.Question),
                };
                foreach (var validation in validations)
                {
                    if (!validation.IsValid)
                    {
                        return validation;
                    }
                }
                Faq_BLL.Create_Question(faq);
                return new ValidatorResult { IsValid = true, };
            } 
            catch(Exception ex) 
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(CreateQuestion),
                    ErrorMessage = $"Ocorreu um erro a criar pergunta: {ex.Message}",
                };
            }
        }
        public static ValidatorResult ReactivateQuestion(Faq faq)
        {
            try
            {
                var validations = new[]
                {
                    FaqValidator.ValidateQuestion(faq.Question),
                };
                foreach (var validation in validations)
                {
                    if (!validation.IsValid)
                    {
                        return validation;
                    }
                }
                Faq_BLL.Reactivate_Question(faq.Question);
                return new ValidatorResult { IsValid = true, };
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    Source = nameof(ReactivateQuestion),
                    ErrorMessage = $"Ocorreu um erro a reativar pergunta: {ex.Message}",
                };
            }
        }
    }
}
