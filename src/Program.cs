using System.Text;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("║           WELCOME TO            ║");
            Console.WriteLine("║       FUNCTION CHALLENGES       ║");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("╚═════════════════════════════════╝");
            // Challenge 1: String and Number Processor
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine("Challenge 1: String and Number Processor\n");
            Console.ForegroundColor = ConsoleColor.White;
            string result = StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            Console.WriteLine(result);

            // Challenge 2: Object Swapper
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n═════════════════════════════════");
            Console.WriteLine("Challenge 2: Object Swapper\n");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";
            bool bool1 = true;
            bool bool2 = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(SwapObjects(ref num1, ref num2));
            Console.WriteLine(SwapObjects(ref num3, ref num4));
            Console.WriteLine(SwapObjects(ref str1, ref str2));
            Console.WriteLine(SwapObjects(ref str3, ref str4));
            Console.WriteLine(SwapObjects(ref bool1, ref bool2));

            // Challenge 3: Guessing Game
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n═════════════════════════════════");
            Console.WriteLine("Challenge 3: Guessing Game\n");
            Console.ForegroundColor = ConsoleColor.White;
            GuessingGame();

            // Challenge 4: Simple Word Reversal
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n═════════════════════════════════");
            Console.WriteLine("Challenge 4: Simple Word Reversal\n");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(reversed);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔═════════════════════════════════╗");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("║            FINISHED             ║");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("╚═════════════════════════════════╝");
        }
        static string StringNumberProcessor(params object[] values)
        {
            int sum = 0;
            string concatenatedString = "";
            foreach (var value in values)
            {
                if (value.GetType() == typeof(string))// if (value is string a){concatenatedString+=a;}
                {
                    concatenatedString += value.ToString() + " ";
                }
                if (value.GetType() == typeof(int))
                {
                    sum += Convert.ToInt32(value);
                }
            }
            return $"{concatenatedString} ; {sum}";
        }
        static string SwapObjects<T>(ref T value1, ref T value2)
        {
            T temp;
            if (value1 is string s1 && value2 is string s2)
            {
                if (s1.Length < 5 || s2.Length < 5)
                {
                    return "Length must be more than 5";
                }
                temp = value1;
                value1 = value2;
                value2 = temp;
                return $"value1 : {value1} value2 : {value2}";
            }
            if (value1 is int n1 && value2 is int n2)
            {
                if (n1 < 18 || n2 < 18)
                {
                    return " Value must be more than 18";
                }
                temp = value1;
                value1 = value2;
                value2 = temp;
                return $"value1 : {value1} value2 : {value2}";
            }
            return "NOT SUPPORTED TYPE";
        }
        static void GuessingGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            Console.WriteLine("Guess a number between 1 - 10 or `Quit` to stop :");
            string? input = Console.ReadLine();
            int.TryParse(input, out int guessing);
            while (num != guessing)
            {
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("OK BYEE ^.^");
                    break;
                }
                if (num == guessing)
                {
                    Console.WriteLine("YAAYYY!! YOU GUESSED RIGHT");
                    break;
                }
                if (!int.TryParse(input, out int n))
                {
                    Console.WriteLine("YOU DID NOT ENTER A NUMBER:(\nEnter number please :");
                    input = Console.ReadLine();
                    int.TryParse(input, out guessing);
                    continue;
                }
                Console.WriteLine("Oops!! Wrong guess, try again or `Quit` to stop :");
                input = Console.ReadLine();
                int.TryParse(input, out guessing);
            }
            if (num == guessing) Console.WriteLine("YAAYYY!! YOU GUESSED RIGHT");
        }
        static string ReverseWords(string str)
        {
            string[] sentense = str.Split(" ");
            StringBuilder newStr = new StringBuilder();
            foreach (var word in sentense)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                letters.ToString();
                newStr.Append(letters);
                newStr.Append(" ");
            }
            string newString = newStr.ToString();
            return newString;
        }

    }
}
