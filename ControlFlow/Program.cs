// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // statements
            //bool condition = true;
            //byte condition2 = 3;
            //if (condition)
            //{

            //}
            //else if (true && condition)
            //{
            //}
            //else
            //{
            //}
            //switch (condition2)
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    default:
            //        break;
            //}

            //float price = (condition) ? 1 : 0;

            //excercises

            //1
            //Console.WriteLine("Input from 1 to 10");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 1 && number <= 10)
            //{
            //    Console.WriteLine("Correct number");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect number!");
            //}

            //2
            //Console.WriteLine("Input first value");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second value");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //string result = (number1 > number2) ? "First value bigger" : "Second value bigger";
            //Console.WriteLine(result);

            //3
            //Console.WriteLine("Input width of painting");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input height of painting");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //string result = (number1 > number2) ? "It is a landscape" : "It is a portrait";
            //Console.WriteLine(result);

            //4
            //Console.WriteLine("Input speed limit");
            //int limit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input car`s speed");
            //int carSpeed = Convert.ToInt32(Console.ReadLine());
            //if (carSpeed < limit)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    int points = (carSpeed - limit)/5;
            //    if (points >= 12)
            //    {
            //        Console.WriteLine("Suspended license");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your points is {0}", points);
            //    }
            //}

            //loops
            //int[] numbers = new int[5] {1,2,3,4,5};
            //for (int i = 0; i < 10; i++) { 
            //    Console.WriteLine(i);
            //}
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //    if (number == 1)
            //    {
            //        Console.WriteLine("Break");
            //        break;
            //    }
            //}
            //while (numbers[4] != 0)
            //{
            //    numbers[4]--;
            //    Console.WriteLine("While "+ numbers[4]);
            //}
            //do
            //{
            //    ++numbers[3];
            //    if (numbers[3] == 5)
            //    {
            //        Console.WriteLine("Continue");
            //        continue;
            //    }

            //} while (numbers[3] < 5);

            //Random class
            //var random = new Random();
            //const int passwordLength = 10;
            //var buffer = new char[passwordLength];
            //for (int i = 0; i < passwordLength; i++)
            //{
            //    buffer[i] = (char)('a'+random.Next(0, 26));
            //}
            //var password = new string(buffer);
            //Console.WriteLine(password);

            //excercises 2

            //1
            //int count = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0) { 
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //2
            //string input = "";
            //int result = 0;
            //while (true)
            //{
            //    Console.WriteLine("Input number or ok for exit");
            //    input = Console.ReadLine();
            //    if (input == "ok")
            //    {
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    }
            //    else
            //    {
            //        result += Convert.ToInt32(input);
            //    }
            //}

            //3
            //Console.WriteLine("Input a number:");
            //int input = Convert.ToInt32(Console.ReadLine());
            //double result = 1;
            //for (int i = 2; i <= input; i++) {
            //    result *= i;
            //}
            //Console.WriteLine(input+"!="+result);

            //4
            //Console.WriteLine("We wonder number from 1 to 10 \n Try to guess, input a number:");
            //Random randomizer = new Random();
            //int rightNumber = randomizer.Next(1, 10);
            //int tries = 4;
            //while (tries > 0)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input == rightNumber)
            //    {
            //        Console.WriteLine("Congrats! You guess it!");
            //        break;
            //    }
            //    else
            //    {
            //        tries--;
            //        if (tries == 0)
            //        {
            //            Console.WriteLine("Ha ha, you lose!");
            //            break;
            //        }
            //        Console.WriteLine("No, try again!");

            //    }
            //}


            //5
            //Console.WriteLine("Please input numbers separated by comma: ");
            //string input = Console.ReadLine();
            //string[] numbers = input.Split(", ");
            //int max = 0;
            //foreach (string number in numbers) {

            //    if (Convert.ToInt32(number) > max) { 
            //        max = Convert.ToInt32(number);
            //    }
            //}
            //Console.WriteLine("Max value: "+max);






        }
    }
}