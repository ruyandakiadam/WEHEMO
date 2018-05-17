using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeHeMo.Service.Contract;
using WeHeMo.DTO;
using System.ServiceModel;
namespace WeHeMo.Web.UI
{
    public partial class profile : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CustomerID == Guid.Empty)
                Response.Redirect("~/login.aspx");

            var customer = Service.CustomerGet(CustomerID);

            if (!IsPostBack) {
            txtname.Value = customer.name;
            txtemail.Value = customer.email;
            txtpassword.Value = customer.password;
            }
        }

        protected void btnUpdateClick(object sender, EventArgs e)
        {
            string name= txtname.Value;
            string email = txtemail.Value;
            string password = txtpassword.Value;
            Service.CustomerUpdate(CustomerID,name,email,password);
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Only alert Message');", true);
            Response.Redirect("~/profile.aspx");
        }
    }
}