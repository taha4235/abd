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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\questiongame\\questiongame\\game.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("all field are required");
            }
            else
            {
                int time = Convert.ToInt32(textBox1.Text);
                int score = Convert.ToInt32(textBox2.Text); 
                string name = textBox3.Text;
                string question = textBox4.Text;
                int userid = -1;
                int questionid = -1;

                try
                {
                    connection.Open();

                    string query1 = "SELECT Id FROM users WHERE username = @name";
                    using (SqlCommand command1 = new SqlCommand(query1, connection))
                    {
                        command1.Parameters.AddWithValue("@name", name);
                        SqlDataReader reader = command1.ExecuteReader();
                        if (reader.Read())
                        {
                            userid = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("User not found or invalid");
                            reader.Close();
                            return; 
                        }
                        reader.Close();
                    }

                    string query2 = "SELECT Id FROM question WHERE description = @question";
                    using (SqlCommand command2 = new SqlCommand(query2, connection))
                    {
                        command2.Parameters.AddWithValue("@question", question);
                        SqlDataReader reader = command2.ExecuteReader();
                        if (reader.Read())
                        {
                            questionid = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("Question not found or invalid");
                            reader.Close();
                            return; 
                        }
                        reader.Close();
                    }

                    string query3 = "INSERT INTO Round (Time, Score, UserId, QuestionId) VALUES (@time, @score, @userId, @questionId)";
                    using (SqlCommand command3 = new SqlCommand(query3, connection))
                    {
                        command3.Parameters.AddWithValue("@time", time);
                        command3.Parameters.AddWithValue("@score", score);
                        command3.Parameters.AddWithValue("@userId", userid);
                        command3.Parameters.AddWithValue("@questionId", questionid);

                        int rows = command3.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Result added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Insert failed");
                        }
                    }
                    string query5 = "SELECT username FROM users WHERE Id = @id";
                    string highestScoreQuery = @"
    SELECT TOP 1 R.UserId, R.Score
    FROM Round R
    ORDER BY R.Score DESC";
                    string lowestScoreQuery = @"
    SELECT TOP 1 R.UserId, R.Score
    FROM Round R
    ORDER BY R.Score ASC";

                    using (SqlCommand command = new SqlCommand(query5, connection))
                    {
                        command.Parameters.AddWithValue("@id", userid);
                        SqlDataReader reader = command.ExecuteReader();
                        string currentUsername = string.Empty;

                        if (reader.Read())
                        {
                            currentUsername = reader["username"].ToString();
                        }
                        reader.Close();  

                        using (SqlCommand highestScoreCommand = new SqlCommand(highestScoreQuery, connection))
                        {
                            SqlDataReader scoreReader = highestScoreCommand.ExecuteReader();
                            int highestScoreUserId = 0;
                            int highestScore = 0;
                            string highestScoreUsername = string.Empty;

                            if (scoreReader.Read())
                            {
                                highestScoreUserId = Convert.ToInt32(scoreReader["UserId"]);
                                highestScore = Convert.ToInt32(scoreReader["Score"]);
                                scoreReader.Close(); 

                                using (SqlCommand userCommand = new SqlCommand("SELECT username FROM users WHERE Id = @highestScoreUserId", connection))
                                {
                                    userCommand.Parameters.AddWithValue("@highestScoreUserId", highestScoreUserId);
                                    SqlDataReader userReader = userCommand.ExecuteReader();

                                    if (userReader.Read())
                                    {
                                        highestScoreUsername = userReader["username"].ToString();
                                    }
                                    userReader.Close();
                                }
                            }
                            else
                            {
                                scoreReader.Close();  
                            }

                            using (SqlCommand lowestScoreCommand = new SqlCommand(lowestScoreQuery, connection))
                            {
                                SqlDataReader lowestScoreReader = lowestScoreCommand.ExecuteReader();
                                int lowestScoreUserId = 0;
                                int lowestScore = 0;
                                string lowestScoreUsername = string.Empty;

                                if (lowestScoreReader.Read())
                                {
                                    lowestScoreUserId = Convert.ToInt32(lowestScoreReader["UserId"]);
                                    lowestScore = Convert.ToInt32(lowestScoreReader["Score"]);
                                    lowestScoreReader.Close();  

                                    using (SqlCommand lowestUserCommand = new SqlCommand("SELECT username FROM users WHERE Id = @lowestScoreUserId", connection))
                                    {
                                        lowestUserCommand.Parameters.AddWithValue("@lowestScoreUserId", lowestScoreUserId);
                                        SqlDataReader lowestUserReader = lowestUserCommand.ExecuteReader();

                                        if (lowestUserReader.Read())
                                        {
                                            lowestScoreUsername = lowestUserReader["username"].ToString();
                                        }
                                        lowestUserReader.Close();
                                    }
                                }
                                else
                                {
                                    lowestScoreReader.Close(); 
                                }

                                MessageBox.Show($"Current User: {currentUsername}\n" +
                                                $"Highest Score User: {highestScoreUsername}\nHighest Score: {highestScore}\n" +
                                                $"Lowest Score User: {lowestScoreUsername}\nLowest Score: {lowestScore}");
                            }
                        }
                    }


                }



                catch (Exception ex)
                {
                    
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
