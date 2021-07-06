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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("房间号",90);
            this.listView1.Columns.Add("类型",100);
            this.listView1.Columns.Add("价格",100);
            this.listView1.Columns.Add("状态",100);
            this.listView1.Columns.Add("可住人数",100);
            this.listView1.Columns.Add("开始日期", 100);
            this.listView1.Columns.Add("结束日期", 100);
        }

        private void check_Click(object sender, EventArgs e)
        {
            List<RoomInfo> rList = new List<RoomInfo>();//存放信息数据
            int count;

            //加载数据库中数据  
            string conStr = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    string type = comboBox2.Text;
                    string state = comboBox1.Text;
                    string startday = bDay1.Text;
                    string endday = bDay2.Text;
                    if (startday == "")
                    {
                        startday = "0";
                    }
                    if (endday == "")
                    {
                        endday = "31";
                    }
                    if (int.Parse(startday) > int.Parse(endday))
                    {
                        MessageBox.Show("请输入正确的开始日期和结束日期！");
                    }
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@day1", startday);
                    cmd.Parameters.AddWithValue("@day2", endday);
                    if (type == "" && state == "")
                    {
                        cmd.CommandText = "select No,Type,Price,State,Num,Startday,Endday from [Room] where Startday>=@day1 and Endday<=@day2";
                    }
                    else if (type != "" && state == "")
                    {
                        cmd.CommandText = "select No,Type,Price,State,Num,Startday,Endday from [Room] where Type=@type,Startday>=@day1 and Endday<=@day2";
                    }
                    else if (type == "" && state != "")
                    {
                        cmd.CommandText = "select No,Type,Price,State,Num,Startday,Endday from [Room] where State=@state,Startday>=@day1 and Endday<=@day2";
                    }
                    else
                    {
                        cmd.CommandText = "select No,Type,Price,State,Num,Startday,Endday from [Room] where State=@state and Type=@type and Startday>=@day1 and Endday<=@day2";
                    }

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    count = dt.Rows.Count;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //reader每执行一次read操作，就会让指针往下一条数据走
                        while (reader.Read())  //如果能读到数据，一行一行地读
                        {
                           RoomInfo roomInfo = new RoomInfo();
                            roomInfo.setNo(reader["No"].ToString());
                            roomInfo.setType(reader["Type"].ToString());
                            roomInfo.setPrice(int.Parse(reader["Price"].ToString()));
                            roomInfo.setState(reader["State"].ToString());
                            roomInfo.setNum(int.Parse(reader["Num"].ToString()));
                            roomInfo.setstartday(int.Parse(reader["Startday"].ToString()));
                            roomInfo.setendday(int.Parse(reader["Endday"].ToString()));
                            rList.Add(roomInfo);
                        }
                    }
                }
            }

            this.listView1.Items.Clear();

            this.listView1.BeginUpdate();


            for (int i = 0; i < count; i++)
            {
               RoomInfo ri = rList[i];
               this.listView1.Items.Add(ri.getNo());
               this.listView1.Items[i].SubItems.Add(ri.getType());
               this.listView1.Items[i].SubItems.Add(ri.getPrice().ToString());
               this.listView1.Items[i].SubItems.Add(ri.getState());
               this.listView1.Items[i].SubItems.Add(ri.getNum().ToString());
                this.listView1.Items[i].SubItems.Add(ri.getstartday().ToString());
                this.listView1.Items[i].SubItems.Add(ri.getendday().ToString());
            }
            this.listView1.EndUpdate();
        }


       
        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
