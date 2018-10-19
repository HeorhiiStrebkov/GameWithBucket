using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class BasikGamer
    {
        public string PlayerType { get; set; }
        public string PlayerName { get; set; }
        public int[] AllNumbers { get; set; }
        public virtual void Play(int WinDigit, ref int[] AllAnswers)
        {
            bool IsRight = false;
            int NearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                Random rand = new Random((int)DateTime.Now.Ticks+126 + i);
                AllNumbers[i] = rand.Next(40, 140);
                AllAnswers[i] = AllNumbers[i];
                if (AllNumbers[i] == WinDigit)
                {
                    IsRight = true;
                }
                else
                {
                    if ((Math.Abs(WinDigit - NearWinDigit)) > (Math.Abs(WinDigit - AllNumbers[i])))
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
        public BasikGamer()
        {
            PlayerType = "BasikGamer";
            AllNumbers = new int[20];
        }
    }
}
