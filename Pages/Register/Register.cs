using System.Security.Cryptography;
using System.Windows.Forms;
using MealSync_APP.Utils;
using System;
using System.Drawing;

namespace MealSync_APP
{
    public partial class Register : Form
    {
         private readonly User user = new User();
        
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
                user.PostCode = tbPostcode.Text;

                var register = UserAuth.Register(user, tbPassword_Confirm.Text);
                if (register.IsValid)
                {
                    MessageBox.Show("Utilizador criado com sucesso!", "SUCESSO");
                    LoginForm.Open(this);
                }
                else
                {
                    MessageBox.Show(register.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                ofd.Title = "Select an Image";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pbUserProfilePicture.Image = null;
                    pbUserProfilePicture.Image = Image.FromFile(ofd.FileName);
                    user.ProfileImage = ImgConverter.ImageToBytes(pbUserProfilePicture.Image);
                }
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
                tbPassword_Confirm.PasswordChar = '\0'; 
                labelPasswordConfirm.Text = "🔓";
            }
            else
            {
                tbPassword_Confirm.PasswordChar = '*';
                labelPasswordConfirm.Text = "🔒";
            }
        }
    }
}
