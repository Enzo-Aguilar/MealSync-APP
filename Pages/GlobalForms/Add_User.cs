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
        private readonly int _role;

        public Add_User(string fromWhere)
        {
            InitializeComponent();
            _role = _role;

        }

        //Load do form
        private void Create_User_Load(object sender, EventArgs e)
        {
            CbRole_Visibility();

            cbRole.Items.Add("Administrador"); 
            cbRole.Items.Add("Funcionário");   
            cbRole.Items.Add("Aluno");         

            cbRole.SelectedIndex = _role; 
            cbRole.Enabled = false;       
        }

        //Métodos dos Componentes Gráficos
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime createdAt = DateTime.UtcNow;
            string email = tbEmail.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string passwordConfirm = tbPassword_Confirm.Text;
            int role = cbRole.SelectedIndex;

            //UserAuth.Register(email, name, password, passwordConfirm, role);
            //BLL.User.Create_User(createdAt, email, name, password, role);
            MessageBox.Show("Utilizador Criado com sucesso");
        }

        //Métodos Auxiliares
        private void CbRole_Visibility()
        {
           
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
