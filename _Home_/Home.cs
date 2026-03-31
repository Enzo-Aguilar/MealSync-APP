using MealSync_APP._Começo;
using MealSync_APP._Conta_Bancaria;
using MealSync_APP._Utilizador_;
using MealSync_APP.Administradores;
using MealSync_APP.Alunos;
using MealSync_APP.Marcações;
using MealSync_APP.Pedidos;
using MealSync_APP.Refeições;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private void sair_Click(object sender, EventArgs e)
        {
            Index INDEX = new Index();
            INDEX.Show();
            this.Close();
        }

        //Perfil
        private void editar_Perfil_Click(object sender, EventArgs e)
        {
            Editar_Perfil EditarPerfil = new Editar_Perfil();
            EditarPerfil.MdiParent = this;
            EditarPerfil.Show();
        }

        //Conta Bancária
        private void associar_ContaBancaria_Click(object sender, EventArgs e)
        {
            Associar_ContaBancaria AssociarContaBancaria = new Associar_ContaBancaria();
            AssociarContaBancaria.MdiParent = this;
            AssociarContaBancaria.Show();
        }
        private void criar_ContaBancaria_Click(object sender, EventArgs e)
        {
            Criar_ContaBancaria CriarContaBancaria = new Criar_ContaBancaria();
            CriarContaBancaria.MdiParent = this;
            CriarContaBancaria.Show();
        }

        //Marcações
        private void ver_Pedidos_Click(object sender, EventArgs e)
        {
            Ver_Pedidos VerPedidos = new Ver_Pedidos();
            VerPedidos.MdiParent = this;
            VerPedidos.Show();
        }
        private void fazer_Pedido_Click(object sender, EventArgs e)
        {
            Fazer_Pedido FazerPedido = new Fazer_Pedido();
            FazerPedido.MdiParent = this;
            FazerPedido.Show();
        }
        private void desmarcar_Pedidos_Click(object sender, EventArgs e)
        {
            Desmarcar_Pedido DesmarcarPedido = new Desmarcar_Pedido();
            DesmarcarPedido.MdiParent = this;
            DesmarcarPedido.Show();
        }

        //Refeições
        private void ver_Refeicoes_Click(object sender, EventArgs e)
        {
            Ver_Refeicoes VerRefeicoes = new Ver_Refeicoes();
            VerRefeicoes.MdiParent = this;
            VerRefeicoes.Show();
        }
        private void adicionar_Refeicoes_Click(object sender, EventArgs e)
        {
            Adicionar_Refeicoes AdicionarRefeicoes = new Adicionar_Refeicoes();
            AdicionarRefeicoes.MdiParent = this;
            AdicionarRefeicoes.Show();
        }
        private void editar_Refeicoes_Click(object sender, EventArgs e)
        {
            Editar_Refeicoes EditarRefeicoes = new Editar_Refeicoes();
            EditarRefeicoes.MdiParent = this;
            EditarRefeicoes.Show();
        }
        private void remover_Refeicoes_Click(object sender, EventArgs e)
        {
            Remover_Refeicoes RemoverRefeicoes = new Remover_Refeicoes();
            RemoverRefeicoes.MdiParent = this;
            RemoverRefeicoes.Show();
        }

        //Alunos
        private void ver_Alunos_Click(object sender, EventArgs e)
        {
           Ver_Alunos VerAlunos = new Ver_Alunos();
            VerAlunos.MdiParent = this;
            VerAlunos.Show();
        }
        private void adicionar_Alunos_Click(object sender, EventArgs e)
        {
            Adicionar_Aluno AdicionarAluno = new Adicionar_Aluno();
            AdicionarAluno.MdiParent = this;
            AdicionarAluno.Show();
        }
        private void editar_Alunos_Click(object sender, EventArgs e)
        {
            Editar_Aluno EditarAluno = new Editar_Aluno();
            EditarAluno.MdiParent = this;
            EditarAluno.Show();
        }
        private void remover_Alunos_Click(object sender, EventArgs e)
        {
            Remover_Aluno RemoverAluno = new Remover_Aluno();
            RemoverAluno.MdiParent = this;
            RemoverAluno.Show();
        }

        //Funcionários
        private void ver_Funcionarios_Click(object sender, EventArgs e)
        {
            Ver_Alunos VerAlunos = new Ver_Alunos();
            VerAlunos.MdiParent = this;
            VerAlunos.Show();
        }
        private void adicionar_Funcionarios_Click(object sender, EventArgs e)
        {
            Adicionar_Aluno AdicionarAluno = new Adicionar_Aluno();
            AdicionarAluno.MdiParent = this;
            AdicionarAluno.Show();
        }
        private void editar_Funcionarios_Click(object sender, EventArgs e)
        {
            Editar_Aluno EditarAluno = new Editar_Aluno();
            EditarAluno.MdiParent = this;
            EditarAluno.Show();
        }
        private void remover_Funcionarios_Click(object sender, EventArgs e)
        {
            Remover_Aluno RemoverAluno = new Remover_Aluno();
            RemoverAluno.MdiParent = this;
            RemoverAluno.Show();
        }

        //Administradores
        private void ver_Administradores_Click(object sender, EventArgs e)
        {
            Ver_Adminstradores VerAdministradores = new Ver_Adminstradores();
            VerAdministradores.MdiParent = this;
            VerAdministradores.Show();
        }
        private void adicionar_Administradores_Click(object sender, EventArgs e)
        {
            Adicionar_Adminstrador AdicionarAdministrador = new Adicionar_Adminstrador();
            AdicionarAdministrador.MdiParent = this;
            AdicionarAdministrador.Show();
        }
        private void editar_Administradores_Click(object sender, EventArgs e)
        {
            Editar_Administrador EditarAdministrador = new Editar_Administrador();
            EditarAdministrador.MdiParent = this;
            EditarAdministrador.Show();
        }
        private void remover_Administradores_Click(object sender, EventArgs e)
        {
            Remover_Administrador RemoverAdministrador  = new Remover_Administrador();
            RemoverAdministrador.MdiParent = this;
            RemoverAdministrador.Show();
        }

        //Métodos Auxiliares
        private void Is_Admin()
        {
            if (Globais.Utilizador.funcao != "administrador")
            {
                //Esconder opções de admin

                //Refeições
                adicionar_Refeicoes.Visible = false;
                editar_Refeicoes.Visible = false;
                remover_Refeicoes.Visible = false;

                //Aluno, Funcionário, Administrador
                Alunos.Visible = false;
                Funcionarios.Visible = false;
                Administradores.Visible = false;
            }
        }
    }
}
