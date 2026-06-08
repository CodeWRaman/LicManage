using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresntationLayerLic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          

        }
        // Forms 
      
        
        // Utility 
        private void RecieveMenueStrip(ToolStripMenuItem item)
        {
            if(item == PeopleParentMenu)
            {
                PeopleMangeForm frm = new PeopleMangeForm();
                frm.ShowDialog();
            }
            if(item == UsersParentMenu)
            {
                frmUsers frm = new frmUsers();
                frm.ShowDialog(); 
            }
        }

        private void toolMenuStrip_Click(object sender, EventArgs e)
        {
            RecieveMenueStrip((ToolStripMenuItem)sender); 
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginUrs frm = new frmLoginUrs();
            frm.Show();
            this.Close();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
