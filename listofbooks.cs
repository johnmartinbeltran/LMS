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
    public partial class Userborrowed : UserControl
    {
        public Userborrowed()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Documents\New folder\loginformPOS\db_database.mdb");
        DBaseconnection dbc = new DBaseconnection();
        private void Userborrowed_Load(object sender, EventArgs e)
        {
            /* comboBox1.Items.Add("Books");
              comboBox1.Items.Add("Nonbooks");*/


            dbc.addbookstolistview(listView1);
        }

        private void txtbox_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_search.Text))
            {

                txtbox_search.Text = "Search...";
            }
        }

        private void txtbox_search_Enter(object sender, EventArgs e)
        {
            if (txtbox_search.Text == "Search...")
            {
                txtbox_search.Text = "";
            }
        }

        private void txtbox_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    con.Open();
                    listView1.Items.Clear();

                    OleDbCommand sc = new OleDbCommand("SELECT * FROM Books ORDER BY Accession", con);
                    sc.ExecuteNonQuery();
                    OleDbDataReader dr = sc.ExecuteReader();


                    while (dr.Read())
                    {

                        ListViewItem item = new ListViewItem(dr["Accession"].ToString());
                        item.SubItems.Add(dr["BookID"].ToString());
                        item.SubItems.Add(dr["BookTitle"].ToString());
                        item.SubItems.Add(dr["AuthorName"].ToString());


                        listView1.Items.Add(item);

                    }
                    con.Close();
                    dr.Close();
                }



                else if (comboBox1.SelectedIndex == 1)
                {


                    con.Open();
                    listView1.Items.Clear();

                    OleDbCommand sc = new OleDbCommand("SELECT * FROM NonBooks ORDER BY Accession", con);
                    sc.ExecuteNonQuery();
                    OleDbDataReader dr = sc.ExecuteReader();


                    while (dr.Read())
                    {

                        ListViewItem item = new ListViewItem(dr["Accession"].ToString());
                        item.SubItems.Add(dr["BookID"].ToString());
                        item.SubItems.Add(dr["BookTitle"].ToString());
                        item.SubItems.Add(dr["AuthorName"].ToString());


                        listView1.Items.Add(item);

                    }
                    con.Close();
                }
                else if (comboBox1.SelectedIndex == 2)
                {



                    listView1.Items.Clear();
                    con.Open();
                    OleDbCommand sc = new OleDbCommand("SELECT * FROM ListBooks ORDER BY Accession", con);
                    sc.ExecuteNonQuery();
                    OleDbDataReader dr = sc.ExecuteReader();


                    while (dr.Read())
                    {

                        ListViewItem item = new ListViewItem(dr["Accession"].ToString());
                        item.SubItems.Add(dr["BookID"].ToString());
                        item.SubItems.Add(dr["BookTitle"].ToString());
                        item.SubItems.Add(dr["AuthorName"].ToString());


                        listView1.Items.Add(item);

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
         
            try
            {

                con.Open();
                OleDbCommand sc = new OleDbCommand("SELECT * FROM ListBooks WHERE BookID AND BookTitle Like '" + txtbox_search.Text + "%' ", con);
                sc.ExecuteNonQuery();

                OleDbDataReader dr = sc.ExecuteReader();
                listView1.Items.Clear();
                
                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["Accession"].ToString());
                    item.SubItems.Add(dr["BookID"].ToString());
                    item.SubItems.Add(dr["BookTitle"].ToString());
                    item.SubItems.Add(dr["AuthorName"].ToString());


                    listView1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}

