namespace MasterMind
{
    internal class Program
    {
        

        

        static void Main(string[] args)
        {
            RandomNumberGenerator rng = new RandomNumberGenerator();
            CheckArrays checkArrays = new CheckArrays();
            int number = rng.Random();
            //number = 6580;
            Console.WriteLine(number);

            const int maxAttempts = 10;

            int[] computerNo = number.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.WriteLine("Enter any 4-digit number between 1000 and 9999:");
                string input = Console.ReadLine();
                int userNumber = Int32.Parse(input);
                //int resultNumber = ConvertToUniqueDigits(userNumber);

                int[] userInput = userNumber.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();

                

                List<String> list = checkArrays.MatchArrays(computerNo , userInput);


                bool isCorrect = Enumerable.SequenceEqual(computerNo, userInput);

                if (isCorrect)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You wrote: {input}");
                    for(int i=0; i<list.Count; i++)
                    {
                        Console.Write(list[i].ToString()+" ");
                        
                    }
                    int chanceLeft = maxAttempts - attempt;
                    Console.WriteLine();
                    Console.WriteLine($"Incorrect guess. Chances left: {chanceLeft}");

                }
            }

            Console.WriteLine("Game over. You have used all your chances.");

        }
    }
}