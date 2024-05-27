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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace questiongame
{
    public partial class Reset : Form
    {
        public Reset()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\questiongame\\questiongame\\game.mdf;Integrated Security=True;Connect Timeout=30");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Reset_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string currentpass = textBox2.Text;
            string newpass = textBox3.Text;

         
        try
            {
              
                    connection.Open();

                    string query = "UPDATE users SET password = @newpass WHERE username = @name AND password = @currentpass";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50) { Value = name});
                        command.Parameters.Add(new SqlParameter("@currentpass", SqlDbType.NVarChar, 64) { Value = currentpass });
                        command.Parameters.Add(new SqlParameter("@newpass", SqlDbType.NVarChar, 64) { Value = newpass});

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data");
                        }
                    }
                
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
