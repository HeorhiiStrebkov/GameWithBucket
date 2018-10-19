using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class BasikGamer : Player
    {
        public override void Play(int winDigit, ref int[] allAnswers, int oneByOne, int allgamers)
        {
            bool IsRight = false;
            int nearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                Random rand = new Random((int)DateTime.Now.Ticks+126 + i);
                AllNumbers[i] = rand.Next(40, 140);
                allAnswers[i + ((100/allgamers) * oneByOne) ] = AllNumbers[i];
                if (AllNumbers[i] == winDigit)
                {
                    IsRight = true;
                }
                else
                {
                    if ((Math.Abs(winDigit - nearWinDigit)) > (Math.Abs(winDigit - AllNumbers[i])))
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
        public BasikGamer(int allgamers)
        {
            PlayerType = "BasikGamer";
            AllNumbers = new int[(100 / allgamers)];
        }
    }
}
