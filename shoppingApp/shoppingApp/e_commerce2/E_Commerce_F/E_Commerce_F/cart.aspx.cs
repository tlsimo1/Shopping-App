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
    public partial class cart : System.Web.UI.Page
    {
        float total2 = 0;
        string total;
        connection con = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            affichecart();
        }

        void affichecart()
        {
            SqlDataAdapter da = new SqlDataAdapter(" SELECT * FROM F_ARTICLE INNER JOIN cart ON F_ARTICLE.AR_Ref = cart.AR_Ref ", con.Active());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float b;
            SqlDataAdapter da = new SqlDataAdapter(" SELECT * FROM F_ARTICLE INNER JOIN cart ON F_ARTICLE.AR_Ref = cart.AR_Ref ", con.Active());
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               
                total = dr["price"].ToString();
                b = float.Parse(total);
                int c = int.Parse(DropDownList1.Text);
                total2 = b * c;
                Label1.Text = total2.ToString();

            }
        }
            
    }
}