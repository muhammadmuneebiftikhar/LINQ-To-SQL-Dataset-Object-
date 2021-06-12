using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class Index : System.Web.UI.Page
    {
        LoginDataContext dtContext = new LoginDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void RetrieveUserDetail()
        {
            GridView1.DataSource = dtContext.Logins;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Login ldetail = new Login
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Phone = Convert.ToInt64(txtPhone.Text),
                CNIC = txtCnic.Text
            };

            dtContext.Logins.InsertOnSubmit(ldetail);
            dtContext.SubmitChanges();
            RetrieveUserDetail();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Login ldetail = dtContext.Logins.SingleOrDefault(x => x.Name == txtName.Text);
            ldetail.Email = txtEmail.Text;
            ldetail.Password = txtPassword.Text;
            ldetail.Phone = Convert.ToInt64(txtPhone.Text);
            ldetail.CNIC = txtCnic.Text;
            dtContext.SubmitChanges();
            RetrieveUserDetail();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Login ldetail = dtContext.Logins.SingleOrDefault(x => x.Name == txtName.Text);
            dtContext.Logins.DeleteOnSubmit(ldetail);
            dtContext.SubmitChanges();
            RetrieveUserDetail();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            RetrieveUserDetail();
        }
    }
}