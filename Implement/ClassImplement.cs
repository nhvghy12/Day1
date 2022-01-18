using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D1;
using static D1.Member;

namespace D1.Implement
{
    public class ClassImplement : IClassManipulation
    {
        public List<Member> GetMemberByGender(List<Member> members,
                                              Gender1 gender)
        {
            List<Member> membersByGender = new List<Member>();
            foreach (var m in members)
            {
                if (m.Gender == gender)
                {
                    m.Show();
                }
            }
            return members;
        }
        public List<string> GetMemberFullname(List<Member> members)
        {
            var rs = new List<String>();
          
            foreach (var item in members)
            {
               String fullName = item.FirstName + " " + item.LastName;
               Console.WriteLine(fullName);
            }
            return rs;
        }

        public List<Member> GetMemberInPlace(List<Member> members , string place)
        {
            foreach (var item in members)
            {
                if (item.Place.Equals(place))
                {
                    item.Show();
                }
            }
            return members;
        }

        public Member GetMemberOldest(List<Member> members)
        {
            var oldest = members[0];
            for (var i = 1; i < members.Count; i++)
            {
                var member = members[i];
                if (member.CompareTo(oldest) > 0)
                {
                    oldest = member;

                }
            }
            Console.WriteLine(oldest);
            return oldest;
        }
        public Tuple<List<Member>, List<Member>, List<Member>> SlitMembersByBirthYear(List<Member> list)
        {
            var list1 = new List<Member>();
            var list2 = new List<Member>();
            var list3 = new List<Member>();
            foreach(var item in list)
            {
                var birthYear = item.BirthDay.Year;
                switch (birthYear)
                {
                    case 2000:
                        list1.Add(item);
                        item.Show();
                        break;
                    case > 2000:
                        list2.Add(item);
                        item.Show();
                        break;
                    case < 2000:
                        list3.Add(item);
                        item.Show();
                        break;

                }
            }
            return Tuple.Create(list1, list2, list3);
        }

        internal void GetMemberFullName(List<Member> list)
        {
            throw new NotImplementedException();
        }

        internal void GetMembersInPlace(List<Member> list, string v)
        {
            throw new NotImplementedException();
        }
    }
}