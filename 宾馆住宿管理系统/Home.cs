using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace 宾馆住宿管理系统
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void 房间管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room a = new Room();
            this.Close();
            a.Show();
        }

        private void 成员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            this.Close();
            u.Show();
        }

        private void 顾客信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            this.Close();
            c.Show();
        }

        private void 预订房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserve r = new Reserve();
            this.Close();
            r.Show();
        }

        private void 登记入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn oo = new CheckIn();
            this.Close();
            oo.Show();
        }

        private void 退房结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut ll = new CheckOut();
            this.Close();
            ll.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 房间信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
