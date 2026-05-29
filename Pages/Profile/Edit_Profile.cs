using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP.ProfileFolder
{
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }
        //Load do form
        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Altere apenas os campos que deseja editar");
            CurrentUserInfo();
        }

        //Métodos dos componentes gráficos
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckDiference())
            {
                MessageBox.Show("Nenhuma alteração foi feita");
            }
            else
            {
                try
                {
                    User user = new User
                    {
                        ID = CurrentSession.User.ID,
                        Email = tbEmail.Text,
                        Name = tbName.Text,
                        Password = tbPassword.Text,
                        PhoneNumber = tbPhoneNum.Text,
                        SchoolIDNumber = tbSchoolMemberID.Text,
                        PostCode = tbPostcode.Text
                    };
                    var update = UserData.Update(user, tbPassword_Confirm.Text);
                    if (update.IsValid)
                    {
                        var res = MessageBox.Show("Tem certeza que deseja alterar os seus dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            MessageBox.Show("Utilizador editado", "");
                            LoginForm.Open(this);
                        }
                        User_BLL.UpdateUser(user);
                    }
                    else
                    {
                        MessageBox.Show(update.ErrorMessage);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ocorreu um erro: "+err.Message);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Edição descartada", "");   
            }
        }

        //Métodos Auxiliares
        private void CurrentUserInfo()
        {
            tbEmail.Text = CurrentSession.User.Email;
            tbName.Text = CurrentSession.User.Name;
            tbPassword.Text = CurrentSession.User.Password;
            tbPassword_Confirm.Text = CurrentSession.User.Password;
            tbPhoneNum.Text = CurrentSession.User.PhoneNumber;
            tbSchoolMemberID.Text = CurrentSession.User.SchoolIDNumber;
            tbPostcode.Text = CurrentSession.User.PostCode;
        }
        private bool CheckDiference()
        {
            try
            {
                var checks = new[]
                {
                    tbEmail.Text == CurrentSession.User.Email,
                    tbName.Text == CurrentSession.User.Name,
                    tbPassword.Text == CurrentSession.User.Password,
                    tbPhoneNum.Text == CurrentSession.User.PhoneNumber,
                    tbSchoolMemberID.Text == CurrentSession.User.SchoolIDNumber,
                    tbPostcode.Text == CurrentSession.User.PostCode
                };  
                foreach (var result in checks)
                {
                    if (!result)
                    {
                        return false;
                    }
                    return true;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: "+err.Message);
                return false;
            }
        }

        private void checkBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}