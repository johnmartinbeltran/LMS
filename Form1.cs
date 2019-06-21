using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace loginformPOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }

        
        DBaseconnection dbc = new DBaseconnection();
        
        private void FormClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void txtbox_username_Enter(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "Student ID")
            {
                txtbox_username.Text = "";
            }

        }

        private void txtbox_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_username.Text))
            {

                txtbox_username.Text = "Student ID";
            }
        }

        private void txtbox_password_Enter(object sender, EventArgs e)
        {
            if (txtbox_password.Text == "Password")
            {
                txtbox_password.Text = "";
            }
            txtbox_password.isPassword = true;
        }

        private void txtbox_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_password.Text))
            {
                txtbox_password.isPassword = false;
                txtbox_password.Text = "Password";
            }

        }

        private void minimized_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            registrationform frm = new registrationform();
            frm.Show();
        }

        private void txt_password_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int attempts = 1;
        private void btn_login_Click(object sender, EventArgs e)
        {
            

                }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              

            if (txtbox_username.Text == "admin" && txtbox_password.Text == "admin")
            {
                MessageBox.Show("Welcome to Administrator Panel");
                userform ap = new userform();
                ap.Show();
                this.Hide();
            }
           

            else
            {
               

                MessageBox.Show("Something is wrong. try again \n Atttempts done: " + attempts + " out of 3");
                attempts++;

                txtbox_password.Text = "";
            }
            if (attempts == 4)
            {
                MessageBox.Show("Maximum attempts has reached. \nThe program will close");
                Application.Exit();



                txtbox_password.Text = "";
            }
            txtbox_password.Focus(); //keycode enter
            } //keycode enter close bracket
        }

       

        

       

       

        

               /* catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
               
            }
            con.Close();
        }*/
    }
}

