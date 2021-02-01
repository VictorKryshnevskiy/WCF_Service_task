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
            var client = new Service.ServiceClient("BasicHttpBinding_IService");
            var num = int.Parse(TextBox1.Text);
            try
            {
                Label1.Text = client.GetNumber(num);
            }
            catch (Exception )
            {
               
            }
            finally
            {
                client.Close();
            }
        }
    }
}