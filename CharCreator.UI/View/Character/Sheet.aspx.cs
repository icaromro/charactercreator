using System;
using System.Web;
using System.Web.UI.WebControls;
using CharCreator.Business.Service;
using CharCreator.Model.Entity;

namespace CharCreator.UI.View.Character
{
    public partial class Sheet : System.Web.UI.Page
    {
        #region Variables
        protected long characterId { get; set; }
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
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSystems();
                characterId = 0;
                if (Request.QueryString["id"] != null)
                {
                    lblTitle.Text = "Edição de Personagem";
                    characterId = Convert.ToInt64(Request.QueryString["id"]);
                    LoadCharacter(characterId);
                }
                else
                {
                    lblTitle.Text = "Criação de Personagem";
                }
            }
        }

        private void LoadCharacter(long characterId)
        {
            CharacterService characterService = new CharacterService();
            if (characterService.VerifyCharacterOwnership(currentUser.id, characterId))
            {
                Model.Entity.Character character = characterService.GetById(characterId);
                ddlSystem.SelectedValue = character.system_id.ToString();

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('teste " + characterId + "')", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", 
                    "alert('Usuário selecionado não pertence ao usuário logado.'); " +
                    "window.location='" + Request.ApplicationPath + "View/Character/CharacterList.aspx'", true);                
            }                        
        }

        private void LoadSystems()
        {
            SystemService systemService = new SystemService();            
            ddlSystem.DataSource = systemService.GetAllActiveDataTable();
            
            ddlSystem.DataBind();
            ddlSystem.Items.Insert(0,new ListItem("Selecione", "0", true));
        }

        protected void btnSelectSystem_OnClick(object sender, EventArgs e)
        {            
            if (ddlSystem.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Por favor, selecione um sistema')", true);
            }
            else
            {
                ddlSystem.Enabled = btnSelectSystem.Visible = false;
                btnDeselectSystem.Visible = true;
                //select view according to the system selected
            }
        }

        protected void btnDeselectSystem_OnClick(object sender, EventArgs e)
        {
            btnDeselectSystem.Visible = false;
            ddlSystem.Enabled = btnSelectSystem.Visible = true;
            ddlSystem.SelectedIndex = 0;
        }
    }
}