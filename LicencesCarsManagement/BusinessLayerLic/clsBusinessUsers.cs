using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerLic; 

namespace BusinessLayerLic
{
    public class clsBusinessUsers
    {
        // Fields 
        public enum enMode { enAdd, enUpdate };
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public string FullName { get; set; }

        public enMode Mode { get; set; }

        public clsBusinessPeople Person { get; set; }
        //End of Fields 


        
        public clsBusinessUsers()
        {
            Person = new clsBusinessPeople(); 
            this.UserId = 0;
            this.Username = "";
            this.Password = "";
            this.isActive = false;
            this.FullName = ""; 

            this.Person.PersonID = 0; 
            this.Person.NationalNo = ""; 
            this.Person.FirstName = "";
            this.Person.LastName = "";
            this.Person.DateOfBirth = DateTime.Now;
            this.Person.Address = "";
            this.Person.Email = "";
            this.Person.Nationality = ""; 
            this.Person.ImagePath = "";
            this.Person.PhoneNumber = "";
            this.Person.Gender = "";
            this.Person.CountryID = 0;
            
            this.Mode = enMode.enAdd;



        }


        public clsBusinessUsers(int UserID,int PersonID,string FullName,string UserName,bool isActive)
        {
            clsBusinessPeople PersonOut = clsBusinessPeople.FindPersonByID(PersonID); 
            
            Person = new clsBusinessPeople(); 
            this.Person.PersonID = PersonOut.PersonID; 
            this.Person.NationalNo = PersonOut.NationalNo; 
            this.Person.FirstName = PersonOut.FirstName; 
            this.Person.LastName = PersonOut.LastName; 
            this.Person.DateOfBirth = PersonOut.DateOfBirth; 
            this.Person.Address = PersonOut.Address; 
            this.Person.Email = PersonOut.Email; 
            this.Person.Nationality = PersonOut.Nationality; 
            this.Person.ImagePath = PersonOut.ImagePath; 
            this.Person.PhoneNumber = PersonOut.PhoneNumber; 
            this.Person.Gender = PersonOut.Gender; 
            this.Person.CountryID    = PersonOut.CountryID;

            this.UserId = UserID;
            this.FullName = this.Person.FirstName + ' ' + this.Person.LastName;
            this.Username = UserName;
            this.isActive = isActive;

            this.Mode = enMode.enUpdate; 


        }
        // Check Existence 
        public static bool isExist(string Username,string Password)
        {
            bool result = clsDataAccUsers.isUserExist(Username, Password);

            return result; 
        }

        public static bool isBUserActive(string Username)
        {
            return clsDataAccUsers.isUserActive(Username); 
        }


        // Bring Data User 

        public static clsBusinessUsers FindUserByID(int ID)
        {
            
            int PersonID = 0;
            string FullName = "";
            string UserName = "";
            bool isActive = false; 

            if (clsDataAccUsers.FindUserFromAccessByID(ID, ref PersonID, ref FullName, ref UserName,ref isActive))
            {
                return new clsBusinessUsers(ID, PersonID, FullName, UserName, isActive);
            }


            return null;
        }

        public static List<clsBusinessUsers> GetListOfUsers()
        {
            List<clsUsersDOT> UsersDOT = clsDataAccUsers.LoadUsersDLL();
            List<clsBusinessUsers> UsersBLL = new List<clsBusinessUsers>(); 
            foreach(clsUsersDOT Us in UsersDOT)
            {
                clsBusinessUsers User = new clsBusinessUsers();
                User.Person.PersonID = Us.PersonID;
                User.Person.FirstName = Us.FirstName;
                User.Person.LastName = Us.LastName;
                User.UserId = Us.UserID;
                User.Username = Us.Username;
                User.isActive = Us.isActive;

                UsersBLL.Add(User); 
            }

             
            return UsersBLL; 


        }

        public static List<clsBusinessUsers>GetAllUsersByFiltering(string ColumnName,string value)
        {
            List<clsUsersDOT> UsersDOT = clsDataAccUsers.GetAllUsersByFiltering(ColumnName, value);
            List<clsBusinessUsers> UsersBLL = new List<clsBusinessUsers>();
            foreach (clsUsersDOT Us in UsersDOT)
            {
                clsBusinessUsers User = new clsBusinessUsers();
                string[] splitResult = Us.FullName.Split(' ');
                
                User.Person.PersonID = Us.PersonID;
                User.Person.FirstName = splitResult[0];
                User.Person.LastName = splitResult[1];
                User.FullName = Us.FullName;
                User.UserId = Us.UserID;
                User.Username = Us.Username;
                User.isActive = Us.isActive;

                UsersBLL.Add(User);
            }


            return UsersBLL;
        }

        

    }
}
