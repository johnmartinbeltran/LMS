namespace loginformPOS
{
    partial class userform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userform));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.userformclose = new System.Windows.Forms.Label();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_history = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_adminmaintenance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_borrowedbooks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_borrowbooks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userborrowed1 = new loginformPOS.Userborrowed();
            this.userSeachbooks1 = new loginformPOS.UserSeachbooks();
            this.systemmaintenance = new loginformPOS.addbooks();
            this.usermanagement1 = new loginformPOS.usermanagement();
            this.panel1.SuspendLayout();
            this.dashboardpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userformclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Panel";
            // 
            // userformclose
            // 
            this.userformclose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userformclose.AutoSize = true;
            this.userformclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userformclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userformclose.Location = new System.Drawing.Point(1204, 9);
            this.userformclose.Name = "userformclose";
            this.userformclose.Size = new System.Drawing.Size(26, 25);
            this.userformclose.TabIndex = 3;
            this.userformclose.Text = "X";
            this.userformclose.Click += new System.EventHandler(this.userformclose_Click);
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dashboardpanel.Controls.Add(this.userborrowed1);
            this.dashboardpanel.Controls.Add(this.userSeachbooks1);
            this.dashboardpanel.Controls.Add(this.systemmaintenance);
            this.dashboardpanel.Controls.Add(this.usermanagement1);
            this.dashboardpanel.Location = new System.Drawing.Point(246, 54);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(984, 692);
            this.dashboardpanel.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.bunifuGradientPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 480);
            this.panel3.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btn_history);
            this.bunifuGradientPanel2.Controls.Add(this.btn_adminmaintenance);
            this.bunifuGradientPanel2.Controls.Add(this.btn_logout);
            this.bunifuGradientPanel2.Controls.Add(this.btn_borrowedbooks);
            this.bunifuGradientPanel2.Controls.Add(this.btn_borrowbooks);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(245, 480);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // btn_history
            // 
            this.btn_history.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_history.BorderRadius = 0;
            this.btn_history.ButtonText = "History";
            this.btn_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history.DisabledColor = System.Drawing.Color.Gray;
            this.btn_history.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_history.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_history.Iconimage")));
            this.btn_history.Iconimage_right = null;
            this.btn_history.Iconimage_right_Selected = null;
            this.btn_history.Iconimage_Selected = null;
            this.btn_history.IconMarginLeft = 15;
            this.btn_history.IconMarginRight = 0;
            this.btn_history.IconRightVisible = true;
            this.btn_history.IconRightZoom = 0D;
            this.btn_history.IconVisible = true;
            this.btn_history.IconZoom = 75D;
            this.btn_history.IsTab = false;
            this.btn_history.Location = new System.Drawing.Point(3, 157);
            this.btn_history.Name = "btn_history";
            this.btn_history.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_history.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_history.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_history.selected = false;
            this.btn_history.Size = new System.Drawing.Size(245, 48);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_history.Textcolor = System.Drawing.Color.White;
            this.btn_history.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_adminmaintenance
            // 
            this.btn_adminmaintenance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_adminmaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_adminmaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminmaintenance.BorderRadius = 0;
            this.btn_adminmaintenance.ButtonText = "Admin Maintenance";
            this.btn_adminmaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminmaintenance.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminmaintenance.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminmaintenance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminmaintenance.Iconimage")));
            this.btn_adminmaintenance.Iconimage_right = null;
            this.btn_adminmaintenance.Iconimage_right_Selected = null;
            this.btn_adminmaintenance.Iconimage_Selected = null;
            this.btn_adminmaintenance.IconMarginLeft = 12;
            this.btn_adminmaintenance.IconMarginRight = 0;
            this.btn_adminmaintenance.IconRightVisible = true;
            this.btn_adminmaintenance.IconRightZoom = 0D;
            this.btn_adminmaintenance.IconVisible = true;
            this.btn_adminmaintenance.IconZoom = 80D;
            this.btn_adminmaintenance.IsTab = false;
            this.btn_adminmaintenance.Location = new System.Drawing.Point(0, 103);
            this.btn_adminmaintenance.Name = "btn_adminmaintenance";
            this.btn_adminmaintenance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_adminmaintenance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_adminmaintenance.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminmaintenance.selected = false;
            this.btn_adminmaintenance.Size = new System.Drawing.Size(245, 48);
            this.btn_adminmaintenance.TabIndex = 2;
            this.btn_adminmaintenance.Text = "Admin Maintenance";
            this.btn_adminmaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adminmaintenance.Textcolor = System.Drawing.Color.White;
            this.btn_adminmaintenance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminmaintenance.Click += new System.EventHandler(this.btn_adminmaintenance_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.ButtonText = "Logout";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_logout.Iconimage")));
            this.btn_logout.Iconimage_right = null;
            this.btn_logout.Iconimage_right_Selected = null;
            this.btn_logout.Iconimage_Selected = null;
            this.btn_logout.IconMarginLeft = 15;
            this.btn_logout.IconMarginRight = 0;
            this.btn_logout.IconRightVisible = true;
            this.btn_logout.IconRightZoom = 0D;
            this.btn_logout.IconVisible = true;
            this.btn_logout.IconZoom = 75D;
            this.btn_logout.IsTab = false;
            this.btn_logout.Location = new System.Drawing.Point(0, 207);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_logout.selected = false;
            this.btn_logout.Size = new System.Drawing.Size(245, 48);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logout.Textcolor = System.Drawing.Color.White;
            this.btn_logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_borrowedbooks
            // 
            this.btn_borrowedbooks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_borrowedbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_borrowedbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrowedbooks.BorderRadius = 0;
            this.btn_borrowedbooks.ButtonText = "Books";
            this.btn_borrowedbooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrowedbooks.DisabledColor = System.Drawing.Color.Gray;
            this.btn_borrowedbooks.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_borrowedbooks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_borrowedbooks.Iconimage")));
            this.btn_borrowedbooks.Iconimage_right = null;
            this.btn_borrowedbooks.Iconimage_right_Selected = null;
            this.btn_borrowedbooks.Iconimage_Selected = null;
            this.btn_borrowedbooks.IconMarginLeft = 10;
            this.btn_borrowedbooks.IconMarginRight = 0;
            this.btn_borrowedbooks.IconRightVisible = true;
            this.btn_borrowedbooks.IconRightZoom = 0D;
            this.btn_borrowedbooks.IconVisible = true;
            this.btn_borrowedbooks.IconZoom = 90D;
            this.btn_borrowedbooks.IsTab = false;
            this.btn_borrowedbooks.Location = new System.Drawing.Point(0, 0);
            this.btn_borrowedbooks.Name = "btn_borrowedbooks";
            this.btn_borrowedbooks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_borrowedbooks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_borrowedbooks.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_borrowedbooks.selected = false;
            this.btn_borrowedbooks.Size = new System.Drawing.Size(245, 48);
            this.btn_borrowedbooks.TabIndex = 0;
            this.btn_borrowedbooks.Text = "Books";
            this.btn_borrowedbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_borrowedbooks.Textcolor = System.Drawing.Color.White;
            this.btn_borrowedbooks.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowedbooks.Click += new System.EventHandler(this.btn_borrowedbooks_Click);
            // 
            // btn_borrowbooks
            // 
            this.btn_borrowbooks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_borrowbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_borrowbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrowbooks.BorderRadius = 0;
            this.btn_borrowbooks.ButtonText = "Borrow Books";
            this.btn_borrowbooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrowbooks.DisabledColor = System.Drawing.Color.Gray;
            this.btn_borrowbooks.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_borrowbooks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_borrowbooks.Iconimage")));
            this.btn_borrowbooks.Iconimage_right = null;
            this.btn_borrowbooks.Iconimage_right_Selected = null;
            this.btn_borrowbooks.Iconimage_Selected = null;
            this.btn_borrowbooks.IconMarginLeft = 12;
            this.btn_borrowbooks.IconMarginRight = 0;
            this.btn_borrowbooks.IconRightVisible = true;
            this.btn_borrowbooks.IconRightZoom = 0D;
            this.btn_borrowbooks.IconVisible = true;
            this.btn_borrowbooks.IconZoom = 80D;
            this.btn_borrowbooks.IsTab = false;
            this.btn_borrowbooks.Location = new System.Drawing.Point(0, 47);
            this.btn_borrowbooks.Name = "btn_borrowbooks";
            this.btn_borrowbooks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_borrowbooks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_borrowbooks.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_borrowbooks.selected = false;
            this.btn_borrowbooks.Size = new System.Drawing.Size(245, 48);
            this.btn_borrowbooks.TabIndex = 1;
            this.btn_borrowbooks.Text = "Borrow Books";
            this.btn_borrowbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_borrowbooks.Textcolor = System.Drawing.Color.White;
            this.btn_borrowbooks.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowbooks.Click += new System.EventHandler(this.btn_searchbooks_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 684);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::loginformPOS.Properties.Resources._585e4bcdcb11b227491c3396;
            this.pictureBox2.Location = new System.Drawing.Point(50, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userborrowed1
            // 
            this.userborrowed1.Location = new System.Drawing.Point(0, 0);
            this.userborrowed1.Name = "userborrowed1";
            this.userborrowed1.Size = new System.Drawing.Size(984, 737);
            this.userborrowed1.TabIndex = 0;
            this.userborrowed1.Load += new System.EventHandler(this.userborrowed1_Load);
            // 
            // userSeachbooks1
            // 
            this.userSeachbooks1.Location = new System.Drawing.Point(0, -1);
            this.userSeachbooks1.Name = "userSeachbooks1";
            this.userSeachbooks1.Size = new System.Drawing.Size(984, 682);
            this.userSeachbooks1.TabIndex = 1;
            // 
            // systemmaintenance
            // 
            this.systemmaintenance.Location = new System.Drawing.Point(0, 0);
            this.systemmaintenance.Name = "systemmaintenance";
            this.systemmaintenance.Size = new System.Drawing.Size(984, 692);
            this.systemmaintenance.TabIndex = 2;
            this.systemmaintenance.Load += new System.EventHandler(this.addbooks1_Load);
            this.systemmaintenance.Click += new System.EventHandler(this.addbooks1_Click);
            // 
            // usermanagement1
            // 
            this.usermanagement1.Location = new System.Drawing.Point(0, -1);
            this.usermanagement1.Name = "usermanagement1";
            this.usermanagement1.Size = new System.Drawing.Size(984, 682);
            this.usermanagement1.TabIndex = 3;
            this.usermanagement1.Load += new System.EventHandler(this.usermanagement1_Load);
            this.usermanagement1.Click += new System.EventHandler(this.usermanagement1_Click);
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 741);
            this.Controls.Add(this.dashboardpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userform";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dashboardpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userformclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel dashboardpanel;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private UserSeachbooks userSeachbooks1;
        private Userborrowed userborrowed1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_borrowedbooks;
        private Bunifu.Framework.UI.BunifuFlatButton btn_borrowbooks;
        private addbooks systemmaintenance;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminmaintenance;
        private Bunifu.Framework.UI.BunifuFlatButton btn_history;
        private usermanagement usermanagement1;
    }
}