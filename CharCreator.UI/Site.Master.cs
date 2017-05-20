using System;
using System.Web;
using System.Web.UI;

namespace CharCreator.UI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["User"] == null)
            {
                Response.Redirect("View/Login/Login.aspx");
            }
        }
    }
}