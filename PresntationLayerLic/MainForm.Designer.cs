namespace PresntationLayerLic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.AppParentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleParentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversParentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersParentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountParentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppParentMenu,
            this.PeopleParentMenu,
            this.DriversParentMenu,
            this.UsersParentMenu,
            this.AccountParentMenu});
            resources.ApplyResources(this.MainmenuStrip, "MainmenuStrip");
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // AppParentMenu
            // 
            resources.ApplyResources(this.AppParentMenu, "AppParentMenu");
            this.AppParentMenu.Name = "AppParentMenu";
            this.AppParentMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 8);
            // 
            // PeopleParentMenu
            // 
            resources.ApplyResources(this.PeopleParentMenu, "PeopleParentMenu");
            this.PeopleParentMenu.Name = "PeopleParentMenu";
            this.PeopleParentMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 8);
            this.PeopleParentMenu.Click += new System.EventHandler(this.toolMenuStrip_Click);
            // 
            // DriversParentMenu
            // 
            resources.ApplyResources(this.DriversParentMenu, "DriversParentMenu");
            this.DriversParentMenu.Name = "DriversParentMenu";
            this.DriversParentMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 8);
            this.DriversParentMenu.Click += new System.EventHandler(this.toolMenuStrip_Click);
            // 
            // UsersParentMenu
            // 
            resources.ApplyResources(this.UsersParentMenu, "UsersParentMenu");
            this.UsersParentMenu.Name = "UsersParentMenu";
            this.UsersParentMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 8);
            this.UsersParentMenu.Click += new System.EventHandler(this.toolMenuStrip_Click);
            // 
            // AccountParentMenu
            // 
            resources.ApplyResources(this.AccountParentMenu, "AccountParentMenu");
            this.AccountParentMenu.Name = "AccountParentMenu";
            this.AccountParentMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 8);
            this.AccountParentMenu.Click += new System.EventHandler(this.toolMenuStrip_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainmenuStrip);
            this.MainMenuStrip = this.MainmenuStrip;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UsersParentMenu;
        private System.Windows.Forms.ToolStripMenuItem AppParentMenu;
        private System.Windows.Forms.ToolStripMenuItem PeopleParentMenu;
        private System.Windows.Forms.ToolStripMenuItem DriversParentMenu;
        private System.Windows.Forms.ToolStripMenuItem AccountParentMenu;
    }
}

