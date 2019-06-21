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
    public partial class addbooks : UserControl
    {


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ACER\Desktop\loginformPOS\loginformPOS\db_database.mdb");
        
        DBaseconnection dbc = new DBaseconnection();

        public addbooks()
        {
            InitializeComponent();
        }

        
    
        
        private void addbooks_Load(object sender, EventArgs e)
        {
            
                dbc.addbookstolistview(listView1);
              
                
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            dbc.listviewtotext(textBox1, textBox2, textBox3, textBox4,  listView1);

        }
        

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            dbc.insertdata(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, listView1);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
         

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
             dbc.deletebooks(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, listView1);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
          
        }
        private void btn_update_Click_1(object sender, EventArgs e)
        {
           dbc.updatebooks(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,  listView1);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
          
        }

        private void txt_accession_keypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuFlatButton1_MouseClick(object sender, MouseEventArgs e)
        {
           
        
       

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

      

        
    }

    
    }


    