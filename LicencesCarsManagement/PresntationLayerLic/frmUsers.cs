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
    public partial class frmUsers : Form
    {
        List<clsBusinessUsers> _Users = new List<clsBusinessUsers>(); 
        public frmUsers()
        {
            InitializeComponent();
           
        }
        private void RestUsersToDefault()
        {
            
            cmBoxFilterUsers.SelectedIndex = 0;
            checkFiltter();
            FillUsersInDataGridView();

        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            RestUsersToDefault(); 

        }

        private void FillUsersInDataGridView()
        {
            
            _Users = clsBusinessUsers.GetListOfUsers();

            lblRecordsUsersCount.Text = _Users.Count.ToString();
            foreach (clsBusinessUsers User in _Users)
            {
                
                    
                dtGridUsers.Rows.Add(User.UserId, User.Person.PersonID, User.Person.FirstName + ' ' + User.Person.LastName, User.Username, User.isActive);
            
             
            
            
            }




        }

        // Filter 
       
        private string WithoutSpaces(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    result += str[i];
                }
            }


            return result;
        }

        private void HandleFilter(string ColumnName)
        {
            dtGridUsers.Rows.Clear();
            string value = txtFilterUsers.Text;
            _Users.Clear(); 

            _Users = clsBusinessUsers.GetAllUsersByFiltering(ColumnName, value);

            if (_Users != null)
            {
                lblRecordsUsersCount.Text = _Users.Count.ToString();
                foreach (clsBusinessUsers row in _Users)
                {

                    dtGridUsers.Rows.Add(row.UserId, row.Person.PersonID, row.Person.FirstName + ' ' + row.Person.LastName,
                        row.Username, row.isActive);

                }
            }
            else
            {

                dtGridUsers.Rows.Clear();
            }
        }

        private void HandleIsActiveFilter()
        {
            dtGridUsers.Rows.Clear();

            List<clsBusinessUsers> Users = clsBusinessUsers.GetAllUsersByFiltering("isActive", "true");

            if (Users != null)
            {
                lblRecordsUsersCount.Text = Users.Count.ToString();
                foreach (clsBusinessUsers row in Users)
                {

                    dtGridUsers.Rows.Add(row.UserId, row.Person.PersonID, row.Person.FirstName + ' ' + row.Person.LastName,
                        row.Username, row.isActive);

                }
            }
            else
            {
                // MessageBox.Show("Error");
                dtGridUsers.Rows.Clear();
            }

        }


        private void GetAllUsersByFilter()
        {
           
            _Users.Clear();
            string CaseName = WithoutSpaces(cmBoxFilterUsers.SelectedItem.ToString());

            if (CaseName == WithoutSpaces("User ID"))
            {
                int Check = clsValidation.CheckIfIntegerFormat(txtFilterUsers.Text);
                int NumberID = -1;
                if (Check != -1)
                {
                    NumberID = Check;
                }

                clsBusinessUsers User = clsBusinessUsers.FindUserByID(NumberID);
                if (User != null)
                {
                    dtGridUsers.Rows.Clear();
                    dtGridUsers.Rows.Add(User.UserId, User.Person.PersonID, User.FullName, User.Username, User.isActive);
                }
                else
                {
          
                    dtGridUsers.Rows.Clear();

                }

                return;


            }






            if (CaseName == WithoutSpaces("User ID"))
            {
                HandleFilter("UserID");
            }

            if (CaseName == WithoutSpaces("Person ID"))
            {

                HandleFilter("PersonID");


            }

            if (CaseName == WithoutSpaces("Full Name"))
            {
                HandleFilter("FullName");


            }




            if (CaseName == WithoutSpaces("UserName"))
            {

                HandleFilter("UserName");

            }
            
            
        }




        private void btnCloseUserManage_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtFilterUsers_TextChanged(object sender, EventArgs e)
        {
            GetAllUsersByFilter();
        }

        private void checkFiltter()
        {
            if(cmBoxFilterUsers.Text != "none" && cmBoxFilterUsers.Text != "Is Active")
            {
                txtFilterUsers.Visible = true; 

            }
            else
            {
                txtFilterUsers.Visible = false; 
            }
        }
        private void cmBoxFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            if (cmBoxFilterUsers.Text == "Is Active" || cmBoxFilterUsers.Text == "none")
            {
                txtFilterUsers.Visible = false;

                if(cmBoxFilterUsers.Text == "Is Active")
                    HandleIsActiveFilter(); 
            }
            else
            {
                txtFilterUsers.Visible = true;

            }
        }

        private void txtFilterUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmBoxFilterUsers.Text == "Person ID" || cmBoxFilterUsers.Text == "User ID")
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
    }
}
