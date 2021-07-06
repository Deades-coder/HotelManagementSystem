using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 宾馆住宿管理系统
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Columns.Add("用户名", 200);
            this.listView.Columns.Add("密码", 300);
        }

        private void check_Click(object sender, EventArgs e)
        {
            List<UserInfo> uList = new List<UserInfo>();//存放信息数据

            //加载数据库中数据  
            string conStr = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "select UserName, Password from [Users] ";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //reader每执行一次read操作，就会让指针往下一条数据走
                        while (reader.Read())  //如果能读到数据，一行一行地读
                        {
                            UserInfo userInfo = new UserInfo();
                            userInfo.setUserName(reader["UserName"].ToString());
                            userInfo.setPassword(reader["Password"].ToString());
                            uList.Add(userInfo);
                        }
                    }
                }
            }

            this.listView.Items.Clear();

            this.listView.BeginUpdate();

            Others o = new Others();

            for (int i = 0; i < o.getUserCount(); i++)
            {
                UserInfo ui = uList[i];
                this.listView.Items.Add(ui.getUserName());
                this.listView.Items[i].SubItems.Add(ui.getPassword());
            }
            this.listView.EndUpdate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
