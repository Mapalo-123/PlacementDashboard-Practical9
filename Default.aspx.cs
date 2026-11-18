using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;

using PlacementDashboard.DataAccess;

namespace PlacementDashboard
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPlacementData();
            }
        }

        private void LoadPlacementData()
        {
            try
            {
                StudentDataAccess dataAccess = new StudentDataAccess();

                DataTable dt = dataAccess.GetAllStudents();

                gvStudents.DataSource = dt;
                gvStudents.DataBind();

                int total = dt.Rows.Count;
                int placed = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Status"].ToString() == "Placed")
                    {
                        placed++;
                    }
                }

                lblTotal.Text = total.ToString();
                lblPlaced.Text = placed.ToString();
                lblNotPlaced.Text = (total - placed).ToString();
            }
            catch (Exception ex)
            {
                Response.Write("Database Error: " + ex.Message);
            }
        }

        protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentDataAccess dataAccess = new StudentDataAccess();

            DataTable dt = dataAccess.GetAllStudents();

            int studentID = Convert.ToInt32(
                gvStudents.SelectedDataKey.Value);

            DataRow[] rows = dt.Select("StudentID = " + studentID);

            if (rows.Length > 0)
            {
                DataTable selectedStudent = rows.CopyToDataTable();

                dvStudent.DataSource = selectedStudent;
                dvStudent.DataBind();
            }
        }
    }
}
