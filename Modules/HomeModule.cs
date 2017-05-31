using Nancy;
using System.Collections.Generic;
using RockPaperScissor.Objects;
using System;

namespace RockPaperScissor
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/play"] = _ => {
        RPS player1 = new RPS(Request.Form["player1"]);
        RPS player2 = new RPS(Request.Form["player2"]);
        List<RPS> playerList = RPS.ShowPlayers();
        Console.WriteLine("1 " + playerList[0].GetHand() + " " + playerList[1].GetHand());
        // List<int> listPoint = RPS.Play(playerList[0].GetHand(), playerList[1].GetHand());
        // Console.WriteLine("2" + playerList[0].GetHand());
        return View["play.cshtml", playerList];
      };

    }
  }
}
