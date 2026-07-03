namespace MealSync_APP
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Bank_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.associate_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.create_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.transactions_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivate_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivate_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.ver_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.make_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Meals = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.Students = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Students = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivate_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivate_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.Admins = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Admins = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivate_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.profile = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQs = new System.Windows.Forms.ToolStripMenuItem();
            this.show_FAQs = new System.Windows.Forms.ToolStripMenuItem();
            this.make_FAQs = new System.Windows.Forms.ToolStripMenuItem();
            this.answer_FAQs = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivate_FAQs = new System.Windows.Forms.ToolStripMenuItem();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(57, 20);
            this.Logout.Text = "Sair ➜]";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Bank_Account
            // 
            this.Bank_Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associate_BankAccount,
            this.create_BankAccount,
            this.transactions_BankAccount,
            this.deactivate_BankAccount,
            this.reactivate_BankAccount,
            this.adicionarToolStripMenuItem});
            this.Bank_Account.Name = "Bank_Account";
            this.Bank_Account.Size = new System.Drawing.Size(99, 20);
            this.Bank_Account.Text = "Conta Bancaria";
            // 
            // associate_BankAccount
            // 
            this.associate_BankAccount.Name = "associate_BankAccount";
            this.associate_BankAccount.Size = new System.Drawing.Size(182, 22);
            this.associate_BankAccount.Text = "🔗‍ Associar";
            this.associate_BankAccount.Click += new System.EventHandler(this.Associate_BankAccount_Click);
            // 
            // create_BankAccount
            // 
            this.create_BankAccount.Name = "create_BankAccount";
            this.create_BankAccount.Size = new System.Drawing.Size(182, 22);
            this.create_BankAccount.Text = "➕ Criar";
            this.create_BankAccount.Click += new System.EventHandler(this.Create_BankAccount_Click);
            // 
            // transactions_BankAccount
            // 
            this.transactions_BankAccount.Name = "transactions_BankAccount";
            this.transactions_BankAccount.Size = new System.Drawing.Size(182, 22);
            this.transactions_BankAccount.Text = "⌯⌲Transações";
            this.transactions_BankAccount.Click += new System.EventHandler(this.Transactions_BankAccount_Click);
            // 
            // deactivate_BankAccount
            // 
            this.deactivate_BankAccount.Name = "deactivate_BankAccount";
            this.deactivate_BankAccount.Size = new System.Drawing.Size(182, 22);
            this.deactivate_BankAccount.Text = "🔒 Desativar";
            this.deactivate_BankAccount.Click += new System.EventHandler(this.Deactivate_BankAccount_Click);
            // 
            // reactivate_BankAccount
            // 
            this.reactivate_BankAccount.Name = "reactivate_BankAccount";
            this.reactivate_BankAccount.Size = new System.Drawing.Size(182, 22);
            this.reactivate_BankAccount.Text = "🔓 Reativar";
            this.reactivate_BankAccount.Click += new System.EventHandler(this.Reactivate_BankAccount_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.adicionarToolStripMenuItem.Text = " € Introduzir Quantia";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.AddMoneyToBk_Click);
            // 
            // Orders
            // 
            this.Orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ver_Order,
            this.make_Order,
            this.cancel_Order});
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(61, 20);
            this.Orders.Text = "Pedidos";
            // 
            // ver_Order
            // 
            this.ver_Order.Name = "ver_Order";
            this.ver_Order.Size = new System.Drawing.Size(180, 22);
            this.ver_Order.Text = "👀Ver";
            this.ver_Order.Click += new System.EventHandler(this.Show_Orders_Click);
            // 
            // make_Order
            // 
            this.make_Order.Name = "make_Order";
            this.make_Order.Size = new System.Drawing.Size(180, 22);
            this.make_Order.Text = "📝 Marcar";
            this.make_Order.Click += new System.EventHandler(this.Make_Orders_Click);
            // 
            // cancel_Order
            // 
            this.cancel_Order.Name = "cancel_Order";
            this.cancel_Order.Size = new System.Drawing.Size(180, 22);
            this.cancel_Order.Text = "🗑️ Desmarcar";
            this.cancel_Order.Click += new System.EventHandler(this.Cancel_Order_Click);
            // 
            // Meals
            // 
            this.Meals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Meal,
            this.add_Meal,
            this.remove_Meal});
            this.Meals.Name = "Meals";
            this.Meals.Size = new System.Drawing.Size(69, 20);
            this.Meals.Text = "Refeições";
            // 
            // edit_Meal
            // 
            this.edit_Meal.Name = "edit_Meal";
            this.edit_Meal.Size = new System.Drawing.Size(180, 22);
            this.edit_Meal.Text = "✍ Editar";
            this.edit_Meal.Click += new System.EventHandler(this.Edit_Meal_Click);
            // 
            // add_Meal
            // 
            this.add_Meal.Name = "add_Meal";
            this.add_Meal.Size = new System.Drawing.Size(180, 22);
            this.add_Meal.Text = "➕ Adicionar";
            this.add_Meal.Click += new System.EventHandler(this.Add_Meal_Click);
            // 
            // remove_Meal
            // 
            this.remove_Meal.Name = "remove_Meal";
            this.remove_Meal.Size = new System.Drawing.Size(180, 22);
            this.remove_Meal.Text = "🗑️ Remover";
            this.remove_Meal.Click += new System.EventHandler(this.Remove_Meal_Click);
            // 
            // Students
            // 
            this.Students.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Students,
            this.add_Student,
            this.reactivate_Student,
            this.remove_Student});
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(56, 20);
            this.Students.Text = "Alunos";
            // 
            // show_Students
            // 
            this.show_Students.Name = "show_Students";
            this.show_Students.Size = new System.Drawing.Size(180, 22);
            this.show_Students.Text = "👀 Ver";
            this.show_Students.Click += new System.EventHandler(this.Show_Students_Click);
            // 
            // add_Student
            // 
            this.add_Student.Name = "add_Student";
            this.add_Student.Size = new System.Drawing.Size(180, 22);
            this.add_Student.Text = "➕ Adicionar";
            this.add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // reactivate_Student
            // 
            this.reactivate_Student.Name = "reactivate_Student";
            this.reactivate_Student.Size = new System.Drawing.Size(180, 22);
            this.reactivate_Student.Text = "🔓Reativar";
            this.reactivate_Student.Click += new System.EventHandler(this.Reactivate_Student_Click);
            // 
            // remove_Student
            // 
            this.remove_Student.Name = "remove_Student";
            this.remove_Student.Size = new System.Drawing.Size(180, 22);
            this.remove_Student.Text = "🗑️ Remover";
            this.remove_Student.Click += new System.EventHandler(this.Remove_Student_Click);
            // 
            // Employees
            // 
            this.Employees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Employees,
            this.add_Employee,
            this.reactivate_Employee,
            this.remove_Employee});
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(87, 20);
            this.Employees.Text = "Funcionarios";
            // 
            // show_Employees
            // 
            this.show_Employees.Name = "show_Employees";
            this.show_Employees.Size = new System.Drawing.Size(180, 22);
            this.show_Employees.Text = "👀 Ver";
            this.show_Employees.Click += new System.EventHandler(this.Show_Employees_Click);
            // 
            // add_Employee
            // 
            this.add_Employee.Name = "add_Employee";
            this.add_Employee.Size = new System.Drawing.Size(180, 22);
            this.add_Employee.Text = "➕ Adicionar";
            this.add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // reactivate_Employee
            // 
            this.reactivate_Employee.Name = "reactivate_Employee";
            this.reactivate_Employee.Size = new System.Drawing.Size(180, 22);
            this.reactivate_Employee.Text = "🔓reativar";
            this.reactivate_Employee.Click += new System.EventHandler(this.Reactivate_Employee_Click);
            // 
            // remove_Employee
            // 
            this.remove_Employee.Name = "remove_Employee";
            this.remove_Employee.Size = new System.Drawing.Size(180, 22);
            this.remove_Employee.Text = "🗑️ Remover";
            this.remove_Employee.Click += new System.EventHandler(this.Remove_Employee_Click);
            // 
            // Admins
            // 
            this.Admins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Admins,
            this.add_Admin,
            this.reactivate_Admin,
            this.remove_Admin});
            this.Admins.Name = "Admins";
            this.Admins.Size = new System.Drawing.Size(106, 20);
            this.Admins.Text = "Administradores";
            // 
            // show_Admins
            // 
            this.show_Admins.Name = "show_Admins";
            this.show_Admins.Size = new System.Drawing.Size(180, 22);
            this.show_Admins.Text = "👀 Ver";
            this.show_Admins.Click += new System.EventHandler(this.Show_Admins_Click);
            // 
            // add_Admin
            // 
            this.add_Admin.Name = "add_Admin";
            this.add_Admin.Size = new System.Drawing.Size(180, 22);
            this.add_Admin.Text = "➕ Adicionar";
            this.add_Admin.Click += new System.EventHandler(this.Add_Admin_Click);
            // 
            // reactivate_Admin
            // 
            this.reactivate_Admin.Name = "reactivate_Admin";
            this.reactivate_Admin.Size = new System.Drawing.Size(180, 22);
            this.reactivate_Admin.Text = "🔓reativar";
            this.reactivate_Admin.Click += new System.EventHandler(this.Reactivate_Admin_Click);
            // 
            // remove_Admin
            // 
            this.remove_Admin.Name = "remove_Admin";
            this.remove_Admin.Size = new System.Drawing.Size(180, 22);
            this.remove_Admin.Text = "🗑️ Remover";
            this.remove_Admin.Click += new System.EventHandler(this.Remove_Admin_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.profile,
            this.Bank_Account,
            this.Orders,
            this.Meals,
            this.Students,
            this.Employees,
            this.Admins,
            this.FAQs});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1167, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // profile
            // 
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Profile});
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(46, 20);
            this.profile.Text = "Perfil";
            // 
            // edit_Profile
            // 
            this.edit_Profile.Name = "edit_Profile";
            this.edit_Profile.Size = new System.Drawing.Size(180, 22);
            this.edit_Profile.Text = "✍ Editar ";
            this.edit_Profile.Click += new System.EventHandler(this.Edit_Profile_Click);
            // 
            // FAQs
            // 
            this.FAQs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_FAQs,
            this.make_FAQs,
            this.answer_FAQs,
            this.reactivate_FAQs});
            this.FAQs.Name = "FAQs";
            this.FAQs.Size = new System.Drawing.Size(46, 20);
            this.FAQs.Text = "FAQs";
            // 
            // show_FAQs
            // 
            this.show_FAQs.Name = "show_FAQs";
            this.show_FAQs.Size = new System.Drawing.Size(193, 22);
            this.show_FAQs.Text = "👀 Ver";
            this.show_FAQs.Click += new System.EventHandler(this.Show_FAQs_Click);
            // 
            // make_FAQs
            // 
            this.make_FAQs.Name = "make_FAQs";
            this.make_FAQs.Size = new System.Drawing.Size(193, 22);
            this.make_FAQs.Text = "❔Fazer Pergunta";
            this.make_FAQs.Click += new System.EventHandler(this.Make_FAQs_Click);
            // 
            // answer_FAQs
            // 
            this.answer_FAQs.Name = "answer_FAQs";
            this.answer_FAQs.Size = new System.Drawing.Size(193, 22);
            this.answer_FAQs.Text = "📝Responder Pergunta";
            this.answer_FAQs.Click += new System.EventHandler(this.Answer_FAQs_Click);
            // 
            // reactivate_FAQs
            // 
            this.reactivate_FAQs.Name = "reactivate_FAQs";
            this.reactivate_FAQs.Size = new System.Drawing.Size(193, 22);
            this.reactivate_FAQs.Text = "🔓Reativar";
            this.reactivate_FAQs.Click += new System.EventHandler(this.Reactivate_FAQs_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(1031, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(38, 13);
            this.clock.TabIndex = 2;
            this.clock.Text = "relogio";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 645);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem Bank_Account;
        private System.Windows.Forms.ToolStripMenuItem associate_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem create_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem Orders;
        private System.Windows.Forms.ToolStripMenuItem make_Order;
        private System.Windows.Forms.ToolStripMenuItem cancel_Order;
        private System.Windows.Forms.ToolStripMenuItem Meals;
        private System.Windows.Forms.ToolStripMenuItem edit_Meal;
        private System.Windows.Forms.ToolStripMenuItem add_Meal;
        private System.Windows.Forms.ToolStripMenuItem remove_Meal;
        private System.Windows.Forms.ToolStripMenuItem Students;
        private System.Windows.Forms.ToolStripMenuItem show_Students;
        private System.Windows.Forms.ToolStripMenuItem add_Student;
        private System.Windows.Forms.ToolStripMenuItem remove_Student;
        private System.Windows.Forms.ToolStripMenuItem Employees;
        private System.Windows.Forms.ToolStripMenuItem show_Employees;
        private System.Windows.Forms.ToolStripMenuItem add_Employee;
        private System.Windows.Forms.ToolStripMenuItem remove_Employee;
        private System.Windows.Forms.ToolStripMenuItem Admins;
        private System.Windows.Forms.ToolStripMenuItem show_Admins;
        private System.Windows.Forms.ToolStripMenuItem add_Admin;
        private System.Windows.Forms.ToolStripMenuItem remove_Admin;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deactivate_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem reactivate_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem profile;
        private System.Windows.Forms.ToolStripMenuItem edit_Profile;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.ToolStripMenuItem FAQs;
        private System.Windows.Forms.ToolStripMenuItem show_FAQs;
        private System.Windows.Forms.ToolStripMenuItem make_FAQs;
        private System.Windows.Forms.ToolStripMenuItem answer_FAQs;
        private System.Windows.Forms.ToolStripMenuItem reactivate_FAQs;
        private System.Windows.Forms.ToolStripMenuItem transactions_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem ver_Order;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reactivate_Student;
        private System.Windows.Forms.ToolStripMenuItem reactivate_Employee;
        private System.Windows.Forms.ToolStripMenuItem reactivate_Admin;
    }
}