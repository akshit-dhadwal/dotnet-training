using System;
using System.Collections;
using System.Linq;
using static Atm.Banking;

namespace Atm
{
    class PersonDetail
    {
        public List<Person> GetDetail()
        {
            List<Person> information = new List<Person>();
             
             information.Add(new Person{password = 1234,balance = 25000, name = "Amit"});
             information.Add(new Person{password = 1235,balance = 50000, name = "Ramesh"});
             information.Add(new Person{password = 1236,balance = 100000, name = "Akshit"});

             return information;

        }
    }
}