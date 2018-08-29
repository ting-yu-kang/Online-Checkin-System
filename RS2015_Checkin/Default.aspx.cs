using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RS2015_Checkin
{
    public partial class Default : System.Web.UI.Page
    {
        List<Student> ListZip = new List<Student>();
        bool processing = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (RS2015DBEntities entities = new RS2015DBEntities())
                {
                    TotalLabel.Text = "總報名人數：" + Convert.ToString(entities.Checkins.Count()) + "<br/>";
                    CurrentLabel.Text = "已報到人數：" + Convert.ToString((from a in entities.Checkins where a.Checkin1 == true select a).Count());
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (processing) return;
            processing = true;

            Label2.Visible = false;
            ListZip.Clear();
            string digits = TextBox1.Text;
            using (RS2015DBEntities entities = new RS2015DBEntities())
            {
                var user = (from a in entities.Checkins
                            where a.Phone.Contains(digits)
                            select a).ToList();
                if (user.Count() == 0)
                {
                    Label1.Visible = true;
                    Label1.Text = "Not found!!!";
                    processing = false;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    return;
                }
                Label1.Visible = false;
                foreach (var item in user)
                {
                    ListZip.Add(new Student(item.ID, item.Name, item.Phone, item.School, item.Department, item.Grade));
                }
                GridView1.DataSource = ListZip;
                GridView1.DataBind();
            }
            processing = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (processing) return;
            processing = true;

            Label2.Visible = false;
            ListZip.Clear();
            string name = TextBox2.Text;
            using (RS2015DBEntities entities = new RS2015DBEntities())
            {
                var user = (from a in entities.Checkins
                            where a.Name.Contains(name)
                            select a).ToList();
                if (user.Count() == 0)
                {
                    Label1.Visible = true;
                    Label1.Text = "Not found!!!";
                    processing = false;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    return;
                }
                Label1.Visible = false;
                foreach (var item in user)
                {
                    ListZip.Add(new Student(item.ID, item.Name, item.Phone, item.School, item.Department, item.Grade));
                }
                GridView1.DataSource = ListZip;
                GridView1.DataBind();
            }
            processing = false;
        }

        public class Student
        {
            public Student(int iD, string name, string phone, string school, string department, string grade)
            {
                ID = iD;
                Name = name;
                Phone = phone;
                School = school;
                Department = department;
                Grade = grade;
            }

            public int ID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string School { get; set; }
            public string Department { get; set; }
            public string Grade { get; set; }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Checkin") {
                Button BTN = (Button)e.CommandSource;
                GridViewRow myRow = (GridViewRow)BTN.NamingContainer;
                int id = Convert.ToInt32(GridView1.Rows[myRow.DataItemIndex].Cells[1].Text);
                
                GridView1.DataSource = null;
                GridView1.DataBind();

                using (RS2015DBEntities entities = new RS2015DBEntities())
                {
                    var user = (from a in entities.Checkins
                                where a.ID == id
                                select a).FirstOrDefault();
                    user.Checkin1 = true;
                    entities.SaveChanges();
                    Label2.Visible = true;
                    Label2.Text = user.Name + " 同學簽到成功！";
                    CurrentLabel.Text = "已報到人數：" + Convert.ToString((from a in entities.Checkins where a.Checkin1 == true select a).Count());
                }
            }
        }
    }
}