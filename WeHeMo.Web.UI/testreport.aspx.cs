using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WeHeMo.Web.UI
{
    public partial class testreport : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Guid id = default(Guid);
            string str = Request.QueryString[0];
            

            id = new Guid(str);
            
             repeatTestReport.DataSource = Service.TestGetTestReport(id);
             repeatTestReport.DataBind();

         }

         protected void repeatTestReport_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
         {
             if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
             {
                 var trResult = e.Item.FindControl("row") as HtmlTableRow;
                 var status = e.Item.FindControl("description") as HtmlTableCell;
                 var statusCode = status.InnerText;
                 if (statusCode == "OK")
                     trResult.Attributes["class"] = "positive";
                 else
                     trResult.Attributes["class"] = "negative";
             }
         }
        }
    }
