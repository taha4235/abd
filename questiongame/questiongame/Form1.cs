using System.Data.SqlClient;

namespace questiongame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\questiongame\\questiongame\\game.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("all field are required");
            }
            else
            {
                LoginUser();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void LoginUser()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "admin")
            {
                admin d2 = new admin();
                d2.Show();
                return; // Return after redirecting to admin page
            }

            try
            {
                // Check if the user exists
                string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@username", username);

                connection.Open();
                int userCount = (int)checkUserCommand.ExecuteScalar();

                if (userCount == 0)
                {
                    // If user does not exist, register the user
                    string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("New user registered successfully!");

                    // Log in the newly registered user
                    MessageBox.Show("Login successful!");
                    game g1 = new game();
                    g1.Show();

                    connection.Close();
                    return;
                }

                string checkPasswordQuery = "SELECT password FROM users WHERE username = @username";
                SqlCommand checkPasswordCommand = new SqlCommand(checkPasswordQuery, connection);
                checkPasswordCommand.Parameters.AddWithValue("@username", username);

                string storedPassword = checkPasswordCommand.ExecuteScalar()?.ToString();

                if (storedPassword == null)
                {
                    MessageBox.Show("Username or password is incorrect!");
                    connection.Close();
                    return;
                }

                if (storedPassword == password)
                {
                    MessageBox.Show("Login successful!");
                    game g1 = new game();
                    g1.Show();
                }
                else
                {
                    MessageBox.Show("Password is incorrect!");
                }

                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error}");
                connection.Close();
            }
        }






        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset r1 = new Reset();
            r1.Show();
            this.Hide();
        }
    }
}