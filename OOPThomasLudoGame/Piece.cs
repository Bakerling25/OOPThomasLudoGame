using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class Piece
    {
        private int boardPosition;
        public PieceColor Color { get; set; }
        public int PieceNumber { get; set; }
        public int Position { get; set; }
        public int BoardPosition
        {
            get {return boardPosition; }
            set {boardPosition = WhatBoardPosstion(value); }
        }
        public bool IsAtHome { get; set; }
        public bool IsAtGoal { get; set; }
        public int WhatBoardPosstion(int identifier)
        {
            switch (identifier)
            {
                case 1:
                    return 1;
                case 2:
                    return 14;
                case 3:
                    return 27;
                case 4:
                    return 40;
                default:
                    return 0;
            }
        }
    }
}
