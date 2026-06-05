namespace PresntationLayerLic
{
    partial class frmLoginUrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUrs));
            this.lbExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserLogIn = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblUsrLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chBoxRememberme = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbExit.Location = new System.Drawing.Point(781, -1);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(20, 19);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 450);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserLogIn
            // 
            this.txtUserLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserLogIn.Location = new System.Drawing.Point(525, 165);
            this.txtUserLogIn.Name = "txtUserLogIn";
            this.txtUserLogIn.Size = new System.Drawing.Size(148, 20);
            this.txtUserLogIn.TabIndex = 2;
            this.txtUserLogIn.TextChanged += new System.EventHandler(this.txtUserLogIn_TextChanged);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.Location = new System.Drawing.Point(525, 211);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(148, 20);
            this.txtPasswordLogin.TabIndex = 3;
            this.txtPasswordLogin.TextChanged += new System.EventHandler(this.txtPasswordLogin_TextChanged);
            // 
            // lblUsrLogIn
            // 
            this.lblUsrLogIn.AutoSize = true;
            this.lblUsrLogIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrLogIn.Location = new System.Drawing.Point(420, 163);
            this.lblUsrLogIn.Name = "lblUsrLogIn";
            this.lblUsrLogIn.Size = new System.Drawing.Size(94, 19);
            this.lblUsrLogIn.TabIndex = 4;
            this.lblUsrLogIn.Text = "Usernaem :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password :";
            // 
            // chBoxRememberme
            // 
            this.chBoxRememberme.AutoSize = true;
            this.chBoxRememberme.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxRememberme.Location = new System.Drawing.Point(525, 237);
            this.chBoxRememberme.Name = "chBoxRememberme";
            this.chBoxRememberme.Size = new System.Drawing.Size(126, 20);
            this.chBoxRememberme.TabIndex = 6;
            this.chBoxRememberme.Text = "Remember me";
            this.chBoxRememberme.UseVisualStyleBackColor = true;
            this.chBoxRememberme.CheckedChanged += new System.EventHandler(this.chBoxRememberme_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(596, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(525, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmLoginUrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chBoxRememberme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsrLogIn);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUserLogIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginUrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginUrs";
            this.Load += new System.EventHandler(this.frmLoginUrs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserLogIn;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblUsrLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBoxRememberme;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}