using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Player
    {
        private string name;
        private List<Piece> pieces;
        private bool hasPlayerPieceOnBoard;
        private bool hasPlayerWon;
        private int playerIndentifier;
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
        public bool HasPlayerPieceOnBoard
        {
            get {return hasPlayerPieceOnBoard; }
            set {hasPlayerPieceOnBoard = value; }
        }
        public int PlayerIndentifier
        {
            get { return playerIndentifier; }
            set { playerIndentifier = value; }
        }
        public bool HasPlayerWon
        {
            get {return hasPlayerWon; }
            set { hasPlayerWon = value; }
        }


    }
}
