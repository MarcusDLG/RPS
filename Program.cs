using System;

namespace RPS
{
  class Program
  {
    static void Main(string[] args)
    {
      bool flag = true;
      while (flag)
      {
        // As a user, I should see a welcome message.
        Console.WriteLine("Welcome to 'Rock, Paper, Scissors, Lizard, Spock");
        //User should be prompted to choose a level: 
        Console.WriteLine("Please choose a difficulty: normal, impossible, and easy.");
        var difficultyType = Console.ReadLine().ToLower();
        if (difficultyType != "normal" && difficultyType != "impossible" && difficultyType != "easy")
        {
          Console.WriteLine("That is not a valid choice, chose again from normal, impossible, and easy.");
          difficultyType = Console.ReadLine().ToLower();
        }
        if (difficultyType == "normal")
        {
          //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
          Console.WriteLine("Please pick from the following: rock, paper, scissors, lizard, or spock.");
          var userChoice = Console.ReadLine().ToLower();
          Console.WriteLine("You chose: " + userChoice);
          //Add a validation tool to verify that user put in correct type of data
          if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors" && userChoice != "lizard" && userChoice != "spock")
          {
            Console.WriteLine("That is not a valid choice, chose again from rock, paper, scissors, lizard, or spock.");
            userChoice = Console.ReadLine().ToLower();
          }
          //  The computer should randomly decide one of the options and store as a variable.
          Random rnd = new Random();
          string[] answer = { "rock", "paper", "scissors, lizard, spock" };

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
          else if (userChoice == "rock" && computerChoice == "spock")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "rock" && computerChoice == "scissors")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "rock" && computerChoice == "lizard")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "paper" && computerChoice == "scissors")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "paper" && computerChoice == "lizard")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "paper" && computerChoice == "rock")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "paper" && computerChoice == "spock")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "scissors" && computerChoice == "paper")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "scissors" && computerChoice == "lizard")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "scissors" && computerChoice == "rock")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "scissors" && computerChoice == "spock")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "lizard" && computerChoice == "paper")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "lizard" && computerChoice == "spock")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "lizard" && computerChoice == "scissors")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "lizard" && computerChoice == "rock")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "spock" && computerChoice == "paper")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "spock" && computerChoice == "lizard")
          {
            Console.WriteLine("Sorry, the computer chose: " + computerChoice + ". You lose.");
          }
          else if (userChoice == "spock" && computerChoice == "rock")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
          else if (userChoice == "spock" && computerChoice == "scissors")
          {
            Console.WriteLine("Congrats you win: you chose " + userChoice + " and the computer chose " + computerChoice + ".");
          }
        }
        else if (difficultyType == "impossible")
        {
          //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
          Console.WriteLine("Please pick from the following: rock, paper, scissors, lizard, or spock.");
          var userChoice = Console.ReadLine().ToLower();
          Console.WriteLine("You chose: " + userChoice);
          //Add a validation tool to verify that user put in correct type of data
          if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors" && userChoice != "lizard" && userChoice != "spock")
          {
            Console.WriteLine("That is not a valid choice, chose again from rock, paper, scissors, lizard, or spock.");
            userChoice = Console.ReadLine().ToLower();
          }
          //  The computer should randomly decide one of the options and store as a variable.
          Random rnd = new Random();
          string[] answer = { "rock", "paper", "scissors, lizard, spock" };

          int rpsIndex = rnd.Next(answer.Length);
          var computerChoice = answer[rpsIndex];

          //I need it to inform the user that they've lost regardless of  their choice
          if (userChoice == "rock")
          {
            string[] rockLoses = { "paper", "spock" };

            int rockLosesindex = rnd.Next(rockLoses.Length);
            computerChoice = rockLoses[rockLosesindex];
            Console.WriteLine("Sorry, you lose, computer chose: " + computerChoice + ".");

          }
          else if (userChoice == "paper")
          {
            string[] paperLoses = { "lizard", "scissors" };

            int paperLosesindex = rnd.Next(paperLoses.Length);
            computerChoice = paperLoses[paperLosesindex];
            Console.WriteLine("Sorry, you lose, computer chose: " + computerChoice + ".");

          }
          else if (userChoice == "scissors")
          {
            string[] scissorLoses = { "rock", "spock" };

            int scissorLosesindex = rnd.Next(scissorLoses.Length);
            computerChoice = scissorLoses[scissorLosesindex];
            Console.WriteLine("Sorry, you lose, computer chose: " + computerChoice + ".");
          }
          else if (userChoice == "lizard")
          {
            string[] lizardLoses = { "rock", "scissors" };

            int lizardLosesindex = rnd.Next(lizardLoses.Length);
            computerChoice = lizardLoses[lizardLosesindex];
            Console.WriteLine("Sorry, you lose, computer chose: " + computerChoice + ".");
          }
          else if (userChoice == "spock")
          {
            string[] spockLoses = { "lizard", "paper" };

            int spockLosesindex = rnd.Next(spockLoses.Length);
            computerChoice = spockLoses[spockLosesindex];
            Console.WriteLine("Sorry, you lose, computer chose: " + computerChoice + ".");
          }
        }
        else if (difficultyType == "easy")
        {
          //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
          Console.WriteLine("Please pick from the following: rock, paper, scissors, lizard, or spock.");
          var userChoice = Console.ReadLine().ToLower();
          Console.WriteLine("You chose: " + userChoice);
          //Add a validation tool to verify that user put in correct type of data
          if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors" && userChoice != "lizard" && userChoice != "spock")
          {
            Console.WriteLine("That is not a valid choice, chose again from rock, paper, scissors, lizard, or spock.");
            userChoice = Console.ReadLine().ToLower();
          }
          //  The computer should randomly decide one of the options and store as a variable.
          Random rnd = new Random();
          string[] answer = { "rock", "paper", "scissors, lizard, spock" };

          int rpsIndex = rnd.Next(answer.Length);
          var computerChoice = answer[rpsIndex];

          //I need it to inform the user that they've lost regardless of  their choice
          if (userChoice == "rock")
          {
            string[] rockWins = { "scissors", "lizard" };

            int rockWinsindex = rnd.Next(rockWins.Length);
            computerChoice = rockWins[rockWinsindex];
            Console.WriteLine("Congrats, you won, the computer chose: " + computerChoice + ".");

          }
          else if (userChoice == "paper")
          {
            string[] paperWins = { "rock", "spock" };

            int paperWinsindex = rnd.Next(paperWins.Length);
            computerChoice = paperWins[paperWinsindex];
            Console.WriteLine("Congrats, you won, the computer chose: " + computerChoice + ".");

          }
          else if (userChoice == "scissors")
          {
            string[] scissorWins = { "water", "lizard" };

            int scissorWinsindex = rnd.Next(scissorWins.Length);
            computerChoice = scissorWins[scissorWinsindex];
            Console.WriteLine("Congrats, you won, the computer chose: " + computerChoice + ".");
          }
          else if (userChoice == "lizard")
          {
            string[] lizardWins = { "spock", "paper" };

            int lizardWinsindex = rnd.Next(lizardWins.Length);
            computerChoice = lizardWins[lizardWinsindex];
            Console.WriteLine("Congrats, you won, the computer chose: " + computerChoice + ".");
          }
          else if (userChoice == "spock")
          {
            string[] spockWins = { "rock", "scissors" };

            int spockWinsindex = rnd.Next(spockWins.Length);
            computerChoice = spockWins[spockWinsindex];
            Console.WriteLine("Congrats, you won, the computer chose: " + computerChoice + ".");
          }
        }
        Console.WriteLine("Play again? ('yes' or 'no')");
        string playAgain = null;
        playAgain = Console.ReadLine();
        if (playAgain == "no")
          flag = false;
      }
    }
  }
}