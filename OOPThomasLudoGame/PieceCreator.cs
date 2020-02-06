using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThomasLudoGame
{
    class PieceCreator
    {
        public static List<Piece> CreatePiece()
        {
            int counter = 1;
            List<Piece> pieces = new List<Piece>();
            foreach (PieceColor pieceColor in Enum.GetValues(typeof(PieceColor)))
            {

                for (int pieceNum = 1; pieceNum < 5; pieceNum++)
                {
                    pieces.Add(new Piece()
                    {
                        Color = pieceColor,
                        PieceNumber = pieceNum,
                        IsAtHome = true,
                        BoardPosition = counter,
                        IsAtGoal = false,
                        Position = 0
                    });
                }
                counter++;
                
            }
            return pieces;
        }
       
    }
    
}
