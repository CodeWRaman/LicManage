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
            this.dataGridViewPeopleManage = new System.Windows.Forms.DataGridView();
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboFilterPeople = new System.Windows.Forms.ComboBox();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClosePeopleMange = new System.Windows.Forms.Button();
            this.lblCountPeople = new System.Windows.Forms.Label();
            this.lblRecordsPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewPeopleManage.Location = new System.Drawing.Point(93, 271);
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
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(95, 236);
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
            "Nationality ",
            "Gender ",
            "Phone",
            "Email"});
            this.comboFilterPeople.Location = new System.Drawing.Point(169, 233);
            this.comboFilterPeople.Name = "comboFilterPeople";
            this.comboFilterPeople.Size = new System.Drawing.Size(202, 24);
            this.comboFilterPeople.TabIndex = 4;
            this.comboFilterPeople.SelectedIndexChanged += new System.EventHandler(this.comboFilterPeople_SelectedIndexChanged);
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFilter.Location = new System.Drawing.Point(392, 236);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(203, 20);
            this.txtBoxFilter.TabIndex = 5;
            this.txtBoxFilter.TextChanged += new System.EventHandler(this.txtBoxFilter_TextChanged);
            this.txtBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilter_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 30);
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
            this.lblHead.Location = new System.Drawing.Point(539, 173);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(157, 24);
            this.lblHead.TabIndex = 7;
            this.lblHead.Text = "Manage People";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.Location = new System.Drawing.Point(1069, 224);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(69, 41);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClosePeopleMange
            // 
            this.btnClosePeopleMange.Font = new System.Drawing.Font("Old Antic Outline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClosePeopleMange.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePeopleMange.Image")));
            this.btnClosePeopleMange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleMange.Location = new System.Drawing.Point(1016, 638);
            this.btnClosePeopleMange.Name = "btnClosePeopleMange";
            this.btnClosePeopleMange.Size = new System.Drawing.Size(122, 34);
            this.btnClosePeopleMange.TabIndex = 9;
            this.btnClosePeopleMange.Text = "Close";
            this.btnClosePeopleMange.UseVisualStyleBackColor = true;
            this.btnClosePeopleMange.Click += new System.EventHandler(this.btnClosePeopleMange_Click);
            // 
            // lblCountPeople
            // 
            this.lblCountPeople.AutoSize = true;
            this.lblCountPeople.Location = new System.Drawing.Point(180, 644);
            this.lblCountPeople.Name = "lblCountPeople";
            this.lblCountPeople.Size = new System.Drawing.Size(13, 13);
            this.lblCountPeople.TabIndex = 10;
            this.lblCountPeople.Text = "0";
            // 
            // lblRecordsPeople
            // 
            this.lblRecordsPeople.AutoSize = true;
            this.lblRecordsPeople.Font = new System.Drawing.Font("Old Antic Outline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecordsPeople.Location = new System.Drawing.Point(89, 638);
            this.lblRecordsPeople.Name = "lblRecordsPeople";
            this.lblRecordsPeople.Size = new System.Drawing.Size(89, 23);
            this.lblRecordsPeople.TabIndex = 11;
            this.lblRecordsPeople.Text = "# Records : ";
            // 
            // PeopleMangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1227, 706);
            this.Controls.Add(this.lblRecordsPeople);
            this.Controls.Add(this.lblCountPeople);
            this.Controls.Add(this.btnClosePeopleMange);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.comboFilterPeople);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dataGridViewPeopleManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeopleMangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClosePeopleMange;
        private System.Windows.Forms.Label lblCountPeople;
        private System.Windows.Forms.Label lblRecordsPeople;
    }
}