using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

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
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@empId,@employeeCode,@hireDate,@Department,@Position,@Salary)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@empId", txtEmpid.Text);
                cmd.Parameters.AddWithValue("@employeeCode", txtEmpcode.Text);
                cmd.Parameters.AddWithValue("@hireDate", txtDate.Text);
                cmd.Parameters.AddWithValue("@Department", txtDep.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);


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

            // Define arrays of TextBox controls for integer and string validation
            TextBox[] integerFields = { txtEmpid, txtSalary };
            TextBox[] stringFields = { txtEmpcode, txtDate, txtDep, txtPosition };

            foreach (TextBox field in integerFields)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    string fieldName = field.Name.Substring(3); // Remove "txt" prefix from control name
                    MessageBox.Show(fieldName + " is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!int.TryParse(field.Text, out int fieldValue))
                {
                    string fieldName = field.Name.Substring(3); // Remove "txt" prefix from control name
                    MessageBox.Show(fieldName + " must contain a valid integer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (TextBox field in stringFields)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    string fieldName = field.Name.Substring(3); // Remove "txt" prefix from control name
                    MessageBox.Show(fieldName + " is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (int.TryParse(field.Text, out int fieldValue))
                {
                    string fieldName = field.Name.Substring(3); // Remove "txt" prefix from control name
                    MessageBox.Show(fieldName + " must contain only letters", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            return true;


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


            txtEmpid.Focus();
        }

        private void EmployeeRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empid = Convert.ToInt32(EmployeeRegister.SelectedRows[0].Cells[0].Value);

            txtEmpid.Text = EmployeeRegister.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpcode.Text = EmployeeRegister.SelectedRows[0].Cells[1].Value.ToString();

            string inputDate = EmployeeRegister.SelectedRows[0].Cells[2].Value.ToString();
            DateTime parsedDate = DateTime.ParseExact(inputDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string formattedDate = parsedDate.ToString("yyyy-MM-dd HH:mm:ss");
            txtDate.Text = formattedDate;

            txtDep.Text = EmployeeRegister.SelectedRows[0].Cells[3].Value.ToString();
            txtPosition.Text = EmployeeRegister.SelectedRows[0].Cells[4].Value.ToString();
            txtSalary.Text = EmployeeRegister.SelectedRows[0].Cells[5].Value.ToString();



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
            if (Empid > 0)
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