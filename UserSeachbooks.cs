using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace loginformPOS
{
    public partial class UserSeachbooks : UserControl
    {

        public OleDbConnection con;
        DBaseconnection dbc = new DBaseconnection();
        public UserSeachbooks()
        {

            InitializeComponent();


        }
       
        private void UserSeachbooks_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            dbc.listviewtobookname(txt_Bname, listView1);
        }

        private void btn_BorrowBook_Click(object sender, EventArgs e)
        {

            dbc.issuereturnbooks(txt_StudentNumber.Text, txt_Fname.Text, txt_Bname.Text, dt_borrow,listView1);
        
    }

        private void txt_snumber_keypress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_fname_keypress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Bname_TextChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.ToString() == txt_Bname.Text)
            {
                txt_Bname.Modified = false;
            }
            
        }

        private void btn_availability_Click(object sender, EventArgs e)
        {
            dbc.addbookstolistview(listView1);
        }

        private void txt_StudentNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}