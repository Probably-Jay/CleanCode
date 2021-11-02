using System;

namespace DRY
{
    public class ChessGame
    {
        private Player player1;
        private Player player2;
        
        bool CheckWin()
        {
            if (player1.HasWon() || player2.HasWon())
            {
                return true;
            }
            
            return false;
        }

        void PlayTurn()
        {
            if (player1.OwnsTurn)
            {
                player1.PlayTurn();
            }
            else if (player1.OwnsTurn)
            {
                player2.PlayTurn();
            }
            else throw new Exception();
        }

        void ProgressTurn()
        {
            if (player1.OwnsTurn)
            {
                player1.OwnsTurn = false;
                player2.OwnsTurn = true;
                IncreaseTurnCounter();
            }
            else if (player2.OwnsTurn)
            {
                player1.OwnsTurn = true;
                player2.OwnsTurn = false;
                IncreaseTurnCounter();
            }
            else throw new Exception();
        }

        private void IncreaseTurnCounter()
        {
            throw new NotImplementedException();
        }
    }

    public class Player
    {
        public bool HasWon()
        {
            throw new NotImplementedException();
        }

        public bool OwnsTurn { get; set; }

        public void PlayTurn()
        {
            throw new NotImplementedException();
        }
    }
}