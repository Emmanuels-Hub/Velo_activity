using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velo_Fitness
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=fitdatabase.db;Version=3;";

        public Register()
        {
            InitializeComponent();
            InitializeDatabase();

        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Create a table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)";
                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create a table if it doesn't exist
                string createCalQuery = "CREATE TABLE IF NOT EXISTS calory (id INTEGER PRIMARY KEY CHECK (id = 1), value INTEGER NOT NULL )";
                using (SQLiteCommand cmd = new SQLiteCommand(createCalQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public bool valpass(string password)
        {
            var uppercase = new Regex(@"[A-Z]+");
            var lowercase = new Regex(@"[a-z]+");

            if (uppercase.IsMatch(password) && lowercase.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (getUser.Text == "" && getPass.Text == "" && getcomPass.Text == "")
            {
                MessageBox.Show("Input fields cannot be Empty.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (getcomPass.Text == getPass.Text)
            {
                if (getPass.TextLength >= 12)
                {
                    if (valpass(getPass.Text) == true)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();

                            string insertDataQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                            using (SQLiteCommand cmd = new SQLiteCommand(insertDataQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", getUser.Text);
                                cmd.Parameters.AddWithValue("@password", getPass.Text);
                                cmd.ExecuteNonQuery();
                            }

                            conn.Close();
                        }

                        MessageBox.Show("Account Created Successful.", "Created.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password must contain at least 1 lowercase and 1 uppercase letter", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password lenght must be Above 12.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Password Doesn't Match.", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getPass.Text = "";
                getcomPass.Text = "";
                getPass.Focus();
            }

        }

        private void signPage_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
