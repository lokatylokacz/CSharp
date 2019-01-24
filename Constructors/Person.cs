using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id, age;
        string firstName, lastName, address, gender;

        public Person()
        {
            id = 1;
            firstName = "Alek";
            lastName = "Trollo";
            age = 123;
        }

        public Person(int id, string firstName, string lastName, string address, int age, string gender)
        {
            this.id = id;  //this.id to id obietku zadeklarowane nad konstruktorem
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender; 
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            address = "Katowice";
            age = 18;
        }
        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
