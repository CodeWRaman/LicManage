using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayerLic
{
    public class clsDataAccessPeople : AccountSetting
    {
        public struct stPeople
        {
            // test
           public int PersonID { get; set; }
           
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Nationallity { get; set; }
            public string PhoneNumber { get; set; }
            public string Gendor { get; set; }
            public string ImagePath { get; set; }
            public int CountryID { get; set; }


        }
        public static DataTable GetPeopleFromAccess()
        {
            DataTable db = new DataTable(); 
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);

            string query = @"Select Persons.PersonID,Persons.NationalNumber, Persons.FirstName,Persons.LastName,
                            Persons.DateOfBirth,Persons.Address,Persons.Email,Nationality = Countries.CountryName,Persons.PhoneNumber,Persons.Gender From Persons Inner Join Countries ON Persons.CountryID = Countries.CountryID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open(); 
                SqlDataReader read = cmd.ExecuteReader();

                if(read.HasRows)
                {
                    db.Load(read); 
                }    



                read.Close(); 
            }
            catch(Exception ex)
            {

                return null; 

            }
            finally
            {
                connection.Close(); 
            }

            return db;

           
        }
        
        public static bool FindPersonFromAccessByID(ref int ID,ref string NationalNo, ref string FirstName,ref string LastName,ref DateTime DateOfBirth,ref string Address
            ,ref string Email,ref string Nationallity,ref string PhoneNumber,ref string Gendor,ref string ImagePath,ref int CountryID)
        {
            bool isFound = false; 
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select *From Persons Where PersonID = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ID", ID); 

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader(); 
                if(reader.Read())
                {
                    isFound = true;
                   
                    ID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNumber"];
                    FirstName = (string) reader["FirstName"]; 
                    LastName = (string) reader["LastName"]; 
                    DateOfBirth = (DateTime) reader["DateOfBirth"];
                    Address = (string) reader["Address"]; 
                    Email = (string) reader["Email"]; 
                    Nationallity = (string) reader["Nationality"]; 
                    PhoneNumber = (string) reader["PhoneNumber"]; 
                    Gendor = (string) reader["Gender"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = ""; 
                    }

                    CountryID = (int)reader["CountryID"];
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

               
                reader.Close(); 
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



        public static bool FindPersonFromAccessByStr (string caseName,string value,ref int ID,ref string NationalNo, ref string FirstName, ref string LastName, ref DateTime DateOfBirth, ref string Address
            , ref string Email, ref string Nationallity, ref string PhoneNumber, ref string Gendor, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select *From Persons Where " + caseName + " = @value";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@value", value);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Email = (string)reader["Email"];
                    Nationallity = (string)reader["Nationality"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Gendor = (string)reader["Gender"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    CountryID = (int)reader["CountryID"];
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }


                reader.Close();
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


        
        public static List<stPeople> GetListOfPeople(string caseName,string value)
        {
           
            List<stPeople> ListPeople = new List<stPeople>();

            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select *From Persons Where " + caseName + " = @value";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@value", value); 

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 

                while(reader.Read())
                {
                    stPeople people = new stPeople();
                    people.PersonID = (int)reader["PersonID"];
                    people.NationalNo = (string)reader["NationalNumber"];
                    people.FirstName = (string)reader["FirstName"];
                    people.LastName = (string)reader["LastName"];
                    people.DateOfBirth = (DateTime)reader["DateOfBirth"];
                    people.Address = (string)reader["Address"];
                    people.Email = (string)reader["Email"];
                    people.Nationallity = (string)reader["Nationality"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        people.ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        people.ImagePath = "";
                    }
                    people.PhoneNumber = (string)reader["PhoneNumber"];
                    people.Gendor = (string)reader["Gender"];

                    people.CountryID = (int)reader["CountryID"];

                    ListPeople.Add(people);
                


                }
                reader.Close(); 
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close(); 
            }

            return ListPeople;
        }







    }


}
