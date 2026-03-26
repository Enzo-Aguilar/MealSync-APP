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
using System.Xml.Linq;

namespace MealSync_APP
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        private void Index_Load(object sender, EventArgs e)
        {
            //Limpar valores do Utilizador anterior
            Globais.Utilizador.ID = 0;
            Globais.Utilizador.funcao = "";
            Globais.Utilizador.nome = "";

            MessageBox.Show("Seja Bem-Vindo a MealSync");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbNome.Text) && !string.IsNullOrEmpty(tbPassword.Text))
                {
                    DataTable dt = BLL.Utilizador.procurar_UtilizadorPorNome(tbNome.Text);
                    if (dt.Rows.Count != 0)
                    {
                        if (dt.Rows.Count > 0 && dt.Rows[0][5].ToString() == tbPassword.Text)
                        {
                            Globais.Utilizador.nome = tbNome.Text;

                            //Guardar a função do utilizador
                            Globais.Utilizador.funcao = dt.Rows[0][3].ToString();

                            //Guardar ID's
                            Globais.Utilizador.ID = Convert.ToInt16(dt.Rows[0][0]);

                            criarContaBancaria();
                            Home home = new Home();
                            this.Hide();
                            home.Show();

                        }
                        else
                        {
                            MessageBox.Show("Password incorreta", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de utilizador incorreto", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "EXCEPTION");
            }
        }

        private void criarContaBancaria()
        {
            // Criar a MessageBox
            DialogResult result = MessageBox.Show(
                text: "Deseja criar um conta bancaria?",
                caption: "Index",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question
            );

            //Tratar os resultados
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "You confirmed! Action is proceeding.",
                    "Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                BLL.
            }
            else
            {
                MessageBox.Show(
                    "Cancelled. No changes were made.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
