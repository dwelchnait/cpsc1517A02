using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //NO DB temporary List<T>
        public static List<CEntry> Entries;

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";

            if (!Page.IsPostBack)
            {
                Entries = new List<CEntry>();
            }
        }
    }
}