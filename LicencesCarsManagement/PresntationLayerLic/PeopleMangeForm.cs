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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresntationLayerLic
{
    public partial class PeopleMangeForm : Form
    {
        private DataTable _dt = new DataTable(); 

       
        public PeopleMangeForm()
        {
            
            InitializeComponent();
            RestToDefault(); 
        }

        private string WithoutSpaces(string str)
        {
            string result = "";

            for(int i=0;i<str.Length;i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    result += str[i]; 
                }
            }


            return result; 
        }

      
        private void RestToDefault()
        {

            _dt.Clear();
            dataGridViewPeopleManage.Rows.Clear(); 
            _dt = clsBusinessPeople.GetPeopleFromBusinesss();
            int num = _dt.Rows.Count;
            lblCountPeople.Text = num.ToString(); 
            
            if (_dt != null)
            {
                foreach(DataRow row in _dt.Rows)
                {
                    dataGridViewPeopleManage.Rows.Add(row["PersonID"], row["NationalNumber"], row["FirstName"] , row["LastName"],
                        Convert.ToDateTime(row["DateOfBirth"]).ToString("yyyy - MM - dd"), row["Address"], row["Email"], row["Nationality"],
                        row["PhoneNumber"], row["Gender"]);
                   
                }

            }
            else
            {
                MessageBox.Show("No People in the System"); 
            }

            comboFilterPeople.SelectedIndex = 0;
            txtBoxFilter.Visible = false; 
                
            
        }

       

        private void HandleListByItem(string CaseName)
        {
            dataGridViewPeopleManage.Rows.Clear();
            string value = txtBoxFilter.Text;
           
            List<clsBusinessPeople> Persons = clsBusinessPeople.FindPersons(CaseName,value);

            if (Persons != null)
            {
                lblCountPeople.Text = Persons.Count.ToString(); 
                foreach (clsBusinessPeople row in Persons )
                {
                    
                    dataGridViewPeopleManage.Rows.Add(row.PersonID, row.NationalNo, row.FirstName, row.LastName,
                        Convert.ToDateTime(row.DateOfBirth).ToString("yyyy - MM - dd"), row.Address, row.Email, row.Nationality,
                        row.PhoneNumber, row.Gender);

                }
            }
            else
            {
                // MessageBox.Show("Error");
                dataGridViewPeopleManage.Rows.Clear();
            }

         
        }
        private void listPeopleByItems(int Selected)
        {
           
            List<clsBusinessPeople> persons = new List<clsBusinessPeople>();
            persons.Clear();
            string CaseName = WithoutSpaces(comboFilterPeople.SelectedItem.ToString());
            

            if (CaseName == WithoutSpaces("Person ID"))
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
                         , Person.Address, Person.Email, Person.Nationality, Person.PhoneNumber, Person.Gender);
                }
                else
                {
                    dataGridViewPeopleManage.Rows.Clear();

                }

                return;


            }

            if (CaseName == WithoutSpaces("National No.")) 
            {
                HandleListByItem("NationalNumber"); 
            }

            if (CaseName == WithoutSpaces("First Name"))
            {

                HandleListByItem(CaseName); 


            }

            if (CaseName == WithoutSpaces("Last Name")) 
            {
                HandleListByItem(CaseName); 
                
            }

            if (CaseName == WithoutSpaces("Nationality")) 
            {

                HandleListByItem(CaseName); 

            }


            if (CaseName == WithoutSpaces("Gender"))
            {

                HandleListByItem(CaseName);

            }

            if (CaseName == WithoutSpaces("Phone"))
            {

                HandleListByItem("PhoneNumber");

            }
            if (CaseName == WithoutSpaces("Email"))
            {

                HandleListByItem(CaseName);

            }



        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            listPeopleByItems(comboFilterPeople.SelectedIndex);
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

       

        private void btnClosePeopleMange_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmUsrCnAddPerson frmAddPerson = new frmUsrCnAddPerson(-1);
            frmAddPerson.ShowDialog();
 
            RestToDefault(); 
          
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = (int) dataGridViewPeopleManage.CurrentRow.Cells[0].Value;
            frmUsrCnAddPerson frmForEdit = new frmUsrCnAddPerson(Id);
            frmForEdit.ShowDialog();
            RestToDefault(); 
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure to delete this Person ?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string Message = clsBusinessPeople.DeletePersonBL((int) dataGridViewPeopleManage.CurrentRow.Cells[0].Value);
                MessageBox.Show(Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                RestToDefault(); 
            }

        }

        private void PeopleMangeForm_Load(object sender, EventArgs e)
        {
            RestToDefault();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsrCnAddPerson frm = new frmUsrCnAddPerson(-1);
            frm.Show(); 
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Not Implemented yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Not Implemented yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void showDetialsToolStripMenu_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dataGridViewPeopleManage.CurrentRow.Cells[0].Value); 
            frm.ShowDialog();
            RestToDefault(); 
        }
    }
}
