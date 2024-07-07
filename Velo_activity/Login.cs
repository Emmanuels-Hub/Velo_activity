using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Velo_Fitness
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=fitdatabase.db;Version=3;";
        private int timeout = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string username = getloguser.Text;
            string password = getlogpass.Text;


            if (username != "" && password != "")
            {
                if (timeout == 0)
                {
                    MessageBox.Show("Login Limits Exceeded, Create a new Account", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    new Register().Show();
                    this.Hide();
                }
                else
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string selectUserQuery = "SELECT * FROM users WHERE username = @username AND password = @password";
                        using (SQLiteCommand cmd = new SQLiteCommand(selectUserQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Login successful!");
                                    // Proceed to the next form or main application
                                    new Home().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Login Details.", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    timeout--;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Input Fields cannot be empty.", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void regPage_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
