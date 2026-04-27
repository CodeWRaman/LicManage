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
    public partial class PeopleMangeForm : Form
    {
        private DataTable dt = new DataTable(); 

        private enum enSlected {enNone =0,enPersonID =1, enNationalityNo = 2 , enFirstName=3 ,
            enLastName =4,enNationality = 5,enGendor = 6,enPhone = 7,enEmail = 8};
        public PeopleMangeForm()
        {
            dt = clsBusinessPeople.GetPeopleFromBusinesss();
            InitializeComponent();
            RestToDefault(); 
        }

        

      
        private void RestToDefault()
        {
           
            
            
            if (dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    dataGridViewPeopleManage.Rows.Add(row["PersonID"], row["NationalNumber"], row["FirstName"], row["LastName"],
                        Convert.ToDateTime(row["DateOfBirth"]).ToString("yyyy - MM - dd"), row["Address"], row["Email"], row["Nationality"],
                        row["PhoneNumber"], row["Gender"]);
                   
                }

            }
            else
            {
                MessageBox.Show("No People in the System"); 
            }

            comboFilterPeople.SelectedIndex = 0; 
                
            
        }

        // Filter Handling 
        // by me 
        private void listPeopleByItems(int Selected)
        {
            string value = txtBoxFilter.Text;
            List<clsBusinessPeople> persons = new List<clsBusinessPeople>();
            persons.Clear(); 

            if (FilterSelect(Selected) == enSlected.enPersonID)
            {
                int Check = clsValidation.CheckIfIntegerFormat(txtBoxFilter.Text);
                int NumberID = -1;
                if (Check != -1)
                {
                    NumberID = Check;
                }

                clsBusinessPeople Person = clsBusinessPeople.FindPersonByID(NumberID);
                if (Person != null)
                {
                    dataGridViewPeopleManage.Rows.Clear();
                    dataGridViewPeopleManage.Rows.Add(Person.PersonID, Person.NationalNo, Person.FirstName, Person.LastName, Person.DateOfBirth.ToString("yyyy - MM - dd")
                         , Person.Adderss, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gendor);
                }
                else
                {
                    dataGridViewPeopleManage.Rows.Clear();

                }

                return;


            }

            if (FilterSelect(Selected) == enSlected.enNationalityNo)
            {
                value = txtBoxFilter.Text;
                clsBusinessPeople Person = clsBusinessPeople.FindPersonByStr("NationalNumber",  value);
                if (Person != null)
                {
                    dataGridViewPeopleManage.Rows.Clear();
                    dataGridViewPeopleManage.Rows.Add(Person.PersonID, Person.NationalNo, Person.FirstName, Person.LastName, Person.DateOfBirth.ToString("yyyy - MM - dd")
                         , Person.Adderss, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gendor);
                }
                else
                {
                    // MessageBox.Show("Error");
                    dataGridViewPeopleManage.Rows.Clear();
                }

                return;
            }

            if (FilterSelect(Selected) == enSlected.enFirstName)
            {
                
                 persons = clsBusinessPeople.FindPersons("FirstName",  value);
                if (persons.Count != 0)
                {
                    dataGridViewPeopleManage.Rows.Clear();
                    foreach (clsBusinessPeople Person in persons)
                    {

                        dataGridViewPeopleManage.Rows.Add(Person.PersonID, Person.NationalNo, Person.FirstName, Person.LastName, Person.DateOfBirth.ToString("yyyy - MM - dd")
                             , Person.Adderss, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gendor);

                    }
                }



            }

            if (FilterSelect(Selected) == enSlected.enLastName)
            {
                persons = clsBusinessPeople.FindPersons("LastName", value);
                
                if (persons.Count != 0)
                {
                  
                    dataGridViewPeopleManage.Rows.Clear();
                    foreach (clsBusinessPeople Person in persons)
                    {

                        dataGridViewPeopleManage.Rows.Add(Person.PersonID, Person.NationalNo, Person.FirstName, Person.LastName, Person.DateOfBirth.ToString("yyyy - MM - dd")
                             , Person.Adderss, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gendor);

                    }
                }
            }

            if (FilterSelect(Selected) == enSlected.enNationality)
            {
                
                persons.Clear(); 
                persons = clsBusinessPeople.FindPersons("Nationality", value);
               
                if (persons.Count != 0)
                {
                    MessageBox.Show(persons[0].PersonID.ToString());
                    MessageBox.Show(persons[1].PersonID.ToString()); 

                    dataGridViewPeopleManage.Rows.Clear();
                    foreach (clsBusinessPeople Person in persons)
                    {

                        dataGridViewPeopleManage.Rows.Add(Person.PersonID, Person.NationalNo, Person.FirstName, Person.LastName, Person.DateOfBirth.ToString("yyyy - MM - dd")
                             , Person.Adderss, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gendor);

                    }
                }
                




            }

             
        }
        
        private enSlected FilterSelect(int Num)
        { 
            switch(Num)
            {
                case 1:
                    return enSlected.enPersonID;
                case 2:
                    return enSlected.enNationalityNo; 
                case 3:
                    return enSlected.enFirstName;
                case 4:
                    return enSlected.enLastName;
                case 5:
                    return enSlected.enNationality;
                case 6:
                    return enSlected.enGendor;
                case 7:
                    return enSlected.enPhone;
                default:
                    return enSlected.enEmail; 
            }
        
        
        }
        private void CheckFilter(string text)
        {
            if(text!="None")
            {
                txtBoxFilter.Visible = true; 
               
            }
            else
            {
                txtBoxFilter.Visible = false;

            }

        }

          // Events 
        private void lblXfromMangePeople_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFilter(comboFilterPeople.Text); 
        }

        
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboFilterPeople.Text == "Person ID")
            {
                bool isNumber = clsValidation.CheckNumricFormat(e);
                if (isNumber)
                {
                    e.Handled = isNumber;
                }
                else
                {
                    e.Handled = isNumber;
                }

            }

        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            listPeopleByItems(comboFilterPeople.SelectedIndex); 
        }

        
    }
}
