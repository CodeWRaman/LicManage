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
using System.IO; 
namespace PresntationLayerLic
{
    public partial class frmUsrCnAddPerson : Form
    {
        // Variables 
        public delegate void DelOnAdd();
        public event DelOnAdd ToRestForm;
        
        private int _PersonID;
        clsBusinessPeople _Person = new clsBusinessPeople();
        string _selectedPath = "";
        string _DefaultPhoto = "";
        string _ToDelete = ""; 

        // Start Functionality 
        public frmUsrCnAddPerson(int ID)
        {
            InitializeComponent();
            ResetToDefaultAddPrForm();
            if (ID != -1)
            {
                _PersonID = ID; 
             bringPersonDataInForm();
            }
            else
            {

                _PersonID = -1;
            }
        }

        public void bringPersonDataInForm()
        {
            if (_PersonID == -1)
                return;

            lblTitel.Text = "Update Person"; 
            _Person = clsBusinessPeople.FindPersonByID(_PersonID);
            lbReturndIDPr.Text = _Person.PersonID.ToString(); 
            txtUsrCnAdPrFirName.Text = _Person.FirstName;
            txtUsrCnAdPrSecName.Text = _Person.LastName;
            txtNtNoPerson.Text = _Person.NationalNo;

            txtEmlPreson.Text = (_Person.Email != "" ? _Person.Email : "");

            txtAdrsAdPr.Text = _Person.Address;
            DtPikerAddPr.Value = _Person.DateOfBirth;

            if (_Person.ImagePath != "")
            {
                
                picAddPrs.Load(_Person.ImagePath);
                linklbRmImage.Visible = true; 
                
            }

           

            string Load = "";
            if (_Person.Gender == "M" )
            {
                rdBtnMel.Checked = true;
                if(_Person.ImagePath == "")
                {
                    Load = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                    picAddPrs.Load(Load);
                }
              
            }
            else
            {
                rdBtnFemel.Checked = true;
                if (_Person.ImagePath == "")
                {
                    Load = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                    picAddPrs.Load(Load);
                }

            }

            cmbCountryAddPr.SelectedIndex = cmbCountryAddPr.FindString(clsBusinessCountry.FindCountryByID(_Person.CountryID).CountryName);

            txtPhonePrs.Text = _Person.PhoneNumber;

            _Person.Mode = clsBusinessPeople.enMode.enUpdate;






        }
        private void Save()
        {
            _Person.NationalNo = txtNtNoPerson.Text;
            _Person.FirstName = txtUsrCnAdPrFirName.Text;
            _Person.LastName = txtUsrCnAdPrSecName.Text;
            _Person.DateOfBirth = (DateTime)DtPikerAddPr.Value;
            _Person.Address = txtAdrsAdPr.Text; 
            if(txtEmlPreson.Text == "")
            {
                _Person.Email = null; 
            }
            else
            {
                _Person.Email = txtEmlPreson.Text; 
            }

            _Person.Nationality = cmbCountryAddPr.Text;
            

            _Person.PhoneNumber = txtPhonePrs.Text; 

            if(rdBtnFemel.Checked)
            {
                _Person.Gender = "F"; 
            }
            else
            {
                _Person.Gender = "M"; 
            }

            _Person.CountryID = clsBusinessCountry.FindCountryByName(cmbCountryAddPr.Text).CountryID;

            // Handle Image Path 
            Guid fileName = Guid.NewGuid();
            string newPathCopy = @"C:\DLVDTEST\" + fileName + ".png";
            if(_Person.ImagePath != "" && _ToDelete == "")
                _ToDelete = _Person.ImagePath; 

            if (picAddPrs.ImageLocation != null)
            {
               
           

                if (_selectedPath != "")
                    _Person.ImagePath = newPathCopy;
               

                
            }

            // Saving and Copied file 
            if(_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully"); 
                if(_selectedPath != "")
                File.Copy(_selectedPath, newPathCopy); 

                if(_ToDelete !="" && _Person.Mode == clsBusinessPeople.enMode.enUpdate && _Person.ImagePath != _ToDelete)
                File.Delete(_ToDelete);

                lbReturndIDPr.Text = _Person.PersonID.ToString();
               
            }
            else
            {
                MessageBox.Show("Insertion a person Failed","Message",MessageBoxButtons.OK,MessageBoxIcon.Error); 
               

            }

            ToRestForm?.Invoke(); 


        }
        
        private void  ResetToDefaultAddPrForm()
        {
            int birthYear = DateTime.Now.Year - 18;
            DateTime birthDate = new DateTime(birthYear, DateTime.Now.Month, DateTime.Now.Day);
            DtPikerAddPr.MaxDate = birthDate;
            rdBtnMel.Checked = true;
            linklbRmImage.Visible = false;
            LoadCountry();
            cmbCountryAddPr.SelectedIndex = 0;
            // _selectedPath = picAddPrs.ImageLocation;
            if (rdBtnFemel.Checked)
            {
                _DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                 picAddPrs.Load(_DefaultPhoto);
            }
            else
            {
                _DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                  picAddPrs.Load(_DefaultPhoto);
            }

        }
        public void LoadCountry()
        {
            List<clsBusinessCountry> Countries = clsBusinessCountry.ListCountries(); 

            foreach(clsBusinessCountry cr in Countries)
            {
                cmbCountryAddPr.Items.Add(cr.CountryName); 
            }


        }
        // Start Validation 
        private void txtUsrCnAdPrFirName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsrCnAdPrFirName.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(txtUsrCnAdPrFirName, "First Name Must Provided"); 
            }
            else
            {
                errorProvider3.SetError(txtUsrCnAdPrFirName, ""); 

                e.Cancel = false;
              

            }
        }
        private void txtUsrCnAdPrSecName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsrCnAdPrSecName.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(txtUsrCnAdPrSecName, "Second Name Must Provided");
            }
            else
            {
                errorProvider3.SetError(txtUsrCnAdPrSecName, "");

                e.Cancel = false;


            }
        }

      

        private void txtEmlPreson_Validating(object sender, CancelEventArgs e)
        {
            if(!clsValidation.isEmail(txtEmlPreson.Text) && txtEmlPreson.Text != "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmlPreson, "Invalid Email Address"); 
               
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmlPreson, "");
            }
        }


        private void txtAdrsAdPr_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAdrsAdPr.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(txtAdrsAdPr, "Provide Address"); 
            }
            else
            {

                e.Cancel = false; 
                errorProvider2.SetError(txtAdrsAdPr, ""); 

            }
        }

     

        // Start Logic 
        private void rdBtnMel_CheckedChanged(object sender, EventArgs e)
        {
            if (_Person.ImagePath != "")
                return; 

            if (rdBtnMel.Checked)
            {

                picAddPrs.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png");

            }
            else
            {
                picAddPrs.Load(@"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png");

            }
        }

       



        private void btnClosePrsAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhonePrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(clsValidation.CheckNumricFormat(e))
            {
                e.Handled = true; 
            }
            else
            {
                e.Handled = false; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(); 
        }

        
        private void linklbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linklbRmImage.Visible)
            {
                MessageBox.Show("Remove the Picture First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openAddPicDialog.InitialDirectory = @"c:\";
            openAddPicDialog.DefaultExt = "png";
            openAddPicDialog.Filter = "Photos (*.jbg)|*.jbg|Photos (*.png)|*.*|All files(*.*)|*.*";
        
            if (openAddPicDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedPath = openAddPicDialog.FileName;
                picAddPrs.Load(_selectedPath);
                linklbRmImage.Visible = true; 
            }

          
        }

        private void linklbRmImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            picAddPrs.ImageLocation = null;
            linklbRmImage.Visible = false;
            _DefaultPhoto = "";
            if (_Person.ImagePath != "")
                _ToDelete = _Person.ImagePath; 

            _Person.ImagePath = "";
            _selectedPath = ""; 
            
            
            if (rdBtnFemel.Checked)
            {
                _DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                picAddPrs.Load(_DefaultPhoto);
            }
            else
            {
                _DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                picAddPrs.Load(_DefaultPhoto);
            }

        }
    }
}
