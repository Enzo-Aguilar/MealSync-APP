using BusinessLogicLayer;
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
    public partial class Choose_BankAccountType : Form
    {
        public Choose_BankAccountType()
        {
            InitializeComponent();
        }

        //Load do form
        private void Escolher_TipoContaBancaria_Load(object sender, EventArgs e)
        {
            //Começar por padrão aluno
            cbTipo_contaBancaria.SelectedIndex = 0;

            //Não permitir ao utilizador inserir valores manualmente
            cbTipo_contaBancaria.DropDownStyle = ComboBoxStyle.DropDownList;

            //Password começar invisivel
            lbPassword.Visible = false;
            tbPassword.Visible = false;
        }

        //Eventos dos componentes gráficos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int contador = 0;//Estava fazendo uma verificação pra definir a password 
            try
            {
                string tipo = cbTipo_contaBancaria.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(tipo))
                {
                    BankAccount.tipo = tipo;
                    MessageBox.Show("Tipo de conta " + tipo + " criado com sucesso");
                    MessageBox.Show("Por motivos de segurança por favor defina uma password");
                    lbPassword.Visible = true;
                    tbPassword.Visible = true;
                    contador++;

                 
                    Mostrar_Home();
                }
                else
                {
                    cbTipo_contaBancaria.SelectedIndex = 0;
                    MessageBox.Show("Valor Invalido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message, "ERRO");
            }
        }

        //Métodos de Chamada de outros forms
        private void Mostrar_Home ()
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
