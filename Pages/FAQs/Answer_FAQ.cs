using System.Windows.Forms;
using BusinessLogicLayer;
using System;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Answer_FAQ : Form
    {
        public Answer_FAQ()
        {
            InitializeComponent();
        }
        //Load do Form
        private void Answer_FAQs_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        //Métodos dos componentes graficos
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
                LoadContent();
            }
            else
            {
                dgvFAQs.DataSource = FAQs_BLL.GetUnansweredAnswerByQuestion(tbSearch.Text);
            }
        }
        private void BtnAnswerQuestion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAnswer.Text) && !string.IsNullOrEmpty(tbQuestion.Text))
            {
                try
                {
                    string question = tbQuestion.Text;
                    string answer = tbAnswer.Text;
                    MessageBox.Show("Pergunta Respondida", "Sucesso");
                    FAQs_BLL.AnswerQuestion(answer, question);
                    ResetElements();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ocorreu um erro: " + err.Message);
                }
            }
        }
        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                string question = tbQuestion.Text;
                MessageBox.Show("Pergunta foi invalidada");
                FAQs_BLL.Deativate_FAQ(question);
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadContent();
        }

        //Métodos Auxiliares
        private void LoadContent()
        {
            dgvFAQs.Visible = false; 
            dgvFAQs.DataSource = FAQs_BLL.Show_UnansweredFAQs();
            dgvFAQs.Visible = true;
        }
        private void ResetElements()
        {
            LoadContent();
            tbAnswer.Clear();
            tbQuestion.Clear();
            tbSearch.Clear();
        }

    }
}
