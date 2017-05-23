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
                btnSelectSystem_OnClick(null, null);
                ddlSystem.Enabled = btnSelectSystem.Visible = btnDeselectSystem.Visible = false;

                switch (character.system_id)
                {
                    case 1:
                        Load3detCharacter(characterId);
                        break;
                    default:
                        break;
                }                                
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", 
                    "alert('Personagem selecionado não pertence ao usuário logado.'); " +
                    "window.location='" + Request.ApplicationPath + "View/Character/CharacterList.aspx'", true);                
            }                        
        }

        protected void Load3detCharacter(long characterId)
        {
            Character3detService character3DetService = new Character3detService();
            Character3det selectedCharacter = character3DetService.GetById(characterId);
            txbName.Enabled = ddlScale.Enabled = ddlSex.Enabled = false;
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
                mvCharacterSheets.Visible = btnDeselectSystem.Visible = true;
                mvCharacterSheets.ActiveViewIndex = Convert.ToInt32(ddlSystem.SelectedValue);                
                //select view according to the system selected
            }
        }

        protected void btnDeselectSystem_OnClick(object sender, EventArgs e)
        {
            mvCharacterSheets.Visible = btnDeselectSystem.Visible = false;
            ddlSystem.Enabled = btnSelectSystem.Visible = true;
            mvCharacterSheets.ActiveViewIndex = ddlSystem.SelectedIndex = 0;
        }

        

        #region DropDownLists_Init

        protected void ddlScale_OnInit(object sender, EventArgs e)
        {
            ScaleService scaleService = new ScaleService();
            ddlScale.DataSource = scaleService.GetAllDataTable();
            ddlScale.DataBind();            
        }

        protected void ddlSystem_OnInit(object sender, EventArgs e)
        {
            SystemService systemService = new SystemService();
            ddlSystem.DataSource = systemService.GetAllActiveDataTable();
            ddlSystem.DataBind();
            ddlSystem.Items.Insert(0, new ListItem("Selecione", "0", true));
        }

        #endregion
    }
}