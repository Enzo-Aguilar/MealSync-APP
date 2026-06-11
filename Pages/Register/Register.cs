using System.Security.Cryptography;
using System.Windows.Forms;
using MealSync_APP.Utils;
using System;
using System.Drawing;
using MealSync_APP.Globals;

namespace MealSync_APP
{
    public partial class Register : Form
    {
        private readonly User _u = new User();

        public Register()
        {
            InitializeComponent();
        }
        private void Registo_Load(object sender, EventArgs e)
        {
            CurrentSession.Clear();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int roleStudent = 2;
                string passwordConfirm = tbPasswordConfirm.Text;

                _u.CreatedAt = DateTime.Now;
                _u.Email = tbEmail.Text;
                _u.Name = tbName.Text;
                _u.Password = tbPassword.Text;
                _u.PhoneNumber = tbPhoneNum.Text;
                _u.PostCode = tbPostcode.Text;
                _u.Role = roleStudent;
                _u.SchoolIDNumber = tbSchoolMemberID.Text;

                var register = UserAuth.Register(_u, passwordConfirm);
                if (register.IsValid)
                {
                    MessageBox.Show("Utilizador criado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm.Open(this);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(register.ErrorMessage, register.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                _u.Clear();
            }
        }
        private void LbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { LoginForm.Open(this); }
        private void PbUserProfilePicture_Click(object sender, EventArgs e)
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
                        _u.ProfileImage = ImageUtils.ImageToBytes(pbUserProfilePicture.Image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (labelPassword.Text.Contains("🔒"))
            {
                tbPassword.PasswordChar = '\0';
                labelPassword.Text = "🔓";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                labelPassword.Text = "🔒";
            }
        }
        private void LbPassword_Confirm_Click(object sender, EventArgs e)
        {
            if (labelPasswordConfirm.Text.Contains("🔒"))
            {
                tbPasswordConfirm.PasswordChar = '\0';
                labelPasswordConfirm.Text = "🔓";
            }
            else
            {
                tbPasswordConfirm.PasswordChar = '*';
                labelPasswordConfirm.Text = "🔒";
            }
        }

        //Helpers
        private void ClearFields()
        {
            tbEmail.Clear();
            tbName.Clear();
            tbPassword.Clear();
            tbPasswordConfirm.Clear();
            tbPhoneNum.Clear();
            tbSchoolMemberID.Clear();
            tbPostcode.Clear();
            pbUserProfilePicture.Image = null;
        }
    }
}
