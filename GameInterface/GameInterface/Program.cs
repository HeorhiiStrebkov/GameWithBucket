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
            int[] allAnswers = new int[100];
            int howMuchGamers = 0;
            int toChooseTypes = 0;
            Player[] gamers = new Player[8];
            Random rand = new Random((int)DateTime.Now.Ticks);
            int winDigit = rand.Next(40, 140);
            Console.WriteLine("Hi, member!Let's see our game!");
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do some options with choose of count and type of player (press right number)");
                Console.WriteLine("1.Start your Programm");
                Console.WriteLine("2.See all digits and arrays (for admin)");
                Console.WriteLine("3.Choose options for game");
                Console.WriteLine("4.Clear All Data");
                Console.WriteLine("5.Exit");
                switcher = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (switcher)
                {
                    case 1:
                        Console.WriteLine($"Our winDigit is {winDigit}.");
                        if (gamers[0] == null)
                        {
                            Console.WriteLine("U can't start, choose options firstly!");
                        }
                        else
                        {
                            for (int i = 0; i < gamers.Length; i++)
                            {
                                if (gamers[i] != null)
                                {
                                    gamers[i].Play(winDigit, ref allAnswers, i, howMuchGamers);
                                }
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Our winDigit is {winDigit}.");
                        Console.WriteLine("Full array of tries :");
                        for (int i = 0; i < allAnswers.Length; i++)
                        {
                            Console.Write(allAnswers[i] + " ");
                        }
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("Enter number of members between 2 and 8");
                            howMuchGamers = Convert.ToInt32(Console.ReadLine());
                            if (howMuchGamers >= 9 || howMuchGamers <= 1)
                            {
                                Console.WriteLine("Try again!");
                            }
                        } while (howMuchGamers >= 9 || howMuchGamers <= 1);
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter number to choose or other to end option!");
                            Console.WriteLine("1.Create BasikPlayer");
                            Console.WriteLine("2.Create Cheater");
                            Console.WriteLine("3.Create NodeGamer");
                            Console.WriteLine("4.Create UberGamer");
                            Console.WriteLine("5.Create UberCheater");
                            switcher = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (switcher)
                            {
                                case 1:
                                    for (int i = 0; i < gamers.Length; i++)
                                    {
                                        if (gamers[i] == null)
                                        {
                                            var basikPlayer = new BasikGamer(howMuchGamers);
                                            gamers[i] = basikPlayer;
                                            Console.WriteLine("BasikGamer was Created");
                                            toChooseTypes++;
                                            break;
                                        }
                                    }

                                    break;
                                case 2:
                                    for (int i = 0; i < gamers.Length; i++)
                                    {
                                        if (gamers[i] == null)
                                        {
                                            var cheaterPlayer = new Cheater(howMuchGamers);
                                            gamers[i] = cheaterPlayer;
                                            Console.WriteLine("Cheater was Created");
                                            toChooseTypes++;
                                            break;
                                        }
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < gamers.Length; i++)
                                    {
                                        if (gamers[i] == null)
                                        {
                                            var nodePlayer = new NodeGamer(howMuchGamers);
                                            gamers[i] = nodePlayer;
                                            Console.WriteLine("nodePlayer was Created");
                                            toChooseTypes++;
                                            break;
                                        }
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < gamers.Length; i++)
                                    {
                                        if (gamers[i] == null)
                                        {
                                            var uberPlayer = new UberGamer(howMuchGamers);
                                            gamers[i] = uberPlayer;
                                            Console.WriteLine("UberGamer was Created");
                                            toChooseTypes++;
                                            break;
                                        }
                                    }
                                    break;
                                case 5:
                                    for (int i = 0; i < gamers.Length; i++)
                                    {
                                        if (gamers[i] == null)
                                        {
                                            var uberCheaterPlayer = new UberCheater(howMuchGamers);
                                            gamers[i] = uberCheaterPlayer;
                                            Console.WriteLine("UberCheater was Created");
                                            toChooseTypes++;
                                            break;
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Missed! Try Again!");
                                    break;
                            }
                        }
                        while (toChooseTypes != howMuchGamers);
                        IsSwitcher = false;
                        break;
                    case 4:
                        for (int i = 0; i < gamers.Length; i++)
                        {
                            gamers[i] = null;
                        }
                        for (int i = 0; i < allAnswers.Length; i++)
                        {
                            allAnswers[i] = 0;
                        }
                        Console.WriteLine("All data was cleared!");
                        break;
                    case 5:
                        IsSwitcher = true;
                        break;
                    default:
                        Console.WriteLine("U need to write number of operation.");
                        Console.WriteLine("Try Again pls. Ok?");
                        break;

                }
            }
            while (IsSwitcher == false);
            Console.WriteLine("All players was choosen!");
        }
    }
}

