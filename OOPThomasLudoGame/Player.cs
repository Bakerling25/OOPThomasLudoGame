using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Player
    {
        private string name;
        private List<Piece> pieces;
        private bool hasPlayerOnePieceOnBoard;
        public string Name
        { 
            get { return name; }
            set { name = value; } 
        }
        public List<Piece> Pieces
        {
            get { return pieces; }
            set {pieces = value; }
        }
        public bool HasPlayerOnePieceOnBoard
        {
            get {return hasPlayerOnePieceOnBoard; }
            set {hasPlayerOnePieceOnBoard = value; }
        }


    }
}
