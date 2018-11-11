using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8._10
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            House house = new House();
            List<IPart> parts = new List<IPart>();
            parts.Add(new Part());
            parts.Add(new Wall());
            parts.Add(new Window());
            parts.Add(new Door());
            parts.Add(new Basement());
            foreach (var items in parts)
            {
                items.Build();
            }
            house.Finished = true;
            teamLeader.Info = "Дом достроен.";
            Console.WriteLine(teamLeader.Info);
            Console.ReadLine();
        }
    }
}
