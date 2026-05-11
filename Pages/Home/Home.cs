using System.Windows.Forms;
using MealSync_APP.Utils;
using System;

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
           //Adicionar método de Home Visibility
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

        //Pedidos
        private void show_Orders_Click(object sender, EventArgs e)
        {
            
        }
        private void make_Orders_Click(object sender, EventArgs e)
        {

        }
        private void cancel_Order_Click(object sender, EventArgs e)
        {
            
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
        private void lbDoesNotHaveBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.OpenForm_CreateBankAccount();
        }

        //Perfil do Utilizador
        private void Edit_Profile_Click(object sender, EventArgs e){ OpenForm.EditUserProfile(); }

        //Conta bancária
        private void Associate_BankAccount_Click(object sender, EventArgs e){OpenForm.AssociateToBankAccount();}
        private void Create_BankAccount_Click(object sender, EventArgs e){OpenForm.CreateBankAccount();}
        private void DeactivateToolStripMenuItem_Click(object sender, EventArgs e){OpenForm.DeactivateBankAccount();}
        private void ReativarToolStripMenuItem_Click(object sender, EventArgs e){ OpenForm.ReactivateBankAccount(); }

    }
}
