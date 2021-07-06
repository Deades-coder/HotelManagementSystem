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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            this.Close();
            a.Show();
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            if (CusName.Text == "" || RoomNum.Text == "")
            {
                MessageBox.Show("顾客姓名或房间号为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
                try
                {
                    string sql = "update Room set Room.State='未入住',Room.StartDay=0,Room.EndDay=0 where Room.No=@room and Room.state = '已入住'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", CusName.Text);
                    cmd.Parameters.AddWithValue("@room", RoomNum.Text);
                    con.Open();

                    int count = cmd.ExecuteNonQuery();

                    if (count <= 0)
                    {
                        MessageBox.Show("操作失败！");
                    }

                    con.Close();

                    sql = "update Customers set Customers.RoomNum='未入住' where Customers.CusName=@name";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", CusName.Text);

                    con.Open();

                    count = cmd.ExecuteNonQuery();
                    if (count <= 0)
                    {
                        MessageBox.Show("操作失败！");
                    }
                    MessageBox.Show("操作成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }
}
