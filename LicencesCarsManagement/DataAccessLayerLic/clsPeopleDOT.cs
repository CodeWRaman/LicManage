using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerLic
{
    // for List People Use 
    public class clsPeopleDOT
    {
       
            public int PersonID { get; set; }

            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Nationality { get; set; }
            public string PhoneNumber { get; set; }
            public string Gendor { get; set; }
            public string ImagePath { get; set; }
            public int CountryID { get; set; }


        
    }
    public class clsUsersDOT : clsPeopleDOT
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public string FullName { get; set; }




    }
}
