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
            UserData.Reset();
        }

        //Métodos dos componentes graficos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPassword.Text;

            if (Auth.Login(name, password).IsValid)
            {
                UserData.Save(name);
                FormUtils.Open_Home(this);
            }
            else
            {
                MessageBox.Show(Auth.Login(name, password).errorMessage);
            }
        }
        private void lbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Register(this,"Index");
        }
    }
}