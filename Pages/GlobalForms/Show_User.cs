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

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Show_User : Form
    {
        private readonly string _fromWhere;
        public Show_User(string fromWhere)
        {
            InitializeComponent();
            _fromWhere = fromWhere;
        }
        //Método de load
        private void Show_User_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            if (_fromWhere == "Admin")
                dataGridView1.DataSource = User_BLL.Admin.Show_Admins();
            else if (_fromWhere == "Employee")
                dataGridView1.DataSource = User_BLL.Employee.Show_Employees();
            else 
                dataGridView1.DataSource = User_BLL.Student.Show_Students();
        }

        //Métodos dos componentes gráficos
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnTableOrder_Click(object sender, EventArgs e)
        {

        }

        private void BtnTableOrder1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTableOrder2_Click(object sender, EventArgs e)
        {

        }

    }
}
