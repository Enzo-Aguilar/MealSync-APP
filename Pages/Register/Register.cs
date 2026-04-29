using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;

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
            //UserData
            DateTime CreatedAt = DateTime.UtcNow;
            string email = tbEmail.Text;       
            string name = tbName.Text;
            string password = tbPassword.Text; 
            string passwordConfirm = tbPassword_Confirm.Text;
            string phoneNumber = tbPhoneNum.Text;
            int role = 2;                      
            string IDNumber = tbIDNumber.Text;
            string postcode = tbPostcode.Text; 
        }
        private void LbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){LoginForm.Open(this);}
    }
}
