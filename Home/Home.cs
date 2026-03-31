using MealSync_APP._Começo;
using MealSync_APP._Conta_Bancaria;
using MealSync_APP.Marcações;
using MealSync_APP.Pedidos;
using MealSync_APP.Refeições;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Load do form
        private void Home_Load(object sender, EventArgs e)
        {
            Is_Admin();
        }

        //Métodos dos componentes gráficos
        private void associar_ContaBancaria_Click(object sender, EventArgs e)
        {
            Associar_ContaBancaria acb = new Associar_ContaBancaria();
            acb.MdiParent = this;
            acb.Show();
        }
        private void criar_ContaBancaria_Click(object sender, EventArgs e)
        {
            Criar_ContaBancaria ccb = new Criar_ContaBancaria();
            ccb.MdiParent = this;
            ccb.Show();
        }
        private void desmarcar_Pedidos_Click(object sender, EventArgs e)
        {
            Desmarcar_Pedido dp = new Desmarcar_Pedido();
            dp.MdiParent = this;
            dp.Show();
        }
        private void fazer_Pedido_Click(object sender, EventArgs e)
        {
            Fazer_Pedidos fm = new Fazer_Pedidos();
            fm.MdiParent = this;
            fm.Show();
        }
        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Index index = new Index();
            index.Show();
        }




    }
}
