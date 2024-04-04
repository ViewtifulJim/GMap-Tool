using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapTool
{
    public partial class LoginForm : Form
    {

        private Dictionary<string, string> userCredentials;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            existingUsers();
        }

        private void btnHelpLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter your username and password to login.\nOnly existing users can access this application.\n\nIf you require access please click 'Request Login'.\n\nIcon Reference: https://uxwing.com/country-icon/",  "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearLogin_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            // Check if the provided username exists and if the password matches
            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GMapToolMainForm customForm = new GMapToolMainForm();
                customForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void existingUsers()
        {
            userCredentials = new Dictionary<string, string>();
            userCredentials.Add("admin", "admin");
            userCredentials.Add("jw", "password123");
            userCredentials.Add("shiny", "password123");
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == "")
            {
                txtBoxUsername.BackColor = Color.LightGray;
            }
            else
            {
                txtBoxUsername.BackColor = Color.White;
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "")
            {
                txtBoxPassword.BackColor = Color.LightGray;
            }
            else
            {
                txtBoxPassword.BackColor = Color.White;
            }   
        }


        private void btnRequestLogin_Click(object sender, EventArgs e)
        {
            string devEmail = "14048787@students.southwales.ac.uk",
                    subject = "Request: New username and password - GMapTool",
                    message = "<Enter phone number to retrieve new username and password>";

            string mailToURI = $"mailto:{devEmail}?subject={Uri.EscapeUriString(subject)}&body={Uri.EscapeUriString(message)}";

            DialogResult userChoice = MessageBox.Show("Are you sure you would like to request a username and password?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (userChoice == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(mailToURI) { UseShellExecute = true });
            }
        }

        
    }
}
