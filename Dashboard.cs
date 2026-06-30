using System.Windows.Forms;
using MealSync_APP.Utils;
using System;


namespace MealSync_APP.Pages.Home
{
    public partial class Dashboard : Form
    {
        private float originalWidth;
        private float originalHeight;

        private float btnEntrarOrigX, btnEntrarOrigY, btnEntrarOrigW, btnEntrarOrigH;
        private float btnCriarOrigX, btnCriarOrigY, btnCriarOrigW, btnCriarOrigH;

        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            originalWidth = this.ClientSize.Width;
            originalHeight = this.ClientSize.Height;

            btnEntrarOrigX = btnEntrar.Left;
            btnEntrarOrigY = btnEntrar.Top;
            btnEntrarOrigW = btnEntrar.Width;
            btnEntrarOrigH = btnEntrar.Height;

            btnCriarOrigX = btnCriar.Left;
            btnCriarOrigY = btnCriar.Top;
            btnCriarOrigW = btnCriar.Width;
            btnCriarOrigH = btnCriar.Height;

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void BtnLogin_Click(object sender, EventArgs e) { LoginForm.Open(this); }
        private void BtnRegister_Click(object sender, EventArgs e) { RegisterForm.Open(this); }
        private void Dashboard_Resize(object sender, EventArgs e)
        {
            float scaleX = this.ClientSize.Width / originalWidth;
            float scaleY = this.ClientSize.Height / originalHeight;

            btnEntrar.Left = (int)(btnEntrarOrigX * scaleX);
            btnEntrar.Top = (int)(btnEntrarOrigY * scaleY);
            btnEntrar.Width = (int)(btnEntrarOrigW * scaleX);
            btnEntrar.Height = (int)(btnEntrarOrigH * scaleY);

            btnCriar.Left = (int)(btnCriarOrigX * scaleX);
            btnCriar.Top = (int)(btnCriarOrigY * scaleY);
            btnCriar.Width = (int)(btnCriarOrigW * scaleX);
            btnCriar.Height = (int)(btnCriarOrigH * scaleY);
        }
    }
}
