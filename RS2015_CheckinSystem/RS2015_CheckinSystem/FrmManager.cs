using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2015_CheckinSystem
{
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        //添加数据
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //定义一个初始值n=0, 用于判断后期是否成功插入数据
            int n = 0;
            string sql = "insert into Record(Movie_Name,Movie_Director,Date_Released) values (@Movie_Name,@Movie_Director,@Date_Released)";
            //判断插入的数据是否为空,如果为空,则提示重新插入!
            if (txtMovie.Text.Trim() == "" || txtDirector.Text.Trim() == "" || txtDate.Text.Trim() == "")
            {
                MessageBox.Show("插入数据不能为空,请按要求插入数据!");
                return;
            }
            //向数据库插入参数
            SqlParameter[] param ={
                                      new SqlParameter("@Movie_Name",txtMovie.Text),
                                      new SqlParameter("@Movie_Director",txtDirector.Text),
                                      new SqlParameter("@Date_Released",Convert.ToDateTime(txtDate.Text))

                                  };
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddRange(param);
            n = cmd.ExecuteNonQuery();
            if (n == 0)
            {
                MessageBox.Show("添加失败!");
                return;
            }
            else if (n > 0)
            {
                MessageBox.Show("添加成功!");
            }
            conn.Close();
            //调用refresh方法,在添加完成数据后 自动刷新 显示新数据
            Refresh();
        }

        //删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //使用sql删除语句
            string sql = "delete from Record where 1=1";
            //如果datagridview的当前行被选中
            if (dgvManager.CurrentRow.Selected)
            {
                //将sql语句 delete from Record where 1=1 + and Id = + 当前选中行的第0个单元格的号码(即Id号)
                sql = sql + "and Id=" + Convert.ToInt32(dgvManager.CurrentRow.Cells[0].Value.ToString());
            }
            int n = 0;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            n = cmd.ExecuteNonQuery();
            if (n == 0)
            {
                MessageBox.Show("不存在的ID!");
                return;

            }
            else if (n > 0)
            {
                MessageBox.Show("删除成功!");
            }
            conn.Close();
            //删除完后 刷新一下当前数据
            Refresh();
        }

        //将鼠标点击的datagridview 上的行内容传递给 文本框
        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取字段名为Movie_Name的单元格内容
            txtMovie.Text = dgvManager.Rows[e.RowIndex].Cells["Movie_Name"].Value.ToString();
            //同理 获取当前点击行里的 name属性为Movie_Director的单元格 获取并将其传至txtDirector 文本框
            txtDirector.Text = dgvManager.Rows[e.RowIndex].Cells["Movie_Director"].Value.ToString();
            //new一个时间对象 目的是将电影发行时间的小时,分和秒给去掉 保留到最小单位为日
            DateTime datetoDay = new DateTime().Date;
            //将当前行的日期单元格的值 赋给 时间对象datetoDay
            datetoDay = Convert.ToDateTime(dgvManager.Rows[e.RowIndex].Cells["Date_Released"].Value);
            //通过ToShortDateString()方法 将日期后的00:00:00 给剔除掉 并赋给 txtDate文本框
            txtDate.Text = datetoDay.ToShortDateString();
        }

        //更新数据操作
        private void btnSave_Click(object sender, EventArgs e)
        {
            //在对数据进行修改之前 对文本框的内容做一下检查, 如果为空 则提示重新输入
            if (txtMovie.Text.Trim() == "" || txtDirector.Text.Trim() == "" || txtDate.Text.Trim() == "")
            {
                MessageBox.Show("文本框的输入不能为空!");
                return;
            }
            //使用SQL update 更新语句
            //获取文本框中输入的内容, 通过Id进行更新(Id为当前鼠标点击行的Id)
            string sqlUpdate = "update Record set Movie_Name ='" + txtMovie.Text + "',Movie_Director ='"
             + txtDirector.Text + "',Date_Released='" + txtDate.Text +
            "'where Id='" + dgvManager.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
            conn.Open();
            int n = cmdUpdate.ExecuteNonQuery();
            if (n == 0)
            {
                //提示更新失败
                MessageBox.Show("更新失败!");
                return;// 并且返回
            }
            else if (n > 0)
            {
                //否则更新成功
                MessageBox.Show("恭喜你!更新成功!");
            }
            //执行完数据更新操作后 需要关闭数据库 节省资源
            conn.Close();
            //更新完以后  调用刷新方法,将更新后的数据 显示在datagridview上面
            Refresh();
        }

        //查看并刷新所有数据
        private void btnView_Click(object sender, EventArgs e)
        {
            string sql = "select Id,Movie_Name,Movie_Director,Date_Released from Record";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dgvManager.DataSource = dt;
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'movieDataSet.Record' 資料表。您可以視需要進行移動或移除。
            this.recordTableAdapter.Fill(this.movieDataSet.Record);

        }


    }
}
