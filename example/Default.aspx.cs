﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JinianNet.JNTemplate;

namespace example
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JinianNet.JNTemplate.ITemplate t = BuildManager.CreateTemplate("index.html");
            t.Render(Response.Output);
        }
    }
}