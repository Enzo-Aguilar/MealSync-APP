using MealSync_APP.Globals;
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

namespace MealSync_APP.ProfileFolder
{
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Altere apenas os campos que deseja editar");
            CurrentUserInfo();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Edição descartada", "");
                LoginForm.Open(this);
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
            tbPostcode.Text = CurrentSession.User.PostalCode;
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
                tbPostcode.Text == CurrentSession.User.PostalCode
            };
                foreach (var result in checks)
                {
                    if (!result)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: "+err.Message);
            }
        }
    }
}