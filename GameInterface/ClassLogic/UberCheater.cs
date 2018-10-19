using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class UberCheater : Player

    {
        public override void Play(int winDigit, ref int[] allAnswers, int oneByOne, int allgamers)
        {
            bool IsRight = false;
            bool IsSwitcher = false;
            int nearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                AllNumbers[i] = ((100 / allgamers) * oneByOne)  + i;
                allAnswers[((100 / allgamers) * oneByOne)  + i] = AllNumbers[i];
                IsSwitcher = false;
                do
                {
                    for (int j = 0; j < allAnswers.Length; j++)
                    {
                        if (j != (i + ((100 / allgamers) * oneByOne) ))
                        {
                            if (AllNumbers[i] == allAnswers[j])
                            {
                                AllNumbers[i]++;
                                allAnswers[((100 / allgamers) * oneByOne)  + i] = AllNumbers[i];
                                IsSwitcher = false;
                                break;
                            }
                            else
                            {
                                IsSwitcher = true;
                            }
                        }
                    }
                }
                while (IsSwitcher == false);
                if (AllNumbers[i] == winDigit)
                {
                    IsRight = true;
                }
                else
                {
                    if (Math.Abs(winDigit - nearWinDigit) > Math.Abs(winDigit - AllNumbers[i]))
                    {
                        nearWinDigit = AllNumbers[i];
                    }
                }
            }
            if (IsRight == true)
            {
                Console.WriteLine($"{PlayerType} win it with {winDigit} digit!");
            }
            else
            {
                Console.WriteLine($"{PlayerType} win it with  digit that was the nearest - {nearWinDigit} digit!");
            }
        }
        public UberCheater(int allgamers)
        {
            PlayerType = "UberCheater";
            AllNumbers = new int[(100 / allgamers)];
        }
    }
}
