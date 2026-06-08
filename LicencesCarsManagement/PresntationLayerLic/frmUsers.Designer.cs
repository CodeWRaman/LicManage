namespace PresntationLayerLic
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHead = new System.Windows.Forms.Label();
            this.picManagUserIcon = new System.Windows.Forms.PictureBox();
            this.lbFilterTitel = new System.Windows.Forms.Label();
            this.cmBoxFilterUsers = new System.Windows.Forms.ComboBox();
            this.txtFilterUsers = new System.Windows.Forms.TextBox();
            this.btnAddUsr = new System.Windows.Forms.Button();
            this.dtGridUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbldtViwRecordTitle = new System.Windows.Forms.Label();
            this.btnCloseUserManage = new System.Windows.Forms.Button();
            this.lblRecordsUsersCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picManagUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHead.Location = new System.Drawing.Point(378, 203);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(181, 29);
            this.lblHead.TabIndex = 8;
            this.lblHead.Text = "Manage Users";
            // 
            // picManagUserIcon
            // 
            this.picManagUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picManagUserIcon.Image")));
            this.picManagUserIcon.Location = new System.Drawing.Point(383, 57);
            this.picManagUserIcon.Name = "picManagUserIcon";
            this.picManagUserIcon.Size = new System.Drawing.Size(167, 131);
            this.picManagUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManagUserIcon.TabIndex = 9;
            this.picManagUserIcon.TabStop = false;
            // 
            // lbFilterTitel
            // 
            this.lbFilterTitel.AutoSize = true;
            this.lbFilterTitel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterTitel.Location = new System.Drawing.Point(106, 252);
            this.lbFilterTitel.Name = "lbFilterTitel";
            this.lbFilterTitel.Size = new System.Drawing.Size(82, 22);
            this.lbFilterTitel.TabIndex = 10;
            this.lbFilterTitel.Text = "Filter By:";
            // 
            // cmBoxFilterUsers
            // 
            this.cmBoxFilterUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmBoxFilterUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxFilterUsers.FormattingEnabled = true;
            this.cmBoxFilterUsers.Items.AddRange(new object[] {
            "none",
            "User ID",
            "Person ID",
            "Full Name",
            "UserName",
            "Is Active"});
            this.cmBoxFilterUsers.Location = new System.Drawing.Point(194, 252);
            this.cmBoxFilterUsers.Name = "cmBoxFilterUsers";
            this.cmBoxFilterUsers.Size = new System.Drawing.Size(167, 21);
            this.cmBoxFilterUsers.TabIndex = 11;
            this.cmBoxFilterUsers.SelectedIndexChanged += new System.EventHandler(this.cmBoxFilterUsers_SelectedIndexChanged);
            // 
            // txtFilterUsers
            // 
            this.txtFilterUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterUsers.Location = new System.Drawing.Point(367, 254);
            this.txtFilterUsers.Name = "txtFilterUsers";
            this.txtFilterUsers.Size = new System.Drawing.Size(206, 20);
            this.txtFilterUsers.TabIndex = 12;
            this.txtFilterUsers.TextChanged += new System.EventHandler(this.txtFilterUsers_TextChanged);
            this.txtFilterUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterUsers_KeyPress);
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsr.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsr.Image")));
            this.btnAddUsr.Location = new System.Drawing.Point(737, 203);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(75, 71);
            this.btnAddUsr.TabIndex = 13;
            this.btnAddUsr.UseVisualStyleBackColor = true;
            // 
            // dtGridUsers
            // 
            this.dtGridUsers.AllowUserToAddRows = false;
            this.dtGridUsers.AllowUserToOrderColumns = true;
            this.dtGridUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Column1,
            this.FullName,
            this.Username,
            this.isActive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dtGridUsers.EnableHeadersVisualStyles = false;
            this.dtGridUsers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtGridUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtGridUsers.Location = new System.Drawing.Point(101, 280);
            this.dtGridUsers.Name = "dtGridUsers";
            this.dtGridUsers.Size = new System.Drawing.Size(711, 293);
            this.dtGridUsers.TabIndex = 14;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Person ID";
            this.Column1.Name = "Column1";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 50;
            this.FullName.Name = "FullName";
            this.FullName.Width = 230;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Is Active";
            this.isActive.Name = "isActive";
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbldtViwRecordTitle
            // 
            this.lbldtViwRecordTitle.AutoSize = true;
            this.lbldtViwRecordTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtViwRecordTitle.Location = new System.Drawing.Point(98, 587);
            this.lbldtViwRecordTitle.Name = "lbldtViwRecordTitle";
            this.lbldtViwRecordTitle.Size = new System.Drawing.Size(71, 17);
            this.lbldtViwRecordTitle.TabIndex = 15;
            this.lbldtViwRecordTitle.Text = "# Records:";
            // 
            // btnCloseUserManage
            // 
            this.btnCloseUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseUserManage.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserManage.Image")));
            this.btnCloseUserManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserManage.Location = new System.Drawing.Point(717, 587);
            this.btnCloseUserManage.Name = "btnCloseUserManage";
            this.btnCloseUserManage.Size = new System.Drawing.Size(95, 40);
            this.btnCloseUserManage.TabIndex = 16;
            this.btnCloseUserManage.Text = "Close";
            this.btnCloseUserManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserManage.UseVisualStyleBackColor = true;
            this.btnCloseUserManage.Click += new System.EventHandler(this.btnCloseUserManage_Click);
            // 
            // lblRecordsUsersCount
            // 
            this.lblRecordsUsersCount.AutoSize = true;
            this.lblRecordsUsersCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsUsersCount.Location = new System.Drawing.Point(175, 587);
            this.lblRecordsUsersCount.Name = "lblRecordsUsersCount";
            this.lblRecordsUsersCount.Size = new System.Drawing.Size(20, 17);
            this.lblRecordsUsersCount.TabIndex = 17;
            this.lblRecordsUsersCount.Text = "??";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(889, 671);
            this.Controls.Add(this.lblRecordsUsersCount);
            this.Controls.Add(this.btnCloseUserManage);
            this.Controls.Add(this.lbldtViwRecordTitle);
            this.Controls.Add(this.dtGridUsers);
            this.Controls.Add(this.btnAddUsr);
            this.Controls.Add(this.txtFilterUsers);
            this.Controls.Add(this.cmBoxFilterUsers);
            this.Controls.Add(this.lbFilterTitel);
            this.Controls.Add(this.picManagUserIcon);
            this.Controls.Add(this.lblHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picManagUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.PictureBox picManagUserIcon;
        private System.Windows.Forms.Label lbFilterTitel;
        private System.Windows.Forms.ComboBox cmBoxFilterUsers;
        private System.Windows.Forms.TextBox txtFilterUsers;
        private System.Windows.Forms.Button btnAddUsr;
        private System.Windows.Forms.DataGridView dtGridUsers;
        private System.Windows.Forms.Label lbldtViwRecordTitle;
        private System.Windows.Forms.Button btnCloseUserManage;
        private System.Windows.Forms.Label lblRecordsUsersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}