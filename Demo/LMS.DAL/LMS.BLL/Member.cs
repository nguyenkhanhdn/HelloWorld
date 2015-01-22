using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LMS.BLL
{
    public class Member
    {
        public bool CreateMember(string code, string name, string address, string phone)
        {
            //Xử lý nghiệp vụ, sau đó gọi thực hiện việc thao tác dữ liệu
            LMS.DAL.Member mObj = new LMS.DAL.Member();
            return mObj.CreateMember(code, name, address, phone);
        }
        public bool UpdateMember(string code, string name, string address, string phone)
        {
            //Xử lý nghiệp vụ, sau đó gọi thực hiện việc thao tác dữ liệu
            LMS.DAL.Member mObj = new LMS.DAL.Member();
            return mObj.UpdateMember(code, name, address, phone);
        }
        public DataTable GetMembers()
        {
            LMS.DAL.Member mobj = new LMS.DAL.Member();
            return mobj.GetMembers();
        }
    }
}
