using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SESys
{
    public partial class studentreg : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public studentreg()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadRegistrationNumbers();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=DARK-N0\\SQLEXPRESS;Initial Catalog=EnrollmentSystem;Integrated Security=True"; // Replace with your connection string
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string regNo = comboBoxregno.Text;
            string firstName = tbxFname.Text;
            string lastName = tbxLname.Text;
            string nicNo = tbxNIC.Text;
            string contactNo = tbxstudentcontact.Text;
            DateTime dob = dateTimePickerDOB.Value;
            string gender = rdoMale.Checked ? "Male" : "Female";
            string parentFullName = tbxparentfullname.Text;
            string parentAddress = tbxparentaddress.Text;
            string parentNIC = tbxparentNIC.Text;
            string parentContactNo = tbxparentContactno.Text;
            string homePhoneNo = tbxhomephoneNo.Text;

            try
            {
                connection.Open();
                // Check if registration number already exists
                command.CommandText = "SELECT COUNT(*) FROM Student WHERE RegNo = @RegNo";
                command.Parameters.Clear(); // Clear existing parameters
                command.Parameters.AddWithValue("@RegNo", regNo); // Add parameter for checking registration number
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Registration number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert student details into the database
                    command.CommandText = @"INSERT INTO Student 
                                    (RegNo, FirstName, LastName, NICNo, ContactNo, DateOfBirth, Gender, 
                                    ParentFullName, ParentAddress, ParentNIC, ParentContactNo, HomePhoneNo) 
                                    VALUES 
                                    (@RegNo, @FirstName, @LastName, @NICNo, @ContactNo, @DateOfBirth, @Gender, 
                                    @ParentFullName, @ParentAddress, @ParentNIC, @ParentContactNo, @HomePhoneNo)";
                    command.Parameters.Clear(); // Clear existing parameters before adding new ones
                    command.Parameters.AddWithValue("@RegNo", regNo);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@NICNo", nicNo);
                    command.Parameters.AddWithValue("@ContactNo", contactNo);
                    command.Parameters.AddWithValue("@DateOfBirth", dob);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@ParentFullName", parentFullName);
                    command.Parameters.AddWithValue("@ParentAddress", parentAddress);
                    command.Parameters.AddWithValue("@ParentNIC", parentNIC);
                    command.Parameters.AddWithValue("@ParentContactNo", parentContactNo);
                    command.Parameters.AddWithValue("@HomePhoneNo", homePhoneNo);
                    // Execute the command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reload the registration numbers after successful registration
                    LoadRegistrationNumbers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnGenerateRegNo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string regNo = random.Next(1000, 9999).ToString();
            comboBoxregno.Text = regNo;
        }
        private void LoadRegistrationNumbers()
        {
            try
            {
                // Make sure the connection is closed before opening it again
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

                connection.Open();
                command.CommandText = "SELECT RegNo FROM Student";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxregno.Items.Add(reader["RegNo"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection in the finally block to ensure it's always closed
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void comboBoxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegNo = comboBoxregno.Text;

            try
            {
                connection.Open();
                command.Parameters.Clear(); // Clear existing parameters before adding new ones
                command.CommandText = "SELECT * FROM Student WHERE RegNo = @RegNo";
                command.Parameters.AddWithValue("@RegNo", selectedRegNo);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Populate the text boxes and other controls with student details
                    tbxFname.Text = reader["FirstName"].ToString();
                    tbxLname.Text = reader["LastName"].ToString();
                    tbxNIC.Text = reader["NICNo"].ToString();
                    tbxstudentcontact.Text = reader["ContactNo"].ToString();
                    dateTimePickerDOB.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    if (reader["Gender"].ToString() == "Male")
                    {
                        rdoMale.Checked = true;
                    }
                    else if (reader["Gender"].ToString() == "Female")
                    {
                        rdoFemale.Checked = true;
                    }
                    tbxparentfullname.Text = reader["ParentFullName"].ToString();
                    tbxparentaddress.Text = reader["ParentAddress"].ToString();
                    tbxparentNIC.Text = reader["ParentNIC"].ToString();
                    tbxparentContactno.Text = reader["ParentContactNo"].ToString();
                    tbxhomephoneNo.Text = reader["HomePhoneNo"].ToString();
                }
                else
                {
                    MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string regNo = comboBoxregno.Text;
            string firstName = tbxFname.Text;
            string lastName = tbxLname.Text;
            string nicNo = tbxNIC.Text;
            string contactNo = tbxstudentcontact.Text;
            DateTime dob = dateTimePickerDOB.Value;
            string gender = rdoMale.Checked ? "Male" : "Female";
            string parentFullName = tbxparentfullname.Text;
            string parentAddress = tbxparentaddress.Text;
            string parentNIC = tbxparentNIC.Text;
            string parentContactNo = tbxparentContactno.Text;
            string homePhoneNo = tbxhomephoneNo.Text;

            try
            {
                connection.Open();
                command.Parameters.Clear(); // Clear existing parameters before adding new ones
                command.CommandText = @"UPDATE Student SET 
                                FirstName = @FirstName, 
                                LastName = @LastName, 
                                NICNo = @NICNo, 
                                ContactNo = @ContactNo, 
                                DateOfBirth = @DateOfBirth, 
                                Gender = @Gender, 
                                ParentFullName = @ParentFullName, 
                                ParentAddress = @ParentAddress, 
                                ParentNIC = @ParentNIC, 
                                ParentContactNo = @ParentContactNo, 
                                HomePhoneNo = @HomePhoneNo 
                                WHERE RegNo = @RegNo";
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@NICNo", nicNo);
                command.Parameters.AddWithValue("@ContactNo", contactNo);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@ParentFullName", parentFullName);
                command.Parameters.AddWithValue("@ParentAddress", parentAddress);
                command.Parameters.AddWithValue("@ParentNIC", parentNIC);
                command.Parameters.AddWithValue("@ParentContactNo", parentContactNo);
                command.Parameters.AddWithValue("@HomePhoneNo", homePhoneNo);
                command.Parameters.AddWithValue("@RegNo", regNo);
                command.ExecuteNonQuery();
                MessageBox.Show("Student details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearFormControls()
        {
            tbxFname.Clear();
            tbxLname.Clear();
            tbxNIC.Clear();
            tbxstudentcontact.Clear();
            dateTimePickerDOB.Value = DateTime.Now; // Reset to current date
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            tbxparentfullname.Clear();
            tbxparentaddress.Clear();
            tbxparentNIC.Clear();
            tbxparentContactno.Clear();
            tbxhomephoneNo.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string regNo = comboBoxregno.Text;

            try
            {
                connection.Open();
                command.Parameters.Clear(); // Clear existing parameters before adding new ones
                command.CommandText = "DELETE FROM Student WHERE RegNo = @RegNo";
                command.Parameters.AddWithValue("@RegNo", regNo);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student details deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form controls after successful deletion
                    ClearFormControls();
                    // Reload registration numbers after deletion
                    LoadRegistrationNumbers();
                }
                else
                {
                    MessageBox.Show("No student found with the provided registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
    }
}
