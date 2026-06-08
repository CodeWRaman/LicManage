namespace PresntationLayerLic
{
    partial class frmShowPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
            this.urControlPersonInfo1 = new PresntationLayerLic.urControlPersonInfo();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnClosePeopleMange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urControlPersonInfo1
            // 
            this.urControlPersonInfo1.Location = new System.Drawing.Point(6, 61);
            this.urControlPersonInfo1.Name = "urControlPersonInfo1";
            this.urControlPersonInfo1.PersonID = 0;
            this.urControlPersonInfo1.Size = new System.Drawing.Size(682, 256);
            this.urControlPersonInfo1.TabIndex = 43;
            this.urControlPersonInfo1.Load += new System.EventHandler(this.urControlPersonInfo1_Load);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitel.Location = new System.Drawing.Point(256, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(163, 28);
            this.lblTitel.TabIndex = 44;
            this.lblTitel.Text = "Person Details";
            // 
            // btnClosePeopleMange
            // 
            this.btnClosePeopleMange.Font = new System.Drawing.Font("Old Antic Outline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClosePeopleMange.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePeopleMange.Image")));
            this.btnClosePeopleMange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleMange.Location = new System.Drawing.Point(555, 323);
            this.btnClosePeopleMange.Name = "btnClosePeopleMange";
            this.btnClosePeopleMange.Size = new System.Drawing.Size(122, 34);
            this.btnClosePeopleMange.TabIndex = 45;
            this.btnClosePeopleMange.Text = "Close";
            this.btnClosePeopleMange.UseVisualStyleBackColor = true;
            this.btnClosePeopleMange.Click += new System.EventHandler(this.btnClosePeopleMange_Click);
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(703, 360);
            this.Controls.Add(this.btnClosePeopleMange);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.urControlPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Person Info";
            this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private urControlPersonInfo urControlPersonInfo1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnClosePeopleMange;
    }
}