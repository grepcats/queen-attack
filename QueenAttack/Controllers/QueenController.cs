using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using QueenAttack.Models;

namespace QueenAttack.Controllers
{
  public class QueenController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/queen-attack")]
    public ActionResult Attack()
    {
      Queen attackQueen = new Queen(
      Request.Form["attack-x"],
      Request.Form["attack-y"]
      );

      Queen targetQueen = new Queen(
      Request.Form["target-x"],
      Request.Form["target-y"]
      );

      // if (attackQueen.IsOnBoard() == true && targetQueen.IsOnBoard() == true)
      // {
      //   attackQueen.CanAttack(attackQueen.CanAttackHorizontal(attackQueen.GetY(), targetQueen.GetY()),  )
      // }

    }

  }


}
