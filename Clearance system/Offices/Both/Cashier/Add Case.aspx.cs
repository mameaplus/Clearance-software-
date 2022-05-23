﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ClearanceSystem.Offices.Both.Cashier
{
    public partial class Add_Case : System.Web.UI.Page
    {
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Session["url"] = HttpContext.Current.Request.Url.AbsolutePath;
            if (Session["username"] != null)
            {
                if (Session["postion"] as string != 0 + "")
                    Response.Redirect("../../../Login.aspx");
            }
            else
                Response.Redirect("../../../Login.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] != null)
            //{
            //    if (Session["postion"] as string != 0 + "")
            //        Response.Redirect("../../../Login.aspx");
            //}

        }





        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Session["id"] = (GridView1.SelectedRow.Cells[0].FindControl("id") as Label).Text;
            Session["Credit"] = (GridView1.SelectedRow.Cells[3].FindControl("Credit") as Label).Text;
            Session["Reson"] = (GridView1.SelectedRow.Cells[4].FindControl("Reson") as Label).Text;
            Session["Caseid"] = (GridView1.SelectedRow.Cells[0].FindControl("HiddenField1") as HiddenField).Value;

            if (GridView1.SelectedRow != null)
                Server.Transfer("Finance.aspx");

        }
    }
}