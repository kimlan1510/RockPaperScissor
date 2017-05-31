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

        //Act
        string displayHand = player1.GetHand();

        //Assert
        Assert.Equal("Rock", displayHand);
      }



  }
}
