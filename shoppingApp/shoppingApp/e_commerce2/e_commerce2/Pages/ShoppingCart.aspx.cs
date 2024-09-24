using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using e_commerce2.Models;

namespace e_commerce2.Pages
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();

            
            GetPurchasesInCart(userId); 
        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel cartModel = new CartModel();
            double subTotal = 0;

            List<cart> purchaseList = cartModel.GetOrdersInCart(userId);

            CreateShopTable(purchaseList, out  subTotal);



            double vat = subTotal * 0.21;
            double totalAmount = subTotal + 15 + vat;

            litTotal.Text = "DH " + subTotal;
            litVat.Text = "DH " + vat;
            litTotalAmount.Text = "DH " + totalAmount;
        }

        private void CreateShopTable(List<cart> purchaseList, out double subTotal)
        {
            subTotal = new double();
            ArticleModel model = new ArticleModel();

            foreach (cart cart in purchaseList)
            {

                ARTICLEE article = model.getArticle(cart.ArticleRef);

                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Images/Multimedia/{0}", article.AR_Photo),
                    PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", article.AR_Ref)
                };

                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.ID),
                    Text = "Delete Item",
                    ID = "del" + cart.ID,
                };

                lnkDelete.Click += Delete_item;


                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.ID.ToString()
                };
                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Amount.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;


                Table table = new Table { CssClass = "CartTable" };
                TableRow row1 = new TableRow();
                TableRow row2 = new TableRow();

                TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell cell1_2 = new TableCell
                {
                    Text = string.Format("<h4>{0}</h4><br />{1}<br/>In Stock",
                    article.AR_Design, "Item No:" + article.AR_Ref),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350,
                };

                TableCell cell1_3 = new TableCell { Text = "Unit Price<hr/>" };
                TableCell cell1_4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell cell1_5 = new TableCell { Text = "Item Total<hr/>" };
                TableCell cell1_6 = new TableCell();

                TableCell cell2_1 = new TableCell();
                TableCell cell2_2 = new TableCell { Text = "" + article.AR_PrixAch };
                TableCell cell2_3 = new TableCell();
                TableCell cell2_4 = new TableCell { Text = " " + Math.Round((cart.Amount * (double)article.AR_PrixAch), 2) };
                TableCell cell2_5 = new TableCell();




                cell1_1.Controls.Add(btnImage);
                cell1_6.Controls.Add(lnkDelete);
                cell2_3.Controls.Add(ddlAmount);


                row1.Cells.Add(cell1_1);
                row1.Cells.Add(cell1_2);
                row1.Cells.Add(cell1_3);
                row1.Cells.Add(cell1_4);
                row1.Cells.Add(cell1_5);
                row1.Cells.Add(cell1_6);

                row2.Cells.Add(cell2_1);
                row2.Cells.Add(cell2_2);
                row2.Cells.Add(cell2_3);
                row2.Cells.Add(cell2_4);
                row2.Cells.Add(cell2_5);
                table.Rows.Add(row1);
                table.Rows.Add(row2);
                pnlShoppingCart.Controls.Add(table);


                subTotal += Math.Round((cart.Amount * (double)article.AR_PrixAch), 2);
            }


            Session[User.Identity.GetUserId()] = purchaseList;
        }

        private void Delete_item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            var cartModel = new CartModel();
            cartModel.DeleteCart(cartId);

            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

       

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DropDownList selectedList = (DropDownList)sender;
            int cartId = Convert.ToInt32(selectedList.ID);
            int quantity = Convert.ToInt32(selectedList.SelectedValue);

            
            CartModel cartModel = new CartModel();
            cartModel.UpdateQuantity(cartId, quantity);
            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

       
       
    }
}