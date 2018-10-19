using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogic
{
    public abstract class Player
    {
        public string PlayerType { get; set; }
        public int[] AllNumbers { get; set; }
        public abstract void Play(int winDigit, ref int[] allAnswers, int oneByOne, int allgamers);
        public Player()
        {

        }
        public Player(int allgamers)
        {
            PlayerType = "Player";
            AllNumbers = new int[(100 / allgamers)];
        }
    }
}
