using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestString : System.Web.UI.Page
{
    protected string SomeValue = "test";

    protected void Page_Load(object sender, EventArgs e)
    {
        SomeValue = "123";
    }
}