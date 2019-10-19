using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnWebServiceDB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

            if (!this.IsPostBack) {
                this.VincularDados();
            }
        }

        private void VincularDados()
        {
            ServiceDB service = new ServiceDB();
            gdvAlunos.DataSource = service.GetDados();
            gdvAlunos.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}