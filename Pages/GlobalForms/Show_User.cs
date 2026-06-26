using System.Windows.Forms;
using BusinessLogicLayer;
using System;
using System.Data.SqlClient;

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Show_User : Form
    {
        private readonly string _fromWhere = string.Empty;
        private bool _allUsers = false;
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
        //Métodos dos componentes gráficos
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvUsers.Visible = false;
            LoadTable();
            dgvUsers.Visible = true;
        }

        private void BtnAlphabeticOrder_Click(object sender, EventArgs e)
        {
            if (_allUsers == false)
            {
                if (_fromWhere == "Admin")
                    dgvUsers.DataSource = User_BLL.Admin.Show_Admins_Alphabetical();
                else if (_fromWhere == "Employee")
                    dgvUsers.DataSource = User_BLL.Employee.Show_Employees_Alphabetical();
                else
                    dgvUsers.DataSource = User_BLL.Student.Show_Students_Alphabetical();
            }
            else
            {
                dgvUsers.DataSource = User_BLL.Show_AllUsers_Alphabetical();
            }
        }

        private void BtnIdOrder_Click(object sender, EventArgs e)
        {
            if (_allUsers == false)
            {
                if (_fromWhere == "Admin")
                    dgvUsers.DataSource = User_BLL.Admin.Show_Admins_OrderById();
                else if (_fromWhere == "Employee")
                    dgvUsers.DataSource = User_BLL.Employee.Show_Employees_OrderById();
                else
                    dgvUsers.DataSource = User_BLL.Student.Show_Students_OrderById();
            }
            else
            {
                dgvUsers.DataSource = User_BLL.Show_AllUsers_OrderById();
            }
        }

        private void BtnCreatedAtOrder_Click(object sender, EventArgs e)
        {
            if (_allUsers == false)
            {
                if (_allUsers == false)
                    if (_fromWhere == "Admin")
                        dgvUsers.DataSource = User_BLL.Admin.Show_Admins_OrderByCreationDate();
                    else if (_fromWhere == "Employee")
                        dgvUsers.DataSource = User_BLL.Employee.Show_Employees_OrderByCreationDate();
                    else
                        dgvUsers.DataSource = User_BLL.Student.Show_Students_OrderByCreationDate();
            }
            else
            {
                dgvUsers.DataSource = User_BLL.Show_AllUsers_OrderByCreationDate();
            }
        }

        //Helpers
        private void LoadTable()
        {
            if (_fromWhere == "Admin")
                dgvUsers.DataSource = User_BLL.Admin.Show_Admins();
            else if (_fromWhere == "Employee")
                dgvUsers.DataSource = User_BLL.Employee.Show_Employees();
            else
                dgvUsers.DataSource = User_BLL.Student.Show_Students();
        }
        private void BtnAllUsers_Click(object sender, EventArgs e)
        {
            _allUsers = !_allUsers;
        }
    }
}
