using System;
using Day2.Enum;

namespace Day2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public bool IsGraduated { get; set; }
        public string MembersInfo
        {
            get
            {
                string member = string.Concat("First Name: ", this.FirstName, " Last Name: ", this.LastName," Gender: ", this.Gender, " Date Of Birth: ", this.DateOfBirth, " Phone Number: ", this.PhoneNumber, " Birth Place: ", this.BirthPlace, " Age: ", this.Age);
                return member;
            }
        }
        public string FullName
        {
            get
            {
                return this.FirstName + this.LastName;
            }
        }
    }
}