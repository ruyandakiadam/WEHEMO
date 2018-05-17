using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WeHeMo.Web.UI
{
    public partial class _default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CustomerID == Guid.Empty)
                Response.Redirect("~/login.aspx");

            repeatTestList.DataSource = Service.TestList(CustomerID);
            repeatTestList.DataBind();
        }

        protected void repeatTestList_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                /* var btn = e.Item.FindControl("btn") as Button;
                 if (btn != null)
                 {  // adding button event 
                     btn.Click += new EventHandler(btn_Click);
                 }*/
                var trResult = e.Item.FindControl("row") as HtmlTableRow;
                var status = e.Item.FindControl("statuscode") as HtmlTableCell;
                var statusCode = status.InnerText;
                if (statusCode == "200")
                    trResult.Attributes["class"] = "positive";
                else if (statusCode == "")
                    trResult.Attributes["class"] = "ui grey table"; // burası yüzünden silemiyoruz burayı kladırısakta gri olmayacak
                else
                    trResult.Attributes["class"] = "negative";
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            var testId = (sender as LinkButton).CommandArgument;  //Id değerini aldık
            Service.TestDelete(new Guid(testId));
        }
        /*void btn_Click(object sender, EventArgs e)
{
   var id = new Guid((sender as Button).SkinID);
   Service.TestDelete(id);
}

protected void btndelete_Click1(object sender, EventArgs e)
{
   var id =new Guid( (sender as Button).ID);

   Service.TestDelete(id);
}*/
    }
}