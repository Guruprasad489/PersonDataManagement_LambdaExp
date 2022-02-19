﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person data management program");
            List<Person> list = new List<Person>();
            AddPersonDetailsToList(list);

            Console.WriteLine("Choose an option \n1. Retrieve top 2 Person Age Less Than 60" +
                                               "\n2. Retrieve Person Age Between 13 To 18");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    RetrievePersonAgeLessThan60(list);
                    break;
                case 2:
                    RetrievePersonAgeBetween13To18(list);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();
        }
        //UC1 - Add default values to list
        public static void AddPersonDetailsToList(List<Person> list)
        {
            // Object Initializer
            list.Add(new Person() { ssn = 1, name = "Guru", address = "Belgaum", age = 25 });
            list.Add(new Person() { ssn = 2, name = "Guruprasad", address = "Belgaum", age = 26 });
            list.Add(new Person() { ssn = 3, name = "Virat", address = "Karnataka", age = 70 });
            list.Add(new Person() { ssn = 4, name = "Rohit", address = "Maharastra", age = 50 });
            list.Add(new Person() { ssn = 5, name = "Sachin", address = "Maharastra", age = 61 });
            list.Add(new Person() { ssn = 6, name = "Pandya", address = "Maharastra", age = 16 });
            list.Add(new Person() { ssn = 1, name = "Rahul", address = "Karnataka", age = 63 });
            IterateOverList(list);
        }
        //Method to Iterate over list
        public static void IterateOverList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
        //UC2 - Method to Retrieve top 2 Person Age Less Than 60 from list
        public static void RetrievePersonAgeLessThan60(List<Person> list)
        {
            List<Person> topTwoRecords = list.FindAll(person => person.age < 60).OrderBy(a=>a.age).Take(2).ToList();
            Console.WriteLine("\nTop 2 persons with Age less than 60");
            IterateOverList(topTwoRecords);
        }
        //UC3 - Method to Retrieve all records from the list for Age between 13 to 18
        public static void RetrievePersonAgeBetween13To18(List<Person> list)
        {
            List<Person> teenage = list.FindAll(person => person.age >=13 && person.age <=18).ToList();
            Console.WriteLine("\nlist for Age between 13 to 18");
            IterateOverList(teenage);
        }
    }
}