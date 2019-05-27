using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GymWcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int CreateMember(GymMember member)
        {
            SqlConnection cn = ConnectToDB();
            string query = "insert into GymMember values(@MemberCode,@MemberName,@EmailId,@PhoneNumber,@MemberShipStartDate,@MemberShipDuration)";
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.Parameters.AddWithValue("@MemberCode", member.MemberCode);
            cmd.Parameters.AddWithValue("@MemberName", member.MemberName);
            cmd.Parameters.AddWithValue("@EmailId", member.EmailId);
            cmd.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
            cmd.Parameters.AddWithValue("@MemberShipStartDate", member.MemberShipStartDate);

            cmd.Parameters.AddWithValue("@MemberShipDuration",member.MemberShipDuration);
            return cmd.ExecuteNonQuery();
        }

        private SqlConnection ConnectToDB()
        {
            string cs = "server=localhost;uid=sa;pwd=123;database=M3Sample";
            SqlConnection cn = new SqlConnection(cs);

            cn.Open();
            return cn;
        }
    }
}