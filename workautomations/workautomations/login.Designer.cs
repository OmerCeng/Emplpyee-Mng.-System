namespace workautomations
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            xbutton = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label3 = new Label();
            login_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 447);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(265, 20);
            label5.TabIndex = 11;
            label5.Text = "Employee Management System";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(85, 397);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 9;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(45, 367);
            label4.Name = "label4";
            label4.Size = new Size(186, 15);
            label4.TabIndex = 8;
            label4.Text = "Don't you have an account ?";
            label4.Click += label4_Click;
            // 
            // xbutton
            // 
            xbutton.AutoSize = true;
            xbutton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xbutton.Location = new Point(730, 9);
            xbutton.Name = "xbutton";
            xbutton.Size = new Size(17, 18);
            xbutton.TabIndex = 1;
            xbutton.Text = "X";
            xbutton.Click += xbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 82);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 2;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(284, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // login_username
            // 
            login_username.Location = new Point(284, 167);
            login_username.Name = "login_username";
            login_username.Size = new Size(202, 23);
            login_username.TabIndex = 4;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(284, 225);
            login_password.Name = "login_password";
            login_password.Size = new Size(202, 23);
            login_password.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(284, 202);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // login_button
            // 
            login_button.BackColor = Color.MidnightBlue;
            login_button.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.ButtonFace;
            login_button.Location = new Point(284, 267);
            login_button.Name = "login_button";
            login_button.Size = new Size(80, 38);
            login_button.TabIndex = 7;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(759, 447);
            Controls.Add(login_button);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(xbutton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label xbutton;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private TextBox login_password;
        private Label label3;
        private Button login_button;
        private Label label4;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
