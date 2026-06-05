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
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public clsBusinessPeople Person { get; set; }

        public clsBusinessUsers()
        {
            this.UserId = 0;
            this.Username = "";
            this.Password = "";
            this.isActive = false;
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
        
        
        }

        public static bool isExist(string Username,string Password)
        {
            bool result = clsDataAccUsers.isUserExist(Username, Password);

            return result; 
        }

    }
}
