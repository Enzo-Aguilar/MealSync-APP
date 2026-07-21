using System.Windows.Forms;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System.Drawing;
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
                        Password = tbPassword.Text,
                        PhoneNumber = tbPhoneNum.Text,
                        SchoolIDNumber = tbSchoolMemberID.Text,
                        ProfileImage = ImageUtils.ImageToBytes(pbUserProfilePicture.Image),
                        PostCode = tbPostcode.Text,
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
                        _user.ProfileImage = ImageUtils.ImageToBytes(pbUserProfilePicture.Image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar imagem: {ex.Message}");
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

        //Métodos Auxiliares
        private void CurrentUserInfo()
        {
            tbEmail.Text = CurrentSession.User.Email;
            tbName.Text = CurrentSession.User.Name;
            tbPhoneNum.Text = CurrentSession.User.PhoneNumber;
            tbSchoolMemberID.Text = CurrentSession.User.SchoolIDNumber;
            tbPostcode.Text = CurrentSession.User.PostCode;
            pbUserProfilePicture.Image = ImageUtils.BytesToImage(CurrentSession.User.ProfileImage);
        }
        private bool CheckDiff()
        {
            try
            {
                var elements = new[]
                {
                    tbEmail.Text == CurrentSession.User.Email,
                    tbName.Text == CurrentSession.User.Name,
                    tbPassword.Text != string.Empty,
                    tbPasswordConfirm.Text != string.Empty,
                    tbPhoneNum.Text == CurrentSession.User.PhoneNumber,
                    tbSchoolMemberID.Text == CurrentSession.User.SchoolIDNumber,
                    tbPostcode.Text == CurrentSession.User.PostCode,
                    ImageUtils.ImageToBytes(pbUserProfilePicture.Image) == CurrentSession.User.ProfileImage
                };  
                foreach (var element in elements)
                {
                    if (!element)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void tbPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}