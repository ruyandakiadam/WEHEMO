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
    public partial class testadd :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CustomerID == Guid.Empty)
                Response.Redirect("~/login.aspx");
        }

        protected void btnTestAdd(object sender, EventArgs e)
        {
            TestID = Service.TestAdd(CustomerID, txturl.Value);
            Response.Redirect("~/default.aspx");
        }
    }
}