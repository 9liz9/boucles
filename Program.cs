namespace S02_boucles;

class Program
{
    static void Main(string[] args)
    {
        string[] moves = new string[32];
        int currentIndex = 0;

        Console.WriteLine("Entrez les pas de danse (entrez 'done' pour terminer) :");

        string input = Console.ReadLine();
        while (input != "done" && currentIndex < 32)
        {
            moves[currentIndex] = input;
            currentIndex++;
            input = Console.ReadLine();
        }

        Console.WriteLine("Entrez le nombre d'itérations :");
        int iterations = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La suite de pas :");
        int moveCount = currentIndex;
        for (int i = 0; i < iterations; i++)
        {
            for (int j = 0; j < moveCount; j++)
            {
                Console.WriteLine(moves[j]);
            }
        }
    }

}
