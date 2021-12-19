using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Knyazkin_Lab5OOP
{
    class Knyazkin_team
    {
        private List<Knyazkin_player> list = new List<Knyazkin_player>();

        public void addPlayer()
        {
            Knyazkin_player player = new Knyazkin_player();
            Console.WriteLine("Write firstname: ");
            player.setFirstName(Console.ReadLine());
            Console.WriteLine("Write lastname: ");
            player.setLastName(Console.ReadLine());
            Console.WriteLine("Write age: ");
            player.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Write country: ");
            player.setCountry(Console.ReadLine());
            list.Add(player);
        }
        public void addCoach()
        {
            Knyazkin_coach coach = new Knyazkin_coach();
            Console.WriteLine("Write firstname: ");
            coach.setFirstName(Console.ReadLine());
            Console.WriteLine("Write lastname: ");
            coach.setLastName(Console.ReadLine());
            Console.WriteLine("Write age: ");
            coach.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Write country: ");
            coach.setCountry(Console.ReadLine());
            Console.WriteLine("Write experience: ");
            coach.setExp(int.Parse(Console.ReadLine()));
            Console.WriteLine("Write former team: ");
            coach.setFormTeam(Console.ReadLine());
            list.Add(coach);
        }
        public void printAll()
        {
            Console.WriteLine("===========================");
            if (!list.Any()) Console.WriteLine("List is empty.");
            foreach (Knyazkin_player st in list)
            {
                st.printInfo();
            }
            Console.WriteLine("===========================");
        }
        public void saveAll()
        {
            var bf = new BinaryFormatter();
            using (Stream fs = new FileStream("team.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, list);
            }
        }
        public void loadAll()
        {
            var bf = new BinaryFormatter();
            using (Stream fs = new FileStream("team.dat", FileMode.Open))
            {
                this.list = (bf.Deserialize(fs) as List<Knyazkin_player>);
            }
        }
        public void clearAll()
        {
            list.Clear();
        }
    }
}
