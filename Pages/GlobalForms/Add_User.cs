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
            if (_form == "Index" || _form == "Dashboard")
            {
                this.Text = "Register";
                cbRole.SelectedItem = "Aluno";
                cbRole.Enabled = false;
            }
            else if (_form == "Add_Student")
            {
                this.Text = "Adicionar Aluno";
                cbRole.SelectedItem = "Aluno";
                cbRole.Enabled = false;
            }
            else if (_form == "Add_Employee")
            {
                this.Text = "Adicionar Funcionario";
                cbRole.SelectedItem = "Funcionario";
                cbRole.Enabled = false;
            }
            else if (_form == "Add_Admin")
            {
                this.Text = "Adicionar Administrador";
                cbRole.SelectedItem = "Admin";
                cbRole.Enabled = false;
            }
            else
            {
                this.Text = "Register";
                cbRole.SelectedItem = "Aluno";
                cbRole.Enabled = false;
            }
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
