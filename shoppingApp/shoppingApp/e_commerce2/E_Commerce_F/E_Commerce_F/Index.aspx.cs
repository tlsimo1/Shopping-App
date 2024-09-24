using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_F
{
    public partial class Index : System.Web.UI.Page
    {
        int clientid = 1;
        int qte = 1;
        connection con = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {


            affichePhoto();

            addCart();
        }
        void affichePhoto()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM F_ARTICLE INNER JOIN F_FAMILLE ON F_ARTICLE.FA_CodeFamille = F_FAMILLE.FA_CodeFamille", con.Active());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        void addCart()
        {
            string price = Request.QueryString["price"];
            string AR_Ref = Request.QueryString["ref"];
            string photo = Request.QueryString["photo"];
            if (Request.QueryString.AllKeys.Contains("action"))
            {
                
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [BIJOU].[dbo].[cart]
                                                   ([client_id]
                                                   ,[QTE]
                                                   ,[price]
                                                   ,[AR_Ref]
                                                   ,[photo])
                                             VALUES
                                                   ('" + clientid + "','" + qte + "','" + float.Parse(price) + "','" + AR_Ref + "','" + photo + "')", con.Active());
            cmd.ExecuteNonQuery();
            }
        }
    }
}