using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class Cheater : BasikGamer
    {
        public override void Play(int WinDigit, ref int[] AllAnswers, int OneByOne, int AllGamers)
        {
            bool IsRight = false;
            bool IsSwitcher = false;
            int NearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                Random rand = new Random((int)DateTime.Now.Ticks+90 + i);
                AllNumbers[i] = rand.Next(40, 140);
                AllAnswers[((100 / AllGamers) * OneByOne)  + i] = AllNumbers[i];
                IsSwitcher = false;
                do
                {
                    for (int j = 0; j < AllAnswers.Length; j++)
                    {
                        if (j != (i+ ((100 / AllGamers) * OneByOne) ))
                        {
                            Random rnd = new Random((int)DateTime.Now.Ticks+156 + i + j);
                            if (AllNumbers[i] == AllAnswers[j])
                            {
                                AllNumbers[i] = rnd.Next(40, 140);
                                AllAnswers[((100 / AllGamers) * OneByOne)  + i] = AllNumbers[i];
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
        public Cheater(int AllGamers)
        {
            PlayerType = "Cheater";
            AllNumbers = new int[(100 /AllGamers)];
        }
    }
}
