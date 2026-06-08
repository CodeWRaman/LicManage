using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerLic
{
    public class clsDataAccUsers : AccountSetting
    {

        // checking Existence 
        public static bool isUserExist(string Username,string Password)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select R = 1 From Users Where UserName = @Username And Password = @Password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password); 

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                isExist = read.HasRows;

                read.Close(); 


            }
            catch
            {
                isExist = false; 
            }
            finally
            {
                connection.Close(); 
            }




            return isExist; 

        }

        public static bool isUserActive(string Username)
        {
            bool isAtive = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select R = 1 From Users Where UserName = @Username and isActive = 1";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", Username);
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                isAtive = read.HasRows;

                read.Close();


            }
            catch
            {
                isAtive = false;
            }
            finally
            {
                connection.Close();
            }

            return isAtive; 

        }

        public static bool isPersonLinked(int PersonID)
        {
            bool isLinked = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select R = 1 From Users Where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection); 
            
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                isLinked = read.HasRows;

                read.Close(); 

            }
            catch
            {
                isLinked = false; 
            }
            finally
            {
                connection.Close(); 
            }

            return isLinked; 

        }

        // Bring Data 
        public static List<clsUsersDOT> LoadUsersDLL()
        {
            List<clsUsersDOT> Users = new List<clsUsersDOT> ();
             
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
           
            string Query = "Select *From vUsersInfo";

            SqlCommand cmd = new SqlCommand(Query, connection);
           

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader(); 
                while(read.Read())
                {
                    clsUsersDOT User = new clsUsersDOT();

                    User.UserID = (int)read["UserID"];
                    User.PersonID = (int)read["PersonID"];
                    User.FirstName = (string)read["FirstName"];
                    User.LastName = (string)read["LastName"];
                    User.Username = (string)read["UserName"];
                    User.isActive = (bool)read["isActive"];

                    Users.Add(User); 
                    
                        

                }
                
                read.Close(); 
            }
            catch(Exception ex)
            {
              
            }
            finally
            {
                connection.Close(); 
            }

           
            return Users; 


        }

        public static List<clsUsersDOT>GetAllUsersByFiltering(string ColumnName,string value)
        {
            List<clsUsersDOT> Users = new List<clsUsersDOT>();

            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            if(!ClsDataAccessValidation.VaildateOnUsersColumns(ColumnName))
            {
                throw new ArgumentException("Invalid Column Name"); 
            }
            string query = "Select *From vUsersFullInfo Where " + ColumnName + " = @value";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value", value); 

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    clsUsersDOT User = new clsUsersDOT();

                    User.UserID = (int)read["UserID"];
                    User.PersonID = (int)read["PersonID"];
                    User.FullName = (string)read["FullName"];
                    User.Username = (string)read["UserName"];
                    User.isActive = (bool)read["isActive"];

                    Users.Add(User);



                }

                read.Close();


            }
            catch
            {

            }
            finally
            {
                connection.Close(); 
            }


            return Users;


        }

        public static bool FindUserFromAccessByID(int ID, ref int PersonID, ref string FullName, ref string UserName,ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(AccountSetting.connectionStr);
            string query = "Select *From vUsersFullInfo Where UserID = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    FullName = (string)reader["FullName"];
                    UserName = (string)reader["UserName"];
                    isActive = (bool)reader["isActive"]; 

                    
                    isFound = true;
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

    }
}
