using MealSync_APP._Começo;
using MealSync_APP._Conta_Bancaria;
using MealSync_APP._Utilizador_;
using MealSync_APP.Administradores;
using MealSync_APP.Alunos;
using MealSync_APP.Marcações;
using MealSync_APP.Pedidos;
using MealSync_APP.Refeições;
using MealSync_APP.Utils;
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
            
        }
    
        //Métodos dos componentes gráficos
        private void Logout_Click(object sender, EventArgs e)
        {
            FormUtils.Open_Index();
        }

        private void edit_Profile_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm_EditProfile();
        }
    }
}
