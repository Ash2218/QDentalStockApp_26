using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QDentalStockApp26
{
    public partial class frmLogin : Form
    {
        String username, password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar ;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username= txtUsername.Text.Trim().ToLower();
            password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {

                frmItems frm = new frmItems(); //items form
                frm.Show();
                this.Hide();

                //MessageBox.Show("Please enter username and password");
                //txtUsername.Focus();
                //return;
            }

            if (username == "dentalrep81")
            {   

                if (password == "1234")
                {
                   MessageBox.Show("Login successful", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 frm = new Form1(); // main form
                    frm.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Incorrect password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }

                
            }
            else
            {
                MessageBox.Show("Incorrect username", "Login Failed!",MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Clear();
                txtUsername.Focus();
            }


        }
    }
}
