using System.Runtime.Serialization;

namespace VotingSystemAPI.Models
{
    public static class Votingenum
    {
        public enum Parties
        {
            [EnumMember(Value = "MK")]
            MK,
            [EnumMember(Value = "DA")]
            DA,
            [EnumMember(Value = "EFF")]
            EFF,
            [EnumMember(Value = "MKP")]
            MKP,
            [EnumMember(Value = "IFP")]
            IFP,
            [EnumMember(Value = "Action SA")]
            ActionSA,
            [EnumMember(Value = "FF")]
            FF,
            [EnumMember(Value = "Other")]
            Other
        }
    }
}
