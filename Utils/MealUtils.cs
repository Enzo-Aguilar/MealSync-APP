using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Utils
{
    public class MealValidator : Meal_BLL
    {
        static protected ValidatorResult Validate_DateTimePicker(DateTime? mealDate)
        {
            try
            {
                if (mealDate != null)
                {
                    DateTime today = DateTime.Today;
                    DateTime oneWeekLater = today.AddDays(7);

                    // Check if the meal date is in the past
                    if (mealDate < today)
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Não pode criar refeição para dias passados"
                        };
                    }
                    // Check if the meal date is today
                    else if (mealDate == today)
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "Não pode criar refeição para o dia atual"
                        };
                    }
                    // Check if the meal date is less than 7 days away
                    else if (mealDate < oneWeekLater)
                    {
                        int daysAhead = (mealDate.Value - today).Days;
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = $"Refeições devem ser criadas com pelo menos 7 dias de antecedência. Você tem apenas {daysAhead} dia(s)"
                        };
                    }
                    // All checks passed - date is valid (7 or more days in advance)
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                            ErrorMessage = ""
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "Data da refeição é obrigatória"
                    };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao validar a data: {err.Message}"
                };
            }
        }
        static protected ValidatorResult Validate_Description(string description)
        {
            try
            {
                if (!string.IsNullOrEmpty(description))
                {
                    if (description.Length > 255)
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "A descrição da refeição deve conter no máximo 255 caracteres"
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                            ErrorMessage = ""
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "A descrição da refeição é obrigatória"
                    };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao validar a descrição da refeição: {err.Message}"
                };
            }
        }
        static protected ValidatorResult Validate_MealImage(byte[] mealImage)
        {
            try
            {
                if (mealImage != null)
                {
                    if (mealImage.Length > 0)
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                            ErrorMessage = ""
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "A imagem da refeição não pode estar vazia"
                        };
                    }

                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "A imagem da refeição é obrigatória"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao tentar validar a imagem da refeição: {ex.Message}"
                };
            }
        }
        static protected ValidatorResult Validate_Name(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (name.Length > 100)
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O nome da refeição deve conter no máximo 100 caracteres"
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                            ErrorMessage = ""
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O nome da refeição é obrigatório"
                    };
                }
            }
            catch (Exception err)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao validar o nome da refeição: {err.Message}"
                };
            }
        }
        static protected ValidatorResult Validate_Price(SqlMoney price)
        {
            try
            {
                if (price.IsNull)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O preço da refeição é obrigatório"
                    };

                }
                else if (price.Value < 0)
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O preço da refeição não pode ser negativo"
                    };
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = true,
                        ErrorMessage = ""
                    };
                }
            }
            catch (Exception ex)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao validar o preço da refeição: {ex.Message}"
                };
            }
        }
        static protected ValidatorResult Validate_Type(string type)
        {
            try
            {
                if (!string.IsNullOrEmpty(type))
                {
                    if (type.Length > 50)
                    {
                        return new ValidatorResult
                        {
                            IsValid = false,
                            ErrorMessage = "O tipo da refeição deve conter no máximo 50 caracteres"
                        };
                    }
                    else
                    {
                        return new ValidatorResult
                        {
                            IsValid = true,
                            ErrorMessage = ""
                        };
                    }
                }
                else
                {
                    return new ValidatorResult
                    {
                        IsValid = false,
                        ErrorMessage = "O tipo da refeição é obrigatório"
                    };
                }

            }
            catch (Exception err)
            {
                return new ValidatorResult
                {
                    IsValid = false,
                    ErrorMessage = $"Ocorreu um erro ao validar o tipo da refeição: {err.Message}"
                };
            }
        }
    }
    public class MealAuth : MealValidator
    {
        public static ValidatorResult CreateMeal(Meal meal)
        {
            var checks = new[]
            {
                Validate_DateTimePicker(meal.Date),
                Validate_Description(meal.Description),
                Validate_MealImage(meal.MealImage),
                Validate_Name(meal.Name),
                Validate_Price(meal.Price),
                Validate_Type(meal.Type),
            };
            foreach(var res in checks)
            {
                if (!res.IsValid) return res;
            }
            Meal_BLL.Create_Meal(meal);
            return new ValidatorResult
            {
                IsValid = true,
                ErrorMessage = ""
            };
        }
        public static ValidatorResult EditMeal(Meal m)
        {
            var checks = new[]
            {
                Validate_DateTimePicker(m.Date),
                Validate_Description(m.Description),
                Validate_MealImage(m.MealImage),
                Validate_Name(m.Name),
                Validate_Price(m.Price),
                Validate_Type(m.Type),
            };
        }
    }
}
