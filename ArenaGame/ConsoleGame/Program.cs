using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0, threeWins = 0, fourWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Knight("Sir Lancelot");
                Hero two = new Rogue("Robih Hood");
                Hero three = new Gladiator("Conan");
                Hero four = new Seeker("Leon Smith");

                Console.WriteLine($"Arena fight between: {one.Name}, {two.Name}, {three.Name} and {four.Name}");
                
                Arena arena1 = new Arena(one, two);
                Hero winner1 = arena1.Battle();
                Console.WriteLine($"Winner of first battle is: {winner1.Name}");

                Arena arena2 = new Arena(three, four);
                Hero winner2 = arena2.Battle();
                Console.WriteLine($"Winner of second battle is: {winner2.Name}");

                Arena finalArena = new Arena(winner1, winner2);
                Hero finalWinner = finalArena.Battle();
                Console.WriteLine($"Final Winner is: {finalWinner.Name}");

                if (finalWinner == one) oneWins++;
                else if (finalWinner == two) twoWins++;
                else if (finalWinner == three) threeWins++;
                else if (finalWinner == four) fourWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"Knight has {oneWins} wins.");
            Console.WriteLine($"Rogue has {twoWins} wins.");
            Console.WriteLine($"Gladiator has {threeWins} wins.");
            Console.WriteLine($"Seeker has {fourWins} wins.");

            Console.ReadLine();
        }
    }
}
