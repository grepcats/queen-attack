using System.Collections.Generic;
using System;

namespace QueenAttack.Models
{
  public class Queen
  {
    private int _XCoord;
    private int _YCoord;

    public Queen(int X, int Y)
    {
      _XCoord = X;
      _YCoord = Y;
    }

    public int GetX()
    {
      return _XCoord;
    }

    public int GetY()
    {
      return _YCoord;
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

  }
}
