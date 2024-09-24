using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_commerce2.Pages.Management
{
    public partial class Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

      

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
            string AR_Ref = row.Cells[1].Text;
            Response.Redirect("~/Pages/Management/ManageArticle.aspx?AR_Ref=" + AR_Ref);
        }
    }
}