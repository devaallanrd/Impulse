
using Arduino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class Default : System.Web.UI.Page
    {
        //private PresentadorListaUsuarios _presenter;
       

        protected void Page_Init(object sender, EventArgs e)
        {
          
           // Service.ServicioUsuario servicioUsuario = ObjectFactory.GetInstance<Service.ServicioUsuario>();
           // _presenter = new PresentadorListaUsuarios(this, servicioUsuario);
          //  this.ddlTipoUsuario.SelectedIndexChanged += delegate { _presenter.Display(); };
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

       /* public void Display(IList<Service.UsuarioViewModel> Usuarios)
        {
            //rptUsuarios.DataSource = Usuarios;
           // rptUsuarios.DataBind();
        }*/



        public string ErrorMessage
        {
            set { lblErrorMessage.Text = String.Format("<p><strong>Error</strong><br/>{0}<p/>", value); }
        }

    }
}