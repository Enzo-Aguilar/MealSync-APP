using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //Load do form
        private void Registo_Load(object sender, EventArgs e)
        {
            UserData.Reset();
            cbRole.SelectedItem = "Aluno";
            cbRole.Enabled = false;
        }

        //Métodos dos componentes gráficos
        private void lbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Login();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime createdAt = DateTime.UtcNow;
            string email = tbEmail.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string passwordConfirm = tbPassword_Confirm.Text;
            int role = 2;

            UserAuth.Register(email, name, password, passwordConfirm, role);
            BLL.User.Create_User(createdAt, email, name, password, role);
            MessageBox.Show("Utilizador Criado com sucesso");

            FormUtils.Open_Login();
            this.Close();
        }       
    }
}
