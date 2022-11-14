using System;
using System.Collections.Generic;

namespace Rps.Models
{
  public class RpsGame
  {
    public string HumanPlayer { get; set; }
    public string ComputerPlayer { get; set; }

    public RpsGame(string play)
    {
      HumanPlayer = play;
      ComputerPlayer = BotHandPlay();
    }

    public string BotHandPlay()
    {
      Random rand = new Random();
      int randomNum = rand.Next(1, 4);

      if (randomNum == 1)
      {
        return "ROCK";
      }

      if (randomNum == 2)
      {
        return "PAPER";
      }

      else
      {
        return "SCISSORS";
      }
    }

    public bool GamePlay()
    {
      switch(HumanPlayer)
      {
        case "ROCK":
          if (ComputerPlayer == "ROCK")
          {
            Console.WriteLine("DRAW!!!");
            return false;
          }
          else if (ComputerPlayer == "Paper")
          {
            return false;
          }
          else
          {
            return true;
          }
          break;
        case "PAPER":
          if (ComputerPlayer == "ROCK")
          {
            return true;
          }
          else if (ComputerPlayer == "PAPER")
          {
            Console.WriteLine("DRAW!!!");
            return false;
          }
          else
          {
            return false;
          }
          break;  
        case "SCISSORS":
          if (ComputerPlayer == "ROCK")
          {
            return false;
          }
          else if (ComputerPlayer == "PAPER")
          {
            return true;
          }
          else
          {
            Console.WriteLine("DRAW!!!");
            return false;
          }
          break;
        default: return true;
      }
    }
  }
}