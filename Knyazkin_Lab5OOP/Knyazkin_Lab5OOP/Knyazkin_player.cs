using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knyazkin_Lab5OOP
{
   [Serializable]
    class Knyazkin_player
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string country;

        public void setFirstName(string fname)
        {
            this.firstName = fname;
        }
        public void setLastName(string lname)
        {
            this.lastName = lname;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setCountry(string country)
        {
            this.country = country;
        }
        public virtual void printInfo()
        {
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}, Age: {age}, Country: {country}.");
        }

        public Knyazkin_player() { }
        public Knyazkin_player(string fname, string lname, int age, string country)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.age = age;
            this.country = country;
        }
    }
}
