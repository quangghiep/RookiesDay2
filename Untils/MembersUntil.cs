using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day2.Enum;

namespace Day2.Untils
{
    public class MembersUntil
    {
        public List<Member> Members;
        public MembersUntil() 
        {
            Members = InitMembers();
        }
        private List<Member> InitMembers()
        {
            return new List<Member>{
                new Member{
                    FirstName ="Vu",
                    LastName ="Hiep",
                    Gender = Gender.Female,
                    DateOfBirth  =new DateTime(2000,1,11),
                    PhoneNumber = "123456788",
                    BirthPlace = "HY",
                    IsGraduated = false,
                },
                new Member{
                    FirstName = "Vo",
                    LastName = "Huy",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1999,1,11),
                    PhoneNumber = "123400088",
                    BirthPlace = "HN",
                    IsGraduated = false,
                },
                new Member{
                    FirstName = "V",
                    LastName = "Hy",
                    Gender = Gender.Other,
                    DateOfBirth = new DateTime(2001,1,11),
                    PhoneNumber = "123400088",
                    BirthPlace = "HN",
                    IsGraduated = false,
                },
            };
        }
        public Member OldestAge(List<Member> members)
        {
            return members.Where(m => m.Age == members.Max(m => m.Age)).FirstOrDefault();
        }
        public Member HNMember(List<Member> members)
        {
            return members.Where(m => m.BirthPlace == "HN").FirstOrDefault();
        }
        public List<string> FullNames(List<Member> members)
        {
            return members.Select(mem => mem.FullName).ToList();
        }
        // public Member MemberByBirthPlace(string birthPlace)
        // {
        //     Member result = (from member in Members 
        //                     where member.BirthPlace == birthPlace
        //                     select member).FirstOrDefault();
        //     return result;
        // }
    }
}