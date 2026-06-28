using BusinessLogicLayer;
using MealSync_APP.Globals;
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

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Deactivate_User : Form
    {
        private string roleFilter = null;
        private DataTable currentDgvQuery;
        public Deactivate_User(string fromWhere)
        {
            InitializeComponent();
        }

        private void Remove_User_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = currentDgvQuery = User_BLL.Show_AllUsers();
            roleFilter = null;
        }
        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    string ID  = dgvUsers.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty; 
                    string name = dgvUsers.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    string email = dgvUsers.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    string phoneNum = dgvUsers.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    byte[] imageByte = (byte[])dgvUsers.Rows[e.RowIndex].Cells[5].Value;

                    tbUserId.Text = ID;
                    tbUserName.Text = name;
                    tbUserEmail.Text = email;
                    tbUserPhoneNumber.Text = phoneNum;
                    pbUserProfileImage.Image = ImageUtils.BytesToImage(imageByte);
                }
                catch(Exception ex)
                {

                    MessageBox.Show($"Ocorreu um erro: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void BtnFilterByAdmins_Click(object sender, EventArgs e)
        {
            roleFilter = "Admin";
            dgvUsers.DataSource = currentDgvQuery = User_BLL.Admin.Show_Admins();
        }
        private void BtnFilterByEmployee_Click(object sender, EventArgs e)
        {
            roleFilter = "Employee";
            dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_Employees();
        }
        private void BtnFilterByStudent_Click(object sender, EventArgs e)
        {
            roleFilter = "Student";
            dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_Students();
        }
        private void BtnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbUserId.Text);
                var message = MessageBox.Show("Tem certeza?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var deactivateUser = UserAuth.DeactivateUser(ID);
                    if (deactivateUser.IsValid)
                    {
                        MessageBox.Show("Utilizador desativado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(deactivateUser.ErrorMessage, deactivateUser.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        private void BtnAlphabeticOrder_Click(object sender, EventArgs e)
        {
            if(roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_Admins_Alphabetical();
            }
            else if(roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_Employees_Alphabetical();
            }
            else if(roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_Students_Alphabetical();
            }
            else if (roleFilter == null)
            {
                dgvUsers.DataSource = User_BLL.Show_AllUsers_Alphabetical();
            }
        }
        private void BtnIdOrder_Click(object sender, EventArgs e)   
        {
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_Admins_OrderById();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_Employees_OrderById();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_Students_OrderById();
            }
            else if (roleFilter == null)
            {
                dgvUsers.DataSource = User_BLL.Show_AllUsers_OrderById();
            }
        }
        private void BtnCreatedAtOrder_Click(object sender, EventArgs e)
        {
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_Admins_OrderByCreationDate();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_Employees_OrderByCreationDate();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_Students_OrderByCreationDate();
            }
            else if(roleFilter == null)
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Show_AllUsers_OrderByCreationDate();
            }
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvUsers.DataSource = currentDgvQuery;
            }
            else
            {
                if (roleFilter == "Admin")
                {
                    dgvUsers.DataSource = User_BLL.Admin.Search_AdminByName(tbSearch.Text);
                }
                else if (roleFilter == "Employee")
                {
                    dgvUsers.DataSource = User_BLL.Employee.Search_EmmployeeByName(tbSearch.Text);
                }
                else if (roleFilter == "Student")
                {
                    dgvUsers.DataSource = User_BLL.Student.Search_StudentByName(tbSearch.Text);
                }
                else if(roleFilter == null)
                {
                    dgvUsers.DataSource = User_BLL.Search_UserByName(tbSearch.Text);
                }
            }
        }

        //Helpers
        private void ClearFields()
        {
            roleFilter = null;
            tbSearch.Clear();
            tbUserId.Clear();
            tbUserName.Clear();
            tbUserEmail.Clear();
            tbUserPhoneNumber.Clear();
            pbUserProfileImage.Image = null;
        }
    }
}
