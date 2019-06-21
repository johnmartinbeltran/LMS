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
    public partial class registrationform : Form
    {

        public registrationform()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Desktop\loginformPOS\loginformPOS\db_database.mdb");
        DBaseconnection dbc = new DBaseconnection();
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (Opacity == 100)
            {
                timer1.Stop();
            }
        }

        private void registrationform_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void btn_ChooseImage_Click(object sender, EventArgs e)
        {
/*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;
                string strfilename = ofd.FileName;
                textBox7.Text = strfilename;

    
            }*/
            

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_studentnumber.Text == "" || txt_fname.Text == "" || txt_lname.Text == "" || txt_password.Text == "" || txt_age.Text == "" || txt_address.Text == "" || txt_contactnumber.Text == "")
            {
                MessageBox.Show("Fill up all information");
            }
            else
            {
                    con.Open();
                    String newcon = "insert into DBUsers VALUES ('" + txt_studentnumber.Text + "', '" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_password.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(newcon, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successfully");
                    this.Hide();
                    clear();
           
            }
            con.Close();
            }
                void clear()
                {
                txt_studentnumber.Text = txt_fname.Text = txt_lname.Text = txt_password.Text = txt_age.Text = txt_address.Text = cb_gender.Text = txt_contactnumber.Text = "";
        }
        

        private void studentnumber_keypress(object sender, KeyPressEventArgs e)
        {
          
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_fnam_keypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_lname_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_age_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cnumber_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_pass_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_gender_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
