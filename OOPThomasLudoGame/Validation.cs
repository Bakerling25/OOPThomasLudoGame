using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Validation
    {
        public static bool HasPlayerTrownSix(Player player)
        {
            if (player.HasPlayerPieceOnBoard)
            {
                return true;
            }
            return false;
        }
        
    }
}
