namespace SESys
{
    public partial class Form1 : Form
    {

        private int loginAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbxuser.Text;
            string password = tbxpass.Text;

            if (username == "admin" && password == "1234")
            {

                home homeForm = new home();
                homeForm.Show();
                this.Hide();
            }
            else
            {

                loginAttempts--;
                if (loginAttempts > 0)
                {
                    MessageBox.Show("Invalid username or password. You have " + loginAttempts + " attempts left.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Maximum login attempts reached. Application will now close.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}