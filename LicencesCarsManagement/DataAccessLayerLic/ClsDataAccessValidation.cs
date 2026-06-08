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


        public static bool VaildateOnUsersColumns(string ColumnName)
        {
            switch(ColumnName)
            {
                case "UserID":
                    return true;
                case "PersonID":
                    return true;
                case "UserName":
                    return true;
                case "isActive":
                    return true;
                case "FullName":
                    return true; 
               
                default:
                    return false; 
            }

        }



    }


    
}
