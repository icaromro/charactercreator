using System;
using System.Web;
using System.Web.UI.WebControls;
using CharCreator.Business.Service;
using CharCreator.Model.Entity;

namespace CharCreator.UI.View.Character
{
    public partial class CharacterList : System.Web.UI.Page
    {
        protected User currentUser
        {
            get
            {
                if (HttpContext.Current.Session["User"] == null)
                {
                    Response.Redirect("View/Login/Login.aspx");
                    return null;
                }
                else
                    return (User)(HttpContext.Current.Session["User"]);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CharacterService characterService = new CharacterService();                        
            gvCharacters.DataSource = characterService.GetUserCharacters(currentUser.id);
            gvCharacters.DataBind();
        }

        protected void gvCharacters_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "viewCharacter")
            {
                int index = Int32.Parse((string) e.CommandArgument);
                long characterId = Convert.ToInt64(gvCharacters.DataKeys[index].Values["id"]);
                //load character sheet
            }
        }

        protected void btnCreateCharacter_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Character/Sheet.aspx");
        }
    }
}