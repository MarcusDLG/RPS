using System;

namespace RPS
{
  class Program
  {
    static void Main(string[] args)
    {
      // As a user, I should see a welcome message.
      Console.WriteLine("Welcome to Rock Paper Scissors");
      //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
      Console.WriteLine("Please pick from the following: rock, paper, or scissors.");
      var userChoice = Console.ReadLine().ToLower();
      Console.WriteLine("You chose: " + userChoice);
      //Add a validation tool to verify that user put in correct type of data
      if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
      {
        Console.WriteLine("That is not a valid choice, chose again from rock, paper, or scissors.");
        userChoice = Console.ReadLine().ToLower();
      }
      //  The computer should randomly decide one of the options and store as a variable.
      Random rnd = new Random();
      string[] answer = { "rock", "paper", "scissors" };

      int rpsIndex = rnd.Next(answer.Length);
      var computerChoice = answer[rpsIndex];

      //I need to tell it how each variable is equal to, greater than, or less than the others. 
      if (userChoice == computerChoice)
      {
        Console.WriteLine("Congrats, you both chose " + userChoice + ". It is a draw.");
      }
      else if (userChoice == "rock" && computerChoice == "paper")
      {
        Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
      }
      else if (userChoice == "rock" && computerChoice == "scissors")
      {
        Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
      }
      else if (userChoice == "paper" && computerChoice == "scissors")
      {
        Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
      }
      else if (userChoice == "paper" && computerChoice == "rock")
      {
        Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
      }
      else if (userChoice == "scissors" && computerChoice == "paper")
      {
        Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
      }
      else if (userChoice == "scissors" && computerChoice == "rock")
      {
        Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");

      }
    }
  }
}






