using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GymWcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int CreateMember(GymMember member);
    }
    [DataContract]
    public class GymMember
    {
        [DataMember]
        public string MemberCode { get; set; }
        [DataMember]
        public string MemberName { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public long PhoneNumber { get; set; }
        [DataMember]
        public DateTime MemberShipStartDate { get; set; }
        [DataMember]
        public string MemberShipDuration { get; set; }

    }

    
    
}
