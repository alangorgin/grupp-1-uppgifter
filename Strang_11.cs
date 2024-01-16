public class Strang_11
{
    public static void Start()
    {
        // Strängar uppgift 11
        Console.WriteLine("Enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            Random random = new Random();
            char randomLetter = (char)('A' + random.Next(0, 26));
            Console.Write(randomLetter);
        }
    }
}