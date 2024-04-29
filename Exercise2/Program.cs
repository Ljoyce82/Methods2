using System.Globalization;
using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Goblin Bank's adding machine\n");

            Console.WriteLine("Please select your magic + , - , * , / ");

            string? op = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Please enter your gold amounts? Seperate With Comma or goblins will go MAD!");

            string? numbers = Console.ReadLine();

            int result = calculation(op, numbers);

            Console.WriteLine("Result:  " + result);
        }

        static int calculation(string op, string numbers)
        {
            int result = (0);
            string[] numArray = numbers.Split(',');
            switch (op)
            {
                case "+":
                    foreach (string num1 in numArray)
                    {
                        if (int.TryParse(num1, out int num))
                            result += num;
                    }
                    break;

                case "-":
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        if (int.TryParse(numArray[i], out int num))
                            Console.WriteLine(num);
                        result -= num;
                    }
                    break;

                case "*":
                    result = 1;
                    foreach (string num2 in numArray)
                    {
                        if (int.TryParse(num2, out int num))
                            result *= num;
                    }
                    break;

                case "/":
                    if (int.TryParse(numArray[0], out int firstNum) && firstNum != 0)
                    {
                        result = firstNum;
                        for (int i = 1; i < numArray.Length; i++)
                        {
                            if (int.TryParse(numArray[i], out int num) && num != 0)
                            {
                                result /= num;
                            }
                            else
                            {
                                Console.WriteLine("Can't get gold that way! You have nothing.");
                                return 0;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Can't get gold that way! You have nothing.");
                        return 0;
                    }
                    break;

                default:

                    Console.WriteLine("Don't Confuse the goblins!");
                    break;

            }

            return result;
        }

    }
}