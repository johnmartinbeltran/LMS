using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace loginformPOS
{
    class DBaseconnection // CLASS
    {
        public OleDbConnection con;
        string ConString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Documents\New folder\loginformPOS\db_database.mdb");


        public DBaseconnection()
        {
            try
            {
                con = new OleDbConnection(ConString);
                con.Open();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void addbookstolistview(ListView listview1) // ADDING DATA FROM DATABASE TO LISTVIEW
        {
            OleDbCommand sc = new OleDbCommand("SELECT * FROM ListBooks ORDER BY Accession ", con);
            sc.ExecuteNonQuery();
            try
            {



                OleDbDataReader dr = sc.ExecuteReader();
                listview1.Items.Clear();

                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["Accession"].ToString());
                    item.SubItems.Add(dr["BookID"].ToString());
                    item.SubItems.Add(dr["BookTitle"].ToString());
                    item.SubItems.Add(dr["AuthorName"].ToString());


                    listview1.Items.Add(item);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public void listviewtotext(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, ListView listView1) // DATA SHOW TO TEXTBOX
        {
            string Accession = listView1.SelectedItems[0].SubItems[0].Text;
            string BookID = listView1.SelectedItems[0].SubItems[1].Text;
            string BookTitle = listView1.SelectedItems[0].SubItems[2].Text;
            string AuthorName = listView1.SelectedItems[0].SubItems[3].Text;


            textBox1.Text = Accession;
            textBox2.Text = BookID;
            textBox3.Text = BookTitle;
            textBox4.Text = AuthorName;

        }
        public void listviewtobookname(TextBox txt_Bname, ListView listView1)
        {
            string BookTitle = listView1.SelectedItems[0].SubItems[2].Text;
            txt_Bname.Text = BookTitle;
        }

        public void insertdata(string textBox1, string textBox2, string textBox3, string textBox4, ListView listView1)  //  ADMIN ADD/INSERT BOOKS
        {

            if (textBox1 == "" || textBox2 == "" || textBox3 == "" || textBox4 == "")
            {
                MessageBox.Show("Fill up all information");
            }

            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM ListBooks WHERE Accession= @Accession", con); //check if data is already existed
                    cmd.Parameters.AddWithValue("@Accession", textBox1);
                    cmd.Parameters.AddWithValue("@BookID", textBox2);

                    OleDbDataReader dr = cmd.ExecuteReader();


                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            MessageBox.Show(" This book " + dr[0].ToString() + " is already existed"); //column dr[0].ToString()

                        }

                    }

                    else
                    {
                        dr.Close();


                        OleDbCommand sc = new OleDbCommand("insert into ListBooks VALUES ('" + textBox1 + "','" + textBox2 + "','" + textBox3 + "','" + textBox4 + "')", con);
                        sc.ExecuteNonQuery();

                        DialogResult dd = MessageBox.Show("Do you want to Insert?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dd == DialogResult.Yes)
                        {
                            MessageBox.Show("Inserted Sucessfully");
                            addbookstolistview(listView1);
                        }
                        else
                        {

                        }
                    }

                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                con.Close();

            }




        }



        public void deletebooks(string textBox1, string textBox2, string textBox3, string textBox4, ListView listView1) //  ADMIN DELETE BOOKS
        {
            if (textBox1 == "" || textBox2 == "" || textBox3 == "" || textBox4 == "")
            {
                MessageBox.Show("Select Books you want to delete!");
            }
            else
            {


                con.Open();
                OleDbCommand cm = new OleDbCommand("DELETE FROM ListBooks WHERE Accession = @Accession", con);

                cm.Parameters.AddWithValue("@Accession", listView1.SelectedItems[0].Text);

                cm.Parameters.AddWithValue("@BookID", listView1.SelectedItems[0].Text);
                cm.Parameters.AddWithValue("@BookTitle", listView1.SelectedItems[0].Text);
                cm.Parameters.AddWithValue("@AuthorName", listView1.SelectedItems[0].Text);


                try
                {

                    cm.ExecuteNonQuery();
                    DialogResult dr = MessageBox.Show("Do you want to Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Deleted Successfully");
                        addbookstolistview(listView1);
                    }
                    else
                    {

                    }



                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();


            }
        }
        public void updatebooks(string textBox1, string textBox2, string textBox3, string textBox4, ListView listView1) //  ADMIN UPDATE BOOKS
        {

            if (textBox1 == "" || textBox2 == "" || textBox3 == "" || textBox4 == "")
            {
                MessageBox.Show("Fill up all information");
            }
            else
            {

                try
                {
                    con.Open();
                    OleDbCommand cm = new OleDbCommand("update ListBooks set Accession = @Accession, BookID = @BookID, BookTitle = @BookTitle, AuthorName = @AuthorName WHERE Accession = @a1", con);
                    cm.Parameters.AddWithValue("@Accession", listView1.SelectedItems[0].Text = textBox1);
                    cm.Parameters.AddWithValue("@BookID", listView1.SelectedItems[0].Text = textBox2);
                    cm.Parameters.AddWithValue("@BookTitle", listView1.SelectedItems[0].Text = textBox3);
                    cm.Parameters.AddWithValue("@AuthorName", listView1.SelectedItems[0].Text = textBox4);

                    cm.Parameters.AddWithValue("@a1", listView1.SelectedItems[0].Text = textBox1);


                    cm.ExecuteNonQuery();
                   DialogResult dr = MessageBox.Show( "Do you want to Update?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                   if (dr == DialogResult.Yes)
                   {
                       MessageBox.Show("Update Sucessfully");
                       addbookstolistview(listView1);
                   }
                   else
                   {
                   
                   }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }


        }

        public void issuereturnbooks(string txt_StudentNumber, string txt_Fname, string txt_Bname, DateTimePicker dt_borrow, ListView listView1) //USER BORROW BOOKS
        {
            if (txt_Fname == "")
            {
                MessageBox.Show("Fill up all information");
            }

            else
            {


                try
                {
                    con.Open();



                    OleDbCommand sc = new OleDbCommand("insert into BorrowedBooks VALUES ('" + txt_StudentNumber + "','" + txt_Fname + "','" + txt_Bname + "','" + dt_borrow.Value.Date.ToShortDateString() + "')", con);
                    sc.ExecuteNonQuery();

                    DialogResult dr = MessageBox.Show("Are you sure you want to borrow this book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Borrowed Books Successfully");
                        addbookstolistview(listView1);
                        
                    }
                    else
                    {

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                con.Close();
            }


        }

        public void issuereturndetails(ListView listview1) // ADMIN USER MANAGEMENT
        {

            OleDbCommand sc = new OleDbCommand("SELECT * FROM BorrowedBooks ORDER BY StudentID ", con);
            sc.ExecuteNonQuery();
            try
            {
                OleDbDataReader dr = sc.ExecuteReader();
                listview1.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["StudentID"].ToString());
                    item.SubItems.Add(dr["FirstName"].ToString());
                    item.SubItems.Add(dr["Books"].ToString());
                    item.SubItems.Add(dr["Date"].ToString());



                    listview1.Items.Add(item);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void listviewtotextbox(ListView listView1) // DATA SHOW TO TEXTBOX USER MANAGEMENT
        {

        }

    }


}