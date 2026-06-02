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
         
        private int PersonID;
        clsBusinessPeople Person = new clsBusinessPeople();
        string _selectedPath = "";
        string DefaultPhoto = ""; 
        public frmUsrCnAddPerson(int ID)
        {
            InitializeComponent();
            ResetToDefaultAddPrForm();
            if (ID != -1)
            {
                PersonID = ID; 
             bringPersonDataInForm();
            }
            else
            {

                PersonID = -1;
            }
        }

        public void bringPersonDataInForm()
        {
            if (PersonID == -1)
                return;

            lblTitel.Text = "Update Person"; 
            Person = clsBusinessPeople.FindPersonByID(PersonID);
            lbReturndIDPr.Text = Person.PersonID.ToString(); 
            txtUsrCnAdPrFirName.Text = Person.FirstName;
            txtUsrCnAdPrSecName.Text = Person.LastName;
            txtNtNoPerson.Text = Person.NationalNo;

            txtEmlPreson.Text = (Person.Email != "" ? Person.Email : "");

            txtAdrsAdPr.Text = Person.Adderss;
            DtPikerAddPr.Value = Person.DateOfBirth;

            if (Person.ImagePath != "")
            {
                
                picAddPrs.Load(Person.ImagePath);
                linklbRmImage.Visible = true; 
                
            }

           

            string Load = "";
            if (Person.Gendor == "M" )
            {
                rdBtnMel.Checked = true;
                if(Person.ImagePath == "")
                {
                    Load = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                    picAddPrs.Load(Load);
                }
              
            }
            else
            {
                rdBtnFemel.Checked = true;
                if (Person.ImagePath == "")
                {
                    Load = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                    picAddPrs.Load(Load);
                }

            }

            cmbCountryAddPr.SelectedValue = clsBusinessCountry.FindCountryByID(Person.CountryID).CountryName;

            txtPhonePrs.Text = Person.PhoneNumber;

            Person.Mode = clsBusinessPeople.enMode.enUpdate;






        }
        private void Save()
        {
            Person.NationalNo = txtNtNoPerson.Text;
            Person.FirstName = txtUsrCnAdPrFirName.Text;
            Person.LastName = txtUsrCnAdPrSecName.Text;
            Person.DateOfBirth = (DateTime)DtPikerAddPr.Value;
            Person.Adderss = txtAdrsAdPr.Text; 
            if(txtEmlPreson.Text == "")
            {
                Person.Email = null; 
            }
            else
            {
                Person.Email = txtEmlPreson.Text; 
            }

            Person.Nationality = cmbCountryAddPr.Text;
            

            Person.PhoneNumber = txtPhonePrs.Text; 

            if(rdBtnFemel.Checked)
            {
                Person.Gendor = "F"; 
            }
            else
            {
                Person.Gendor = "M"; 
            }

            Person.CountryID = clsBusinessCountry.FindCountryByName(cmbCountryAddPr.Text).CountryID;

            // Handle Image Path 
            Guid fileName = Guid.NewGuid();
            string newPathCopy = @"C:\DLVDTEST\" + fileName + ".png";
            string ToDelete = Person.ImagePath; 

            if (picAddPrs.ImageLocation != null)
            {
               
                //if(_selectedPath != "")
                //File.Copy(_selectedPath, newPathCopy);
                //if(Person.ImagePath !="")
                //File.Delete(Person.ImagePath);


                if (_selectedPath != "")
                    Person.ImagePath = newPathCopy;
                else
                    Person.ImagePath = "";

                
            }

            // Saving and Copied file 
            if(Person.Save())
            {
                MessageBox.Show("Data Saved Successfully"); 
                if(_selectedPath != "")
                File.Copy(_selectedPath, newPathCopy);
                if(ToDelete !="")
                File.Delete(ToDelete);
                lbReturndIDPr.Text = Person.PersonID.ToString(); 
            }
            else
            {
                MessageBox.Show("Insertion a person Failed"); 
               

            }


    


        }
        private void frmUsrCnAddPerson_Load(object sender, EventArgs e)
        {
            
          
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
                DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                 picAddPrs.Load(DefaultPhoto);
            }
            else
            {
                DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                  picAddPrs.Load(DefaultPhoto);
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
            if (Person.ImagePath != "")
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
            DefaultPhoto = "";
            if (rdBtnFemel.Checked)
            {
                DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Female 512.png";
                picAddPrs.Load(DefaultPhoto);
            }
            else
            {
                DefaultPhoto = @"C:\Users\Admin\OneDrive\Desktop\Managemnt Licenses Project\Icons\Male 512.png";
                picAddPrs.Load(DefaultPhoto);
            }

        }
    }
}
