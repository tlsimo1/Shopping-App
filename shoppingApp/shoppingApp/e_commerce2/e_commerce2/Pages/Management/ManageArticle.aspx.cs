using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_commerce2.Models;
namespace e_commerce2.Pages.Management
{
    public partial class ManageArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetImages();

                if (!String.IsNullOrWhiteSpace(Request.QueryString["AR_Ref"]))
                {
                    string AR_Ref = Request.QueryString["AR_Ref"];
                    FillPage(AR_Ref);
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ArticleModel articlemodel = new ArticleModel();
            ARTICLEE article = CreateArticle();
            
            if(!String.IsNullOrWhiteSpace(Request.QueryString["AR_Ref"]))
            {
                string AR_Ref = Request.QueryString["AR_Ref"];
                Label1.Text = articlemodel.UpdateArticle(AR_Ref,article);
            }
            else
            {
                Label1.Text = articlemodel.InsertArticle(article);
            }
        }
        private void FillPage(string AR_Ref)
        {
            ArticleModel articlemodel = new ArticleModel();
            ARTICLEE article = articlemodel.getArticle(AR_Ref);

            TextBox1.Text = article.AR_Ref;
            TextBox2.Text = article.AR_Design;
            TextBox3.Text = article.AR_UniteVen.ToString() ;
            TextBox4.Text = article.AR_PrixAch.ToString();
            TextBox5.Text = article.AR_PrixVen.ToString();
            TextBox6.Text = article.AR_PrixTTC.ToString();
            TextBox7.Text = article.AR_SuiviStock.ToString();
            TextBox8.Text = article.AR_Publie.ToString();

            DropDownList1.SelectedValue = article.FA_CodeFamille;
            DropDownList2.SelectedValue = article.AR_Photo;


        }
        private void GetImages()
        {
            try
            {
                //Get all filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Multimedia/"));

                //Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                //Set the arrayList as the dropdownview's datasource and refresh
                DropDownList2.DataSource = imageList;
                DropDownList2.AppendDataBoundItems = true;
                DropDownList2.DataBind();
            }
            catch (Exception e)
            {
                Label1.Text = e.ToString();
            }
        }
        private ARTICLEE CreateArticle()
        {
            ARTICLEE A = new ARTICLEE();
            A.AR_Ref = TextBox1.Text;
            A.AR_Design = TextBox2.Text;
            A.FA_CodeFamille = DropDownList1.Text;
            A.AR_UniteVen = Convert.ToInt16(TextBox3.Text);
            A.AR_PrixAch = Convert.ToDecimal(TextBox4.Text);
            A.AR_PrixVen = Convert.ToDecimal(TextBox5.Text);
            A.AR_PrixTTC = Convert.ToInt16(TextBox6.Text);
            A.AR_SuiviStock = Convert.ToInt16(TextBox7.Text);
            A.AR_Publie = Convert.ToInt16(TextBox8.Text);
            A.AR_Photo = DropDownList2.Text;
            return A;
        }

        


    }
}