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

namespace MealSync_APP.Pages.Home
{
    public partial class Dashboard : Form
    {
        private float originalWidth;
        private float originalHeight;

        private float btnEntrarOrigX, btnEntrarOrigY, btnEntrarOrigW, btnEntrarOrigH;
        private float btnCriarOrigX, btnCriarOrigY, btnCriarOrigW, btnCriarOrigH;

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FormUtils.Open_Register(this);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormUtils.Open_Login();
        }

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
        private void Dash_board_Resize(object sender, EventArgs e)
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
