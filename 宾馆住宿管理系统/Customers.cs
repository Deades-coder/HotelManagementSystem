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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Columns.Add("客户姓名",150);
            this.listView.Columns.Add("客户电话",200);
            this.listView.Columns.Add("客户房间");
        }

        private void check_Click(object sender, EventArgs e)
        {
            List<CustomerInfo> cList = new List<CustomerInfo>();//存放信息数据

            //加载数据库中数据  
            string conStr = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "select CusName, CusPhone, RoomNum from [Customers] ";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //reader每执行一次read操作，就会让指针往下一条数据走
                        while (reader.Read())  //如果能读到数据，一行一行地读
                        {
                            CustomerInfo customerInfo = new CustomerInfo();
                            customerInfo.setCusName(reader["CusName"].ToString());
                            customerInfo.setCusPhone(reader["CusPhone"].ToString());
                            customerInfo.setRoomNum(reader["RoomNum"].ToString());
                            cList.Add(customerInfo);
                        }
                    }
                }
            }

            this.listView.Items.Clear();

            this.listView.BeginUpdate();

            Others o = new Others();

            for (int i = 0; i < o.getCusCount(); i++)
            {
                CustomerInfo ci = cList[i];
                this.listView.Items.Add(ci.getCusName());
                this.listView.Items[i].SubItems.Add(ci.getCusPhone());
                this.listView.Items[i].SubItems.Add(ci.getRoomNum().ToString());
            }
            this.listView.EndUpdate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddCus ac = new AddCus();
            ac.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Change c = new Change();
            c.Show();
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
