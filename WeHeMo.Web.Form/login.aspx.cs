using System;

namespace WeHeMo.Web.Form
{
    public partial class login : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var id = Service.CustomerLogin(txtEmail.Value, txtPassword.Value);
            if (id == null)
                lblMessage.InnerText = "Müşteri bulunamadı.";
            else
            {
                CustomerID = id.Value;
                Response.Redirect("~/default.aspx");
            }
        }
    }
}