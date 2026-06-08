using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerLic; 
namespace PresntationLayerLic
{
    public partial class urControlPersonInfo : UserControl
    {
        
        clsBusinessPeople _Person = new clsBusinessPeople();
        public int PersonID { get; set; }
        public urControlPersonInfo()
        {
            InitializeComponent();
            
        }
        
      
        public void Load_DataPerson()
        {
             
            _Person = clsBusinessPeople.FindPersonByID(PersonID);
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FirstName + ' ' + _Person.LastName;
            lblNationNumber.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email; 
            lblGender.Text = _Person.Gender;
            if(lblGender.Text == "M")
            {
                picGender.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Man 32.png");
            }
            else
            {
                picGender.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Woman 32.png");

            }
                lblAddress.Text = _Person.Address;
            lblPhone.Text = _Person.PhoneNumber;
            lblCountryName.Text = clsBusinessCountry.FindCountryByID(_Person.CountryID).CountryName;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("yyyy - MM - dd");
            string Path = _Person.ImagePath;
            if (Path == "")
            {
                if (_Person.Gender == "M")
                    picPersonInUsrCon.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png");
                else
                    picPersonInUsrCon.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png");

            }
            else
            {
                picPersonInUsrCon.Load(Path);
            }
            


        }
       

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUsrCnAddPerson frm = new frmUsrCnAddPerson(PersonID);
            frm.ShowDialog();
            Load_DataPerson();


        }

        
    }
}
