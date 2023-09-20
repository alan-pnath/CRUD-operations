using System;
using System.Data;
using System.Data.SqlClient;

namespace crud_operations
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NOIT5V9\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True");

        public int Empid;

        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmployeeDetails();
        }

        private void GetEmployeeDetails()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            EmployeeRegister.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@empId,@employeeCode,@hireDate,@Department,@Position,@Salary,@regID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@empId", txtEmpid.Text);
                cmd.Parameters.AddWithValue("@employeeCode", txtEmpcode.Text);
                cmd.Parameters.AddWithValue("@hireDate", txtDate.Text);
                cmd.Parameters.AddWithValue("@Department", txtDep.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@regID", txtRegid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee is inserted in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeDetails();
                ResetForm();

            }
        }

        private bool IsValid()
        {
            if (txtEmpid.Text == string.Empty)
            {
                MessageBox.Show("Employee Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEmpcode.Text == string.Empty)
            {
                MessageBox.Show("Employee Code is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDate.Text == string.Empty)
            {
                MessageBox.Show("Hire date is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDep.Text == string.Empty)
            {
                MessageBox.Show("Department is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtPosition.Text == string.Empty)
            {
                MessageBox.Show("Position is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtSalary.Text == string.Empty)
            {
                MessageBox.Show("Salary is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtRegid.Text == string.Empty)
            {
                MessageBox.Show("Register Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            Empid = 0;
            txtEmpid.Clear();
            txtEmpcode.Clear();
            txtDate.Clear();
            txtDep.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
            txtRegid.Clear();

            txtEmpid.Focus();
        }

        private void EmployeeRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empid = Convert.ToInt32(EmployeeRegister.SelectedRows[0].Cells[0].Value);

            txtEmpid.Text = EmployeeRegister.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpcode.Text = EmployeeRegister.SelectedRows[0].Cells[1].Value.ToString();
            txtDate.Text = EmployeeRegister.SelectedRows[0].Cells[2].Value.ToString();
            txtDep.Text = EmployeeRegister.SelectedRows[0].Cells[3].Value.ToString();
            txtPosition.Text = EmployeeRegister.SelectedRows[0].Cells[4].Value.ToString();
            txtSalary.Text = EmployeeRegister.SelectedRows[0].Cells[5].Value.ToString();
            txtRegid.Text = EmployeeRegister.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Empid > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET  empId=@empId, employeeCode=@employeeCode, hireDate=@hireDate, Department=@Department, Position=@Position, Salary=@Salary,regId=@regId WHERE empId = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@empId", txtEmpid.Text);
                cmd.Parameters.AddWithValue("@employeeCode", txtEmpcode.Text);
                cmd.Parameters.AddWithValue("@hireDate", txtDate.Text);
                cmd.Parameters.AddWithValue("@Department", txtDep.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@regId", txtRegid.Text);
                cmd.Parameters.AddWithValue("@id", this.Empid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee data is updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeDetails();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Select a employee to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Empid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE Employee WHERE empId = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Empid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee is deleted from database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeDetails();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Select a employee to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}