using System.Security.Cryptography;
using System.Windows.Forms;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP
{
    public partial class Register : Form
    {
        static private readonly User user = new User();
        static private readonly Aes aes = Aes.Create();
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
            try
            {
                user.CreatedAt = DateTime.UtcNow;
                user.Email = tbEmail.Text;
                user.Name = tbName.Text;
                user.Password = tbPassword.Text;
                user.PhoneNumber = tbPhoneNum.Text;
                user.Role = 2;
                user.SchoolIDNumber = tbSchoolMemberID.Text;
                user.PostalCode = tbPostcode.Text;

                string passwordConfirm = tbPassword_Confirm.Text;
                var register = UserAuth.Register(user, passwordConfirm);
                if (register.IsValid)
                {
                    LoginForm.Open(this);
                }
                else
                {
                    MessageBox.Show(register.errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar registar o utilizador: " + err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void LbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){LoginForm.Open(this);}

        private void PbUserProfilePicture_Click(object sender, EventArgs e)
        {
            //Adiconar imagem de perfil
        }

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
