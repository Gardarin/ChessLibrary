using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Chess
{
    public class King : ChessPiece, Interfaces.IActivity
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

            if (Math.Abs(X - x) > 1 || Math.Abs(Y - y) > 1)
            {
                return false;
            }
            return true;
        }

        public King(string color, int x, int y)
        {
            Name = "King";
            Color = color;
            X = x;
            Y = y;
        }
    }
}
