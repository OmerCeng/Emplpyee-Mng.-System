namespace workautomations
{
    partial class AddEmployee
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            emp_perf = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            addEmployee_status = new ComboBox();
            label7 = new Label();
            addEmployee_position = new ComboBox();
            label6 = new Label();
            addEmployee_clearBtn = new Button();
            addEmployee_deleteBtn = new Button();
            updateEmployee_updateBtn = new Button();
            addEmployee_addBtn = new Button();
            addEmployee_phoneNum = new TextBox();
            label5 = new Label();
            addEmployee_gender = new ComboBox();
            label4 = new Label();
            addEmployee_fullName = new TextBox();
            label3 = new Label();
            addEmployee_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 262);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(13, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(931, 191);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(211, 33);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(emp_perf);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(addEmployee_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addEmployee_position);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_clearBtn);
            panel2.Controls.Add(addEmployee_deleteBtn);
            panel2.Controls.Add(updateEmployee_updateBtn);
            panel2.Controls.Add(addEmployee_addBtn);
            panel2.Controls.Add(addEmployee_phoneNum);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_fullName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 262);
            panel2.TabIndex = 1;
            // 
            // emp_perf
            // 
            emp_perf.FormattingEnabled = true;
            emp_perf.Items.AddRange(new object[] { "Perfect", "Well ", "Avarage", "Should be Improved", "Bad Performance" });
            emp_perf.Location = new Point(784, 76);
            emp_perf.Name = "emp_perf";
            emp_perf.Size = new Size(158, 23);
            emp_perf.TabIndex = 19;
            emp_perf.SelectedIndexChanged += emp_perf_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(635, 76);
            label8.Name = "label8";
            label8.Size = new Size(143, 16);
            label8.TabIndex = 18;
            label8.Text = "Employee Performance ";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Tahoma", 9.75F);
            button1.Location = new Point(408, 205);
            button1.Name = "button1";
            button1.Size = new Size(78, 34);
            button1.TabIndex = 17;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addEmployee_status
            // 
            addEmployee_status.FormattingEnabled = true;
            addEmployee_status.Items.AddRange(new object[] { "On leave", "Working" });
            addEmployee_status.Location = new Point(438, 118);
            addEmployee_status.Name = "addEmployee_status";
            addEmployee_status.Size = new Size(158, 23);
            addEmployee_status.TabIndex = 16;
            addEmployee_status.SelectedIndexChanged += addEmployee_status_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(375, 120);
            label7.Name = "label7";
            label7.Size = new Size(43, 16);
            label7.TabIndex = 15;
            label7.Text = "Status";
            // 
            // addEmployee_position
            // 
            addEmployee_position.FormattingEnabled = true;
            addEmployee_position.Items.AddRange(new object[] { "Manager", "Back-end Developer", "Front-end Developer", "Ui/Ux Developer", "CyberSecurity" });
            addEmployee_position.Location = new Point(438, 74);
            addEmployee_position.Name = "addEmployee_position";
            addEmployee_position.Size = new Size(158, 23);
            addEmployee_position.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(375, 76);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 13;
            label6.Text = "Position";
            // 
            // addEmployee_clearBtn
            // 
            addEmployee_clearBtn.BackColor = Color.SteelBlue;
            addEmployee_clearBtn.Font = new Font("Tahoma", 9.75F);
            addEmployee_clearBtn.Location = new Point(736, 191);
            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            addEmployee_clearBtn.Size = new Size(127, 48);
            addEmployee_clearBtn.TabIndex = 12;
            addEmployee_clearBtn.Text = "Clear";
            addEmployee_clearBtn.UseVisualStyleBackColor = false;
            addEmployee_clearBtn.Click += addEmployee_clearBtn_Click;
            // 
            // addEmployee_deleteBtn
            // 
            addEmployee_deleteBtn.BackColor = Color.SteelBlue;
            addEmployee_deleteBtn.Font = new Font("Tahoma", 9.75F);
            addEmployee_deleteBtn.Location = new Point(562, 191);
            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            addEmployee_deleteBtn.Size = new Size(127, 48);
            addEmployee_deleteBtn.TabIndex = 11;
            addEmployee_deleteBtn.Text = "Delete";
            addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            addEmployee_deleteBtn.Click += addEmployee_deleteBtn_Click;
            // 
            // updateEmployee_updateBtn
            // 
            updateEmployee_updateBtn.BackColor = Color.SteelBlue;
            updateEmployee_updateBtn.Font = new Font("Tahoma", 9.75F);
            updateEmployee_updateBtn.Location = new Point(198, 191);
            updateEmployee_updateBtn.Name = "updateEmployee_updateBtn";
            updateEmployee_updateBtn.Size = new Size(127, 48);
            updateEmployee_updateBtn.TabIndex = 10;
            updateEmployee_updateBtn.Text = "Update";
            updateEmployee_updateBtn.UseVisualStyleBackColor = false;
            updateEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
            // 
            // addEmployee_addBtn
            // 
            addEmployee_addBtn.BackColor = Color.SteelBlue;
            addEmployee_addBtn.Font = new Font("Tahoma", 9.75F);
            addEmployee_addBtn.Location = new Point(24, 191);
            addEmployee_addBtn.Name = "addEmployee_addBtn";
            addEmployee_addBtn.Size = new Size(127, 48);
            addEmployee_addBtn.TabIndex = 9;
            addEmployee_addBtn.Text = "Add";
            addEmployee_addBtn.UseVisualStyleBackColor = false;
            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
            // 
            // addEmployee_phoneNum
            // 
            addEmployee_phoneNum.Location = new Point(438, 29);
            addEmployee_phoneNum.Name = "addEmployee_phoneNum";
            addEmployee_phoneNum.Size = new Size(158, 23);
            addEmployee_phoneNum.TabIndex = 8;
            addEmployee_phoneNum.TextChanged += addEmployee_phoneNum_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(341, 31);
            label5.Name = "label5";
            label5.Size = new Size(91, 16);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male ", "Female" });
            addEmployee_gender.Location = new Point(103, 116);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(158, 23);
            addEmployee_gender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(40, 118);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // addEmployee_fullName
            // 
            addEmployee_fullName.Location = new Point(103, 72);
            addEmployee_fullName.Name = "addEmployee_fullName";
            addEmployee_fullName.Size = new Size(158, 23);
            addEmployee_fullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 74);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // addEmployee_id
            // 
            addEmployee_id.Location = new Point(103, 27);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(158, 23);
            addEmployee_id.TabIndex = 1;
            addEmployee_id.TextChanged += addEmployee_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(10, 29);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            Load += AddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox addEmployee_fullName;
        private Label label3;
        private TextBox addEmployee_id;
        private Label label2;
        private TextBox addEmployee_phoneNum;
        private Label label5;
        private ComboBox addEmployee_gender;
        private Button addEmployee_clearBtn;
        private Button addEmployee_deleteBtn;
        private Button updateEmployee_updateBtn;
        private Button addEmployee_addBtn;
        private ComboBox addEmployee_position;
        private Label label6;
        private ComboBox addEmployee_status;
        private Label label7;
        private Button button1;
        private ComboBox emp_perf;
        private Label label8;
    }
}