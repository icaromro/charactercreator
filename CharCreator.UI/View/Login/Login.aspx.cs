using System;
using System.Web;
using CharCreator.Data.Repository;
using CharCreator.Business.Service;
using CharCreator.Model.Entity;

namespace CharCreator.UI.View.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            UserService userService = new UserService();            
            
            User user = new User();
            user.login = txbLogin.Text;
            user.password = txbPassword.Text;

            if (userService.LogIn(ref user))
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Login OKAY !')", true);
                HttpContext.Current.Session["User"] = user;
                Response.Redirect("~/View/Character/CharacterList.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Erro no login! ')",
                    true);


        }
    }
}