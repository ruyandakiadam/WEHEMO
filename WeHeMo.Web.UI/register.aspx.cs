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
    public partial class register : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregisterclick(object sender, EventArgs e)
        {

            var id = Service.CustomerAdd(txt_name.Value, txt_email.Value, txt_password.Value);
            CustomerID = id;
            Response.Redirect("~/default.aspx");

        }

    }
}