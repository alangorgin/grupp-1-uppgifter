public class Grund_13
{
    public static void Start()
    {
        // Grunder uppgift 13
        // Hangman
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Guess the word!");

        String randomizedWord = GenerateRandomWord();
        int amountOfLetters = randomizedWord.Length;
        char[] guessedLetters = new string('*', amountOfLetters).ToCharArray();

        int lives = 10;
        bool won = false;

        while (lives > 0 && !won)
        {
            Console.WriteLine($"\n{new string(guessedLetters)}");
            Console.WriteLine($"Lives left: {lives}");

            char guessedLetter = Console.ReadKey().KeyChar;

            if (randomizedWord.Contains(guessedLetter))
            {
                for (int i = 0; i < randomizedWord.Length; i++)
                {
                    if (randomizedWord[i] == guessedLetter)
                    {
                        guessedLetters[i] = guessedLetter;
                    }
                }

                won = !guessedLetters.Contains('*');
            }
            else
            {
                Console.WriteLine("\nIncorrect guess.");
                lives--;
            }
        }

        if (won)
        {
            Console.Beep();
            Console.WriteLine("Congratulations! You've guessed the word!");
        }
        else
        {
            Console.WriteLine("Game over!");
            Console.WriteLine($"The word was: {randomizedWord}.");
        }
    }

    private static string GenerateRandomWord()
    {
        List<string> words = ["Stockholm", "Copenhagen", "Reykjavik"];

        Random random = new Random();
        int index = random.Next(words.Count);
        String randomizedWord = words[index];

        return randomizedWord;
    }
}