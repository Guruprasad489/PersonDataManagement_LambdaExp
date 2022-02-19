using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Person
    {
        public int ssn { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return $"SSN: {ssn}, Name: {name}, Address: {address}, Age: {age}";
        }
    }
}
