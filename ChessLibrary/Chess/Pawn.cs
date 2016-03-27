using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Chess
{
    public class Pawn : ChessPiece, Interfaces.IActivity
    {
        public bool Move(int x, int y)
        {
            if (CheckStep(x, y))
            {
                X = x;
                Y = y;
                return true;
            }
            return false;
        }

        public bool CheckStep(int x, int y)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7)
            {
                return false;
            }

            if (X!=x || Math.Abs(Y - y) > 2)
            {
                return false;
            }
            return true;
        }

        public Pawn(string color, int x, int y)
        {
            Name = "Pawn";
            Color = color;
            X = x;
            Y = y;
        }
    }
}
