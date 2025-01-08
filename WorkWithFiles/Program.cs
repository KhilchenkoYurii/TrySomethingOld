using System.Text;
using System;

namespace Solution
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of words: "+amountOfWordsInFile());
            Console.WriteLine("The longest word: " + theLongestWord());
        }

        public static void fileFileInfoExample()
        {
            string path = @"c:\something.jpg";
            if (!File.Exists(path))
            {
                File.Create(path);
                //File.Copy();
            }
            else
            {
                Console.WriteLine("not exist");
            }
            var content = File.ReadAllText(path);

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
            }
        }
        public static void directoryDirectoryInfoExample()
        {
            string path = @"c:\temp\folder1";
            Directory.CreateDirectory(path);
            string[] files = Directory.GetFiles(path);
            foreach (string fiel in files)
            {
                Console.WriteLine(fiel);
            }
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        public static void workWithPath()
        {
            string path = @"c:\temp\folder1\keksi1.jpg";

            Console.WriteLine("File name: "+Path.GetFileName(path)+
                "\nExtension: "+ Path.GetExtension(path)+
                "\nFile name without extension: " + Path.GetFileNameWithoutExtension(path)+
                "\nDirectory name: " + Path.GetDirectoryName(path));
        }

        public static int amountOfWordsInFile()
        {
            string path = @"C:\Users\yurii.khilchenko\Desktop\TextForExcercise1.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamReader stream = fileInfo.OpenText();
            string content = stream.ReadToEnd();
            string[] words = content.Split(' ');
            return words.Length;
        }

        public static string theLongestWord()
        {
            string path = @"C:\Users\yurii.khilchenko\Desktop\TextForExcercise1.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamReader stream = fileInfo.OpenText();
            string content = stream.ReadToEnd();
            string[] words = content.Split(' ');
            string theLongestWord = "";
            foreach (string word in words) { 
                if(word.Length > theLongestWord.Length) { theLongestWord = word; }
            }
            return theLongestWord;
        }
    }
}