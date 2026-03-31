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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        //Load do form
        private void Index_Load(object sender, EventArgs e)
        {
            Limpar_Dados();
        }

        //Métodos dos componentes graficos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar_Dados())
                {
                    Guardar_Dados();
                    Abrir_Home();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message, "EXCEPTION");
            }
        }
        private void lbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abrir_Registo();
        }

        //Métodos Auxiliares
        private void Guardar_Dados()
        {
            DataTable dt = BLL.Utilizador.Procurar_porNome(tbNome.Text);

            //Guardar valores importantes do utilizador
            Globais.Utilizador.ID = Convert.ToInt16(dt.Rows[0][0]);
            Globais.Utilizador.funcao = dt.Rows[0][3].ToString();
            Globais.Utilizador.nome = tbNome.Text;
        }
        private void Limpar_Dados()
        {
            //Limpar dados do Utilizador anterior
            Globais.Utilizador.ID = -1;
            Globais.Utilizador.funcao = string.Empty;
            Globais.Utilizador.nome = string.Empty;

            //Limpar dados da Conta Bancária anterior
            Globais.ContaBancaria.ID = -1;
            Globais.ContaBancaria.saldo = 0;
            Globais.ContaBancaria.tipo = string.Empty;

            //Limpar campos de texto(Apenas por detalhe)
            tbNome.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
        private bool Validar_Dados()
        {
            string nome = tbNome.Text;
            string password = tbPassword.Text;

            try
            {
                if (!string.IsNullOrEmpty(nome))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        DataTable dt = BLL.Utilizador.Procurar_porNome(tbNome.Text);
                        if (dt.Rows.Count != 0)
                        {
                            if (dt.Rows.Count > 0 && dt.Rows[0][5].ToString() == password)
                            {
                                return true;
                            }
                            else
                            {
                                tbPassword.Text = string.Empty;
                                MessageBox.Show("Password Invalida", "ERRO");
                                return false;
                            }
                        }
                        else
                        {
                            tbNome.Text = string.Empty;
                            MessageBox.Show("Utilizador não encontrado", "ERRO");
                            return false;
                        }
                    }
                    else
                    {
                        tbPassword.Text = string.Empty;
                        MessageBox.Show("Campo Password Invalido", "ERRO");
                        return false;
                    }
                }
                else
                {
                    tbNome.Text = string.Empty;
                    MessageBox.Show("Campo nome Invalido", "ERRO");
                    return false;
                }
            }
            catch (Exception ex)
            {
                tbNome.Text = string.Empty;
                tbPassword.Text = string.Empty;
                MessageBox.Show("Ocorreu um erro " + ex.Message,"EXCEPTION");
                return false;
            }
        }

        //Métodos de chamada para outros forms
        private void Abrir_Home()
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void Abrir_Registo()
        {
            Registo registo = new Registo();
            registo.Show();
            this.Hide();
        }

    }
}
