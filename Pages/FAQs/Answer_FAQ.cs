using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Answer_FAQ : Form
    {
        public Answer_FAQ()
        {
            InitializeComponent();
        }

        private void Answer_FAQs_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void DgvFAQs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    tbQuestion.Text = dgvFAQs.Rows[e.RowIndex].Cells[0].Value?.ToString();
                }
                catch(Exception err)
                {
                    MessageBox.Show("Ocorreu um erro: "+err.Message);
                }
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvFAQs.DataSource = FAQs_BLL.GetUnansweredQuestions(tbQuestion.Text);
            }
            else
            {
                dgvFAQs.DataSource = FAQs_BLL.GetUnansweredAnswerByQuestion(tbSearch.Text);
            }
        }

        private void BtnAnswerQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string question = tbQuestion.Text;
                string answer = tbAnswer.Text;
                FAQs_BLL.AnswerQuestion(answer,question);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
            } 
        }

        //Métodos Auxiliares
        private void LoadContent()
        {
            dgvFAQs.Visible = false; 
            dgvFAQs.DataSource = FAQs_BLL.Show_UnansweredFAQs();
            dgvFAQs.Visible = true;
        }
    }
}
