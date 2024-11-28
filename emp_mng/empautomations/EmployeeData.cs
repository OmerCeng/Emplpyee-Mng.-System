using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workautomations
{
    internal class EmployeeData
    {



        private SqlConnection connect = new SqlConnection(@"Data Source=OMER\SQLEXPRESS;Initial Catalog=employeee;Integrated Security=True;");

        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> employeeList = new List<EmployeeData>();

            try
            {
                connect.Open();
                string query = "SELECT employee_id, full_name, gender, contact_number, position, salary, status FROM employees WHERE delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeData employee = new EmployeeData
                        {
                            // Assuming your columns are mapped correctly
                            EmployeeID = reader["employee_id"].ToString(),
                            FullName = reader["full_name"].ToString(),
                            Gender = reader["gender"].ToString(),
                            ContactNumber = reader["contact_number"].ToString(),
                            Position = reader["position"].ToString(),
                            Salary = Convert.ToDecimal(reader["salary"]),
                            Status = reader["status"].ToString()
                        };
                        employeeList.Add(employee);
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

            return employeeList;
        }

        // Properties for employee data
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Status { get; set; }

    }
}


