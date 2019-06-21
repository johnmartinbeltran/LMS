namespace loginformPOS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbox_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.FormClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 46);
            this.panel1.TabIndex = 0;
            // 
            // FormClose
            // 
            this.FormClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.FormClose.AutoSize = true;
            this.FormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormClose.Location = new System.Drawing.Point(324, 9);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(23, 25);
            this.FormClose.TabIndex = 1;
            this.FormClose.Text = "x";
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Form";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_username.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_username.HintText = "";
            this.txtbox_username.isPassword = false;
            this.txtbox_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtbox_username.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtbox_username.LineThickness = 4;
            this.txtbox_username.Location = new System.Drawing.Point(32, 245);
            this.txtbox_username.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(278, 44);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.Text = "Student ID";
            this.txtbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_username.Enter += new System.EventHandler(this.txtbox_username_Enter);
            this.txtbox_username.Leave += new System.EventHandler(this.txtbox_username_Leave);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_password.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_password.HintText = "";
            this.txtbox_password.isPassword = false;
            this.txtbox_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtbox_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtbox_password.LineThickness = 4;
            this.txtbox_password.Location = new System.Drawing.Point(32, 309);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(278, 44);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.Text = "Password";
            this.txtbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_password.Enter += new System.EventHandler(this.txtbox_password_Enter);
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            this.txtbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_keypress);
            this.txtbox_password.Leave += new System.EventHandler(this.txtbox_password_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Library Management System";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 9;
            this.bunifuElipse2.TargetControl = this.btn_login;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 7;
            this.btn_login.ButtonText = "                           Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_login.Iconimage")));
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(32, 373);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(278, 51);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "                           Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.line.LineThickness = 1;
            this.line.Location = new System.Drawing.Point(45, 168);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(265, 22);
            this.line.TabIndex = 5;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.btn_Register;
            // 
            // btn_Register
            // 
            this.btn_Register.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Register.BorderRadius = 7;
            this.btn_Register.ButtonText = "                        Register";
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Register.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Register.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Register.Iconimage")));
            this.btn_Register.Iconimage_right = null;
            this.btn_Register.Iconimage_right_Selected = null;
            this.btn_Register.Iconimage_Selected = null;
            this.btn_Register.IconMarginLeft = 0;
            this.btn_Register.IconMarginRight = 0;
            this.btn_Register.IconRightVisible = true;
            this.btn_Register.IconRightZoom = 0D;
            this.btn_Register.IconVisible = true;
            this.btn_Register.IconZoom = 90D;
            this.btn_Register.IsTab = false;
            this.btn_Register.Location = new System.Drawing.Point(32, 435);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_Register.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Register.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Register.selected = false;
            this.btn_Register.Size = new System.Drawing.Size(278, 48);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "                        Register";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Register.Textcolor = System.Drawing.Color.White;
            this.btn_Register.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(359, 521);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Register;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}

