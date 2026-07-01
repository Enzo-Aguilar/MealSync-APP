using MealSync_APP.Pages.BankAccountFolder;
using MealSync_APP.Pages.GlobalForms;
using MealSync_APP.BankAccountFolder;
using MealSync_APP.Pages.FAQsFolder;
using MealSync_APP.ProfileFolder;
using MealSync_APP.OrderFolder;
using MealSync_APP.MealFolder;
using System.Windows.Forms;

namespace MealSync_APP.Utils
{
    public class RegisterForm
    {
        public static void Open(Form form)
        {
            Register resgister = new Register();
            form.Hide();
            resgister.Show();
        }
    }
    public class LoginForm : HomeForm
    {
        public static new void Open(Form form)
        {
            Login login = new Login();
            if(form is Home)
            {
                form.Close();
               _home = new Home();
            }
            form.Hide();
            login.Show();
        }
    }
    public class HomeForm
    {
        static protected Home _home = new Home();
        public static void Open(Form form)
        {
            form.Hide();
            _home.Show();
        }
    }

    public class OpenForm : HomeForm
    {
        //Perfil
        public static void EditUserProfile()
        {
            Edit_Profile ep = new Edit_Profile { MdiParent = _home};
            ep.Show();
        }

        //Bank Account (usuário currente)
        public static void AddMoneyToBk()
        {
            Add_MoneyToBk amtbk = new Add_MoneyToBk { MdiParent = _home};
            amtbk.Show();
        }
        public static void AssociateToBankAccount()
        {
            Associate_BankAccount ab = new Associate_BankAccount { MdiParent = _home};
            ab.Show();
        }
        public static void CreateBankAccount()
        {
            Create_BankAccount cba = new Create_BankAccount { MdiParent = _home};
            cba.Show();
        }
        public static void BankAccountTransactions()
        {
           Transactions_BankAccount tbc = new Transactions_BankAccount { MdiParent = _home };
            tbc.Show();
        }
        public static void DeactivateBankAccount()
        {
            Deactivate_BankAccount dba = new Deactivate_BankAccount { MdiParent = _home };
            dba.Show();
        }
        public static void ReactivateBankAccount()
        {
            Reactivate_BankAccount rba = new Reactivate_BankAccount { MdiParent = _home };
            rba.Show();
        }

        // Marcações
        public static void CancelOrder()
        {
            Cancel_Order co = new Cancel_Order { MdiParent = _home };
            co.Show();
        }
        public static void MakeOrder()
        {
            Make_Order mo = new Make_Order { MdiParent = _home };
            mo.Show();
        }
        public static void ShowOrder()
        {
            Show_Orders so = new Show_Orders { MdiParent = _home };
            so.Show();
        }

        // Refeições
        public static void AddMeal()
        {
            Add_Meal am = new Add_Meal { MdiParent = _home };
            am.Show();
        }
        public static void EditMeal()
        {
            Edit_Meal em = new Edit_Meal { MdiParent = _home };
            em.Show();
        }
        public static void RemoveMeal()
        {
            Remove_Meal rm = new Remove_Meal { MdiParent = _home };
            rm.Show();
        }

        //User Forms
        public static void AddUser(string fromWhere)
        {
            Add_User addUser = new Add_User(fromWhere) { MdiParent= _home };
            addUser.Show();
        }
        public static void ShowUser(string fromWhere)
        {
            Show_User su = new Show_User(fromWhere) { MdiParent = _home };
            su.Show();
        }
        public static void RemoveUser(string fromWhere)
        {
            Deactivate_User ru = new Deactivate_User(fromWhere) { MdiParent =_home };
            ru.Show();
        }
        public static void ReactivateUser(string fromWhere)
        {
            Reactivate_User ru = new Reactivate_User(fromWhere) { MdiParent = _home };
            ru.Show();
        }

        //FAQs
        public static void AnswerFAQs()
        {
            Answer_Faq answer_FAQ = new Answer_Faq() { MdiParent = _home };
            answer_FAQ.Show();
        }
        public static void MakeFAQs()
        {
            Create_Faq create_FAQs = new Create_Faq() { MdiParent = _home };
            create_FAQs.Show();
        }
        public static void ReactivateFAQs()
        {
            Reactivate_Faq reactivate_FAQ = new Reactivate_Faq() {MdiParent = _home};
            reactivate_FAQ.Show();
        }
        public static void ShowFAQs()
        {
            Show_Faq showFAQs = new Show_Faq(){ MdiParent = _home };
            showFAQs.Show();
        }
    }
}
