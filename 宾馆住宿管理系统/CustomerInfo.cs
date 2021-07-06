using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 宾馆住宿管理系统
{
    class CustomerInfo
    {
        private int CusID;
        private string CusName;
        private string CusPhone;
        private string RoomNum;
        
        public int getCusID()
        {
            return CusID;
        }
        public void setCusID(int CusID)
        {
            this.CusID = CusID;
        }
        public string getCusName()
        {
            return CusName;
        }
        public void setCusName (string CusName)
        {
            this.CusName = CusName;
        }
        public string getCusPhone ()
        {
            return CusPhone;
        }
        public void setCusPhone(string CusPhone)
        {
            this.CusPhone = CusPhone;
        }
        public string getRoomNum()
        {
            return RoomNum;
        }
        public void setRoomNum(string RoomNum)
        {
            this.RoomNum = RoomNum;
        }
    }
}
