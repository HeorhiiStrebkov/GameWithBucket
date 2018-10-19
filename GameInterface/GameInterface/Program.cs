using ClassLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int switcher = 0;
            bool IsSwitcher = false;
            int[] AllAnswers = new int[100];
            Random rand = new Random((int)DateTime.Now.Ticks);
            int WinDigit = rand.Next(40, 140);
            Console.WriteLine("Hi, member!Let's see our game!");
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do some options with choose of count and type of player (press right number)");
                Console.WriteLine("1.Start your Programm");
                Console.WriteLine("2.See all digits and arrays (for admin)");
                Console.WriteLine("3.Exit");
                switcher = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (switcher)
                {
                    case 1:
                        Console.WriteLine($"Our WinDigit is {WinDigit}.");
                        var BasikPlayer = new BasikGamer();
                        BasikPlayer.Play(WinDigit, ref AllAnswers);
                        var UberPlayer = new UberGamer();
                        UberPlayer.Play(WinDigit, ref AllAnswers);
                        var NodePlayer = new NodeGamer();
                        NodePlayer.Play(WinDigit, ref AllAnswers);
                        var Cheater = new Cheater();
                        Cheater.Play(WinDigit, ref AllAnswers);
                        var UberCheater = new UberCheater();
                        UberCheater.Play(WinDigit, ref AllAnswers);
                        break;
                    case 2:
                        Console.WriteLine($"Our WinDigit is {WinDigit}.");
                        Console.WriteLine("Full array of tries :");
                        for (int i = 0; i < AllAnswers.Length; i++)
                        {
                            Console.Write(AllAnswers[i] + " ");
                        }
                        break;
                    case 3:
                        IsSwitcher = true;
                        break;
                    default:
                        Console.WriteLine("U need to write number of operation.");
                        Console.WriteLine("Try Again pls. Ok?");
                        break;

                }
            }
            while (IsSwitcher == false);
        }
    }
}

