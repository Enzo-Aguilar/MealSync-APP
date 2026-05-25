using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
            Home_Tabs_Visibility();
        }
        //Métodos Auxiliares
        private void Home_Tabs_Visibility()
        {
            int role = CurrentSession.User.Role;
            if(role == 2)
            {
                deactivate_BankAccount.Visible=false;
                reactivate_BankAccount.Visible = false;
                add_Meal.Visible = false;
                remove_Meal.Visible = false;
                Students.Visible = false;
                Employees.Visible = false;
                Admins.Visible = false;
                answer_FAQs.Visible = false;
                reactivate_FAQs.Visible = false;
            }
            else if(role == 1)
            {
                deactivate_BankAccount.Visible=false;
                reactivate_BankAccount.Visible=false;
                Students.Visible=false; 
                Employees.Visible=false;
                Admins.Visible=false;
            }
        }
        private void Home_Resize(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\home1.png");
                this.BackgroundImage = img;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar carregar a image de fundo: " + err.Message, "ERROR");
            }
        }

        //Métodos dos componentes gráficos

        //LogOut
        private void Logout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Até Breve", "");
                LoginForm.Open(this);
            }
        }


        //Refeições
        private void show_Meals_Click(object sender, EventArgs e)
        {
            
        }
        private void add_Meal_Click(object sender, EventArgs e)
        {
            
        }
        private void edit_Meal_Click(object sender, EventArgs e)
        {
            
        }
        private void remove_Meal_Click(object sender, EventArgs e)
        {
            
        }

        //Alunos
        private void show_Students_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_ShowStudents();
        }
        private void add_Student_Click(object sender, EventArgs e)
        {
            this.Text = "Add_Student";
            FormUtils.Open_Register(this);
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
            this.Text = "Add_Employee";
            FormUtils.Open_Register(this);
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
            this.Text = "Add_Admin";
            FormUtils.Open_Register(this);
        }
        private void edit_Admin_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditAdmin();
        }
        private void remove_Admin_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_RemoveAdmin();
        }

        //Perfil do Utilizador
        private void Edit_Profile_Click(object sender, EventArgs e){ OpenForm.EditUserProfile(); }

        // Conta bancária
        private void Associate_BankAccount_Click(object sender, EventArgs e){OpenForm.AssociateToBankAccount();}
        private void Create_BankAccount_Click(object sender, EventArgs e){OpenForm.CreateBankAccount();}
        private void Deactivate_BankAccount_Click(object sender, EventArgs e){OpenForm.DeactivateBankAccount();}
        private void Reactivate_BankAccount_Click(object sender, EventArgs e){OpenForm.ReactivateBankAccount();}


        private void Show_Orders_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Make_Orders_Click_1(object sender, EventArgs e)
        {

        }

        private void Cancel_Order_Click_1(object sender, EventArgs e)
        {

        }
    }
}
