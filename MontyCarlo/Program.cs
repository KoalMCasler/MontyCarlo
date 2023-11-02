using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyCarlo
{
    internal class Program
    {
        static ConsoleKeyInfo input;
        static int[] amounts = new int[12]; // totats for 2d6
        static Random rng = new Random(); // Random random random
        static int dice1;
        static int dice2;
        static int result;
        static int count;
        static void Main()
        {
            count = 0;
            Console.WriteLine("Monte Carlo Sim");
            Console.WriteLine();
            Console.WriteLine("Press any key to start");
            Console.WriteLine("Press any key to exit");
            while (count <= 1000000000)
            {
                dice1 = rng.Next(1,7);
                dice2 = rng.Next(1,7);
                result = dice1 + dice2;
                amounts[result - 1]++;
                count++;
                if (count % 10000000 == 0)
                {
                    Console.WriteLine(string.Format("Dice roll #{0}:",count));
                    for(int i = 0; i <= 11; i++)
                    {
                        int x = i + 1;
                        Console.WriteLine(string.Format("{0}:{1}",x, amounts[i]));
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
