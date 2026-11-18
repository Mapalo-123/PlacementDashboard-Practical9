using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlacementDashboard.DataAccess
{
    public class StudentDataAccess
    {
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Students";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
