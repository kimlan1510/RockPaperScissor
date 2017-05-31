using System;
using System.Collections.Generic;

namespace RockPaperScissor.Objects
{
  public class RPS
  {
    private string _name;
    private string _hand;
    private int _randint;
    Random rnd = new Random(); //random number generator
    private static List<RPS> _listPlayer = new List<RPS>();
    private static List<int> _listPoint = new List<int>();
    public RPS(string name)
    {
      _name = name;
      _randint = rnd.Next(1, 4);  //1 <= randint < 4
      _hand = ShowHand(_randint);   //_hand = rock or paper or scissor
      _listPlayer.Add(this);
      
    }
    public string GetName()
    {
      return _name;
    }
    public string GetHand()
    {
      return _hand;
    }
    public int GetRnd()
    {
      return _randint;
    }
    public static List<RPS> ShowPlayers()
    {
      return _listPlayer;
    }
    //Return the correspondent hand{rock, paper, scissor} based on random number from 1 - 3
    public string ShowHand(int randomNumber)
    {
      if(randomNumber == 1)
      {
        _hand = "Rock";
      }
      else if(randomNumber  == 2)
      {
        _hand = "Paper";
      }
      else
      {
        _hand = "Scissor";
      }
      return _hand;
    }

    public static List<int> Play(string hand1, string hand2)
    {
      int player1Point = 0;
      int player2Point = 0;
      while( player1Point<= 3 && player2Point <= 3)
      {
        if((hand1 == "Rock" && hand2 == "Rock") || (hand1 == "Paper" && hand2 == "Paper") || (hand1 == "Scissor" && hand2 == "Scissor"))
        {
          player1Point = player1Point;
          player2Point = player2Point;
        }
        else if(hand1 == "Rock" && hand2 == "Paper")
        {
          player2Point += 1;
        }
        else if (hand1 == "Rock" && hand2 == "Scissor")
        {
          player1Point += 1;

        }
        else if (hand1 == "Paper" && hand2 == "Rock")
        {
          player1Point += 1;
        }
        else if (hand1 == "Paper" && hand2 == "Scissor")
        {
          player2Point += 1;
        }
        else if (hand1 == "Scissor" && hand2 == "Paper")
        {
          player1Point += 1;
        }
        else if (hand1 == "scissor" && hand2 == "Rock")
        {
          player2Point += 1;
        }
        _listPoint.Add(player1Point);
        _listPoint.Add(player2Point);
      }
      return _listPoint;
    }

  }
}
