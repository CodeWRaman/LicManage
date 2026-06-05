using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerLic;
namespace PresntationLayerLic
{
    public partial class frmLoginUrs : Form
    {
        public frmLoginUrs()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void EnableDisablecheckBox()
        {
            if (txtPasswordLogin.Text == "" || txtUserLogIn.Text == "")
            {
                chBoxRememberme.Enabled = false;

            }
            else
            {
                chBoxRememberme.Enabled = true;
            }
        }
        private void chBoxRememberme_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chBoxRememberme.Checked)
            {
                
                string Username = txtUserLogIn.Text;
                string Password = txtPasswordLogin.Text;
                txtUserLogIn.Enabled = false;
                txtPasswordLogin.Enabled = false; 

                StreamWriter write = File.CreateText(@"C:\Users\Admin\source\repos\LicencesCarsManagement\LoginUsers.txt");
                
                try
                {
                    
                    write.Write(Username);
                    write.Write(" ");
                    write.Write(Password); 

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); 

                }
                finally
                {
                    write.Close(); 
                }




            }
            else
            {
                txtUserLogIn.Enabled = true;
                txtPasswordLogin.Enabled = true; 
                try
                {
                    File.Create(@"C:\Users\Admin\source\repos\LicencesCarsManagement\LoginUsers.txt").Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
               
               

            }
        }


        private void RetrieveFromFile()
        {
            StreamReader read = File.OpenText(@"C:\Users\Admin\source\repos\LicencesCarsManagement\LoginUsers.txt");

            string Username = "";
            string Password = "";
            try
            {
               
                while(!read.EndOfStream)
                {
                    string result = read.ReadLine();
                    string[] arrResult = result.Split(' ');
                    Username = arrResult[0];
                    Password = arrResult[1];

                }
                    
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                read.Close(); 
            }

            txtPasswordLogin.Text= Password;
            txtUserLogIn.Text = Username;
            if(Username != "" && Password != "")
                chBoxRememberme.Checked = true; 

        }
        private void frmLoginUrs_Load(object sender, EventArgs e)
        {
            RetrieveFromFile(); 
            if (txtPasswordLogin.Text == "" || txtUserLogIn.Text == "")
                chBoxRememberme.Enabled = false;
            else
                chBoxRememberme.Enabled = true; 

        }

        private void txtUserLogIn_TextChanged(object sender, EventArgs e)
        {
            EnableDisablecheckBox(); 
        }

        private void txtPasswordLogin_TextChanged(object sender, EventArgs e)
        {
            EnableDisablecheckBox();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isExist = clsBusinessUsers.isExist(txtUserLogIn.Text, txtPasswordLogin.Text);
            if (isExist)
            { 
                MainForm frm = new MainForm();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
