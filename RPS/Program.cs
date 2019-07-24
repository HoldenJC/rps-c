using System;
using System.Collections.Generic;

namespace RockPaperScissors
{

  public class Program
  {
    public static void Main()
    {
      ConsoleKeyInfo moveA;
      ConsoleKeyInfo moveB;
      string move1 = "error: invalid move";
      string move2 = "error: invalid move";

      while (move1 == "error: invalid move" || move2 == "error: invalid move")
      {
        Console.WriteLine("Player 1 make your move: (a:rock s:paper d:scissors)");
        moveA = Console.ReadKey(true);
        Console.WriteLine("Player 2 make your move: (arrow keys left:rock down:paper right:scissors)");
        moveB = Console.ReadKey(true);
        move1 = moveA.Key.ToString();
        move2 = moveB.Key.ToString();
        move1 = findMove(move1);
        move2 = findMove2(move2);
        Console.WriteLine("____________________________________");
        Console.WriteLine("Player 1 move: " + move1);
        Console.WriteLine("Player 2 move: " + move2);
        if (move1 == "error: invalid move" || move2 == "error: invalid move")
        {
          Console.WriteLine("invalid move made, try again");
        }
      }
      Console.WriteLine(winCheck(move1, move2));

      Console.WriteLine("Play again? ( y / n )?");
      string rpsChoice = Console.ReadLine();
      if (rpsChoice == "y")
      {
        Main();
      }
      else
      {
        return;
      }
    }

    static string findMove(string rawMove)
    {
      if (rawMove == "A")
      {
        rawMove = "rock";
      }
      else if (rawMove == "S")
      {
        rawMove = "paper";
      }
      else if (rawMove == "D")
      {
        rawMove = "scissors";
      }
      else
      {
        rawMove = "error: invalid move";
      }
      return rawMove;
    }

    static string findMove2(string rawMove)
    {
      if (rawMove == "LeftArrow")
      {
        rawMove = "rock";
      }
      else if (rawMove == "DownArrow")
      {
        rawMove = "paper";
      }
      else if (rawMove == "RightArrow")
      {
        rawMove = "scissors";
      }
      else
      {
        rawMove = "error: invalid move";
      }
      return rawMove;
    }

    static string winCheck(string aMove, string bMove)
    {
      string winner;
      if ((aMove == "rock" && bMove == "scissors") || (aMove == "paper" && bMove == "rock") || (aMove == "scissors" && bMove == "paper"))
      {
        winner = "Player 1 wins!";
      }
      else if (aMove == bMove)
      {
        winner = "Tie game!";
      }
      else
      {
        winner = "Player 2 wins!";
      }
      return winner;
    }
  }
  

}

