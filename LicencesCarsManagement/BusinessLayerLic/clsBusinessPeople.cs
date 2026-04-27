using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayerLic; 

namespace BusinessLayerLic
{
    public class clsBusinessPeople
    {
        enum enMode { enAdd ,enUpdate};

        enMode Mode = enMode.enAdd; 

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Adderss { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }


        public string PhoneNumber { get; set; }
        public string Gendor { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }

        static public int NumberTest { get; set; }

        public clsBusinessPeople()
        {
           this.PersonID = 0;
            this.NationalNo = ""; 
            this.FirstName = "";
            this.DateOfBirth = DateTime.Today; 
            this.Adderss = ""; 
            this.Email = ""; 
           this. Nationality = "";
           this.PhoneNumber = "";
            this.Gendor = "";
            this.ImagePath = "";
            this.CountryID = 0; 
            Mode = enMode.enAdd;


        }
        public clsBusinessPeople(int PersonID,string NationalNo,string FirstName,string LastName,DateTime DateOfBirth,string Address,string Email,
            string Nationallity,string PhoneNumber,string Gendor,string imagePath,int CountryID)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo; 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth =DateOfBirth;
            this.Adderss = Address; 
            this.Email = Email; 
            this.Nationality = Nationallity;
            this.PhoneNumber = PhoneNumber;
            this.Gendor = Gendor;
            this.ImagePath = imagePath;
            this.CountryID = CountryID;
            Mode = enMode.enUpdate;


        }


        public static clsBusinessPeople FindPersonByID(int ID)
        {
            int PerID = ID;
            string NationalNo = "";
            string Name = "";
            string LastName = "";
            DateTime dt = DateTime.Today; 
            string Address = "";
            string Email = "";
            string Nationality = "";
            string PhoneNumber = "";
            string Gendor = "";
            string image = "";
            int CountryID = 0; 

            if(clsDataAccessPeople.FindPersonFromAccessByID(ref PerID,ref NationalNo,ref Name,ref LastName,ref dt,ref Address,ref Email,ref Nationality
                ,ref PhoneNumber,ref Gendor,ref image,ref CountryID))
            {
                return new clsBusinessPeople(PerID, NationalNo,Name, LastName, dt, Address, Email, Nationality, PhoneNumber, Gendor, image, CountryID);
            }
             
           
            return null;  
        }


        public static clsBusinessPeople FindPersonByStr(string caseName, string value)
        {
            int PerID = 0;
            string NationalNo = ""; 
            string Name = "";
            string LastName = "";
            DateTime dt = DateTime.Today;
            string Address = "";
            string Email = "";
            string Nationality = "";
            string PhoneNumber = "";
            string Gendor = "";
            string image = "";
            int CountryID = 0;

            if (clsDataAccessPeople.FindPersonFromAccessByStr(caseName,value,ref PerID,ref NationalNo ,ref Name, ref LastName, ref dt, ref Address, ref Email, ref Nationality
                , ref PhoneNumber, ref Gendor, ref image, ref CountryID))
            {
                return new clsBusinessPeople(PerID, NationalNo,Name, LastName, dt, Address, Email, Nationality, PhoneNumber, Gendor, image, CountryID);
            }


            return null;
        }

        public static List<clsBusinessPeople> FindPersons(string caseName, string value)
        {
             
            List<clsBusinessPeople> List = new List<clsBusinessPeople>();
            List<clsDataAccessPeople.stPeople> People = clsDataAccessPeople.GetListOfPeople(caseName, value);
            NumberTest = People.Count; 
            foreach(clsDataAccessPeople.stPeople pe in People)
            {
                clsBusinessPeople person = new clsBusinessPeople();
                person.PersonID = pe.PersonID;
                person.NationalNo = pe.NationalNo; 
                person.FirstName = pe.FirstName;
                person.LastName = pe.LastName;
                person.DateOfBirth = pe.DateOfBirth;
                person.Adderss = pe.Address;
                person.Nationality = pe.Nationallity;
                person.PhoneNumber = pe.PhoneNumber;
                person.Email = pe.Email;
                person.Gendor = pe.Gendor;
                person.ImagePath = pe.ImagePath;
                person.CountryID = pe.CountryID;
                List.Add(person); 
            }





            return List;
        }

        public static DataTable GetPeopleFromBusinesss()
        {
            return clsDataAccessPeople.GetPeopleFromAccess(); 
        }

        
    }
}
