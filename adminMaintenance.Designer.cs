namespace loginformPOS
{
    partial class adminMaintenance
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbooks1 = new loginformPOS.addbooks();
            this.userborrowed1 = new loginformPOS.Userborrowed();
            this.userborrowed2 = new loginformPOS.Userborrowed();
            this.userSeachbooks1 = new loginformPOS.UserSeachbooks();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userSeachbooks1);
            this.panel1.Controls.Add(this.userborrowed2);
            this.panel1.Controls.Add(this.userborrowed1);
            this.panel1.Controls.Add(this.addbooks1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 565);
            this.panel1.TabIndex = 0;
            // 
            // addbooks1
            // 
            this.addbooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbooks1.Location = new System.Drawing.Point(0, 0);
            this.addbooks1.Name = "addbooks1";
            this.addbooks1.Size = new System.Drawing.Size(905, 555);
            this.addbooks1.TabIndex = 5;
            // 
            // userborrowed1
            // 
            this.userborrowed1.Location = new System.Drawing.Point(0, 0);
            this.userborrowed1.Name = "userborrowed1";
            this.userborrowed1.Size = new System.Drawing.Size(918, 737);
            this.userborrowed1.TabIndex = 6;
            // 
            // userborrowed2
            // 
            this.userborrowed2.Location = new System.Drawing.Point(0, 0);
            this.userborrowed2.Name = "userborrowed2";
            this.userborrowed2.Size = new System.Drawing.Size(918, 737);
            this.userborrowed2.TabIndex = 7;
            // 
            // userSeachbooks1
            // 
            this.userSeachbooks1.Location = new System.Drawing.Point(0, 0);
            this.userSeachbooks1.Name = "userSeachbooks1";
            this.userSeachbooks1.Size = new System.Drawing.Size(918, 737);
            this.userSeachbooks1.TabIndex = 8;
            // 
            // adminMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "adminMaintenance";
            this.Size = new System.Drawing.Size(905, 565);
            this.Load += new System.EventHandler(this.adminMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private addbooks addbooks1;
        private System.Windows.Forms.Panel panel2;
        private Userborrowed userborrowed1;
        private UserSeachbooks userSeachbooks1;
        private Userborrowed userborrowed2;
    }
}
