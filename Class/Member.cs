using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace D1
{
    public class Member : IComparable
    {

        public Member(string firstName, DateTime birthDay)
        {
            this.FirstName = firstName;
            this.BirthDay = birthDay;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum Gender1 { Male, Female, Other }
        private Gender1 gender1;

        public Gender1 Gender
        {
            get { return gender1; }
            set { gender1 = value; }
        }


        public DateTime BirthDay { get; set; }

        public string Phone { get; set; }
        public string Place { get; set; }
        public  uint Age
        {
            get
            {
                return (uint)(DateTime.Now.Year - BirthDay.Year);
            }
        }
        public bool Graduated { get; set; }

        public Member() { }
        public Member(string fistname, string lastname, Gender1 gender, DateTime birth, string phone, string place, bool graduated)
        {
            FirstName = fistname;
            LastName = lastname;
            Gender = gender;
            BirthDay = birth;
            Phone = phone;
            Place = place;
           
            Graduated = graduated;
        }

        public void Show()
        {
            Console.WriteLine(FirstName + "\t" + LastName + "\t" + Gender + "\t" + BirthDay.ToString("yyyy/MM/dd") + "\t" + Phone + "\t" + Place + "\t" + Age + "\t" + Graduated);

            //Console.WriteLine($"{FirstName} {LastName} {Gender} {BirthDay.ToString("dd/MM/yyyy")} {Place} {Phone} {Age} {Graduated}");

        }



        public string FullName
        {
            get { return FirstName + LastName; }
        }


        public int ToTalDays
        {
            get
            {
                return (int)(DateTime.Now - BirthDay).TotalDays;
            }
        }
        public int CompareTo(object obj)
        {
            return ToTalDays.CompareTo((Member)obj);
        }

    }
}
