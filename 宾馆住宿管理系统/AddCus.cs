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
    public partial class AddCus : Form
    {
        public AddCus()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (tbCusName.Text == "" || tbCusPhone.Text == "")
            {
                MessageBox.Show("顾客姓名或顾客手机号为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    Others o = new Others();
                    int count = o.getCusCount();

                    con.Close();

                    string sql = "insert into Customers (CusName,CusPhone,RoomNum) values (@cusname,@cusphone,@roomnum)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cusname", tbCusName.Text);
                    cmd.Parameters.AddWithValue("@cusphone", tbCusPhone.Text);
                    cmd.Parameters.AddWithValue("@roomnum", comboBox1.SelectedItem);

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("添加顾客信息成功");
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
    }
}
