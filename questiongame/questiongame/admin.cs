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

namespace questiongame
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\questiongame\\questiongame\\game.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string answer1 = textBox1.Text;
            string answer2 = textBox2.Text;
            string question = richTextBox1.Text;

            try
            {
                string insertQuery = "INSERT INTO question (description,Answer1, Answer2) VALUES (@description, @answer1, @answer2)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@description", question);
                insertCommand.Parameters.AddWithValue("@answer1", answer1);
                insertCommand.Parameters.AddWithValue("@answer2", answer2);

                connection.Open();
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Question added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add question. Please try again.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error}");
                connection.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string answer1 = textBox3.Text;
            string description = richTextBox2.Text;

            try
            {
                string deleteQuery = "DELETE FROM question WHERE answer1 = @answer1 AND description = @description";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@answer1", answer1);
                deleteCommand.Parameters.AddWithValue("@description", description);

                connection.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Question deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No question found with the provided answer and description.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error}");
                connection.Close();
            }
            textBox3.Clear();
            richTextBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string answer1 = textBox4.Text;
            string answer2 = textBox5.Text;
            string description = richTextBox3.Text;

            try
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE question SET description = @description, answer1 = @answer1, answer2 = @answer2";

                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@answer1", answer1);
                command.Parameters.AddWithValue("@answer2", answer2);

                int rows = command.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show("updated succesfully");
                else
                {
                    MessageBox.Show("question not found");
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
            textBox4.Clear();
            textBox5.Clear();
            richTextBox3.Clear();




        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT Id,Score FROM Round WHERE Score = @score";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@score", textBox6.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Score"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
