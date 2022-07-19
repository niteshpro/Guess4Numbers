//Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
class guess
{
    static void Main()
    {
        var random = new Random();
        var input = random.Next(1,10);
        //Console.WriteLine(input);
        Console.WriteLine("-------------Guess the Number between 1 to 10 ----------------");
        Console.WriteLine("Enter the number: ");
        for (int i = 0; i < 4; i++)
        {
            int guess = Convert.ToInt32( Console.ReadLine());
            if (guess == input)
            {
                Console.WriteLine("You Won!!! ");
                break;
            }
            else
                Console.WriteLine("Guess the number again");

        }
        Console.WriteLine("YOU LOST");

    }
}