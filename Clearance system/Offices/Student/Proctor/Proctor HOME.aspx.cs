﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClearanceSystem.Offices.Student.Proctor
{
    public partial class Proctor_HOME : System.Web.UI.Page
    {
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            //if (Session["username"] != null)
            //{
            //    if (Session["postion"] as string != 4 + "")
            //        Response.Redirect("../../../Login.aspx");
            //}
            //else
            //    Response.Redirect("../../../Login.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["url"] = HttpContext.Current.Request.Url.AbsolutePath;
        }
    }
}