using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Chess
{
    public class Tower : ChessPiece, Interfaces.IActivity
    {
        public bool Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool CheckStep(int x, int y)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7)
            {
                return false;
            }

            if (Math.Abs(X - x) != 0 && Math.Abs(Y - y) != 0)
            {
                return false;
            }
            return true;
        }
    }
}
