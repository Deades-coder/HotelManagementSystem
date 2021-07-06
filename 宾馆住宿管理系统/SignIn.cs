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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getIntoSign_Click(object sender, EventArgs e)
        {
            if (txpassword.Text == "" || txUserName.Text == "")
            {
                MessageBox.Show("用户名或密码为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    Others o = new Others();
                    int count = o.getUserCount();

                    con.Close();

                    string sql = "insert into Users (UserName,Password) values (@username,@pwd)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txUserName.Text);
                    cmd.Parameters.AddWithValue("@pwd", txpassword.Text);

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    
                    MessageBox.Show("注册成功");
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
