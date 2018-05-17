using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WeHeMo.Business;

namespace WeHeMo.Web.Form
{
    public partial class _default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CustomerID == Guid.Empty)
                Response.Redirect("~/login.aspx");

            var test = new Test();
            repeatTestList.DataSource = test.List(CustomerID);
            repeatTestList.DataBind();
        }

        protected void repeatTestList_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var trResult = e.Item.FindControl("row") as HtmlTableRow;
                var status = e.Item.FindControl("status") as HtmlTableCell;
                var statusCode = status.InnerText;
                if (statusCode == "200")
                    trResult.Attributes["class"] = "positive";
                else if(statusCode == "")
                    trResult.Attributes["class"] = "disabled";
                else
                    trResult.Attributes["class"] = "negative";
            }
        }
    }
}