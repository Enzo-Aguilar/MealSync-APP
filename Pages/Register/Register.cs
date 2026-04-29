using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;
using System.Configuration;

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
        }

        //Métodos dos componentes gráficos
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.createdAt = DateTime.UtcNow;
            user.email = tbEmail.Text;
            user.name = tbName.Text;
            user.password = tbPassword.Text;
            user.phoneNumber = tbPhoneNum.Text;
            user.role = 2;
            user.schoolID_num = tbIDNumber.Text;
            user.postalCode = tbPostcode.Text;

            string passwordConfirm = tbPasswordConfirm.Text;

            var register = Auth.Register(user, passwordConfirm);
            if (register.IsValid)
            {
                UserData.Save();
            }
        }
        private void LbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){LoginForm.Open(this);}

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {//Mostrar a senha
                tbPassword.PasswordChar = '\0';
            }
            else
            {//Esconder a senha
                tbPassword.PasswordChar = '*';
            }
        }

        private void checkBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {//Mostrar a senha
                tbPassword_Confirm.PasswordChar = '\0';
            }
            else
            {//Esconder a senha
                tbPassword_Confirm.PasswordChar = '*';
            }
        }
    }
}
