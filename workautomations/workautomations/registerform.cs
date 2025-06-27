using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace workautomations
{
    public partial class registerform : Form
    {
        SqlConnection connect = new SqlConnection(@"your string");
        public registerform()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(registerform));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            signup_password = new TextBox();
            label3 = new Label();
            signup_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            xbutton = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 431);
            panel1.TabIndex = 8;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaGreen;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(85, 357);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 9;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(284, 267);
            button1.Name = "button1";
            button1.Size = new Size(80, 38);
            button1.TabIndex = 15;
            button1.Text = "Signup";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(284, 225);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(202, 23);
            signup_password.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(284, 202);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // signup_username
            // 
            signup_username.Location = new Point(284, 167);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(202, 23);
            signup_username.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(284, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 82);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 10;
            label1.Text = "Register Account";
            // 
            // xbutton
            // 
            xbutton.AutoSize = true;
            xbutton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xbutton.Location = new Point(720, 9);
            xbutton.Name = "xbutton";
            xbutton.Size = new Size(17, 18);
            xbutton.TabIndex = 9;
            xbutton.Text = "X";
            xbutton.Click += xbutton_Click;
            // 
            // registerform
            // 
            ClientSize = new Size(743, 431);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(signup_password);
            Controls.Add(label3);
            Controls.Add(signup_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(xbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerform";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private TextBox signup_password;
        private Label label3;
        private TextBox signup_username;
        private Label label2;
        private Label label1;
        private Label xbutton;

        private void xbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (signup_username.Text == "" || signup_password.Text == "")
                {
                    MessageBox.Show("Username or password cannot be empty!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                            {
                                checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                                int count = (int)checkUser.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show(signup_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    DateTime today = DateTime.Today;
                                    string insertData = "INSERT INTO users (username, password, date_register) VALUES (@username, @password, @dateReg)";

                                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                        cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                        cmd.Parameters.AddWithValue("@dateReg", today);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Form yönlendirme
                                        login loginform = new login();
                                        loginform.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }
    }
}
