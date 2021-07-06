using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 宾馆住宿管理系统
{
    class UserInfo
    {
        private int ID;
        private string userName;
        private string password;

        public int getID()
        {
            return ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public string getUserName()
        {
            return userName;
        }
        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
