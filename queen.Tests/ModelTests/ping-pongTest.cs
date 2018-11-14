using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenWorld;

namespace Pong.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
   public void canQueenAttack_vertical()
    {
      Queen myQueen = new Queen();
      Assert.AreEqual(true, myQueen.canQueenAttack(1, 3, 1, 4));
    }
     [TestMethod]
   public void canQueenAttack_horizontal()
    {
      Queen myQueen = new Queen();
      Assert.AreEqual(true, myQueen.canQueenAttack(2, 3, 1, 3));
    }
     [TestMethod]
   public void canQueenAttack_diagonal()
    {
      Queen myQueen = new Queen();
      Assert.AreEqual(true, myQueen.canQueenAttack(2, 4, 3, 3));
    }

  

}
}