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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SignIn u = new SignIn();
            u.Show();
        }

        private void LoginSystem_Click(object sender, EventArgs e)
        {
            if (txUserName.Text == "" || txPassword.Text == "")
            {
                MessageBox.Show("帐号或密码为空");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                try
                {
                    string sql = "select * from  Users where Users.UserName=@username and Users.Password=@pwd";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txUserName.Text);
                    cmd.Parameters.AddWithValue("@pwd", txPassword.Text);

                    con.Open();
                    //cmd.Connection = con;
                    Console.WriteLine(sql);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！");
                        this.Hide();
                        Home h = new Home();
                        h.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
