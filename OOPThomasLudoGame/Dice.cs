using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Dice
    {
        
        public static int GetDiceThrow()
        {
            Random random = new Random();
            int diceNum = random.Next(1, 7);
            return diceNum;
        }
    }
}
