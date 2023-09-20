namespace crud_operations
{
    partial class Employee
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
            EmployeeRegister = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmpid = new TextBox();
            txtEmpcode = new TextBox();
            txtDate = new TextBox();
            txtDep = new TextBox();
            txtPosition = new TextBox();
            txtSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeRegister).BeginInit();
            SuspendLayout();
            // 
            // EmployeeRegister
            // 
            EmployeeRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeRegister.Location = new Point(2, 0);
            EmployeeRegister.Name = "EmployeeRegister";
            EmployeeRegister.RowHeadersWidth = 51;
            EmployeeRegister.RowTemplate.Height = 29;
            EmployeeRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeRegister.Size = new Size(661, 725);
            EmployeeRegister.TabIndex = 0;
            EmployeeRegister.CellContentClick += EmployeeRegister_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(676, 597);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 1;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(824, 597);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(970, 597);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1112, 597);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 4;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(676, 100);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 5;
            label1.Text = "Employee Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(676, 238);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 6;
            label2.Text = "Employee Code :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(679, 308);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 7;
            label3.Text = "Hire Date :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(676, 385);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 8;
            label4.Text = "Department :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(679, 456);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 9;
            label5.Text = "Position :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(679, 170);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 10;
            label6.Text = "Salary :";
            // 
            // txtEmpid
            // 
            txtEmpid.Location = new Point(856, 100);
            txtEmpid.Name = "txtEmpid";
            txtEmpid.Size = new Size(249, 27);
            txtEmpid.TabIndex = 11;
            // 
            // txtEmpcode
            // 
            txtEmpcode.Location = new Point(856, 238);
            txtEmpcode.Name = "txtEmpcode";
            txtEmpcode.Size = new Size(249, 27);
            txtEmpcode.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(856, 312);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(249, 27);
            txtDate.TabIndex = 13;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(856, 389);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(249, 27);
            txtDep.TabIndex = 14;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(856, 460);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(249, 27);
            txtPosition.TabIndex = 15;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(856, 170);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(249, 27);
            txtSalary.TabIndex = 16;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1242, 727);
            Controls.Add(txtSalary);
            Controls.Add(txtPosition);
            Controls.Add(txtDep);
            Controls.Add(txtDate);
            Controls.Add(txtEmpcode);
            Controls.Add(txtEmpid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EmployeeRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee information";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EmployeeRegister;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmpid;
        private TextBox txtEmpcode;
        private TextBox txtDate;
        private TextBox txtDep;
        private TextBox txtPosition;
        private TextBox txtSalary;
    }
}