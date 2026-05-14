using MealSync_APP.Pages.BankAccountFolder;
using MealSync_APP.BankAccountFolder;
using MealSync_APP.Administradores;
using MealSync_APP.Funcionários;
using MealSync_APP.ProfileFolder;
using System.Windows.Forms;
using MealSync_APP.Alunos;

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
    }
    public class FormUtils 
    {
        static protected Home _home = new Home();

        //Register
        static public void Open_Register(Form form)
        {
            Register register = new Register();
            form.Hide();
        }

        //Login
        static public void Open_Login()
        {
            Login login = new Login();
        }

        //Home
        static public void Open_Home()
        {
            _home = new Home();
        }

        //User em sessão
        static public void OpenForm_EditProfile()
        {
            Edit_Profile editProfile = new Edit_Profile();
            editProfile.MdiParent = _home;
            editProfile.Show();

        }

        //Bank Account
        static public void OpenForm_AssociateBankAccount()
        {
            Associate_BankAccount ab = new Associate_BankAccount();
            ab.MdiParent = _home;
            ab.Show();
        }
        static public void OpenForm_CreateBankAccount()
        {
            Create_BankAccount createBankAccount = new Create_BankAccount();
            createBankAccount.MdiParent = _home;
            createBankAccount.Show();
        }

        //Admin
        static public void OpenForm_AddAdmin()
        {
        }
        static public void OpenForm_EditAdmin()
        {
            Edit_Admin editAdmin = new Edit_Admin();
            editAdmin.MdiParent = _home;
            editAdmin.Show();
        }
        static public void OpenForm_RemoveAdmin()
        {
            Remove_Admin removeAdmin = new Remove_Admin();
            removeAdmin.MdiParent = _home;
        }
        static public void OpenForm_ShowAdmins()
        {
            Show_Admins showAdmin = new Show_Admins();
            showAdmin.MdiParent = _home;
            showAdmin.Show();
        }

        //Employee = Funcionario
        static public void OpenForm_AddEmployee()
        {
            Add_Employee addEmployee = new Add_Employee();
            addEmployee.MdiParent = _home;
            addEmployee.Show();
        }
        static public void OpenForm_EditEmployee()
        {
            Edit_Employee editEmployee = new Edit_Employee();
            editEmployee.MdiParent = _home;
            editEmployee.Show();
        }
        static public void OpenForm_RemoveEmployee()
        {
            Remove_Employee removeEmployee = new Remove_Employee();
            removeEmployee.MdiParent = _home;
            removeEmployee.Show();
        }
        static public void OpenForm_ShowEmployees()
        {
            Show_Employees showEmployees = new Show_Employees();
            showEmployees.MdiParent = _home;
            showEmployees.Show();
        }

        //Students = Alunos
        static public void OpenForm_AddStudent()
        {
            Add_Student addStudent = new Add_Student();
            addStudent.MdiParent = _home;
            addStudent.Show();
        }
        static public void OpenForm_EditStudent()
        {
            Edit_Student editStudent = new Edit_Student();
            editStudent.MdiParent = _home;
            editStudent.Show();
        }
        static public void OpenForm_RemoveStudent()
        {
            Remove_Student removeStudent = new Remove_Student();
            removeStudent.MdiParent = _home;
            removeStudent.Show();
        }
        static public void OpenForm_ShowStudents()
        {
            Show_Students showStudents = new Show_Students();
            showStudents.MdiParent = _home;
            showStudents.Show();
        }

        //Orders = Pedidos


        //Meals = Refeições


    }
}
