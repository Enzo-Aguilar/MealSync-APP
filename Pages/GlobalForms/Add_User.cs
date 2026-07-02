using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Add_User : Form
    {
        private static readonly User _user = new User(); 
        public Add_User(string userType)
        {
            InitializeComponent();
            CbRoleVisibility(userType);
        }
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                _user.CreatedAt = DateTime.UtcNow;
                _user.Email = tbEmail.Text;
                _user.Name = tbName.Text;
                _user.Password = tbPassword.Text;
                _user.PhoneNumber = tbPhoneNumber.Text;
                _user.PostCode = tbPostCode.Text;
                _user.ProfileImage = ImageUtils.ImageToBytes(pbUserProfilePicture.Image) ?? null;
                _user.SchoolIDNumber = tbSchoolMemberID.Text;
                string passwordConfirm = tbPassword_Confirm.Text;

                var createUser = UserAuth.CreateUser(_user, passwordConfirm);
                if (createUser.IsValid)
                {
                    MessageBox.Show("Utilizador Criado com sucesso");
                    _user.Clear();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(createUser.ErrorMessage, createUser.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Helpers
        private void CbRoleVisibility(string userType)
        {
            cbRole.Enabled = true;
            if (userType == "Student")
            {
                _user.Role = 2;
                cbRole.Text = "Aluno";
            }
            else if (userType == "Employee")
            {
                _user.Role = 1;
                cbRole.Text = "Funcionário";
            }
            else if (userType == "Admin")
            {
                _user.Role = 0;
                cbRole.Text = "Administrador";
            }
            cbRole.Enabled = false;
        }
        private void ClearFields()
        {
            tbEmail.Clear();
            tbName.Clear();
            tbPassword.Clear();
            tbPassword_Confirm.Clear();
            tbPhoneNumber.Clear();
            tbPostCode.Clear();
            pbUserProfilePicture.Image.Dispose();
            tbSchoolMemberID.Clear();
        }
        private void PbProfileImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                    ofd.Title = "Select an Image";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pbUserProfilePicture.Image = null;
                        pbUserProfilePicture.Image = Image.FromFile(ofd.FileName);
                        _user.ProfileImage = ImageUtils.ImageToBytes(pbUserProfilePicture.Image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbPassword_Click(object sender, EventArgs e)
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

        private void tbPassword_Confirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword2_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text.Contains("🔒"))
            {
                tbPassword.PasswordChar = '\0';
                lbPassword2.Text = "🔓";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                lbPassword2.Text = "🔒";
            }
        }
    }
}
