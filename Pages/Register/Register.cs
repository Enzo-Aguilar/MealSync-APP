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
            UserUtils.Reset_UserData();

            if(_form == "Index")
            {

                cbRole.SelectedIndex = 0;
                cbRole.SelectedItem = "Alunos";
                cbRole.Enabled = false;
            }
            else if(_form == "Add_Student")
            {
                this.Name = "Adicionar Aluno";
                cbRole.SelectedIndex = 0;
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
        private void btnCriar_Conta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime createdAt = DateTime.UtcNow;
                string email = Convert.ToString(tbEmail.Text);
                string name = Convert.ToString(tbName.Text);
                string password = Convert.ToString(tbPassword.Text);
                string passwordConfirm = Convert.ToString(tbPassword_Confirm.Text);
                int role = Convert.ToInt32(cbRole.SelectedIndex);

                if(UserUtils.Auth_UserRegister(createdAt, email, name, password,passwordConfirm, role))
                {
                    BLL.User.Create_User(createdAt, email, name, password, role);
                    MessageBox.Show("Utilizador criado com sucesso");
                    FormUtils.Open_Index();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao criar utilizador: "+err.Message,"EXCEPTION");
            }
            
        }
        private void lbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Index();
            this.Close();
        }
    }
}
