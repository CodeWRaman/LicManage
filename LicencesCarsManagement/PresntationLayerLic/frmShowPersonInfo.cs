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
    public partial class frmShowPersonInfo : Form
    {
       
        
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
           urControlPersonInfo1.PersonID = PersonID;
            
            
        }

        

        // End 
        private void btnClosePeopleMange_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void urControlPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            urControlPersonInfo1.Load_DataPerson();
        }
    }
}
