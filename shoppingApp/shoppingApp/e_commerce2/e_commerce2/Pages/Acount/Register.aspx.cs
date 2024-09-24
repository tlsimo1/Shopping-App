using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using e_commerce2.Models;

namespace e_commerce2.Pages.Acount
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();


            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["WebShopeConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            IdentityUser user = new IdentityUser();
            user.UserName = txtUserName.Text;
            if(txtPassword.Text==txtConfirmPassword.Text)
            {

                try
                {
                    IdentityResult result = manager.Create(user,txtPassword.Text);
                    if(result.Succeeded)
                    {
                        UserInformation info = new UserInformation
                        {
                            Adress=txtAdress.Text,
                            FirstName=txtFirstName.Text,
                            LastName=txtLastName.Text,
                            PostalCode=Convert.ToInt32(txtPostalCode.Text),
                            GUID=user.Id
                        };

                        UserInfoModel model = new UserInfoModel();
                        model.InsertUserDetail(info);

                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                        var userIdentity = manager.CreateIdentity(user,DefaultAuthenticationTypes.ApplicationCookie);

                        authenticationManager.SignIn(new AuthenticationProperties(),userIdentity);
                        Response.Redirect("~/Index.aspx");
                    }
                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch( Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }
            }
            else
            {
                litStatus.Text = "Password must match???";
            }
        }
    }
}