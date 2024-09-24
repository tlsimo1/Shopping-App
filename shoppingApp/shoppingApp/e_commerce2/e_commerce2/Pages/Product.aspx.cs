using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_commerce2.Models;
using Microsoft.AspNet.Identity;

namespace e_commerce2.Pages
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            //Get selected product data
            if (!string.IsNullOrWhiteSpace(Request.QueryString["AR_Ref"]))
            {
                string AR_Ref = Request.QueryString["AR_Ref"];
                ArticleModel  model = new ArticleModel();
                ARTICLEE article = model.getArticle(AR_Ref);

                //Fill page with data
                lblTitle.Text = article.AR_Design;
                lblDescription.Text = article.AR_Design;
                lblPrice.Text = "Price per unit:<br/>£ " + article.AR_PrixAch;
                imgProduct.ImageUrl = "~/Images/Multimedia/" + article.AR_Photo;
                lblItemNr.Text = article.AR_Ref;

                //Fill amount list with numbers 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["AR_Ref"]))
            {

                string clientId = Context.User.Identity.GetUserId();
                if(clientId !=null)
                {
                string articleRef = Request.QueryString["AR_Ref"];
                int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                cart cart = new cart
                {
                    Amount = amount,
                    ClientID = clientId,
                    DatePurchased = DateTime.Now,
                    IsInCart = true,
                    ArticleRef = articleRef
                };

                CartModel model = new CartModel();
                lblResult.Text = model.InsertCart(cart);
                }
                else
                {
                    lblResult.Text = "Please log in to Order Items ";
                }
            }
        }
    }
}