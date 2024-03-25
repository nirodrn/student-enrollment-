using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SESys
{
    public partial class courses : Form
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public courses()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDaysOfWeek();
            LoadSavedCourses();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=DARK-N0\\SQLEXPRESS;Initial Catalog=EnrollmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
        }
        private void LoadDaysOfWeek()
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            comboBoxdays.Items.AddRange(daysOfWeek);
        }

       private void LoadSavedCourses()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(); // Initialize the command object
                command.Connection = connection;
                command.CommandText = "SELECT CourseName FROM Courses";

                SqlDataAdapter adapter = new SqlDataAdapter(); // Initialize the adapter object
                adapter.SelectCommand = command;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxcourseName.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBoxcourseName.Items.Add(row["CourseName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        private void btnsave_Click(object sender, EventArgs e)
        {
            string courseName = comboBoxcourseName.Text;
            List<string> courseTimings = new List<string>();
            foreach (var item in listBoxCourseTime.Items)
            {
                courseTimings.Add(item.ToString());
            }

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO Courses (CourseName, CourseTimings) VALUES (@CourseName, @CourseTimings)";
                command.Parameters.Clear(); // Clear existing parameters
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.Parameters.AddWithValue("@CourseTimings", string.Join(",", courseTimings));
                command.ExecuteNonQuery();
                MessageBox.Show("Course saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSavedCourses(); // Update the ComboBox with saved courses
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void comboBoxcourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = comboBoxcourseName.Text;
            if (!string.IsNullOrEmpty(selectedCourse))
            {
                try
                {
                    connection.Open();
                    command.CommandText = "SELECT CourseTimings FROM Courses WHERE CourseName = @CourseName";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CourseName", selectedCourse);
                    string courseTimings = command.ExecuteScalar()?.ToString();
                    if (!string.IsNullOrEmpty(courseTimings))
                    {
                        listBoxCourseTime.Items.Clear();
                        listBoxCourseTime.Items.AddRange(courseTimings.Split(','));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading course timings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnAddToListbox_Click(object sender, EventArgs e)
        {
            string courseTime = $"{comboBoxdays.SelectedItem}: {tbxstarTime.Text} to {tbxendTime.Text}";
            listBoxCourseTime.Items.Add(courseTime);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBoxcourseName.Text;
            if (!string.IsNullOrEmpty(selectedCourse))
            {
                // Get the updated course timings from the list box
                List<string> updatedCourseTimings = new List<string>();
                foreach (var item in listBoxCourseTime.Items)
                {
                    updatedCourseTimings.Add(item.ToString());
                }

                try
                {
                    connection.Open();
                    command.CommandText = "UPDATE Courses SET CourseTimings = @CourseTimings WHERE CourseName = @CourseName";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CourseTimings", string.Join(",", updatedCourseTimings));
                    command.Parameters.AddWithValue("@CourseName", selectedCourse);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course timings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating course timings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBoxcourseName.Text;
            if (!string.IsNullOrEmpty(selectedCourse))
            {
                try
                {
                    connection.Open();
                    command.CommandText = "DELETE FROM Courses WHERE CourseName = @CourseName";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CourseName", selectedCourse);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSavedCourses(); // Update the ComboBox with saved courses
                    }
                    else
                    {
                        MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnremovefromListbox_Click(object sender, EventArgs e)
        {
            // Check if any item is selected in the list box
            if (listBoxCourseTime.SelectedIndex != -1)
            {
                // Remove the selected item from the list box
                listBoxCourseTime.Items.RemoveAt(listBoxCourseTime.SelectedIndex);
            }
            else
            {
                // If no item is selected, show an error message
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCourseTime.Items.Clear();

        }
    }
}
