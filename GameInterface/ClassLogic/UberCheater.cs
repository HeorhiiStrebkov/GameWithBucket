﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class UberCheater : BasikGamer

    {
        public UberCheater()
        {
            PlayerType = "UberCheater";
            AllNumbers = new int[20];
        }
        public override void Play(int WinDigit, ref int[] AllAnswers, int OneByOne)
        {
            bool IsRight = false;
            bool IsSwitcher = false;
            int NearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                AllNumbers[i] = (12 * OneByOne)  + i;
                AllAnswers[(12 * OneByOne)  + i] = AllNumbers[i];
                IsSwitcher = false;
                do
                {
                    for (int j = 0; j < AllAnswers.Length; j++)
                    {
                        if (j != (i + (12 * OneByOne) ))
                        {
                            if (AllNumbers[i] == AllAnswers[j])
                            {
                                AllNumbers[i]++;
                                AllAnswers[(12 * OneByOne)  + i] = AllNumbers[i];
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
                Console.WriteLine($"{PlayerType} win it with {WinDigit} digit!");
            }
            else
            {
                Console.WriteLine($"{PlayerType} win it with  digit that was the nearest - {NearWinDigit} digit!");
            }
        }

    }
}
