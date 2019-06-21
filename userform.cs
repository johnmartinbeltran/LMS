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
    public partial class userform : Form
    {
        public userform()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Documents\New folder\loginformPOS\db_database.mdb");
        
        DBaseconnection dbc = new DBaseconnection();
        

        private void userform_Load(object sender, EventArgs e)
        {

          //  dbc.listofbooks(listview1);


          timer1.Start();
        }

        private void userformclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_searchbooks_Click(object sender, EventArgs e)
        {
            userSeachbooks1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 100)
            {
                timer1.Stop();
            }
            
    }

       

        

        private void btn_borrowedbooks_Click(object sender, EventArgs e)
        {

            userborrowed1.BringToFront();
         
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {      
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();   
            
        }

        private void addbooks1_Load(object sender, EventArgs e)
        {
            
        }

        private void addbooks1_Click(object sender, EventArgs e)
        {
            btn_adminmaintenance.BringToFront();
        }

        private void btn_adminmaintenance_Click(object sender, EventArgs e)
        {
            systemmaintenance.BringToFront();
        }

        private void usermanagement1_Load(object sender, EventArgs e)
        {

        }

        private void usermanagement1_Click(object sender, EventArgs e)
        {
            btn_history.BringToFront();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            usermanagement1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userborrowed1_Load(object sender, EventArgs e)
        {

        }
    }
}
