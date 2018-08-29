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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //使用SqlConnection 来连接数据库
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //创建sql 查询语句  
                string sql = "select MUserPwd from MovieAccount where MUserName ='" + txtName.Text + "'";
                //创建 SqlCommand 执行指令
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //打开数据库连接
                    conn.Open();
                    //使用 SqlDataReader 来 读取数据库  
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        //SqlDataReader 在数据库中为 从第1条数据开始 一条一条往下读 
                        if (sdr.Read())  //如果读取账户成功(文本框中的用户名在数据库中存在)
                        {
                            //则将第1条 密码 赋给 字符串pwd  ,并且依次往后读取 所有的密码
                            //Trim()方法为移除字符串前后的空白
                            string pwd = sdr.GetString(0).Trim();
                            //如果 文本框中输入的密码 ==数据库中的密码
                            if (pwd == txtPwd.Text)
                            {
                                //说明在该账户下 密码正确, 系统登录成功
                                MessageBox.Show("Login Succeed, entering to main page...");
                                FrmManager manager = new FrmManager();
                                manager.Show();
                                this.Hide();
                            }
                            else
                            {
                                //否则密码错误 再次输入密码
                                MessageBox.Show("Wrong Password, please try again");
                                //并自动将当前密码 清空
                                txtPwd.Text = "";
                            }
                        }
                        else
                        {
                            //如果读取账户数据失败, 则用户名不存在
                            MessageBox.Show("User not found!");
                            //并自动清空账户名
                            txtName.Text = "";
                        }
                    }
                }
            }
        }
    }
}
