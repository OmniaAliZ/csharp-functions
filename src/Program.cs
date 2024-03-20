using System.Text;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor"); //? DONE
            string result = StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            Console.WriteLine(result);
            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";

            Console.WriteLine(SwapObjects(ref num1, ref num2)); // Expected outcome: num1 = 30, num2 = 25  
            Console.WriteLine(SwapObjects(ref num3, ref num4)); // Error: Value must be more than 18

            Console.WriteLine(SwapObjects(ref str1, ref str2)); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            Console.WriteLine(SwapObjects(ref str3, ref str4)); // Error: Length must be more than 5

            //    SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, ref str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game"); //? DONE
            // Uncomment to test the GuessingGame method
            // GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal"); //? DONE
            // string sentence = "This is the original sentence!";
            // string reversed = ReverseWords(sentence);
            // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }
        static string StringNumberProcessor(params object[] values)
        {
            int sum = 0;
            string concatenatedString = "";
            foreach (var value in values)
            {
                if (value.GetType() == typeof(string))
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
            if (typeof(T) != typeof(string) || typeof(T) != typeof(int))
            {
                return "NOT SUPPORTED TYPE";
            }
            if (typeof(T) == typeof(string))
            {
                if (value1.ToString().Length <= 5 || value2.ToString().Length <= 5)
                {
                    temp = value1;
                    value1 = value2;
                    value2 = temp;
                    return $"value1 : {value1} value2 : {value2}";
                }
            }
            if (typeof(T) == typeof(int))
            {
                if (Convert.ToInt32(value1) < 18 || Convert.ToInt32(value1) < 18)
                {
                    temp = value1;
                    value1 = value2;
                    value2 = temp;
                    return $"value1 : {value1} value2 : {value2}";
                }
            }
            return "SOMTHING WRONG";
        }
        static void GuessingGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            Console.WriteLine("Guess a number between 1 - 10 or `Quit` to stop :");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int guessing))
            {
                while (guessing != num)
                {
                    if (input.ToLower() == "quit")
                    {
                        System.Console.WriteLine("OK BYEE ^.^");
                        break;
                    }
                    if (int.TryParse(input, out guessing))
                    {
                        Console.WriteLine("Oops!! Wrong guess, try again or `Quit` to stop :");
                        input = Console.ReadLine();
                    }
                    if (guessing == num)
                    {
                        Console.WriteLine("YAAYYY!! YOU GUESSED RIGHT");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Guess a number please  or `Quit` to stop :");
                        input = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("YOU DID NOT ENTER A NUMBER:(");
            }
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
