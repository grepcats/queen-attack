using System.Collections.Generic;
using System;

namespace QueenAttack.Models
{
  public class Queen
  {
    private int _xCoord;
    private int _yCoord;

    public Queen(int x, int y)
    {
      _xCoord = x;
      _yCoord = y;
    }

    public int GetX()
    {
      return _xCoord;
    }

    public void SetX(int x)
    {
      _xCoord = x;
    }

    public int GetY()
    {
      return _yCoord;
    }

    public void SetY(int y)
    {
      _yCoord = y;
    }

    public bool CanAttackHorizontal(int attackY, int targetY)
    {
      if (attackY == targetY)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CanAttackVertical(int attackX, int targetX)
    {
      if (attackX == targetX)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CanAttackDiagonal(int attackX, int targetX, int attackY, int targetY)
    {
      int xDifference = Math.Abs(attackX - targetX);
      int yDifference = Math.Abs(attackY - targetY);
      if (xDifference == yDifference)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsOnBoard(int x, int y)
    {
      if (x < 0 || x > 8 || y < 0 || y > 8 )
      {
        return false;
      }
      else
      {
        return true;
      }
    }


  }
}
