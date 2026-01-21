using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int answer = rng.Next(0,100);
        string play = "yes";
        int number = 0;
        //Console.WriteLine(guess);

        do
        {
            Console.Write("What is the magic number? ");
            string strGuess = Console.ReadLine();
            int guess = int.Parse(strGuess);
            number++;
            if (guess == answer)
            {
                Console.WriteLine($"You guessed it! Yipee! It took you {number} guesses!");
                Console.Write("Do you wanna play again? ");
                play = Console.ReadLine();
                number = 0;
                answer = rng.Next(0,100);
            }
            else if (guess < answer)
            {
                Console.WriteLine("You're too low!");
            }
            else if (guess > answer)
            {
                Console.WriteLine("You're too high!");
            }

        } while (play == "yes");
    }
}