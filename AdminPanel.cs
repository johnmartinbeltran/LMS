using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginformPOS
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
        }

        private void userformclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
       
        private void btn_UserManagement_Click_1(object sender, EventArgs e)
        {
           usermanagement1.BringToFront();
        }

        private void btn_Maintenance_Click(object sender, EventArgs e)
        {
           addbooks1.BringToFront();
        }

        private void userformclose_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();


        }

        private void addbooks1_Load(object sender, EventArgs e)
        {

        }

        
    }
  
}
