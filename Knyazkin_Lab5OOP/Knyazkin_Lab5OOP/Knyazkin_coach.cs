using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knyazkin_Lab5OOP
{
    [Serializable]
    class Knyazkin_coach : Knyazkin_player
    {
    
        protected int experience;
        protected string fteam;


        public void setExp(int exp)
        {
            this.experience = exp;
        }
        public void setFormTeam(string f_team)
        {
            this.fteam = f_team;
        }
        public override void printInfo()
        {
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}, Age: {age}, Country: {country}, Experience: {experience}, Former Team: {fteam}.");
        }
        public Knyazkin_coach() { }
        public Knyazkin_coach(string fname, string lname, int age, string country, int exp, string f_team)
            : base(fname, lname, age, country)
        {
            this.experience = exp;
            this.fteam = f_team;
        }
    }
    
}
