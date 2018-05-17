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
    public partial class login :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendClick(object sender, EventArgs e)
        {
            
            var id = Service.CustomerLogin(txtEmail.Value, txtpassword.Value);
            if (id == null)
            {

                warning.Style.Add("display", "normal");
                lblMessage.InnerText = "Yanlış giriş yaptınız. Lütfen tekrar deneyin";
                
            }

            else
            {
                CustomerID = id.Value;
                Response.Redirect("~/default.aspx");
            }
            }

        protected void btnRegisterClick(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");

        }
    }
}
