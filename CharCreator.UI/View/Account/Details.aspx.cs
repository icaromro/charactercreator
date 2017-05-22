using System;
using System.Web;
using CharCreator.Model.Entity;

namespace CharCreator.UI.View.Account
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User usuarioLogado = (User)(HttpContext.Current.Session["User"]);
            lblNome.Text = usuarioLogado.name;
            lblLogin.Text = usuarioLogado.login;
            lblRegisterDate.Text = usuarioLogado.registerDate.ToString("dd/MM/yyyy");
        }
    }
}