using System.Runtime.Serialization;

namespace WPC_Test.Helpers
{
    [DataContract]
    public class Location
    {
        [DataMember] public double longitude;
        [DataMember] public double latitude;
    }
}