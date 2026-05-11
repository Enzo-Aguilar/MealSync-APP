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

namespace MealSync_APP.Pages.FAQs
{
    public partial class Show_FAQs : Form
    {
        public Show_FAQs()
        {
            InitializeComponent();
        }
        private void Show_FAQs_Load(object sender, EventArgs e)
        {
            dgvQuestions.DataSource = FAQs_BLL.Show_FAQs();
        }

        private void DgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    string question = dgvQuestions.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    DataTable dt = FAQs_BLL.FAQ_Answer(question);
                    string answer = dt.Rows[0][0].ToString();
                    tbAnswers.Text = answer;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ocorreu um erro selecionando a tabela: " + err.Message, "Error");
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvQuestions.Visible = false;
            dgvQuestions.DataSource = FAQs_BLL.Show_FAQs();
            dgvQuestions.Visible = true;
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvQuestions.DataSource = FAQs_BLL.Show_FAQs();
            }
            else
            {
                dgvQuestions.DataSource = FAQs_BLL.Search_Question(tbSearch.Text);
            }
            
        }
    }
}
