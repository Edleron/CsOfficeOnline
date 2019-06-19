﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormUI
{
    public partial class Section : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Users"] != null)
            {
                lblUserTitle.Text = Session["Users"].ToString();
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnCategories_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataAccess.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }
    }
}