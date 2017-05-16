using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Configuration;
using CharCreator.Data.Repository;
using CharCreator.Domain.Entity;

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
            
            try
            {
                repo.OpenConnection();                    
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Connection Open !')", true);               
                repo.CloseConnection();
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Can not open connection ! ')", true);                
                
            }
        }
    }
}