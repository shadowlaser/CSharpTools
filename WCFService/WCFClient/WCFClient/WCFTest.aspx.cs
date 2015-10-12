using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.WCFService;

namespace WCFClient
{
    public partial class WCFTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            UserClient user = new UserClient();

            string result = user.ShowName(this.txtName.Text);
            Response.Write(result);
        }
    }
}