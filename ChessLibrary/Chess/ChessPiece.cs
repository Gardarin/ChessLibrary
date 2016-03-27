using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Chess
{
    public abstract class ChessPiece
    {
        public string Name{get;set;}
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
