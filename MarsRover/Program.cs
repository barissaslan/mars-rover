using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            MarsRover rover = new MarsRover(1, 2, "N", plateau);

            string commands = "LMLMLMLMM";

            foreach (var command in commands)
            {
                if (command == 'M')
                    rover.move();
                else
                    rover.turn(command.ToString());

                Console.WriteLine(rover);
            }

            Console.ReadLine();
        }
    }
}
