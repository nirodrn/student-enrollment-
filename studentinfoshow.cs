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
    public partial class studentinfoshow : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        public studentinfoshow()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadStudentData();
            LoadRegistrationNumbers();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=DARK-N0\\SQLEXPRESS;Initial Catalog=EnrollmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            command = new SqlCommand();
            command.Connection = connection;
        }

        private void studentinfoshow_Load(object sender, EventArgs e)
        {
            // Check if there is at least one selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the value of the RegNo column from the selected row
                string regNo = dataGridView1.SelectedRows[0].Cells["RegNo"].Value.ToString();

                // Set the selected item in the ComboBox to the RegNo value
                comboBoxregno.SelectedItem = regNo;

                // Update the labels and other information based on the selected registration number
                UpdateComboBoxAndLabels(regNo);
            }
        }




        private void comboBoxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected registration number from the ComboBox
            string selectedRegNo = comboBoxregno.SelectedItem?.ToString();

            // Update the ListBox
            UpdateListBox(selectedRegNo);

            // Unselect all rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }

            // Check if selectedRegNo is not null before proceeding
            if (!string.IsNullOrEmpty(selectedRegNo))
            {
                // Find the row in the DataGridView that matches the selected registration number
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["RegNo"].Value.ToString() == selectedRegNo)
                    {
                        // Select the row in the DataGridView
                        row.Selected = true;

                        // Scroll to the selected row
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                        // Optionally, you can break the loop if you only want to select the first matching row
                        break;
                    }
                }
            }

            // Update DataGridView with all columns from the Student table
            try
            {
                connection.Open();
                string query = "SELECT * FROM Student";
                adapter.SelectCommand = new SqlCommand(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "StudentData");
                dataGridView1.DataSource = ds.Tables["StudentData"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadStudentData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Student";
                adapter.SelectCommand = new SqlCommand(query, connection);
                dataSet.Clear(); // Clear existing data
                adapter.Fill(dataSet, "Students");
                dataGridView1.DataSource = dataSet.Tables["Students"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateComboBoxAndLabels(string regNo)
        {
            // Get the selected registration number from the ComboBox
            string selectedRegNo = comboBoxregno.SelectedItem?.ToString();

            // Update the ListBox
            UpdateListBox(selectedRegNo);

            // Update the labels
            UpdateLabels(selectedRegNo);
        }

        private void LoadRegistrationNumbers()
        {
            try
            {
                comboBoxregno.Items.Clear(); // Clear existing items
                foreach (DataRow row in dataSet.Tables["Students"].Rows)
                {
                    comboBoxregno.Items.Add(row["RegNo"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is at least one selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the value of the RegNo column from the selected row
                string regNo = dataGridView1.SelectedRows[0].Cells["RegNo"].Value.ToString();

                // Set the selected item in the ComboBox to the RegNo value
                comboBoxregno.SelectedItem = regNo;

                // Update the labels and other information based on the selected registration number
                UpdateComboBoxAndLabels(regNo);

            }
        }

        private void UpdateListBox(string regNo)
        {
            try
            {
                connection.Open();

                // Check if there are values in the StudentClasses table for the selected registration number
                string query = "SELECT CourseName FROM StudentClasses WHERE RegNo = @RegNo";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@RegNo", regNo);

                SqlDataReader reader = cmd.ExecuteReader();

                // Clear the ListBox
                listBoxClasses.Items.Clear();

                // If there are values in the StudentClasses table, add them to the ListBox
                while (reader.Read())
                {
                    listBoxClasses.Items.Add(reader["CourseName"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ListBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateLabels(string regNo)
        {
            try
            {
                connection.Open();

                // Update labels based on the selected registration number
                string query = "SELECT FirstName, LastName, Gender, DateOfBirth FROM Student WHERE RegNo = @RegNo";
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RegNo", regNo);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Calculate age based on date of birth
                    DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);
                    int age = CalculateAge(dob);

                    // Update labels with the retrieved information
                    lblfullname.Text = $"{reader["FirstName"]} {reader["LastName"]}";
                    lblgender.Text = reader["Gender"].ToString();
                    lblage.Text = age.ToString(); // Display age instead of birthday
                                                  // Clear the parent information labels
                                                  //  llblparentnameandtp.Text = "";
                }
                else
                {
                    // Clear labels if no matching record found
                    lblfullname.Text = "";
                    lblgender.Text = "";
                    lblage.Text = "";
                    // Clear the parent information labels
                    //  llblparentnameandtp.Text = "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating labels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }



    }
}
