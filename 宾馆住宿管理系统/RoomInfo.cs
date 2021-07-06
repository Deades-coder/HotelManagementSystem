using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 宾馆住宿管理系统
{
    class RoomInfo
    {
        private string No;
        private string type;
        private int price;
        private string state;
        private int num;
        private int startday;
        private int endday;
        public int getendday()
        {
            return endday;
        }
        public void setendday(int endday)
        {
            this.endday = endday;

        }
        public int getstartday()
        {
            return startday;
        }
        public void setstartday(int startday)
        {
            this.startday = startday;
        }
        public string getNo()
        {
            return No;
        }
        public void setNo(string No)
        {
            this.No = No;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public int getPrice()
        {
            return price;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public string getState()
        {
            return state;
        }
        public void setState(string state)
        {
            this.state = state;
        }
        public int getNum()
        {
            return num;
        }
        public void setNum(int num)
        {
            this.num = num;
        }
    }

}
