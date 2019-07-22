using System;

namespace Exercise1.Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new People("Marry", true, 25);
            if (people.Gender.Equals(true))
            {
                Console.WriteLine("Persion details: " + "Name = {0}, Gender = Male, Age = {2}", people.Name, people.Gender, people.Age);
            }

            people.Age += 10;
            Console.WriteLine("Person details (apter incrementing age): " + "Name = {0}, Gender = Male, Age = {2}", people.Name, people.Gender, people.Age);



        }
    }
}