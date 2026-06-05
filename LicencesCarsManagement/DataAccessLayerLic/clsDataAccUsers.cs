using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace DataAccessLayerLic
{
    public class clsDataAccUsers : AccountSetting
    {
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
    }
}
