using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Interfaces
{
    public interface IActivity
    {
        bool CheckStep(int x, int y);  
        
        bool Move(int x, int y);
    }
}
