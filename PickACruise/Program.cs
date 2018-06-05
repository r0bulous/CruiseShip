using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACruise
{
    class Program
    {
        static void Main(string[] args)
        {
            CruiseShip friend = new CruiseShip();

            Console.WriteLine("Enter your friend's age to pick a cruise ship.");
            friend.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("You picked {0} as your cruise provider!", friend.GetCruiseShip());
        }
    }
}
