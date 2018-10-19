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
            int HowMuchGamers = 0;
            int ToChooseTypes = 0;
            BasikGamer[] Gamers = new BasikGamer[8];
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
                Console.WriteLine("3.Choose options for game");
                Console.WriteLine("4.Exit");
                switcher = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (switcher)
                {
                    case 1:
                        Console.WriteLine($"Our WinDigit is {WinDigit}.");
                        if (Gamers[0] == null)
                        {
                            Console.WriteLine("U can't start, choose options firstly!");
                        }
                        else
                        {
                            for (int i = 0; i < Gamers.Length; i++)
                            {
                                if (Gamers[i] != null)
                                {
                                    Gamers[i].Play(WinDigit, ref AllAnswers, i, HowMuchGamers);
                                }
                            }
                        }
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
                        Console.WriteLine("Enter number of members between 2 and 8");
                        do
                        {
                            HowMuchGamers = Convert.ToInt32(Console.ReadLine());
                            if (HowMuchGamers <= 1 && HowMuchGamers >= 9)
                            {
                                Console.WriteLine("One more! U need to enter number of members between 2 and 8");
                            }
                        }
                        while (HowMuchGamers > 1 && HowMuchGamers < 9);
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter number to choose or other to end option!");
                            Console.WriteLine("1.Create BsikPlayer");
                            Console.WriteLine("2.Create Cheater");
                            Console.WriteLine("3.Create NodeGamer");
                            Console.WriteLine("4.Create UberGamer");
                            Console.WriteLine("5.Create UberCheater");
                            Console.WriteLine("6.Exit to main menu");
                            switcher = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (switcher)
                            {
                                case 1:
                                    if (Gamers[7] == null)
                                    {
                                        for (int i = 0; i < Gamers.Length; i++)
                                        {
                                            if (Gamers[i] == null)
                                            {
                                                var BasikPlayer = new BasikGamer(HowMuchGamers);
                                                Gamers[i] = BasikPlayer;
                                                Console.WriteLine("BasikGamer was Created");
                                                ToChooseTypes++;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("U had 8 players and can;t add more!");
                                    }
                                    break;
                                case 2:
                                    if (Gamers[7] == null)
                                    {
                                        for (int i = 0; i < Gamers.Length; i++)
                                        {
                                            if (Gamers[i] == null)
                                            {
                                                var CheaterPlayer = new Cheater(HowMuchGamers);
                                                Gamers[i] = CheaterPlayer;
                                                Console.WriteLine("Cheater was Created");
                                                ToChooseTypes++;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("U had 8 players and can;t add more!");
                                    }
                                    break;
                                case 3:
                                    if (Gamers[7] == null)
                                    {
                                        for (int i = 0; i < Gamers.Length; i++)
                                        {
                                            if (Gamers[i] == null)
                                            {
                                                var NodePlayer = new NodeGamer(HowMuchGamers);
                                                Gamers[i] = NodePlayer;
                                                Console.WriteLine("NodePlayer was Created");
                                                ToChooseTypes++;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("U had 8 players and can;t add more!");
                                    }
                                    break;
                                case 4:
                                    if (Gamers[7] == null)
                                    {
                                        for (int i = 0; i < Gamers.Length; i++)
                                        {
                                            if (Gamers[i] == null)
                                            {
                                                var UberPlayer = new UberGamer(HowMuchGamers);
                                                Gamers[i] = UberPlayer;
                                                Console.WriteLine("UberGamer was Created");
                                                ToChooseTypes++;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("U had 8 players and can;t add more!");
                                    }
                                    break;
                                case 5:
                                    if (Gamers[7] == null)
                                    {
                                        for (int i = 0; i < Gamers.Length; i++)
                                        {
                                            if (Gamers[i] == null)
                                            {
                                                var UberCheaterPlayer = new UberCheater(HowMuchGamers );
                                                Gamers[i] = UberCheaterPlayer;
                                                Console.WriteLine("UberCheater was Created");
                                                ToChooseTypes++;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("U had 8 players and can;t add more!");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Missed! Try Again!");
                                    break;
                            }
                        }
                        while (ToChooseTypes != HowMuchGamers);
                        IsSwitcher = false;
                        break;
                    case 4:
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

