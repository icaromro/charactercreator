using System;
using System.Web;
using System.Web.UI;
using CharCreator.Model.Entity;

namespace CharCreator.UI
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User usuarioLogado = (User)(HttpContext.Current.Session["User"]);
            lblTeste.Text = usuarioLogado.name + "\n " + usuarioLogado.birthDate + "\n ";
        }
    }
}