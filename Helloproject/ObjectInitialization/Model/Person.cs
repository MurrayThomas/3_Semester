using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitialization.Model
{

    public class Person
    {
        private string? name;
        private DateTime? birthdate;

        public Person()
        {
        }

        public Person(string inName) {
            name = inName;
        }

        public Person(string inName, DateTime? birthdate)
        {
            this.name = inName;
            this.birthdate = birthdate;
        }

        public string Name { get { return name; } }


    }
}
