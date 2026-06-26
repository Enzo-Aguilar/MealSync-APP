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
                _user.ProfileImage = ImageUtils.ImageToBytes(pbProfileImage.Image);
                _user.SchoolIDNumber = tbSchoolMemberID.Text;
                string passwordConfirm = tbPassword_Confirm.Text;

                var createUser = UserAuth.CreateUser(_user, passwordConfirm);
                if (createUser.IsValid)
                {
                    MessageBox.Show("Utilizador Criado com sucesso");
                    _user.Clear();
                    CleearFields();
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
            switch (userType) 
            {
                case "Student":
                    _user.Role = 2;
                    cbRole.Text = "Aluno";
                    break;
                case "Employee":
                    _user.Role = 1;
                    cbRole.Text = "Funcionário";
                    break;
                case "Admin":
                    _user.Role = 0;
                    cbRole.Text = "Adminstrador";
                    break;
            }

            cbRole.Enabled = false;
        }
        private void CleearFields()
        {
            tbEmail.Clear();
            tbName.Clear();
            tbPassword.Clear();
            tbPassword_Confirm.Clear();
            tbPhoneNumber.Clear();
            tbPostCode.Clear();
            pbProfileImage.Image.Dispose();
            tbSchoolMemberID.Clear();
        }
    }
}
