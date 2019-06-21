namespace loginformPOS
{
    partial class UserSeachbooks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BorrowBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bname = new System.Windows.Forms.TextBox();
            this.dt_borrow = new System.Windows.Forms.DateTimePicker();
            this.btn_availability = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Borrow Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 41);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(706, 632);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Accession";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book ID";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Book Title";
            this.columnHeader3.Width = 280;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Author Name";
            this.columnHeader4.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Borrow Date";
            // 
            // btn_BorrowBook
            // 
            this.btn_BorrowBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_BorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_BorrowBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BorrowBook.BorderRadius = 0;
            this.btn_BorrowBook.ButtonText = "Borrow Book";
            this.btn_BorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BorrowBook.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BorrowBook.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BorrowBook.Iconimage = null;
            this.btn_BorrowBook.Iconimage_right = null;
            this.btn_BorrowBook.Iconimage_right_Selected = null;
            this.btn_BorrowBook.Iconimage_Selected = null;
            this.btn_BorrowBook.IconMarginLeft = 10;
            this.btn_BorrowBook.IconMarginRight = 0;
            this.btn_BorrowBook.IconRightVisible = true;
            this.btn_BorrowBook.IconRightZoom = 0D;
            this.btn_BorrowBook.IconVisible = true;
            this.btn_BorrowBook.IconZoom = 90D;
            this.btn_BorrowBook.IsTab = false;
            this.btn_BorrowBook.Location = new System.Drawing.Point(735, 492);
            this.btn_BorrowBook.Name = "btn_BorrowBook";
            this.btn_BorrowBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_BorrowBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_BorrowBook.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BorrowBook.selected = false;
            this.btn_BorrowBook.Size = new System.Drawing.Size(228, 38);
            this.btn_BorrowBook.TabIndex = 13;
            this.btn_BorrowBook.Text = "Borrow Book";
            this.btn_BorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BorrowBook.Textcolor = System.Drawing.Color.White;
            this.btn_BorrowBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrowBook.Click += new System.EventHandler(this.btn_BorrowBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Student Number";
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentNumber.Location = new System.Drawing.Point(750, 164);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.Size = new System.Drawing.Size(200, 24);
            this.txt_StudentNumber.TabIndex = 17;
            this.txt_StudentNumber.TextChanged += new System.EventHandler(this.txt_StudentNumber_TextChanged);
            this.txt_StudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_snumber_keypress);
            // 
            // txt_Fname
            // 
            this.txt_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.Location = new System.Drawing.Point(750, 247);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(200, 24);
            this.txt_Fname.TabIndex = 19;
            this.txt_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fname_keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Book Name";
            // 
            // txt_Bname
            // 
            this.txt_Bname.Enabled = false;
            this.txt_Bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bname.Location = new System.Drawing.Point(750, 326);
            this.txt_Bname.Name = "txt_Bname";
            this.txt_Bname.Size = new System.Drawing.Size(200, 24);
            this.txt_Bname.TabIndex = 21;
            this.txt_Bname.TextChanged += new System.EventHandler(this.txt_Bname_TextChanged);
            // 
            // dt_borrow
            // 
            this.dt_borrow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_borrow.CustomFormat = "yyyy-MM-dd";
            this.dt_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_borrow.Location = new System.Drawing.Point(750, 400);
            this.dt_borrow.Name = "dt_borrow";
            this.dt_borrow.Size = new System.Drawing.Size(94, 20);
            this.dt_borrow.TabIndex = 22;
            this.dt_borrow.Value = new System.DateTime(2017, 11, 19, 0, 0, 0, 0);
            // 
            // btn_availability
            // 
            this.btn_availability.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_availability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_availability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_availability.BorderRadius = 0;
            this.btn_availability.ButtonText = "Generate Available Books";
            this.btn_availability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_availability.DisabledColor = System.Drawing.Color.Gray;
            this.btn_availability.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_availability.Iconimage = null;
            this.btn_availability.Iconimage_right = null;
            this.btn_availability.Iconimage_right_Selected = null;
            this.btn_availability.Iconimage_Selected = null;
            this.btn_availability.IconMarginLeft = 10;
            this.btn_availability.IconMarginRight = 0;
            this.btn_availability.IconRightVisible = true;
            this.btn_availability.IconRightZoom = 0D;
            this.btn_availability.IconVisible = true;
            this.btn_availability.IconZoom = 90D;
            this.btn_availability.IsTab = false;
            this.btn_availability.Location = new System.Drawing.Point(735, 448);
            this.btn_availability.Name = "btn_availability";
            this.btn_availability.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_availability.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_availability.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_availability.selected = false;
            this.btn_availability.Size = new System.Drawing.Size(228, 38);
            this.btn_availability.TabIndex = 25;
            this.btn_availability.Text = "Generate Available Books";
            this.btn_availability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_availability.Textcolor = System.Drawing.Color.White;
            this.btn_availability.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_availability.Click += new System.EventHandler(this.btn_availability_Click);
            // 
            // UserSeachbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_availability);
            this.Controls.Add(this.dt_borrow);
            this.Controls.Add(this.txt_Bname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_StudentNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_BorrowBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserSeachbooks";
            this.Size = new System.Drawing.Size(1051, 682);
            this.Load += new System.EventHandler(this.UserSeachbooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BorrowBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Bname;
        private System.Windows.Forms.DateTimePicker dt_borrow;
        private Bunifu.Framework.UI.BunifuFlatButton btn_availability;
    }
}
