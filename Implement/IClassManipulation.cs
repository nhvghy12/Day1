using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static D1.Member;

namespace D1.Implement
{
    public interface IClassManipulation
    {
        public List<Member> GetMemberByGender(List<Member> members,
                                       Gender1 gender);
        public Member GetMemberOldest(List<Member> members);
        public List<string> GetMemberFullname(List<Member> members);
        public List<Member> GetMemberInPlace(List<Member> members, string place);
        public Tuple<List<Member>, List<Member>, List<Member>> SlitMembersByBirthYear(List<Member> list);

    }
}