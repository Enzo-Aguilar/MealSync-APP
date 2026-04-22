using System.Windows.Forms;
using MealSync_APP.Utils;
using System;
using BusinessLogicLayer;

namespace MealSync_APP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Load do form
        public void Home_Load(object sender, EventArgs e)
        {
            HomeTabs_Visibility();
            Has_BankAccount();
        }
    
        //Métodos dos componentes gráficos

        //LogOut
        private void Logout_Click(object sender, EventArgs e)
        { 
            FormUtils.Open_Index();
            HomeTabs_Visibility();
        }

        //User (em sessão)
        private void edit_Profile_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditProfile();
        }

        //Conta Bancária
        private void associate_BankAccount_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_AssociateBankAccount();
        }
        private void create_BankAccount_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_CreateBankAccount();
        }

        //Pedidos
        private void show_Orders_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowOrders();
        }
        private void make_Orders_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_MakeOrder();
        }
        private void cancel_Order_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_CancelOrder();
        }

        //Refeições
        private void show_Meals_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowMeal();
        }
        private void edit_Meal_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditMeal();
        }
        private void add_Meal_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_AddMeal();
        }
        private void remove_Meal_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_RemoveMeal();
        }

        //Alunos
        private void show_Students_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowStudents();
        }
        private void add_Student_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_AddStudent();
        }
        private void edit_Student_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditStudent();
        }
        private void remove_Student_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_RemoveStudent();
        }

        //Funcionarios
        private void show_Employees_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowEmployees();
        }
        private void add_Employee_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_AddEmployee();
        }
        private void edit_Employee_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditEmployee();
        }
        private void remove_Employee_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_RemoveEmployee();
        }

        //Admin
        private void show_Admins_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowAdmins();
        }
        private void add_Admin_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_AddAdmin();
        }
        private void edit_Admin_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditAdmin();
        }
        private void remove_Admin_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_RemoveAdmin();
        }

        //Métodos Auxiliares
        public void HomeTabs_Visibility()
        {
            if (User.Role == 0) // Admin
            {
                // No changes needed for admin
            }
            else if (User.Role == 1) // Employee
            {
                Students.Visible = false;
                Employees.Visible = false;
                Admin.Visible = false;
            }
            else if (User.Role == 2) // Student
            {
                edit_Meal.Visible = false;
                add_Meal.Visible = false;
                remove_Meal.Visible = false;
                Students.Visible = false;
                Employees.Visible = false;
                Admin.Visible = false;
            }
        }
        public void Has_BankAccount()
        {
            var res =  BankAuth.Has_BankAccount(User.ID);
            if (!res.IsValid)
            {
                lbDoesNotHaveBankAccount.Text = res.errorMessage;
            }
        }
        private void lbDoesNotHaveBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.OpenForm_CreateBankAccount();
            lbDoesNotHaveBankAccount.Visible = false;
        }
    }
}
