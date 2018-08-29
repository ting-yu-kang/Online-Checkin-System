using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RS2015_Checkin
{
    public partial class Summary : System.Web.UI.Page
    {
        int total;
        int current;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (RS2015DBEntities entities = new RS2015DBEntities())
            {
                total = entities.Checkins.Count();
                current = (from a in entities.Checkins where a.Checkin1 == true select a).Count();
            }

            TotalLabel.Text = "總報名人數：" + Convert.ToString(total) + "<br/>";
            CurrentLabel.Text = "已報名人數：" + Convert.ToString(current) + "<br/>";
        }
    }
}