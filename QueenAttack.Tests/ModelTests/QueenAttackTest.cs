using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QueenAttack.Models;
using System;

namespace QueenAttack.Test
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void GetX_ReturnX_Int()
    {
      //Arrange
      int userX = 1;
      int userY = 1;
      Queen newQueen = new Queen(userX, userY);

      //Act
      int newX = newQueen.GetX();

      //Assert
      Assert.AreEqual(userX, newX);
    }

    [TestMethod]
    public void GetY_ReturnY_Int()
    {
      //Arrange
      int userX = 1;
      int userY = 1;
      Queen newQueen = new Queen(userX, userY);

      //Act
      int newY = newQueen.GetY();

      //Assert
      Assert.AreEqual(userY, newY);
    }

    [TestMethod]
    public void CanAttackHorizontal_ReturnTrue_True()
    {
      //Arrange
      bool canAttack = true;
      Queen attackQueen = new Queen(3, 3);
      Queen targetQueen = new Queen(4, 3);

      //Act
      bool checkHoriz = attackQueen.CanAttackHorizontal(attackQueen.GetY(), targetQueen.GetY());

      //Assert
      Assert.AreEqual(canAttack, checkHoriz);

    }
  }


}
