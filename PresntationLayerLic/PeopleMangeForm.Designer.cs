namespace PresntationLayerLic
{
    partial class PeopleMangeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleMangeForm));
            this.lblXfromMangePeople = new System.Windows.Forms.Label();
            this.lblPeopleMangeForm = new System.Windows.Forms.Label();
            this.dataGridViewPeopleManage = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboFilterPeople = new System.Windows.Forms.ComboBox();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.clPersonI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNationallity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXfromMangePeople
            // 
            this.lblXfromMangePeople.AutoSize = true;
            this.lblXfromMangePeople.BackColor = System.Drawing.Color.Brown;
            this.lblXfromMangePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXfromMangePeople.ForeColor = System.Drawing.Color.White;
            this.lblXfromMangePeople.Location = new System.Drawing.Point(1267, 2);
            this.lblXfromMangePeople.Name = "lblXfromMangePeople";
            this.lblXfromMangePeople.Size = new System.Drawing.Size(16, 16);
            this.lblXfromMangePeople.TabIndex = 0;
            this.lblXfromMangePeople.Text = "X";
            this.lblXfromMangePeople.Click += new System.EventHandler(this.lblXfromMangePeople_Click);
            // 
            // lblPeopleMangeForm
            // 
            this.lblPeopleMangeForm.AutoSize = true;
            this.lblPeopleMangeForm.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleMangeForm.Location = new System.Drawing.Point(3, 2);
            this.lblPeopleMangeForm.Name = "lblPeopleMangeForm";
            this.lblPeopleMangeForm.Size = new System.Drawing.Size(110, 14);
            this.lblPeopleMangeForm.TabIndex = 1;
            this.lblPeopleMangeForm.Text = "People Mange Form";
            // 
            // dataGridViewPeopleManage
            // 
            this.dataGridViewPeopleManage.AllowUserToOrderColumns = true;
            this.dataGridViewPeopleManage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPeopleManage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewPeopleManage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeopleManage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeopleManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPersonI,
            this.NationalNo,
            this.clFirstName,
            this.clLastName,
            this.clDateOfBirth,
            this.clAddress,
            this.clEmail,
            this.clNationallity,
            this.clPhoneNumber,
            this.clGender});
            this.dataGridViewPeopleManage.GridColor = System.Drawing.Color.White;
            this.dataGridViewPeopleManage.Location = new System.Drawing.Point(172, 292);
            this.dataGridViewPeopleManage.Name = "dataGridViewPeopleManage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeopleManage.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPeopleManage.Size = new System.Drawing.Size(1045, 352);
            this.dataGridViewPeopleManage.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(169, 265);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 16);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter By:";
            // 
            // comboFilterPeople
            // 
            this.comboFilterPeople.BackColor = System.Drawing.SystemColors.Window;
            this.comboFilterPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilterPeople.FormattingEnabled = true;
            this.comboFilterPeople.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name ",
            "Last Name ",
            "Nationallity ",
            "Gendor ",
            "Phone",
            "Email"});
            this.comboFilterPeople.Location = new System.Drawing.Point(243, 262);
            this.comboFilterPeople.Name = "comboFilterPeople";
            this.comboFilterPeople.Size = new System.Drawing.Size(202, 24);
            this.comboFilterPeople.TabIndex = 4;
            this.comboFilterPeople.SelectedIndexChanged += new System.EventHandler(this.comboFilterPeople_SelectedIndexChanged);
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFilter.Location = new System.Drawing.Point(466, 265);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(203, 20);
            this.txtBoxFilter.TabIndex = 5;
            this.txtBoxFilter.TextChanged += new System.EventHandler(this.txtBoxFilter_TextChanged);
            this.txtBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilter_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHead.Location = new System.Drawing.Point(526, 216);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(203, 24);
            this.lblHead.TabIndex = 7;
            this.lblHead.Text = "People Management";
            // 
            // clPersonI
            // 
            this.clPersonI.HeaderText = "Person ID";
            this.clPersonI.Name = "clPersonI";
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No.";
            this.NationalNo.Name = "NationalNo";
            // 
            // clFirstName
            // 
            this.clFirstName.HeaderText = "First Name";
            this.clFirstName.Name = "clFirstName";
            // 
            // clLastName
            // 
            this.clLastName.HeaderText = "Last Name";
            this.clLastName.Name = "clLastName";
            // 
            // clDateOfBirth
            // 
            this.clDateOfBirth.HeaderText = "Date of Birth";
            this.clDateOfBirth.Name = "clDateOfBirth";
            // 
            // clAddress
            // 
            this.clAddress.HeaderText = "Address";
            this.clAddress.Name = "clAddress";
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            // 
            // clNationallity
            // 
            this.clNationallity.HeaderText = "Nationallity";
            this.clNationallity.Name = "clNationallity";
            // 
            // clPhoneNumber
            // 
            this.clPhoneNumber.HeaderText = "Phone Number";
            this.clPhoneNumber.Name = "clPhoneNumber";
            // 
            // clGender
            // 
            this.clGender.HeaderText = "Gender";
            this.clGender.Name = "clGender";
            // 
            // PeopleMangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 714);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.comboFilterPeople);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dataGridViewPeopleManage);
            this.Controls.Add(this.lblPeopleMangeForm);
            this.Controls.Add(this.lblXfromMangePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeopleMangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleMangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXfromMangePeople;
        private System.Windows.Forms.Label lblPeopleMangeForm;
        private System.Windows.Forms.DataGridView dataGridViewPeopleManage;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboFilterPeople;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPersonI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNationallity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
    }
}