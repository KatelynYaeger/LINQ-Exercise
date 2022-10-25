using Microsoft.VisualBasic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>() { "CallofDuty", "Fortnight", "KingdomHearts", "Tetris", "Pacman" };

            gameList = gameList.OrderBy(name => name.Length).ToList();

            foreach (var word in gameList)
                {
                Console.WriteLine($"{word}");
                }

            Console.WriteLine("");

            Console.WriteLine(gameList.Count);

            Console.WriteLine("");

            gameList = gameList.OrderBy(name => name.Length).ThenBy(name => name).ToList();

            foreach (var word in gameList)
            {
                Console.WriteLine($"{word}");
            }

            Console.WriteLine("");

            gameList = gameList.Append("CallofDuty").ToList();
            foreach (var word in gameList)
            {
                Console.WriteLine($"{word}");
            }

            Console.WriteLine("");

            IEnumerable<string> result = gameList.Select(word => word.ToUpper());
            foreach (var word in result)
            {
                Console.WriteLine($"{word}");
            }

            Console.WriteLine("");


            gameList = gameList.Where(word => word.Length < 8).ToList();
            foreach (var word in gameList)
            {
                Console.WriteLine($"{word}");
            }

            Console.WriteLine("");
        }

    }
}
//DONE - Fork and Clone the repository - Linq Repo to your local computer.
//DONE - Using Method Syntax, create a list of video games of your choice…
//DONE - Order the list of games by the length of the game’s names...
//DONE - Be sure to use the lambda expression in this exercise!
//DONE - Bonus - Try to use each of these methods on your list of video games
//DONE - Use the list of Linq methods for help

