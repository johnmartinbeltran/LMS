namespace loginformPOS
{
    partial class usermanagement
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
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Borrowed Books History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 41);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(5, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(961, 589);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student Number";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Books";
            this.columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date ";
            this.columnHeader4.Width = 80;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.BorderRadius = 0;
            this.btn_refresh.ButtonText = "Refresh ";
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.DisabledColor = System.Drawing.Color.Gray;
            this.btn_refresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_refresh.Iconimage = null;
            this.btn_refresh.Iconimage_right = null;
            this.btn_refresh.Iconimage_right_Selected = null;
            this.btn_refresh.Iconimage_Selected = null;
            this.btn_refresh.IconMarginLeft = 0;
            this.btn_refresh.IconMarginRight = 0;
            this.btn_refresh.IconRightVisible = true;
            this.btn_refresh.IconRightZoom = 0D;
            this.btn_refresh.IconVisible = true;
            this.btn_refresh.IconZoom = 90D;
            this.btn_refresh.IsTab = false;
            this.btn_refresh.Location = new System.Drawing.Point(14, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(182, 27);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.Text = "Refresh ";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Textcolor = System.Drawing.Color.White;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // usermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "usermanagement";
            this.Size = new System.Drawing.Size(984, 682);
            this.Load += new System.EventHandler(this.usermanagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
    }
}
