using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;
        public string Surname { get; set; }
        private DateTime _birthdate;

        public Person() { }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate
        {
            get { return _birthdate; }
            private set { _birthdate = value; }
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;
                return years;
            }
        }
        public void SetBithdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi " + to + "! My name is " + Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
