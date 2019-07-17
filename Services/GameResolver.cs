using Red7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Red7.Services
{
    public class GameResolver
    {
        public String GetWinner(Player[] players)
        {
            string winnerName = "";
            Card winningCard = null;
            
            foreach (Player player in players)
            {
                foreach (Card card in player.Palette)
                {
                    if (winningCard == null)
                    {
                        winnerName = player.Name;
                        winningCard = card;
                    } else
                    {
                        if (winningCard.Number < card.Number)
                        {
                            winningCard = card;
                            winnerName = player.Name;
                        } else if (winningCard.Number == card.Number)
                        {
                            if (winningCard.Color < card.Color)
                            {
                                winningCard = card;
                                winnerName = player.Name;
                            }
                        }
                    }
                }
            }

            return winnerName;
        }
    }
}
