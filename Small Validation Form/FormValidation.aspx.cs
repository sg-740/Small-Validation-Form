﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Small_Validation_Form
{
    public partial class FormValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Data Save Successfully!')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("What Is Your Name: ");

        }
    }
}