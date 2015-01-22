using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS.DAL
{
    public class Member
    {
        private string connectionString;
        public Member()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LMS"].ConnectionString;
        }

        public bool CreateMember(string code, string name, string address, string phone)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("uspCreateMember", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mcode", code);
            cmd.Parameters.AddWithValue("@mname", name);
            cmd.Parameters.AddWithValue("@maddress", address);
            cmd.Parameters.AddWithValue("@mphone", phone);

            con.Open();
            int i = cmd.ExecuteNonQuery();// Thực hiện lệnh Insert
            con.Close();
            if (i > 0) b = true;
            return b;
        }
        public bool UpdateMember(string code, string name, string address, string phone)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("uspUpdateMember", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mcode", code);
            cmd.Parameters.AddWithValue("@mname", name);
            cmd.Parameters.AddWithValue("@maddress", address);
            cmd.Parameters.AddWithValue("@mphone", phone);

            con.Open();
            int i = cmd.ExecuteNonQuery();//Thuc hien lenh update
            con.Close();
            if (i > 0) b = true;
            return b;

        }

        public bool DeleteMember(string code)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("uspDeleteMember", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mcode", code);
          
            con.Open();
            int i = cmd.ExecuteNonQuery(); //Thuc hien lenh delete
            con.Close();
            if (i > 0) b = true;
            return b;

        }

        public DataTable GetMembers()
        {
            SqlConnection con = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand("uspGetMembers", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);//Lấy dữ liệu, đổ về dt
            return dt;
        }

        public DataTable GetMemberByCode(string code)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("uspGetMemberByCode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mcode", code);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);//Lấy dữ liệu, đổ về dt
            return dt;
        }
    }
}
