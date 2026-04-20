using BusinessLogicLayer;
using MealSync_APP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP
{
    public partial class Register : Form
    {
        private readonly string _form;
        public Register(string whoForm)
        {
            InitializeComponent();
            _form = whoForm;
        }
        //Load do form
        private void Registo_Load(object sender, EventArgs e)
        {
            UserData.Reset();

            if(_form == "Index")
            {
                cbRole.SelectedIndex = 2;
                cbRole.SelectedItem = "Alunos";
                cbRole.Enabled = false;
            }
            else if(_form == "Add_Student")
            {
                this.Name = "Adicionar Aluno";
                cbRole.SelectedIndex = 2;
                cbRole.SelectedItem = "Alunos";
                cbRole.Enabled = false;
            }
            else if (_form == "Add_Admin")
            {
                cbRole.SelectedIndex = 0;
                cbRole.SelectedItem = "Administrador";
                cbRole.Enabled = false;
            }

        }

        //Métodos dos componentes gráficos
        private void lbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Index();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime createdAt = DateTime.UtcNow;
            string email = tbEmail.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string passwordConfirm = tbPassword_Confirm.Text;
            int role = cbRole.SelectedIndex;

            Auth.Register(email, name, password, passwordConfirm, role);
            BLL.User.Create_User(createdAt, email, name, password, role);
            MessageBox.Show("Utilizador Criado com sucesso");

            FormUtils.Open_Index();
            this.Close();
        }
    }
}
