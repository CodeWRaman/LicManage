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
        private void openPeopleManagementForm()
        {
            PeopleMangeForm frm = new PeopleMangeForm();
            frm.ShowDialog(); 
        }
        
        // Utility 
        private void RecieveMenueStrip(ToolStripMenuItem item)
        {
            if(item == PeopleParentMenu)
            {
                openPeopleManagementForm();
            }
        }

        private void toolMenuStrip_Click(object sender, EventArgs e)
        {
            RecieveMenueStrip((ToolStripMenuItem)sender); 
        }

       
    }
}
