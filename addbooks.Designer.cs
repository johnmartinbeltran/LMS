namespace loginformPOS
{
    partial class addbooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 41);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "System Maintenance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accession";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Author Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(719, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 24);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accession_keypress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(719, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 24);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox3.Location = new System.Drawing.Point(719, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 24);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox4.Location = new System.Drawing.Point(716, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 24);
            this.textBox4.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 0;
            this.btn_add.ButtonText = "Add ";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = null;
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 90D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(716, 316);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(182, 35);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.BorderRadius = 0;
            this.btn_update.ButtonText = "Update ";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update.Iconimage = null;
            this.btn_update.Iconimage_right = null;
            this.btn_update.Iconimage_right_Selected = null;
            this.btn_update.Iconimage_Selected = null;
            this.btn_update.IconMarginLeft = 0;
            this.btn_update.IconMarginRight = 0;
            this.btn_update.IconRightVisible = true;
            this.btn_update.IconRightZoom = 0D;
            this.btn_update.IconVisible = true;
            this.btn_update.IconZoom = 90D;
            this.btn_update.IsTab = false;
            this.btn_update.Location = new System.Drawing.Point(716, 357);
            this.btn_update.Name = "btn_update";
            this.btn_update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update.selected = false;
            this.btn_update.Size = new System.Drawing.Size(182, 35);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update ";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.Textcolor = System.Drawing.Color.White;
            this.btn_update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delete.Iconimage = null;
            this.btn_delete.Iconimage_right = null;
            this.btn_delete.Iconimage_right_Selected = null;
            this.btn_delete.Iconimage_Selected = null;
            this.btn_delete.IconMarginLeft = 0;
            this.btn_delete.IconMarginRight = 0;
            this.btn_delete.IconRightVisible = true;
            this.btn_delete.IconRightZoom = 0D;
            this.btn_delete.IconVisible = true;
            this.btn_delete.IconZoom = 90D;
            this.btn_delete.IsTab = false;
            this.btn_delete.Location = new System.Drawing.Point(716, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(182, 35);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(18, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 635);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Accession";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book ID";
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
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Clear";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(716, 439);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(182, 35);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.Text = "Clear";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            this.bunifuFlatButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_MouseClick);
            // 
            // addbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "addbooks";
            this.Size = new System.Drawing.Size(984, 692);
            this.Load += new System.EventHandler(this.addbooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
