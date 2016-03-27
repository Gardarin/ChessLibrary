using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary.Chess;
using ChessLibrary.Interfaces;

namespace ChessLibrary
{
    public class Game
    {
        private ChessPiece[,] _playingField;
        public Player BlackPlayer{ get; private set; }
        public Player WhitePlayer{ get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public TimeSpan BlackPlayerTime { get; private set; }
        public TimeSpan WhitePlayerTime { get; private set; }
        public string State { get; set; }

        public Game()
        { }

        public Game(Player blackPlayer, Player whitePlayer, TimeSpan gameTime)
        {
            _playingField = new ChessPiece[8, 8];
            
            BlackPlayer = blackPlayer;
            WhitePlayer = whitePlayer;
            BlackPlayerTime = gameTime;
            WhitePlayerTime = gameTime;
            CreationDate = DateTime.Now;
            State = "";
        }

        private void InitialField()
        {
            for (int i = 0; i < 8; ++i)
            {
                _playingField[i, 1] = new Pawn("White", i, 1);
                _playingField[i, 6] = new Pawn("Black", i, 6);
            }
            _playingField[4, 0] = new King("White", 4, 0);
            _playingField[5, 7] = new King("Black", 5, 7);
        }

        private string GetCollorById(int playerId)
        {
            if (BlackPlayer.PlayerId == playerId)
            {
                return "Black";
            }
            if (WhitePlayer.PlayerId == playerId)
            {
                return "White";
            }
            return "";
        }

        public bool Step(int playerId, int curentX, int curentY, int newX, int newY)
        {
            ChessPiece chessPiece = _playingField[curentX, curentY];
            if (chessPiece != null)
            {
                if (chessPiece.Color == GetCollorById(playerId))
                {
                    return (chessPiece as IActivity).Move(newX, newY);
                }
            }
            return false;
        }

        public ChessPiece[,] GetField()
        {
            return _playingField;
        }
    }
}
