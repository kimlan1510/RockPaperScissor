using Xunit;
namespace RockPaperScissor.Objects
{
  public class TestPlay
  {
    // [Fact]
    // public void Test1_GetRandomNumber_ReturnValue()
    // {
    //   //Arrange
    //   RPS player1 = new RPS("bob");
    //
    //   //Act
    //   int RndNumber = player1.GetRnd();
    //
    //   //Assert
    //   Assert.Equal(RndOutput, 1);
    // }

      [Fact]
      public void Test2_GetHand_returnRockPaperScissor()
      {
        //Arrange
        RPS player1 = new RPS("bob");
        RPS player2 = new RPS("bill");


        //Act
        string displayHand1 = player1.ShowHand(player1.GetRnd());
        string displayHand2 = player2.ShowHand(player2.GetRnd());
        //Assert
        Assert.Equal(displayHand1, displayHand2);
        // Assert.Equal("rock", displayHand1);
        // Assert.Equal("rock", displayHand2);
      }



  }
}
