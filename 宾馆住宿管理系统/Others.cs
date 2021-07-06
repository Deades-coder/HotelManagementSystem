using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 宾馆住宿管理系统
{
    class Others
    {
        public int getUserCount()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

            string sql = "select * from Users";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = dt.Rows.Count;

            return count;
        }

        public int getCusCount()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

            string sql = "select * from Customers";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = dt.Rows.Count;

            return count;
        }

        public int getRoomCount()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

            string sql = "select * from Room";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = dt.Rows.Count;

            return count;
        }
    }
}
