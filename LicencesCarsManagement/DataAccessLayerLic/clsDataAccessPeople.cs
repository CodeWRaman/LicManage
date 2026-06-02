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
            if (!ClsDataAccessValidation.ValidationOnCaseName(caseName))
            {
                throw new ArgumentException("Invalid column name.");
            }
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



        public static List<clsPeopleDOT> GetListOfPeople(string caseName, string value)
        {

            List<clsPeopleDOT> ListPeople = new List<clsPeopleDOT>();

            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            if(!ClsDataAccessValidation.ValidationOnCaseName(caseName))
            {
                 throw new ArgumentException("Invalid column name.");
            }
            string query = "Select *From Persons Where " + caseName + " = @value";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@value", value);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clsPeopleDOT people = new clsPeopleDOT();
                    people.PersonID = (int)reader["PersonID"];
                    people.NationalNo = (string)reader["NationalNumber"];
                    people.FirstName = (string)reader["FirstName"];
                    people.LastName = (string)reader["LastName"];
                    people.DateOfBirth = (DateTime)reader["DateOfBirth"];
                    people.Address = (string)reader["Address"];
                    people.Email = (string)reader["Email"];
                    people.Nationality = (string)reader["Nationality"];
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
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ListPeople;
        }

        public static int AddNewPerson(string NationalNumber, string FirstName,string LastName,DateTime DateOfBirth,string Address,string Email,
            string Nationality,string ImagePath,string PhoneNumber,string Gender,int CountryID)
        {
            int PersonID = 0; 
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "INSERT INTO Persons (NationalNumber, FirstName, LastName, DateOfBirth, Address, Email, Nationality, ImagePath, PhoneNumber, Gender, CountryID) VALUES (@NationalNumber, @FirstName, @LastName, @DateOfBirth, @Address, @Email, @Nationality, @ImagePath, @PhoneNumber, @Gender, @CountryID); SELECT SCOPE_IDENTITY();";



            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Address", Address);
            if (Email != "" && Email != null)
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@Nationality", Nationality);

            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);


            

            try
            {
                connection.Open(); 
                object result = cmd.ExecuteScalar(); 
                if(result!=null && int.TryParse(result.ToString(),out int ID))
                {
                     PersonID = ID;
                }
                else
                {
                    PersonID = -1;
                }
            }
            catch
            {
                 PersonID = -5; 

            }
            finally
            {
                connection.Close(); 
            }



            return PersonID; 
        }

        




    }


}
