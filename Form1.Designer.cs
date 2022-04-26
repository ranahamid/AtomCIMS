using System;

namespace Atom_CIMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_login = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exitbutton4 = new System.Windows.Forms.Button();
            this.Helpbutton3 = new System.Windows.Forms.Button();
            this.Aboutbutton2 = new System.Windows.Forms.Button();
            this.groupBox4_browser = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox5_log = new System.Windows.Forms.GroupBox();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.textBox2_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3_logIn = new System.Windows.Forms.Button();
            this.groupBox3_logo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5_help = new System.Windows.Forms.GroupBox();
            this.button3_helpOk = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.webBrowser2_help = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1_Tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox4_browser.SuspendLayout();
            this.groupBox5_log.SuspendLayout();
            this.groupBox3_logo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5_help.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1_Tray.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_login
            // 
            this.button1_login.Location = new System.Drawing.Point(188, 3);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(80, 30);
            this.button1_login.TabIndex = 26;
            this.button1_login.UseVisualStyleBackColor = true;
            this.button1_login.Click += new System.EventHandler(this.button1_login_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(18, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(404, 238);
            this.webBrowser1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 291);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crdentials Details";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "Web";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exitbutton4
            // 
            this.Exitbutton4.Location = new System.Drawing.Point(368, 3);
            this.Exitbutton4.Name = "Exitbutton4";
            this.Exitbutton4.Size = new System.Drawing.Size(80, 30);
            this.Exitbutton4.TabIndex = 29;
            this.Exitbutton4.Text = "Close";
            this.Exitbutton4.UseVisualStyleBackColor = true;
            this.Exitbutton4.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Helpbutton3
            // 
            this.Helpbutton3.Location = new System.Drawing.Point(98, 3);
            this.Helpbutton3.Name = "Helpbutton3";
            this.Helpbutton3.Size = new System.Drawing.Size(80, 30);
            this.Helpbutton3.TabIndex = 28;
            this.Helpbutton3.Text = "Help";
            this.Helpbutton3.UseVisualStyleBackColor = true;
            this.Helpbutton3.Click += new System.EventHandler(this.Helpbutton3_Click);
            // 
            // Aboutbutton2
            // 
            this.Aboutbutton2.Location = new System.Drawing.Point(12, 3);
            this.Aboutbutton2.Name = "Aboutbutton2";
            this.Aboutbutton2.Size = new System.Drawing.Size(80, 30);
            this.Aboutbutton2.TabIndex = 27;
            this.Aboutbutton2.Text = "About";
            this.Aboutbutton2.UseVisualStyleBackColor = true;
            this.Aboutbutton2.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox4_browser
            // 
            this.groupBox4_browser.Controls.Add(this.tabControl1);
            this.groupBox4_browser.Location = new System.Drawing.Point(20, 44);
            this.groupBox4_browser.Name = "groupBox4_browser";
            this.groupBox4_browser.Size = new System.Drawing.Size(430, 276);
            this.groupBox4_browser.TabIndex = 35;
            this.groupBox4_browser.TabStop = false;
            this.groupBox4_browser.Text = "Domains";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Location = new System.Drawing.Point(6, 15);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 256);
            this.tabControl1.TabIndex = 32;
            // 
            // groupBox5_log
            // 
            this.groupBox5_log.Controls.Add(this.textBox1_password);
            this.groupBox5_log.Controls.Add(this.textBox2_username);
            this.groupBox5_log.Controls.Add(this.label2);
            this.groupBox5_log.Controls.Add(this.label1);
            this.groupBox5_log.Controls.Add(this.button3_logIn);
            this.groupBox5_log.Location = new System.Drawing.Point(22, 48);
            this.groupBox5_log.Name = "groupBox5_log";
            this.groupBox5_log.Size = new System.Drawing.Size(427, 170);
            this.groupBox5_log.TabIndex = 36;
            this.groupBox5_log.TabStop = false;
            this.groupBox5_log.Text = "Log In ";
            this.groupBox5_log.Visible = false;
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(166, 72);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.Size = new System.Drawing.Size(235, 20);
            this.textBox1_password.TabIndex = 4;
            this.textBox1_password.UseSystemPasswordChar = true;
            this.textBox1_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_password_KeyDown);
            // 
            // textBox2_username
            // 
            this.textBox2_username.Location = new System.Drawing.Point(166, 33);
            this.textBox2_username.Name = "textBox2_username";
            this.textBox2_username.Size = new System.Drawing.Size(235, 20);
            this.textBox2_username.TabIndex = 3;
            this.textBox2_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_username_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // button3_logIn
            // 
            this.button3_logIn.Location = new System.Drawing.Point(326, 116);
            this.button3_logIn.Name = "button3_logIn";
            this.button3_logIn.Size = new System.Drawing.Size(75, 23);
            this.button3_logIn.TabIndex = 0;
            this.button3_logIn.Text = "Log In";
            this.button3_logIn.UseVisualStyleBackColor = true;
            this.button3_logIn.Click += new System.EventHandler(this.button3_logIn_Click);
            // 
            // groupBox3_logo
            // 
            this.groupBox3_logo.Controls.Add(this.label3);
            this.groupBox3_logo.Controls.Add(this.groupBox4);
            this.groupBox3_logo.Location = new System.Drawing.Point(23, 48);
            this.groupBox3_logo.Name = "groupBox3_logo";
            this.groupBox3_logo.Size = new System.Drawing.Size(428, 293);
            this.groupBox3_logo.TabIndex = 37;
            this.groupBox3_logo.TabStop = false;
            this.groupBox3_logo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Credentials and information management system";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(90, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 102);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5_help
            // 
            this.groupBox5_help.Controls.Add(this.button3_helpOk);
            this.groupBox5_help.Controls.Add(this.groupBox5);
            this.groupBox5_help.Location = new System.Drawing.Point(12, 46);
            this.groupBox5_help.Name = "groupBox5_help";
            this.groupBox5_help.Size = new System.Drawing.Size(439, 295);
            this.groupBox5_help.TabIndex = 38;
            this.groupBox5_help.TabStop = false;
            this.groupBox5_help.Text = "Help";
            this.groupBox5_help.Visible = false;
            // 
            // button3_helpOk
            // 
            this.button3_helpOk.Location = new System.Drawing.Point(336, 264);
            this.button3_helpOk.Name = "button3_helpOk";
            this.button3_helpOk.Size = new System.Drawing.Size(75, 23);
            this.button3_helpOk.TabIndex = 1;
            this.button3_helpOk.Text = "Ok";
            this.button3_helpOk.UseVisualStyleBackColor = true;
            this.button3_helpOk.Click += new System.EventHandler(this.button3_helpOk_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.webBrowser2_help);
            this.groupBox5.Location = new System.Drawing.Point(7, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 239);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // webBrowser2_help
            // 
            this.webBrowser2_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2_help.Location = new System.Drawing.Point(3, 16);
            this.webBrowser2_help.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2_help.Name = "webBrowser2_help";
            this.webBrowser2_help.Size = new System.Drawing.Size(408, 220);
            this.webBrowser2_help.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Atom AP CIMS";
            this.notifyIcon1.BalloonTipTitle = "Atom AP CIMS";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1_Tray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Atom AP CIMS";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1_Tray
            // 
            this.contextMenuStrip1_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1_Tray.Name = "contextMenuStrip1_Tray";
            this.contextMenuStrip1_Tray.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Helpbutton3);
            this.panel1.Controls.Add(this.Exitbutton4);
            this.panel1.Controls.Add(this.Aboutbutton2);
            this.panel1.Controls.Add(this.button1_login);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 41);
            this.panel1.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(459, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5_help);
            this.Controls.Add(this.groupBox3_logo);
            this.Controls.Add(this.groupBox5_log);
            this.Controls.Add(this.groupBox4_browser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atom CIMS";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4_browser.ResumeLayout(false);
            this.groupBox5_log.ResumeLayout(false);
            this.groupBox5_log.PerformLayout();
            this.groupBox3_logo.ResumeLayout(false);
            this.groupBox3_logo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5_help.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStrip1_Tray.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exitbutton4;
        private System.Windows.Forms.Button Helpbutton3;
        private System.Windows.Forms.Button Aboutbutton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4_browser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox5_log;
        private System.Windows.Forms.Button button3_logIn;
        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.TextBox textBox2_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3_logo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5_help;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.WebBrowser webBrowser2_help;
        private System.Windows.Forms.Button button3_helpOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_Tray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;

    }
}

