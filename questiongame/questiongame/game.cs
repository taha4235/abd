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
using System.Threading;
using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;

namespace questiongame
{
    public partial class game : Form
    {
        private Random random = new Random();
        public game()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\questiongame\\questiongame\\game.mdf;Integrated Security=True;Connect Timeout=30");
        private int countdown = 20;


        private void game_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button2.Text = GenerateRandomText(10);
            button5.Text = GenerateRandomText(10);
            decrement();
            fun();


        }
        void decrement()
        {
            countdown = 20;
            timer1.Start();
        }
        public void checkTimer()
        {
            countdown--;
            if(countdown <= 0)
            {
                timer1.Stop();
                MessageBox.Show("you failed");
            }
        }
        private string GenerateRandomText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }
        void fun()
        {
            try
            {
                connection.Open();
                string query = "SELECT description,answer1, answer2 FROM question";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        richTextBox1.Text = reader["description"].ToString();
                        button2.Text = reader["answer1"].ToString();
                        button4.Text = reader["answer2"].ToString();
                        button3.Text = "hello";
                        button5.Text = "hello world";


                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"{error}");
            }
            finally
            {
                connection.Close();
            }
        }
        void loops(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkTimer();
            if (countdown >= 0)
            {
                label3.Text = countdown.ToString();
                countdown--;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int score = Convert.ToInt32(label4.Text); // Get the current score from label4

            try
            {
                connection.Open();

                string description = richTextBox1.Text;

                string query = "SELECT answer1, answer2 FROM question WHERE description = @description";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", description);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string answer1 = reader["answer1"].ToString();
                    string answer2 = reader["answer2"].ToString();

                    if (clickedBtn.Text == answer1 || clickedBtn.Text == answer2)
                    {
                        score++;
                        MessageBox.Show("Correct!");
                        label4.Text = score.ToString();
                        timer1.Stop();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("No question found with the given description.");
                }
                reader.Close();

                string newQuestionQuery = "SELECT TOP 1 description, answer1, answer2 FROM question ORDER BY NEWID()";
                SqlCommand newQuestionCommand = new SqlCommand(newQuestionQuery, connection);

                SqlDataReader newQuestionReader = newQuestionCommand.ExecuteReader();
                if (newQuestionReader.Read())
                {
                    richTextBox1.Text = newQuestionReader["description"].ToString();
                    string newAnswer1 = newQuestionReader["answer1"].ToString();
                    string newAnswer2 = newQuestionReader["answer2"].ToString();

                    button3.Text = newAnswer1;
                    button4.Text = newAnswer2;
                }
                newQuestionReader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int score = Convert.ToInt32(label4.Text); // Get the current score from label4

            try
            {
                connection.Open();

                string description = richTextBox1.Text;

                string query = "SELECT answer1, answer2 FROM question WHERE description = @description";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", description);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string answer1 = reader["answer1"].ToString();
                    string answer2 = reader["answer2"].ToString();

                    if (clickedBtn.Text == answer1 || clickedBtn.Text == answer2)
                    {
                        score++;
                        MessageBox.Show("Correct!");
                        label4.Text = score.ToString();
                        timer1.Stop();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("No question found with the given description.");
                }
                reader.Close();

                // Load a new question
                string newQuestionQuery = "SELECT TOP 1 description, answer1, answer2 FROM question ORDER BY NEWID()";
                SqlCommand newQuestionCommand = new SqlCommand(newQuestionQuery, connection);

                SqlDataReader newQuestionReader = newQuestionCommand.ExecuteReader();
                if (newQuestionReader.Read())
                {
                    richTextBox1.Text = newQuestionReader["description"].ToString();
                    string newAnswer1 = newQuestionReader["answer1"].ToString();
                    string newAnswer2 = newQuestionReader["answer2"].ToString();

                    button3.Text = newAnswer1;
                    button4.Text = newAnswer2;
                }
                newQuestionReader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int score = Convert.ToInt32(label4.Text); // Get the current score from label4

            try
            {
                connection.Open();

                string description = richTextBox1.Text;

                string query = "SELECT answer1, answer2 FROM question WHERE description = @description";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", description);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string answer1 = reader["answer1"].ToString();
                    string answer2 = reader["answer2"].ToString();

                    if (clickedBtn.Text == answer1 || clickedBtn.Text == answer2)
                    {
                        score++;
                        MessageBox.Show("Correct!");
                        label4.Text = score.ToString();
                        timer1.Stop();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("No question found with the given description.");
                }
                reader.Close();

                // Load a new question
                string newQuestionQuery = "SELECT TOP 1 description, answer1, answer2 FROM question ORDER BY NEWID()";
                SqlCommand newQuestionCommand = new SqlCommand(newQuestionQuery, connection);

                SqlDataReader newQuestionReader = newQuestionCommand.ExecuteReader();
                if (newQuestionReader.Read())
                {
                    richTextBox1.Text = newQuestionReader["description"].ToString();
                    string newAnswer1 = newQuestionReader["answer1"].ToString();
                    string newAnswer2 = newQuestionReader["answer2"].ToString();

                    button3.Text = newAnswer1;
                    button4.Text = newAnswer2;
                }
                newQuestionReader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int score = Convert.ToInt32(label4.Text); // Get the current score from label4

            try
            {
                connection.Open();

                string description = richTextBox1.Text;

                string query = "SELECT answer1, answer2 FROM question WHERE description = @description";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", description);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string answer1 = reader["answer1"].ToString();
                    string answer2 = reader["answer2"].ToString();

                    if (clickedBtn.Text == answer1 || clickedBtn.Text == answer2)
                    {
                        score++;
                        MessageBox.Show("Correct!");
                        label4.Text = score.ToString();
                        timer1.Stop();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("No question found with the given description.");
                }
                reader.Close();

                // Load a new question
                string newQuestionQuery = "SELECT TOP 1 description, answer1, answer2 FROM question ORDER BY NEWID()";
                SqlCommand newQuestionCommand = new SqlCommand(newQuestionQuery, connection);

                SqlDataReader newQuestionReader = newQuestionCommand.ExecuteReader();
                if (newQuestionReader.Read())
                {
                    richTextBox1.Text = newQuestionReader["description"].ToString();
                    string newAnswer1 = newQuestionReader["answer1"].ToString();
                    string newAnswer2 = newQuestionReader["answer2"].ToString();

                    button3.Text = newAnswer1;
                    button4.Text = newAnswer2;
                }
                newQuestionReader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occurred: " + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }




        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Stop();
            label4.Text = "0";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Text = "button2";
            button3.Text = "button3";
            button4.Text = "button4";
            button5.Text = "button5";
            label3.Text = Convert.ToString(20);
            richTextBox1.Text = "";


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Blue;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Transparent;
                this.ForeColor = Color.Black;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Transparent;
                this.ForeColor = Color.Black;
            }
        }

        private void loginAsNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newform = new Form1();
            newform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            result r1 = new result();
            r1.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
