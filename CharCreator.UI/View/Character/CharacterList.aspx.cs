using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharCreator.UI.View.Character
{
    public partial class CharacterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCharacters.DataSource = null;
            gvCharacters.DataBind();
        }
    }
}