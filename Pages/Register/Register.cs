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
        public Register()
        {
            InitializeComponent();
        }
        //Load do form
        private void Registo_Load(object sender, EventArgs e)
        {
            UserUtils.Reset_UserData();
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
                       // BLL.Utilizador.Criar(dataCriacao, email, funcao, nome, password);
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
            FormUtils.Open_Index();
            this.Close();
        }

        private bool Procurar_Dados()//Procura dados duplicados
        {
            string email = tbEmail.Text;
            string nome = tbNome.Text;

            return false;
        }
        private bool Validar_Dados()
        {
            string email = tbEmail.Text;
            string funcao = cbFuncao.SelectedItem.ToString();
            string nome = tbNome.Text;
            string password = tbPassword.Text;

            //Tentar fazer fazer com switch
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
