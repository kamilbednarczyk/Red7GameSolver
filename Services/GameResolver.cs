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

        public string SameNumbers(Player[] players)
        {

            Player winningPlayer = null;
            List<Card> cardList = new List<Card>();

            foreach (var player in players)
            {
                if (winningPlayer==null)
                {
                    winningPlayer = player;
                    cardList = player.SameNumbersList();
                }
                else
                {
                    List<Card> tempCardList = player.SameNumbersList();
                    if (tempCardList.Count > cardList.Count)
                    {
                        winningPlayer = player;
                        cardList = tempCardList;
                    }
                    else if (tempCardList.Count == cardList.Count)
                    {
                        Card currentWinnerCard = winningPlayer.HighestColor(cardList);
                        Card potentWinner = player.HighestColor(tempCardList);
                        if (currentWinnerCard.Number < potentWinner.Number)
                        {
                            winningPlayer = player;
                            cardList = tempCardList;
                        } else if (currentWinnerCard.Number == potentWinner.Number)
                        {
                            if (currentWinnerCard.Color < potentWinner.Color)
                            {
                                winningPlayer = player;
                                cardList = tempCardList;
                            }
                        }
                        
                    }

                }
            }

            return winningPlayer.Name;
        }
        public Colors GetCurrentRule(Card[] Cards)
        {
            return Cards[Cards.Length - 1].Color;
        }
    }

    
}
