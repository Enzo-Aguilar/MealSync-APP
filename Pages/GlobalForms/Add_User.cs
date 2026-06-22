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
        public Add_User(string fromWhere)
        {
            InitializeComponent();
        }
        //Load do form
        private void Create_User_Load(object sender, EventArgs e)
        {
            CbRole_Visibility();
        }

        //Métodos dos Componentes Gráficos
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            DateTime createdAt = DateTime.UtcNow;
            string email = tbEmail.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string passwordConfirm = tbPassword_Confirm.Text;
            int role = _role;

         
            User_BLL.Create_User();
            MessageBox.Show("Utilizador Criado com sucesso");
        }

        //Métodos Auxiliares
        private void CbRole_Visibility()
        {
            //Fazer switch pra verificar se é 0 1 ou 2
        }


    }
}
