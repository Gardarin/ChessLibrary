using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    public class Player
    {
        public int PlayerId;
        public string Name{get;set;}
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public string Rating { get; set; }
        public string DateOfBirth { get; set; }
        public List<Game> Games { get; set; }
        public Game CurentGame { get; set; }
    }
}
