using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP
{
    public partial class OLDAssociar_contaBancaria : Form
    {
        public OLDAssociar_contaBancaria()
        {
            InitializeComponent();
        }

        //Load do form
        private void Associar_contaBancaria_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        //Eventos dos componentes gráficos
        private void btnAssociar_Click(object sender, EventArgs e)
        {
            try
            {
                //Buscar valores das textbox's
                int ID = Convert.ToInt16(tbID.Text);
                DateTime data = Convert.ToDateTime(tbData.Text);
                string IBAN = tbIBAN.Text;
                string password = tbPassword.Text;

                bool validar = Validar_Dados(ID, IBAN, password);
                if (validar)
                {
                    DataTable dt = BLL.ContaBancaria.Procurar_PorID(ID);
                    if(dt.Rows.Count != 0)
                    {
                        if(dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0][4].ToString() == password)
                            {
                                int ID_Utilizador = Globais.Utilizador.ID;
                                BLL.Utilizador.Titular.Associar(ID_Utilizador,ID);

                                //Guardar os dados da conta bancária associada ao utilizador
                                Globais.ContaBancaria.ID = ID;
                                string saldo = dt.Rows[0][3].ToString();
                                Globais.ContaBancaria.saldo = new SqlMoney(Convert.ToInt16(saldo));

                                this.Close();
                            }
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void dgv_contasBancarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ignorar o cabeçalho da tabela
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tabela_contasBancarias.Rows[e.RowIndex];

            //Mostrar valores nas textbox's
            tbID.Text = row.Cells["ID"].Value.ToString();
            tbData.Text = row.Cells["data"].Value.ToString();
            tbIBAN.Text = row.Cells["IBAN"].Value.ToString();
        }

        //Funções auxiliares
        private bool Validar_Dados(int ID, string IBAN, string password)
        {
            try
            {
                if (ID > 0)
                {
                    if (!string.IsNullOrEmpty(IBAN))
                    {
                        if (!string.IsNullOrEmpty(password))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Campo Password Invalido", "ERRO");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo IBAN Invalido", "ERRO");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Campo ID Invalido", "ERRO");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
                return false;
            }
        }
        private void Atualizar()
        {
            //"Sabor" atualizar
            tabela_contasBancarias.Visible = false;
            tabela_contasBancarias.Visible = true;

            //Adiciona os valores das Contas Bancarias a tabela
            tabela_contasBancarias.DataSource = BLL.ContaBancaria.Mostrar();
        }
    }
}
