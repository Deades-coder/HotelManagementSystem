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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void changeDetail_Click(object sender, EventArgs e)
        {
            if (txCusName.Text == "" || txCusPhone.Text == "")
            {
                MessageBox.Show("顾客姓名或密码为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    string sql = "update Customers set Customers.CusPhone=@phone, Customers.RoomNum=@room where Customers.CusName=@name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", txCusName.Text);
                    cmd.Parameters.AddWithValue("@phone", txCusPhone.Text);
                    cmd.Parameters.AddWithValue("@room", comboBox1.SelectedItem);

                    con.Open();
                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MessageBox.Show("修改成功！");
                    this.Hide();
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

        private void deleteDetail_Click(object sender, EventArgs e)
        {
            Others o = new Others();
            int count1 = o.getCusCount();

            if (txCusName.Text == "" || txCusPhone.Text == "")
            {
                MessageBox.Show("顾客姓名或电话为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    string sql = "delete from Customers where Customers.CusName=@name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", txCusName.Text);

                    con.Open();
                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    int count2 = o.getCusCount();

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
