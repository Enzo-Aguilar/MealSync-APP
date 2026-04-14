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
            this.DontKnowWhatIsThis = new System.Windows.Forms.MenuStrip();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.Bank_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.associate_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.create_BankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.make_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Meals = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Meals = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Meal = new System.Windows.Forms.ToolStripMenuItem();
            this.Students = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Students = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.show_Admins = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.DontKnowWhatIsThis.SuspendLayout();
            this.SuspendLayout();
            // 
            // DontKnowWhatIsThis
            // 
            this.DontKnowWhatIsThis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DontKnowWhatIsThis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.Profile,
            this.Bank_Account,
            this.Orders,
            this.Meals,
            this.Students,
            this.Employees,
            this.Admin});
            this.DontKnowWhatIsThis.Location = new System.Drawing.Point(0, 0);
            this.DontKnowWhatIsThis.Name = "DontKnowWhatIsThis";
            this.DontKnowWhatIsThis.Size = new System.Drawing.Size(797, 24);
            this.DontKnowWhatIsThis.TabIndex = 0;
            this.DontKnowWhatIsThis.Text = "menuStrip1";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(38, 20);
            this.Logout.Text = "Sair";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Profile
            // 
            this.Profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Profile});
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(46, 20);
            this.Profile.Text = "Perfil";
            // 
            // edit_Profile
            // 
            this.edit_Profile.Name = "edit_Profile";
            this.edit_Profile.Size = new System.Drawing.Size(104, 22);
            this.edit_Profile.Text = "Editar";
            this.edit_Profile.Click += new System.EventHandler(this.edit_Profile_Click);
            // 
            // Bank_Account
            // 
            this.Bank_Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associate_BankAccount,
            this.create_BankAccount});
            this.Bank_Account.Name = "Bank_Account";
            this.Bank_Account.Size = new System.Drawing.Size(99, 20);
            this.Bank_Account.Text = "Conta Bancaria";
            // 
            // associate_BankAccount
            // 
            this.associate_BankAccount.Name = "associate_BankAccount";
            this.associate_BankAccount.Size = new System.Drawing.Size(118, 22);
            this.associate_BankAccount.Text = "Associar";
            this.associate_BankAccount.Click += new System.EventHandler(this.associate_BankAccount_Click);
            // 
            // create_BankAccount
            // 
            this.create_BankAccount.Name = "create_BankAccount";
            this.create_BankAccount.Size = new System.Drawing.Size(118, 22);
            this.create_BankAccount.Text = "Criar";
            this.create_BankAccount.Click += new System.EventHandler(this.create_BankAccount_Click);
            // 
            // Orders
            // 
            this.Orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Orders,
            this.make_Orders,
            this.cancel_Order});
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(61, 20);
            this.Orders.Text = "Pedidos";
            // 
            // show_Orders
            // 
            this.show_Orders.Name = "show_Orders";
            this.show_Orders.Size = new System.Drawing.Size(180, 22);
            this.show_Orders.Text = "Ver";
            this.show_Orders.Click += new System.EventHandler(this.show_Orders_Click);
            // 
            // make_Orders
            // 
            this.make_Orders.Name = "make_Orders";
            this.make_Orders.Size = new System.Drawing.Size(180, 22);
            this.make_Orders.Text = "Fazer";
            this.make_Orders.Click += new System.EventHandler(this.make_Orders_Click);
            // 
            // cancel_Order
            // 
            this.cancel_Order.Name = "cancel_Order";
            this.cancel_Order.Size = new System.Drawing.Size(180, 22);
            this.cancel_Order.Text = "Desmarcar";
            this.cancel_Order.Click += new System.EventHandler(this.cancel_Order_Click);
            // 
            // Meals
            // 
            this.Meals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Meals,
            this.edit_Meal,
            this.add_Meal,
            this.remove_Meal});
            this.Meals.Name = "Meals";
            this.Meals.Size = new System.Drawing.Size(69, 20);
            this.Meals.Text = "Refeições";
            // 
            // show_Meals
            // 
            this.show_Meals.Name = "show_Meals";
            this.show_Meals.Size = new System.Drawing.Size(180, 22);
            this.show_Meals.Text = "Ver";
            this.show_Meals.Click += new System.EventHandler(this.show_Meals_Click);
            // 
            // edit_Meal
            // 
            this.edit_Meal.Name = "edit_Meal";
            this.edit_Meal.Size = new System.Drawing.Size(180, 22);
            this.edit_Meal.Text = "Editar";
            this.edit_Meal.Click += new System.EventHandler(this.edit_Meal_Click);
            // 
            // add_Meal
            // 
            this.add_Meal.Name = "add_Meal";
            this.add_Meal.Size = new System.Drawing.Size(180, 22);
            this.add_Meal.Text = "Adicionar";
            this.add_Meal.Click += new System.EventHandler(this.add_Meal_Click);
            // 
            // remove_Meal
            // 
            this.remove_Meal.Name = "remove_Meal";
            this.remove_Meal.Size = new System.Drawing.Size(180, 22);
            this.remove_Meal.Text = "Remover";
            this.remove_Meal.Click += new System.EventHandler(this.remove_Meal_Click);
            // 
            // Students
            // 
            this.Students.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Students,
            this.add_Student,
            this.edit_Student,
            this.remove_Student});
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(56, 20);
            this.Students.Text = "Alunos";
            // 
            // show_Students
            // 
            this.show_Students.Name = "show_Students";
            this.show_Students.Size = new System.Drawing.Size(180, 22);
            this.show_Students.Text = "Ver";
            this.show_Students.Click += new System.EventHandler(this.show_Students_Click);
            // 
            // add_Student
            // 
            this.add_Student.Name = "add_Student";
            this.add_Student.Size = new System.Drawing.Size(180, 22);
            this.add_Student.Text = "Adicionar";
            this.add_Student.Click += new System.EventHandler(this.add_Student_Click);
            // 
            // edit_Student
            // 
            this.edit_Student.Name = "edit_Student";
            this.edit_Student.Size = new System.Drawing.Size(180, 22);
            this.edit_Student.Text = "Editar";
            this.edit_Student.Click += new System.EventHandler(this.edit_Student_Click);
            // 
            // remove_Student
            // 
            this.remove_Student.Name = "remove_Student";
            this.remove_Student.Size = new System.Drawing.Size(180, 22);
            this.remove_Student.Text = "Remover";
            this.remove_Student.Click += new System.EventHandler(this.remove_Student_Click);
            // 
            // Employees
            // 
            this.Employees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Employees,
            this.add_Employee,
            this.edit_Employee,
            this.remove_Employee});
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(87, 20);
            this.Employees.Text = "Funcionarios";
            // 
            // show_Employees
            // 
            this.show_Employees.Name = "show_Employees";
            this.show_Employees.Size = new System.Drawing.Size(180, 22);
            this.show_Employees.Text = "Ver";
            this.show_Employees.Click += new System.EventHandler(this.show_Employees_Click);
            // 
            // add_Employee
            // 
            this.add_Employee.Name = "add_Employee";
            this.add_Employee.Size = new System.Drawing.Size(180, 22);
            this.add_Employee.Text = "Adicionar";
            this.add_Employee.Click += new System.EventHandler(this.add_Employee_Click);
            // 
            // edit_Employee
            // 
            this.edit_Employee.Name = "edit_Employee";
            this.edit_Employee.Size = new System.Drawing.Size(180, 22);
            this.edit_Employee.Text = "Editar";
            this.edit_Employee.Click += new System.EventHandler(this.edit_Employee_Click);
            // 
            // remove_Employee
            // 
            this.remove_Employee.Name = "remove_Employee";
            this.remove_Employee.Size = new System.Drawing.Size(180, 22);
            this.remove_Employee.Text = "Remover";
            this.remove_Employee.Click += new System.EventHandler(this.remove_Employee_Click);
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Admins,
            this.add_Admin,
            this.edit_Admin,
            this.remove_Admin});
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(106, 20);
            this.Admin.Text = "Administradores";
            // 
            // show_Admins
            // 
            this.show_Admins.Name = "show_Admins";
            this.show_Admins.Size = new System.Drawing.Size(180, 22);
            this.show_Admins.Text = "Ver";
            this.show_Admins.Click += new System.EventHandler(this.show_Admins_Click);
            // 
            // add_Admin
            // 
            this.add_Admin.Name = "add_Admin";
            this.add_Admin.Size = new System.Drawing.Size(180, 22);
            this.add_Admin.Text = "Adicionar";
            this.add_Admin.Click += new System.EventHandler(this.add_Admin_Click);
            // 
            // edit_Admin
            // 
            this.edit_Admin.Name = "edit_Admin";
            this.edit_Admin.Size = new System.Drawing.Size(180, 22);
            this.edit_Admin.Text = "Editar";
            this.edit_Admin.Click += new System.EventHandler(this.edit_Admin_Click);
            // 
            // remove_Admin
            // 
            this.remove_Admin.Name = "remove_Admin";
            this.remove_Admin.Size = new System.Drawing.Size(180, 22);
            this.remove_Admin.Text = "Remover";
            this.remove_Admin.Click += new System.EventHandler(this.remove_Admin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 444);
            this.Controls.Add(this.DontKnowWhatIsThis);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.DontKnowWhatIsThis;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.DontKnowWhatIsThis.ResumeLayout(false);
            this.DontKnowWhatIsThis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip DontKnowWhatIsThis;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem Profile;
        private System.Windows.Forms.ToolStripMenuItem Bank_Account;
        private System.Windows.Forms.ToolStripMenuItem Orders;
        private System.Windows.Forms.ToolStripMenuItem Meals;
        private System.Windows.Forms.ToolStripMenuItem edit_Profile;
        private System.Windows.Forms.ToolStripMenuItem create_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem associate_BankAccount;
        private System.Windows.Forms.ToolStripMenuItem show_Orders;
        private System.Windows.Forms.ToolStripMenuItem make_Orders;
        private System.Windows.Forms.ToolStripMenuItem cancel_Order;
        private System.Windows.Forms.ToolStripMenuItem show_Meals;
        private System.Windows.Forms.ToolStripMenuItem edit_Meal;
        private System.Windows.Forms.ToolStripMenuItem add_Meal;
        private System.Windows.Forms.ToolStripMenuItem remove_Meal;
        private System.Windows.Forms.ToolStripMenuItem Students;
        private System.Windows.Forms.ToolStripMenuItem show_Students;
        private System.Windows.Forms.ToolStripMenuItem add_Student;
        private System.Windows.Forms.ToolStripMenuItem edit_Student;
        private System.Windows.Forms.ToolStripMenuItem remove_Student;
        private System.Windows.Forms.ToolStripMenuItem Employees;
        private System.Windows.Forms.ToolStripMenuItem show_Employees;
        private System.Windows.Forms.ToolStripMenuItem add_Employee;
        private System.Windows.Forms.ToolStripMenuItem edit_Employee;
        private System.Windows.Forms.ToolStripMenuItem remove_Employee;
        private System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem show_Admins;
        private System.Windows.Forms.ToolStripMenuItem add_Admin;
        private System.Windows.Forms.ToolStripMenuItem edit_Admin;
        private System.Windows.Forms.ToolStripMenuItem remove_Admin;
    }
}