using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System.Data;
using System;

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Deactivate_User : Form
    {
        private string roleFilter;
        private DataTable currentDgvQuery;
        public Deactivate_User(string fromWhere)
        {
            InitializeComponent();
            roleFilter = fromWhere;
        }

        private void Remove_User_Load(object sender, EventArgs e)
        {
            LoadContent();

        }
        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string ID = dgvUsers.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    string name = dgvUsers.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                    string email = dgvUsers.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                    string phoneNum = dgvUsers.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;
                    byte[] imageByte = (byte[])User_BLL.Get_UserProfilePicture(int.Parse(ID)) ?? null;

                    tbUserId.Text = ID;
                    tbUserName.Text = name;
                    tbUserEmail.Text = email;
                    tbUserPhoneNumber.Text = phoneNum;
                    pbUserProfileImage.Image = ImageUtils.BytesToImage(imageByte) ?? null;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(tbUserId.Text))
                {
                    MessageBox.Show("Selecione um utilizador para desativar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int ID = int.Parse(tbUserId.Text);
                var message = MessageBox.Show("Tem certeza?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var deactivateUser = UserAuth.DeactivateUser(ID);
                    if (deactivateUser.IsValid)
                    {
                        MessageBox.Show("Utilizador desativado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContent();
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
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_Admins_Alphabetical();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_Employees_Alphabetical();
            }
            else if (roleFilter == "Student")
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
            else if (roleFilter == null)
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
                    dgvUsers.DataSource = User_BLL.Employee.Search_EmployeeByName(tbSearch.Text);
                }
                else if (roleFilter == "Student")
                {
                    dgvUsers.DataSource = User_BLL.Student.Search_StudentByName(tbSearch.Text);
                }
                else if (roleFilter == null)
                {
                    dgvUsers.DataSource = User_BLL.Search_UserByName(tbSearch.Text);
                }
            }
        }
        private void LbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procure pelo nome do utilizador", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LoadContent()
        {
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Admin.Show_Admins();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Employee.Show_Employees();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Student.Show_Students();
            }
            else
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Show_AllUsers();
            }
        }
    }
}
