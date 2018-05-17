using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeHeMo.Web.UI
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void testlistclick(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
        protected void profilclick(object sender, EventArgs e)
        {
            Response.Redirect("~/profile.aspx");
        }
        protected void testaddclick(object sender, EventArgs e)
        {
            Response.Redirect("~/testadd.aspx");
        }
    }




      /*  protected void menuclick(object sender, MenuEventArgs e)
        {

            switch (e.Item.Text)
            {
                case "Profil":
                    Response.Redirect("~/profile.aspx");
                    break;
                case "Test Görüntüle":
                    Response.Redirect("~/default.aspx");
                    break;
                case "Test Ekle":
                    Response.Redirect("~/testadd.aspx");
                    break;
            
            }


        }*/
    }
