namespace workautomations
{
    partial class Salary
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
            returnbtn = new Button();
            salary_clearBtn = new Button();
            salary_updateBtn = new Button();
            salary_position = new TextBox();
            salary_salary = new TextBox();
            label4 = new Label();
            label5 = new Label();
            salary_name = new TextBox();
            label3 = new Label();
            salary_employeeID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(returnbtn);
            panel1.Controls.Add(salary_clearBtn);
            panel1.Controls.Add(salary_updateBtn);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 498);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // returnbtn
            // 
            returnbtn.BackColor = Color.SteelBlue;
            returnbtn.ForeColor = SystemColors.ActiveCaptionText;
            returnbtn.Location = new Point(68, 398);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(81, 39);
            returnbtn.TabIndex = 12;
            returnbtn.Text = "Return Main";
            returnbtn.UseVisualStyleBackColor = false;
            returnbtn.Click += returnbtn_Click;
            // 
            // salary_clearBtn
            // 
            salary_clearBtn.BackColor = Color.SteelBlue;
            salary_clearBtn.ForeColor = SystemColors.ActiveCaptionText;
            salary_clearBtn.Location = new Point(124, 340);
            salary_clearBtn.Name = "salary_clearBtn";
            salary_clearBtn.Size = new Size(81, 39);
            salary_clearBtn.TabIndex = 11;
            salary_clearBtn.Text = "Clear";
            salary_clearBtn.UseVisualStyleBackColor = false;
            salary_clearBtn.Click += salary_clearBtn_Click;
            // 
            // salary_updateBtn
            // 
            salary_updateBtn.BackColor = Color.SteelBlue;
            salary_updateBtn.ForeColor = SystemColors.ActiveCaptionText;
            salary_updateBtn.Location = new Point(13, 340);
            salary_updateBtn.Name = "salary_updateBtn";
            salary_updateBtn.Size = new Size(81, 39);
            salary_updateBtn.TabIndex = 9;
            salary_updateBtn.Text = "Update";
            salary_updateBtn.UseVisualStyleBackColor = false;
            salary_updateBtn.Click += salary_updateBtn_Click;
            // 
            // salary_position
            // 
            salary_position.Location = new Point(13, 217);
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(203, 23);
            salary_position.TabIndex = 5;
            // 
            // salary_salary
            // 
            salary_salary.Location = new Point(13, 292);
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(203, 23);
            salary_salary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 199);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 4;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 274);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "Salary";
            // 
            // salary_name
            // 
            salary_name.Location = new Point(13, 136);
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(203, 23);
            salary_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 118);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // salary_employeeID
            // 
            salary_employeeID.Location = new Point(13, 73);
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(203, 23);
            salary_employeeID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(254, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 498);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 416);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(142, 33);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox salary_employeeID;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox salary_name;
        private Label label3;
        private TextBox salary_position;
        private TextBox salary_salary;
        private Label label4;
        private Label label5;
        private Button salary_clearBtn;
        private Button salary_updateBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button returnbtn;
    }
}