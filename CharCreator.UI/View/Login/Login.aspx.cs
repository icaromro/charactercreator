using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Configuration;
using CharCreator.Data.Repository;
using CharCreator.Domain.Entity;
using CharCreator.Domain.Service;

namespace CharCreator.UI.View.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            
            BaseRepository<User> repo
                 = new BaseRepository<User>();
            
            User user = new User();
            user.login = txbLogin.Text;
            user.password = txbPassword.Text;
            UserService uR = new UserService();
            UserRepository uR = new UserRepository();
            if(uR.LogIn(user))                
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Connection Open !')", true);
            else                
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Can not open connection ! ')", true);
                
            
        }
    }
}