using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using e_commerce2.Models;
namespace e_commerce2
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var user = Context.User.Identity;
            if (user.IsAuthenticated)
            {
                
                lnkLoginn.Visible = false;
                lnkRegister.Visible = false;

                lnkLogout.Visible = true;
                litStatus.Visible = true;


                CartModel model = new CartModel();
                string userId = HttpContext.Current.User.Identity.GetUserId();
                litStatus.Text = string.Format("{0} ({1})",Context.User.Identity.Name,
                    model.GetAmountOfOrders(userId));
               
            }
            else
            {
                lnkLoginn.Visible = true;
                lnkRegister.Visible = true;

                lnkLogout.Visible = false;
                litStatus.Visible = false;
            }

        }
        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Index.aspx");
        }
        protected void lnkLogout_Click1(object sender, EventArgs e)
        {
           
        }
      
}
}