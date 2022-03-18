using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Sample
{
    public class DBMethod
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DmsContent"].ToString();
        }

        public static string LogDB(string ErrorMessage)
        {
            string Msg = "";
            try
            {
                SqlConnection con = new SqlConnection(GetConnectionString());
                con.Open();
                SqlCommand cmd = new SqlCommand("[INSERT_LogErrorTest]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = 1001;
                cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar).Value = ErrorMessage;

                try
                {
                    cmd.ExecuteNonQuery();
                    Msg = "Add Done ";

                }
                catch (Exception ex)
                {
                    Msg = "Error While Adding";
                }
                con.Close();
                return Msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
