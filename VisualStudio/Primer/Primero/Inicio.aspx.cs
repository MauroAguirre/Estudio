using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Primero
{
    public partial class Inicio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                List < string > wopa = new List<string>();
                wopa.Add("+");
                wopa.Add("-");
                lbx1.DataSource 
            }
            
            
        }

    }
}