using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerLic; 

namespace BusinessLayerLic
{
    public class clsBusinessCountry
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; }
        public clsBusinessCountry()
        {
            int CountryID = 0;
            string CountryName = ""; 
        }

        public clsBusinessCountry(int Id,string Name)
        {
            CountryID = Id;
            CountryName = Name; 
        }

        public static clsBusinessCountry FindCountryByID(int ID)
        {
           
            string Name = ""; 

            if(clsDataCountries.FindCountryById(ID,ref Name))
            {
                return new clsBusinessCountry(ID, Name); 
            }
            else
            {
                return null; 
            }

        }

        public static List<clsBusinessCountry> ListCountries()
        {
            List<clsBusinessCountry> ListCr = new List<clsBusinessCountry>();
            List<CountryDOT> ListDataCr = clsDataCountries.ListCountries(); 

            foreach(CountryDOT cr in ListDataCr)
            {
                clsBusinessCountry Country = new clsBusinessCountry();
                Country.CountryID = cr.CountryID;
                Country.CountryName = cr.CountryName;
                ListCr.Add(Country); 

            }

            return ListCr; 
        }

    }
}
