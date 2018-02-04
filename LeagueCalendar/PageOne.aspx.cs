using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeagueCalendar
{
    public partial class PageOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // TODO: fill in the UI
            }
        }

        protected void MatchesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: show the match's date based on the index...
        }
    }
}