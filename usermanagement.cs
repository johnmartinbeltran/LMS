using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace loginformPOS
{
    public partial class usermanagement : UserControl
    {
        

        public usermanagement()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Documents\New folder\loginformPOS\db_database.mdb");
        
        DBaseconnection dbc = new DBaseconnection();
        private void usermanagement_Load(object sender, EventArgs e)
        {
            dbc.issuereturndetails(listView1);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand sc = new OleDbCommand("SELECT * FROM BorrowedBooks ORDER BY StudentID ", con);
            sc.ExecuteNonQuery();
            try
            {
                
                OleDbDataReader dr = sc.ExecuteReader();
                listView1.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["StudentID"].ToString());
                    item.SubItems.Add(dr["FirstName"].ToString());
                    item.SubItems.Add(dr["Books"].ToString());
                    item.SubItems.Add(dr["Date"].ToString());



                    listView1.Items.Add(item);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
