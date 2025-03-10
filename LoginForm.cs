 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mendoza_Mariela_Act_GUI
{
    public partial class LoginForm : Form
    {
        private string validUsername = "Mariela";
        private string validPassword = "marielamaganda";
        private int loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginAttempts++;
            if (loginAttempts > 5)
            {
                MessageBox.Show("Your login has been blocked after multiple incorrect password entries. A password reset is required. Please follow the link below.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Password reset link (for display only)
                MessageBox.Show("You can reset your password by clicking on the following URL: www.reset.com", "Reset Password Link", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // Or disable login button and show reset link
                return;
            }

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == validUsername && password == validPassword)
            {
                // Successful login
                MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentForm studentForm = new StudentForm();
                this.Hide();
                studentForm.Show();
            }
            else
            {
                // Failed login
                string errorMessage = "";
                if (username != validUsername && password != validPassword)
                {
                    errorMessage = "Incorrect Username and Password.";
                }
                else if (username != validUsername)
                {
                    errorMessage = "Incorrect Username.";
                }
                else if (password != validPassword)
                {
                    errorMessage = "Incorrect Password.";
                }
                MessageBox.Show(errorMessage + $"\nAttempt login: {loginAttempts} of 5", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear password field after failed attempt
                PasswordTextBox.Clear();
                PasswordTextBox.Focus(); // Set focus back to password textbox for next attempt
            }
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
