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

    [TestMethod]
    public void CanAttackVertical_ReturnTrue_True()
    {
      //Arrange
      bool canAttack = true;
      Queen attackQueen = new Queen(3, 4);
      Queen targetQueen = new Queen(3, 2);

      //Act
      bool checkVert = attackQueen.CanAttackVertical(attackQueen.GetX(), targetQueen.GetX());

      //Assert
      Assert.AreEqual(canAttack, checkVert);
    }

    [TestMethod]
    public void CanAttackDiagonal_ReturnTrue_True()
    {
      //Arrange
      bool canAttack = true;
      Queen attackQueen = new Queen(4, 4);
      Queen targetQueen = new Queen(1, 7);

      //Act
      bool checkDiag = attackQueen.CanAttackDiagonal(attackQueen.GetX(), targetQueen.GetX(), attackQueen.GetY(), targetQueen.GetY());

      //Assert
      Assert.AreEqual(canAttack, checkDiag);
    }

    [TestMethod]
    public void SetX_UpdateXAfterAttack()
    {
      //Arrange
      Queen attackQueen = new Queen(4, 4);
      Queen targetQueen = new Queen(1, 7);

      //Act
      attackQueen.SetX(targetQueen.GetX());

      //Assert
      Assert.AreEqual(attackQueen.GetX(), targetQueen.GetX());
    }

    [TestMethod]
    public void SetY_UpdateYAfterAttack()
    {
      //Arrange
      Queen attackQueen = new Queen(4, 4);
      Queen targetQueen = new Queen(1, 7);

      //Act
      attackQueen.SetY(targetQueen.GetY());

      //Assert
      Assert.AreEqual(attackQueen.GetY(), targetQueen.GetY());
    }

    [TestMethod]
    public void IsOnBoard_isPossumRelatedToRat_false()
    {
      //Arrange
      Queen newQueen = new Queen(-1, 1);
      bool onBoard = false;

      //Act
      bool thisQueenOnBoard = newQueen.IsOnBoard(newQueen.GetX(), newQueen.GetY());

      //Assert
      Assert.AreEqual(onBoard, thisQueenOnBoard);
    }


  }
}
