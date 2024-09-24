using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_commerce2.Models;

namespace e_commerce2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            ArticleModel model = new ArticleModel();
            List<ARTICLEE> articles = model.GetAllArticle();

            if (articles != null)
            {
                foreach (ARTICLEE article in articles)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Multimedia/" + article.AR_Photo,
                        CssClass = "productImage",
                        PostBackUrl = string.Format("~/Pages/Product.aspx?AR_Ref={0}", article.AR_Ref)
                    };
                    Label lblName = new Label
                    {
                        Text = article.AR_Design,
                        CssClass = "productDesign"
                    };
                    Label lblPrice = new Label
                    {
                        Text = "DH " + article.AR_PrixAch,
                        CssClass = "productPrixAch"
                    };

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblPrice);

                    //Add dynamic controls to static control
                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
            }
        }
    }
}