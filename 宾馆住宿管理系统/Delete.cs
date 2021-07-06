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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Others o = new Others();
            int count1 = o.getUserCount();

            if (txDelete.Text == "")
            {
                MessageBox.Show("输入的用户名为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    string sql = "delete from  Users where Users.UserName=@username";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txDelete.Text);

                    con.Open();
                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    int count2 = o.getUserCount();

                    if (count1 > count2)
                    {
                        MessageBox.Show("删除成功！");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
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
