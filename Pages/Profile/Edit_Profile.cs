using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP.ProfileFolder
{
    public partial class Edit_Profile : Form
    {
        private User _user = new User();
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
            if (CheckDiff())
            {
                try
                {
                    _user = new User
                    {
                        ID = CurrentSession.User.ID,
                        Email = tbEmail.Text,
                        Name = tbName.Text,
                        Password = tbPassword.Text ?? CurrentSession.User.Password,
                        PhoneNumber = tbPhoneNum.Text,
                        SchoolIDNumber = tbSchoolMemberID.Text,
                        PostCode = tbPostcode.Text
                    };
                    var message = MessageBox.Show("Tem certeza que deseja efetuar alterações", "?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        var update = UserData.Update(_user, tbPasswordConfirm.Text);
                        if (update.IsValid)
                        {
                            MessageBox.Show("Utilizador editado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(update.ErrorMessage, update.Source, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma alteração foi efetuada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Edição descartada", "",MessageBoxButtons.OK,MessageBoxIcon.Information);   
            }
        }

        //Métodos Auxiliares
        private void CurrentUserInfo()
        {
            tbEmail.Text = CurrentSession.User.Email;
            tbName.Text = CurrentSession.User.Name;
            tbPhoneNum.Text = CurrentSession.User.PhoneNumber;
            tbSchoolMemberID.Text = CurrentSession.User.SchoolIDNumber;
            tbPostcode.Text = CurrentSession.User.PostCode;
        }
        private bool CheckDiff()
        {
            try
            {
                var textboxs = new[]
                {
                    tbEmail.Text == CurrentSession.User.Email,
                    tbName.Text == CurrentSession.User.Name,
                    Password.HashPassword(tbPassword.Text) == CurrentSession.User.Password,
                    tbPhoneNum.Text == CurrentSession.User.PhoneNumber,
                    tbSchoolMemberID.Text == CurrentSession.User.SchoolIDNumber,
                    tbPostcode.Text == CurrentSession.User.PostCode
                };  
                foreach (var textbox in textboxs)
                {
                    if (!textbox)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text.Contains("🔒"))
            {
                tbPassword.PasswordChar = '\0';
                lbPassword.Text = "🔓";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                lbPassword.Text = "🔒";
            }
        }

        private void LbPasswordConfirm_Click(object sender, EventArgs e)
        {
            if (lbPasswordConfirm.Text.Contains("🔒"))
            {
                tbPasswordConfirm.PasswordChar = '\0';
                lbPasswordConfirm.Text = "🔓";
            }
            else
            {
                tbPasswordConfirm.PasswordChar = '*';
                lbPasswordConfirm.Text = "🔒";
            }
        }
    }
}