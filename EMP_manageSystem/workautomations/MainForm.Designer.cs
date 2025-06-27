namespace workautomations
{
    partial class MainForm
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            logoutbutton = new Button();
            salarybutton = new Button();
            addEmployee = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(963, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 53);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(343, 9);
            label2.Name = "label2";
            label2.Size = new Size(424, 32);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(logoutbutton);
            panel2.Controls.Add(salarybutton);
            panel2.Controls.Add(addEmployee);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 611);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint_1;
            // 
            // logoutbutton
            // 
            logoutbutton.BackColor = Color.SteelBlue;
            logoutbutton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutbutton.ForeColor = Color.White;
            logoutbutton.Location = new Point(40, 409);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(174, 50);
            logoutbutton.TabIndex = 5;
            logoutbutton.Text = "Logout";
            logoutbutton.UseVisualStyleBackColor = false;
            logoutbutton.Click += logoutbutton_Click;
            // 
            // salarybutton
            // 
            salarybutton.BackColor = Color.SteelBlue;
            salarybutton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salarybutton.ForeColor = Color.White;
            salarybutton.Location = new Point(40, 327);
            salarybutton.Name = "salarybutton";
            salarybutton.Size = new Size(174, 50);
            salarybutton.TabIndex = 4;
            salarybutton.Text = "Salary";
            salarybutton.UseVisualStyleBackColor = false;
            salarybutton.Click += salarybutton_Click;
            // 
            // addEmployee
            // 
            addEmployee.BackColor = Color.SteelBlue;
            addEmployee.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployee.ForeColor = Color.White;
            addEmployee.Location = new Point(40, 247);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(174, 50);
            addEmployee.TabIndex = 3;
            addEmployee.Text = "Employees";
            addEmployee.UseVisualStyleBackColor = false;
            addEmployee.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._2245150;
            pictureBox1.Location = new Point(40, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button addEmployee;
        private Button salarybutton;
        private Button logoutbutton;
    }
}