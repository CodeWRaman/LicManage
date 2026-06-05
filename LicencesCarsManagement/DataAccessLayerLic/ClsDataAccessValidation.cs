using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerLic
{
    public class ClsDataAccessValidation
    {
        // this function will Handle the Column -> which is Static <- Not the value  
        public static bool ValidationOnCaseNamePersons(string CaseName)
        {
            switch(CaseName)
            {
                case "PersonID":
                    return true;

                case "NationalNumber":
                    return true; 

                case "FirstName":
                    return true;

                case "LastName":
                    return true; 

                case "Nationality":
                    return true;

                case "Gender":
                    return true;
                    
                case "PhoneNumber":
                    return true; 

                case "Email":
                    return true;
                default:
                    return false; 
            }
        }
    }
}
