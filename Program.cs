using System;
using Day2.Untils;
using Day2.Enum;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            MembersUntil membersUntil = new MembersUntil();
            var femaleMembers = membersUntil.Members.Where(m => m.Gender == Gender.Female);
            var maleMembers = membersUntil.Members.Where(m => m.Gender == Gender.Male);
            var otherMembers = membersUntil.Members.Where(m => m.Gender == Gender.Other);
            //ex1
            Console.WriteLine("Female list:");
            foreach (Member m in femaleMembers)
            {
                Console.WriteLine(m.MembersInfo);

            }
            Console.WriteLine("Male list:");
            foreach (Member m in maleMembers)
            {
                Console.WriteLine(m.MembersInfo);

            }
            Console.WriteLine("Other list:");
            foreach (Member m in otherMembers)
            {
                Console.WriteLine(m.MembersInfo);

            }
            // List<String> fullNames = membersUntil.FullNames(listmembers);
            // Console.WriteLine("List fullname: ");
            // fullNames.ForEach(m => {Console.WriteLine("Full Name: "+ m);});
            Console.WriteLine("List of less than 2000:");
            membersUntil.Members.Where(m => m.DateOfBirth.Year < 2000).Select(x => x.MembersInfo).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List of greater than 2000:");
            membersUntil.Members.Where(m => m.DateOfBirth.Year > 2000).Select(x => x.MembersInfo).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List of 2000:");
            membersUntil.Members.Where(m => m.DateOfBirth.Year == 2000).Select(x => x.MembersInfo).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
