namespace loginformPOS
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbooks1 = new loginformPOS.addbooks();
            this.btn_UserManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Maintenance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userformclose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usermanagement1 = new loginformPOS.usermanagement();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addbooks1);
            this.panel1.Controls.Add(this.btn_UserManagement);
            this.panel1.Controls.Add(this.btn_Maintenance);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.usermanagement1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 669);
            this.panel1.TabIndex = 0;
            // 
            // addbooks1
            // 
            this.addbooks1.Location = new System.Drawing.Point(0, 104);
            this.addbooks1.Name = "addbooks1";
            this.addbooks1.Size = new System.Drawing.Size(905, 565);
            this.addbooks1.TabIndex = 7;
            this.addbooks1.Load += new System.EventHandler(this.addbooks1_Load);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.btn_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.btn_UserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UserManagement.BorderRadius = 0;
            this.btn_UserManagement.ButtonText = "Borrowed Book History";
            this.btn_UserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserManagement.DisabledColor = System.Drawing.Color.Gray;
            this.btn_UserManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_UserManagement.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_UserManagement.Iconimage")));
            this.btn_UserManagement.Iconimage_right = null;
            this.btn_UserManagement.Iconimage_right_Selected = null;
            this.btn_UserManagement.Iconimage_Selected = null;
            this.btn_UserManagement.IconMarginLeft = 0;
            this.btn_UserManagement.IconMarginRight = 0;
            this.btn_UserManagement.IconRightVisible = true;
            this.btn_UserManagement.IconRightZoom = 0D;
            this.btn_UserManagement.IconVisible = true;
            this.btn_UserManagement.IconZoom = 60D;
            this.btn_UserManagement.IsTab = false;
            this.btn_UserManagement.Location = new System.Drawing.Point(450, 48);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.btn_UserManagement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(191)))), ((int)(((byte)(59)))));
            this.btn_UserManagement.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_UserManagement.selected = false;
            this.btn_UserManagement.Size = new System.Drawing.Size(455, 59);
            this.btn_UserManagement.TabIndex = 4;
            this.btn_UserManagement.Text = "Borrowed Book History";
            this.btn_UserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UserManagement.Textcolor = System.Drawing.Color.White;
            this.btn_UserManagement.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserManagement.Click += new System.EventHandler(this.btn_UserManagement_Click_1);
            // 
            // btn_Maintenance
            // 
            this.btn_Maintenance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btn_Maintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btn_Maintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maintenance.BorderRadius = 0;
            this.btn_Maintenance.ButtonText = "Maintenance";
            this.btn_Maintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maintenance.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Maintenance.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Maintenance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Maintenance.Iconimage")));
            this.btn_Maintenance.Iconimage_right = null;
            this.btn_Maintenance.Iconimage_right_Selected = null;
            this.btn_Maintenance.Iconimage_Selected = null;
            this.btn_Maintenance.IconMarginLeft = 0;
            this.btn_Maintenance.IconMarginRight = 0;
            this.btn_Maintenance.IconRightVisible = true;
            this.btn_Maintenance.IconRightZoom = 0D;
            this.btn_Maintenance.IconVisible = true;
            this.btn_Maintenance.IconZoom = 60D;
            this.btn_Maintenance.IsTab = false;
            this.btn_Maintenance.Location = new System.Drawing.Point(1, 48);
            this.btn_Maintenance.Name = "btn_Maintenance";
            this.btn_Maintenance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btn_Maintenance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btn_Maintenance.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Maintenance.selected = false;
            this.btn_Maintenance.Size = new System.Drawing.Size(455, 59);
            this.btn_Maintenance.TabIndex = 1;
            this.btn_Maintenance.Text = "Maintenance";
            this.btn_Maintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Maintenance.Textcolor = System.Drawing.Color.White;
            this.btn_Maintenance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maintenance.Click += new System.EventHandler(this.btn_Maintenance_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.userformclose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 48);
            this.panel2.TabIndex = 0;
            // 
            // userformclose
            // 
            this.userformclose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userformclose.AutoSize = true;
            this.userformclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userformclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userformclose.Location = new System.Drawing.Point(859, 9);
            this.userformclose.Name = "userformclose";
            this.userformclose.Size = new System.Drawing.Size(26, 25);
            this.userformclose.TabIndex = 4;
            this.userformclose.Text = "X";
            this.userformclose.Click += new System.EventHandler(this.userformclose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Panel";
            // 
            // usermanagement1
            // 
            this.usermanagement1.Location = new System.Drawing.Point(0, 104);
            this.usermanagement1.Name = "usermanagement1";
            this.usermanagement1.Size = new System.Drawing.Size(905, 565);
            this.usermanagement1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Maintenance;
        private Bunifu.Framework.UI.BunifuFlatButton btn_UserManagement;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label userformclose;
        private usermanagement usermanagement1;
        private addbooks addbooks1;
    }
}