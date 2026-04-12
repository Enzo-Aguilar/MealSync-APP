using System.Windows.Forms;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        //Load do form
        private void Index_Load(object sender, EventArgs e)
        {
            UserUtils.Reset_UserData();   
        }

        //Métodos dos componentes graficos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserUtils.Auth_UserLogin(tbNome.Text, tbPassword.Text))
            {
                FormUtils.Open_Home(this);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro no login");
            }
        }
        private void lbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Register(this);
        }
    }
}