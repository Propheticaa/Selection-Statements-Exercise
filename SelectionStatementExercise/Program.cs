namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RandomNumberGame();
            FavoriteSubject();
        }

        public static void RandomNumberGame()
        {
            Random r = new Random();
            int favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my favorite number:");
            int userInput = 0;
            while (!(userInput == favNumber))
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                }
            }
        }

        public static void FavoriteSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine().ToLower();
            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;
                case "science":
                    Console.WriteLine("Science is cool because it's all discovering truths of the world!");
                    break;
                case "history":
                    Console.WriteLine("History is awesome because it's all about seeing what happened in the past!");
                    break;
                case "art": 
                    Console.WriteLine("Art is beautiful because it's all about expressing yourself!");
                    break;
                case "gym":
                    Console.WriteLine("Gym is fun with how much you get to move around!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
        
    }
}
