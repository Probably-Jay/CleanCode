using System;
using System.Collections.Generic;
using System.Linq;

namespace DRY
{
    public class Variables2
    {
        private List<Player> players;

        bool CheckWin()
        {
            if(players.Any(player => player.HasWon()))
            {
                return true;
            }
            
            return false;
        }

        void PlayTurn()
        {
            var turnOwner = players.Where(player => player.OwnsTurn);
            
            if (turnOwner.Count() != 1)
            {
                throw new Exception();
            }

            turnOwner.First().PlayTurn();
            
            IncreaseTurnCounter();
        }

        private void IncreaseTurnCounter()
        {
            throw new NotImplementedException();
        }

        void ProgressTurn()
        {
            var enumerator = players.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.OwnsTurn)
                {
                    PassTurnToNextPlayer(enumerator);
                    return;
                }
            } 
            
            throw new Exception();
        }

        private void PassTurnToNextPlayer(List<Player>.Enumerator enumerator)
        {
            enumerator.Current.OwnsTurn = false;

            if (enumerator.MoveNext())
            {
                enumerator.Current.OwnsTurn = true;
            }
            else // fallen off end of enumerator, return to the start
            {
                players.First().OwnsTurn = true;
            }

            return;
        }
    }


}