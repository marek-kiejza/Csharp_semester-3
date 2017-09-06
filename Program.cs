using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] eloResult = new int[5,3];
        static int[] lolResult = new int[3];
        static void Main(string[] args)
        {

            int[,] eloResult = new int[5,3];
            eloResult[0,1] = 56;

            int choice = Menu();
            Switch(choice);
            //eloResult[0] = 56;
        }

        static void Test ()
        {
            eloResult[1,1] = 2;

        }

        static int Menu()
        {
            int choice = 0;

            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("1.Player Report");
            Console.WriteLine("2.Score Analysis Report");
            Console.WriteLine("3.Search for a Player");
            Console.WriteLine("4.Exit");
            Console.WriteLine();
            Console.Write("Enter Choice : ");

            choice = int.Parse(Console.ReadLine());

            return choice;
        }

        static void Switch(int choice)
        { 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("dupa");
                    break;

                case 2:
                    Console.WriteLine("dupa");
                    break;

                case 3:
                    Console.WriteLine("dupa");
                    break;

                case 4:
                    Console.WriteLine("dupa");
                    break;

                default:
                    break;
            }

        }
    }
}
