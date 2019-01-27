using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace Report
{
    public partial class Report_ASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string con = WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString();
        protected void BtnReport_OnClick(object sender, EventArgs e)
        {
            //try
            //{
            //    string sql = "INSERT INTO Student(Name,Address,Phone) VALUES('" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')";
            //    SqlCommand cmd = new SqlCommand(sql, new SqlConnection(con));
            //    cmd.Connection.Open();
            //    cmd.ExecuteNonQuery();
            //    cmd.Connection.Close();
            //    Label1.Text = "Save Succesfully.";
            //}
            //catch (Exception er)
            //{
            //    Label1.Text = er.ToString();

            //}

            
            DataTable dt=GetData();
            if (dt.Rows.Count>0)
            {
                ReportDocument r=new ReportDocument();
                r.Load(Server.MapPath("CrystalReport1.rpt"));
                r.SetDataSource(dt);
                ReportSubmit.rpt = r;
                Response.Redirect("ReportViewer.aspx");
            }
            

        }

        private DataTable GetData()
        {
            DataTable dt=new DataTable();
            string sql = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(sql, new SqlConnection(con));
            cmd.Connection.Open();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
    }
}