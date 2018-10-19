using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class UberGamer : BasikGamer
    {
        public UberGamer()
        {
            PlayerType = "UberGamer";
            AllNumbers = new int[20];
        }
        public override void Play(int WinDigit, ref int []AllAnswers)
        {
            bool IsRight = false;
            int NearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                AllNumbers[i] = i+40;
                AllAnswers[19+i] = AllNumbers[i];
                if (AllNumbers[i] == WinDigit)
                {
                    IsRight = true;
                }
                else
                {
                    if (Math.Abs(WinDigit - NearWinDigit) > Math.Abs(WinDigit - AllNumbers[i]))
                    {
                        NearWinDigit = AllNumbers[i];
                    }
                }
            }
            if (IsRight == true)
            {
                Console.WriteLine ($"{PlayerType} win it with {WinDigit} digit!");
            }
            else
            {
               
                Console.WriteLine ($"{PlayerType} win it with  digit that was the nearest - {NearWinDigit} digit!");
            }
        }
    }
}
