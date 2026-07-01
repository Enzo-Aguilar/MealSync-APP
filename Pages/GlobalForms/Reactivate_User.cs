using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System.Data;
using System;

namespace MealSync_APP.Pages.GlobalForms
{
    public partial class Reactivate_User : Form
    {
        private readonly string roleFilter;
        private DataTable currentDgvQuery;
        public Reactivate_User(string fromWhere)
        {
            InitializeComponent();
            roleFilter = fromWhere;
        }
        private void Reactivate_User_Load(object sender, EventArgs e)
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
                    byte[] imageByte = (byte[])User_BLL.Get_UserProfilePicture(int.Parse(ID));

                    tbUserId.Text = ID;
                    tbUserName.Text = name;
                    tbUserEmail.Text = email;
                    tbUserPhoneNumber.Text = phoneNum;
                    pbUserProfileImage.Image = ImageUtils.BytesToImage(imageByte);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnReactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbUserId.Text))
                {
                    MessageBox.Show("Selecione um utilizador para reativar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int ID = int.Parse(tbUserId.Text);
                var message = MessageBox.Show("Tem certeza?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var reactivateUser = UserAuth.ReactivateUser(ID);
                    if (reactivateUser.IsValid)
                    {
                        MessageBox.Show("Utilizador reativado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContent();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(reactivateUser.ErrorMessage, reactivateUser.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_DeactivatedAdmins_Alphabetical();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_DeactivatedEmployees_Alphabetical();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_DeactivatedStudents_Alphabetical();
            }
            else if (roleFilter == null)
            {
                dgvUsers.DataSource = User_BLL.Show_AllDeactivatedUsers_Alphabetical();
            }
        }
        private void BtnIdOrder_Click(object sender, EventArgs e)
        {
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_DeactivatedAdmins_OrderById();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_DeactivatedEmployees_OrderById();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_DeactivatedStudents_OrderById();
            }
            else if (roleFilter == null)
            {
                dgvUsers.DataSource = User_BLL.Show_AllDeactivatedUsers_OrderById();
            }
        }
        private void BtnCreatedAtOrder_Click(object sender, EventArgs e)
        {
            if (roleFilter == "Admin")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Admin.Show_DeactivatedAdmins_OrderByCreationDate();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Employee.Show_DeactivatedEmployees_OrderByCreationDate();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = currentDgvQuery = User_BLL.Student.Show_DeactivatedStudents_OrderByCreationDate();
            }
            else if (roleFilter == null)
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Show_AllDeactivatedUsers_OrderByCreationDate();
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
                    dgvUsers.DataSource = User_BLL.Admin.Search_DeactivatedAdminByName(tbSearch.Text);
                }
                else if (roleFilter == "Employee")
                {
                    dgvUsers.DataSource = User_BLL.Employee.Search_DeactivatedEmployeeByName(tbSearch.Text);
                }
                else if (roleFilter == "Student")
                {
                    dgvUsers.DataSource = User_BLL.Student.Search_DeactivatedStudentByName(tbSearch.Text);
                }
                else if (roleFilter == null)
                {
                    dgvUsers.DataSource = User_BLL.Search_UserByName(tbSearch.Text);
                }
            }
        }
        private void LbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procure pelo nome do utilizador","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Helpers
        private void ClearFields()
        {
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
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Admin.Show_DeactivatedAdmins();
            }
            else if (roleFilter == "Employee")
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Employee.Show_DeactivatedEmployees();
            }
            else if (roleFilter == "Student")
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Student.Show_DeactivatedStudents();
            }
            else
            {
                dgvUsers.DataSource = currentDgvQuery = User_BLL.Show_AllDeactivatedUsers();
            }
        }
    }
}
