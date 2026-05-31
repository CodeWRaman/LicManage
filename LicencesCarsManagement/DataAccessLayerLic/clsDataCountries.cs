using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace DataAccessLayerLic
{
    public class clsDataCountries : AccountSetting
    {
        
        public static bool FindCountryById(int ID,ref string CountryName)
        {
            bool isFound = false ; 
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "select *From Countries Where CountryID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID); 

            try
            {
                connection.Open(); 
                SqlDataReader read = command.ExecuteReader();

                if (read.Read())
                {
                    isFound = true; 
                    ID = (int)read["CountryID"];
                    CountryName = (string)read["CountryName"];
                }
                else
                {
                    isFound = false; 
                }



                    read.Close(); 

            }
            catch
            {
                isFound = false; 
            }
            finally
            {
                connection.Close(); 

            }




            return isFound; 

        }

        public static bool FindCountryByName(string Name,ref int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "select *From Countries Where CountryName = @Name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

          

            try
            {
                connection.Open();
                SqlDataReader read = command.ExecuteReader();

                if (read.Read())
                {
                    isFound = true;
                    ID = (int)read["CountryID"];
                    Name = (string)read["CountryName"];
                }
                else
                {
                    isFound = false;
                }



                read.Close();

            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();

            }




            return isFound;
        }

        public static List<CountryDOT>ListCountries()
        {
            List<CountryDOT> Countries = new List<CountryDOT>();

            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select *From Countries";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader read = command.ExecuteReader(); 
                while(read.Read())
                {
                    CountryDOT cr = new CountryDOT();
                    cr.CountryID = (int)read["CountryID"];
                    cr.CountryName = (string)read["CountryName"];

                    Countries.Add(cr); 


                }

            }
            catch
            {

            }
            finally
            {
                connection.Close(); 
            }





            return Countries; 
        }
        
        
    }
}
