using MealSync_APP.Globals;
using MealSync_APP.Pages.GlobalForms;
using MealSync_APP.Utils;
using System;
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
        public void Home_Load(object sender, EventArgs e)
        {
            HomeResize(null, null);
            HomeTabsVisibility();
            LogCheck.UserIsLogged(this);
            clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        //Helpers
        private void HomeTabsVisibility()
        {
            int role = CurrentSession.User.Role;
            if (role == 2)
            {
                deactivate_BankAccount.Visible = false;
                reactivate_BankAccount.Visible = false;
                Meals.Visible = false;
                Students.Visible = false;
                Employees.Visible = false;
                Admins.Visible = false;
                answer_FAQs.Visible = false;
                reactivate_FAQs.Visible = false;
            }
            else if (role == 1)
            {
                deactivate_BankAccount.Visible = false;
                reactivate_BankAccount.Visible = false;
                Students.Visible = false;
                Employees.Visible = false;
                Admins.Visible = false;
            }
        }
        private void HomeResize(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\home1.png");
                this.BackgroundImage = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar a image de fundo: {ex.Message}", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


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

        //Perfil do Utilizador
        private void Edit_Profile_Click(object sender, EventArgs e) { OpenForm.EditUserProfile(); }

        //Conta bancária
        private void AddMoneyToBk_Click(object sender, EventArgs e) { OpenForm.AddMoneyToBk(); }
        private void Associate_BankAccount_Click(object sender, EventArgs e) { OpenForm.AssociateToBankAccount(); }
        private void Create_BankAccount_Click(object sender, EventArgs e) { OpenForm.CreateBankAccount(); }
        private void Transactions_BankAccount_Click(object sender, EventArgs e) { OpenForm.BankAccountTransactions(); }
        private void Deactivate_BankAccount_Click(object sender, EventArgs e) { OpenForm.DeactivateBankAccount(); }
        private void Reactivate_BankAccount_Click(object sender, EventArgs e) { OpenForm.ReactivateBankAccount(); }

        // Marcações
        private void Show_Orders_Click(object sender, EventArgs e) { OpenForm.ShowOrder(); }
        private void Make_Orders_Click(object sender, EventArgs e) { OpenForm.MakeOrder(); }
        private void Cancel_Order_Click(object sender, EventArgs e) { OpenForm.CancelOrder(); }

        // Refeições
        private void Edit_Meal_Click(object sender, EventArgs e) { OpenForm.EditMeal(); }
        private void Add_Meal_Click(object sender, EventArgs e) { OpenForm.AddMeal(); }
        private void Remove_Meal_Click(object sender, EventArgs e) { OpenForm.RemoveMeal(); }

        // Alunos
        private void Show_Students_Click(object sender, EventArgs e) { OpenForm.ShowUser("Stundent"); }
        private void Add_Student_Click(object sender, EventArgs e){ OpenForm.AddUser("Student"); }
        private void Remove_Student_Click(object sender, EventArgs e) { OpenForm.RemoveUser("Student"); }

        // Funcionarios
        private void Show_Employees_Click(object sender, EventArgs e) { OpenForm.ShowUser("Employee"); }
        private void Add_Employee_Click(object sender, EventArgs e){ OpenForm.AddUser("Employee"); }
        private void Remove_Employee_Click(object sender, EventArgs e) { OpenForm.RemoveUser("Employee"); }

        // Administradores
        private void Show_Admins_Click(object sender, EventArgs e) { OpenForm.ShowUser("Admin"); }
        private void Add_Admin_Click(object sender, EventArgs e){ OpenForm.ShowUser("Admin"); }
        private void Remove_Admin_Click(object sender, EventArgs e) { OpenForm.RemoveUser("Admin"); }

        //FAQs (perguntas frequentes)
        private void Show_FAQs_Click(object sender, EventArgs e) { OpenForm.ShowFAQs(); }
        private void Make_FAQs_Click(object sender, EventArgs e) { OpenForm.MakeFAQs(); }
        private void Answer_FAQs_Click(object sender, EventArgs e) { OpenForm.AnswerFAQs(); }
        private void Reactivate_FAQs_Click(object sender, EventArgs e) { OpenForm.ReactivateFAQs(); }
    }
}
