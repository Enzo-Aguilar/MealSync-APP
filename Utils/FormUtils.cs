using BusinessLogicLayer;
using MealSync_APP._Começo;
using MealSync_APP._Conta_Bancaria;
using MealSync_APP._Utilizador_;
using MealSync_APP.Administradores;
using MealSync_APP.Alunos;
using MealSync_APP.Funcionários;
using MealSync_APP.Marcações;
using MealSync_APP.Pedidos;
using MealSync_APP.Refeições;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MealSync_APP.Utils
{
    public class FormUtils
    {
        static protected Home _home = new Home();
       
        //Register
        static public void Open_Register(Form form)
        {
            Register regis = new Register();
            form.Hide();
            regis.Show();
        }

        //Login
        static public void Open_Login()
        {
            Login login = new Login();
            login.Show();
           _home.Close();
        }

        //Home
        static public  void Open_Home(Login index)
        {
            _home = new Home();
            _home.Show();
            index.Hide();
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
            createBankAccount.MdiParent= _home;
            createBankAccount.Show();        
        }

        //Admin
        static public void OpenForm_AddAdmin()
        {
            Add_Admin addAdmin = new Add_Admin();
            addAdmin.MdiParent = _home;
            addAdmin.Show();
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
    public class Meals : FormUtils
    {
        static public void OpenForm_AddMeal()
        {
            Add_Meal add_Meal = new Add_Meal();
            add_Meal.MdiParent = _home;
            add_Meal.Show();
        }
        static public void OpenForm_EditMeal()
        {
            Edit_Meal edit_Meal = new Edit_Meal();
            edit_Meal.MdiParent = _home;
            edit_Meal.Show();
        }
        static public void OpenForm_RemoveMeal()
        {
            Remove_Meal remove_Meal = new Remove_Meal();
            remove_Meal.MdiParent = _home;
            remove_Meal.Show();
        }
        static public void OpenForm_ShowMeal()
        {
            Show_Meals show_Meals = new Show_Meals();
            show_Meals.MdiParent = _home;
            show_Meals.Show();
        }
    }

    public class Orders : FormUtils
    {
        static public void OpenForm_CancelOrder()
        {
            Cancel_Order cancel_Order = new Cancel_Order();
            cancel_Order.MdiParent = _home;
            cancel_Order.Show();
        }
        static public void OpenForm_MakeOrder()
        {
            Make_Order makeOrder = new Make_Order();
            makeOrder.MdiParent = _home;
            makeOrder.Show();
        }
        static public void OpenForm_ShowOrders()
        {
            Show_Orders showOrders = new Show_Orders();
            showOrders.MdiParent = _home;
            showOrders.Show();
        }
    }
}
