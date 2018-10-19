using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class UberGamer : Player
    {
        public override void Play(int winDigit, ref int []allAnswers, int oneByOne, int allgamers)
        {
            bool IsRight = false;
            int nearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                AllNumbers[i] = i+40;
                allAnswers[((100 / allgamers) * oneByOne)  + i] = AllNumbers[i];
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
                Console.WriteLine ($"{PlayerType} win it with {winDigit} digit!");
            }
            else
            {
               
                Console.WriteLine ($"{PlayerType} win it with  digit that was the nearest - {nearWinDigit} digit!");
            }
        }
        public UberGamer(int allgamers)
        {
            PlayerType = "UberGamer";
            AllNumbers = new int[(100 / allgamers)];
        }
    }
}
