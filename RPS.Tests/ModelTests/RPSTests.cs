using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rps.Models;
using System.Collections.Generic;
using System;


namespace Rps.Tests
{
  [TestClass]
  public class RpsGameTests
  {
    [TestMethod]
    public void RpsGame_HumanPlayerCreated_True()
    {
      RpsGame newGame = new RpsGame("ROCK");
      string humanPlay = newGame.HumanPlayer;
      Assert.AreEqual("ROCK", humanPlay);
    }

    [TestMethod]
    public void RpsGame_IsComputerPlayerCreated_True()
    {
      RpsGame newGame = new RpsGame("PAPER");
      string compPlay = newGame.ComputerPlayer;
      Assert.AreEqual(typeof(string), compPlay.GetType());
    }

    [TestMethod]
    public void RpsGame_IsPlayerWinner_True()
    {
      RpsGame newGame = new RpsGame("SCISSORS");
      Assert.AreEqual(true, newGame.GamePlay());
    }
  }
}