using System;
using System.Collections.Generic;
using D1.Implement;

namespace D1
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Member> list = new List<Member>() {
            new Member
            {
                FirstName="Tuan",
                LastName="Phong",
                Gender=Member.Gender1.Male,
                BirthDay= new DateTime(2000,01,01),
                Phone="0963199204",
                
                Place="HP",
                Graduated=true
            },
            new Member
            {
                FirstName="Van",
                LastName="Phuc",
                Gender=Member.Gender1.Male,
                BirthDay= new DateTime(1999,01,01),
                Phone="0963199204",
               
                Place="HN",
                Graduated=true
            },
            new Member
            {
                FirstName="Dinh",
                LastName="Huy",
                Gender=Member.Gender1.Female,
                BirthDay= new DateTime(2050,01,01),
                Phone="0963199204",
               
                Place="BN",
                Graduated=true
            }

             };


            Class m = new Class(list);
            ClassImplement cl = new ClassImplement();


            while (true)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Return a list of members who is Male");
                Console.WriteLine("2. Return the oldest one based on “Age” ");
                Console.WriteLine("3. Return a new list that contains Full Name only");
                Console.WriteLine("4.  Return 3 lists");
                Console.WriteLine("5.  Return the first person who was born in Ha Noi");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("1. Return a list of members who is Male");

                            cl.GetMemberByGender(list, Member.Gender1.Male);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("2. Return the oldest one based on “Age” ");
                            cl.GetMemberOldest(list);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("3. Return a new list that contains Full Name only");
                            // m.ShowFullName();
                            cl.GetMemberFullName(list);
                            break;
                        }


                    case 4:
                        {
                            Console.WriteLine("4.  Return 3 lists");
                             cl.SlitMembersByBirthYear(list);
                            break;

                        }
                    case 5:

                        {

                            Console.WriteLine("5.  Return the first person who was born in Ha Noi");
                            //  m.PlaceHN();
                            cl.GetMembersInPlace(list, "HN");
                            break;

                        }
                    case 0:
                        {
                            Console.WriteLine("Exit System");
                            return;

                        }
                    default:
                        {
                            break;
                        }


                }
            }
        }
    }
}
