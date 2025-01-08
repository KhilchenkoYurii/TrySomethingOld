// See https://aka.ms/new-console-template for more information
namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays (fixed length)
            //Rectangular array 
            //int[,] matrix = new int[3, 3];
            //int[,] matrix1 = new int[2, 2]
            //{
            //    {2,2 },
            //    {2,2 },
            //};
            //int element = matrix[0, 0];

            ////jagged array
            //int[][] jMatrix = new int[3][];
            //jMatrix[0] = new int[3];
            //jMatrix[1] = new int[2];
            //jMatrix[2] = new int[4];
            //int jElement = jMatrix[0][0];

            //int[] testArray = new int[5] { 1, 2, 3, 5, 1 };

            //Console.WriteLine("Length: " + testArray.Length);
            //Console.WriteLine("Index of 3: " + Array.IndexOf(testArray, 3));
            //Array.Sort(testArray);
            //foreach (int i in testArray)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Clear(testArray, 0, 2);
            //foreach (int i in testArray)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] anotherArray = new int[3];
            //Array.Copy(testArray, anotherArray, 3);
            //foreach (int i in anotherArray)
            //{
            //    Console.Write(i + ",");
            //}
            //Array.Reverse(anotherArray);
            //foreach (int i in anotherArray)
            //{
            //    Console.Write(i + ",");
            //}

            //Lists (dynamic length)
            //List<int> list = new List<int>();
            //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            //list.Add(1);
            //list1.AddRange([1, 2]);

            //foreach (int i in list1)
            //{
            //    Console.Write(i+",");
            //}
            //Console.WriteLine("\nIndex of 5: " + list1.IndexOf(5));
            //Console.WriteLine("Last index of 1: " + list1.LastIndexOf(1));
            //Console.WriteLine("Count: " + list1.Count());
            //list1.RemoveAll(x => x == 1);
            //foreach (int i in list1)
            //{
            //    Console.Write(i + ",");
            //}
            //list.Clear();

            //exercises

            //1
            //string input = "";
            //List<string> list = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Input name of friends who liked your post: ");
            //    input = Console.ReadLine();
            //    if (input == "")
            //        break;
            //    else
            //        list.Add(input);

            //}
            //switch (list.Count)
            //{
            //    case 0:
            //        Console.WriteLine("Nobody? So pity");
            //        break;
            //    case 1:
            //        Console.WriteLine("{0} likes your post.", list[0]);
            //        break;
            //    case 2:
            //        Console.WriteLine("{0} and {1} like your post.", list[0], list[1]);
            //        break;
            //    case 3:
            //        Console.WriteLine("{0}, {1} and {2} others like your post.", list[0], list[1], list.Count-2);
            //        break;
            //}

            //2
            //string name = "";
            //string reversedName = "";
            //Console.WriteLine("Please, enter your name: ");
            //name = Console.ReadLine();
            //foreach (char str in name.Reverse())
            //    reversedName += str;
            //Console.WriteLine("Your reversed name: "+ reversedName);

            //3
            //string input = "";
            //List<string> list = new List<string>();
            //while (list.Count!=5)
            //{
            //    Console.WriteLine("Input a number: ");
            //    input = Console.ReadLine();
            //    if (list.Contains(input))
            //    {
            //        Console.WriteLine("No! Input a unique number!");
            //        continue;
            //    }
            //    else
            //        list.Add(input);
            //}
            //list.Sort();
            //Console.WriteLine("Your sorted numbers: ");
            //foreach (string item in list)
            //    Console.Write(item + ",");

            //4
            //string input = "";
            //List<string> list = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Input a number or \'Quite\' to exit: ");
            //    input = Console.ReadLine();
            //    if (input == "Quite")
            //        break;
            //    else
            //        list.Add(input);
            //}
            //List<string> uniquList = new List<string>();
            //foreach (string element in list)
            //{
            //    if (uniquList.Contains(element))
            //        continue;
            //    else 
            //        uniquList.Add(element);
            //}
            //Console.WriteLine("Your unique numbers: ");
            //foreach (string item in uniquList)
            //    Console.Write(item + ",");

            //5
            //string input = "";
            //string[] list = [];
            //while (true)
            //{
            //    Console.WriteLine("Input numbers like this (e.g 5, 1, 9, 2, 10): ");
            //    input = Console.ReadLine();
            //    list = input.Split(", ");
            //    if (list.Length < 5)
            //        Console.WriteLine("Min length is 5!");
            //    else
            //        break;

            //}
            //List<int> newArray = new List<int>();
            //foreach (string s in list)
            //{
            //    newArray.Add(Convert.ToInt32(s));
            //}
            //newArray.Sort();
            //Console.WriteLine("The 3 smallets values: ");
            //for (int i = 0; i < 3; i++)
            //    Console.Write(newArray[i]+", ");

        }
        }
}
