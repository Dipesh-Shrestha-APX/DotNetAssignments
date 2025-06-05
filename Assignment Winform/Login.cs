using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Allow only typing, not control characters (like Enter key)
            if (char.IsControl(e.KeyChar))
                return;

            // After each keypress, check if the current text is a valid email
            string email = textBox1.Text + e.KeyChar; // Add the new character to the text

            if (IsValidEmail(email))
            {
                textBox1.BackColor = System.Drawing.Color.LightGreen; // valid email typed
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.LightPink; // invalid email so far
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill both Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(username))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Both filled and email is valid
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

