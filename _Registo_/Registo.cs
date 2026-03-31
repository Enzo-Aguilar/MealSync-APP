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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }
        //Load do form
        private void Registo_Load(object sender, EventArgs e)
        {
            Limpar_Dados();
        }

        //Métodos dos componentes gráficos
        private void btnCriar_Conta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataCriacao = DateTime.Now;
                string email = tbEmail.Text;
                string funcao = Convert.ToString(cbFuncao.SelectedItem.ToString());
                string nome = tbNome.Text;
                string password = tbPassword.Text;

                if (Validar_Dados() && Procurar_Dados())
                {
                    try
                    {
                        BLL.Utilizador.Criar(dataCriacao, email, funcao, nome, password);
                        MessageBox.Show("Conta criada com sucesso! Faça seu primeiro login", "Sucesso");
                        Abrir_Index();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao criar a conta: " + ex.Message, "EXCEPTION I");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar a conta: " + ex.Message, "EXCEPTION II");
            }
        }
        private void lbLink_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abrir_Index();
        }

        //Métodos Auxiliares
        private void Limpar_Dados()
        {
            //Limpar textboxes e combobox
            tbEmail.Text = string.Empty;
            cbFuncao.SelectedIndex = 0;
            tbNome.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbPassword_Confirmar.Text = string.Empty;
        }
        private bool Procurar_Dados()
        {
            string email = tbEmail.Text;
            string nome = tbNome.Text;

            try
            {
                DataTable dtEmail = BLL.Auxiliar.Procurar.Utilizador.Procurar_Email(email);
                DataTable dtNome = BLL.Auxiliar.Procurar.Utilizador.Procurar_Nome(nome);

                if (dtEmail.Rows.Count == 0)
                {
                    if (dtNome.Rows.Count == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Já existe um utilizador com este nome", "Aviso");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Já existe um utilizador com este email", "Aviso");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao procurar os dados: " + ex.Message, "EXCEPTION");
                return false;
            }
        }
        private bool Validar_Dados()
        {
            string email = tbEmail.Text;
            string funcao = cbFuncao.SelectedItem.ToString();
            string nome = tbNome.Text;
            string password = tbPassword.Text;
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    if (!string.IsNullOrEmpty(funcao))
                    {
                        if (!string.IsNullOrEmpty(nome))
                        {
                            if (!string.IsNullOrEmpty(password))
                            {
                                if (password == tbPassword_Confirmar.Text)
                                {
                                    return true;
                                }
                                else
                                {
                                    tbPassword.Text = string.Empty;
                                    tbPassword_Confirmar.Text = string.Empty;
                                    MessageBox.Show("As passwords não coincidem", "ERRO");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo [password] não pode estar vazio", "ERRO");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo [nome] não pode estar vazio", "ERRO");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo [Tipo de conta] não pode estar vazio", "ERRO");
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("O campo email não pode estar vazio", "ERRO");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao validar os dados: " + ex.Message, "EXCEPTION");
                return false;
            }
        }

        //Métodos de chamada para outros forms
        private void Abrir_Index()
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }
    }
}
