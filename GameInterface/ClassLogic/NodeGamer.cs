using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public class NodeGamer : BasikGamer
    {
        public override void Play(int WinDigit, ref int[] AllAnswers, int OneByOne, int AllGamers) 
        {
            bool IsRight = false;
            bool IsSwitcher = false;
            int NearWinDigit = 10000;
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                Random rand = new Random((int)DateTime.Now.Ticks+170 + i);
                AllNumbers[i] = rand.Next(40, 140);
                AllAnswers[((100 / AllGamers) * OneByOne) + i] = AllNumbers[i];
                IsSwitcher = false;
                do
                {
                    for (int j = 0; j < AllNumbers.Length; j++)
                    {
                        if (j != i)
                        {
                            Random rnd = new Random((int)DateTime.Now.Ticks+110 + i + j);
                            if (AllNumbers[i] == AllNumbers[j])
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
                Console.WriteLine ($"{PlayerType} win it with {WinDigit} digit!");
            }
            else
            {
                Console.WriteLine ($"{PlayerType} win it with  digit that was the nearest - {NearWinDigit} digit!");
            }

        }
        public NodeGamer(int AllGamers)
        {
            PlayerType = "NodeGamer";
            AllNumbers = new int[(100 / AllGamers)];
        }
    }
}
