using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_Dataset
{
    public partial class Default : System.Web.UI.Page
    {
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=MUNEEB;Initial Catalog=Vp_Lab;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from Departments" , con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            dt = ds.Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Name"] = txtDName.Text;
            dr["Location"] = txtDLocation.Text;
            dt.Rows.Add(dr);
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            da.Update(dt);
            con.Close();
            Response.Redirect("~/default.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow drDpt = dt.AsEnumerable().SingleOrDefault(x => x.Field<int>("Id") == Convert.ToInt32(txtDID.Text));
            drDpt["Name"] = txtDName.Text;
            drDpt["Location"] = txtDLocation.Text;
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            da.Update(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow drDpt = dt.AsEnumerable().SingleOrDefault(x => x.Field<int>("Id") == Convert.ToInt32(txtDID.Text));
            drDpt.Delete();
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            da.Update(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var dpt = from d in dt.AsEnumerable() where d.Field<int>("Id") == Convert.ToInt32(txtDID.Text) select d;
            DataTable dtDpt = dpt.CopyToDataTable();
            GridView1.DataSource = dtDpt;
            GridView1.DataBind();
            txtDID.Text = dtDpt.Rows[0]["ID"].ToString();
            txtDName.Text = dtDpt.Rows[0]["Name"].ToString();
            txtDLocation.Text = dtDpt.Rows[0]["Location"].ToString();
        }
    }
}