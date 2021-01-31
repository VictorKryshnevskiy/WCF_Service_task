using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var num = int.Parse(TextBox1.Text);
            var client = new Service.ServiceClient("BasicHttpBinding_IService");
            Label1.Text = client.GetNumber(num);
            client.Close();
        }
    }
}